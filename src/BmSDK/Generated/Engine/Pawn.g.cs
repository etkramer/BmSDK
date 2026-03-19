#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: Pawn<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class Pawn : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.Pawn", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal Pawn() { }

    /// <summary>
    /// Constructs a new Pawn
    /// </summary>
    public Pawn(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, Pawn Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected Pawn(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<Pawn>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Pawn>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<Pawn>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Pawn>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Pawn>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<Pawn>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Pawn>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// FloatProperty: MaxStepHeight
    /// </summary>
    public unsafe float MaxStepHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// FloatProperty: MaxJumpHeight
    /// </summary>
    public unsafe float MaxJumpHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// FloatProperty: WalkableFloorZ
    /// </summary>
    public unsafe float WalkableFloorZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// FloatProperty: SecondaryStepHeight
    /// </summary>
    public unsafe float SecondaryStepHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }

    /// <summary>
    /// FloatProperty: LedgeCheckThreshold
    /// </summary>
    public unsafe float LedgeCheckThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// StructProperty: PartialLedgeMoveDir
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PartialLedgeMoveDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// ObjectProperty: Controller
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Controller
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// ObjectProperty: NextPawn
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT NextPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// ObjectProperty: LastRealViewer
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LastRealViewer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// ObjectProperty: LastViewer
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LastViewer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// ObjectProperty: PathConstraintList
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PathConstraintList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// ObjectProperty: PathGoalList
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PathGoalList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// ObjectProperty: Anchor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Anchor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// ObjectProperty: LastAnchor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LastAnchor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// ObjectProperty: HeadVolume
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HeadVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// ObjectProperty: noise1other
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT noise1other
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ObjectProperty: noise2other
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT noise2other
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// ObjectProperty: PlayerReplicationInfo
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerReplicationInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// ObjectProperty: OnLadder
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT OnLadder
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// ObjectProperty: LastStartSpot
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LastStartSpot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// ObjectProperty: DrivenVehicle
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DrivenVehicle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// ObjectProperty: LastHitBy
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LastHitBy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// ObjectProperty: InvManager
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT InvManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// ObjectProperty: Weapon
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Weapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// ObjectProperty: PhysicsPushBody
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PhysicsPushBody
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// ObjectProperty: LinkedCullPawn
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LinkedCullPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// ObjectProperty: MIC_PawnMat
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MIC_PawnMat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// ObjectProperty: MIC_PawnHair
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MIC_PawnHair
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// ComponentProperty: SurveillanceParticleEffect
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SurveillanceParticleEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// ComponentProperty: PreRagdollCollisionComponent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PreRagdollCollisionComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// ClassProperty: InventoryManagerClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT InventoryManagerClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// ComponentProperty: CylinderComponent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CylinderComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// ComponentProperty: Mesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Mesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// ClassProperty: HitDamageType
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HitDamageType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// ClassProperty: ControllerClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ControllerClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }

    /// <summary>
    /// FloatProperty: NetRelevancyTime
    /// </summary>
    public unsafe float NetRelevancyTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: bScriptTickSpecial
    /// </summary>
    public unsafe bool bScriptTickSpecial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bUpAndOut
    /// </summary>
    public unsafe bool bUpAndOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bIsWalking
    /// </summary>
    public unsafe bool bIsWalking
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bWantsToCrouch
    /// </summary>
    public unsafe bool bWantsToCrouch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bIsCrouched
    /// </summary>
    public unsafe bool bIsCrouched
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bTryToUncrouch
    /// </summary>
    public unsafe bool bTryToUncrouch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bCanCrouch
    /// </summary>
    public unsafe bool bCanCrouch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bCrawler
    /// </summary>
    public unsafe bool bCrawler
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bReducedSpeed
    /// </summary>
    public unsafe bool bReducedSpeed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bJumpCapable
    /// </summary>
    public unsafe bool bJumpCapable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bCanJump
    /// </summary>
    public unsafe bool bCanJump
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bCanWalk
    /// </summary>
    public unsafe bool bCanWalk
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bCanSwim
    /// </summary>
    public unsafe bool bCanSwim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bCanFly
    /// </summary>
    public unsafe bool bCanFly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bCanClimbLadders
    /// </summary>
    public unsafe bool bCanClimbLadders
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bCanStrafe
    /// </summary>
    public unsafe bool bCanStrafe
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bAvoidLedges
    /// </summary>
    public unsafe bool bAvoidLedges
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bStopAtLedges
    /// </summary>
    public unsafe bool bStopAtLedges
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bAllowLedgeOverhang
    /// </summary>
    public unsafe bool bAllowLedgeOverhang
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bPartiallyOverLedge
    /// </summary>
    public unsafe bool bPartiallyOverLedge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bSimulateGravity
    /// </summary>
    public unsafe bool bSimulateGravity
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreForces
    /// </summary>
    public unsafe bool bIgnoreForces
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bCanWalkOffLedges
    /// </summary>
    public unsafe bool bCanWalkOffLedges
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bCanBeBaseForPawns
    /// </summary>
    public unsafe bool bCanBeBaseForPawns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bSimGravityDisabled
    /// </summary>
    public unsafe bool bSimGravityDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bDirectHitWall
    /// </summary>
    public unsafe bool bDirectHitWall
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bPushesRigidBodies
    /// </summary>
    public unsafe bool bPushesRigidBodies
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bForceFloorCheck
    /// </summary>
    public unsafe bool bForceFloorCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bForceKeepAnchor
    /// </summary>
    public unsafe bool bForceKeepAnchor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bRootMotionOverridesFallingXY
    /// </summary>
    public unsafe bool bRootMotionOverridesFallingXY
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bRootMotionOverridesFallingXY
    /// </summary>
    public unsafe bool bRootMotionOverridesFallingXY
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bCanMantle
    /// </summary>
    public unsafe bool bCanMantle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bCanClimbUp
    /// </summary>
    public unsafe bool bCanClimbUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: bCanClimbCeilings
    /// </summary>
    public unsafe bool bCanClimbCeilings
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: bCanSwatTurn
    /// </summary>
    public unsafe bool bCanSwatTurn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: bCanLeap
    /// </summary>
    public unsafe bool bCanLeap
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: bCanCoverSlip
    /// </summary>
    public unsafe bool bCanCoverSlip
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: bDisplayPathErrors
    /// </summary>
    public unsafe bool bDisplayPathErrors
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: bCanPickupInventory
    /// </summary>
    public unsafe bool bCanPickupInventory
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: bAmbientCreature
    /// </summary>
    public unsafe bool bAmbientCreature
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: bLOSHearing
    /// </summary>
    public unsafe bool bLOSHearing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: bMuffledHearing
    /// </summary>
    public unsafe bool bMuffledHearing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: bDontPossess
    /// </summary>
    public unsafe bool bDontPossess
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: bRollToDesired
    /// </summary>
    public unsafe bool bRollToDesired
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: bStationary
    /// </summary>
    public unsafe bool bStationary
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: bCachedRelevant
    /// </summary>
    public unsafe bool bCachedRelevant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: bNoWeaponFiring
    /// </summary>
    public unsafe bool bNoWeaponFiring
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: bModifyReachSpecCost
    /// </summary>
    public unsafe bool bModifyReachSpecCost
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: bModifyNavPointDest
    /// </summary>
    public unsafe bool bModifyNavPointDest
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: bPathfindsAsVehicle
    /// </summary>
    public unsafe bool bPathfindsAsVehicle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: bPrevBypassSimulatedClientPhysics
    /// </summary>
    public unsafe bool bPrevBypassSimulatedClientPhysics
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: HasDied
    /// </summary>
    public unsafe bool HasDied
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: TurnedOff
    /// </summary>
    public unsafe bool TurnedOff
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: bRunPhysicsWithNoController
    /// </summary>
    public unsafe bool bRunPhysicsWithNoController
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: bForceMaxAccel
    /// </summary>
    public unsafe bool bForceMaxAccel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: bLimitFallAccel
    /// </summary>
    public unsafe bool bLimitFallAccel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: bReplicateHealthToAll
    /// </summary>
    public unsafe bool bReplicateHealthToAll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: bForceRMVelocity
    /// </summary>
    public unsafe bool bForceRMVelocity
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: bForceRegularVelocity
    /// </summary>
    public unsafe bool bForceRegularVelocity
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: bPlayedDeath
    /// </summary>
    public unsafe bool bPlayedDeath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: bDesiredRotationSet
    /// </summary>
    public unsafe bool bDesiredRotationSet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: bLockDesiredRotation
    /// </summary>
    public unsafe bool bLockDesiredRotation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: bUnlockWhenReached
    /// </summary>
    public unsafe bool bUnlockWhenReached
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: bCanTraverse
    /// </summary>
    public unsafe bool bCanTraverse
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 940); }
    }

    /// <summary>
    /// BoolProperty: bCanJumpUpWalls
    /// </summary>
    public unsafe bool bCanJumpUpWalls
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bUseSimplePhysWalking
    /// </summary>
    public unsafe bool bUseSimplePhysWalking
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bUseComplexStepUpCode
    /// </summary>
    public unsafe bool bUseComplexStepUpCode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bIsBatman
    /// </summary>
    public unsafe bool bIsBatman
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bUsedByMatinee
    /// </summary>
    public unsafe bool bUsedByMatinee
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bRootMotionFromInterpCurve
    /// </summary>
    public unsafe bool bRootMotionFromInterpCurve
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bDebugShowCameraLocation
    /// </summary>
    public unsafe bool bDebugShowCameraLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bFastAttachedMove
    /// </summary>
    public unsafe bool bFastAttachedMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bAllowSlideOffEdges
    /// </summary>
    public unsafe bool bAllowSlideOffEdges
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bSurveillanceVisualEffectDisabled
    /// </summary>
    public unsafe bool bSurveillanceVisualEffectDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bAttachSurveillanceEffectToSocket
    /// </summary>
    public unsafe bool bAttachSurveillanceEffectToSocket
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// ByteProperty: WalkingPhysics
    /// </summary>
    public unsafe byte WalkingPhysics
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// ByteProperty: PathSearchType
    /// </summary>
    public unsafe byte PathSearchType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 949); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 949); }
    }

    /// <summary>
    /// ByteProperty: RemoteViewPitch
    /// </summary>
    public unsafe byte RemoteViewPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 950); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 950); }
    }

    /// <summary>
    /// ByteProperty: FlashCount
    /// </summary>
    public unsafe byte FlashCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 951); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 951); }
    }

    /// <summary>
    /// ByteProperty: FiringMode
    /// </summary>
    public unsafe byte FiringMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// ByteProperty: PlayerCollisionFilter
    /// </summary>
    public unsafe byte PlayerCollisionFilter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 953); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 953); }
    }

    /// <summary>
    /// ByteProperty: NonPlayerCollisionFilter
    /// </summary>
    public unsafe byte NonPlayerCollisionFilter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 954); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 954); }
    }

    /// <summary>
    /// FloatProperty: UncrouchTime
    /// </summary>
    public unsafe float UncrouchTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// FloatProperty: CrouchHeight
    /// </summary>
    public unsafe float CrouchHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// FloatProperty: CrouchRadius
    /// </summary>
    public unsafe float CrouchRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// IntProperty: FullHeight
    /// </summary>
    public unsafe int FullHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// FloatProperty: NonPreferredVehiclePathMultiplier
    /// </summary>
    public unsafe float NonPreferredVehiclePathMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// FloatProperty: DesiredSpeed
    /// </summary>
    public unsafe float DesiredSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// FloatProperty: MaxDesiredSpeed
    /// </summary>
    public unsafe float MaxDesiredSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }

    /// <summary>
    /// FloatProperty: HearingThreshold
    /// </summary>
    public unsafe float HearingThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// FloatProperty: Alertness
    /// </summary>
    public unsafe float Alertness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// FloatProperty: SightRadius
    /// </summary>
    public unsafe float SightRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// FloatProperty: PeripheralVision
    /// </summary>
    public unsafe float PeripheralVision
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// FloatProperty: AvgPhysicsTime
    /// </summary>
    public unsafe float AvgPhysicsTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// FloatProperty: Mass
    /// </summary>
    public unsafe float Mass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }

    /// <summary>
    /// FloatProperty: Buoyancy
    /// </summary>
    public unsafe float Buoyancy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// FloatProperty: MeleeRange
    /// </summary>
    public unsafe float MeleeRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// IntProperty: AnchorItem
    /// </summary>
    public unsafe int AnchorItem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// FloatProperty: FindAnchorFailedTime
    /// </summary>
    public unsafe float FindAnchorFailedTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// FloatProperty: LastValidAnchorTime
    /// </summary>
    public unsafe float LastValidAnchorTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// FloatProperty: DestinationOffset
    /// </summary>
    public unsafe float DestinationOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// FloatProperty: NextPathRadius
    /// </summary>
    public unsafe float NextPathRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// StructProperty: SerpentineDir
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SerpentineDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// FloatProperty: SerpentineDist
    /// </summary>
    public unsafe float SerpentineDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }

    /// <summary>
    /// FloatProperty: SerpentineTime
    /// </summary>
    public unsafe float SerpentineTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }

    /// <summary>
    /// FloatProperty: SpawnTime
    /// </summary>
    public unsafe float SpawnTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }

    /// <summary>
    /// IntProperty: MaxPitchLimit
    /// </summary>
    public unsafe int MaxPitchLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }

    /// <summary>
    /// FloatProperty: GroundSpeed
    /// </summary>
    public unsafe float GroundSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }

    /// <summary>
    /// FloatProperty: WaterSpeed
    /// </summary>
    public unsafe float WaterSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1068); }
    }

    /// <summary>
    /// FloatProperty: AirSpeed
    /// </summary>
    public unsafe float AirSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// FloatProperty: LadderSpeed
    /// </summary>
    public unsafe float LadderSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// FloatProperty: AccelRate
    /// </summary>
    public unsafe float AccelRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// FloatProperty: JumpZ
    /// </summary>
    public unsafe float JumpZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }

    /// <summary>
    /// FloatProperty: OutofWaterZ
    /// </summary>
    public unsafe float OutofWaterZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// FloatProperty: MaxOutOfWaterStepHeight
    /// </summary>
    public unsafe float MaxOutOfWaterStepHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// FloatProperty: AirControl
    /// </summary>
    public unsafe float AirControl
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// FloatProperty: WalkingPct
    /// </summary>
    public unsafe float WalkingPct
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// FloatProperty: MovementSpeedModifier
    /// </summary>
    public unsafe float MovementSpeedModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// FloatProperty: CrouchedPct
    /// </summary>
    public unsafe float CrouchedPct
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }

    /// <summary>
    /// FloatProperty: MaxFallSpeed
    /// </summary>
    public unsafe float MaxFallSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }

    /// <summary>
    /// FloatProperty: AIMaxFallSpeedFactor
    /// </summary>
    public unsafe float AIMaxFallSpeedFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// FloatProperty: BaseEyeHeight
    /// </summary>
    public unsafe float BaseEyeHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// FloatProperty: EyeHeight
    /// </summary>
    public unsafe float EyeHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }

    /// <summary>
    /// StructProperty: Floor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Floor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }

    /// <summary>
    /// FloatProperty: SplashTime
    /// </summary>
    public unsafe float SplashTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// IntProperty: Health
    /// </summary>
    public unsafe int Health
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// IntProperty: HealthMax
    /// </summary>
    public unsafe int HealthMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1148); }
    }

    /// <summary>
    /// FloatProperty: BreathTime
    /// </summary>
    public unsafe float BreathTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// FloatProperty: UnderWaterTime
    /// </summary>
    public unsafe float UnderWaterTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1156); }
    }

    /// <summary>
    /// FloatProperty: LastPainTime
    /// </summary>
    public unsafe float LastPainTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }

    /// <summary>
    /// FloatProperty: KismetDeathDelayTime
    /// </summary>
    public unsafe float KismetDeathDelayTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1164); }
    }

    /// <summary>
    /// StructProperty: RMVelocity
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RMVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// StructProperty: noise1spot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT noise1spot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1180); }
    }

    /// <summary>
    /// FloatProperty: noise1time
    /// </summary>
    public unsafe float noise1time
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }
    }

    /// <summary>
    /// FloatProperty: noise1loudness
    /// </summary>
    public unsafe float noise1loudness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1196); }
    }

    /// <summary>
    /// StructProperty: noise2spot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT noise2spot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1200); }
    }

    /// <summary>
    /// FloatProperty: noise2time
    /// </summary>
    public unsafe float noise2time
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1212); }
    }

    /// <summary>
    /// FloatProperty: noise2loudness
    /// </summary>
    public unsafe float noise2loudness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1216); }
    }

    /// <summary>
    /// FloatProperty: SoundDampening
    /// </summary>
    public unsafe float SoundDampening
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1220); }
    }

    /// <summary>
    /// FloatProperty: DamageScaling
    /// </summary>
    public unsafe float DamageScaling
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1224); }
    }

    /// <summary>
    /// StrProperty: MenuName
    /// </summary>
    public unsafe BmSDK.FString MenuName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1228); }
    }

    /// <summary>
    /// NameProperty: LandMovementState
    /// </summary>
    public unsafe BmSDK.FName LandMovementState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1244); }
    }

    /// <summary>
    /// NameProperty: WaterMovementState
    /// </summary>
    public unsafe BmSDK.FName WaterMovementState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1252); }
    }

    /// <summary>
    /// FloatProperty: LastStartTime
    /// </summary>
    public unsafe float LastStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1260); }
    }

    /// <summary>
    /// StructProperty: TakeHitLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT TakeHitLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1264); }
    }

    /// <summary>
    /// StructProperty: TearOffMomentum
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT TearOffMomentum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1276); }
    }

    /// <summary>
    /// FloatProperty: RBPushRadius
    /// </summary>
    public unsafe float RBPushRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1288); }
    }

    /// <summary>
    /// FloatProperty: RBPushStrength
    /// </summary>
    public unsafe float RBPushStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1292); }
    }

    /// <summary>
    /// FloatProperty: AlwaysRelevantDistanceSquared
    /// </summary>
    public unsafe float AlwaysRelevantDistanceSquared
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1296); }
    }

    /// <summary>
    /// FloatProperty: VehicleCheckRadius
    /// </summary>
    public unsafe float VehicleCheckRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1300); }
    }

    /// <summary>
    /// FloatProperty: ViewPitchMin
    /// </summary>
    public unsafe float ViewPitchMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1304); }
    }

    /// <summary>
    /// FloatProperty: ViewPitchMax
    /// </summary>
    public unsafe float ViewPitchMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1308); }
    }

    /// <summary>
    /// IntProperty: AllowedYawError
    /// </summary>
    public unsafe int AllowedYawError
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1312); }
    }

    /// <summary>
    /// StructProperty: DesiredRotation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DesiredRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1316); }
    }

    /// <summary>
    /// StructProperty: FlashLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FlashLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1328); }
    }

    /// <summary>
    /// StructProperty: LastFiringFlashLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LastFiringFlashLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1340); }
    }

    /// <summary>
    /// IntProperty: ShotCount
    /// </summary>
    public unsafe int ShotCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1352); }
    }

    /// <summary>
    /// IntProperty: FailedLandingCount
    /// </summary>
    public unsafe int FailedLandingCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1356); }
    }

    /// <summary>
    /// StructProperty: walkFailPoint
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT walkFailPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1360); }
    }

    /// <summary>
    /// ArrayProperty: SlotNodes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Components>>> SlotNodes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Components>>>>(Ptr + 1372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1372); }
    }

    /// <summary>
    /// ArrayProperty: InterpGroupList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Components>> InterpGroupList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Components>>>(Ptr + 1388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1388); }
    }

    /// <summary>
    /// ArrayProperty: ScalarParameterInterpArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor.Components> ScalarParameterInterpArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor.Components>>(Ptr + 1404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1404); }
    }

    /// <summary>
    /// StructProperty: RootMotionInterpCurve
    /// </summary>
    public unsafe BmSDK.Engine.Actor.Components RootMotionInterpCurve
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor.Components>(Ptr + 1420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1420); }
    }

    /// <summary>
    /// FloatProperty: RootMotionInterpRate
    /// </summary>
    public unsafe float RootMotionInterpRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1452); }
    }

    /// <summary>
    /// FloatProperty: RootMotionInterpCurrentTime
    /// </summary>
    public unsafe float RootMotionInterpCurrentTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1456); }
    }

    /// <summary>
    /// StructProperty: RootMotionInterpCurveLastValue
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RootMotionInterpCurveLastValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1460); }
    }

    /// <summary>
    /// NameProperty: SurveillanceEffectSocket
    /// </summary>
    public unsafe BmSDK.FName SurveillanceEffectSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1472); }
    }
}
