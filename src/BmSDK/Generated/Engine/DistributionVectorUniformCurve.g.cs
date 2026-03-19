#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: DistributionVectorUniformCurve<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class DistributionVectorUniformCurve : BmSDK.DistributionVector, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.DistributionVectorUniformCurve", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal DistributionVectorUniformCurve() { }

    /// <summary>
    /// Constructs a new DistributionVectorUniformCurve
    /// </summary>
    public DistributionVectorUniformCurve(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, DistributionVectorUniformCurve Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected DistributionVectorUniformCurve(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: ConstantCurve
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ConstantCurve
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: bLockAxes1
    /// </summary>
    public unsafe bool bLockAxes1
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 132); }
    }

    /// <summary>
    /// BoolProperty: bLockAxes2
    /// </summary>
    public unsafe bool bLockAxes2
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 132); }
    }

    /// <summary>
    /// BoolProperty: bUseExtremes
    /// </summary>
    public unsafe bool bUseExtremes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 132); }
    }

    /// <summary>
    /// ByteProperty: LockedAxes
    /// </summary>
    public unsafe byte LockedAxes_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }
    /// <summary>
    /// ByteProperty: LockedAxes
    /// </summary>
    public unsafe byte LockedAxes_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 137); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 137); }
    }

    /// <summary>
    /// ByteProperty: MirrorFlags
    /// </summary>
    public unsafe byte MirrorFlags_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 138); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 138); }
    }
    /// <summary>
    /// ByteProperty: MirrorFlags
    /// </summary>
    public unsafe byte MirrorFlags_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 139); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 139); }
    }
    /// <summary>
    /// ByteProperty: MirrorFlags
    /// </summary>
    public unsafe byte MirrorFlags_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }
}
