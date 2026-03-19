#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleLocationBoneSocket<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ParticleModuleLocationBoneSocket : BmSDK.Engine.ParticleModuleLocationBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleLocationBoneSocket", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleLocationBoneSocket() { }

    /// <summary>
    /// Constructs a new ParticleModuleLocationBoneSocket
    /// </summary>
    public ParticleModuleLocationBoneSocket(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleLocationBoneSocket Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleLocationBoneSocket(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: SourceType
    /// </summary>
    public unsafe byte SourceType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// ByteProperty: SelectionMethod
    /// </summary>
    public unsafe byte SelectionMethod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 97); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 97); }
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
    /// ArrayProperty: SourceLocations
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT SourceLocations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: bUpdatePositionEachFrame
    /// </summary>
    public unsafe bool bUpdatePositionEachFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// BoolProperty: bOrientMeshEmitters
    /// </summary>
    public unsafe bool bOrientMeshEmitters
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// BoolProperty: bInheritVelocityAtSpawn
    /// </summary>
    public unsafe bool bInheritVelocityAtSpawn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// NameProperty: SkelMeshActorParamName
    /// </summary>
    public unsafe BmSDK.FName SkelMeshActorParamName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ObjectProperty: EditorSkelMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT EditorSkelMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// FloatProperty: LastUpdateTime
    /// </summary>
    public unsafe float LastUpdateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// Enum: ELocationBoneSocketSource
    /// </summary>
    public enum ELocationBoneSocketSource
    {
        BONESOCKETSOURCE_Bones = 0,
        BONESOCKETSOURCE_Sockets = 1,
        BONESOCKETSOURCE_MAX = 2,
    }
}
