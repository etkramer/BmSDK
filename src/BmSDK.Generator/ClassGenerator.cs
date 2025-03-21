using System.Text.RegularExpressions;
using BmSDK.Generator.Utils;
using UELib.Core;

namespace BmSDK.Generator;

partial class ClassGenerator(UClass Class)
{
    public string Namespace => $"BmSDK.{Class.Package.PackageName}";

    public void GenerateClassFile(TextWriter writer)
    {
        TryInitIntrinsicClasses();

        // Write using statements
        writer.WriteLine("using System;");
        writer.WriteLine("using System.Runtime.InteropServices;\n");

        // Write namespace declaration
        writer.WriteLine($"namespace {Namespace};\n");

        // Write analyzer suppressions
        writer.WriteLine("#pragma warning disable IDE1006\n");

        WriteClassDeclaration(writer, Class);
    }

    /// <summary>
    /// Writes a UClass declaration to the given TextWriter.
    /// </summary>
    void WriteClassDeclaration(TextWriter writer, UClass classObj)
    {
        // Gather fields
        classObj.ComputeLayoutInfo();
        var enumFields = classObj.EnumerateFields().OfType<UEnum>().ToArray();
        var structFields = classObj.EnumerateFields().OfType<UScriptStruct>().ToArray();

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
        writer.Write($" class {classObj.ManagedName}");
        if (classObj.Super is not null)
        {
            writer.Write($" : {GetFullName(classObj.Super)}");
        }
        writer.Write("\n");

        // Write class body
        writer.WriteLine("{");
        {
            // Write properties
            foreach (var propField in classObj.EnumerateFields().OfType<UProperty>())
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

                writer.WriteLine();
            }

            // Write hardcoded members
            if (Class.GetPath() == "Object")
            {
                writer.WriteLine(OBJECT_HARDCODES);
                writer.WriteLine();
            }

            // Write enums
            foreach (var enumField in enumFields)
            {
                WriteEnumDeclaration(writer, enumField, 1);
                writer.WriteLine();
            }

            // Write structs
            foreach (var structField in structFields)
            {
                WriteStructDeclaration(writer, structField, 1);
                writer.WriteLine();
            }
        }
        writer.WriteLine("}");

        // Write extra hardcodes in UObject.cs
        if (Class.GetPath() == "Object")
        {
            writer.WriteLine();
            writer.WriteLine(ARRAY_HARDCODES);
        }
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
        structObj.ComputeLayoutInfo();
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
    void WriteStructFieldDeclaration(TextWriter writer, UProperty prop, int indent)
    {
        // Write [FieldOffset] attribute
        writer.WriteIndent(indent);
        writer.Write($"[FieldOffset({prop.PropertyOffset})] ");

        // Write field declaration (NOTE we're using int as a placeholder for now)
        writer.WriteLine($"public int {prop.Name};");
    }

    /// <summary>
    /// Writes a UProperty declaration to the given TextWriter.
    /// </summary>
    void WritePropDeclaration(TextWriter writer, UProperty prop, int indent)
    {
        var nativeTypeName = GetNativeTypeName(prop);
        var managedTypeName = GetManagedTypeName(prop);
        var categoryName = prop.CategoryName.IsNone() ? "" : prop.CategoryName.ToString();

        writer.WriteLineIndented($"// var({categoryName}) {prop.Decompile()}", indent);
        writer.WriteLineIndented($"public {managedTypeName} {prop.Name}", indent);
        writer.WriteLineIndented("{", indent);
        writer.WriteLineIndented($"get => ({managedTypeName})GetPropertyValue({prop.PropertyOffset}, \"{nativeTypeName}\");", indent + 1);
        writer.WriteLineIndented($"set => SetPropertyValue({prop.PropertyOffset}, \"{nativeTypeName}\", value);", indent + 1);
        writer.WriteLineIndented("}", indent);
    }

    /// <summary>
    /// Writes a UBoolProperty declaration to the given TextWriter and returns its size.
    /// </summary>
    void WriteBoolPropDeclaration(TextWriter writer, UBoolProperty prop, int indent)
    {
        var categoryName = prop.CategoryName.IsNone() ? "" : prop.CategoryName.ToString();

        writer.WriteLineIndented($"// var({categoryName}) {prop.Decompile()}", indent);
        writer.WriteLineIndented($"public bool {prop.Name}", indent);
        writer.WriteLineIndented("{", indent);
        writer.WriteLineIndented($"get => GetBoolPropertyValue({prop.PropertyOffset}, {prop.BitfieldIdx});", indent + 1);
        writer.WriteLineIndented($"set => SetBoolPropertyValue({prop.PropertyOffset}, {prop.BitfieldIdx}, value);", indent + 1);
        writer.WriteLineIndented("}", indent);
    }
}
