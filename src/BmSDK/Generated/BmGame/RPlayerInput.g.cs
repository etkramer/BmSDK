#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPlayerInput<br/>
/// (flags = 0)
/// </summary>
public partial class RPlayerInput : BmSDK.Engine.PlayerInput, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPlayerInput", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPlayerInput() { }

    /// <summary>
    /// Constructs a new RPlayerInput
    /// </summary>
    public RPlayerInput(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPlayerInput Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPlayerInput(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bInvertJoystick
    /// </summary>
    public unsafe bool bInvertJoystick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bLeftTrigger
    /// </summary>
    public unsafe bool bLeftTrigger
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bRightTrigger
    /// </summary>
    public unsafe bool bRightTrigger
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bTakedownButton
    /// </summary>
    public unsafe bool bTakedownButton
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bQuickStrike
    /// </summary>
    public unsafe bool bQuickStrike
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bHeavyStrike
    /// </summary>
    public unsafe bool bHeavyStrike
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bChargeStrike
    /// </summary>
    public unsafe bool bChargeStrike
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bLeftBumper
    /// </summary>
    public unsafe bool bLeftBumper
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bRightBumper
    /// </summary>
    public unsafe bool bRightBumper
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bSticksInverted
    /// </summary>
    public unsafe bool bSticksInverted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bInvertCapeGlide
    /// </summary>
    public unsafe bool bInvertCapeGlide
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bInvertBatarang
    /// </summary>
    public unsafe bool bInvertBatarang
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bUseEasyControls
    /// </summary>
    public unsafe bool bUseEasyControls
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bUseSixaxisControls
    /// </summary>
    public unsafe bool bUseSixaxisControls
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bUseForensicsButton
    /// </summary>
    public unsafe bool bUseForensicsButton
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bInvertedCeilingControls
    /// </summary>
    public unsafe bool bInvertedCeilingControls
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bSouthPawControls
    /// </summary>
    public unsafe bool bSouthPawControls
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bSouthPawActive
    /// </summary>
    public unsafe bool bSouthPawActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bBatmobileBattleModeToggle
    /// </summary>
    public unsafe bool bBatmobileBattleModeToggle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// FloatProperty: aRawLHJoyUp
    /// </summary>
    public unsafe float aRawLHJoyUp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// FloatProperty: aRawLHJoyRight
    /// </summary>
    public unsafe float aRawLHJoyRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// FloatProperty: aRawRHJoyUp
    /// </summary>
    public unsafe float aRawRHJoyUp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// FloatProperty: aRawRHJoyRight
    /// </summary>
    public unsafe float aRawRHJoyRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// FloatProperty: aRightTrigger
    /// </summary>
    public unsafe float aRightTrigger
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// FloatProperty: aLeftTrigger
    /// </summary>
    public unsafe float aLeftTrigger
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// FloatProperty: aRightAnalogTriggerRaw
    /// </summary>
    public unsafe float aRightAnalogTriggerRaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// FloatProperty: aLeftAnalogTriggerRaw
    /// </summary>
    public unsafe float aLeftAnalogTriggerRaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// FloatProperty: RawRightTrigger
    /// </summary>
    public unsafe float RawRightTrigger
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// FloatProperty: RawLeftTrigger
    /// </summary>
    public unsafe float RawLeftTrigger
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// FloatProperty: aGlanceUp
    /// </summary>
    public unsafe float aGlanceUp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// FloatProperty: aGlanceRight
    /// </summary>
    public unsafe float aGlanceRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// FloatProperty: GlanceUpScale
    /// </summary>
    public unsafe float GlanceUpScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// FloatProperty: GlanceRightScale
    /// </summary>
    public unsafe float GlanceRightScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// ByteProperty: aLeftShoulder
    /// </summary>
    public unsafe byte aLeftShoulder
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// ByteProperty: aRightShoulder
    /// </summary>
    public unsafe byte aRightShoulder
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 761); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 761); }
    }

    /// <summary>
    /// ByteProperty: aTakedownButton
    /// </summary>
    public unsafe byte aTakedownButton
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 762); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 762); }
    }

    /// <summary>
    /// ByteProperty: aQuickStrike
    /// </summary>
    public unsafe byte aQuickStrike
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 763); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 763); }
    }

    /// <summary>
    /// ByteProperty: aHeavyStrike
    /// </summary>
    public unsafe byte aHeavyStrike
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// ByteProperty: aChargeStrike
    /// </summary>
    public unsafe byte aChargeStrike
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 765); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 765); }
    }

    /// <summary>
    /// ByteProperty: aGrappleButton
    /// </summary>
    public unsafe byte aGrappleButton
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 766); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 766); }
    }

    /// <summary>
    /// ByteProperty: bRawDpadUp
    /// </summary>
    public unsafe byte bRawDpadUp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 767); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 767); }
    }

    /// <summary>
    /// ByteProperty: bRawDpadDown
    /// </summary>
    public unsafe byte bRawDpadDown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// ByteProperty: bRawDpadLeft
    /// </summary>
    public unsafe byte bRawDpadLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 769); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 769); }
    }

    /// <summary>
    /// ByteProperty: bRawDpadRight
    /// </summary>
    public unsafe byte bRawDpadRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 770); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 770); }
    }

    /// <summary>
    /// ByteProperty: bRunButton
    /// </summary>
    public unsafe byte bRunButton
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 771); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 771); }
    }

    /// <summary>
    /// ByteProperty: bCrouchButton
    /// </summary>
    public unsafe byte bCrouchButton
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ByteProperty: bReadyGadgetButton
    /// </summary>
    public unsafe byte bReadyGadgetButton
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 773); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 773); }
    }

    /// <summary>
    /// ByteProperty: bCancelButton
    /// </summary>
    public unsafe byte bCancelButton
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 774); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 774); }
    }

    /// <summary>
    /// ByteProperty: bForensicsButton
    /// </summary>
    public unsafe byte bForensicsButton
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 775); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 775); }
    }

    /// <summary>
    /// ByteProperty: bHandBrakeButton
    /// </summary>
    public unsafe byte bHandBrakeButton
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }

    /// <summary>
    /// ByteProperty: bArmouredMode
    /// </summary>
    public unsafe byte bArmouredMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 777); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 777); }
    }

    /// <summary>
    /// ByteProperty: bFireVehicleWeapon
    /// </summary>
    public unsafe byte bFireVehicleWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 778); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 778); }
    }

    /// <summary>
    /// ByteProperty: bFireVehicleSecondaryWeapon
    /// </summary>
    public unsafe byte bFireVehicleSecondaryWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 779); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 779); }
    }

    /// <summary>
    /// ByteProperty: bThrottleButton
    /// </summary>
    public unsafe byte bThrottleButton
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// ByteProperty: bVehicleBoostButton
    /// </summary>
    public unsafe byte bVehicleBoostButton
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 781); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 781); }
    }

    /// <summary>
    /// ByteProperty: bBrakeButton
    /// </summary>
    public unsafe byte bBrakeButton
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 782); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 782); }
    }

    /// <summary>
    /// ByteProperty: bHandbrakeOrBrake
    /// </summary>
    public unsafe byte bHandbrakeOrBrake
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 783); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 783); }
    }

    /// <summary>
    /// ByteProperty: bGadgetSelectWheel
    /// </summary>
    public unsafe byte bGadgetSelectWheel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// ByteProperty: bLookBehindVehicle
    /// </summary>
    public unsafe byte bLookBehindVehicle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 785); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 785); }
    }

    /// <summary>
    /// ByteProperty: bBatmobileEjectModifier
    /// </summary>
    public unsafe byte bBatmobileEjectModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 786); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 786); }
    }

    /// <summary>
    /// ByteProperty: bLeftStickDown
    /// </summary>
    public unsafe byte bLeftStickDown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 787); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 787); }
    }

    /// <summary>
    /// FloatProperty: RawLeftY
    /// </summary>
    public unsafe float RawLeftY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// FloatProperty: RawLeftX
    /// </summary>
    public unsafe float RawLeftX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// FloatProperty: RawRightY
    /// </summary>
    public unsafe float RawRightY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// FloatProperty: RawRightX
    /// </summary>
    public unsafe float RawRightX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }

    /// <summary>
    /// FloatProperty: MouseX
    /// </summary>
    public unsafe float MouseX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// FloatProperty: MouseY
    /// </summary>
    public unsafe float MouseY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// FloatProperty: aAccelX
    /// </summary>
    public unsafe float aAccelX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// FloatProperty: aAccelY
    /// </summary>
    public unsafe float aAccelY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// FloatProperty: aAccelZ
    /// </summary>
    public unsafe float aAccelZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// FloatProperty: aGyro
    /// </summary>
    public unsafe float aGyro
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// FloatProperty: AccelX
    /// </summary>
    public unsafe float AccelX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// FloatProperty: AccelY
    /// </summary>
    public unsafe float AccelY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }

    /// <summary>
    /// FloatProperty: AccelZ
    /// </summary>
    public unsafe float AccelZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// FloatProperty: aThrottleAxis
    /// </summary>
    public unsafe float aThrottleAxis
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// FloatProperty: aBrakeAxis
    /// </summary>
    public unsafe float aBrakeAxis
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// FloatProperty: LeftTriggerValue
    /// </summary>
    public unsafe float LeftTriggerValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// FloatProperty: RightTriggerValue
    /// </summary>
    public unsafe float RightTriggerValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// StructProperty: ControllerSpin
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerInput.FControllerSpinContainer ControllerSpin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerInput.FControllerSpinContainer>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }
}
