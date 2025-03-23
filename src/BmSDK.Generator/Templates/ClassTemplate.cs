using BmSDK.Generator;
using UELib.Core;

static class ClassTemplate
{
    public static FormattableString Render(UClass classObj, ClassGenerator generator)
    {
        var enumFields = classObj.EnumerateFields().OfType<UEnum>().ToArray();
        var structFields = classObj.EnumerateFields().OfType<UScriptStruct>().ToArray();
        var propFields = classObj.EnumerateFields().OfType<UProperty>().ToArray();

        var superDecl = classObj.Super is null ? "" : $" : {generator.GetFullName(classObj.Super)}";

        return $$"""
            // class {{classObj.Package.PackageName}}.{{classObj.GetPath()}} (size = {{classObj.StructSize}})
            public{{(classObj.HasClassFlag(UELib.Flags.ClassFlags.Abstract) ? " abstract" : "")}} partial class {{classObj.ManagedName}} {{superDecl}}
            {
                {{propFields.Select(prop => RenderProperty(prop, generator))}}

                {{enumFields.Select(EnumTemplate.Render)}}

                {{structFields.Select(StructTemplate.Render)}}
            }
            """;
    }

    static FormattableString RenderProperty(UProperty prop, ClassGenerator generator)
    {
        var managedTypeName = generator.GetManagedTypeName(prop);

        // Special handling for bool props
        if (prop is UBoolProperty boolProp)
        {
            return RenderBoolProperty(boolProp);
        }

        return $$"""
            // {{((UField)prop.Class).ManagedName}} (size = {{prop.ElementSize}}, offset = {{prop.PropertyOffset}})
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
