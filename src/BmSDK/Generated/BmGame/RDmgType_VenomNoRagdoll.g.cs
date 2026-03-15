#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_VenomNoRagdoll<br/>
/// (size = 120)
/// (flags = 18)
/// </summary>
public partial class RDmgType_VenomNoRagdoll : BmSDK.BmGame.RDmgType_Venom, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_VenomNoRagdoll", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_VenomNoRagdoll() { }

    /// <summary>
    /// Constructs a new RDmgType_VenomNoRagdoll
    /// </summary>
    public RDmgType_VenomNoRagdoll(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_VenomNoRagdoll Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_VenomNoRagdoll(nint ptr) : base(ptr) { }

}
