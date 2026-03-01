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
    public unsafe ref EFunctionFlags FunctionFlags => ref MarshalUtil.AsRef<EFunctionFlags>(Ptr + 108);

    /// <summary>
    /// Property: iNative
    /// </summary>
    public unsafe ref ushort iNative => ref MarshalUtil.AsRef<ushort>(Ptr + 112);

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
