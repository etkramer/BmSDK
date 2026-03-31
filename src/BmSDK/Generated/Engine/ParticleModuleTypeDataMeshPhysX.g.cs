#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleTypeDataMeshPhysX<br/>
/// (size = 116)
/// (flags = 134230162)
/// </summary>
public partial class ParticleModuleTypeDataMeshPhysX : BmSDK.Engine.ParticleModuleTypeDataMesh, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleTypeDataMeshPhysX", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as ParticleModuleTypeDataMeshPhysX.
    /// </summary>
    public static ParticleModuleTypeDataMeshPhysX DefaultObject => (ParticleModuleTypeDataMeshPhysX)StaticClass().DefaultObject;

    internal ParticleModuleTypeDataMeshPhysX() { }

    /// <summary>
    /// Constructs a new ParticleModuleTypeDataMeshPhysX
    /// </summary>
    public ParticleModuleTypeDataMeshPhysX(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleTypeDataMeshPhysX Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleTypeDataMeshPhysX(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ParticleModuleTypeDataMeshPhysX>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleModuleTypeDataMeshPhysX>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ParticleModuleTypeDataMeshPhysX>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleModuleTypeDataMeshPhysX>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleModuleTypeDataMeshPhysX>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleModuleTypeDataMeshPhysX>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ParticleModuleTypeDataMeshPhysX>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleModuleTypeDataMeshPhysX>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Enum: EPhysXMeshRotationMethod
    /// </summary>
    public enum EPhysXMeshRotationMethod
    {
        PMRM_Disabled = 0,
        PMRM_Spherical = 1,
        PMRM_Box = 2,
        PMRM_LongBox = 3,
        PMRM_FlatBox = 4,
        PMRM_Velocity = 5,
        PMRM_MAX = 6,
    }

    /// <summary>
    /// ObjectProperty: PhysXParSys
    /// </summary>
    public unsafe BmSDK.Engine.PhysXParticleSystem PhysXParSys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PhysXParticleSystem>(Ptr + 80); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }
    }

    /// <summary>
    /// ByteProperty: PhysXRotationMethod
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleTypeDataMeshPhysX.EPhysXMeshRotationMethod PhysXRotationMethod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleTypeDataMeshPhysX.EPhysXMeshRotationMethod>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// FloatProperty: FluidRotationCoefficient
    /// </summary>
    public unsafe float FluidRotationCoefficient
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// StructProperty: RenderInstance
    /// </summary>
    public unsafe System.IntPtr RenderInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// StructProperty: VerticalLod
    /// </summary>
    public unsafe ref BmSDK.Engine.ParticleModuleTypeDataPhysX.FPhysXEmitterVerticalLodProperties VerticalLod
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.ParticleModuleTypeDataPhysX.FPhysXEmitterVerticalLodProperties>(Ptr + 96);

    /// <summary>
    /// FloatProperty: ZOffset
    /// </summary>
    public unsafe float ZOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }
}
