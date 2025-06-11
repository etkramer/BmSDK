using BmSDK.Framework;

namespace BmSDK;

public partial class Class
{
    /// <summary>
    /// Gets the default object for this class.
    /// </summary>
    public unsafe GameObject DefaultObject
    {
        get
        {
            var ptr = GameFunctions.GetDefaultObject(Ptr, 0);
            return MarshalUtil.ToManaged<GameObject>(&ptr);
        }
    }
}
