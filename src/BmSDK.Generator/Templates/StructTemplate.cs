using UELib.Core;

static class StructTemplate
{
    public static FormattableString Render(UStruct structObj)
    {
        var propFields = structObj.EnumerateFields().OfType<UProperty>().ToArray();
        var superDecl = structObj.Super is null ? "" : $" /* : {structObj.Super.ManagedName} */";

        return $$"""
            [StructLayout(LayoutKind.Explicit, Size={{structObj.StructSize}})]
            public struct {{structObj.ManagedName}} {{superDecl}}
            {
                {{propFields.Select(RenderStructField)}}
            }
            """;
    }

    static FormattableString RenderStructField(UProperty prop) =>
        $$"""
            [FieldOffset({{prop.PropertyOffset}})]
            public int {{prop.ManagedName}}; // {{(
                (UField)prop.Class
            ).ManagedName}} (size = {{prop.ElementSize}})
            """;
}
