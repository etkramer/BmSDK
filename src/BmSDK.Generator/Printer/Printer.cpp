#include "pch.h"
#include "Printer.h"
#include "Engine/UClass.h"
#include "Engine/UProperty.h"

void Printer::PrintFile(UClass* _class, ostream& out)
{
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
	cout << "public class " << _class->GetNameManaged();
	if (_class->SuperField)
	{
		cout << " : " << _class->SuperField->GetPathNameManaged();
	}
	cout << endl;

	// Print class body
	cout << "{" << endl;
	{
		UField* fieldLink = _class->Children;
		while (fieldLink)
		{
			if (!fieldLink->IsA(UProperty::StaticClass()))
			{
				fieldLink = fieldLink->Next;
				continue;
			}

			auto prop = (UProperty*)fieldLink;

			Printer::PrintProperty(prop, out);

			if (prop->Next && prop->Next->IsA(UProperty::StaticClass()))
			{
				cout << endl;
			}

			fieldLink = fieldLink->Next;
		}
	}
	cout << "}" << endl;
}

void Printer::PrintProperty(UProperty* prop, ostream& out)
{
	// Print prop comment
	cout << "    /// <summary>" << endl;
	cout << "    /// Property: " << prop->GetName() << endl;
	cout << "    /// </summary>" << endl;

	// Print prop declaration
	cout << "    public " << prop->GetInnerTypeNameManaged() << " " << prop->GetName() << endl;

	// Print prop body
	cout << "    {" << endl;
	cout << "        get => throw new System.NotImplementedException();" << endl;
	cout << "        set => throw new System.NotImplementedException();" << endl;
	cout << "    }" << endl;
}
