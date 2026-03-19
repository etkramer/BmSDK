#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: DistributionVectorConstant<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class DistributionVectorConstant : BmSDK.DistributionVector, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.DistributionVectorConstant", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal DistributionVectorConstant() { }

    /// <summary>
    /// Constructs a new DistributionVectorConstant
    /// </summary>
    public DistributionVectorConstant(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, DistributionVectorConstant Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected DistributionVectorConstant(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: Constant
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Constant
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: bLockAxes
    /// </summary>
    public unsafe bool bLockAxes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 124) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 124); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 124); }
    }

    /// <summary>
    /// ByteProperty: LockedAxes
    /// </summary>
    public unsafe byte LockedAxes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }
}
