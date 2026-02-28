#include "pch.h"
#include "Printer.h"
#include "Engine/UClass.h"
#include "Engine/UProperty.h"
#include "Engine/UEnum.h"
#include "Engine/UFunction.h"

#include <map>

int Printer::IndentLevel = 0;

void Printer::PrintFile(ClassNode* classNode, ostream& out, ClassGraph* graph)
{
    // Print preprocessor directives
    Printer::Indent(out) << "#pragma warning disable CS0108" << endl;
    Printer::Indent(out) << "#pragma warning disable CS1591" << endl;
    out << endl;

    // Print namespace declaration (using pre-computed value)
    Printer::Indent(out) << "namespace " << classNode->packageNameManaged << ";" << endl;
    out << endl;

    // Print class declaration
    Printer::PrintClass(classNode, out, graph);
}

void Printer::PrintClass(ClassNode* classNode, ostream& out, ClassGraph* graph)
{
    auto _class = reinterpret_cast<UClass*>(classNode->ptr);

    // Print class comment
    Printer::Indent(out) << "/// <summary>" << endl;
    Printer::Indent(out) << "/// ";
    if (classNode->isAbstract)
    {
        out << "ABSTRACT ";
    }
    Printer::Indent(out) << "Class: " << classNode->managedName << "<br/>" << endl;
    Printer::Indent(out) << "/// (size = " << _class->PropertiesSize << ")" << endl;
    Printer::Indent(out) << "/// (flags = " << (DWORD)_class->ClassFlags << ")" << endl;
    Printer::Indent(out) << "/// </summary>" << endl;

    // Print class declaration (using pre-computed values)
    Printer::Indent(out) << "public partial class " << classNode->managedName << " : ";
    if (_class->SuperStruct)
    {
        auto superNode = graph->GetStructNode(_class->SuperStruct);
        if (superNode)
        {
            out << superNode->managedPathName << ", ";
        }
    }
    out << "BmSDK.IGameObject" << endl;

    // Print class body
    Printer::Indent(out) << "{" << endl;
    Printer::PushIndent();
    {
        // Print StaticClass() helper
        Printer::Indent(out) << "static BmSDK.Class s_staticClass = null;" << endl;
        Printer::Indent(out) << "public static BmSDK.Class StaticClass()" << endl;
        Printer::Indent(out) << "{" << endl;
        Printer::PushIndent();
        {
            Printer::Indent(out) << "if (s_staticClass is null)" << endl;
            Printer::Indent(out) << "{" << endl;
            Printer::PushIndent();
            {
                // Use pre-computed pathName
                Printer::Indent(out)
                    << "s_staticClass = StaticFindObjectChecked<Class>(null, null, \""
                    << classNode->pathName << "\", false);" << endl;
                Printer::Indent(out) << "s_staticClass.AddToRoot();" << endl;
            }
            Printer::PopIndent();
            Printer::Indent(out) << "}" << endl;

            Printer::Indent(out) << "return s_staticClass;" << endl;
        }
        Printer::PopIndent();
        Printer::Indent(out) << "}" << endl;

        out << endl;

        // Print internal ctor
        Printer::Indent(out) << "internal " << classNode->managedName << "() { }" << endl << endl;

        // Print main ctor (unless abstract)
        if (!classNode->isAbstract)
        {
            Printer::Indent(out) << "/// <summary>" << endl;
            Printer::Indent(out) << "/// Constructs a new " << classNode->managedName << endl;
            Printer::Indent(out) << "/// </summary>" << endl;
            Printer::Indent(out)
                << "public " << classNode->managedName
                << "(BmSDK.GameObject Outer, string Name = null, "
                   "BmSDK.GameObject.EObjectFlags SetFlags = 0, "
                << classNode->managedName
                << " Template = null) : base(ConstructObjectInternal(StaticClass(), "
                   "Outer, Name, SetFlags, Template)) { }"
                << endl
                << endl;
        }

        // Print pointer ctor
        Printer::Indent(out) << "/// <summary>" << endl;
        Printer::Indent(out)
            << "/// Constructs a new wrapper instance from the given object pointer." << endl;
        Printer::Indent(out) << "/// </summary>" << endl;
        Printer::Indent(out) << "protected " << classNode->managedName << "(nint ptr)";
        if (_class->GetName() == "Object")
        {
            out << " { Ptr = ptr; }" << endl;
        }
        else
        {
            out << " : base(ptr) { }" << endl;
        }
        out << endl;

        // Use pre-computed isActor instead of walking SuperStruct
        if (classNode->isActor)
        {
            Printer::PrintScHelpers(classNode, out);
        }

        // Print fields using pre-computed children vector
        for (auto childNode : classNode->children)
        {
            // Don't print any members for intrinsic classes
            if (classNode->isIntrinsic)
            {
                break;
            }

            if (auto propNode = dynamic_cast<PropertyNode*>(childNode))
            {
                Printer::PrintProperty(propNode, out, graph);
                out << endl;
            }
            else if (auto enumNode = dynamic_cast<EnumNode*>(childNode))
            {
                Printer::PrintEnum(enumNode, out);
                out << endl;
            }
            else if (auto structNode = dynamic_cast<StructNode*>(childNode))
            {
                auto field = reinterpret_cast<UField*>(childNode->ptr);
                if (field->IsA(UScriptStruct::StaticClass()))
                {
                    Printer::PrintStruct(structNode, out, graph);
                    out << endl;
                }
                else if (field->IsA(UFunction::StaticClass()))
                {
                    Printer::PrintFunction(structNode, out, graph);
                    out << endl;
                }
            }
        }
    }
    Printer::PopIndent();
    Printer::Indent(out) << "}" << endl;
}

