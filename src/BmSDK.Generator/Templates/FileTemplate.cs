using BmSDK.Generator;
using UELib.Core;

static class FileTemplate
{
    public static FormattableString Render(UClass classObj) =>
        $$"""
            namespace {{TypeMapper.GetManagedNamespace(classObj)}};

            {{ClassTemplate.Render(classObj)}}
            """;
}
