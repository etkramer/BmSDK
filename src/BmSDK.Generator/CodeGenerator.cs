using BmSDK.Generator.Utils;
using UELib.Core;

namespace BmSDK.Generator;

static partial class CodeGenerator
{
    public static void GenerateClassFile(TextWriter writer, UClass classObj)
    {
        TryInitIntrinsicClasses();

        // Write using statements
        writer.WriteLine("using BmSDK;");
        writer.WriteLine("using BmSDK.Framework;\n");

        // Write namespace declaration
        writer.WriteLine($"namespace BmSDK.{classObj.Package.PackageName};\n");

        WriteClassDeclaration(writer, classObj, 0);
    }

    /// <summary>
    /// Writes a UClass declaration to the given TextWriter.
    /// </summary>
    public static void WriteClassDeclaration(TextWriter writer, UClass classObj, int indent = 0)
    {
        // Gather fields
        var enumFields = classObj.EnumerateFields().OfType<UEnum>().ToArray();
        var structFields = classObj.EnumerateFields().OfType<UScriptStruct>().ToArray();

        // Write declaration
        writer.WriteIndent(indent);
        writer.Write($"public class {classObj.Name}");
        if (classObj.Super is not null)
        {
            writer.Write($" : {GetFullName(classObj.Super)}");
        }
        writer.Write("\n");

        // Write class body
        writer.WriteLineIndented("{", indent);
        {
            // Write enums
            foreach (var enumField in enumFields)
            {
                WriteEnumDeclaration(writer, enumField, indent + 1);
                writer.WriteLine();
            }

            // Write structs
            foreach (var structField in structFields)
            {
                WriteStructDeclaration(writer, structField, indent + 1);
                writer.WriteLine();
            }

            // Write properties
            WritePropDeclarations(writer, classObj, indent + 1);
        }
        writer.WriteLineIndented("}", indent);
    }

    /// <summary>
    /// Writes a UEnum declaration to the given TextWriter.
    /// </summary>
    static void WriteEnumDeclaration(TextWriter writer, UEnum enumObj, int indent)
    {
        // Write declaration
        writer.WriteLineIndented($"public enum {enumObj.Name} : byte", indent);
        writer.WriteLineIndented("{", indent);
        {
            // Write members (but skip _MAX)
            for (int i = 0; i < enumObj.Names.Count - 1; i++)
            {
                writer.WriteLineIndented($"{enumObj.Names[i]} = 0x{1 << i:X},", indent + 1);
            }
        }
        writer.WriteLineIndented("}", indent);
    }

    /// <summary>
    /// Writes a UStruct declaration to the given TextWriter.
    /// </summary>
    public static void WriteStructDeclaration(
        TextWriter writer,
        UScriptStruct structObj,
        int indent
    )
    {
        // Gather fields
        var propFields = structObj.EnumerateFields().OfType<UProperty>().ToArray();

        // Write declaration
        writer.WriteIndent(indent);
        writer.Write($"public struct {structObj.CppName}");
        if (structObj.Super is not null)
        {
            writer.Write($" : {GetFullName(structObj.Super)}");
        }
        writer.Write("\n");

        // Write class body
        writer.WriteLineIndented("{", indent);
        {
            // Write properties
            WritePropDeclarations(writer, structObj, indent + 1);
        }
        writer.WriteLineIndented("}", indent);
    }

    public static void WritePropDeclarations(TextWriter writer, UStruct structObj, int indent)
    {
        var propFields = structObj.EnumerateFields().OfType<UProperty>().ToArray();

        // Write properties
        var fieldOffset = 0;
        var fieldBit = 0;
        foreach (var propField in propFields)
        {
            // Track number of bools in a bitfield
            if (propField is UBoolProperty)
            {
                fieldBit++;
            }
            else
            {
                fieldBit = 0;
            }

            // Begin new bitfield if needed
            if (fieldBit > 32)
            {
                fieldBit = 0;
                fieldOffset += 4;
            }

            if (propField is UBoolProperty boolProperty)
            {
                fieldOffset += WriteBoolPropDeclaration(
                    writer,
                    boolProperty,
                    fieldOffset,
                    fieldBit,
                    indent
                );
            }
            else
            {
                fieldOffset += WritePropDeclaration(writer, propField, fieldOffset, indent);
            }
        }
    }

    /// <summary>
    /// Writes a UProperty declaration to the given TextWriter and returns itss size.
    /// </summary>
    public static int WritePropDeclaration(
        TextWriter writer,
        UProperty prop,
        int fieldOffset,
        int indent
    )
    {
        var nativeTypeName = GetNativeTypeName(prop);
        var managedTypeName = GetManagedTypeName(prop);
        writer.WriteLineIndented(
            $"public {managedTypeName} {prop.Name} => ({managedTypeName})GetPropertyValue({fieldOffset}, \"{nativeTypeName}\");",
            indent
        );

        return GetNativeFieldSize(prop);
    }

    /// <summary>
    /// Writes a UProperty declaration to the given TextWriter and returns itss size.
    /// </summary>
    public static int WriteBoolPropDeclaration(
        TextWriter writer,
        UProperty prop,
        int fieldOffset,
        int fieldBit,
        int indent
    )
    {
        writer.WriteLineIndented(
            $"public bool {prop.Name} => GetBoolPropertyValue({fieldOffset}, {fieldBit});",
            indent
        );

        if (prop.NextField is not UBoolProperty)
        {
            // Advance by sizeof(BITFIELD)
            return 4;
        }

        return 0;
    }
}
