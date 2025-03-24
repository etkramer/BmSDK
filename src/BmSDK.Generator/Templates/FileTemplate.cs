using UELib.Core;

namespace BmSDK.Generator.Templates;

static class FileTemplate
{
    // public static FormattableString Render(UClass classObj) =>
    //     $$"""
    //         namespace {{TypeMapper.GetManagedNamespace(classObj)}};

    //         {{ClassTemplate.Render(classObj)}}
    //         """;

    public static FormattableString Render(UClass classObj)
    {
        var extraText = (FormattableString)$"";

        // Are we rendering Core.Object? Then write structs/enums separately
        var isObjClass = classObj.GetPath() == "Core.Object";
        if (isObjClass)
        {
            var enumFields = classObj.EnumerateFields().OfType<UEnum>().ToArray();
            var structFields = classObj.EnumerateFields().OfType<UScriptStruct>().ToArray();

            extraText = $$"""
                {{enumFields.Select(EnumTemplate.Render)}}

                {{structFields.Select(StructTemplate.Render)}}
                """;
        }

        return $$"""
            namespace {{TypeMapper.GetManagedNamespace(classObj)}};

            {{ClassTemplate.Render(classObj)}}

            {{extraText}}
            """;
    }
}
