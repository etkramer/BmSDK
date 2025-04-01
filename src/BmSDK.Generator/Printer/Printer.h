class Printer
{
private:
	Printer() = delete;

public:
	static void PrintFile(class UClass* class_, ostream& out);

private:
	static void PrintClass(class UClass* class_, ostream& out);
	static void PrintEnum(class UEnum* enum_, ostream& out);
	static void PrintProperty(class UProperty* prop, ostream& out);
};
