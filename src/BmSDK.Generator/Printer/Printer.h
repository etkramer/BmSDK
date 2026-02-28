#pragma once

#include "Framework/ClassGraph.h"

class Printer
{
private:
    Printer() = delete;

public:
    static void PrintFile(ClassNode* classNode, ostream& out, ClassGraph* graph);
    static void PrintStaticInit(const vector<ClassNode*>& classes, ostream& out, ClassGraph* graph);

private:
    static void PrintClass(ClassNode* classNode, ostream& out, ClassGraph* graph);
    static void PrintScHelpers(ClassNode* classNode, ostream& out);
    static void PrintScHelper(
        string returnType,
        string helper,
        bool generic,
        bool ctor,
        bool cast,
        string type,
        ostream& out);
    static void PrintStruct(StructNode* structNode, ostream& out, ClassGraph* graph);
    static void PrintEnum(EnumNode* enumNode, ostream& out);
    static void PrintProperty(PropertyNode* propNode, ostream& out, ClassGraph* graph);
    static void PrintFunction(StructNode* funcNode, ostream& out, ClassGraph* graph);

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
