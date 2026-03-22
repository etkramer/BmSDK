#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK;

/// <summary>
/// ABSTRACT Class: Field<br/>
/// (size = 48)
/// (flags = 268435585)
/// </summary>
public partial class Field : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Core.Field", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal Field() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected Field(nint ptr) : base(ptr) { }

}
