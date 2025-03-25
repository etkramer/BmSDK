using UELib.Core;

namespace BmSDK.Generator.Templates;

static class FileTemplate
{
    public static FormattableString Render(UClass classObj)
    {
        return $$"""
            namespace {{TypeMapper.GetManagedNamespace(classObj)}};

            {{ClassTemplate.Render(classObj)}}
            """;
    }
}
