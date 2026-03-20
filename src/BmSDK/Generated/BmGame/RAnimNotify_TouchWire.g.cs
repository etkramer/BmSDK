#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAnimNotify_TouchWire<br/>
/// (size = 92)
/// (flags = 0)
/// </summary>
public partial class RAnimNotify_TouchWire : BmSDK.Engine.AnimNotify, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimNotify_TouchWire", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimNotify_TouchWire() { }

    /// <summary>
    /// Constructs a new RAnimNotify_TouchWire
    /// </summary>
    public RAnimNotify_TouchWire(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnimNotify_TouchWire Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimNotify_TouchWire(nint ptr) : base(ptr) { }

    /// <summary>
    /// Enum: LimbOnOrOff
    /// </summary>
    public enum LimbOnOrOff
    {
        LIMB_On = 0,
        LIMB_Off = 1,
        LIMB_MAX = 2,
    }

    /// <summary>
    /// ByteProperty: LimbType
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.OverheadRopeControlPointType LimbType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.OverheadRopeControlPointType>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ByteProperty: OnOrOff
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimNotify_TouchWire.LimbOnOrOff OnOrOff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimNotify_TouchWire.LimbOnOrOff>(Ptr + 85); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 85); }
    }

    /// <summary>
    /// BoolProperty: CanBeLastLimbToComeOff
    /// </summary>
    public unsafe bool CanBeLastLimbToComeOff
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 88); }
    }
}
