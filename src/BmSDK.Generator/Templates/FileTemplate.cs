using BmSDK.Generator;
using UELib.Core;

static class FileTemplate
{
    public static FormattableString Render(UClass classObj)
    {
        // TODO: Refactor. We're just using this for some helper methods.
        var helper = new ClassHelper(classObj);

        return $$"""
            using System;
            using System.Numerics;
            using System.Runtime.InteropServices;

            namespace {{helper.Namespace}};

            {{ClassTemplate.Render(classObj, helper)}}
            """;
    }
}
