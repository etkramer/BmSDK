#include "pch.h"
#include "Printer.h"
#include "Engine/UClass.h"
#include "Engine/UProperty.h"
#include "Engine/UEnum.h"

void Printer::PrintFile(UClass* _class, ostream& out)
{
	// Print preprocessor directives
	out << "#nullable enable annotations" << endl;
	out << endl;

	// Print namespace declaration
	out << "namespace " << _class->GetPackageNameManaged() << ";" << endl;
	out << endl;

	// Print class declaration
	Printer::PrintClass(_class, out);
}

void Printer::PrintClass(UClass* _class, ostream& out)
{
	// Print class comment
	out << "/// <summary>" << endl;
	out << "/// Class: " << _class->GetNameManaged() << "<br/>" << endl;
	out << "/// (size = " << _class->PropertiesSize << ")" << endl;
	out << "/// </summary>" << endl;

	// Print class declaration
	out << "public class " << _class->GetNameManaged();
	if (_class->SuperField)
	{
		out << " : " << _class->SuperField->GetPathNameManaged();
	}
	out << endl;

	// Print class body
	out << "{" << endl;
	{
		UField* fieldLink = _class->Children;
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
			else if (fieldLink->IsA(UEnum::StaticClass()))
			{
				Printer::PrintEnum((UEnum*)fieldLink, out);

				if (fieldLink->Next)
				{
					out << endl;
				}
			}

			fieldLink = fieldLink->Next;
		}
	}
	out << "}" << endl;
}

void Printer::PrintEnum(UEnum* enum_, ostream& out)
{
	// Print prop comment
	out << "    /// <summary>" << endl;
	out << "    /// Enum: " << enum_->GetName() << endl;
	out << "    /// </summary>" << endl;

	// Print prop declaration
	out << "    public enum " << enum_->GetNameManaged() << endl;

	// Print prop body
	out << "    {" << endl;
	for (INT i = 0; i < enum_->Names.Num; i++)
	{
		out << "        " << enum_->Names.ElementAt(i).ToString() << " = " << i << "," << endl;
	}
	out << "    }" << endl;
}

void Printer::PrintProperty(UProperty* prop, ostream& out)
{
	// Print prop comment
	out << "    /// <summary>" << endl;
	out << "    /// " << prop->Class->GetName() << ": " << prop->GetName() << endl;
	out << "    /// </summary>" << endl;

	// Print prop declaration
	out << "    public " << prop->GetInnerTypeNameManaged() << " " << prop->GetName() << endl;

	// Print prop body
	out << "    {" << endl;
	out << "        get => throw new global::System.NotImplementedException();" << endl;
	out << "        set => throw new global::System.NotImplementedException();" << endl;
	out << "    }" << endl;
}
