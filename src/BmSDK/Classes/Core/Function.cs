using BmSDK.Framework;

namespace BmSDK;

public partial class Function
{
    /// <summary>
    /// Property: FunctionFlags
    /// </summary>
    public EFunctionFlags FunctionFlags
    {
        get => MarshalUtil.ToManagedSafe<EFunctionFlags>(Ptr + 132);
        set => SetPropertyValue(this, 132, value);
    }

    /// <summary>
    /// Property: iNative
    /// </summary>
    public ushort iNative
    {
        get => MarshalUtil.ToManagedSafe<ushort>(Ptr + 136);
        set => SetPropertyValue(this, 136, value);
    }
}
