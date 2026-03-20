#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_RicochetStick<br/>
/// (size = 216)
/// (flags = 18)
/// </summary>
public partial class RDmgType_RicochetStick : BmSDK.BmGame.RDmgType_StealthBatarang, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_RicochetStick", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_RicochetStick() { }

    /// <summary>
    /// Constructs a new RDmgType_RicochetStick
    /// </summary>
    public RDmgType_RicochetStick(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_RicochetStick Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_RicochetStick(nint ptr) : base(ptr) { }

}
