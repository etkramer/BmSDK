using BmSDK.Framework;

namespace BmSDK;

public partial class UClass
{
    /// <summary>
    /// Gets a pointer to the default object for this class.
    /// TODO: Marshal this correctly.
    /// </summary>
    public IntPtr GetDefaultObjectPtr()
    {
        return GameFunctions.GetDefaultObject(Ptr, 0);
    }
}
