#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHUDPrompt<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RHUDPrompt : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHUDPrompt", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RHUDPrompt() { }

    /// <summary>
    /// Constructs a new RHUDPrompt
    /// </summary>
    public RHUDPrompt(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHUDPrompt Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHUDPrompt(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: PC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController PC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ObjectProperty: FromKismet
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_HelpText FromKismet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_HelpText>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: bOverridePromptIsActive
    /// </summary>
    public unsafe bool bOverridePromptIsActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bOverridePromptShouldBeActive
    /// </summary>
    public unsafe bool bOverridePromptShouldBeActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bForcePromptUpdate
    /// </summary>
    public unsafe bool bForcePromptUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bDisplayWhetherHelpTextIsHintOrTutorial
    /// </summary>
    public unsafe bool bDisplayWhetherHelpTextIsHintOrTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// StructProperty: OverridePrompt
    /// </summary>
    public unsafe BmSDK.BmGame.RHUDPrompt.FHelpLine OverridePrompt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHUDPrompt.FHelpLine>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// StructProperty: MainLine
    /// </summary>
    public unsafe BmSDK.BmGame.RHUDPrompt.FHelpLine MainLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHUDPrompt.FHelpLine>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// StructProperty: MainLineLast
    /// </summary>
    public unsafe BmSDK.BmGame.RHUDPrompt.FHelpLine MainLineLast
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHUDPrompt.FHelpLine>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// ArrayProperty: Lines
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RHUDPrompt.FHelpLine> Lines
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RHUDPrompt.FHelpLine>>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// ArrayProperty: LinesLast
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RHUDPrompt.FHelpLine> LinesLast
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RHUDPrompt.FHelpLine>>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// StrProperty: Instructions
    /// </summary>
    public unsafe BmSDK.FString Instructions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// StrProperty: InstructionsLast
    /// </summary>
    public unsafe BmSDK.FString InstructionsLast
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// StrProperty: HighPriorityInstructions
    /// </summary>
    public unsafe BmSDK.FString HighPriorityInstructions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// Struct: FHelpLine
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FHelpLine
    {
        /// <summary>
        /// StrProperty: Line
        /// </summary>
        public unsafe BmSDK.FString Line
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: Icon
        /// </summary>
        public unsafe BmSDK.BmGame.RHUDPrompt.EControlIcon Icon
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHUDPrompt.EControlIcon>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: Alpha
        /// </summary>
        public unsafe int Alpha
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// BoolProperty: bAsSecondaryMain
        /// </summary>
        public unsafe bool bAsSecondaryMain
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Enum: EControlIcon
    /// </summary>
    public enum EControlIcon
    {
        CI_None = 0,
        CI_UI_Start = 1,
        CI_UI_Select = 2,
        CI_UI_A = 3,
        CI_UI_B = 4,
        CI_UI_X = 5,
        CI_UI_Y = 6,
        CI_UI_L1 = 7,
        CI_UI_L2 = 8,
        CI_UI_L3 = 9,
        CI_UI_R1 = 10,
        CI_UI_R2 = 11,
        CI_UI_R3 = 12,
        CI_UI_Move = 13,
        CI_UI_MoveLR = 14,
        CI_UI_MoveUD = 15,
        CI_UI_Mouse = 16,
        CI_UI_MouseLR = 17,
        CI_UI_MouseUD = 18,
        CI_UI_MouseLMB = 19,
        CI_UI_MapCenter = 20,
        CI_UI_MapZoom = 21,
        CI_Interact = 22,
        CI_VisionModes = 23,
        CI_AimGadget = 24,
        CI_UseGadget = 25,
        CI_UseGrapple = 26,
        CI_UseScanner = 27,
        CI_Map = 28,
        CI_DPad = 29,
        CI_LeftStick = 30,
        CI_LeftStickUp = 31,
        CI_LeftStickDown = 32,
        CI_LeftStickUpAndDown = 33,
        CI_LeftStickLeftAndRight = 34,
        CI_RightStick = 35,
        CI_CrouchInteract = 36,
        CI_CrouchInteractHold = 37,
        CI_LeftAndRightStick = 38,
        CI_Crouch = 39,
        CI_DPadU = 40,
        CI_DPadD = 41,
        CI_DPadL = 42,
        CI_DPadR = 43,
        CI_RightStickIn = 44,
        CI_LTorRT = 45,
        CI_LBorRB = 46,
        CI_PageLeft = 47,
        CI_PageRight = 48,
        CI_CrouchGrab = 49,
        CI_SilentTakeDown = 50,
        CI_Strike = 51,
        CI_SecondaryFire = 52,
        CI_CapeStun = 53,
        CI_Throw = 54,
        CI_CombatTakeDown = 55,
        CI_Cancel = 56,
        CI_RunGlide = 57,
        CI_SelectBatarang = 58,
        CI_SelectExplosiveGel = 59,
        CI_SelectHarpoonGun = 60,
        CI_SelectResonatorTuner = 61,
        CI_SelectLineLauncher = 62,
        CI_SelectControllableBatarang = 63,
        CI_SelectSonicBatarang = 64,
        CI_SelectSmokeBomb = 65,
        CI_SelectREC = 66,
        CI_SelectFreezeBlast = 67,
        CI_SelectFreezeCluster = 68,
        CI_SelectJammer = 69,
        CI_Camera = 70,
        CI_LeftHat = 71,
        CI_Zoom = 72,
        CI_DetonateCharge = 73,
        CI_QuickBatarang = 74,
        CI_QuickBatClaw = 75,
        CI_QuickGel = 76,
        CI_QuickFreeze = 77,
        CI_QuickMagBlast = 78,
        CI_QuickCurrentGadget = 79,
        CI_HangFromVantagePoint = 80,
        CI_Movement = 81,
        CI_Gadgets = 82,
        CI_CryptoTune = 83,
        CI_SixAxisShake1 = 84,
        CI_SixAxisShake2 = 85,
        CI_UseMagBlast = 86,
        CI_SwingAttack = 87,
        CI_KnifeCounter = 88,
        CI_BeatDown = 89,
        CI_BeatDownDarkX = 90,
        CI_AerialAttack = 91,
        CI_AerialIntoBeatdown = 92,
        CI_AerialIntoBeatdownDarkX = 93,
        CI_DirectedAerialAttack = 94,
        CI_Jump = 95,
        CI_SmokeAndEscape = 96,
        CI_SuperStun = 97,
        CI_CombatSpecialLeft = 98,
        CI_CombatSpecialTop = 99,
        CI_CombatSpecialBottom = 100,
        CI_Evade = 101,
        CI_HoldRunGlide = 102,
        CI_ToggleDetectiveMode = 103,
        CI_TriggerScan = 104,
        CI_GrappleBoost = 105,
        CI_RecUp = 106,
        CI_RecDown = 107,
        CI_SelectGadget1 = 108,
        CI_SelectGadget2 = 109,
        CI_SelectGadget3 = 110,
        CI_SelectGadget4 = 111,
        CI_SelectGadget5 = 112,
        CI_SelectGadget6 = 113,
        CI_SelectGadget7 = 114,
        CI_SelectGadget8 = 115,
        CI_SelectGadget9 = 116,
        CI_SelectGadget10 = 117,
        CI_SelectGadget11 = 118,
        CI_SelectGadget12 = 119,
        CI_ReleaseGadgetSelect = 120,
        CI_GrappleToHang = 121,
        CI_GrappleToClimb = 122,
        CI_StunStick = 123,
        CI_TitanBeatdown = 124,
        CI_LockOnSecondaryGadget = 125,
        CI_ThrowSecondaryGadget = 126,
        CI_Slide = 127,
        CI_ReadyGadgetButton = 128,
        CI_UseGadgetShort = 129,
        CI_SecondaryGadgetShort = 130,
        CI_BatclawSlam = 131,
        CI_UseGadgetHoldShort = 132,
        CI_SecondaryGadgetHoldShort = 133,
        CI_UseGadgetHold = 134,
        CI_BladeCounter = 135,
        CI_ClimbDown = 136,
        CI_SwitchCharacter = 137,
        CI_CallBatmobile = 138,
        CI_BatmobileEject = 139,
        CI_CrouchStrike = 140,
        CI_BatmobileHandbrake = 141,
        CI_BatmobileThrottle = 142,
        CI_BatmobileBrake = 143,
        CI_BatmobileBoost = 144,
        CI_BatmobileRiddlerSwitch = 145,
        CI_FloorPickup = 146,
        CI_GrappleBoostMk2 = 147,
        CI_BatmobileDodge = 148,
        CI_ThrowCounter = 149,
        CI_EnvironmentTakedown = 150,
        CI_BatmobileBattleMode = 151,
        CI_BatmobileSecondaryFire = 152,
        CI_BatmobileSonarBlast = 153,
        CI_BatmobileSonar = 154,
        CI_BatmobileEMPLv1 = 155,
        CI_BatmobileEMPLv2 = 156,
        CI_DroneHacker = 157,
        CI_TagVehicle = 158,
        CI_UnTagVehicle = 159,
        CI_DiveBomb = 160,
        CI_BatmobileSideSwipe = 161,
        CI_BatmobileMissileBarrage = 162,
        CI_BatmobileMissileBarrageLv2 = 163,
        CI_BatmobileMissileBarrageLv3 = 164,
        CI_BatmobileMissileBarrageLv4 = 165,
        CI_MoveCrane = 166,
        CI_EnterCover = 167,
        CI_LineLauncherStop = 168,
        CI_GrappleBoostMk3 = 169,
        CI_GrappleBoostMk4 = 170,
        CI_SuperComboBatarang = 171,
        CI_SuperComboBatclaw = 172,
        CI_SuperComboGel = 173,
        CI_SuperComboREC = 174,
        CI_SuperComboFreeze = 175,
        CI_BatmobileSuperEject = 176,
        CI_Arrows = 177,
        CI_LeftAndRightKeys = 178,
        CI_DiveRelease = 179,
        CI_ToggleBatmobileCamera = 180,
        CI_GadgetSelect = 181,
        CI_SpecialCombo1 = 182,
        CI_SpecialCombo2 = 183,
        CI_SpecialCombo3 = 184,
        CI_SpecialCombo4 = 185,
        CI_Left = 186,
        CI_Right = 187,
        CI_ZipLine = 188,
        CI_DoubleDodge = 189,
        CI_BatmobileFire = 190,
        CI_GlideSteer = 191,
        CI_NavigateLeaderboard = 192,
        CI_FlipBatmobile = 193,
        CI_ContinuePromptBatmobile = 194,
        CI_BatmobileInteract = 195,
        CI_PhotoModeLook = 196,
        CI_PhotoModeUpDown = 197,
        CI_QuickPhotoMode = 198,
        CI_ToggleForensicsScan = 199,
        CI_MAX = 200,
    }

    /// <summary>
    /// Enum: JustifyText
    /// </summary>
    public enum JustifyText
    {
        JT_Left = 0,
        JT_Center = 1,
        JT_Right = 2,
        JT_Align = 3,
        JT_MAX = 4,
    }
}
