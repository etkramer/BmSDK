#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_AimPhysicsVelocity<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqAct_AimPhysicsVelocity : BmSDK.BmGame.RSeqAct_SetPhysicsVelocity, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_AimPhysicsVelocity", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_AimPhysicsVelocity() { }

    /// <summary>
    /// Constructs a new RSeqAct_AimPhysicsVelocity
    /// </summary>
    public RSeqAct_AimPhysicsVelocity(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_AimPhysicsVelocity Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_AimPhysicsVelocity(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: AimAt
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> AimAt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// FloatProperty: Speed
    /// </summary>
    public unsafe float Speed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// FloatProperty: RandomOffset
    /// </summary>
    public unsafe float RandomOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }
}