void Printer::PrintScHelpers(ClassNode* classNode, ostream& out)
{
    auto type = classNode->managedName;
    Printer::PrintScHelper("void", "AttachScriptComponent", false, false, false, type, out);
    Printer::PrintScHelper("TComponent", "AttachScriptComponent", true, true, true, type, out);
    Printer::PrintScHelper("bool", "HasScriptComponent", false, false, false, type, out);
    Printer::PrintScHelper("bool", "HasScriptComponent", true, false, false, type, out);
    Printer::PrintScHelper("TComponent", "GetScriptComponent", true, false, true, type, out);
    Printer::PrintScHelper("void", "DetachScriptComponent", false, false, false, type, out);
    Printer::PrintScHelper("void", "DetachScriptComponent", true, false, false, type, out);
}

void Printer::PrintScHelper(
    string returnType,
    string helper,
    bool generic,
    bool ctor,
    bool cast,
    string type,
    ostream& out)
{
    if (generic)
    {
        Printer::Indent(out) << "/// <inheritdoc cref=\"Engine.Actor." << helper << "(Type)\"/>"
                            << endl;
        Printer::Indent(out) << "public " << returnType << " " << helper << "<TComponent>()" << endl;
        Printer::PushIndent();
        Printer::Indent(out) << "where TComponent : class, Framework.IScriptComponent<" << type
                            << ">" << (ctor ? ", new()" : "") << endl;
        Printer::Indent(out) << "=> " << (cast ? "(TComponent)" : "") << "((Engine.Actor)this)."
                            << helper << "(typeof(TComponent));" << endl;
        Printer::PopIndent();
        out << endl;
    }
    else
    {
        Printer::Indent(out) << "/// <inheritdoc cref=\"Engine.Actor." << helper
                            << "(Framework.IScriptComponent)\"/>" << endl;
        Printer::Indent(out) << "public " << returnType << " " << helper
                            << "<TComponent>(TComponent component)" << endl;
        Printer::PushIndent();
        Printer::Indent(out) << "where TComponent : class, Framework.IScriptComponent<" << type
                            << ">" << endl;
        Printer::Indent(out) << "=> ((Engine.Actor)this)." << helper
                            << "((Framework.IScriptComponent)component);" << endl;
        Printer::PopIndent();
        out << endl;
    }
}

