#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleLocationStaticVertSurface<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ParticleModuleLocationStaticVertSurface : BmSDK.Engine.ParticleModuleLocationBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleLocationStaticVertSurface", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleLocationStaticVertSurface() { }

    /// <summary>
    /// Constructs a new ParticleModuleLocationStaticVertSurface
    /// </summary>
    public ParticleModuleLocationStaticVertSurface(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleLocationStaticVertSurface Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleLocationStaticVertSurface(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: SourceType
    /// </summary>
    public unsafe byte SourceType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// StructProperty: UniversalOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT UniversalOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bUpdatePositionEachFrame
    /// </summary>
    public unsafe bool bUpdatePositionEachFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: bOrientMeshEmitters
    /// </summary>
    public unsafe bool bOrientMeshEmitters
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: bEnforceNormalCheck
    /// </summary>
    public unsafe bool bEnforceNormalCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// NameProperty: StaticMeshActorParamName
    /// </summary>
    public unsafe BmSDK.FName StaticMeshActorParamName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// ObjectProperty: EditorStaticMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT EditorStaticMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// StructProperty: NormalToCompare
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT NormalToCompare
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// FloatProperty: NormalCheckToleranceDegrees
    /// </summary>
    public unsafe float NormalCheckToleranceDegrees
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// FloatProperty: NormalCheckTolerance
    /// </summary>
    public unsafe float NormalCheckTolerance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ArrayProperty: ValidMaterialIndices
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT ValidMaterialIndices
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// Enum: ELocationStaticVertSurfaceSource
    /// </summary>
    public enum ELocationStaticVertSurfaceSource
    {
        VERTSTATICSURFACESOURCE_Vert = 0,
        VERTSTATICSURFACESOURCE_Surface = 1,
        VERTSTATICSURFACESOURCE_MAX = 2,
    }
}
