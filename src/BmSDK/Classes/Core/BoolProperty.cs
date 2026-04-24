using BmSDK.Framework;

namespace BmSDK;

public partial class BoolProperty
{
    /// <summary>
    /// The bitmask used to pack this bool into its containing int32.
    /// </summary>
    public int BitMask => MarshalUtil.ToManaged<int>(Ptr + 88);

    /// <summary>
    /// Reads this bit-packed bool from <paramref name="obj"/>.
    /// </summary>
    public bool GetValue(GameObject obj) => (MarshalUtil.ToManaged<int>(obj.Ptr + Offset) & BitMask) != 0;

    /// <summary>
    /// Writes this bit-packed bool to <paramref name="obj"/>, preserving other bits in the containing int32.
    /// </summary>
    public void SetValue(GameObject obj, bool value)
    {
        ref var packed = ref MarshalUtil.AsRef<int>(obj.Ptr + Offset);
        packed = value ? (packed | BitMask) : (packed & ~BitMask);
    }
}
