#include "pch.h"
#include "Printer.h"
#include "Engine/UClass.h"
#include "Engine/UProperty.h"
#include "Engine/UEnum.h"
#include "Engine/UFunction.h"

#include <map>

int Printer::IndentLevel = 0;

void Printer::PrintFile(UClass* _class, ostream& out)
{
    // Print preprocessor directives
    Printer::Indent(out) << "#pragma warning disable CS0108" << endl;
    Printer::Indent(out) << "#pragma warning disable CS1591" << endl;
    out << endl;

    // Print namespace declaration
    Printer::Indent(out) << "namespace " << _class->GetPackageNameManaged() << ";" << endl;
    out << endl;

    // Print type
    if (_class->Class->GetPathName() == "Core.Interface")
    {
        // Print interface declaration
        Printer::PrintInterface(_class, out);
    }
    else
    {
        // Print class declaration
        Printer::PrintClass(_class, out);
    }
}

void Printer::PrintInterface(class UClass* _class, ostream& out)
{
    // Print interface comment
    Printer::Indent(out) << "/// <summary>" << endl;
    Printer::Indent(out) << "/// Interface: " << _class->GetNameManaged() << "<br/>" << endl;
    Printer::Indent(out) << "/// (size = " << _class->PropertiesSize << ")" << endl;
    Printer::Indent(out) << "/// (flags = " << (DWORD)_class->ClassFlags << ")" << endl;
    Printer::Indent(out) << "/// </summary>" << endl;

    // Print interface declaration
    Printer::Indent(out) << "public partial interface " << _class->GetNameManaged();
    if (_class->SuperStruct)
    {
        out << " : " << _class->SuperStruct->GetPathNameManaged();
    }
    out << endl;

    // Print interface body
    Printer::Indent(out) << "{" << endl;
    Printer::PushIndent();
    {
        // Print fields
        UField* fieldLink = _class->Children;
        for (UField* fieldLink = _class->Children; fieldLink; fieldLink = fieldLink->Next)
        {
            if (fieldLink->IsA(UEnum::StaticClass()))
            {
                Printer::PrintEnum((UEnum*)fieldLink, out);

                if (fieldLink->Next)
                {
                    out << endl;
                }
            }
            else if (fieldLink->IsA(UScriptStruct::StaticClass()))
            {
                Printer::PrintStruct((UScriptStruct*)fieldLink, out);

                if (fieldLink->Next)
                {
                    out << endl;
                }
            }
            else if (fieldLink->IsA(UFunction::StaticClass()))
            {
                Printer::PrintFunction((UFunction*)fieldLink, out);

                if (fieldLink->Next)
                {
                    out << endl;
                }
            }
        }
    }
    Printer::PopIndent();
    Printer::Indent(out) << "}" << endl;
}

