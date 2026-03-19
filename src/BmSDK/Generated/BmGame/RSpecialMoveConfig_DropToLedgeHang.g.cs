#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveConfig_DropToLedgeHang<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSpecialMoveConfig_DropToLedgeHang : BmSDK.BmGame.RSpecialMoveConfig_RelativeAnimWithTravelAnim, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveConfig_DropToLedgeHang", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_DropToLedgeHang() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_DropToLedgeHang
    /// </summary>
    public RSpecialMoveConfig_DropToLedgeHang(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_DropToLedgeHang Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_DropToLedgeHang(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: TravelAnims
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> TravelAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// IntProperty: Try1stNTravelAnimsMirrored
    /// </summary>
    public unsafe int Try1stNTravelAnimsMirrored
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }

    /// <summary>
    /// IntProperty: Try1stNAnimsMirrored
    /// </summary>
    public unsafe int Try1stNAnimsMirrored
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 476); }
    }

    /// <summary>
    /// BoolProperty: bSwitchCameraForFinalAnim
    /// </summary>
    public unsafe bool bSwitchCameraForFinalAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// NameProperty: CameraStateForFinalAnim
    /// </summary>
    public unsafe BmSDK.FName CameraStateForFinalAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }
}
