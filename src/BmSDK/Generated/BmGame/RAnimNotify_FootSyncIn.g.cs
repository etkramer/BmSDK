#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAnimNotify_FootSyncIn<br/>
/// (size = 44)
/// (flags = 134230162)
/// </summary>
public partial class RAnimNotify_FootSyncIn : BmSDK.Engine.AnimNotify, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimNotify_FootSyncIn", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimNotify_FootSyncIn() { }

    /// <summary>
    /// Constructs a new RAnimNotify_FootSyncIn
    /// </summary>
    public RAnimNotify_FootSyncIn(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnimNotify_FootSyncIn Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimNotify_FootSyncIn(nint ptr) : base(ptr) { }

}
