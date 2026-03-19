#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveConfig_RelativeIdle<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSpecialMoveConfig_RelativeIdle : BmSDK.BmGame.RSpecialMoveConfig, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveConfig_RelativeIdle", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_RelativeIdle() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_RelativeIdle
    /// </summary>
    public RSpecialMoveConfig_RelativeIdle(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_RelativeIdle Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_RelativeIdle(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: AnimNameIdle
    /// </summary>
    public unsafe BmSDK.FName AnimNameIdle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// NameProperty: AnimNameTransitionIn
    /// </summary>
    public unsafe BmSDK.FName AnimNameTransitionIn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// ObjectProperty: AnimSetIdle
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AnimSetIdle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// ObjectProperty: AnimSetTransitionIn
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AnimSetTransitionIn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }

    /// <summary>
    /// ObjectProperty: OverlayAnimSet
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT OverlayAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// ArrayProperty: AlternateAnimNameTransitionIn
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> AlternateAnimNameTransitionIn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }

    /// <summary>
    /// ArrayProperty: IdleOverlays
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> IdleOverlays
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// FloatProperty: MinTimeBetweenOverlays
    /// </summary>
    public unsafe float MinTimeBetweenOverlays
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }

    /// <summary>
    /// FloatProperty: MaxTimeBetweenOverlays
    /// </summary>
    public unsafe float MaxTimeBetweenOverlays
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 476); }
    }

    /// <summary>
    /// BoolProperty: bAlignRotationWithNormal
    /// </summary>
    public unsafe bool bAlignRotationWithNormal
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: UseCameraResetDir
    /// </summary>
    public unsafe bool UseCameraResetDir
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bAnyMovementEnds
    /// </summary>
    public unsafe bool bAnyMovementEnds
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bAllowCameraMoveDuringIdle
    /// </summary>
    public unsafe bool bAllowCameraMoveDuringIdle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bDontAlign
    /// </summary>
    public unsafe bool bDontAlign
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bBatmobileRemoteMove
    /// </summary>
    public unsafe bool bBatmobileRemoteMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// FloatProperty: MeetingTime
    /// </summary>
    public unsafe float MeetingTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// ByteProperty: AimAt
    /// </summary>
    public unsafe byte AimAt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// StructProperty: CameraResetDir
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CameraResetDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }

    /// <summary>
    /// FloatProperty: TimeBeforeAnyMovementEnds
    /// </summary>
    public unsafe float TimeBeforeAnyMovementEnds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// FloatProperty: MaximumCameraYaw
    /// </summary>
    public unsafe float MaximumCameraYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }

    /// <summary>
    /// FloatProperty: MaximumCameraPitch
    /// </summary>
    public unsafe float MaximumCameraPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }
}
