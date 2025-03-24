using BmSDK.Generator.Utils;
using UELib.Core;
using UELib.Flags;

namespace BmSDK.Generator.Templates;

static class StructTemplate
{
    public static FormattableString Render(UStruct structObj)
    {
        var propFields = structObj.EnumerateFields().OfType<UProperty>().ToArray();
        var superDecl = structObj.Super is null ? "" : $" /* : {structObj.Super.ManagedName} */";

        // Format flags
        var flagsText =
            structObj.StructFlags == 0
                ? ""
                : $" ({FlagUtils.DropUnknownBits((StructFlags)structObj.StructFlags)})";

        return $$"""
            /// <summary>
            /// Struct: {{structObj.GetPath()}}{{flagsText}}<br/>
            /// (size = 0x{{structObj.StructSize}})
            /// </summary>
            [StructLayout(LayoutKind.Explicit, Size={{structObj.StructSize}})]
            public struct {{structObj.ManagedName}} {{superDecl}}
            {
                {{propFields.Select(PropTemplate.Render)}}
            }
            """;
    }

    // static FormattableString RenderStructField(UProperty prop)
    // {
    //     // return $$"""
    //     //     [FieldOffset({{prop.PropertyOffset}})]
    //     //     public int {{prop.ManagedName}}; // {{(
    //     //         (UField)prop.Class
    //     //     ).ManagedName}} (size = {{prop.ElementSize}})
    //     //     """;
    // }

    // static FormattableString RenderStructField(UProperty prop) =>
    //     $$"""
    //         [FieldOffset({{prop.PropertyOffset}})]
    //         public int {{prop.ManagedName}}; // {{(
    //             (UField)prop.Class
    //         ).ManagedName}} (size = {{prop.ElementSize}})
    //         """;
}