void Printer::PrintStruct(StructNode* structNode, ostream& out, ClassGraph* graph)
{
    auto _struct = reinterpret_cast<UScriptStruct*>(structNode->ptr);

    // Print struct comment
    Printer::Indent(out) << "/// <summary>" << endl;
    Printer::Indent(out) << "/// Struct: " << structNode->managedName << endl;
    Printer::Indent(out) << "/// </summary>" << endl;

    // Print struct declaration
    Printer::Indent(out) << "[StructLayout(LayoutKind.Explicit, Size = " << _struct->PropertiesSize
                        << ")]" << endl;
    Printer::Indent(out) << "public partial record struct " << structNode->managedName << endl;

    // Print struct body
    Printer::Indent(out) << "{" << endl;
    Printer::PushIndent();
    {
        // Use pre-computed children vector
        for (auto childNode : structNode->children)
        {
            if (auto propNode = dynamic_cast<PropertyNode*>(childNode))
            {
                Printer::PrintProperty(propNode, out, graph);
                out << endl;
            }
        }
    }
    Printer::PopIndent();
    Printer::Indent(out) << "}" << endl;
}

void Printer::PrintEnum(EnumNode* enumNode, ostream& out)
{
    // Print enum comment
    Printer::Indent(out) << "/// <summary>" << endl;
    Printer::Indent(out) << "/// Enum: " << enumNode->ptr->GetName() << endl;
    Printer::Indent(out) << "/// </summary>" << endl;

    // Print enum declaration
    Printer::Indent(out) << "public enum " << enumNode->managedName << endl;

    // Print enum body using pre-computed resolved names
    Printer::Indent(out) << "{" << endl;
    Printer::PushIndent();
    {
        for (auto i = 0u; i < enumNode->resolvedNames.size(); i++)
        {
            Printer::Indent(out) << enumNode->resolvedNames.at(i) << " = " << i << "," << endl;
        }
    }
    Printer::PopIndent();
    Printer::Indent(out) << "}" << endl;
}

void Printer::PrintProperty(PropertyNode* propNode, ostream& out, ClassGraph* graph)
{
    auto prop = reinterpret_cast<UProperty*>(propNode->ptr);

    // Print prop comment
    Printer::Indent(out) << "/// <summary>" << endl;
    Printer::Indent(out) << "/// " << prop->Class->GetName() << ": " << prop->GetName() << endl;
    Printer::Indent(out) << "/// </summary>" << endl;

    // Print prop declaration (using pre-computed innerTypeName and managedName)
    Printer::Indent(out) << "public unsafe " << propNode->innerTypeName << " " << propNode->managedName
                        << endl;

    // Print prop body
    Printer::Indent(out) << "{" << endl;
    Printer::PushIndent();
    {
        // Print prop getter (single line)
        Printer::Indent(out) << "get { ";
        {
            bool isInStruct = !prop->Outer->IsA(UClass::StaticClass());

            // Make Ptr available locally so we can reuse the same getter code
            if (isInStruct)
            {
                out << "fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; ";
            }

            // Booleans (stored as bitmasks) need special handling
            if (propNode->kind == PropertyKind::Bool)
            {
                out << "return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + " << prop->Offset
                    << ") & " << propNode->bitMask << ") != 0;";
            }
            else
            {
                out << "return BmSDK.Framework.MarshalUtil.ToManaged<" << propNode->innerTypeName
                    << ">(Ptr + " << prop->Offset << ");";
            }

            if (isInStruct)
            {
                out << " };";
            }
        }
        out << " }" << endl;

        // Print prop setter (single line)
        Printer::Indent(out) << "set { ";
        {
            bool isInStruct = !prop->Outer->IsA(UClass::StaticClass());

            // Make Ptr available locally so we can reuse the same setter code
            if (isInStruct)
            {
                out << "fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; ";
            }

            // Booleans (stored as bitmasks) need special handling
            if (propNode->kind == PropertyKind::Bool)
            {
                out << "var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + "
                    << prop->Offset << ");";
                out << " var newMask = value ? (currentMask | " << propNode->bitMask
                    << ") : (currentMask & ~" << propNode->bitMask << ");";

                out << " BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + " << prop->Offset
                    << ");";
            }
            else
            {
                out << "BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + " << prop->Offset << ");";
            }

            if (isInStruct)
            {
                out << " };";
            }
        }
        out << " }" << endl;
    }
    Printer::PopIndent();
    Printer::Indent(out) << "}" << endl;
}

