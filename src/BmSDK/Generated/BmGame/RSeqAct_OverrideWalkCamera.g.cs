#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_OverrideWalkCamera<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_OverrideWalkCamera : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_OverrideWalkCamera", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_OverrideWalkCamera() { }

    /// <summary>
    /// Constructs a new RSeqAct_OverrideWalkCamera
    /// </summary>
    public RSeqAct_OverrideWalkCamera(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_OverrideWalkCamera Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_OverrideWalkCamera(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: CameraName
    /// </summary>
    public unsafe BmSDK.FName CameraName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bForceCinematicMode
    /// </summary>
    public unsafe bool bForceCinematicMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 360); }
    }

    /// <summary>
    /// BoolProperty: bCustomCameraZoomAllowed
    /// </summary>
    public unsafe bool bCustomCameraZoomAllowed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 360); }
    }

    /// <summary>
    /// BoolProperty: bCustomCameraDisablesDrag
    /// </summary>
    public unsafe bool bCustomCameraDisablesDrag
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 360); }
    }

    /// <summary>
    /// BoolProperty: DontSwitchCamera
    /// </summary>
    public unsafe bool DontSwitchCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 360); }
    }

    /// <summary>
    /// BoolProperty: CustomCameraDisableCollision
    /// </summary>
    public unsafe bool CustomCameraDisableCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 360); }
    }

    /// <summary>
    /// BoolProperty: CustomCameraLockYaw
    /// </summary>
    public unsafe bool CustomCameraLockYaw
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 360); }
    }

    /// <summary>
    /// StructProperty: CustomCameraConfig
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CustomCameraConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }

    /// <summary>
    /// FloatProperty: CustomCameraFOV
    /// </summary>
    public unsafe float CustomCameraFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// FloatProperty: CustomCameraZoomFOV
    /// </summary>
    public unsafe float CustomCameraZoomFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// FloatProperty: CustomCameraTransitionTime
    /// </summary>
    public unsafe float CustomCameraTransitionTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// StructProperty: CustomCameraExtraCameraRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CustomCameraExtraCameraRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// StructProperty: CustomCameraRotationSpeed
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CustomCameraRotationSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// FloatProperty: CustomCameraLockYawMinRangeInDeg
    /// </summary>
    public unsafe float CustomCameraLockYawMinRangeInDeg
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// FloatProperty: CustomCameraLockYawMaxRangeInDeg
    /// </summary>
    public unsafe float CustomCameraLockYawMaxRangeInDeg
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }

    /// <summary>
    /// NameProperty: BatmobileCameraName
    /// </summary>
    public unsafe BmSDK.FName BatmobileCameraName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }
}
