using BmSDK.Generator;
using UELib.Core;

static class ClassTemplate
{
    public static FormattableString Render(UClass classObj)
    {
        var propFields = classObj.EnumerateFields().OfType<UProperty>().ToArray();
        var enumFields = classObj.EnumerateFields().OfType<UEnum>().ToArray();
        var structFields = classObj.EnumerateFields().OfType<UScriptStruct>().ToArray();

        // Get super class decl
        var classDeclSuper = "";
        if (classObj.Super is not null)
        {
            classDeclSuper = $" : {TypeMapper.GetManagedPathForType(classObj.Super)}";
        }

        // Add keywords for class attributes
        var classDeclKeywords = "";
        if (classObj.HasClassFlag(UELib.Flags.ClassFlags.Abstract))
        {
            classDeclKeywords = " abstract";
        }

        return $$"""
            // class {{classObj.Package.PackageName}}.{{classObj.GetPath()}} (size = {{classObj.StructSize}})
            public{{classDeclKeywords}} partial class {{classObj.ManagedName}}{{classDeclSuper}}
            {
                /*  Properties ({{propFields.Length}}) */
                {{propFields.Select(RenderProp)}}

                /*  Enums ({{enumFields.Length}}) */
                {{enumFields.Select(EnumTemplate.Render)}}

                /*  Structs ({{structFields.Length}}) */
                {{structFields.Select(StructTemplate.Render)}}
            }
            """;
    }

    static FormattableString RenderProp(UProperty prop)
    {
        var managedTypeName = TypeMapper.GetManagedTypeForProp(prop);

        // Special handling for bool props
        if (prop is UBoolProperty boolProp)
        {
            return RenderBoolProperty(boolProp);
        }

        // Precompute class comment for cleanliness
        var classComment =
            $"// {((UField)prop.Class).ManagedName} (size = {prop.ElementSize}, offset = {prop.PropertyOffset}";

        return $$"""
            {{classComment}}
            public {{managedTypeName}} {{prop.ManagedName}}
            {
                get => GetPropertyValue<{{managedTypeName}}>({{prop.PropertyOffset}});
                set => SetPropertyValue({{prop.PropertyOffset}}, value);
            }
            """;
    }

    static FormattableString RenderBoolProperty(UBoolProperty prop)
    {
        return $$"""
            // {{((UField)prop.Class).ManagedName}} (size = 1b, offset = {{prop.PropertyOffset}})
            public bool {{prop.ManagedName}}
            {
                get => GetBoolPropertyValue({{prop.PropertyOffset}}, {{prop.BitfieldIdx}});
                set => SetBoolPropertyValue({{prop.PropertyOffset}}, {{prop.BitfieldIdx}}, value);
            }
            """;
    }
}