void Printer::PrintFunction(StructNode* funcNode, ostream& out, ClassGraph* graph)
{
    auto func = reinterpret_cast<UFunction*>(funcNode->ptr);

    vector<PropertyNode*> params;
    PropertyNode* returnParam = nullptr;

    // Skip operator and iterator functions
    if (((DWORD)func->FunctionFlags & (DWORD)EFunctionFlags::FUNC_Operator) ||
        ((DWORD)func->FunctionFlags & (DWORD)EFunctionFlags::FUNC_Iterator))
    {
        return;
    }

    // Gather func info
    bool funcIsStatic = (DWORD)func->FunctionFlags & (DWORD)EFunctionFlags::FUNC_Static;
    bool funcIsNative = (DWORD)func->FunctionFlags & (DWORD)EFunctionFlags::FUNC_Native;
    bool funcIsEvent = (DWORD)func->FunctionFlags & (DWORD)EFunctionFlags::FUNC_Event;

    // Gather func params from pre-computed children
    for (auto childNode : funcNode->children)
    {
        if (auto propNode = dynamic_cast<PropertyNode*>(childNode))
        {
            auto prop = reinterpret_cast<UProperty*>(propNode->ptr);
            if ((QWORD)prop->PropertyFlags & (QWORD)EPropertyFlags::CPF_ReturnParm)
            {
                returnParam = propNode;
            }
            else if ((QWORD)prop->PropertyFlags & (QWORD)EPropertyFlags::CPF_Parm)
            {
                params.push_back(propNode);
            }
        }
    }

    bool shouldSuppressOptional = false;
    for (auto propNode : params)
    {
        auto prop = reinterpret_cast<UProperty*>(propNode->ptr);

        // C# doesn't support optional out params
        if (((QWORD)prop->PropertyFlags & (QWORD)EPropertyFlags::CPF_OptionalParm) &&
            ((QWORD)prop->PropertyFlags & (QWORD)EPropertyFlags::CPF_OutParm))
        {
            shouldSuppressOptional = true;
            break;
        }
    }

    // Print func comment
    Printer::Indent(out) << "/// <summary>" << endl;
    Printer::Indent(out) << "/// Function: " << func->GetName() << endl;
    Printer::Indent(out) << "/// </summary>" << endl;

    // Print func declaration
    Printer::Indent(out) << "public unsafe ";
    if (funcIsStatic)
    {
        out << "static ";
    }
    out << (returnParam ? returnParam->innerTypeName : "void") << " ";
    out << funcNode->managedName << "(";
    for (auto i = 0u; i < params.size(); i++)
    {
        auto propNode = params[i];
        auto prop = reinterpret_cast<UProperty*>(propNode->ptr);

        // "out" keyword for out params
        if ((QWORD)prop->PropertyFlags & (QWORD)EPropertyFlags::CPF_OutParm)
        {
            out << "out ";
        }

        // Print param declaration
        out << propNode->innerTypeName << " " << propNode->managedName;
        if (((QWORD)prop->PropertyFlags & (QWORD)EPropertyFlags::CPF_OptionalParm) &&
            !shouldSuppressOptional)
        {
            out << " = default";
        }

        if (i < params.size() - 1)
        {
            out << ", ";
        }
    }
    out << ")" << endl;

    // Print func body
    Printer::Indent(out) << "{" << endl;
    Printer::PushIndent();
    {
        string ptrText = funcIsStatic ? "StaticClass().DefaultObject.Ptr" : "Ptr";

        Printer::Indent(out) << "var funcManaged = "
                               "BmSDK.GameObject.StaticFindObjectChecked<BmSDK."
                               "Function>(BmSDK.Function.StaticClass(), null, \""
                            << funcNode->pathName << "\", true);" << endl;

        Printer::Indent(out) << "byte* paramsPtr = stackalloc byte[" << func->PropertiesSize << "];"
                            << endl;
        for (auto propNode : params)
        {
            auto prop = reinterpret_cast<UProperty*>(propNode->ptr);

            // Don't marshal in 'out' params
            if ((QWORD)prop->PropertyFlags & (QWORD)EPropertyFlags::CPF_OutParm)
            {
                continue;
            }

            // Print
            Printer::Indent(out) << "BmSDK.Framework.MarshalUtil.ToUnmanaged(" << propNode->managedName
                                << ", paramsPtr + " << prop->Offset << ");" << endl;
        }

        if (funcIsNative)
        {
            Printer::Indent(out) << "var oldFlags = funcManaged.FunctionFlags;" << endl;
            Printer::Indent(out) << "var oldNative = funcManaged.iNative;" << endl;
            Printer::Indent(out)
                << "funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;" << endl;
            Printer::Indent(out)
                << "funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;" << endl;
            Printer::Indent(out) << "funcManaged.iNative = 0;" << endl;
        }

        Printer::Indent(out) << "BmSDK.Framework.GameFunctions.ProcessEvent(" << ptrText
                            << ", funcManaged.Ptr, (nint)paramsPtr, 0);" << endl;

        if (funcIsNative)
        {
            Printer::Indent(out) << "funcManaged.iNative = oldNative;" << endl;
            Printer::Indent(out) << "funcManaged.FunctionFlags = oldFlags;" << endl;
        }

        // Marshal/assign out params
        for (auto propNode : params)
        {
            auto prop = reinterpret_cast<UProperty*>(propNode->ptr);

            if ((QWORD)prop->PropertyFlags & (QWORD)EPropertyFlags::CPF_OutParm)
            {
                Printer::Indent(out) << propNode->managedName
                                    << " = BmSDK.Framework.MarshalUtil.ToManaged<"
                                    << propNode->innerTypeName << ">(paramsPtr + " << prop->Offset
                                    << ");" << endl;
            }
        }

        if (returnParam != nullptr)
        {
            auto prop = reinterpret_cast<UProperty*>(returnParam->ptr);
            // Print return param declaration
            Printer::Indent(out) << "return BmSDK.Framework.MarshalUtil.ToManaged<"
                                << returnParam->innerTypeName << ">(paramsPtr + " << prop->Offset
                                << ");" << endl;
        }
        else
        {
            Printer::Indent(out) << "return;" << endl;
        }
    }
    Printer::PopIndent();
    Printer::Indent(out) << "}" << endl;
}

