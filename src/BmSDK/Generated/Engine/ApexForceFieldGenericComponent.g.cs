#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ApexForceFieldGenericComponent<br/>
/// (size = 768)
/// (flags = 2290094290)
/// </summary>
public partial class ApexForceFieldGenericComponent : BmSDK.Engine.ApexForceFieldComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ApexForceFieldGenericComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as ApexForceFieldGenericComponent.
    /// </summary>
    public static ApexForceFieldGenericComponent DefaultObject => (ApexForceFieldGenericComponent)StaticClass().DefaultObject;

    internal ApexForceFieldGenericComponent() { }

    /// <summary>
    /// Constructs a new ApexForceFieldGenericComponent
    /// </summary>
    public ApexForceFieldGenericComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ApexForceFieldGenericComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ApexForceFieldGenericComponent(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ApexForceFieldGenericComponent>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ApexForceFieldGenericComponent>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ApexForceFieldGenericComponent>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ApexForceFieldGenericComponent>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ApexForceFieldGenericComponent>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ApexForceFieldGenericComponent>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ApexForceFieldGenericComponent>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ApexForceFieldGenericComponent>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Enum: AFFG_ForceFieldCoordinates
    /// </summary>
    public enum AFFG_ForceFieldCoordinates : byte
    {
        AFFG_CARTESIAN = 0,
        AFFG_SPHERICAL = 1,
        AFFG_CYLINDRICAL = 2,
        AFFG_TOROIDAL = 3,
        AFFG_MAX = 4,
    }

    /// <summary>
    /// FloatProperty: ForceStrength
    /// </summary>
    public unsafe float ForceStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// FloatProperty: ForceRadius
    /// </summary>
    public unsafe float ForceRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// FloatProperty: ForceHeight
    /// </summary>
    public unsafe float ForceHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// ByteProperty: Coordinates
    /// </summary>
    public unsafe BmSDK.Engine.ApexForceFieldGenericComponent.AFFG_ForceFieldCoordinates Coordinates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ApexForceFieldGenericComponent.AFFG_ForceFieldCoordinates>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// StructProperty: Constant
    /// </summary>
    public unsafe ref System.Numerics.Vector3 Constant
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 620);

    /// <summary>
    /// StructProperty: PositionMultiplierX
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PositionMultiplierX
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 632);

    /// <summary>
    /// StructProperty: PositionMultiplierY
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PositionMultiplierY
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 644);

    /// <summary>
    /// StructProperty: PositionMultiplierZ
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PositionMultiplierZ
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 656);

    /// <summary>
    /// StructProperty: PositionTarget
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PositionTarget
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 668);

    /// <summary>
    /// StructProperty: VelocityMultiplierX
    /// </summary>
    public unsafe ref System.Numerics.Vector3 VelocityMultiplierX
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 680);

    /// <summary>
    /// StructProperty: VelocityMultiplierY
    /// </summary>
    public unsafe ref System.Numerics.Vector3 VelocityMultiplierY
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 692);

    /// <summary>
    /// StructProperty: VelocityMultiplierZ
    /// </summary>
    public unsafe ref System.Numerics.Vector3 VelocityMultiplierZ
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 704);

    /// <summary>
    /// StructProperty: VelocityTarget
    /// </summary>
    public unsafe ref System.Numerics.Vector3 VelocityTarget
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 716);

    /// <summary>
    /// StructProperty: Noise
    /// </summary>
    public unsafe ref System.Numerics.Vector3 Noise
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 728);

    /// <summary>
    /// StructProperty: FalloffLinear
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FalloffLinear
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 740);

    /// <summary>
    /// StructProperty: FalloffQuadratic
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FalloffQuadratic
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 752);

    /// <summary>
    /// FloatProperty: TorusRadius
    /// </summary>
    public unsafe float TorusRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }
}
