#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: NxGenericForceField<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class NxGenericForceField : BmSDK.Engine.NxForceField, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.NxGenericForceField", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal NxGenericForceField() { }

    /// <summary>
    /// Constructs a new NxGenericForceField
    /// </summary>
    public NxGenericForceField(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, NxGenericForceField Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected NxGenericForceField(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<NxGenericForceField>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<NxGenericForceField>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<NxGenericForceField>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<NxGenericForceField>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<NxGenericForceField>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<NxGenericForceField>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<NxGenericForceField>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ByteProperty: Coordinates
    /// </summary>
    public unsafe byte Coordinates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// StructProperty: Constant
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Constant
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// StructProperty: PositionMultiplierX
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PositionMultiplierX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// StructProperty: PositionMultiplierY
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PositionMultiplierY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// StructProperty: PositionMultiplierZ
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PositionMultiplierZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// StructProperty: PositionTarget
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PositionTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// StructProperty: VelocityMultiplierX
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VelocityMultiplierX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// StructProperty: VelocityMultiplierY
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VelocityMultiplierY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// StructProperty: VelocityMultiplierZ
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VelocityMultiplierZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// StructProperty: VelocityTarget
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VelocityTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// StructProperty: Noise
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Noise
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }

    /// <summary>
    /// StructProperty: FalloffLinear
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FalloffLinear
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// StructProperty: FalloffQuadratic
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FalloffQuadratic
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }

    /// <summary>
    /// FloatProperty: TorusRadius
    /// </summary>
    public unsafe float TorusRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// StructProperty: LinearKernel
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LinearKernel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }
}
