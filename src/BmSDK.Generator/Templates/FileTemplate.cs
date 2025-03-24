using UELib.Core;

namespace BmSDK.Generator.Templates;

static class FileTemplate
{
    public static FormattableString Render(UClass classObj) =>
        $$"""
            namespace {{TypeMapper.GetManagedNamespace(classObj)}};

            {{ClassTemplate.Render(classObj)}}
            """;
}
