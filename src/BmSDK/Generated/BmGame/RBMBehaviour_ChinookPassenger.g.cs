#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_ChinookPassenger<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMBehaviour_ChinookPassenger : BmSDK.BmGame.RBMBehaviour, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_ChinookPassenger", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_ChinookPassenger() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_ChinookPassenger
    /// </summary>
    public RBMBehaviour_ChinookPassenger(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_ChinookPassenger Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_ChinookPassenger(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Chinook
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Chinook
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// IntProperty: PassengerID
    /// </summary>
    public unsafe int PassengerID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// StructProperty: PassengerInfo
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PassengerInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// BoolProperty: bPlayerClose
    /// </summary>
    public unsafe bool bPlayerClose
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 644) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 644); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 644); }
    }

    /// <summary>
    /// BoolProperty: bAbseiled
    /// </summary>
    public unsafe bool bAbseiled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 644) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 644); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 644); }
    }
}
