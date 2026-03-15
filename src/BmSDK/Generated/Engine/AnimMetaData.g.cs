#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// ABSTRACT Class: AnimMetaData<br/>
/// (size = 44)
/// (flags = 134230163)
/// </summary>
public partial class AnimMetaData : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AnimMetaData", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AnimMetaData() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AnimMetaData(nint ptr) : base(ptr) { }

}
