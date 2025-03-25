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
            {{accessModifier}} unsafe {{returnType}} {{func.ManagedName}}({{RenderParams(
                func
            )}})
            {
                {{RenderBody(func)}}
            }
            """;
    }

    static FormattableString RenderBody(UFunction func)
    {
        var outerClass = (UClass)func.Outer;

        // Compute param layout
        func.ComputeLayoutInfo();

        // Fetch all params
        var paramProps = func.Params?.Where(param => param != func.ReturnProperty) ?? [];
        var paramStructSize =
            paramProps.Sum(param => param.ElementSize) + (func.ReturnProperty?.ElementSize ?? 0);

        // TODO: Handle static functions
        if (func.HasFunctionFlag(FunctionFlags.Static))
        {
            return $"throw new System.NotImplementedException();";
        }

        // TODO: Handle native functions
        if (func.HasFunctionFlag(FunctionFlags.Native))
        {
            return $"throw new System.NotImplementedException();";
        }

        var returnText = "return;";
        if (func.ReturnProperty is not null)
        {
            var returnType = TypeMapper.GetManagedTypeForProp(func.ReturnProperty, outerClass);
            returnText =
                $"return BmSDK.Framework.MarshalUtil.MarshalToManaged<{returnType}>(paramsPtr + {func.ReturnProperty.PropertyOffset});";
        }

        return $$"""
            var funcPtr = BmSDK.GameFunctions.FindFunction(Ptr, new FName("{{func.Name}}"),  0);
            var funcManaged = BmSDK.Framework.MarshalUtil.MarshalToManaged<Function>(&funcPtr);

            byte* paramsPtr = stackalloc byte[{{paramStructSize}}];
            {{
                paramProps.Select(prop => $"BmSDK.Framework.MarshalUtil.MarshalToNative({prop.Name}, paramsPtr + {prop.PropertyOffset});")
            }}

            BmSDK.GameFunctions.ProcessEvent(Ptr, funcPtr, (IntPtr)paramsPtr, 0);
            {{returnText}}
            """;
    }

    static string RenderParams(UFunction func)
    {
        var outerClass = (UClass)func.Outer;

        // Fetch all params
        var paramProps = func.Params?.Where(param => param != func.ReturnProperty) ?? [];

        // var paramsText = $"";
        var paramPropTexts = new List<string>();
        foreach (var paramProp in paramProps)
        {
            var paramType = TypeMapper.GetManagedTypeForProp(paramProp, outerClass);
            var paramIsOptional = paramProp.HasPropertyFlag(PropertyFlagsLO.OptionalParm);
            var paramIsReference = paramProp is UObjectProperty || paramProp is UStringProperty;

            // Compute param type name
            if (paramIsReference && paramIsOptional)
            {
                // Optional non-value params are nullable
                paramType += "?";
            }

            var paramText = $"{paramType} {paramProp.Name}";
            if (paramIsOptional)
            {
                paramText += " = default";
            }

            paramPropTexts.Add(paramText);
        }

        return string.Join(", ", paramPropTexts);
    }
}
