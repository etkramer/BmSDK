#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleAttractorSkelVertSurface<br/>
/// (size = 400)
/// (flags = 142610578)
/// </summary>
public partial class ParticleModuleAttractorSkelVertSurface : BmSDK.Engine.ParticleModuleAttractorBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleAttractorSkelVertSurface", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as ParticleModuleAttractorSkelVertSurface.
    /// </summary>
    public static ParticleModuleAttractorSkelVertSurface DefaultObject => (ParticleModuleAttractorSkelVertSurface)StaticClass().DefaultObject;

    internal ParticleModuleAttractorSkelVertSurface() { }

    /// <summary>
    /// Constructs a new ParticleModuleAttractorSkelVertSurface
    /// </summary>
    public ParticleModuleAttractorSkelVertSurface(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleAttractorSkelVertSurface Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleAttractorSkelVertSurface(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ParticleModuleAttractorSkelVertSurface>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleModuleAttractorSkelVertSurface>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ParticleModuleAttractorSkelVertSurface>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleModuleAttractorSkelVertSurface>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleModuleAttractorSkelVertSurface>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleModuleAttractorSkelVertSurface>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ParticleModuleAttractorSkelVertSurface>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleModuleAttractorSkelVertSurface>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Enum: EAttractorSkelVertSurfaceDestination
    /// </summary>
    public enum EAttractorSkelVertSurfaceDestination : byte
    {
        VERTSURFACEDEST_Vert = 0,
        VERTSURFACEDEST_Surface = 1,
        VERTSURFACEDEST_MAX = 2,
    }

    /// <summary>
    /// ByteProperty: FalloffType
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleAttractorSkelVertSurface.EVertSurfaceAttractorFalloffType FalloffType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleAttractorSkelVertSurface.EVertSurfaceAttractorFalloffType>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// ByteProperty: DestinationType
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleAttractorSkelVertSurface.EAttractorSkelVertSurfaceDestination DestinationType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleAttractorSkelVertSurface.EAttractorSkelVertSurfaceDestination>(Ptr + 97); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 97); }
    }

    /// <summary>
    /// BoolProperty: bParticleLifeRelative
    /// </summary>
    public unsafe bool bParticleLifeRelative
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bEnforceNormalCheck
    /// </summary>
    public unsafe bool bEnforceNormalCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// StructProperty: FalloffExponent
    /// </summary>
    public unsafe ref BmSDK.DistributionFloat.FRawDistributionFloat FalloffExponent
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 104);

    /// <summary>
    /// StructProperty: Range
    /// </summary>
    public unsafe ref BmSDK.DistributionFloat.FRawDistributionFloat Range
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 140);

    /// <summary>
    /// StructProperty: Strength
    /// </summary>
    public unsafe ref BmSDK.DistributionFloat.FRawDistributionFloat Strength
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 176);

    /// <summary>
    /// StructProperty: CollisionRadius
    /// </summary>
    public unsafe ref BmSDK.DistributionFloat.FRawDistributionFloat CollisionRadius
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 212);

    /// <summary>
    /// StructProperty: DragCoefficient
    /// </summary>
    public unsafe ref BmSDK.DistributionFloat.FRawDistributionFloat DragCoefficient
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 248);

    /// <summary>
    /// StructProperty: DragRadius
    /// </summary>
    public unsafe ref BmSDK.DistributionFloat.FRawDistributionFloat DragRadius
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 284);

    /// <summary>
    /// StructProperty: UniversalOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 UniversalOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 320);

    /// <summary>
    /// NameProperty: SkelMeshActorParamName
    /// </summary>
    public unsafe BmSDK.FName SkelMeshActorParamName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }

    /// <summary>
    /// ObjectProperty: EditorSkelMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMesh EditorSkelMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }

    /// <summary>
    /// ArrayProperty: ValidAssociatedBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> ValidAssociatedBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// StructProperty: NormalToCompare
    /// </summary>
    public unsafe ref System.Numerics.Vector3 NormalToCompare
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 364);

    /// <summary>
    /// FloatProperty: NormalCheckToleranceDegrees
    /// </summary>
    public unsafe float NormalCheckToleranceDegrees
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// FloatProperty: NormalCheckTolerance
    /// </summary>
    public unsafe float NormalCheckTolerance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// ArrayProperty: ValidMaterialIndices
    /// </summary>
    public unsafe BmSDK.TArray<int> ValidMaterialIndices
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// Enum: EVertSurfaceAttractorFalloffType
    /// </summary>
    public enum EVertSurfaceAttractorFalloffType : byte
    {
        VSFOFF_Constant = 0,
        VSFOFF_Linear = 1,
        VSFOFF_Exponent = 2,
        VSFOFF_MAX = 3,
    }
}
