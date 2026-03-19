#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RigidBodyBase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RigidBodyBase : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RigidBodyBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RigidBodyBase() { }

    /// <summary>
    /// Constructs a new RigidBodyBase
    /// </summary>
    public RigidBodyBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RigidBodyBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RigidBodyBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RigidBodyBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RigidBodyBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RigidBodyBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RigidBodyBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RigidBodyBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RigidBodyBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RigidBodyBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ArrayProperty: Components
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>> Components
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ArrayProperty: AllComponents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor.Timers> AllComponents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ObjectProperty: DefaultAkAudible
    /// </summary>
    public unsafe BmSDK.Engine.Actor.Timers DefaultAkAudible
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor.Timers>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ObjectProperty: Owner
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Owner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ObjectProperty: Base
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Base
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ObjectProperty: Instigator
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Instigator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ObjectProperty: WorldInfo
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WorldInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// ObjectProperty: LatentSeqNode
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LatentSeqNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// ObjectProperty: PhysicsVolume
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PhysicsVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// ComponentProperty: CollisionComponent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CollisionComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// ComponentProperty: BaseSkelComponent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BaseSkelComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// StructProperty: Location
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Location
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// StructProperty: Rotation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Rotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// FloatProperty: DrawScale
    /// </summary>
    public unsafe float DrawScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// StructProperty: DrawScale3D
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DrawScale3D
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// StructProperty: PrePivot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PrePivot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// StructProperty: EditorIconColor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT EditorIconColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// FloatProperty: EditorIconDrawScale
    /// </summary>
    public unsafe float EditorIconDrawScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// BoolProperty: HighResTextureStreaming
    /// </summary>
    public unsafe bool HighResTextureStreaming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: BoostDynamicTextureStreaming
    /// </summary>
    public unsafe bool BoostDynamicTextureStreaming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bHidingIsTemporary
    /// </summary>
    public unsafe bool bHidingIsTemporary
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bIsTemporarilyHidden
    /// </summary>
    public unsafe bool bIsTemporarilyHidden
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bStatic
    /// </summary>
    public unsafe bool bStatic
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bHidden
    /// </summary>
    public unsafe bool bHidden
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bHiddenInitial
    /// </summary>
    public unsafe bool bHiddenInitial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bNoDelete
    /// </summary>
    public unsafe bool bNoDelete
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bDeleteMe
    /// </summary>
    public unsafe bool bDeleteMe
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bOnlyOwnerSee
    /// </summary>
    public unsafe bool bOnlyOwnerSee
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bTickIsDisabled
    /// </summary>
    public unsafe bool bTickIsDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bStasis
    /// </summary>
    public unsafe bool bStasis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bWaitForTickBeforeStasis
    /// </summary>
    public unsafe bool bWaitForTickBeforeStasis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bEnableChunkyTick
    /// </summary>
    public unsafe bool bEnableChunkyTick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bWorldGeometry
    /// </summary>
    public unsafe bool bWorldGeometry
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreRigidBodyPawns
    /// </summary>
    public unsafe bool bIgnoreRigidBodyPawns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bOrientOnSlope
    /// </summary>
    public unsafe bool bOrientOnSlope
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreEncroachers
    /// </summary>
    public unsafe bool bIgnoreEncroachers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bDestroyedByInterpActor
    /// </summary>
    public unsafe bool bDestroyedByInterpActor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bRouteBeginPlayEvenIfStatic
    /// </summary>
    public unsafe bool bRouteBeginPlayEvenIfStatic
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bIsMoving
    /// </summary>
    public unsafe bool bIsMoving
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysEncroachCheck
    /// </summary>
    public unsafe bool bAlwaysEncroachCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bHasAlternateTargetLocation
    /// </summary>
    public unsafe bool bHasAlternateTargetLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bCanStepUpOn
    /// </summary>
    public unsafe bool bCanStepUpOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bAICanStepUpOn
    /// </summary>
    public unsafe bool bAICanStepUpOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bNetTemporary
    /// </summary>
    public unsafe bool bNetTemporary
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bOnlyRelevantToOwner
    /// </summary>
    public unsafe bool bOnlyRelevantToOwner
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bNetDirty
    /// </summary>
    public unsafe bool bNetDirty
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysRelevant
    /// </summary>
    public unsafe bool bAlwaysRelevant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bReplicateInstigator
    /// </summary>
    public unsafe bool bReplicateInstigator
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bReplicateMovement
    /// </summary>
    public unsafe bool bReplicateMovement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bSkipActorPropertyReplication
    /// </summary>
    public unsafe bool bSkipActorPropertyReplication
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: bUpdateSimulatedPosition
    /// </summary>
    public unsafe bool bUpdateSimulatedPosition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bTearOff
    /// </summary>
    public unsafe bool bTearOff
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bOnlyDirtyReplication
    /// </summary>
    public unsafe bool bOnlyDirtyReplication
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bAllowFluidSurfaceInteraction
    /// </summary>
    public unsafe bool bAllowFluidSurfaceInteraction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bDemoRecording
    /// </summary>
    public unsafe bool bDemoRecording
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bDemoOwner
    /// </summary>
    public unsafe bool bDemoOwner
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bForceDemoRelevant
    /// </summary>
    public unsafe bool bForceDemoRelevant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bNetInitialRotation
    /// </summary>
    public unsafe bool bNetInitialRotation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bReplicateRigidBodyLocation
    /// </summary>
    public unsafe bool bReplicateRigidBodyLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bKillDuringLevelTransition
    /// </summary>
    public unsafe bool bKillDuringLevelTransition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bExchangedRoles
    /// </summary>
    public unsafe bool bExchangedRoles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bConsiderAllStaticMeshComponentsForStreaming
    /// </summary>
    public unsafe bool bConsiderAllStaticMeshComponentsForStreaming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bDebug
    /// </summary>
    public unsafe bool bDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bPostRenderIfNotVisible
    /// </summary>
    public unsafe bool bPostRenderIfNotVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bAllowActorThoughts
    /// </summary>
    public unsafe bool bAllowActorThoughts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bAllowTwoWayEncroach
    /// </summary>
    public unsafe bool bAllowTwoWayEncroach
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bAllowDisableRigidBody
    /// </summary>
    public unsafe bool bAllowDisableRigidBody
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bEnableOptionalRBCollision
    /// </summary>
    public unsafe bool bEnableOptionalRBCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bForceSetAnimPositionInMatinee
    /// </summary>
    public unsafe bool bForceSetAnimPositionInMatinee
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bIsRoad
    /// </summary>
    public unsafe bool bIsRoad
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bIsTunnel
    /// </summary>
    public unsafe bool bIsTunnel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bIsTrainTracks
    /// </summary>
    public unsafe bool bIsTrainTracks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bIsVehicleJumpRamp
    /// </summary>
    public unsafe bool bIsVehicleJumpRamp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bNoBatmobileImpactSparks
    /// </summary>
    public unsafe bool bNoBatmobileImpactSparks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bForceNetUpdate
    /// </summary>
    public unsafe bool bForceNetUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bLightsUpdateLastRenderTime
    /// </summary>
    public unsafe bool bLightsUpdateLastRenderTime
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bManualPerformPhysics
    /// </summary>
    public unsafe bool bManualPerformPhysics
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bHardAttach
    /// </summary>
    public unsafe bool bHardAttach
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bSnapAttach
    /// </summary>
    public unsafe bool bSnapAttach
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreBaseRotation
    /// </summary>
    public unsafe bool bIgnoreBaseRotation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bBasedActorsNoMove
    /// </summary>
    public unsafe bool bBasedActorsNoMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bSkipAttachedMoves
    /// </summary>
    public unsafe bool bSkipAttachedMoves
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bCanBeAdheredTo
    /// </summary>
    public unsafe bool bCanBeAdheredTo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bCanBeFrictionedTo
    /// </summary>
    public unsafe bool bCanBeFrictionedTo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bHurtEntry
    /// </summary>
    public unsafe bool bHurtEntry
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bGameRelevant
    /// </summary>
    public unsafe bool bGameRelevant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bMovable
    /// </summary>
    public unsafe bool bMovable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bDestroyInPainVolume
    /// </summary>
    public unsafe bool bDestroyInPainVolume
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bCanBeDamaged
    /// </summary>
    public unsafe bool bCanBeDamaged
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bShouldBaseAtStartup
    /// </summary>
    public unsafe bool bShouldBaseAtStartup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bPendingDelete
    /// </summary>
    public unsafe bool bPendingDelete
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bCanTeleport
    /// </summary>
    public unsafe bool bCanTeleport
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysTick
    /// </summary>
    public unsafe bool bAlwaysTick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bBlocksNavigation
    /// </summary>
    public unsafe bool bBlocksNavigation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bInvalidateParentLODOnRemove
    /// </summary>
    public unsafe bool bInvalidateParentLODOnRemove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: BlockRigidBody
    /// </summary>
    public unsafe bool BlockRigidBody
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bCollideWhenPlacing
    /// </summary>
    public unsafe bool bCollideWhenPlacing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bCollideActors
    /// </summary>
    public unsafe bool bCollideActors
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bCollideActorsInitial
    /// </summary>
    public unsafe bool bCollideActorsInitial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bCollideWorld
    /// </summary>
    public unsafe bool bCollideWorld
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bCollideComplex
    /// </summary>
    public unsafe bool bCollideComplex
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bBlockActors
    /// </summary>
    public unsafe bool bBlockActors
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bProjTarget
    /// </summary>
    public unsafe bool bProjTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bBlocksTeleport
    /// </summary>
    public unsafe bool bBlocksTeleport
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bPlayerMovementCheck
    /// </summary>
    public unsafe bool bPlayerMovementCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bMoveCollidesWithDynamicApexChunks
    /// </summary>
    public unsafe bool bMoveCollidesWithDynamicApexChunks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bProjectileMoveSingleBlocking
    /// </summary>
    public unsafe bool bProjectileMoveSingleBlocking
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bForceNoVolumeTrace
    /// </summary>
    public unsafe bool bForceNoVolumeTrace
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bNoEncroachCheck
    /// </summary>
    public unsafe bool bNoEncroachCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bCollideAsEncroacher
    /// </summary>
    public unsafe bool bCollideAsEncroacher
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bPhysRigidBodyOutOfWorldCheck
    /// </summary>
    public unsafe bool bPhysRigidBodyOutOfWorldCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bComponentOutsideWorld
    /// </summary>
    public unsafe bool bComponentOutsideWorld
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bForceOctreeSNFilter
    /// </summary>
    public unsafe bool bForceOctreeSNFilter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bForceOctreeMNFilter
    /// </summary>
    public unsafe bool bForceOctreeMNFilter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bRigidBodyWasAwake
    /// </summary>
    public unsafe bool bRigidBodyWasAwake
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bCallRigidBodyWakeEvents
    /// </summary>
    public unsafe bool bCallRigidBodyWakeEvents
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreHurtRadiusLosCheck
    /// </summary>
    public unsafe bool bIgnoreHurtRadiusLosCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bBounce
    /// </summary>
    public unsafe bool bBounce
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bJustTeleported
    /// </summary>
    public unsafe bool bJustTeleported
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bEnableMobileTouch
    /// </summary>
    public unsafe bool bEnableMobileTouch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bNetInitial
    /// </summary>
    public unsafe bool bNetInitial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bNetOwner
    /// </summary>
    public unsafe bool bNetOwner
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bOwnerAlwaysReplicated
    /// </summary>
    public unsafe bool bOwnerAlwaysReplicated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bHiddenEd
    /// </summary>
    public unsafe bool bHiddenEd
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bEditable
    /// </summary>
    public unsafe bool bEditable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bHiddenEdGroup
    /// </summary>
    public unsafe bool bHiddenEdGroup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bHiddenEdLayer
    /// </summary>
    public unsafe bool bHiddenEdLayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bHiddenEdCustom
    /// </summary>
    public unsafe bool bHiddenEdCustom
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bHiddenEdTemporary
    /// </summary>
    public unsafe bool bHiddenEdTemporary
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bHiddenEdLevel
    /// </summary>
    public unsafe bool bHiddenEdLevel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bHiddenEdScene
    /// </summary>
    public unsafe bool bHiddenEdScene
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bEdShouldSnap
    /// </summary>
    public unsafe bool bEdShouldSnap
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bTempEditor
    /// </summary>
    public unsafe bool bTempEditor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bPathColliding
    /// </summary>
    public unsafe bool bPathColliding
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreStaticForPathBuilding
    /// </summary>
    public unsafe bool bIgnoreStaticForPathBuilding
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bPathTemp
    /// </summary>
    public unsafe bool bPathTemp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bScriptInitialized
    /// </summary>
    public unsafe bool bScriptInitialized
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bLockLocation
    /// </summary>
    public unsafe bool bLockLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bForceAllowKismetModification
    /// </summary>
    public unsafe bool bForceAllowKismetModification
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bStripThisActorWhenCooking
    /// </summary>
    public unsafe bool bStripThisActorWhenCooking
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bEdCanScale
    /// </summary>
    public unsafe bool bEdCanScale
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bEdCanNonUniformScale
    /// </summary>
    public unsafe bool bEdCanNonUniformScale
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bEdCanNegativeScale
    /// </summary>
    public unsafe bool bEdCanNegativeScale
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bDonePostBeginPlay
    /// </summary>
    public unsafe bool bDonePostBeginPlay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bBatmanCanClimb
    /// </summary>
    public unsafe bool bBatmanCanClimb
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bAllowSlopedEdges
    /// </summary>
    public unsafe bool bAllowSlopedEdges
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bAllowCrevice
    /// </summary>
    public unsafe bool bAllowCrevice
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bAutoGrapplePoints
    /// </summary>
    public unsafe bool bAutoGrapplePoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bAutoGrapplePointsAreLowPriority
    /// </summary>
    public unsafe bool bAutoGrapplePointsAreLowPriority
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bAutoGrapplePointsAllowSwinging
    /// </summary>
    public unsafe bool bAutoGrapplePointsAllowSwinging
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: CanAlwaysLinkEdges
    /// </summary>
    public unsafe bool CanAlwaysLinkEdges
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bDisallowShimmy
    /// </summary>
    public unsafe bool bDisallowShimmy
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bAllowNarrowAutoGrappleForConcaveEdge
    /// </summary>
    public unsafe bool bAllowNarrowAutoGrappleForConcaveEdge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bValidLineLauncherTarget
    /// </summary>
    public unsafe bool bValidLineLauncherTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bValidGelTarget
    /// </summary>
    public unsafe bool bValidGelTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bPlayerAlwaysSlidesOff
    /// </summary>
    public unsafe bool bPlayerAlwaysSlidesOff
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bCurrentInvestigateHightlighted
    /// </summary>
    public unsafe bool bCurrentInvestigateHightlighted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: CachedInvestigateSightCheck
    /// </summary>
    public unsafe bool CachedInvestigateSightCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreLOSCheck
    /// </summary>
    public unsafe bool bIgnoreLOSCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bDebugEffectIsRelevant
    /// </summary>
    public unsafe bool bDebugEffectIsRelevant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bUpdateComponentsInPriorityOrder
    /// </summary>
    public unsafe bool bUpdateComponentsInPriorityOrder
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bHasAPEXCloth
    /// </summary>
    public unsafe bool bHasAPEXCloth
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 272); }
    }

    /// <summary>
    /// FloatProperty: HighResTextureStreamingOverrideTimestamp
    /// </summary>
    public unsafe float HighResTextureStreamingOverrideTimestamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// ByteProperty: HideOnChapterCondition
    /// </summary>
    public unsafe byte HideOnChapterCondition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }

    /// <summary>
    /// ByteProperty: HideOnSideStory
    /// </summary>
    public unsafe byte HideOnSideStory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 281); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 281); }
    }

    /// <summary>
    /// ByteProperty: HideOnSideStoryCondition
    /// </summary>
    public unsafe byte HideOnSideStoryCondition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 282); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 282); }
    }

    /// <summary>
    /// ByteProperty: Physics
    /// </summary>
    public unsafe byte Physics
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 283); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 283); }
    }

    /// <summary>
    /// ByteProperty: HideOnSideStoryInitialPhysics
    /// </summary>
    public unsafe byte HideOnSideStoryInitialPhysics
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// ByteProperty: RemoteRole
    /// </summary>
    public unsafe byte RemoteRole
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 285); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 285); }
    }

    /// <summary>
    /// ByteProperty: Role
    /// </summary>
    public unsafe byte Role
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 286); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 286); }
    }

    /// <summary>
    /// ByteProperty: CollisionFilter
    /// </summary>
    public unsafe byte CollisionFilter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 287); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 287); }
    }

    /// <summary>
    /// ByteProperty: CollisionType
    /// </summary>
    public unsafe byte CollisionType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// ByteProperty: ReplicatedCollisionType
    /// </summary>
    public unsafe byte ReplicatedCollisionType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 289); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 289); }
    }

    /// <summary>
    /// ByteProperty: TickGroup
    /// </summary>
    public unsafe byte TickGroup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 290); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 290); }
    }

    /// <summary>
    /// StructProperty: DetachFence
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DetachFence
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// ArrayProperty: Timers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> Timers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }

    /// <summary>
    /// IntProperty: EditorTrackingVal
    /// </summary>
    public unsafe int EditorTrackingVal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }

    /// <summary>
    /// StructProperty: TickedFrame
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT TickedFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// IntProperty: ChunkyTick_DeferredNumFrames
    /// </summary>
    public unsafe int ChunkyTick_DeferredNumFrames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// FloatProperty: ChunkyTick_DeferredDeltaSeconds
    /// </summary>
    public unsafe float ChunkyTick_DeferredDeltaSeconds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }

    /// <summary>
    /// StrProperty: LastEdit
    /// </summary>
    public unsafe BmSDK.FString LastEdit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }

    /// <summary>
    /// FloatProperty: LifeSpan
    /// </summary>
    public unsafe float LifeSpan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// StructProperty: CanTraceActorBlockedTypes
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CanTraceActorBlockedTypes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// FloatProperty: LastRenderTime
    /// </summary>
    public unsafe float LastRenderTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// NameProperty: Tag
    /// </summary>
    public unsafe BmSDK.FName Tag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// NameProperty: Layer
    /// </summary>
    public unsafe BmSDK.FName Layer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// NameProperty: Group
    /// </summary>
    public unsafe BmSDK.FName Group
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// StructProperty: HiddenEditorViews
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT HiddenEditorViews
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// ArrayProperty: Touching
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>>>>>>> Touching
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>>>>>>>>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// ArrayProperty: Children
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>>>>>> Children
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>>>>>>>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// FloatProperty: LatentFloat
    /// </summary>
    public unsafe float LatentFloat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }

    /// <summary>
    /// ArrayProperty: PendingTouches
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>>>>> PendingTouches
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>>>>>>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// StructProperty: Velocity
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Velocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// StructProperty: Acceleration
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Acceleration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// StructProperty: AngularVelocity
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AngularVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }

    /// <summary>
    /// NameProperty: BaseBoneName
    /// </summary>
    public unsafe BmSDK.FName BaseBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// ArrayProperty: Attached
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>>>> Attached
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>>>>>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// StructProperty: RelativeLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RelativeLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// StructProperty: RelativeRotation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RelativeRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// IntProperty: OverlapTag
    /// </summary>
    public unsafe int OverlapTag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// StructProperty: RotationRate
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RotationRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// ArrayProperty: SupportedEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>>> SupportedEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>>>>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// ArrayProperty: GeneratedEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>> GeneratedEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>>>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// ArrayProperty: DuplicatedEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>> DuplicatedEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// ArrayProperty: LatentActions
    /// </summary>
    public unsafe BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT> LatentActions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// FloatProperty: InvestigationMaxDistance
    /// </summary>
    public unsafe float InvestigationMaxDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// ArrayProperty: InvestigationDataArray
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT InvestigationDataArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// FloatProperty: InvestigationPriorityOverride
    /// </summary>
    public unsafe float InvestigationPriorityOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }

    /// <summary>
    /// FloatProperty: CachedInvestigateTimestamp
    /// </summary>
    public unsafe float CachedInvestigateTimestamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }

    /// <summary>
    /// FloatProperty: CachedInvestigateUrgency
    /// </summary>
    public unsafe float CachedInvestigateUrgency
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }

    /// <summary>
    /// StructProperty: InvestigateOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT InvestigateOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// ArrayProperty: PendingASyncLoads
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT PendingASyncLoads
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }

    /// <summary>
    /// Struct: FBlockingVolumeTypesContainer
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FBlockingVolumeTypesContainer
    {
        /// <summary>
        /// BoolProperty: AllActors
        /// </summary>
        public unsafe bool AllActors
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Player
        /// </summary>
        public unsafe bool Player
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Enemies
        /// </summary>
        public unsafe bool Enemies
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Friendlies
        /// </summary>
        public unsafe bool Friendlies
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Physics
        /// </summary>
        public unsafe bool Physics
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Batarang
        /// </summary>
        public unsafe bool Batarang
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: BatClaw
        /// </summary>
        public unsafe bool BatClaw
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: LineLauncher
        /// </summary>
        public unsafe bool LineLauncher
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: GrappleGun
        /// </summary>
        public unsafe bool GrappleGun
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Camera
        /// </summary>
        public unsafe bool Camera
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: WeaponsOrLOS
        /// </summary>
        public unsafe bool WeaponsOrLOS
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: MagneticObjects
        /// </summary>
        public unsafe bool MagneticObjects
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: ClimbOnly
        /// </summary>
        public unsafe bool ClimbOnly
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: IgnoreWallPounces
        /// </summary>
        public unsafe bool IgnoreWallPounces
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: FreezeGrenades
        /// </summary>
        public unsafe bool FreezeGrenades
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: SmokeBomb
        /// </summary>
        public unsafe bool SmokeBomb
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: REC
        /// </summary>
        public unsafe bool REC
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Struct: FThought
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FThought
    {
        /// <summary>
        /// StrProperty: Text
        /// </summary>
        public unsafe BmSDK.FString Text
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: Red
        /// </summary>
        public unsafe byte Red
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ByteProperty: Green
        /// </summary>
        public unsafe byte Green
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 17); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 17); }; }
        }

        /// <summary>
        /// ByteProperty: Blue
        /// </summary>
        public unsafe byte Blue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 18); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 18); }; }
        }

        /// <summary>
        /// ByteProperty: Alpha
        /// </summary>
        public unsafe byte Alpha
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 19); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 19); }; }
        }

        /// <summary>
        /// ArrayProperty: DetailThoughts
        /// </summary>
        public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT DetailThoughts
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Struct: FDetailThought
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FDetailThought
    {
        /// <summary>
        /// StrProperty: Text
        /// </summary>
        public unsafe BmSDK.FString Text
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: Red
        /// </summary>
        public unsafe byte Red
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ByteProperty: Green
        /// </summary>
        public unsafe byte Green
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 17); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 17); }; }
        }

        /// <summary>
        /// ByteProperty: Blue
        /// </summary>
        public unsafe byte Blue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 18); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 18); }; }
        }

        /// <summary>
        /// ByteProperty: Alpha
        /// </summary>
        public unsafe byte Alpha
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 19); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 19); }; }
        }
    }

    /// <summary>
    /// Enum: EThoughtGroup
    /// </summary>
    public enum EThoughtGroup
    {
        THOUGHTGROUP_Player = 0,
        THOUGHTGROUP_AI = 1,
        THOUGHTGROUP_Cinematic = 2,
        THOUGHTGROUP_Vehicle = 3,
        THOUGHTGROUP_Batmobile = 4,
        THOUGHTGROUP_MAX = 5,
    }
}
