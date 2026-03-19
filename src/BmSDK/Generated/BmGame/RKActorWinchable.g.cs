#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RKActorWinchable<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RKActorWinchable : BmSDK.BmGame.RKActorSpawnable, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RKActorWinchable", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RKActorWinchable() { }

    /// <summary>
    /// Constructs a new RKActorWinchable
    /// </summary>
    public RKActorWinchable(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RKActorWinchable Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RKActorWinchable(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RKActorWinchable>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RKActorWinchable>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RKActorWinchable>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RKActorWinchable>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RKActorWinchable>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RKActorWinchable>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RKActorWinchable>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ComponentProperty: InteractComponent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT InteractComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// ComponentProperty: HookMeshComp
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HookMeshComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }

    /// <summary>
    /// BoolProperty: BlockInteraction
    /// </summary>
    public unsafe bool BlockInteraction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: HideOnHUDWhenBlockInteraction
    /// </summary>
    public unsafe bool HideOnHUDWhenBlockInteraction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: CanWinchTargetDuringEncounter
    /// </summary>
    public unsafe bool CanWinchTargetDuringEncounter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: HideOnHUDWhenInPursuitMode
    /// </summary>
    public unsafe bool HideOnHUDWhenInPursuitMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: SideStory
    /// </summary>
    public unsafe bool SideStory
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: FixBatmobileWhenWinchingThisAndBatmanExits
    /// </summary>
    public unsafe bool FixBatmobileWhenWinchingThisAndBatmanExits
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: FixThisWhenWinchingThisAndBatmanExits
    /// </summary>
    public unsafe bool FixThisWhenWinchingThisAndBatmanExits
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bKeepWinchRopeFixedLengthWhenAttached
    /// </summary>
    public unsafe bool bKeepWinchRopeFixedLengthWhenAttached
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: HighlightActorMoving
    /// </summary>
    public unsafe bool HighlightActorMoving
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: IsAsleep
    /// </summary>
    public unsafe bool IsAsleep
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: InPreStreamOut
    /// </summary>
    public unsafe bool InPreStreamOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// ObjectProperty: RefActorMaxWinchAngle
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RefActorMaxWinchAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// ObjectProperty: HighlightActorOnWinch
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HighlightActorOnWinch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// ObjectProperty: HighlightActorMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HighlightActorMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// ObjectProperty: HighlightActorStartMoveEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HighlightActorStartMoveEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// ObjectProperty: HighlightActorStopMoveEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HighlightActorStopMoveEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }

    /// <summary>
    /// ObjectProperty: HighlightActoMovementAudioVelocity
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HighlightActoMovementAudioVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }

    /// <summary>
    /// ObjectProperty: FixedBreakParticle
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FixedBreakParticle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }

    /// <summary>
    /// ObjectProperty: FixedBreakAudio
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FixedBreakAudio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// ObjectProperty: StartDragEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT StartDragEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// ObjectProperty: StopDragEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT StopDragEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// ObjectProperty: AttachedToWinch
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AttachedToWinch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// ComponentProperty: ThroughWallViewMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ThroughWallViewMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// FloatProperty: MaxWinchAngle
    /// </summary>
    public unsafe float MaxWinchAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }

    /// <summary>
    /// FloatProperty: HighlightActorUsedZ
    /// </summary>
    public unsafe float HighlightActorUsedZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// FloatProperty: HighlightActorPrevVel
    /// </summary>
    public unsafe float HighlightActorPrevVel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// FloatProperty: FixedInPlaceHealth
    /// </summary>
    public unsafe float FixedInPlaceHealth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }

    /// <summary>
    /// FloatProperty: TimeAtRest
    /// </summary>
    public unsafe float TimeAtRest
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }

    /// <summary>
    /// ArrayProperty: WinchExtraTargetOffsets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>> WinchExtraTargetOffsets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// FloatProperty: AngularDampingOverrideWhenWinchReleased
    /// </summary>
    public unsafe float AngularDampingOverrideWhenWinchReleased
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1148); }
    }
}
