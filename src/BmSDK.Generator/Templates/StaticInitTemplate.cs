using UELib.Core;

namespace BmSDK.Generator.Templates;

static class StaticInitTemplate
{
    public static FormattableString Render(
        IEnumerable<UClass> classes,
        IEnumerable<string> instrinsicClasses
    )
    {
        return $$"""
            using System.Collections.Generic;

            namespace BmSDK;

            public static class StaticInit
            {
                static Dictionary<string, Type> _classPathToManagedTypeMap = [];

                public static void StaticInitClasses()
                {
                    {{classes.Select(RenderClassInit)}}
                    {{instrinsicClasses.Select(RenderClassInit)}}
                }

                public static Type GetManagedTypeForClass(string classPath)
                {
                    if (_classPathToManagedTypeMap.TryGetValue(classPath, out var res))
                    {
                        return res;
                    }

                    return typeof(BmSDK.IntrinsicDummy);
                }
            }
            """;
    }

    static FormattableString RenderClassInit(UClass classObj) =>
        RenderClassInit($"{classObj.Package.PackageName}.{classObj.Name}");

    static FormattableString RenderClassInit(string classPath)
    {
        return $$"""
            _classPathToManagedTypeMap["{{classPath}}"] = typeof({{TypeMapper.GetManagedPathForType(
                classPath
            )}});
            """;
    }
}
