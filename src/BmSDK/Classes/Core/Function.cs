using BmSDK.Framework;

namespace BmSDK;

public partial class Function
{
    [Flags]
    public enum EFunctionFlags
    {
        FUNC_Defined = 0x2,
        FUNC_Iterator = 0x4,
        FUNC_Native = 0x400,
        FUNC_Event = 0x800,
        FUNC_Operator = 0x1000,
        FUNC_Static = 0x2000,
    }

    public bool IsStatic => FunctionFlags.HasFlag(EFunctionFlags.FUNC_Static);

    /// <summary>
    /// Property: FunctionFlags
    /// </summary>
    public unsafe EFunctionFlags FunctionFlags
    {
        get => MarshalUtil.ToManaged<EFunctionFlags>(Ptr + 108);
        set => MarshalUtil.ToUnmanaged(value, (Ptr + 108).ToPointer());
    }

    /// <summary>
    /// Property: iNative
    /// </summary>
    public unsafe ushort iNative
    {
        get => MarshalUtil.ToManaged<ushort>(Ptr + 112);
        set => MarshalUtil.ToUnmanaged(value, (Ptr + 112).ToPointer());
    }

    public unsafe object? Invoke(GameObject? obj, params object[] args)
    {
        var paramFields = EnumerateParams().ToArray();
        var paramsSize = PropertiesSize;
        var paramsPtr = stackalloc byte[paramsSize];

        Guard.Require(
            args.Length >= paramFields.Length,
            $"Not enough args passed to {Name}.Invoke() (expected {paramFields.Length}, got {args.Length})"
        );

        Guard.Require(IsStatic || obj is not null, $"Got unexpected null in {Name}.Invoke()");

        // Marshal args
        for (var i = 0; i < args.Length; i++)
        {
            var argType = MarshalUtil.GetTypeFromProperty(paramFields[i]);
            MarshalUtil.ToUnmanaged(args[i], (nint)paramsPtr + paramFields[i].Offset, argType);
        }

        // Execute function via ProcessEvent
        var oldFlags = FunctionFlags;
        var oldNative = iNative;
        FunctionFlags &= ~EFunctionFlags.FUNC_Native;
        FunctionFlags |= EFunctionFlags.FUNC_Defined;
        iNative = 0;
        GameFunctions.ProcessEvent(
            IsStatic ? StaticClass().DefaultObject.Ptr : obj!.Ptr,
            Ptr,
            (nint)paramsPtr,
            0
        );
        iNative = oldNative;
        FunctionFlags = oldFlags;

        // Marshal result back (if non-void)
        var returnParam = GetReturnParam();
        if (returnParam is not null)
        {
            var returnType = MarshalUtil.GetTypeFromProperty(returnParam);
            return MarshalUtil.ToManaged((nint)paramsPtr + returnParam.Offset, returnType);
        }

        return null;
    }

    public Property? GetReturnParam() =>
        EnumerateParams()
            .FirstOrDefault(param =>
                param.PropertyFlags.HasFlag(Property.EPropertyFlags.CPF_ReturnParm)
            );

    public IEnumerable<Property> EnumerateParams()
    {
        return EnumerateFields()
            .OfType<Property>()
            .Where(prop =>
                prop.PropertyFlags.HasFlag(Property.EPropertyFlags.CPF_Parm)
                && !prop.PropertyFlags.HasFlag(Property.EPropertyFlags.CPF_ReturnParm)
            );
    }
}
