#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSmashablePropSpawnable<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSmashablePropSpawnable : BmSDK.BmGame.RSmashableProp, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSmashablePropSpawnable", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSmashablePropSpawnable() { }

    /// <summary>
    /// Constructs a new RSmashablePropSpawnable
    /// </summary>
    public RSmashablePropSpawnable(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSmashablePropSpawnable Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSmashablePropSpawnable(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSmashablePropSpawnable>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSmashablePropSpawnable>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSmashablePropSpawnable>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSmashablePropSpawnable>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSmashablePropSpawnable>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSmashablePropSpawnable>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSmashablePropSpawnable>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: PropData
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PropData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// ObjectProperty: BreakCollideActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BreakCollideActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }

    /// <summary>
    /// ByteProperty: PropBreakableType
    /// </summary>
    public unsafe byte PropBreakableType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: PropIsStatic
    /// </summary>
    public unsafe bool PropIsStatic
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: PropIsBroken
    /// </summary>
    public unsafe bool PropIsBroken
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: IgnorePawnCollisions
    /// </summary>
    public unsafe bool IgnorePawnCollisions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: TurnStaticOnStationary
    /// </summary>
    public unsafe bool TurnStaticOnStationary
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: PropWasSpawned
    /// </summary>
    public unsafe bool PropWasSpawned
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: bQueueEmitSmashSpeedAlert
    /// </summary>
    public unsafe bool bQueueEmitSmashSpeedAlert
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: bForceNotifyRigidBodyCollision
    /// </summary>
    public unsafe bool bForceNotifyRigidBodyCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// FloatProperty: PropBreakingForce
    /// </summary>
    public unsafe float PropBreakingForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// FloatProperty: PropBreakTimer
    /// </summary>
    public unsafe float PropBreakTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// FloatProperty: PropExplosiveImpulse
    /// </summary>
    public unsafe float PropExplosiveImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// StructProperty: PropImpulse
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PropImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// NameProperty: BreakTimerName
    /// </summary>
    public unsafe BmSDK.FName BreakTimerName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// FloatProperty: TurnStaticTimer
    /// </summary>
    public unsafe float TurnStaticTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }

    /// <summary>
    /// StructProperty: PropBreakingImpulse
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PropBreakingImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }

    /// <summary>
    /// StructProperty: AppliedImpulse
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AppliedImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1068); }
    }

    /// <summary>
    /// ArrayProperty: LinkedActors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>> LinkedActors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// ArrayProperty: DecalMaterialInstances
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>> DecalMaterialInstances
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }
}
