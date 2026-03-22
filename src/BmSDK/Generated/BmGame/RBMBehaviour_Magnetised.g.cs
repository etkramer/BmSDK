#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_Magnetised<br/>
/// (size = 436)
/// (flags = 8210)
/// </summary>
public partial class RBMBehaviour_Magnetised : BmSDK.BmGame.RBMBehaviour, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_Magnetised", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_Magnetised() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_Magnetised
    /// </summary>
    public RBMBehaviour_Magnetised(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_Magnetised Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_Magnetised(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: CanCheckFalling
    /// </summary>
    public unsafe override bool CanCheckFalling()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBehaviour_Magnetised.CanCheckFalling", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CanHitLaserGrid
    /// </summary>
    public unsafe override bool CanHitLaserGrid()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBehaviour_Magnetised.CanHitLaserGrid", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: OnDeactivate
    /// </summary>
    public unsafe override void OnDeactivate()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBehaviour_Magnetised.OnDeactivate", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ResetRagdoll
    /// </summary>
    public unsafe virtual void ResetRagdoll()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBehaviour_Magnetised.ResetRagdoll", true);
        byte* paramsPtr = stackalloc byte[244];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnActivate
    /// </summary>
    public unsafe override void OnActivate()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBehaviour_Magnetised.OnActivate", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayMagnetised
    /// </summary>
    public unsafe virtual void PlayMagnetised(float StartTime = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBehaviour_Magnetised.PlayMagnetised", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// FloatProperty: ShockTime
    /// </summary>
    public unsafe float ShockTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// ClassProperty: dmgType
    /// </summary>
    public unsafe BmSDK.Class dmgType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// BoolProperty: bKillWhenFinished
    /// </summary>
    public unsafe bool bKillWhenFinished
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 404) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 404); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 404); }
    }

    /// <summary>
    /// BoolProperty: bMagnetisedWhileInRagdoll
    /// </summary>
    public unsafe bool bMagnetisedWhileInRagdoll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 404) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 404); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 404); }
    }

    /// <summary>
    /// BoolProperty: bHitByWeapon
    /// </summary>
    public unsafe bool bHitByWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 404) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 404); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 404); }
    }

    /// <summary>
    /// BoolProperty: bResetRagdoll
    /// </summary>
    public unsafe bool bResetRagdoll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 404) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 404); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 404); }
    }

    /// <summary>
    /// ObjectProperty: Player
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer Player
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// ObjectProperty: ArmouredThugAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet ArmouredThugAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// StructProperty: MagImpactDirection
    /// </summary>
    public unsafe System.Numerics.Vector3 MagImpactDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// StructProperty: Transition
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId Transition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// FloatProperty: OldMagnetisedAnimTime
    /// </summary>
    public unsafe float OldMagnetisedAnimTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }
}
