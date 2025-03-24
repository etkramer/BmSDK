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

        // Are we hiding a field of a superclass?
        var isHidingSuper = ((UClass)func.Outer)
            .EnumerateSuper()
            .Any(super => super.EnumerateFields().Any(f => f.Name == func.Name));

        // Add virtual/override keywords where needed
        List<string> funcDeclKeywords = isHidingSuper ? ["new"] : [];

        // Replace virtual keywords with static where needed
        if (func.HasFunctionFlag(FunctionFlags.Static))
        {
            funcDeclKeywords.Insert(0, "static");
        }

        // Convert keywords to string
        var keywordsText = string.Join(" ", funcDeclKeywords);
        if (keywordsText.Length > 0)
        {
            keywordsText = $" {keywordsText}";
        }

        // Format flags
        var flagsText =
            func.FunctionFlags == 0
                ? ""
                : $" ({FlagUtils.DropUnknownBits((FunctionFlags)func.FunctionFlags)})";

        return $$"""
            /// <summary>
            /// Function: {{func.Name}}{{flagsText}}
            /// </summary>
            {{accessModifier}}{{keywordsText}} {{returnType}} {{func.ManagedName}}({{string.Join(
                ", ",
                paramTypes
            )}}) => throw new System.NotImplementedException();
            """;
    }
}
