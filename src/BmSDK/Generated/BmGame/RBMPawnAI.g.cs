#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMPawnAI<br/>
/// (flags = 0)
/// </summary>
public partial class RBMPawnAI : BmSDK.BmGame.RBMPawnAIAnim, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMPawnAI", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMPawnAI() { }

    /// <summary>
    /// Constructs a new RBMPawnAI
    /// </summary>
    public RBMPawnAI(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMPawnAI Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMPawnAI(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMPawnAI>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMPawnAI>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMPawnAI>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMPawnAI>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMPawnAI>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMPawnAI>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMPawnAI>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// StructProperty: VfTable_IInterface_NavigationHandle
    /// </summary>
    public unsafe System.IntPtr VfTable_IInterface_NavigationHandle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 3340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3340); }
    }

    /// <summary>
    /// StructProperty: BodyDirtStates
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI.FBodyDirtState BodyDirtStates_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI.FBodyDirtState>(Ptr + 3348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3348); }
    }
    /// <summary>
    /// StructProperty: BodyDirtStates
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI.FBodyDirtState BodyDirtStates_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI.FBodyDirtState>(Ptr + 3376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3376); }
    }
    /// <summary>
    /// StructProperty: BodyDirtStates
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI.FBodyDirtState BodyDirtStates_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI.FBodyDirtState>(Ptr + 3404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3404); }
    }
    /// <summary>
    /// StructProperty: BodyDirtStates
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI.FBodyDirtState BodyDirtStates_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI.FBodyDirtState>(Ptr + 3432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3432); }
    }

    /// <summary>
    /// IntProperty: FacialDirtLevel
    /// </summary>
    public unsafe int FacialDirtLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3460); }
    }

    /// <summary>
    /// IntProperty: FacialDamageLevel
    /// </summary>
    public unsafe int FacialDamageLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3464); }
    }

    /// <summary>
    /// ArrayProperty: FacialDamageParameters
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> FacialDamageParameters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 3468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3468); }
    }

    /// <summary>
    /// ArrayProperty: FacialDamageValues
    /// </summary>
    public unsafe BmSDK.TArray<float> FacialDamageValues
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 3484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3484); }
    }

    /// <summary>
    /// FloatProperty: ExplosionDamageLevel
    /// </summary>
    public unsafe float ExplosionDamageLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3500); }
    }

    /// <summary>
    /// IntProperty: BatarangDamageLevel
    /// </summary>
    public unsafe int BatarangDamageLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3504); }
    }

    /// <summary>
    /// IntProperty: DyeSprayLevel
    /// </summary>
    public unsafe int DyeSprayLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3508); }
    }

    /// <summary>
    /// StrProperty: BodySize
    /// </summary>
    public unsafe BmSDK.FString BodySize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 3512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3512); }
    }

    /// <summary>
    /// BoolProperty: bHasGasMask
    /// </summary>
    public unsafe bool bHasGasMask
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bFallBackToNavMeshFloor
    /// </summary>
    public unsafe bool bFallBackToNavMeshFloor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bDoPhysWalkingPointChecks
    /// </summary>
    public unsafe bool bDoPhysWalkingPointChecks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bBlockOtherPawns
    /// </summary>
    public unsafe bool bBlockOtherPawns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bDoPhysWalkingHeightSmoothing
    /// </summary>
    public unsafe bool bDoPhysWalkingHeightSmoothing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bDontTurnOffGeoFloorChecksAtRange
    /// </summary>
    public unsafe bool bDontTurnOffGeoFloorChecksAtRange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bPrevDoGeoFloorChecks
    /// </summary>
    public unsafe bool bPrevDoGeoFloorChecks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreRagdollPositionWhenSettingLocation
    /// </summary>
    public unsafe bool bIgnoreRagdollPositionWhenSettingLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bCanSeeThroughGlassCeilings
    /// </summary>
    public unsafe bool bCanSeeThroughGlassCeilings
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bFriendly
    /// </summary>
    public unsafe bool bFriendly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bCrowd
    /// </summary>
    public unsafe bool bCrowd
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bKeepWeapon
    /// </summary>
    public unsafe bool bKeepWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bSilentPredAI
    /// </summary>
    public unsafe bool bSilentPredAI
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bIsLitePred
    /// </summary>
    public unsafe bool bIsLitePred
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bTriggerPredAlerts
    /// </summary>
    public unsafe bool bTriggerPredAlerts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bDoPredatorVision
    /// </summary>
    public unsafe bool bDoPredatorVision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bSniper
    /// </summary>
    public unsafe bool bSniper
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bCanPickupSniperRifleSniper
    /// </summary>
    public unsafe bool bCanPickupSniperRifleSniper
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bRocketLauncher
    /// </summary>
    public unsafe bool bRocketLauncher
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bCombatMirrored
    /// </summary>
    public unsafe bool bCombatMirrored
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bCanBeDisarmedByMagBlast
    /// </summary>
    public unsafe bool bCanBeDisarmedByMagBlast
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bMagneticBlastClingToWeapon
    /// </summary>
    public unsafe bool bMagneticBlastClingToWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bDodgedMagneticBlastDisarm
    /// </summary>
    public unsafe bool bDodgedMagneticBlastDisarm
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bInstantEnterCombatOnMagBlast
    /// </summary>
    public unsafe bool bInstantEnterCombatOnMagBlast
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bForceNavMeshObstacleUpdate
    /// </summary>
    public unsafe bool bForceNavMeshObstacleUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bApplySoftPawnCollision
    /// </summary>
    public unsafe bool bApplySoftPawnCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bReceiveSoftPawnCollision
    /// </summary>
    public unsafe bool bReceiveSoftPawnCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bDoPlayerCollision
    /// </summary>
    public unsafe bool bDoPlayerCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bApplyRouterPawnAvoidance
    /// </summary>
    public unsafe bool bApplyRouterPawnAvoidance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bTickGunFire
    /// </summary>
    public unsafe bool bTickGunFire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bFireOnceOnly
    /// </summary>
    public unsafe bool bFireOnceOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bForceBehaviourTickEveryFrame
    /// </summary>
    public unsafe bool bForceBehaviourTickEveryFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3528); }
    }

    /// <summary>
    /// BoolProperty: bWeaponCanBePickedUp
    /// </summary>
    public unsafe bool bWeaponCanBePickedUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bWeaponCanBePickedUpOnlyBySelf
    /// </summary>
    public unsafe bool bWeaponCanBePickedUpOnlyBySelf
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bWeaponWasJammed
    /// </summary>
    public unsafe bool bWeaponWasJammed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bDisableCornerSliding
    /// </summary>
    public unsafe bool bDisableCornerSliding
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bAttackASAP
    /// </summary>
    public unsafe bool bAttackASAP
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bForceConstantGroundChecks
    /// </summary>
    public unsafe bool bForceConstantGroundChecks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bWanderingAI
    /// </summary>
    public unsafe bool bWanderingAI
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bCanCrossLevelVolumes
    /// </summary>
    public unsafe bool bCanCrossLevelVolumes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysShovePawns
    /// </summary>
    public unsafe bool bAlwaysShovePawns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bDontShowPredatorEscapeInstructions
    /// </summary>
    public unsafe bool bDontShowPredatorEscapeInstructions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bAwardXPOnDeath
    /// </summary>
    public unsafe bool bAwardXPOnDeath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bSpawnedInRiot
    /// </summary>
    public unsafe bool bSpawnedInRiot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bTriggerBatarangCamera
    /// </summary>
    public unsafe bool bTriggerBatarangCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bFadeOutAfterDeath
    /// </summary>
    public unsafe bool bFadeOutAfterDeath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bStreamWeapon
    /// </summary>
    public unsafe bool bStreamWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bShouldPlayFleeReaction
    /// </summary>
    public unsafe bool bShouldPlayFleeReaction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bWaitForTransToEndBeforeFleeReaction
    /// </summary>
    public unsafe bool bWaitForTransToEndBeforeFleeReaction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bCanBeXrayed
    /// </summary>
    public unsafe bool bCanBeXrayed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bTreatXrayAsOverworld
    /// </summary>
    public unsafe bool bTreatXrayAsOverworld
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bTreatAsOverworldForStasis
    /// </summary>
    public unsafe bool bTreatAsOverworldForStasis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bBatarangCanKill
    /// </summary>
    public unsafe bool bBatarangCanKill
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bBatarangCantTarget
    /// </summary>
    public unsafe bool bBatarangCantTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bDontReactToBatarang
    /// </summary>
    public unsafe bool bDontReactToBatarang
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysDodgeBatarang
    /// </summary>
    public unsafe bool bAlwaysDodgeBatarang
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bForceBatarangMirror
    /// </summary>
    public unsafe bool bForceBatarangMirror
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bHarpoonCantTarget
    /// </summary>
    public unsafe bool bHarpoonCantTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bDontReactToHarpoon
    /// </summary>
    public unsafe bool bDontReactToHarpoon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bMagneticBlastCantHit
    /// </summary>
    public unsafe bool bMagneticBlastCantHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bUseRealNameForInvestigate
    /// </summary>
    public unsafe bool bUseRealNameForInvestigate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bFiring
    /// </summary>
    public unsafe bool bFiring
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bFiringBurst
    /// </summary>
    public unsafe bool bFiringBurst
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bIsInBurst
    /// </summary>
    public unsafe bool bIsInBurst
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3532); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3532); }
    }

    /// <summary>
    /// BoolProperty: bStopAfterBurst
    /// </summary>
    public unsafe bool bStopAfterBurst
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bHasBuiltInGun
    /// </summary>
    public unsafe bool bHasBuiltInGun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bIsInFrontOfCamera
    /// </summary>
    public unsafe bool bIsInFrontOfCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bInDialogue
    /// </summary>
    public unsafe bool bInDialogue
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bICSuspendStasis
    /// </summary>
    public unsafe bool bICSuspendStasis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bICForceStasis
    /// </summary>
    public unsafe bool bICForceStasis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bDestroyPawnIfInStasisForTooLong
    /// </summary>
    public unsafe bool bDestroyPawnIfInStasisForTooLong
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bActionTickActive
    /// </summary>
    public unsafe bool bActionTickActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bActionCustomEyeLocation
    /// </summary>
    public unsafe bool bActionCustomEyeLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bIsRescueTarget
    /// </summary>
    public unsafe bool bIsRescueTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bShowRouterBlockedInfo
    /// </summary>
    public unsafe bool bShowRouterBlockedInfo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bCheckingInGrate
    /// </summary>
    public unsafe bool bCheckingInGrate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bFakeCheckingInGrate
    /// </summary>
    public unsafe bool bFakeCheckingInGrate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bTrackingSightingInGrate
    /// </summary>
    public unsafe bool bTrackingSightingInGrate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bAllowedToChatter
    /// </summary>
    public unsafe bool bAllowedToChatter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreForNavPathAvoidance
    /// </summary>
    public unsafe bool bIgnoreForNavPathAvoidance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bChallengeModePawn
    /// </summary>
    public unsafe bool bChallengeModePawn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bAllowConversationsToContinueWhenTakenDown
    /// </summary>
    public unsafe bool bAllowConversationsToContinueWhenTakenDown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bFadeIn
    /// </summary>
    public unsafe bool bFadeIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bFadeOut
    /// </summary>
    public unsafe bool bFadeOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bShouldTickFade
    /// </summary>
    public unsafe bool bShouldTickFade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bPlayerInteractionsManuallyAttached
    /// </summary>
    public unsafe bool bPlayerInteractionsManuallyAttached
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bInMatineeBehaviour
    /// </summary>
    public unsafe bool bInMatineeBehaviour
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bPooledPawn_Inactive
    /// </summary>
    public unsafe bool bPooledPawn_Inactive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bInThugPool
    /// </summary>
    public unsafe bool bInThugPool
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bWaitingToFinishUnpooling
    /// </summary>
    public unsafe bool bWaitingToFinishUnpooling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bForceRunSleepInPoolCode
    /// </summary>
    public unsafe bool bForceRunSleepInPoolCode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bBeingStreamedOut
    /// </summary>
    public unsafe bool bBeingStreamedOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: grateVisDrawDebug
    /// </summary>
    public unsafe bool grateVisDrawDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: grateVisForceOn
    /// </summary>
    public unsafe bool grateVisForceOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: grateVisForceOff
    /// </summary>
    public unsafe bool grateVisForceOff
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bAwaitingDestruction
    /// </summary>
    public unsafe bool bAwaitingDestruction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3536); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3536); }
    }

    /// <summary>
    /// BoolProperty: bFinishedSpeakingWhileAwaitingDestruction
    /// </summary>
    public unsafe bool bFinishedSpeakingWhileAwaitingDestruction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3540) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3540); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3540); }
    }

    /// <summary>
    /// BoolProperty: bHasSideStoryIconName
    /// </summary>
    public unsafe bool bHasSideStoryIconName
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3540) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3540); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3540); }
    }

    /// <summary>
    /// BoolProperty: CachedInvestigateLocationValid
    /// </summary>
    public unsafe bool CachedInvestigateLocationValid
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3540) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3540); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3540); }
    }

    /// <summary>
    /// BoolProperty: bAllowBehaviourTickWhenPawnTickIsDisabled
    /// </summary>
    public unsafe bool bAllowBehaviourTickWhenPawnTickIsDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3540) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3540); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3540); }
    }

    /// <summary>
    /// ObjectProperty: PoseConfig_Falling
    /// </summary>
    public unsafe BmSDK.BmGame.RPoseConfig PoseConfig_Falling
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig>(Ptr + 3544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3544); }
    }

    /// <summary>
    /// ObjectProperty: PoseConfig_Standing
    /// </summary>
    public unsafe BmSDK.BmGame.RPoseConfig PoseConfig_Standing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig>(Ptr + 3552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3552); }
    }

    /// <summary>
    /// ObjectProperty: PoseConfig_Basic
    /// </summary>
    public unsafe BmSDK.BmGame.RPoseConfig PoseConfig_Basic
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig>(Ptr + 3560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3560); }
    }

    /// <summary>
    /// ObjectProperty: PoseConfig_Ladder
    /// </summary>
    public unsafe BmSDK.BmGame.RPoseConfig PoseConfig_Ladder
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig>(Ptr + 3568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3568); }
    }

    /// <summary>
    /// ObjectProperty: AIManager
    /// </summary>
    public unsafe BmSDK.BmGame.RBMAIManager AIManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIManager>(Ptr + 3576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3576); }
    }

    /// <summary>
    /// ObjectProperty: CurrNavHandle
    /// </summary>
    public unsafe BmSDK.BmGame.RNavigationHandle CurrNavHandle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationHandle>(Ptr + 3584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3584); }
    }

    /// <summary>
    /// ObjectProperty: Spawner
    /// </summary>
    public unsafe BmSDK.GameObject Spawner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 3592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3592); }
    }

    /// <summary>
    /// ObjectProperty: LastMagBlastReceiver
    /// </summary>
    public unsafe BmSDK.BmGame.RMagneticBlastReceiver LastMagBlastReceiver
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagneticBlastReceiver>(Ptr + 3600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3600); }
    }

    /// <summary>
    /// ObjectProperty: AlternateAnimAndWeap
    /// </summary>
    public unsafe BmSDK.BmGame.RAlternateAnimationAndWeaponConfig AlternateAnimAndWeap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAlternateAnimationAndWeaponConfig>(Ptr + 3608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3608); }
    }

    /// <summary>
    /// ObjectProperty: CurrWeapon
    /// </summary>
    public unsafe BmSDK.BmGame.RBMWeapon CurrWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMWeapon>(Ptr + 3616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3616); }
    }

    /// <summary>
    /// ObjectProperty: CurrDroppedWeapon
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatThrownObject CurrDroppedWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatThrownObject>(Ptr + 3624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3624); }
    }

    /// <summary>
    /// ObjectProperty: CharacterDefine
    /// </summary>
    public unsafe BmSDK.BmGame.RCharacterDefine CharacterDefine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCharacterDefine>(Ptr + 3632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3632); }
    }

    /// <summary>
    /// ObjectProperty: StreamedWeaponRefHolder
    /// </summary>
    public unsafe BmSDK.BmGame.RCharacterBioCue StreamedWeaponRefHolder
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCharacterBioCue>(Ptr + 3640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3640); }
    }

    /// <summary>
    /// ObjectProperty: FoliageList
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionClass FoliageList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionClass>(Ptr + 3648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3648); }
    }

    /// <summary>
    /// ObjectProperty: CurrentFoliage
    /// </summary>
    public unsafe BmSDK.Engine.InteractiveFoliageActor CurrentFoliage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.InteractiveFoliageActor>(Ptr + 3656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3656); }
    }

    /// <summary>
    /// ObjectProperty: EntryAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet EntryAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3664); }
    }

    /// <summary>
    /// ObjectProperty: LastFloorPanel
    /// </summary>
    public unsafe BmSDK.BmGame.RElectrifiedFloorPanel LastFloorPanel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RElectrifiedFloorPanel>(Ptr + 3672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3672); }
    }

    /// <summary>
    /// ObjectProperty: CurrentGun
    /// </summary>
    public unsafe BmSDK.BmGame.RBMWeaponRanged CurrentGun
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMWeaponRanged>(Ptr + 3680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3680); }
    }

    /// <summary>
    /// ObjectProperty: GlanceTarget
    /// </summary>
    public unsafe BmSDK.BmGame.AlertInstance GlanceTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.AlertInstance>(Ptr + 3688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3688); }
    }

    /// <summary>
    /// ObjectProperty: StasisLinkMasterPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI StasisLinkMasterPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 3696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3696); }
    }

    /// <summary>
    /// ObjectProperty: ArmouredThugMagnetisedAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet ArmouredThugMagnetisedAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3704); }
    }

    /// <summary>
    /// ObjectProperty: ChallengeDespawnParticleEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ChallengeDespawnParticleEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 3712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3712); }
    }

    /// <summary>
    /// ObjectProperty: ChallengeImpactParticleEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ChallengeImpactParticleEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 3720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3720); }
    }

    /// <summary>
    /// ObjectProperty: ChallengeDespawnAkEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ChallengeDespawnAkEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 3728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3728); }
    }

    /// <summary>
    /// ObjectProperty: InVehicleWeaponArchetype
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleNPCWeapon InVehicleWeaponArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPCWeapon>(Ptr + 3736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3736); }
    }

    /// <summary>
    /// ObjectProperty: lastSearchedLedgeInfo
    /// </summary>
    public unsafe BmSDK.BmGame.RLedgeLookDangerAreaInfo lastSearchedLedgeInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLedgeLookDangerAreaInfo>(Ptr + 3744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3744); }
    }

    /// <summary>
    /// ObjectProperty: MatineeBehaviour
    /// </summary>
    public unsafe BmSDK.BmGame.RBMBehaviour_Controlled MatineeBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMBehaviour_Controlled>(Ptr + 3752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3752); }
    }

    /// <summary>
    /// ObjectProperty: PawnPool
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPool PawnPool
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPool>(Ptr + 3760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3760); }
    }

    /// <summary>
    /// ObjectProperty: IncomingCombatMove
    /// </summary>
    public unsafe BmSDK.BmGame.RCombatMove IncomingCombatMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCombatMove>(Ptr + 3768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3768); }
    }

    /// <summary>
    /// ObjectProperty: ReformLocationActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor ReformLocationActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 3776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3776); }
    }

    /// <summary>
    /// ObjectProperty: RoadObstacleRoads
    /// </summary>
    public unsafe BmSDK.BmGame.RRoadNetwork RoadObstacleRoads
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadNetwork>(Ptr + 3784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3784); }
    }

    /// <summary>
    /// ComponentProperty: LongRangeHighlightMesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent LongRangeHighlightMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 3792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3792); }
    }

    /// <summary>
    /// ComponentProperty: PlayerInteractions
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionComponent PlayerInteractions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionComponent>(Ptr + 3800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3800); }
    }

    /// <summary>
    /// ComponentProperty: FlashLightComponent
    /// </summary>
    public unsafe BmSDK.Engine.SpotLightComponent FlashLightComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SpotLightComponent>(Ptr + 3808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3808); }
    }

    /// <summary>
    /// ClassProperty: CombatBehaviourClass
    /// </summary>
    public unsafe BmSDK.Class CombatBehaviourClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 3816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3816); }
    }

    /// <summary>
    /// ClassProperty: CharactersType
    /// </summary>
    public unsafe BmSDK.Class CharactersType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 3824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3824); }
    }

    /// <summary>
    /// ClassProperty: WeaponType
    /// </summary>
    public unsafe BmSDK.Class WeaponType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 3832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3832); }
    }

    /// <summary>
    /// ByteProperty: PhysWalkingType
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI.EPhysWalkingType PhysWalkingType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI.EPhysWalkingType>(Ptr + 3840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3840); }
    }

    /// <summary>
    /// ByteProperty: TempPhysWalkingType
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI.EPhysWalkingType TempPhysWalkingType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI.EPhysWalkingType>(Ptr + 3841); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3841); }
    }

    /// <summary>
    /// ByteProperty: StasisMode
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI.EStasisMode StasisMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI.EStasisMode>(Ptr + 3842); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3842); }
    }

    /// <summary>
    /// ByteProperty: KOGameAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction KOGameAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 3843); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3843); }
    }

    /// <summary>
    /// ByteProperty: SkinColourType
    /// </summary>
    public unsafe BmSDK.BmGame.RCharacterDefine.SkinTypeEnum SkinColourType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCharacterDefine.SkinTypeEnum>(Ptr + 3844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3844); }
    }

    /// <summary>
    /// ByteProperty: WeaponConfigType
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatManager.EWeaponConfigType WeaponConfigType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatManager.EWeaponConfigType>(Ptr + 3845); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3845); }
    }

    /// <summary>
    /// ByteProperty: HelicopterPointOfInterestType
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.HelicopterPointOfInterestTypes HelicopterPointOfInterestType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.HelicopterPointOfInterestTypes>(Ptr + 3846); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3846); }
    }

    /// <summary>
    /// IntProperty: HitCollisionWithFloorCheckCount
    /// </summary>
    public unsafe int HitCollisionWithFloorCheckCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3848); }
    }

    /// <summary>
    /// StructProperty: SearchExtent
    /// </summary>
    public unsafe System.Numerics.Vector3 SearchExtent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3852); }
    }

    /// <summary>
    /// StructProperty: TerrifiedSearchExtent
    /// </summary>
    public unsafe System.Numerics.Vector3 TerrifiedSearchExtent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3864); }
    }

    /// <summary>
    /// ArrayProperty: NavHandleList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RNavigationHandle> NavHandleList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RNavigationHandle>>(Ptr + 3876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3876); }
    }

    /// <summary>
    /// NameProperty: PawnReferenceName
    /// </summary>
    public unsafe BmSDK.FName PawnReferenceName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 3892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3892); }
    }

    /// <summary>
    /// FloatProperty: SoftPawnCollisionRadiusMultiplier
    /// </summary>
    public unsafe float SoftPawnCollisionRadiusMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3900); }
    }

    /// <summary>
    /// StructProperty: SoftPawnCollisionVelocity
    /// </summary>
    public unsafe System.Numerics.Vector3 SoftPawnCollisionVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3904); }
    }

    /// <summary>
    /// ArrayProperty: SoftPawnCollisionInfluencers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FSoftPawnInfo> SoftPawnCollisionInfluencers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FSoftPawnInfo>>(Ptr + 3916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3916); }
    }

    /// <summary>
    /// NameProperty: HolsterBoneName
    /// </summary>
    public unsafe BmSDK.FName HolsterBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 3932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3932); }
    }

    /// <summary>
    /// IntProperty: ForceGroundChecks
    /// </summary>
    public unsafe int ForceGroundChecks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3940); }
    }

    /// <summary>
    /// IntProperty: FramesSinceGroundCheck
    /// </summary>
    public unsafe int FramesSinceGroundCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3944); }
    }

    /// <summary>
    /// ArrayProperty: AllowBasingOnVehicleObjects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject> AllowBasingOnVehicleObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject>>(Ptr + 3948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3948); }
    }

    /// <summary>
    /// ArrayProperty: DisableVehicleDiveBehaviours
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMBehaviour> DisableVehicleDiveBehaviours
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMBehaviour>>(Ptr + 3964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3964); }
    }

    /// <summary>
    /// FloatProperty: InstantSightRange
    /// </summary>
    public unsafe float InstantSightRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3980); }
    }

    /// <summary>
    /// FloatProperty: FocusedSightRange
    /// </summary>
    public unsafe float FocusedSightRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3984); }
    }

    /// <summary>
    /// FloatProperty: FocusedVisionRadius
    /// </summary>
    public unsafe float FocusedVisionRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3988); }
    }

    /// <summary>
    /// FloatProperty: PeripheralSightRange
    /// </summary>
    public unsafe float PeripheralSightRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3992); }
    }

    /// <summary>
    /// FloatProperty: ExtendedSightRange
    /// </summary>
    public unsafe float ExtendedSightRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3996); }
    }

    /// <summary>
    /// StructProperty: PrevFloorNormal
    /// </summary>
    public unsafe System.Numerics.Vector3 PrevFloorNormal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4000); }
    }

    /// <summary>
    /// StrProperty: ForceDeathTip
    /// </summary>
    public unsafe BmSDK.FString ForceDeathTip
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4012); }
    }

    /// <summary>
    /// StructProperty: HitReactionWeaponSwitchThrowImpulse
    /// </summary>
    public unsafe System.Numerics.Vector3 HitReactionWeaponSwitchThrowImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4028); }
    }

    /// <summary>
    /// StrProperty: RiotWeaponName
    /// </summary>
    public unsafe BmSDK.FString RiotWeaponName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4040); }
    }

    /// <summary>
    /// FloatProperty: DeathTimer
    /// </summary>
    public unsafe float DeathTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4056); }
    }

    /// <summary>
    /// ArrayProperty: DeathMat
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant> DeathMat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant>>(Ptr + 4060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4060); }
    }

    /// <summary>
    /// FloatProperty: DeathFadePause
    /// </summary>
    public unsafe float DeathFadePause
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4076); }
    }

    /// <summary>
    /// FloatProperty: DeathFadeDuration
    /// </summary>
    public unsafe float DeathFadeDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4080); }
    }

    /// <summary>
    /// StructProperty: CachedCylinderExtent
    /// </summary>
    public unsafe System.Numerics.Vector3 CachedCylinderExtent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4084); }
    }

    /// <summary>
    /// FloatProperty: MaxBumpedTimer
    /// </summary>
    public unsafe float MaxBumpedTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4096); }
    }

    /// <summary>
    /// FloatProperty: CarCollisionTimer
    /// </summary>
    public unsafe float CarCollisionTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4100); }
    }

    /// <summary>
    /// FloatProperty: LastCarCollisionWarningTime
    /// </summary>
    public unsafe float LastCarCollisionWarningTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4104); }
    }

    /// <summary>
    /// IntProperty: UniquePawnIdentifier
    /// </summary>
    public unsafe int UniquePawnIdentifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4108); }
    }

    /// <summary>
    /// ArrayProperty: PropStatics
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FCharacterStaticProps> PropStatics
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FCharacterStaticProps>>(Ptr + 4112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4112); }
    }

    /// <summary>
    /// ArrayProperty: PropSkeletals
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FCharacterSkeletalProps> PropSkeletals
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FCharacterSkeletalProps>>(Ptr + 4128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4128); }
    }

    /// <summary>
    /// StructProperty: PropLightingChannels
    /// </summary>
    public unsafe BmSDK.Engine.LightComponent.FLightingChannelContainer PropLightingChannels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.LightComponent.FLightingChannelContainer>(Ptr + 4144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4144); }
    }

    /// <summary>
    /// IntProperty: OverrideKOXP
    /// </summary>
    public unsafe int OverrideKOXP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4148); }
    }

    /// <summary>
    /// ArrayProperty: BatarangTargetBodyParts
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> BatarangTargetBodyParts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 4152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4152); }
    }

    /// <summary>
    /// ArrayProperty: WhipTargetBodyParts
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> WhipTargetBodyParts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 4168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4168); }
    }

    /// <summary>
    /// StrProperty: RealNameForInvestigate
    /// </summary>
    public unsafe BmSDK.FString RealNameForInvestigate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4184); }
    }

    /// <summary>
    /// NameProperty: SpineName
    /// </summary>
    public unsafe BmSDK.FName SpineName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4200); }
    }

    /// <summary>
    /// NameProperty: EntryAnim
    /// </summary>
    public unsafe BmSDK.FName EntryAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4208); }
    }

    /// <summary>
    /// FloatProperty: LastFireTime
    /// </summary>
    public unsafe float LastFireTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4216); }
    }

    /// <summary>
    /// FloatProperty: FireTimer
    /// </summary>
    public unsafe float FireTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4220); }
    }

    /// <summary>
    /// IntProperty: BurstCount
    /// </summary>
    public unsafe int BurstCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4224); }
    }

    /// <summary>
    /// IntProperty: ClipCount
    /// </summary>
    public unsafe int ClipCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4228); }
    }

    /// <summary>
    /// FloatProperty: GunMomentumTime
    /// </summary>
    public unsafe float GunMomentumTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4232); }
    }

    /// <summary>
    /// StructProperty: GunMomentumDir
    /// </summary>
    public unsafe System.Numerics.Vector3 GunMomentumDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4236); }
    }

    /// <summary>
    /// ArrayProperty: GunTargetBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.GunTargetBoneState> GunTargetBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.GunTargetBoneState>>(Ptr + 4248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4248); }
    }

    /// <summary>
    /// FloatProperty: BeenStartledTimer
    /// </summary>
    public unsafe float BeenStartledTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4264); }
    }

    /// <summary>
    /// ArrayProperty: StasisLinkPawn
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI> StasisLinkPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI>>(Ptr + 4268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4268); }
    }

    /// <summary>
    /// FloatProperty: OverrideStasisDist
    /// </summary>
    public unsafe float OverrideStasisDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4284); }
    }

    /// <summary>
    /// FloatProperty: OverrideFrontStasisDist
    /// </summary>
    public unsafe float OverrideFrontStasisDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4288); }
    }

    /// <summary>
    /// FloatProperty: DestroyPawnIfInStasisTime
    /// </summary>
    public unsafe float DestroyPawnIfInStasisTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4292); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceLastRender
    /// </summary>
    public unsafe float TimeSinceLastRender
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4296); }
    }

    /// <summary>
    /// ArrayProperty: Queue
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMAIAction> Queue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMAIAction>>(Ptr + 4300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4300); }
    }

    /// <summary>
    /// ArrayProperty: MoveToTargetList
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> MoveToTargetList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 4316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4316); }
    }

    /// <summary>
    /// StructProperty: MoveToTarget
    /// </summary>
    public unsafe System.Numerics.Vector3 MoveToTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4332); }
    }

    /// <summary>
    /// StructProperty: LastValidNavMeshPoly
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI.FValidNavMeshPoly LastValidNavMeshPoly
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI.FValidNavMeshPoly>(Ptr + 4344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4344); }
    }

    /// <summary>
    /// StructProperty: RouterBlockedPos
    /// </summary>
    public unsafe System.Numerics.Vector3 RouterBlockedPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4368); }
    }

    /// <summary>
    /// StructProperty: RouterBlockedNewPos
    /// </summary>
    public unsafe System.Numerics.Vector3 RouterBlockedNewPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4380); }
    }

    /// <summary>
    /// StructProperty: RouterBlockedDestination
    /// </summary>
    public unsafe System.Numerics.Vector3 RouterBlockedDestination
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4392); }
    }

    /// <summary>
    /// StructProperty: RouterBlockedSnappedDestination
    /// </summary>
    public unsafe System.Numerics.Vector3 RouterBlockedSnappedDestination
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4404); }
    }

    /// <summary>
    /// StructProperty: RouterBlockedExtents
    /// </summary>
    public unsafe System.Numerics.Vector3 RouterBlockedExtents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4416); }
    }

    /// <summary>
    /// ArrayProperty: AlwaysOnPS
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FAlwaysOnParticles> AlwaysOnPS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FAlwaysOnParticles>>(Ptr + 4428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4428); }
    }

    /// <summary>
    /// FloatProperty: CurrDestZ
    /// </summary>
    public unsafe float CurrDestZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4444); }
    }

    /// <summary>
    /// FloatProperty: ZBlendSpeed
    /// </summary>
    public unsafe float ZBlendSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4448); }
    }

    /// <summary>
    /// FloatProperty: PrevPathSlideDirection
    /// </summary>
    public unsafe float PrevPathSlideDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4452); }
    }

    /// <summary>
    /// ArrayProperty: CombatIdleStances
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> CombatIdleStances
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 4456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4456); }
    }

    /// <summary>
    /// IntProperty: CombatIdleStanceID
    /// </summary>
    public unsafe int CombatIdleStanceID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4472); }
    }

    /// <summary>
    /// FloatProperty: FadeTimer
    /// </summary>
    public unsafe float FadeTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4476); }
    }

    /// <summary>
    /// ArrayProperty: PathFailHistory
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FPathFailItem> PathFailHistory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FPathFailItem>>(Ptr + 4480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4480); }
    }

    /// <summary>
    /// FloatProperty: CurrentAverageFaceFXValue
    /// </summary>
    public unsafe float CurrentAverageFaceFXValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4496); }
    }

    /// <summary>
    /// FloatProperty: lastLedgeSearchTime
    /// </summary>
    public unsafe float lastLedgeSearchTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4500); }
    }

    /// <summary>
    /// IntProperty: numPaintyFootPrintsRemaining
    /// </summary>
    public unsafe int numPaintyFootPrintsRemaining
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4504); }
    }

    /// <summary>
    /// IntProperty: PooledActivations
    /// </summary>
    public unsafe int PooledActivations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4508); }
    }

    /// <summary>
    /// FloatProperty: grateVisLength_Normal
    /// </summary>
    public unsafe float grateVisLength_Normal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4512); }
    }

    /// <summary>
    /// FloatProperty: grateVisLength_GrateSearch
    /// </summary>
    public unsafe float grateVisLength_GrateSearch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4516); }
    }

    /// <summary>
    /// FloatProperty: grateVisWidth_Normal
    /// </summary>
    public unsafe float grateVisWidth_Normal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4520); }
    }

    /// <summary>
    /// FloatProperty: grateVisWidth_GrateSearch
    /// </summary>
    public unsafe float grateVisWidth_GrateSearch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4524); }
    }

    /// <summary>
    /// FloatProperty: grateVisForwardBiasDist
    /// </summary>
    public unsafe float grateVisForwardBiasDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4528); }
    }

    /// <summary>
    /// FloatProperty: grateVisAlreadyVisibleBonusRange
    /// </summary>
    public unsafe float grateVisAlreadyVisibleBonusRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4532); }
    }

    /// <summary>
    /// FloatProperty: grateVisWarmupTime
    /// </summary>
    public unsafe float grateVisWarmupTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4536); }
    }

    /// <summary>
    /// ArrayProperty: gratesBMVisibleThrough
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FgrateVisInfo> gratesBMVisibleThrough
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FgrateVisInfo>>(Ptr + 4540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4540); }
    }

    /// <summary>
    /// FloatProperty: SpawnedTime
    /// </summary>
    public unsafe float SpawnedTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4556); }
    }

    /// <summary>
    /// IntProperty: NumWallChecks
    /// </summary>
    public unsafe int NumWallChecks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4560); }
    }

    /// <summary>
    /// ArrayProperty: WallForces
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> WallForces
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 4564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4564); }
    }

    /// <summary>
    /// StructProperty: ForwardWallHitNormal
    /// </summary>
    public unsafe System.Numerics.Vector3 ForwardWallHitNormal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4580); }
    }

    /// <summary>
    /// IntProperty: CurrentWallCheck
    /// </summary>
    public unsafe int CurrentWallCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4592); }
    }

    /// <summary>
    /// FloatProperty: ForwardWallCheckYaw
    /// </summary>
    public unsafe float ForwardWallCheckYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4596); }
    }

    /// <summary>
    /// StrProperty: DeathMovieIfThisPawnKillsBatman
    /// </summary>
    public unsafe BmSDK.FString DeathMovieIfThisPawnKillsBatman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4600); }
    }

    /// <summary>
    /// StructProperty: CachedInvestigateLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 CachedInvestigateLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4616); }
    }

    /// <summary>
    /// IntProperty: RoadObstacleIndex
    /// </summary>
    public unsafe int RoadObstacleIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4628); }
    }
}
