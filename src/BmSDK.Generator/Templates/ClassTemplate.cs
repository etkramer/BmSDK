using BmSDK.Generator.Utils;
using UELib.Core;
using UELib.Flags;

namespace BmSDK.Generator.Templates;

static class ClassTemplate
{
    public static FormattableString Render(UClass classObj)
    {
        var propFields = classObj.EnumerateFields().OfType<UProperty>().ToArray();
        var enumFields = classObj.EnumerateFields().OfType<UEnum>().ToArray();
        var structFields = classObj.EnumerateFields().OfType<UScriptStruct>().ToArray();

        // Ignore private functions
        var funcFields = classObj
            .EnumerateFields()
            .OfType<UFunction>()
            .Where(func => !func.HasFunctionFlag(FunctionFlags.Private))
            .ToArray();

        // Get super class decl
        var classDeclSuper = "";
        if (classObj.Super is not null)
        {
            classDeclSuper = $" : {TypeMapper.GetManagedPathForType(classObj.Super, classObj)}";
        }

        // Add keywords for class attributes
        var classKeywordText = "";
        if (classObj.HasClassFlag(ClassFlags.Abstract))
        {
            classKeywordText = " abstract";
        }

        // Format flags
        var flagsText = $"({FlagUtils.DropUnknownBits((ClassFlags)classObj.ClassFlags)})";

        // Format layout info
        var layoutInfoText =
            $"(size = 0x{classObj.StructSize - classObj.StructStartOffset:X}, offset = 0x{classObj.StructStartOffset:X})";

        return $$"""
            /// <summary>
            /// Class: {{classObj.Package.PackageName}}.{{classObj.GetPath()}} {{flagsText}}<br/>
            /// {{layoutInfoText}}
            /// </summary>
            public{{classKeywordText}} partial class {{classObj.ManagedName}}{{classDeclSuper}}
            {
                {{propFields.Select(PropTemplate.Render)}}

                {{funcFields.Select(FuncTemplate.Render)}}

                {{enumFields.Select(EnumTemplate.Render)}}

                {{structFields.Select(StructTemplate.Render)}}
            }
            """;
    }
}
