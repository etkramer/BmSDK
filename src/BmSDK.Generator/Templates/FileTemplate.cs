using BmSDK.Generator;
using UELib.Core;

static class FileTemplate
{
    public static FormattableString Render(UClass classObj)
    {
        // TODO: Refactor. We're just using this for some helper methods.
        var generator = new ClassGenerator(classObj);

        return $$"""
            using System;
            using System.Numerics;
            using System.Runtime.InteropServices;

            namespace {{generator.Namespace}};

            {{ClassTemplate.Render(classObj, generator)}}
            """;
    }
}