void Printer::PrintClass(UClass* _class, ostream& out)
{
    // Print class comment
    Printer::Indent(out) << "/// <summary>" << endl;
    Printer::Indent(out) << "/// ";
    if ((DWORD)_class->ClassFlags & (DWORD)EClassFlags::CLASS_Abstract)
    {
        out << "ABSTRACT ";
    }
    Printer::Indent(out) << "Class: " << _class->GetNameManaged() << "<br/>" << endl;
    Printer::Indent(out) << "/// (size = " << _class->PropertiesSize << ")" << endl;
    Printer::Indent(out) << "/// (flags = " << (DWORD)_class->ClassFlags << ")" << endl;
    Printer::Indent(out) << "/// </summary>" << endl;

    // Print class declaration
    Printer::Indent(out) << "public partial class " << _class->GetNameManaged() << " : ";
    if (_class->SuperStruct)
    {
        out << _class->SuperStruct->GetPathNameManaged() << ", ";
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
                Printer::Indent(out)
                    << "s_staticClass = StaticFindObjectChecked<Class>(null, null, \""
                    << _class->GetPathName() << "\", false);" << endl;
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
        Printer::Indent(out) << "internal " << _class->GetNameManaged() << "() { }" << endl << endl;

        // Print main ctor (unless abstract)
        if (!((DWORD)_class->ClassFlags & (DWORD)EClassFlags::CLASS_Abstract))
        {
            Printer::Indent(out) << "/// <summary>" << endl;
            Printer::Indent(out) << "/// Constructs a new " << _class->GetNameManaged() << endl;
            Printer::Indent(out) << "/// </summary>" << endl;
            Printer::Indent(out)
                << "public " << _class->GetNameManaged()
                << "(BmSDK.GameObject Outer, string Name = null, "
                "BmSDK.GameObject.EObjectFlags SetFlags = 0, "
                << _class->GetNameManaged()
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
        Printer::Indent(out) << "protected " << _class->GetNameManaged() << "(nint ptr)";
        if (_class->GetName() == "Object")
        {
            out << " { Ptr = ptr; }" << endl;
        }
        else
        {
            out << " : base(ptr) { }" << endl;
        }
        out << endl;

        for (UStruct* super = _class; super; super = super->SuperStruct)
        {
            if (super->GetPathName() == "Engine.Actor")
            {
                Printer::PrintScHelpers(_class, out);
                break;
            }
        }

        // Print fields
        UField* fieldLink = _class->Children;
        for (UField* fieldLink = _class->Children; fieldLink; fieldLink = fieldLink->Next)
        {
            // Don't print any members for intrinsic classes - they occasionally exist
            // at runtime, but we just want their declaration so we can reference them.
            if ((DWORD)_class->ClassFlags & (DWORD)EClassFlags::CLASS_Intrinsic)
            {
                break;
            }

            if (fieldLink->IsA(UProperty::StaticClass()))
            {
                Printer::PrintProperty((UProperty*)fieldLink, out);

                if (fieldLink->Next)
                {
                    out << endl;
                }
            }
            else if (fieldLink->IsA(UEnum::StaticClass()))
            {
                Printer::PrintEnum((UEnum*)fieldLink, out);

                if (fieldLink->Next)
                {
                    out << endl;
                }
            }
            else if (fieldLink->IsA(UScriptStruct::StaticClass()))
            {
                Printer::PrintStruct((UScriptStruct*)fieldLink, out);

                if (fieldLink->Next)
                {
                    out << endl;
                }
            }
            else if (fieldLink->IsA(UFunction::StaticClass()))
            {
                Printer::PrintFunction((UFunction*)fieldLink, out);

                if (fieldLink->Next)
                {
                    out << endl;
                }
            }
        }
    }
    Printer::PopIndent();
    Printer::Indent(out) << "}" << endl;
}

void Printer::PrintScHelpers(class UClass* _class, ostream& out)
{
    auto type = _class->GetNameManaged();
    Printer::PrintScHelper("void", "AttachScriptComponent", false, false, false, type, out);
    Printer::PrintScHelper("TComponent", "AttachScriptComponent", true, true, true, type, out);
    Printer::PrintScHelper("bool", "HasScriptComponent", false, false, false, type, out);
    Printer::PrintScHelper("bool", "HasScriptComponent", true, false, false, type, out);
    Printer::PrintScHelper("TComponent", "GetScriptComponent", true, false, true, type, out);
    Printer::PrintScHelper("void", "DetachScriptComponent", false, false, false, type, out);
    Printer::PrintScHelper("void", "DetachScriptComponent", true, false, false, type, out);
}

void Printer::PrintScHelper(string returnType, string helper, bool generic, bool ctor, bool cast, string type, ostream& out)
{
    if (generic)
    {
        Printer::Indent(out) << "/// <inheritdoc cref=\"Engine.Actor." << helper << "(Type)\"/>" << endl;
        Printer::Indent(out) << "public " << returnType << " " << helper << "<TComponent>()" << endl;
        Printer::PushIndent();
        Printer::Indent(out) << "where TComponent : class, Framework.IScriptComponent<" << type << ">"
            << (ctor ? ", new()" : "") << endl;
        Printer::Indent(out) << "=> " << (cast ? "(TComponent)" : "")
            << "((Engine.Actor)this)." << helper << "(typeof(TComponent));" << endl;
        Printer::PopIndent();
        out << endl;
    }
    else
    {
        Printer::Indent(out) << "/// <inheritdoc cref=\"Engine.Actor." << helper << "(Framework.IScriptComponent)\"/>" << endl;
        Printer::Indent(out) << "public " << returnType << " " << helper << "<TComponent>(TComponent component)" << endl;
        Printer::PushIndent();
        Printer::Indent(out) << "where TComponent : class, Framework.IScriptComponent<" << type << ">" << endl;
        Printer::Indent(out) << "=> ((Engine.Actor)this)." << helper << "((Framework.IScriptComponent)component);" << endl;
        Printer::PopIndent();
        out << endl;
    }
    
}

void Printer::PrintStruct(UScriptStruct* _struct, ostream& out)
{
    // Print struct comment
    Printer::Indent(out) << "/// <summary>" << endl;
    Printer::Indent(out) << "/// Struct: " << _struct->GetNameManaged() << endl;
    Printer::Indent(out) << "/// </summary>" << endl;

    // Print struct declaration
    Printer::Indent(out) << "[StructLayout(LayoutKind.Explicit, Size = " << _struct->PropertiesSize
        << ")]" << endl;
    Printer::Indent(out) << "public partial record struct " << _struct->GetNameManaged() << endl;

    // Print struct body
    Printer::Indent(out) << "{" << endl;
    Printer::PushIndent();
    {
        UField* fieldLink = _struct->Children;
        while (fieldLink)
        {
            if (fieldLink->IsA(UProperty::StaticClass()))
            {
                Printer::PrintProperty((UProperty*)fieldLink, out);

                if (fieldLink->Next)
                {
                    out << endl;
                }
            }

            fieldLink = fieldLink->Next;
        }
    }
    Printer::PopIndent();
    Printer::Indent(out) << "}" << endl;
}

void Printer::PrintEnum(UEnum* _enum, ostream& out)
{
    // De-duplicate enum names
    map<string, int> enumNameFreqs;
    vector<string> enumNames;
    for (auto i = 0; i < _enum->Names.Num; i++)
    {
        auto nameStr = _enum->Names.ElementAt(i).ToString();
        if (enumNameFreqs.find(nameStr) == enumNameFreqs.end())
        {
            enumNameFreqs[nameStr] = 1;
            enumNames.push_back(nameStr);
        }
        else
        {
            enumNameFreqs[nameStr]++;
        }

        if (enumNameFreqs[nameStr] > 1)
        {
            enumNames.push_back(nameStr + "_" + to_string(enumNameFreqs[nameStr]));
        }
    }

    // Print prop comment
    Printer::Indent(out) << "/// <summary>" << endl;
    Printer::Indent(out) << "/// Enum: " << _enum->GetName() << endl;
    Printer::Indent(out) << "/// </summary>" << endl;

    // Print prop declaration
    Printer::Indent(out) << "public enum " << _enum->GetNameManaged() << endl;

    // Print prop body
    Printer::Indent(out) << "{" << endl;
    Printer::PushIndent();
    {
        for (auto i = 0u; i < enumNames.size(); i++)
        {
            Printer::Indent(out) << enumNames.at(i) << " = " << i << "," << endl;
        }
    }
    Printer::PopIndent();
    Printer::Indent(out) << "}" << endl;
}

void Printer::PrintProperty(UProperty* prop, ostream& out)
{
    // Print prop comment
    Printer::Indent(out) << "/// <summary>" << endl;
    Printer::Indent(out) << "/// " << prop->Class->GetName() << ": " << prop->GetName() << endl;
    Printer::Indent(out) << "/// </summary>" << endl;

    // Print prop declaration
    Printer::Indent(out) << "public unsafe " << prop->GetInnerTypeNameManaged() << " "
        << prop->GetNameManaged() << endl;

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
            if (prop->IsA(UBoolProperty::StaticClass()))
            {
                UBoolProperty* boolProp = (UBoolProperty*)prop;
                out << "return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + " << prop->Offset
                    << ") & " << boolProp->BitMask << ") != 0;";
            }
            else
            {
                out << "return BmSDK.Framework.MarshalUtil.ToManaged<"
                    << prop->GetInnerTypeNameManaged() << ">(Ptr + " << prop->Offset << ");";
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
            if (prop->IsA(UBoolProperty::StaticClass()))
            {
                UBoolProperty* boolProp = (UBoolProperty*)prop;
                out << "var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + "
                    << prop->Offset << ");";
                out << " var newMask = value ? (currentMask | " << boolProp->BitMask
                    << ") : (currentMask & ~" << boolProp->BitMask << ");";

                out << " BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + "
                    << prop->Offset << ");";
            }
            else
            {
                out << "BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + " << prop->Offset
                    << ");";
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

void Printer::PrintFunction(class UFunction* func, ostream& out)
{
    vector<UProperty*> params = {};
    UProperty* returnParam = nullptr;

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

    // Gather func params
    UField* fieldLink = func->Children;
    while (fieldLink)
    {
        if (fieldLink->IsA(UProperty::StaticClass()))
        {
            auto prop = (UProperty*)fieldLink;
            if ((QWORD)prop->PropertyFlags & (QWORD)EPropertyFlags::CPF_ReturnParm)
            {
                returnParam = prop;
            }
            else if ((QWORD)prop->PropertyFlags & (QWORD)EPropertyFlags::CPF_Parm)
            {
                params.push_back(prop);
            }
        }

        fieldLink = fieldLink->Next;
    }

    bool shouldSuppressOptional = false;
    for (auto i = 0u; i < params.size(); i++)
    {
        auto prop = params[i];

        // C# doesn't support optional out params. To avoid reordering and to avoid making
        // any functional changes, let's just force everything to be non-optional when we encounter
        // one.
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
    out << (returnParam ? returnParam->GetInnerTypeNameManaged() : "void") << " ";
    out << func->GetNameManaged() << "(";
    for (auto i = 0u; i < params.size(); i++)
    {
        auto prop = params[i];

        // "out" keyword for out params
        if ((QWORD)prop->PropertyFlags & (QWORD)EPropertyFlags::CPF_OutParm)
        {
            out << "out ";
        }

        // Print param declaration
        out << prop->GetInnerTypeNameManaged() << " " << prop->GetNameManaged();
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
            << func->GetPathName() << "\", true);" << endl;

        Printer::Indent(out) << "byte* paramsPtr = stackalloc byte[" << func->PropertiesSize << "];"
            << endl;
        for (auto i = 0u; i < params.size(); i++)
        {
            auto param = params[i];

            // Don't marshal in 'out' params
            if ((QWORD)param->PropertyFlags & (QWORD)EPropertyFlags::CPF_OutParm)
            {
                continue;
            }

            // Print
            Printer::Indent(out) << "BmSDK.Framework.MarshalUtil.ToUnmanaged("
                << param->GetNameManaged() << ", paramsPtr + " << param->Offset
                << ");" << endl;
        }

        if (funcIsNative)
        {
            Printer::Indent(out) << "var oldFlags = funcManaged.FunctionFlags;" << endl;
            Printer::Indent(out) << "var oldNative = funcManaged.iNative;" << endl;
            Printer::Indent(out)
                << "funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;"
                << endl;
            Printer::Indent(out)
                << "funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;"
                << endl;
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
        for (auto i = 0u; i < params.size(); i++)
        {
            auto param = params[i];

            if ((QWORD)param->PropertyFlags & (QWORD)EPropertyFlags::CPF_OutParm)
            {
                Printer::Indent(out)
                    << param->GetNameManaged() << " = BmSDK.Framework.MarshalUtil.ToManaged<"
                    << param->GetInnerTypeNameManaged() << ">(paramsPtr + " << param->Offset << ");"
                    << endl;
            }
        }

        if (returnParam != nullptr)
        {
            // Print return param declaration
            Printer::Indent(out) << "return BmSDK.Framework.MarshalUtil.ToManaged<"
                << returnParam->GetInnerTypeNameManaged() << ">(paramsPtr + "
                << returnParam->Offset << ");" << endl;
        }
        else
        {
            Printer::Indent(out) << "return;" << endl;
        }
    }
    Printer::PopIndent();
    Printer::Indent(out) << "}" << endl;
}

void Printer::PrintStaticInit(vector<UClass*>& classes, ostream& out)
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
            for (auto _class : classes)
            {
                auto classPath = _class->GetPathName();
                auto managedPath = _class->GetPathNameManaged();
                Printer::Indent(out) << "_classPathToManagedTypeMap[\"" << classPath
                    << "\"] = typeof(" << managedPath << ");" << endl;

                Printer::Indent(out) << "_managedTypeToClassPathMap[typeof(" << managedPath
                    << ")] = \"" << classPath << "\";" << endl;
            }
        }
        Printer::PopIndent();
        Printer::Indent(out) << "}" << endl;
    }
    Printer::PopIndent();
    Printer::Indent(out) << "}" << endl;
}
