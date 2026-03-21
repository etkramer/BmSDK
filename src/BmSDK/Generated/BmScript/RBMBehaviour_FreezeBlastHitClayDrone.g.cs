#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RBMBehaviour_FreezeBlastHitClayDrone<br/>
/// (size = 440)
/// (flags = 8210)
/// </summary>
public partial class RBMBehaviour_FreezeBlastHitClayDrone : BmSDK.BmGame.RBMBehaviour_FreezeBlastHit, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RBMBehaviour_FreezeBlastHitClayDrone", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_FreezeBlastHitClayDrone() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_FreezeBlastHitClayDrone
    /// </summary>
    public RBMBehaviour_FreezeBlastHitClayDrone(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_FreezeBlastHitClayDrone Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_FreezeBlastHitClayDrone(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: ActivateFreezeMats
    /// </summary>
    public unsafe virtual void ActivateFreezeMats()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RBMBehaviour_FreezeBlastHitClayDrone.ActivateFreezeMats", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Initialise
    /// </summary>
    public unsafe override void Initialise(BmSDK.BmGame.RPawnPlayer Instigator, System.Numerics.Vector3 HitNorm, bool bInstantFreeze = default, BmSDK.BmGame.RFreezeSprayProjectile Proj = default, bool bShouldAlwaysRagdoll = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RBMBehaviour_FreezeBlastHitClayDrone.Initialise", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Instigator, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNorm, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInstantFreeze, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Proj, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShouldAlwaysRagdoll, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// FloatProperty: TimeTillProjExplode
    /// </summary>
    public unsafe float TimeTillProjExplode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }
}
