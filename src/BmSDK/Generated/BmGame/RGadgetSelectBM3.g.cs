#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGadgetSelectBM3<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RGadgetSelectBM3 : BmSDK.BmGame.RGadgetSelect, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGadgetSelectBM3", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGadgetSelectBM3() { }

    /// <summary>
    /// Constructs a new RGadgetSelectBM3
    /// </summary>
    public RGadgetSelectBM3(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGadgetSelectBM3 Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGadgetSelectBM3(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bIsSynced
    /// </summary>
    public unsafe bool bIsSynced
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: bShouldMoveOffscreen
    /// </summary>
    public unsafe bool bShouldMoveOffscreen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: bCornerGadgetVisible
    /// </summary>
    public unsafe bool bCornerGadgetVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: InTapMode
    /// </summary>
    public unsafe bool InTapMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: EarlySelection
    /// </summary>
    public unsafe bool EarlySelection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: IgnoreRightTrigger
    /// </summary>
    public unsafe bool IgnoreRightTrigger
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: IgnoreRunButton
    /// </summary>
    public unsafe bool IgnoreRunButton
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: IgnoreCancelButton
    /// </summary>
    public unsafe bool IgnoreCancelButton
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: VoiceCommandClose
    /// </summary>
    public unsafe bool VoiceCommandClose
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: bDisabledByChallengeEnded
    /// </summary>
    public unsafe bool bDisabledByChallengeEnded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// IntProperty: RequiredGadgetIndex
    /// </summary>
    public unsafe int RequiredGadgetIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// FloatProperty: fShowReadiedGadgetCountUp
    /// </summary>
    public unsafe float fShowReadiedGadgetCountUp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// FloatProperty: fGoOffscreenCountdown
    /// </summary>
    public unsafe float fGoOffscreenCountdown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// FloatProperty: fGoOffscreenPeriod
    /// </summary>
    public unsafe float fGoOffscreenPeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceDeployed
    /// </summary>
    public unsafe float TimeSinceDeployed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// FloatProperty: EarlySelectionDelay
    /// </summary>
    public unsafe float EarlySelectionDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// ObjectProperty: InvMan
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT InvMan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ByteProperty: CurrentGadgetWheelState
    /// </summary>
    public unsafe byte CurrentGadgetWheelState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }
}
