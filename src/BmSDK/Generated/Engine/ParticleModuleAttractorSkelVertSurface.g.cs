#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleAttractorSkelVertSurface<br/>
/// (size = 0)
/// (flags = 0)
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

    internal ParticleModuleAttractorSkelVertSurface() { }

    /// <summary>
    /// Constructs a new ParticleModuleAttractorSkelVertSurface
    /// </summary>
    public ParticleModuleAttractorSkelVertSurface(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleAttractorSkelVertSurface Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleAttractorSkelVertSurface(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: FalloffType
    /// </summary>
    public unsafe byte FalloffType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// ByteProperty: DestinationType
    /// </summary>
    public unsafe byte DestinationType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 97); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 97); }
    }

    /// <summary>
    /// BoolProperty: bParticleLifeRelative
    /// </summary>
    public unsafe bool bParticleLifeRelative
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bEnforceNormalCheck
    /// </summary>
    public unsafe bool bEnforceNormalCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// StructProperty: FalloffExponent
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleAttractorSkelVertSurface.Range FalloffExponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleAttractorSkelVertSurface.Range>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// StructProperty: Range
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleAttractorSkelVertSurface.Strength Range
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleAttractorSkelVertSurface.Strength>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// StructProperty: Strength
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleAttractorSkelVertSurface.CollisionRadius Strength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleAttractorSkelVertSurface.CollisionRadius>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// StructProperty: CollisionRadius
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleAttractorSkelVertSurface.DragCoefficient CollisionRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleAttractorSkelVertSurface.DragCoefficient>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// StructProperty: DragCoefficient
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleAttractorSkelVertSurface.DragRadius DragCoefficient
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleAttractorSkelVertSurface.DragRadius>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// StructProperty: DragRadius
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleAttractorSkelVertSurface.ValidAssociatedBones DragRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleAttractorSkelVertSurface.ValidAssociatedBones>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// StructProperty: UniversalOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT UniversalOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }

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
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT EditorSkelMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }

    /// <summary>
    /// ArrayProperty: ValidAssociatedBones
    /// </summary>
    public unsafe BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT> ValidAssociatedBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// StructProperty: NormalToCompare
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT NormalToCompare
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }

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
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT ValidMaterialIndices
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// Enum: EVertSurfaceAttractorFalloffType
    /// </summary>
    public enum EVertSurfaceAttractorFalloffType
    {
        VSFOFF_Constant = 0,
        VSFOFF_Linear = 1,
        VSFOFF_Exponent = 2,
        VSFOFF_MAX = 3,
    }
}
