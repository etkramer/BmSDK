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
	Printer::Indent(out) << "#nullable enable annotations" << endl;
	Printer::Indent(out) << "#pragma warning disable CS0108" << endl;
	out << endl;

	// Print namespace declaration
	Printer::Indent(out) << "namespace " << _class->GetPackageNameManaged() << ";" << endl;
	out << endl;

	// Print class declaration
	Printer::PrintClass(_class, out);
}

void Printer::PrintClass(UClass* _class, ostream& out)
{
	// Print class comment
	Printer::Indent(out) << "/// <summary>" << endl;
	Printer::Indent(out) << "/// ";
	if ((DWORD)_class->ClassFlags & (DWORD)EClassFlags::CLASS_Intrinsic)
	{
		out << "INTRINSIC ";
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
	out << "global::BmSDK.IStaticObject" << endl;

	// Print class body
	Printer::Indent(out) << "{" << endl;
	Printer::PushIndent();
	{
		// Print StaticClass() helper
		Printer::Indent(out) << "public static global::BmSDK.Class StaticClass() => _staticClass "
								"??= StaticFindObjectChecked<Class>(null, null, \""
							 << _class->GetPathName() << "\", false);" << endl;
		Printer::Indent(out) << "static global::BmSDK.Class _staticClass = null;" << endl;
		out << endl;

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

void Printer::PrintStruct(UScriptStruct* _struct, ostream& out)
{
	// Print struct comment
	Printer::Indent(out) << "/// <summary>" << endl;
	Printer::Indent(out) << "/// Struct: " << _struct->GetNameManaged() << endl;
	Printer::Indent(out) << "/// </summary>" << endl;

	// Print struct declaration
	Printer::Indent(out) << "[StructLayout(LayoutKind.Explicit, Size = " << _struct->PropertiesSize
						 << ")]" << endl;
	Printer::Indent(out) << "public struct " << _struct->GetNameManaged() << endl;

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
		// TODO: Handle boolean masks
		Printer::Indent(out) << "get { ";
		{
			// Class getter
			if (prop->Outer->IsA(UClass::StaticClass()))
			{
				out << "return global::BmSDK.Framework.MarshalUtil.ToManaged<"
					<< prop->GetInnerTypeNameManaged() << ">(Ptr + " << prop->Offset << ");";
			}
			// Struct getter
			else if (prop->Outer->IsA(UScriptStruct::StaticClass()))
			{
				out << "fixed (void* thisPtr = &this) { "
					<< "return global::BmSDK.Framework.MarshalUtil.ToManaged<"
					<< prop->GetInnerTypeNameManaged() << ">((byte*)thisPtr + " << prop->Offset
					<< ");"
					<< " }";
			}
		}
		out << " }" << endl;

		// Print prop setter (single line)
		// TODO: Handle boolean masks
		Printer::Indent(out) << "set { ";
		{
			// Class setter
			if (prop->Outer->IsA(UClass::StaticClass()))
			{
				out << "global::BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + "
					<< prop->Offset << ");";
			}
			// Struct setter
			else if (prop->Outer->IsA(UScriptStruct::StaticClass()))
			{
				out << "fixed (void* thisPtr = &this) { "
					<< "global::BmSDK.Framework.MarshalUtil.ToUnmanaged(value, (byte*)thisPtr + "
					<< prop->Offset << ");"
					<< " }";
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

	// Skip operator functions
	if ((DWORD)func->FunctionFlags & (DWORD)EFunctionFlags::FUNC_Operator)
	{
		return;
	}

	// Gather func info
	bool funcIsStatic = (DWORD)func->FunctionFlags & (DWORD)EFunctionFlags::FUNC_Static;
	bool funcIsNative = (DWORD)func->FunctionFlags & (DWORD)EFunctionFlags::FUNC_Native;

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

		// Print param declaration
		out << prop->GetInnerTypeNameManaged() << " " << prop->GetNameManaged();
		if ((QWORD)prop->PropertyFlags & (QWORD)EPropertyFlags::CPF_OptionalParm)
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
		string ptrText = funcIsStatic ? "StaticClass().Ptr" : "Ptr";

		Printer::Indent(out) << "var funcPtr = BmSDK.GameFunctions.FindFunction(" << ptrText
							 << ", new FName(\"" << func->Name.ToString() << "\"), 0);" << endl;

		Printer::Indent(out)
			<< "var funcManaged = "
			   "BmSDK.Framework.MarshalUtil.ToManaged<global::BmSDK.Function>(&funcPtr);"
			<< endl;

		Printer::Indent(out) << "byte* paramsPtr = stackalloc byte[" << func->PropertiesSize << "];"
							 << endl;
		for (auto i = 0u; i < params.size(); i++)
		{
			auto param = params[i];

			// Print param declaration
			Printer::Indent(out) << "global::BmSDK.Framework.MarshalUtil.ToUnmanaged("
								 << param->GetNameManaged() << ", paramsPtr + " << param->Offset
								 << ");" << endl;
		}

		if (funcIsNative)
		{
			Printer::Indent(out) << "var oldFlags = funcManaged.FunctionFlags;" << endl;
			Printer::Indent(out) << "var oldNative = funcManaged.iNative;" << endl;
			Printer::Indent(out)
				<< "funcManaged.FunctionFlags &= ~global::BmSDK.EFunctionFlags.Native;" << endl;
			Printer::Indent(out)
				<< "funcManaged.FunctionFlags |= global::BmSDK.EFunctionFlags.Defined;" << endl;
			Printer::Indent(out) << "funcManaged.iNative = 0;" << endl;
		}

		Printer::Indent(out) << "global::BmSDK.GameFunctions.ProcessEvent(" << ptrText
							 << ", funcPtr, (nint)paramsPtr, 0);" << endl;

		if (funcIsNative)
		{
			Printer::Indent(out) << "funcManaged.iNative = oldNative;" << endl;
			Printer::Indent(out) << "funcManaged.FunctionFlags = oldFlags;" << endl;
		}

		if (returnParam != nullptr)
		{
			// Print return param declaration
			Printer::Indent(out) << "return global::BmSDK.Framework.MarshalUtil.ToManaged<"
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
	Printer::Indent(out) << "namespace BmSDK;" << endl;
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
