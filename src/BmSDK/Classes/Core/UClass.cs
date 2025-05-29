using BmSDK.Framework;

namespace BmSDK;

public partial class UClass
{
    /// <summary>
    /// Gets the default object for this class.
    /// </summary>
    public unsafe UObject DefaultObject
    {
        get
        {
            var ptr = GameFunctions.GetDefaultObject(Ptr, 0);
            return MarshalUtil.ToManaged<UObject>(&ptr);
        }
    }
}
