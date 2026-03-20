#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RActorFactoryRigidBody<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RActorFactoryRigidBody : BmSDK.Engine.ActorFactoryRigidBody, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RActorFactoryRigidBody", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RActorFactoryRigidBody() { }

    /// <summary>
    /// Constructs a new RActorFactoryRigidBody
    /// </summary>
    public RActorFactoryRigidBody(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RActorFactoryRigidBody Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RActorFactoryRigidBody(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bDoDamage
    /// </summary>
    public unsafe bool bDoDamage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 216) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 216); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 216); }
    }

    /// <summary>
    /// BoolProperty: bDontBlockActors
    /// </summary>
    public unsafe bool bDontBlockActors
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 216) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 216); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 216); }
    }
}
