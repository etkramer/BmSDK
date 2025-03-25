using BmSDK.Generator.Utils;
using UELib.Core;
using UELib.Flags;

namespace BmSDK.Generator.Templates;

static class FuncTemplate
{
    public static FormattableString Render(UFunction func)
    {
        var outerClass = (UClass)func.Outer;

        // Compute return type name ahead of time
        var returnProp = func.ReturnProperty;
        var returnType = returnProp is null
            ? "void"
            : TypeMapper.GetManagedTypeForProp(returnProp, outerClass);

        // Compute param type names ahead of time
        var paramTypes = func.Params is null
            ? []
            : func
                .Params.Where(param => param != returnProp)
                .Select(param =>
                    $"{TypeMapper.GetManagedTypeForProp(param, outerClass)} {param.Name}"
                )
                .ToArray();

        // Compute access modifier ahead of time
        var accessModifier = func.HasFunctionFlag(FunctionFlags.Protected) ? "protected" : "public";

        // Format flags
        var flagsText =
            func.FunctionFlags == 0
                ? ""
                : $" ({FlagUtils.DropUnknownBits((FunctionFlags)func.FunctionFlags)})";

        return $$"""
            /// <summary>
            /// Function: {{func.Name}}{{flagsText}}
            /// </summary>
            {{accessModifier}} {{returnType}} {{func.ManagedName}}({{string.Join(
                ", ",
                paramTypes
            )}}) => throw new System.NotImplementedException();
            """;
    }
}
