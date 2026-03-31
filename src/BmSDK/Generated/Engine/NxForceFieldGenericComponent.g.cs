#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: NxForceFieldGenericComponent<br/>
/// (size = 656)
/// (flags = 2292199570)
/// </summary>
public partial class NxForceFieldGenericComponent : BmSDK.Engine.NxForceFieldComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.NxForceFieldGenericComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as NxForceFieldGenericComponent.
    /// </summary>
    public static NxForceFieldGenericComponent DefaultObject => (NxForceFieldGenericComponent)StaticClass().DefaultObject;

    internal NxForceFieldGenericComponent() { }

    /// <summary>
    /// Constructs a new NxForceFieldGenericComponent
    /// </summary>
    public NxForceFieldGenericComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, NxForceFieldGenericComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected NxForceFieldGenericComponent(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<NxForceFieldGenericComponent>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<NxForceFieldGenericComponent>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<NxForceFieldGenericComponent>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<NxForceFieldGenericComponent>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<NxForceFieldGenericComponent>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<NxForceFieldGenericComponent>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<NxForceFieldGenericComponent>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<NxForceFieldGenericComponent>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// FloatProperty: RoughExtentX
    /// </summary>
    public unsafe float RoughExtentX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// FloatProperty: RoughExtentY
    /// </summary>
    public unsafe float RoughExtentY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }

    /// <summary>
    /// FloatProperty: RoughExtentZ
    /// </summary>
    public unsafe float RoughExtentZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// ByteProperty: Coordinates
    /// </summary>
    public unsafe BmSDK.Engine.NxForceFieldGeneric.FFG_ForceFieldCoordinates Coordinates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.NxForceFieldGeneric.FFG_ForceFieldCoordinates>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// StructProperty: Constant
    /// </summary>
    public unsafe ref System.Numerics.Vector3 Constant
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 504);

    /// <summary>
    /// StructProperty: PositionMultiplierX
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PositionMultiplierX
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 516);

    /// <summary>
    /// StructProperty: PositionMultiplierY
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PositionMultiplierY
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 528);

    /// <summary>
    /// StructProperty: PositionMultiplierZ
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PositionMultiplierZ
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 540);

    /// <summary>
    /// StructProperty: PositionTarget
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PositionTarget
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 552);

    /// <summary>
    /// StructProperty: VelocityMultiplierX
    /// </summary>
    public unsafe ref System.Numerics.Vector3 VelocityMultiplierX
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 564);

    /// <summary>
    /// StructProperty: VelocityMultiplierY
    /// </summary>
    public unsafe ref System.Numerics.Vector3 VelocityMultiplierY
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 576);

    /// <summary>
    /// StructProperty: VelocityMultiplierZ
    /// </summary>
    public unsafe ref System.Numerics.Vector3 VelocityMultiplierZ
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 588);

    /// <summary>
    /// StructProperty: VelocityTarget
    /// </summary>
    public unsafe ref System.Numerics.Vector3 VelocityTarget
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 600);

    /// <summary>
    /// StructProperty: Noise
    /// </summary>
    public unsafe ref System.Numerics.Vector3 Noise
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 612);

    /// <summary>
    /// StructProperty: FalloffLinear
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FalloffLinear
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 624);

    /// <summary>
    /// StructProperty: FalloffQuadratic
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FalloffQuadratic
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 636);

    /// <summary>
    /// FloatProperty: TorusRadius
    /// </summary>
    public unsafe float TorusRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// StructProperty: Kernel
    /// </summary>
    public unsafe System.IntPtr Kernel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }
}
