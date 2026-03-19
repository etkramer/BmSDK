#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RProjectileGadgetBase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RProjectileGadgetBase : BmSDK.BmGame.RInventoryGadget, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RProjectileGadgetBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RProjectileGadgetBase() { }

    /// <summary>
    /// Constructs a new RProjectileGadgetBase
    /// </summary>
    public RProjectileGadgetBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RProjectileGadgetBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RProjectileGadgetBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RProjectileGadgetBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RProjectileGadgetBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RProjectileGadgetBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RProjectileGadgetBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RProjectileGadgetBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RProjectileGadgetBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RProjectileGadgetBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ClassProperty: SpawnProjectileClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SpawnProjectileClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2068); }
    }

    /// <summary>
    /// ObjectProperty: SpawnProjectileArchetype
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SpawnProjectileArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2076); }
    }

    /// <summary>
    /// ObjectProperty: CurrentTarget
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CurrentTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2084); }
    }

    /// <summary>
    /// ObjectProperty: LastProjectile
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LastProjectile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2092); }
    }

    /// <summary>
    /// ObjectProperty: HitActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HitActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2100); }
    }

    /// <summary>
    /// ObjectProperty: LaunchSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LaunchSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2108); }
    }

    /// <summary>
    /// ClassProperty: ComboCombatClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ComboCombatClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2116); }
    }

    /// <summary>
    /// ComponentProperty: TargetMarker
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TargetMarker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2124); }
    }

    /// <summary>
    /// ComponentProperty: AimingArcTrail
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AimingArcTrail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2132); }
    }

    /// <summary>
    /// FloatProperty: LaunchSpeed
    /// </summary>
    public unsafe float LaunchSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2140); }
    }

    /// <summary>
    /// FloatProperty: Gravity
    /// </summary>
    public unsafe float Gravity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2144); }
    }

    /// <summary>
    /// BoolProperty: HasFiniteAimRange
    /// </summary>
    public unsafe bool HasFiniteAimRange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2148) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2148); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2148); }
    }

    /// <summary>
    /// BoolProperty: bDeactivateTrailInCover
    /// </summary>
    public unsafe bool bDeactivateTrailInCover
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2148) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2148); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2148); }
    }

    /// <summary>
    /// BoolProperty: bSecondaryFire
    /// </summary>
    public unsafe bool bSecondaryFire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2148) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2148); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2148); }
    }

    /// <summary>
    /// BoolProperty: bValidTarget
    /// </summary>
    public unsafe bool bValidTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2148) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2148); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2148); }
    }

    /// <summary>
    /// BoolProperty: bCombatThrow
    /// </summary>
    public unsafe bool bCombatThrow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2148) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2148); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2148); }
    }

    /// <summary>
    /// BoolProperty: bCanFireSecondary
    /// </summary>
    public unsafe bool bCanFireSecondary
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2148) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2148); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2148); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreGlassCollision
    /// </summary>
    public unsafe bool bIgnoreGlassCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2148) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2148); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2148); }
    }

    /// <summary>
    /// BoolProperty: bCombatThrowToGround
    /// </summary>
    public unsafe bool bCombatThrowToGround
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2148) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2148); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2148); }
    }

    /// <summary>
    /// BoolProperty: bStartedComboMove
    /// </summary>
    public unsafe bool bStartedComboMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2148) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2148); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2148); }
    }

    /// <summary>
    /// BoolProperty: bUntargetedCombatKeepsCombos
    /// </summary>
    public unsafe bool bUntargetedCombatKeepsCombos
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2148) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2148); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2148); }
    }

    /// <summary>
    /// BoolProperty: bDebugSimulateOverworld
    /// </summary>
    public unsafe bool bDebugSimulateOverworld
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2148) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2148); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2148); }
    }

    /// <summary>
    /// BoolProperty: bVillainDodged
    /// </summary>
    public unsafe bool bVillainDodged
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2148) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2148); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2148); }
    }

    /// <summary>
    /// BoolProperty: UnequipOnFire
    /// </summary>
    public unsafe bool UnequipOnFire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2148) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2148); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2148); }
    }

    /// <summary>
    /// FloatProperty: AimRange
    /// </summary>
    public unsafe float AimRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2152); }
    }

    /// <summary>
    /// FloatProperty: ProjectileAutoTargetAngle
    /// </summary>
    public unsafe float ProjectileAutoTargetAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2156); }
    }

    /// <summary>
    /// FloatProperty: ProjectileAutoTargetRange
    /// </summary>
    public unsafe float ProjectileAutoTargetRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2160); }
    }

    /// <summary>
    /// NameProperty: DefaultGadgetCamera
    /// </summary>
    public unsafe BmSDK.FName DefaultGadgetCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2164); }
    }

    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.TutorialText ThrowDirectionTypes_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.TutorialText>(Ptr + 2172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2172); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.TutorialText ThrowDirectionTypes_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.TutorialText>(Ptr + 2188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2188); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.TutorialText ThrowDirectionTypes_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.TutorialText>(Ptr + 2204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2204); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.TutorialText ThrowDirectionTypes_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.TutorialText>(Ptr + 2220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2220); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.TutorialText ThrowDirectionTypes_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.TutorialText>(Ptr + 2236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2236); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.TutorialText ThrowDirectionTypes_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.TutorialText>(Ptr + 2252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2252); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.TutorialText ThrowDirectionTypes_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.TutorialText>(Ptr + 2268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2268); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.TutorialText ThrowDirectionTypes_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.TutorialText>(Ptr + 2284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2284); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.TutorialText ThrowDirectionTypes_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.TutorialText>(Ptr + 2300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2300); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.TutorialText ThrowDirectionTypes_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.TutorialText>(Ptr + 2316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2316); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.TutorialText ThrowDirectionTypes_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.TutorialText>(Ptr + 2332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2332); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.TutorialText ThrowDirectionTypes_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.TutorialText>(Ptr + 2348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2348); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.TutorialText ThrowDirectionTypes_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.TutorialText>(Ptr + 2364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2364); }
    }

    /// <summary>
    /// StructProperty: InitialVelocity
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT InitialVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2380); }
    }

    /// <summary>
    /// ByteProperty: LastMirrorChoice
    /// </summary>
    public unsafe byte LastMirrorChoice
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2392); }
    }

    /// <summary>
    /// ByteProperty: LeftHandedThrow
    /// </summary>
    public unsafe byte LeftHandedThrow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2393); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2393); }
    }

    /// <summary>
    /// StructProperty: TargetLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT TargetLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2396); }
    }

    /// <summary>
    /// StructProperty: RenderTargetLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RenderTargetLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2408); }
    }

    /// <summary>
    /// StructProperty: ThrowOffsetPosition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ThrowOffsetPosition_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2420); }
    }
    /// <summary>
    /// StructProperty: ThrowOffsetPosition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ThrowOffsetPosition_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2432); }
    }
    /// <summary>
    /// StructProperty: ThrowOffsetPosition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ThrowOffsetPosition_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2444); }
    }
    /// <summary>
    /// StructProperty: ThrowOffsetPosition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ThrowOffsetPosition_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2456); }
    }
    /// <summary>
    /// StructProperty: ThrowOffsetPosition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ThrowOffsetPosition_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2468); }
    }
    /// <summary>
    /// StructProperty: ThrowOffsetPosition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ThrowOffsetPosition_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2480); }
    }
    /// <summary>
    /// StructProperty: ThrowOffsetPosition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ThrowOffsetPosition_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2492); }
    }
    /// <summary>
    /// StructProperty: ThrowOffsetPosition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ThrowOffsetPosition_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2504); }
    }
    /// <summary>
    /// StructProperty: ThrowOffsetPosition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ThrowOffsetPosition_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2516); }
    }
    /// <summary>
    /// StructProperty: ThrowOffsetPosition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ThrowOffsetPosition_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2528); }
    }
    /// <summary>
    /// StructProperty: ThrowOffsetPosition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ThrowOffsetPosition_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2540); }
    }
    /// <summary>
    /// StructProperty: ThrowOffsetPosition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ThrowOffsetPosition_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2552); }
    }
    /// <summary>
    /// StructProperty: ThrowOffsetPosition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ThrowOffsetPosition_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2564); }
    }

    /// <summary>
    /// FloatProperty: AOERadius
    /// </summary>
    public unsafe float AOERadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2576); }
    }

    /// <summary>
    /// FloatProperty: CombatAimAngle
    /// </summary>
    public unsafe float CombatAimAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2580); }
    }

    /// <summary>
    /// FloatProperty: ReplenishTime
    /// </summary>
    public unsafe float ReplenishTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2584); }
    }

    /// <summary>
    /// FloatProperty: ThrowTime
    /// </summary>
    public unsafe float ThrowTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2588); }
    }
}
