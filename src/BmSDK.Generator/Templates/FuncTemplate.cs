using BmSDK.Generator;
using UELib.Core;

static class FuncTemplate
{
    public static FormattableString Render(UFunction func)
    {
        // Compute return type name ahead of time
        var returnProp = func.ReturnProperty;
        var returnType = returnProp is null ? "void" : TypeMapper.GetManagedTypeForProp(returnProp);

        // Compute param type names ahead of time
        var paramTypes = func.Params is null
            ? []
            : func
                .Params.Where(param => param != returnProp)
                .Select(param => $"{TypeMapper.GetManagedTypeForProp(param)} {param.Name}")
                .ToArray();

        // Compute access modifier ahead of time
        var accessModifier = func.HasFunctionFlag(UELib.Flags.FunctionFlags.Protected)
            ? "protected"
            : "public";

        // Are we hiding a field of a superclass?
        var isHidingSuper = ((UClass)func.Outer)
            .EnumerateSuper()
            .Any(super => super.EnumerateFields().Any(f => f.Name == func.Name));

        // Add virtual/override keywords where needed
        List<string> funcDeclKeywords = isHidingSuper ? ["new"] : [];

        // Replace virtual keywords with static where needed
        if (func.HasFunctionFlag(UELib.Flags.FunctionFlags.Static))
        {
            funcDeclKeywords.Insert(0, "static");
        }

        // Convert keywords to string
        var funcDeclKeywordsStr = string.Join(" ", funcDeclKeywords);
        if (funcDeclKeywordsStr.Length > 0)
        {
            funcDeclKeywordsStr = $" {funcDeclKeywordsStr}";
        }

        return $$"""
            {{accessModifier}}{{funcDeclKeywordsStr}} {{returnType}} {{func.ManagedName}}({{string.Join(
                ", ",
                paramTypes
            )}})
            {
                throw new System.NotImplementedException();
            }
            """;
    }
}
