#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveConfig_DriveCar<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSpecialMoveConfig_DriveCar : BmSDK.BmGame.RSpecialMoveConfig_RunningRelativeAnimMove, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveConfig_DriveCar", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_DriveCar() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_DriveCar
    /// </summary>
    public RSpecialMoveConfig_DriveCar(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_DriveCar Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_DriveCar(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: idleAnimName
    /// </summary>
    public unsafe BmSDK.FName idleAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// BoolProperty: bNotifiesHandleCockpit
    /// </summary>
    public unsafe bool bNotifiesHandleCockpit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 508) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 508); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 508); }
    }

    /// <summary>
    /// BoolProperty: bNoTransitionInAnim
    /// </summary>
    public unsafe bool bNoTransitionInAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 508) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 508); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 508); }
    }

    /// <summary>
    /// BoolProperty: bPlayCameraAnimEvenIfBatmanStartsOutside
    /// </summary>
    public unsafe bool bPlayCameraAnimEvenIfBatmanStartsOutside
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 508) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 508); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 508); }
    }
}
