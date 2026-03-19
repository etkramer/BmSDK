#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: DynamicSMActor<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class DynamicSMActor : BmSDK.Engine.RStaticClimbableActor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.DynamicSMActor", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal DynamicSMActor() { }

    /// <summary>
    /// Constructs a new DynamicSMActor
    /// </summary>
    public DynamicSMActor(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, DynamicSMActor Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected DynamicSMActor(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<DynamicSMActor>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<DynamicSMActor>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<DynamicSMActor>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<DynamicSMActor>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<DynamicSMActor>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<DynamicSMActor>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<DynamicSMActor>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ComponentProperty: StaticMeshComponent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT StaticMeshComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// ObjectProperty: ReplicatedMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ReplicatedMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// ObjectProperty: ReplicatedMaterial0
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ReplicatedMaterial0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// ObjectProperty: ReplicatedMaterial1
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ReplicatedMaterial1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bForceStaticDecals
    /// </summary>
    public unsafe bool bForceStaticDecals
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bPawnCanBaseOn
    /// </summary>
    public unsafe bool bPawnCanBaseOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bSafeBaseIfAsleep
    /// </summary>
    public unsafe bool bSafeBaseIfAsleep
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bGoIntoStasisWhenHidden
    /// </summary>
    public unsafe bool bGoIntoStasisWhenHidden
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bVehicleJumpAutoAlignX
    /// </summary>
    public unsafe bool bVehicleJumpAutoAlignX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bVehicleJumpAutoAlignY
    /// </summary>
    public unsafe bool bVehicleJumpAutoAlignY
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bVehicleJumpAutoAlignNegX
    /// </summary>
    public unsafe bool bVehicleJumpAutoAlignNegX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bVehicleJumpAutoAlignNegY
    /// </summary>
    public unsafe bool bVehicleJumpAutoAlignNegY
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// BoolProperty: bDisableRigidBodyPhysicsWhenPawnBasedOn
    /// </summary>
    public unsafe bool bDisableRigidBodyPhysicsWhenPawnBasedOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 720); }
    }

    /// <summary>
    /// StructProperty: ReplicatedMeshTranslation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ReplicatedMeshTranslation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// StructProperty: ReplicatedMeshRotation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ReplicatedMeshRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// StructProperty: ReplicatedMeshScale3D
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ReplicatedMeshScale3D
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// ByteProperty: JumpOffPawnDirectionMask
    /// </summary>
    public unsafe byte JumpOffPawnDirectionMask
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// FloatProperty: MinImpactVelocityForImpactEffect
    /// </summary>
    public unsafe float MinImpactVelocityForImpactEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }
}
