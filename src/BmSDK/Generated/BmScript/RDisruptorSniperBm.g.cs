#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RDisruptorSniperBm<br/>
/// (flags = 0)
/// </summary>
public partial class RDisruptorSniperBm : BmSDK.BmGame.RDisruptorSniper, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RDisruptorSniperBm", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDisruptorSniperBm() { }

    /// <summary>
    /// Constructs a new RDisruptorSniperBm
    /// </summary>
    public RDisruptorSniperBm(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDisruptorSniperBm Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDisruptorSniperBm(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDisruptorSniperBm>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDisruptorSniperBm>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDisruptorSniperBm>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDisruptorSniperBm>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDisruptorSniperBm>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDisruptorSniperBm>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDisruptorSniperBm>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// StructProperty: FireOverlayAnimation
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId FireOverlayAnimation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId>(Ptr + 2068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2068); }
    }

    /// <summary>
    /// BoolProperty: bBatmanHasFinishedEquippingGadget
    /// </summary>
    public unsafe bool bBatmanHasFinishedEquippingGadget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2076); }
    }

    /// <summary>
    /// BoolProperty: bBatmanCanPurchaseDroneDisruptorUpgrade
    /// </summary>
    public unsafe bool bBatmanCanPurchaseDroneDisruptorUpgrade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2076); }
    }

    /// <summary>
    /// BoolProperty: bBatmanHasDroneDisruptorUpgrade
    /// </summary>
    public unsafe bool bBatmanHasDroneDisruptorUpgrade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2076); }
    }

    /// <summary>
    /// BoolProperty: bBatmanHasMineDisruptorUpgrade
    /// </summary>
    public unsafe bool bBatmanHasMineDisruptorUpgrade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2076); }
    }

    /// <summary>
    /// BoolProperty: bBatmanHasDetectiveModeJammerDisruptorUpgrade
    /// </summary>
    public unsafe bool bBatmanHasDetectiveModeJammerDisruptorUpgrade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2076); }
    }

    /// <summary>
    /// BoolProperty: bBatmanHasDetectiveModeDetectorDisruptorUpgrade
    /// </summary>
    public unsafe bool bBatmanHasDetectiveModeDetectorDisruptorUpgrade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2076); }
    }

    /// <summary>
    /// BoolProperty: bBatmanHasMinidroneControllerDisruptorUpgrade
    /// </summary>
    public unsafe bool bBatmanHasMinidroneControllerDisruptorUpgrade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2076); }
    }

    /// <summary>
    /// BoolProperty: bBatmanHasStunStickDisruptorUpgrade
    /// </summary>
    public unsafe bool bBatmanHasStunStickDisruptorUpgrade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2076); }
    }

    /// <summary>
    /// BoolProperty: bBatmanHasMedicDisruptorUpgrade
    /// </summary>
    public unsafe bool bBatmanHasMedicDisruptorUpgrade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2076); }
    }

    /// <summary>
    /// BoolProperty: bBatmanHasInvisibleThugDisruptorUpgrade
    /// </summary>
    public unsafe bool bBatmanHasInvisibleThugDisruptorUpgrade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2076); }
    }

    /// <summary>
    /// BoolProperty: bBatmanHasExtraAmmoUpgrade
    /// </summary>
    public unsafe bool bBatmanHasExtraAmmoUpgrade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2076); }
    }

    /// <summary>
    /// BoolProperty: bBatmanHasSentryGunDispenserDisruptorUpgrade
    /// </summary>
    public unsafe bool bBatmanHasSentryGunDispenserDisruptorUpgrade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2076); }
    }

    /// <summary>
    /// BoolProperty: bBatmanHasRHDBlindDroneUpgrade
    /// </summary>
    public unsafe bool bBatmanHasRHDBlindDroneUpgrade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2076); }
    }

    /// <summary>
    /// BoolProperty: bScreenHasFinishedTurningOn
    /// </summary>
    public unsafe bool bScreenHasFinishedTurningOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2076); }
    }

    /// <summary>
    /// BoolProperty: bAllowedToUseGadgetCamera
    /// </summary>
    public unsafe bool bAllowedToUseGadgetCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2076); }
    }

    /// <summary>
    /// BoolProperty: bCanMuzzleAim
    /// </summary>
    public unsafe bool bCanMuzzleAim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2076); }
    }

    /// <summary>
    /// BoolProperty: bPostProcessIsTurnedOn
    /// </summary>
    public unsafe bool bPostProcessIsTurnedOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2076); }
    }

    /// <summary>
    /// BoolProperty: DisruptorSuppressingSurveillance
    /// </summary>
    public unsafe bool DisruptorSuppressingSurveillance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2076); }
    }

    /// <summary>
    /// BoolProperty: bPauseAmmoRechargeForTutorial
    /// </summary>
    public unsafe bool bPauseAmmoRechargeForTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2076); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2076); }
    }

    /// <summary>
    /// StructProperty: NormalFireScreenShake
    /// </summary>
    public unsafe BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct NormalFireScreenShake
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 2080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2080); }
    }

    /// <summary>
    /// StructProperty: ZoomedFireScreenShake
    /// </summary>
    public unsafe BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct ZoomedFireScreenShake
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 2236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2236); }
    }

    /// <summary>
    /// FloatProperty: ReplenishTime
    /// </summary>
    public unsafe float ReplenishTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2392); }
    }

    /// <summary>
    /// ArrayProperty: CurrentTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> CurrentTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 2396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2396); }
    }

    /// <summary>
    /// ByteProperty: CurrentMagazineType
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.EHighlightedTargetType CurrentMagazineType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.EHighlightedTargetType>(Ptr + 2412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2412); }
    }

    /// <summary>
    /// ByteProperty: LastPerchDirection
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.PerchDirection LastPerchDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.PerchDirection>(Ptr + 2413); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2413); }
    }

    /// <summary>
    /// FloatProperty: fDelayBetweenMagazineChanges
    /// </summary>
    public unsafe float fDelayBetweenMagazineChanges
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2416); }
    }

    /// <summary>
    /// FloatProperty: fNextMagazineChangeAllowedCountdown
    /// </summary>
    public unsafe float fNextMagazineChangeAllowedCountdown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2420); }
    }

    /// <summary>
    /// StructProperty: CrosshairTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.FHighlightedMesh CrosshairTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.FHighlightedMesh>(Ptr + 2424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2424); }
    }

    /// <summary>
    /// StructProperty: CrosshairNearestTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.FHighlightedMesh CrosshairNearestTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.FHighlightedMesh>(Ptr + 2512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2512); }
    }

    /// <summary>
    /// StructProperty: CrosshairTrackingTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.FHighlightedMesh CrosshairTrackingTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.FHighlightedMesh>(Ptr + 2600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2600); }
    }

    /// <summary>
    /// StructProperty: vCrosshairTargetHitLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 vCrosshairTargetHitLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2688); }
    }

    /// <summary>
    /// ObjectProperty: RestrictedTargetsSequenceAction
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_RestrictDisruptorTargets RestrictedTargetsSequenceAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_RestrictDisruptorTargets>(Ptr + 2700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2700); }
    }

    /// <summary>
    /// ObjectProperty: NormalDisruptorModeMaterials
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface NormalDisruptorModeMaterials_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2708); }
    }
    /// <summary>
    /// ObjectProperty: NormalDisruptorModeMaterials
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface NormalDisruptorModeMaterials_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2716); }
    }
    /// <summary>
    /// ObjectProperty: NormalDisruptorModeMaterials
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface NormalDisruptorModeMaterials_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2724); }
    }
    /// <summary>
    /// ObjectProperty: NormalDisruptorModeMaterials
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface NormalDisruptorModeMaterials_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2732); }
    }
    /// <summary>
    /// ObjectProperty: NormalDisruptorModeMaterials
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface NormalDisruptorModeMaterials_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2740); }
    }
    /// <summary>
    /// ObjectProperty: NormalDisruptorModeMaterials
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface NormalDisruptorModeMaterials_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2748); }
    }
    /// <summary>
    /// ObjectProperty: NormalDisruptorModeMaterials
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface NormalDisruptorModeMaterials_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2756); }
    }
    /// <summary>
    /// ObjectProperty: NormalDisruptorModeMaterials
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface NormalDisruptorModeMaterials_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2764); }
    }

    /// <summary>
    /// ObjectProperty: CurrentTargetDisruptorModeMaterials
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface CurrentTargetDisruptorModeMaterials_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2772); }
    }
    /// <summary>
    /// ObjectProperty: CurrentTargetDisruptorModeMaterials
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface CurrentTargetDisruptorModeMaterials_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2780); }
    }
    /// <summary>
    /// ObjectProperty: CurrentTargetDisruptorModeMaterials
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface CurrentTargetDisruptorModeMaterials_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2788); }
    }
    /// <summary>
    /// ObjectProperty: CurrentTargetDisruptorModeMaterials
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface CurrentTargetDisruptorModeMaterials_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2796); }
    }
    /// <summary>
    /// ObjectProperty: CurrentTargetDisruptorModeMaterials
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface CurrentTargetDisruptorModeMaterials_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2804); }
    }
    /// <summary>
    /// ObjectProperty: CurrentTargetDisruptorModeMaterials
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface CurrentTargetDisruptorModeMaterials_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2812); }
    }
    /// <summary>
    /// ObjectProperty: CurrentTargetDisruptorModeMaterials
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface CurrentTargetDisruptorModeMaterials_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2820); }
    }
    /// <summary>
    /// ObjectProperty: CurrentTargetDisruptorModeMaterials
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface CurrentTargetDisruptorModeMaterials_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2828); }
    }

    /// <summary>
    /// ObjectProperty: DisruptorModeMaterialsForCamouflageThug
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface DisruptorModeMaterialsForCamouflageThug_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2836); }
    }
    /// <summary>
    /// ObjectProperty: DisruptorModeMaterialsForCamouflageThug
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface DisruptorModeMaterialsForCamouflageThug_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2844); }
    }
    /// <summary>
    /// ObjectProperty: DisruptorModeMaterialsForCamouflageThug
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface DisruptorModeMaterialsForCamouflageThug_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2852); }
    }
    /// <summary>
    /// ObjectProperty: DisruptorModeMaterialsForCamouflageThug
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface DisruptorModeMaterialsForCamouflageThug_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2860); }
    }
    /// <summary>
    /// ObjectProperty: DisruptorModeMaterialsForCamouflageThug
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface DisruptorModeMaterialsForCamouflageThug_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2868); }
    }
    /// <summary>
    /// ObjectProperty: DisruptorModeMaterialsForCamouflageThug
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface DisruptorModeMaterialsForCamouflageThug_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2876); }
    }
    /// <summary>
    /// ObjectProperty: DisruptorModeMaterialsForCamouflageThug
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface DisruptorModeMaterialsForCamouflageThug_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2884); }
    }
    /// <summary>
    /// ObjectProperty: DisruptorModeMaterialsForCamouflageThug
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface DisruptorModeMaterialsForCamouflageThug_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2892); }
    }

    /// <summary>
    /// ObjectProperty: HighlightBlankMaterial
    /// </summary>
    public unsafe BmSDK.Engine.Material HighlightBlankMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material>(Ptr + 2900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2900); }
    }

    /// <summary>
    /// ObjectProperty: FireSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FireSound_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2908); }
    }
    /// <summary>
    /// ObjectProperty: FireSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FireSound_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2916); }
    }
    /// <summary>
    /// ObjectProperty: FireSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FireSound_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2924); }
    }
    /// <summary>
    /// ObjectProperty: FireSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FireSound_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2932); }
    }
    /// <summary>
    /// ObjectProperty: FireSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FireSound_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2940); }
    }
    /// <summary>
    /// ObjectProperty: FireSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FireSound_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2948); }
    }
    /// <summary>
    /// ObjectProperty: FireSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FireSound_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2956); }
    }
    /// <summary>
    /// ObjectProperty: FireSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FireSound_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2964); }
    }

    /// <summary>
    /// ObjectProperty: DoubleDisruptedFireSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent DoubleDisruptedFireSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2972); }
    }

    /// <summary>
    /// ObjectProperty: NoAmmoFireSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent NoAmmoFireSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2980); }
    }

    /// <summary>
    /// ObjectProperty: AttemptToDisruptFullyDisruptedTargetFireSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AttemptToDisruptFullyDisruptedTargetFireSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2988); }
    }

    /// <summary>
    /// ObjectProperty: ShotGlassSFX
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ShotGlassSFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2996); }
    }

    /// <summary>
    /// ObjectProperty: TracerEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem TracerEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 3004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3004); }
    }

    /// <summary>
    /// ObjectProperty: CantDoubleJamMinigunThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech CantDoubleJamMinigunThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 3012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3012); }
    }

    /// <summary>
    /// ObjectProperty: CantDoubleJamRocketLauncherThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech CantDoubleJamRocketLauncherThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 3020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3020); }
    }

    /// <summary>
    /// ObjectProperty: NoAmmoLeftThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech NoAmmoLeftThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 3028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3028); }
    }

    /// <summary>
    /// ObjectProperty: CantShootSentryGunThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech CantShootSentryGunThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 3036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3036); }
    }

    /// <summary>
    /// ObjectProperty: CantShootWatchtowerTurretThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech CantShootWatchtowerTurretThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 3044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3044); }
    }

    /// <summary>
    /// ObjectProperty: CantShootSentryGunButHaveRHDBlinderThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech CantShootSentryGunButHaveRHDBlinderThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 3052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3052); }
    }

    /// <summary>
    /// ObjectProperty: CantShootWatchtowerTurretButHaveRHDBlinderThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech CantShootWatchtowerTurretButHaveRHDBlinderThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 3060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3060); }
    }

    /// <summary>
    /// ObjectProperty: CantShootRobotGunThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech CantShootRobotGunThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 3068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3068); }
    }

    /// <summary>
    /// ObjectProperty: NeedUpgradeThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech NeedUpgradeThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 3076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3076); }
    }

    /// <summary>
    /// ObjectProperty: ScreenMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant ScreenMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 3084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3084); }
    }

    /// <summary>
    /// ObjectProperty: MuzzleAimSkelControl
    /// </summary>
    public unsafe BmSDK.Engine.SkelControlLookAt MuzzleAimSkelControl
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkelControlLookAt>(Ptr + 3092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3092); }
    }

    /// <summary>
    /// ObjectProperty: HitRandomObjectVFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem HitRandomObjectVFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 3100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3100); }
    }

    /// <summary>
    /// ObjectProperty: HitGlassVFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem HitGlassVFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 3108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3108); }
    }

    /// <summary>
    /// FloatProperty: AimRadius
    /// </summary>
    public unsafe float AimRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3116); }
    }

    /// <summary>
    /// IntProperty: iAntiEquipmentMaximumAmmo
    /// </summary>
    public unsafe int iAntiEquipmentMaximumAmmo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3120); }
    }

    /// <summary>
    /// IntProperty: iAntiEquipmentRemainingAmmo
    /// </summary>
    public unsafe int iAntiEquipmentRemainingAmmo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3124); }
    }

    /// <summary>
    /// StrProperty: sNextTargetModuleEvent
    /// </summary>
    public unsafe BmSDK.FString sNextTargetModuleEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 3128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3128); }
    }

    /// <summary>
    /// FloatProperty: fScreenOnPercentage
    /// </summary>
    public unsafe float fScreenOnPercentage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3144); }
    }

    /// <summary>
    /// FloatProperty: fScreenTurnOnSpeed
    /// </summary>
    public unsafe float fScreenTurnOnSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3148); }
    }

    /// <summary>
    /// FloatProperty: fMuzzleAimSkelControlFadeOutTimeLeft
    /// </summary>
    public unsafe float fMuzzleAimSkelControlFadeOutTimeLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3152); }
    }

    /// <summary>
    /// FloatProperty: fCornerCoverAimUpWeight
    /// </summary>
    public unsafe float fCornerCoverAimUpWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3156); }
    }

    /// <summary>
    /// FloatProperty: fCornerCoverAimDownWeight
    /// </summary>
    public unsafe float fCornerCoverAimDownWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3160); }
    }

    /// <summary>
    /// ArrayProperty: DisruptedEquipmentArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RDisruptorSniper.FDisruptedEquipmentRecord> DisruptedEquipmentArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RDisruptorSniper.FDisruptedEquipmentRecord>>(Ptr + 3164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3164); }
    }

    /// <summary>
    /// IntProperty: NameIndexTracker
    /// </summary>
    public unsafe int NameIndexTracker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3180); }
    }

    /// <summary>
    /// ArrayProperty: RestrictedTargetsSequenceActions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSeqAct_RestrictDisruptorTargets> RestrictedTargetsSequenceActions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSeqAct_RestrictDisruptorTargets>>(Ptr + 3184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3184); }
    }
}
