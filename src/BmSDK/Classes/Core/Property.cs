namespace BmSDK;

public partial class Property : Field
{
    /// <summary>
    /// Property: ArrayDim
    /// </summary>
    public int ArrayDim
    {
        get => GetPropertyValue<int>(this, 56);
    }

    /// <summary>
    /// Property: ElementSize
    /// </summary>
    public ushort ElementSize
    {
        get => GetPropertyValue<ushort>(this, 56 + 4);
    }

    /// <summary>
    /// Property: Offset
    /// </summary>
    public ushort Offset
    {
        get => GetPropertyValue<ushort>(this, 56 + 4 + 4 + 8 + 8 + 4);
    }

    /// <summary>
    /// Property: PropertyLinkNext
    /// </summary>
    public GameObject PropertyLinkNext
    {
        get => GetPropertyValue<GameObject>(this, 56 + 4 + 4 + 8 + 8 + 4 + 4);
    }
}
