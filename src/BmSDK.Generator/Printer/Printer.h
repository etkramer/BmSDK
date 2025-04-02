class Printer
{
private:
	Printer() = delete;

public:
	static void PrintFile(class UClass* class_, ostream& out);

private:
	static void PrintClass(class UClass* class_, ostream& out);
	static void PrintStruct(class UScriptStruct* struct_, ostream& out);
	static void PrintEnum(class UEnum* enum_, ostream& out);
	static void PrintProperty(class UProperty* prop, ostream& out);
	static void PrintStructProperty(class UProperty* prop, ostream& out);

	static void PushIndent() { IndentLevel++; };
	static void PopIndent() { IndentLevel--; };

	static ostream& Indent(ostream& out)
	{
		for (auto i = 0; i < IndentLevel; i++)
		{
			for (auto j = 0; j < IndentSize; j++)
			{
				out << ' ';
			}
		}

		return out;
	};

	// static string Indent()
	// {
	// 	string res = "";
	// 	for (auto i = 0; i < IndentLevel; i++)
	// 	{
	// 		res += string(IndentSize, ' ');
	// 	}

	// 	return res;
	// };

private:
	static int32_t IndentLevel;
	static const int32_t IndentSize = 4;
};
