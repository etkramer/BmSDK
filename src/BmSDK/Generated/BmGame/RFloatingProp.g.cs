#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RFloatingProp<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RFloatingProp : BmSDK.BmGame.RKActorSpawnable, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RFloatingProp", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RFloatingProp() { }

    /// <summary>
    /// Constructs a new RFloatingProp
    /// </summary>
    public RFloatingProp(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RFloatingProp Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RFloatingProp(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RFloatingProp>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RFloatingProp>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RFloatingProp>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RFloatingProp>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RFloatingProp>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RFloatingProp>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RFloatingProp>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// FloatProperty: PropDensityMultiplier
    /// </summary>
    public unsafe float PropDensityMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// StructProperty: PropCentreOfMassOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PropCentreOfMassOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// FloatProperty: PropRightingForceMultiplier
    /// </summary>
    public unsafe float PropRightingForceMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// FloatProperty: WaterLineOffset
    /// </summary>
    public unsafe float WaterLineOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// FloatProperty: LiftForceDamping
    /// </summary>
    public unsafe float LiftForceDamping
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// ObjectProperty: CurrWaterVolume
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CurrWaterVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// StructProperty: CurrSurfacePosition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CurrSurfacePosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// StructProperty: CurrSurfaceNormal
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CurrSurfaceNormal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// StructProperty: CurrPropDesiredFloatingUp
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CurrPropDesiredFloatingUp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }

    /// <summary>
    /// StructProperty: FloatingLiftForce
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FloatingLiftForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1068); }
    }

    /// <summary>
    /// StructProperty: FloatingDragForce
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FloatingDragForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }
}
