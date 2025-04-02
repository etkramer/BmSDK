namespace BmSDK;

public partial class Function
{
    /// <summary>
    /// Property: FunctionFlags
    /// </summary>
    public EFunctionFlags FunctionFlags
    {
        get => GetPropertyValue<EFunctionFlags>(this, 132);
        set => SetPropertyValue(this, 132, value);
    }

    /// <summary>
    /// Property: iNative
    /// </summary>
    public ushort iNative
    {
        get => GetPropertyValue<ushort>(this, 136);
        set => SetPropertyValue(this, 136, value);
    }
}
