#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMRagdollBoneFollower<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMRagdollBoneFollower : BmSDK.Engine.ActorComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMRagdollBoneFollower", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMRagdollBoneFollower() { }

    /// <summary>
    /// Constructs a new RBMRagdollBoneFollower
    /// </summary>
    public RBMRagdollBoneFollower(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMRagdollBoneFollower Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMRagdollBoneFollower(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: Location
    /// </summary>
    public unsafe System.Numerics.Vector3 Location
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }
}
