using BmSDK.Generator.Utils;
using UELib.Core;
using UELib.Flags;

namespace BmSDK.Generator.Templates;

static class PropTemplate
{
    public static FormattableString Render(UProperty prop)
    {
        var outer = (UStruct)prop.Outer;
        var managedTypeName = TypeMapper.GetManagedTypeForProp(prop, outer);

        // Are we overriding/hiding a field of a superclass?
        var isHidingSuper = outer
            .EnumerateSuper()
            .Any(super => super.EnumerateFields().Any(f => f.Name == prop.Name));

        // Format flags
        var flagsText =
            prop.PropertyFlags == 0
                ? ""
                : $" ({FlagUtils.DropUnknownBits((PropertyFlagsLO)prop.PropertyFlags)})";

        // Format layout info
        var layoutInfoText = $"(offset = {prop.PropertyOffset})";

        // Format getter/setter definitions
        var getterText = "";
        var setterText = "";
        if (prop is not UBoolProperty boolProp)
        {
            if (prop.Outer is UClass)
            {
                getterText =
                    $"get => GetPropertyValue<{managedTypeName}>(this, {prop.PropertyOffset});";
                setterText = $"set => SetPropertyValue(this, {prop.PropertyOffset}, value);";
            }
            else
            {
                getterText =
                    $"get => GameObject.GetPropertyValue<{managedTypeName}, {outer.ManagedName}>(ref this, {prop.PropertyOffset});";
                setterText =
                    $"set => GameObject.SetPropertyValue<{managedTypeName}, {outer.ManagedName}>(ref this, {prop.PropertyOffset}, value);";
            }
        }
        else
        {
            if (prop.Outer is UClass)
            {
                getterText =
                    $"get => (GetPropertyValue<int>(this, {prop.PropertyOffset}) & (1 << {boolProp.BitfieldIdx})) != 0;";

                // TODO: Setter
                setterText = "set => throw new NotImplementedException();";
            }
            else
            {
                getterText =
                    $"get => (GameObject.GetPropertyValue<int, {outer.ManagedName}>(ref this, {prop.PropertyOffset}) & (1 << {boolProp.BitfieldIdx})) != 0;";

                // TODO: Setter
                setterText = "set => throw new NotImplementedException();";
            }
        }

        return $$"""
            /// <summary>
            /// Property: {{prop.Name}}{{flagsText}}<br/>
            /// {{layoutInfoText}}
            /// </summary>
            public{{(isHidingSuper ? " new" : "")}} {{managedTypeName}} {{prop.ManagedName}}
            {
                {{getterText}}
                {{setterText}}
            }
            """;
    }
}
