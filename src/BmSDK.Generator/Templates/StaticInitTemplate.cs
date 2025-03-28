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
                static Dictionary<Type, string> _managedTypeToClassPathMap = [];

                public static void StaticInitClasses()
                {
                    {{classes.Select(RenderClassInit)}}
                    {{instrinsicClasses.Select(RenderClassInit)}}
                }

                public static Type GetManagedTypeForClassPath(string classPath)
                {
                    if (_classPathToManagedTypeMap.TryGetValue(classPath, out var res))
                    {
                        return res;
                    }

                    return typeof(BmSDK.IntrinsicDummy);
                }

                public static string GetClassPathForManagedType(Type type)
                {
                    if (_managedTypeToClassPathMap.TryGetValue(type, out var res))
                    {
                        return res;
                    }

                    return null;
                }
            }
            """;
    }

    static FormattableString RenderClassInit(UClass classObj) =>
        RenderClassInit($"{classObj.ShortPath}");

    static FormattableString RenderClassInit(string classPath)
    {
        return $$"""
            _classPathToManagedTypeMap["{{classPath}}"] = typeof({{TypeMapper.GetManagedPathForType(
                classPath
            )}});
            _managedTypeToClassPathMap[typeof({{TypeMapper.GetManagedPathForType(
                classPath
            )}})] = "{{classPath}}";
            """;
    }
}
