using BmSDK.Framework.Attributes;

namespace BmSDK.Framework;

[IntrinsicClass("Object")]
public abstract class UObject
{
    private readonly IntPtr _nativePtr;

    protected object GetPropertyValue(nint offset, string propClassName) =>
        throw new NotImplementedException();

    protected bool GetBoolPropertyValue(nint offset, int bit) =>
        throw new NotImplementedException();

    protected void SetPropertyValue(nint offset, string propClassName, object value) =>
        throw new NotImplementedException();
}
