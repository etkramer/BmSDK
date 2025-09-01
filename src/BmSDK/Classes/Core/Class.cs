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

    /// <summary>
    /// Returns the matching Type object for this class.
    /// </summary>
    public Type GetManagedType()
    {
        return StaticInit.GetManagedTypeForClassPath(GetPathName());
    }

    /// <summary>
    /// Returns the matching Class object for the given type.
    /// </summary>
    public static Class FindByManagedType(Type type)
    {
        return StaticFindObjectChecked<Class>(
            null,
            null,
            StaticInit.GetClassPathForManagedType(type),
            false
        );
    }
}
