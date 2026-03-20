#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_CaltropsRagdoll<br/>
/// (size = 216)
/// (flags = 0)
/// </summary>
public partial class RDmgType_CaltropsRagdoll : BmSDK.BmGame.RDmgType_Ragdoll, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_CaltropsRagdoll", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_CaltropsRagdoll() { }

    /// <summary>
    /// Constructs a new RDmgType_CaltropsRagdoll
    /// </summary>
    public RDmgType_CaltropsRagdoll(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_CaltropsRagdoll Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_CaltropsRagdoll(nint ptr) : base(ptr) { }

}
