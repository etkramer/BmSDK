#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBatmobileMissile<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBatmobileMissile : BmSDK.BmGame.RBasicProjectile, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBatmobileMissile", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBatmobileMissile() { }

    /// <summary>
    /// Constructs a new RBatmobileMissile
    /// </summary>
    public RBatmobileMissile(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBatmobileMissile Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBatmobileMissile(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatmobileMissile>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileMissile>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatmobileMissile>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileMissile>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileMissile>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatmobileMissile>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileMissile>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: Target
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Target
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// ObjectProperty: ExplosionTemplate
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ExplosionTemplate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// ObjectProperty: ExlposionSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ExlposionSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// ObjectProperty: InitialLoopOn
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT InitialLoopOn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// ObjectProperty: InitialLoopOff
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT InitialLoopOff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// ObjectProperty: InitialLoop
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT InitialLoop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// ObjectProperty: HomingLoopOn
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HomingLoopOn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// ObjectProperty: HomingLoopOff
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HomingLoopOff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// ObjectProperty: HomingLoop
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HomingLoop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// ObjectProperty: AdditionalExplosionSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AdditionalExplosionSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// ObjectProperty: SwitchToPassToExplosion
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SwitchToPassToExplosion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// ComponentProperty: Trail
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Trail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// ComponentProperty: Mesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Mesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }

    /// <summary>
    /// BoolProperty: bHoming
    /// </summary>
    public unsafe bool bHoming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1056); }
    }

    /// <summary>
    /// BoolProperty: MustHitTarget
    /// </summary>
    public unsafe bool MustHitTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1056); }
    }

    /// <summary>
    /// BoolProperty: GroundHugging
    /// </summary>
    public unsafe bool GroundHugging
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1056); }
    }

    /// <summary>
    /// BoolProperty: bForceExplodeAtTarget
    /// </summary>
    public unsafe bool bForceExplodeAtTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1056); }
    }

    /// <summary>
    /// BoolProperty: bDisableAllCollision
    /// </summary>
    public unsafe bool bDisableAllCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1056); }
    }

    /// <summary>
    /// FloatProperty: HomingDelay
    /// </summary>
    public unsafe float HomingDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }

    /// <summary>
    /// FloatProperty: AccelRate
    /// </summary>
    public unsafe float AccelRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }

    /// <summary>
    /// StructProperty: DumbFireDirection
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DumbFireDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1068); }
    }

    /// <summary>
    /// FloatProperty: VelZ
    /// </summary>
    public unsafe float VelZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// FloatProperty: ForceExplodeProxDist
    /// </summary>
    public unsafe float ForceExplodeProxDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }
}
