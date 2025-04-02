namespace BmSDK;

public partial class Struct
{
    /// <summary>
    /// Property: PropertiesSize
    /// </summary>
    public int PropertiesSize
    {
        get => GetPropertyValue<int>(this, 56 + 4 + 4 + 4);
    }
}
