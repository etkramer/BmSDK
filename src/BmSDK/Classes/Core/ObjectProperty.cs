using BmSDK.Framework;

namespace BmSDK;

public partial class ObjectProperty
{
    /// <summary>
    /// Reads the object reference stored in this property on <paramref name="obj"/>.
    /// Returns null if the reference is unset.
    /// </summary>
    public GameObject? GetValue(GameObject obj) =>
        FromPtr(MarshalUtil.ToManaged<IntPtr>(obj.Ptr + Offset));

    /// <summary>
    /// Writes <paramref name="value"/> into this property on <paramref name="obj"/>.
    /// Pass null to clear the reference.
    /// </summary>
    public void SetValue(GameObject obj, GameObject? value) =>
        MarshalUtil.ToUnmanaged(value?.Ptr ?? IntPtr.Zero, obj.Ptr + Offset);
}
