using BmSDK.Generator;
using UELib.Core;

static class ClassTemplate
{
    public static FormattableString Render(UClass classObj)
    {
        var propFields = classObj.EnumerateFields().OfType<UProperty>().ToArray();
        var enumFields = classObj.EnumerateFields().OfType<UEnum>().ToArray();
        var structFields = classObj.EnumerateFields().OfType<UScriptStruct>().ToArray();

        // Ignore private functions
        var funcFields = classObj
            .EnumerateFields()
            .OfType<UFunction>()
            .Where(func => !func.HasFunctionFlag(UELib.Flags.FunctionFlags.Private))
            .ToArray();

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

                /*  Functions ({{enumFields.Length}}) */
                {{funcFields.Select(FuncTemplate.Render)}}

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

        // Are we overriding/hiding a field of a superclass?
        var isHidingSuper = ((UClass)prop.Outer)
            .EnumerateSuper()
            .Any(super => super.EnumerateFields().Any(f => f.Name == prop.Name));

        // Special handling for bool props
        if (prop is UBoolProperty boolProp)
        {
            return RenderBoolProp(boolProp, isHidingSuper);
        }

        // Precompute class comment for cleanliness
        var classComment =
            $"// {((UField)prop.Class).ManagedName} (size = {prop.ElementSize}, offset = {prop.PropertyOffset}";

        return $$"""
            {{classComment}}
            public{{(isHidingSuper ? " new" : "")}} {{managedTypeName}} {{prop.ManagedName}}
            {
                get => GetPropertyValue<{{managedTypeName}}>({{prop.PropertyOffset}});
                set => SetPropertyValue({{prop.PropertyOffset}}, value);
            }
            """;
    }

    static FormattableString RenderBoolProp(UBoolProperty prop, bool isHidingSuper)
    {
        return $$"""
            // {{((UField)prop.Class).ManagedName}} (size = 1b, offset = {{prop.PropertyOffset}})
            public{{(isHidingSuper ? " new" : "")}} bool {{prop.ManagedName}}
            {
                get => GetBoolPropertyValue({{prop.PropertyOffset}}, {{prop.BitfieldIdx}});
                set => SetBoolPropertyValue({{prop.PropertyOffset}}, {{prop.BitfieldIdx}}, value);
            }
            """;
    }
}
