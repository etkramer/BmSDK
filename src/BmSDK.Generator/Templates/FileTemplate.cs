using UELib.Core;

namespace BmSDK.Generator.Templates;

static class FileTemplate
{
    public static FormattableString Render(UClass classObj)
    {
        return $$"""
            namespace {{TypeMapper.GetManagedNamespace(classObj)}};

            // Disable CS0108
            #pragma warning disable CS0108

            {{ClassTemplate.Render(classObj)}}
            """;
    }
}
