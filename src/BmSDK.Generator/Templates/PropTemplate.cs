using BmSDK.Generator.Utils;
using UELib.Core;
using UELib.Flags;

namespace BmSDK.Generator.Templates;

static class PropTemplate
{
    public static FormattableString Render(UProperty prop)
    {
        var outerClass = (UClass)prop.Outer;
        var managedTypeName = TypeMapper.GetManagedTypeForProp(prop, outerClass);

        // Are we overriding/hiding a field of a superclass?
        var isHidingSuper = outerClass
            .EnumerateSuper()
            .Any(super => super.EnumerateFields().Any(f => f.Name == prop.Name));

        // Format flags
        var flagsText =
            prop.PropertyFlags == 0
                ? ""
                : $" ({FlagUtils.DropUnknownBits((PropertyFlagsLO)prop.PropertyFlags)})";

        // Format layout info
        var layoutInfoText = $"(offset = 0x{prop.PropertyOffset - outerClass.StructStartOffset:X})";

        // Format getter/setter definitions
        var getterText = $"get => GetPropertyValue<{managedTypeName}>({prop.PropertyOffset});";
        var setterText = $"set => SetPropertyValue({prop.PropertyOffset}, value);";
        if (prop is UBoolProperty boolProp)
        {
            getterText =
                $"get => GetBoolPropertyValue({boolProp.PropertyOffset}, {boolProp.BitfieldIdx});";
            setterText =
                $"set => SetBoolPropertyValue({boolProp.PropertyOffset}, {boolProp.BitfieldIdx}, value);";
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
