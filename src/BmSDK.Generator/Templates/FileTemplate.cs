using BmSDK.Generator;
using UELib.Core;

static class FileTemplate
{
    public static FormattableString Render(UClass classObj) =>
        $$"""
            using System;
            using System.Runtime.InteropServices;

            namespace {{TypeMapper.GetManagedNamespace(classObj)}};

            {{ClassTemplate.Render(classObj)}}
            """;
}
