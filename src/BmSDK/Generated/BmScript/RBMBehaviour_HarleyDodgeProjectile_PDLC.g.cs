#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RBMBehaviour_HarleyDodgeProjectile_PDLC<br/>
/// (size = 456)
/// (flags = 8210)
/// </summary>
public partial class RBMBehaviour_HarleyDodgeProjectile_PDLC : BmSDK.BmScript.RBMBehaviour_HarleyDodgeProjectile, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RBMBehaviour_HarleyDodgeProjectile_PDLC", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_HarleyDodgeProjectile_PDLC() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_HarleyDodgeProjectile_PDLC
    /// </summary>
    public RBMBehaviour_HarleyDodgeProjectile_PDLC(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_HarleyDodgeProjectile_PDLC Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_HarleyDodgeProjectile_PDLC(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bFinishedTransIn
    /// </summary>
    public unsafe bool bFinishedTransIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 428); }
    }

    /// <summary>
    /// BoolProperty: bInTransOut
    /// </summary>
    public unsafe bool bInTransOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 428); }
    }

    /// <summary>
    /// StructProperty: StartLoc
    /// </summary>
    public unsafe System.Numerics.Vector3 StartLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// StructProperty: StartRot
    /// </summary>
    public unsafe BmSDK.Rotator StartRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }
}
