#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGooSpray<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RGooSpray : BmSDK.BmGame.RProjectileGadgetBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGooSpray", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGooSpray() { }

    /// <summary>
    /// Constructs a new RGooSpray
    /// </summary>
    public RGooSpray(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGooSpray Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGooSpray(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGooSpray>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGooSpray>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGooSpray>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGooSpray>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGooSpray>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGooSpray>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGooSpray>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: SprayFloorMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SprayFloorMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2592); }
    }

    /// <summary>
    /// ObjectProperty: SprayFloorMoveDownHill
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SprayFloorMoveDownHill
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2600); }
    }

    /// <summary>
    /// ObjectProperty: SprayWallMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SprayWallMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2608); }
    }

    /// <summary>
    /// ObjectProperty: SprayCeilingMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SprayCeilingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2616); }
    }

    /// <summary>
    /// ObjectProperty: ReactToExplosionMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ReactToExplosionMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2624); }
    }

    /// <summary>
    /// ObjectProperty: ReactToExplosionMoveL
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ReactToExplosionMoveL
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2632); }
    }

    /// <summary>
    /// ObjectProperty: ReactToExplosionMoveR
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ReactToExplosionMoveR
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2640); }
    }

    /// <summary>
    /// ObjectProperty: ReactToExplosionMoveB
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ReactToExplosionMoveB
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2648); }
    }

    /// <summary>
    /// ObjectProperty: CombatFloorSprayMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CombatFloorSprayMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2656); }
    }

    /// <summary>
    /// ObjectProperty: CombatFloorSprayMove_NoCamAlign
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CombatFloorSprayMove_NoCamAlign
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2664); }
    }

    /// <summary>
    /// ObjectProperty: LastGooMine
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LastGooMine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2672); }
    }

    /// <summary>
    /// ObjectProperty: ProximitySound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ProximitySound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2680); }
    }

    /// <summary>
    /// ObjectProperty: CurrentSprayMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CurrentSprayMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2688); }
    }

    /// <summary>
    /// ObjectProperty: CurrentDetonateTarget
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CurrentDetonateTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2696); }
    }

    /// <summary>
    /// ObjectProperty: ExplodeTarget
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ExplodeTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2704); }
    }

    /// <summary>
    /// ObjectProperty: DetonatorSoundEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DetonatorSoundEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2712); }
    }

    /// <summary>
    /// ObjectProperty: TargetVillain
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TargetVillain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2720); }
    }

    /// <summary>
    /// ObjectProperty: PlaceOnVillainMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlaceOnVillainMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2728); }
    }

    /// <summary>
    /// ObjectProperty: PlaceOnVantageMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlaceOnVantageMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2736); }
    }

    /// <summary>
    /// ObjectProperty: BombArchetype
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BombArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2744); }
    }

    /// <summary>
    /// ObjectProperty: FailedGelSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FailedGelSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2752); }
    }

    /// <summary>
    /// ComponentProperty: DetonatorMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DetonatorMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2760); }
    }

    /// <summary>
    /// ComponentProperty: GooSprayDummyRig
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GooSprayDummyRig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2768); }
    }

    /// <summary>
    /// ComponentProperty: NozzleParticles2
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT NozzleParticles2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2776); }
    }

    /// <summary>
    /// ComponentProperty: NozzleParticles
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT NozzleParticles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2784); }
    }

    /// <summary>
    /// ComponentProperty: GooSprayParticles
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GooSprayParticles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2792); }
    }

    /// <summary>
    /// BoolProperty: bSpraying
    /// </summary>
    public unsafe bool bSpraying
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2800) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2800); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2800); }
    }

    /// <summary>
    /// BoolProperty: bUsingSprayDummy
    /// </summary>
    public unsafe bool bUsingSprayDummy
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2800) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2800); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2800); }
    }

    /// <summary>
    /// BoolProperty: bCanSingleTarget
    /// </summary>
    public unsafe bool bCanSingleTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2800) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2800); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2800); }
    }

    /// <summary>
    /// BoolProperty: bDrawingTargets
    /// </summary>
    public unsafe bool bDrawingTargets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2800) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2800); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2800); }
    }

    /// <summary>
    /// BoolProperty: bForceZeroAmmo
    /// </summary>
    public unsafe bool bForceZeroAmmo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2800) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2800); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2800); }
    }

    /// <summary>
    /// BoolProperty: bProximityDetector
    /// </summary>
    public unsafe bool bProximityDetector
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2800) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2800); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2800); }
    }

    /// <summary>
    /// BoolProperty: bFailedFire
    /// </summary>
    public unsafe bool bFailedFire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2800) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2800); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2800); }
    }

    /// <summary>
    /// BoolProperty: bPlacingOnGround
    /// </summary>
    public unsafe bool bPlacingOnGround
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2800) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2800); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2800); }
    }

    /// <summary>
    /// BoolProperty: bUseNewGroundCamera
    /// </summary>
    public unsafe bool bUseNewGroundCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2800) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2800); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2800); }
    }

    /// <summary>
    /// BoolProperty: bSuperComboThrow
    /// </summary>
    public unsafe bool bSuperComboThrow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2800) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2800); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2800); }
    }

    /// <summary>
    /// BoolProperty: bNoAimedGelSpray
    /// </summary>
    public unsafe bool bNoAimedGelSpray
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2800) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2800); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2800); }
    }

    /// <summary>
    /// StructProperty: SprayLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SprayLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2804); }
    }

    /// <summary>
    /// StructProperty: SprayWallNormal
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SprayWallNormal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2816); }
    }

    /// <summary>
    /// FloatProperty: FirstExplodeTime
    /// </summary>
    public unsafe float FirstExplodeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2828); }
    }

    /// <summary>
    /// FloatProperty: SubsequentExplodeDelay
    /// </summary>
    public unsafe float SubsequentExplodeDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2832); }
    }

    /// <summary>
    /// StructProperty: DetonatorTransition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DetonatorTransition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2836); }
    }

    /// <summary>
    /// IntProperty: NumWallsKilledPeople
    /// </summary>
    public unsafe int NumWallsKilledPeople
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2840); }
    }

    /// <summary>
    /// IntProperty: NumVillainsHitByPlacedMines
    /// </summary>
    public unsafe int NumVillainsHitByPlacedMines
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2844); }
    }

    /// <summary>
    /// FloatProperty: VillainTargetRange
    /// </summary>
    public unsafe float VillainTargetRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2848); }
    }

    /// <summary>
    /// FloatProperty: VantageExplosionRadius
    /// </summary>
    public unsafe float VantageExplosionRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2852); }
    }

    /// <summary>
    /// FloatProperty: VantageMarkerParticleFactor
    /// </summary>
    public unsafe float VantageMarkerParticleFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2856); }
    }

    /// <summary>
    /// ArrayProperty: CurrentTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RInventoryGadget.TutorialText>>> CurrentTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RInventoryGadget.TutorialText>>>>(Ptr + 2860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2860); }
    }

    /// <summary>
    /// ArrayProperty: CurrentTargetParts
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RInventoryGadget.TutorialText>> CurrentTargetParts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RInventoryGadget.TutorialText>>>(Ptr + 2876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2876); }
    }

    /// <summary>
    /// ArrayProperty: NumTouchingEnemies
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RInventoryGadget.TutorialText> NumTouchingEnemies
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RInventoryGadget.TutorialText>>(Ptr + 2892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2892); }
    }
}
