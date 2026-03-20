#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_BaseballBatNoRagdoll<br/>
/// (size = 236)
/// (flags = 0)
/// </summary>
public partial class RDmgType_BaseballBatNoRagdoll : BmSDK.BmGame.RDmgType_Strike, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_BaseballBatNoRagdoll", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_BaseballBatNoRagdoll() { }

    /// <summary>
    /// Constructs a new RDmgType_BaseballBatNoRagdoll
    /// </summary>
    public RDmgType_BaseballBatNoRagdoll(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_BaseballBatNoRagdoll Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_BaseballBatNoRagdoll(nint ptr) : base(ptr) { }

}
