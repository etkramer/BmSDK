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

        // Add static keyword
        var keywordsText = "unsafe";
        if (func.HasFunctionFlag(FunctionFlags.Static))
        {
            keywordsText += " static";
        }

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
            {{accessModifier}} {{keywordsText}} {{returnType}} {{func.ManagedName}}({{RenderParams(
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
        var funcIsStatic = func.HasFunctionFlag(FunctionFlags.Static);
        var funcIsNative = func.HasFunctionFlag(FunctionFlags.Native);

        // TODO: Fix layout computation
        func.ComputeLayoutInfo();

        // Fetch all params
        var paramProps = func.Params?.Where(param => param != func.ReturnProperty) ?? [];

        var preText = "";
        var postText = "";

        // TODO: Handle native functions
        if (funcIsNative)
        {
            // Set function props before call.
            preText += "\nvar oldFlags = funcManaged.FunctionFlags;\n";
            preText += "var oldNative = funcManaged.iNative;\n";
            preText += "funcManaged.FunctionFlags &= ~EFunctionFlags.Native;\n";
            preText += "funcManaged.FunctionFlags |= EFunctionFlags.Defined;\n";
            preText += "funcManaged.iNative = 0;";

            // Unset function props after call.
            postText += "funcManaged.iNative = oldNative;\n";
            postText += "funcManaged.FunctionFlags = oldFlags;\n";
        }

        var returnText = "return;";
        if (func.ReturnProperty is not null)
        {
            var returnType = TypeMapper.GetManagedTypeForProp(func.ReturnProperty, outerClass);
            returnText =
                $"return BmSDK.Framework.MarshalUtil.MarshalToManaged<{returnType}>(paramsPtr + {func.ReturnProperty.PropertyOffset});";
        }

        var ptrText = funcIsStatic ? "StaticClass().Ptr" : "Ptr";

        return $$"""
            var funcPtr = BmSDK.GameFunctions.FindFunction({{ptrText}}, new FName("{{func.Name}}"),  0);
            var funcManaged = BmSDK.Framework.MarshalUtil.MarshalToManaged<Function>(&funcPtr);

            byte* paramsPtr = stackalloc byte[{{func.StructSize}}];
            {{
                paramProps.Select(prop => $"BmSDK.Framework.MarshalUtil.MarshalToNative({prop.Name}, paramsPtr + {prop.PropertyOffset});")
            }}
            {{preText}}
            BmSDK.GameFunctions.ProcessEvent({{ptrText}}, funcPtr, (IntPtr)paramsPtr, 0);
            {{postText}}
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
