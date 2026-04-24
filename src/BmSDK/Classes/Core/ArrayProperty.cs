using BmSDK.Framework;

namespace BmSDK;

public partial class ArrayProperty
{
    /// <summary>
    /// Returns the element count of the TArray stored in this property on <paramref name="obj"/>.
    /// The TArray header layout is { Data: ptr, Count: int32, Capacity: int32 }.
    /// </summary>
    public int GetCount(GameObject obj) =>
        MarshalUtil.ToManaged<int>(obj.Ptr + Offset + IntPtr.Size);
}
