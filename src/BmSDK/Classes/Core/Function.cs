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
