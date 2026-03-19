#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RB_RadialForceActor<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RB_RadialForceActor : BmSDK.Engine.RigidBodyBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RB_RadialForceActor", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RB_RadialForceActor() { }

    /// <summary>
    /// Constructs a new RB_RadialForceActor
    /// </summary>
    public RB_RadialForceActor(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RB_RadialForceActor Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RB_RadialForceActor(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RB_RadialForceActor>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RB_RadialForceActor>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RB_RadialForceActor>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RB_RadialForceActor>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RB_RadialForceActor>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RB_RadialForceActor>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RB_RadialForceActor>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ComponentProperty: RenderComponent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RenderComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// FloatProperty: ForceStrength
    /// </summary>
    public unsafe float ForceStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// FloatProperty: ForceRadius
    /// </summary>
    public unsafe float ForceRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }

    /// <summary>
    /// FloatProperty: SwirlStrength
    /// </summary>
    public unsafe float SwirlStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// FloatProperty: SpinTorque
    /// </summary>
    public unsafe float SpinTorque
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// ByteProperty: ForceFalloff
    /// </summary>
    public unsafe byte ForceFalloff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// ByteProperty: RadialForceMode
    /// </summary>
    public unsafe byte RadialForceMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 693); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 693); }
    }

    /// <summary>
    /// BoolProperty: bForceActive
    /// </summary>
    public unsafe bool bForceActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: bForceApplyToCloth
    /// </summary>
    public unsafe bool bForceApplyToCloth
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: bForceApplyToFluid
    /// </summary>
    public unsafe bool bForceApplyToFluid
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: bForceApplyToRigidBodies
    /// </summary>
    public unsafe bool bForceApplyToRigidBodies
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: bForceApplyToProjectiles
    /// </summary>
    public unsafe bool bForceApplyToProjectiles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// StructProperty: CollideWithChannels
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CollideWithChannels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// Enum: ERadialForceType
    /// </summary>
    public enum ERadialForceType
    {
        RFT_Force = 0,
        RFT_Impulse = 1,
        RFT_MAX = 2,
    }
}
