#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAnimNotify_CanCorrectAfterHere<br/>
/// (size = 44)
/// (flags = 134230162)
/// </summary>
public partial class RAnimNotify_CanCorrectAfterHere : BmSDK.Engine.AnimNotify, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimNotify_CanCorrectAfterHere", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimNotify_CanCorrectAfterHere() { }

    /// <summary>
    /// Constructs a new RAnimNotify_CanCorrectAfterHere
    /// </summary>
    public RAnimNotify_CanCorrectAfterHere(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnimNotify_CanCorrectAfterHere Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimNotify_CanCorrectAfterHere(nint ptr) : base(ptr) { }

}
