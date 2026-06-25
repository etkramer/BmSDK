class Printer
{
private:
	Printer() = delete;

public:
	static void PrintFile(const struct ClassInfo& _class, ostream& out);
	static void PrintStaticInit(const vector<struct ClassInfo>& classes, ostream& out);

private:
	static void PrintInterface(const struct ClassInfo& _class, ostream& out);
	static void PrintClass(const struct ClassInfo& _class, ostream& out);
	static void PrintScHelpers(const struct ClassInfo& _class, ostream& out);
	static void PrintScHelper(string returnType, string helper, bool generic, bool ctor, bool cast, string type, ostream& out);
	static void PrintStruct(const struct StructInfo& _struct, ostream& out);
	static void PrintEnum(const struct EnumInfo& _enum, ostream& out);
	static void PrintProperty(const struct PropertyInfo& prop, ostream& out);
	static void PrintFunction(const struct FunctionInfo& func, bool isInInterface, ostream& out);
	static void PrintMember(const struct MemberInfo* member, bool isInInterface, ostream& out);

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

private:
	static int32_t IndentLevel;
	static const int32_t IndentSize = 4;
};
