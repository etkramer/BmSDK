#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieResonatorMinigame<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RGFxMovieResonatorMinigame : BmSDK.BmGame.RGFxMovie, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieResonatorMinigame", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieResonatorMinigame() { }

    /// <summary>
    /// Constructs a new RGFxMovieResonatorMinigame
    /// </summary>
    public RGFxMovieResonatorMinigame(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieResonatorMinigame Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieResonatorMinigame(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: RadioCanScan
    /// </summary>
    public unsafe bool RadioCanScan
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: RadioCanMove
    /// </summary>
    public unsafe bool RadioCanMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: RadioCanFlick
    /// </summary>
    public unsafe bool RadioCanFlick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: CanExit
    /// </summary>
    public unsafe bool CanExit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: CanCyclePasswords
    /// </summary>
    public unsafe bool CanCyclePasswords
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: bIsHighSecurity
    /// </summary>
    public unsafe bool bIsHighSecurity
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: bJammingImminent
    /// </summary>
    public unsafe bool bJammingImminent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: bAlreadyJammed
    /// </summary>
    public unsafe bool bAlreadyJammed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: bIsInPasswordMode
    /// </summary>
    public unsafe bool bIsInPasswordMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: RumbleEnabled
    /// </summary>
    public unsafe bool RumbleEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: bAnyMandatoryStations
    /// </summary>
    public unsafe bool bAnyMandatoryStations
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// StrProperty: GadgetHelpText
    /// </summary>
    public unsafe BmSDK.FString GadgetHelpText
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// ByteProperty: GadgetHelpIcon
    /// </summary>
    public unsafe byte GadgetHelpIcon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// StrProperty: ResonatorInstructions
    /// </summary>
    public unsafe BmSDK.FString ResonatorInstructions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// StrProperty: ResonatorMoviePath
    /// </summary>
    public unsafe BmSDK.FString ResonatorMoviePath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// ArrayProperty: PasswordArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> PasswordArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// FloatProperty: FlashRumbleValueLeft
    /// </summary>
    public unsafe float FlashRumbleValueLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// FloatProperty: FlashRumbleValueRight
    /// </summary>
    public unsafe float FlashRumbleValueRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// IntProperty: SecurityLevel
    /// </summary>
    public unsafe int SecurityLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }

    /// <summary>
    /// StrProperty: HackingNetworkString
    /// </summary>
    public unsafe BmSDK.FString HackingNetworkString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// StrProperty: HackingTargetString
    /// </summary>
    public unsafe BmSDK.FString HackingTargetString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// FloatProperty: fCachedMouseX
    /// </summary>
    public unsafe float fCachedMouseX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// FloatProperty: fCachedMouseY
    /// </summary>
    public unsafe float fCachedMouseY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// IntProperty: PasswordDifficultyLevel
    /// </summary>
    public unsafe int PasswordDifficultyLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// ArrayProperty: ControllerStatusArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>> ControllerStatusArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }
}
