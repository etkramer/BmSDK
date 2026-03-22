#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAnimNotify_ClipRootMotion<br/>
/// (size = 48)
/// (flags = 134230162)
/// </summary>
public partial class RAnimNotify_ClipRootMotion : BmSDK.BmGame.RAnimNotify_BeginEnd, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimNotify_ClipRootMotion", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimNotify_ClipRootMotion() { }

    /// <summary>
    /// Constructs a new RAnimNotify_ClipRootMotion
    /// </summary>
    public RAnimNotify_ClipRootMotion(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnimNotify_ClipRootMotion Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimNotify_ClipRootMotion(nint ptr) : base(ptr) { }

}
