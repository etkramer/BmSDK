using BmSDK.Generator.Utils;
using UELib.Core;

namespace BmSDK.Generator;

partial class ClassGenerator(UClass Class)
{
    public string Namespace =>
        Class.Package.PackageName == "Core" ? "BmSDK" : $"BmSDK.{Class.Package.PackageName}";

    public void GenerateClassFile(TextWriter writer)
    {
        // Write using statements
        writer.WriteLine("using System;");
        writer.WriteLine("using System.Runtime.InteropServices;\n");

        // Write namespace declaration
        writer.WriteLine($"namespace {Namespace};\n");

        WriteClassDeclaration(writer, Class);
    }

    /// <summary>
    /// Writes a UClass declaration to the given TextWriter.
    /// </summary>
    void WriteClassDeclaration(TextWriter writer, UClass classObj)
    {
        // Gather fields
        var enumFields = classObj.EnumerateFields().OfType<UEnum>().ToArray();
        var structFields = classObj.EnumerateFields().OfType<UScriptStruct>().ToArray();
        var propFields = classObj.EnumerateFields().OfType<UProperty>().ToArray();

        // Write basic info
        writer.WriteLine(
            $"// class {classObj.Package.PackageName}.{classObj.GetPath()} (size = {classObj.StructSize})"
        );

        // Write declaration
        writer.Write("public");
        if (classObj.HasClassFlag(UELib.Flags.ClassFlags.Abstract))
        {
            writer.Write(" abstract");
        }
        writer.Write($" partial class {classObj.ManagedName}");
        if (classObj.Super is not null)
        {
            writer.Write($" : {GetFullName(classObj.Super)}");
        }
        writer.Write("\n");

        // Write class body
        writer.WriteLine("{");
        {
            // Write properties
            foreach (var propField in propFields)
            {
                if (propField is UBoolProperty boolField)
                {
                    WriteBoolPropDeclaration(writer, boolField, 1);
                }
                else
                {
                    // Handle regular properties
                    WritePropDeclaration(writer, propField, 1);
                }

                // Write newline if needed
                if (
                    propField != propFields.Last()
                    || enumFields.Length > 0
                    || structFields.Length > 0
                )
                {
                    writer.WriteLine();
                }
            }

            // Write enums
            foreach (var enumField in enumFields)
            {
                WriteEnumDeclaration(writer, enumField, 1);

                // Write newline if needed
                if (enumField != enumFields.Last() || structFields.Length > 0)
                {
                    writer.WriteLine();
                }
            }

            // Write structs
            foreach (var structField in structFields)
            {
                WriteStructDeclaration(writer, structField, 1);

                // Write newline if needed
                if (structField != structFields.Last())
                {
                    writer.WriteLine();
                }
            }
        }
        writer.WriteLine("}");
    }

    /// <summary>
    /// Writes a UEnum declaration to the given TextWriter.
    /// </summary>
    static void WriteEnumDeclaration(TextWriter writer, UEnum enumObj, int indent)
    {
        // Write declaration
        writer.WriteLineIndented($"public enum {enumObj.Name}", indent);
        writer.WriteLineIndented("{", indent);
        {
            // Write members
            for (int i = 0; i < enumObj.Names.Count; i++)
            {
                writer.WriteLineIndented($"{enumObj.Names[i]} = {i},", indent + 1);
            }
        }
        writer.WriteLineIndented("}", indent);
    }

    /// <summary>
    /// Writes a UStruct declaration to the given TextWriter.
    /// </summary>
    void WriteStructDeclaration(TextWriter writer, UScriptStruct structObj, int indent)
    {
        // Write [StructLayout] attribute
        writer.WriteLineIndented(
            $"[StructLayout(LayoutKind.Explicit, Size={structObj.StructSize})]",
            indent
        );

        // Write declaration
        writer.WriteIndent(indent);
        writer.Write($"public struct {structObj.ManagedName}", indent);
        if (structObj.Super is not null)
        {
            writer.Write($" /* : {structObj.Super.ManagedName} */");
        }
        writer.Write("\n");

        // Write class body
        writer.WriteLineIndented("{", indent);
        {
            // Write properties
            foreach (var propField in structObj.EnumerateFields().OfType<UProperty>())
            {
                WriteStructFieldDeclaration(writer, propField, indent + 1);
            }
        }
        writer.WriteLineIndented("}", indent);
    }

    /// <summary>
    /// Writes a UProperty declaration to the given TextWriter.
    /// </summary>
    static void WriteStructFieldDeclaration(TextWriter writer, UProperty prop, int indent)
    {
        // Write [FieldOffset] attribute
        writer.WriteIndent(indent);
        writer.Write($"[FieldOffset({prop.PropertyOffset})] ");

        // Write field declaration (NOTE we're using int as a placeholder for now)
        writer.Write($"public int {prop.ManagedName};");

        // Write type/size info
        writer.WriteLine($" // {((UField)prop.Class).ManagedName} (size = {prop.ElementSize})");
    }

    /// <summary>
    /// Writes a UProperty declaration to the given TextWriter.
    /// </summary>
    void WritePropDeclaration(TextWriter writer, UProperty prop, int indent)
    {
        // Write type/size info
        writer.WriteLineIndented(
            $"// {((UField)prop.Class).ManagedName} (size = {prop.ElementSize}, offset = {prop.PropertyOffset})",
            indent
        );

        // Write property signature
        var managedTypeName = GetManagedTypeName(prop);
        writer.WriteLineIndented($"public {managedTypeName} {prop.ManagedName}", indent);

        // Write property getter/setter
        writer.WriteLineIndented("{", indent);
        writer.WriteLineIndented(
            $"get => GetPropertyValue<{managedTypeName}>({prop.PropertyOffset});",
            indent + 1
        );
        writer.WriteLineIndented(
            $"set => SetPropertyValue({prop.PropertyOffset}, value);",
            indent + 1
        );
        writer.WriteLineIndented("}", indent);
    }

    /// <summary>
    /// Writes a UBoolProperty declaration to the given TextWriter and returns its size.
    /// </summary>
    static void WriteBoolPropDeclaration(TextWriter writer, UBoolProperty prop, int indent)
    {
        // Write type/size info
        writer.WriteLineIndented(
            $"// {((UField)prop.Class).ManagedName} (size = 1b, offset = {prop.PropertyOffset})",
            indent
        );

        // Write property signature
        writer.WriteLineIndented($"public bool {prop.ManagedName}", indent);

        // Write property getter/setter
        writer.WriteLineIndented("{", indent);
        writer.WriteLineIndented(
            $"get => GetBoolPropertyValue({prop.PropertyOffset}, {prop.BitfieldIdx});",
            indent + 1
        );
        writer.WriteLineIndented(
            $"set => SetBoolPropertyValue({prop.PropertyOffset}, {prop.BitfieldIdx}, value);",
            indent + 1
        );
        writer.WriteLineIndented("}", indent);
    }
}
