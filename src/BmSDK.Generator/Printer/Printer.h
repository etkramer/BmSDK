class Printer
{
private:
	Printer() = delete;

public:
	static void PrintFile(class UClass* classObj, ostream& out);

private:
	static void PrintClass(class UClass* classObj, ostream& out);
	static void PrintProperty(class UProperty* propObj, ostream& out);
};
