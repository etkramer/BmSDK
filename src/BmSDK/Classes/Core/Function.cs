namespace BmSDK;

public sealed class Function : Struct
{
    // TODO

    /// <summary>
    /// Property: FunctionFlags
    /// </summary>
    public int FunctionFlags
    {
        get => GetPropertyValue<int>(this, 136);
        set => SetPropertyValue(this, 136, value);
    }
}
