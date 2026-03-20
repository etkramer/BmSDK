#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SeqEvent_RigidBodyCollision<br/>
/// (size = 384)
/// (flags = 134217874)
/// </summary>
public partial class SeqEvent_RigidBodyCollision : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SeqEvent_RigidBodyCollision", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqEvent_RigidBodyCollision() { }

    /// <summary>
    /// Constructs a new SeqEvent_RigidBodyCollision
    /// </summary>
    public SeqEvent_RigidBodyCollision(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqEvent_RigidBodyCollision Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqEvent_RigidBodyCollision(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: MinCollisionVelocity
    /// </summary>
    public unsafe float MinCollisionVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }
}
