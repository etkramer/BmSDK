#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleAttractorBoneSocket<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ParticleModuleAttractorBoneSocket : BmSDK.Engine.ParticleModuleAttractorBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleAttractorBoneSocket", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleAttractorBoneSocket() { }

    /// <summary>
    /// Constructs a new ParticleModuleAttractorBoneSocket
    /// </summary>
    public ParticleModuleAttractorBoneSocket(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleAttractorBoneSocket Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleAttractorBoneSocket(nint ptr) : base(ptr) { }

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
    /// ByteProperty: SelectionMethod
    /// </summary>
    public unsafe byte SelectionMethod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 98); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 98); }
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
    /// BoolProperty: bAttractAlongLengthOfBone
    /// </summary>
    public unsafe bool bAttractAlongLengthOfBone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// StructProperty: FalloffExponent
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleAttractorBoneSocket.Range FalloffExponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleAttractorBoneSocket.Range>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// StructProperty: Range
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleAttractorBoneSocket.Strength Range
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleAttractorBoneSocket.Strength>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// StructProperty: Strength
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleAttractorBoneSocket.CollisionRadius Strength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleAttractorBoneSocket.CollisionRadius>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// StructProperty: CollisionRadius
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleAttractorBoneSocket.DragCoefficient CollisionRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleAttractorBoneSocket.DragCoefficient>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// StructProperty: DragCoefficient
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleAttractorBoneSocket.DragRadius DragCoefficient
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleAttractorBoneSocket.DragRadius>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// StructProperty: DragRadius
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleAttractorBoneSocket.SourceLocations DragRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleAttractorBoneSocket.SourceLocations>(Ptr + 284); }
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
    /// ArrayProperty: SourceLocations
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT SourceLocations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }

    /// <summary>
    /// NameProperty: SkelMeshActorParamName
    /// </summary>
    public unsafe BmSDK.FName SkelMeshActorParamName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// ObjectProperty: EditorSkelMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT EditorSkelMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// Enum: EBoneSocketAttractorFalloffType
    /// </summary>
    public enum EBoneSocketAttractorFalloffType
    {
        BSFOFF_Constant = 0,
        BSFOFF_Linear = 1,
        BSFOFF_Exponent = 2,
        BSFOFF_MAX = 3,
    }
}
