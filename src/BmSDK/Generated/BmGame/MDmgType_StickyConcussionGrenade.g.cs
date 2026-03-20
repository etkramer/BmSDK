#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MDmgType_StickyConcussionGrenade<br/>
/// (size = 216)
/// (flags = 18)
/// </summary>
public partial class MDmgType_StickyConcussionGrenade : BmSDK.BmGame.RDmgType_SmokeBomb, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MDmgType_StickyConcussionGrenade", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MDmgType_StickyConcussionGrenade() { }

    /// <summary>
    /// Constructs a new MDmgType_StickyConcussionGrenade
    /// </summary>
    public MDmgType_StickyConcussionGrenade(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MDmgType_StickyConcussionGrenade Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MDmgType_StickyConcussionGrenade(nint ptr) : base(ptr) { }

}
