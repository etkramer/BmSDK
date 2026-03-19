#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SeqAct_SetMesh<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class SeqAct_SetMesh : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SeqAct_SetMesh", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqAct_SetMesh() { }

    /// <summary>
    /// Constructs a new SeqAct_SetMesh
    /// </summary>
    public SeqAct_SetMesh(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqAct_SetMesh Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqAct_SetMesh(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: NewSkeletalMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT NewSkeletalMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ObjectProperty: NewStaticMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT NewStaticMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// ByteProperty: MeshType
    /// </summary>
    public unsafe byte MeshType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// BoolProperty: bIsAllowedToMove
    /// </summary>
    public unsafe bool bIsAllowedToMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 372) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 372); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 372); }
    }

    /// <summary>
    /// BoolProperty: bAllowDecalsToReattach
    /// </summary>
    public unsafe bool bAllowDecalsToReattach
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 372) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 372); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 372); }
    }

    /// <summary>
    /// Enum: EMeshType
    /// </summary>
    public enum EMeshType
    {
        MeshType_StaticMesh = 0,
        MeshType_SkeletalMesh = 1,
        MeshType_MAX = 2,
    }
}
