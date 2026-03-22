#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAnimNotify_Clip<br/>
/// (size = 48)
/// (flags = 134230162)
/// </summary>
public partial class RAnimNotify_Clip : BmSDK.BmGame.RAnimNotify_BeginEnd, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimNotify_Clip", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimNotify_Clip() { }

    /// <summary>
    /// Constructs a new RAnimNotify_Clip
    /// </summary>
    public RAnimNotify_Clip(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnimNotify_Clip Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimNotify_Clip(nint ptr) : base(ptr) { }

}
