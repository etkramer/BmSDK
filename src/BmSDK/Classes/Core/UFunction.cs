using BmSDK.Framework;

namespace BmSDK;

public partial class UFunction
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

    /// <summary>
    /// Property: FunctionFlags
    /// </summary>
    public EFunctionFlags FunctionFlags
    {
        get => MarshalUtil.ToManaged<EFunctionFlags>(Ptr + 108);
        set => SetPropertyValue(this, 108, value);
    }

    /// <summary>
    /// Property: iNative
    /// </summary>
    public ushort iNative
    {
        get => MarshalUtil.ToManaged<ushort>(Ptr + 112);
        set => SetPropertyValue(this, 112, value);
    }
}