void Printer::PrintStaticInit(const vector<ClassNode*>& classes, ostream& out, ClassGraph* graph)
{
    // Print usings
    Printer::Indent(out) << "using System.Collections.Generic;" << endl;
    out << endl;
    Printer::Indent(out) << "namespace BmSDK.Framework;" << endl;
    out << endl;

    // Print class declaration
    Printer::Indent(out) << "static partial class StaticInit" << endl;
    Printer::Indent(out) << "{" << endl;
    Printer::PushIndent();
    {
        // Print props
        Printer::Indent(out) << "static Dictionary<string, Type> _classPathToManagedTypeMap = [];"
                            << endl;
        Printer::Indent(out) << "static Dictionary<Type, string> _managedTypeToClassPathMap = [];"
                            << endl;
        out << endl;

        // Print StaticInitClasses()
        Printer::Indent(out) << "public static void StaticInitClasses()" << endl;
        Printer::Indent(out) << "{" << endl;
        Printer::PushIndent();
        {
            for (auto classNode : classes)
            {
                // Use pre-computed values
                Printer::Indent(out) << "_classPathToManagedTypeMap[\"" << classNode->pathName
                                    << "\"] = typeof(" << classNode->managedPathName << ");" << endl;

                Printer::Indent(out) << "_managedTypeToClassPathMap[typeof("
                                    << classNode->managedPathName << ")] = \"" << classNode->pathName
                                    << "\";" << endl;
            }
        }
        Printer::PopIndent();
        Printer::Indent(out) << "}" << endl;
    }
    Printer::PopIndent();
    Printer::Indent(out) << "}" << endl;
}
