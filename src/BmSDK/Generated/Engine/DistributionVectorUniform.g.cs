#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: DistributionVectorUniform<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class DistributionVectorUniform : BmSDK.DistributionVector, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.DistributionVectorUniform", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal DistributionVectorUniform() { }

    /// <summary>
    /// Constructs a new DistributionVectorUniform
    /// </summary>
    public DistributionVectorUniform(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, DistributionVectorUniform Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected DistributionVectorUniform(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: Max
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Max
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// StructProperty: Min
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Min
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// BoolProperty: bLockAxes
    /// </summary>
    public unsafe bool bLockAxes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 136); }
    }

    /// <summary>
    /// BoolProperty: bUseExtremes
    /// </summary>
    public unsafe bool bUseExtremes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 136); }
    }

    /// <summary>
    /// ByteProperty: LockedAxes
    /// </summary>
    public unsafe byte LockedAxes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ByteProperty: MirrorFlags
    /// </summary>
    public unsafe byte MirrorFlags_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 141); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 141); }
    }
    /// <summary>
    /// ByteProperty: MirrorFlags
    /// </summary>
    public unsafe byte MirrorFlags_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 142); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 142); }
    }
    /// <summary>
    /// ByteProperty: MirrorFlags
    /// </summary>
    public unsafe byte MirrorFlags_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 143); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 143); }
    }
}
