#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieUI_PauseOptionsControlsKeyboard<br/>
/// (size = 1760)
/// (flags = 22)
/// </summary>
public partial class RGFxMovieUI_PauseOptionsControlsKeyboard : BmSDK.BmGame.RGFxMovieUI_PauseBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieUI_PauseOptionsControlsKeyboard() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_PauseOptionsControlsKeyboard
    /// </summary>
    public RGFxMovieUI_PauseOptionsControlsKeyboard(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_PauseOptionsControlsKeyboard Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_PauseOptionsControlsKeyboard(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: XI_GetIsLeftCtrlPressed
    /// </summary>
    public unsafe virtual void XI_GetIsLeftCtrlPressed(BmSDK.FString sPath)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.XI_GetIsLeftCtrlPressed", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_GetIsLeftShiftPressed
    /// </summary>
    public unsafe virtual void XI_GetIsLeftShiftPressed(BmSDK.FString sPath)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.XI_GetIsLeftShiftPressed", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CloseScreen
    /// </summary>
    public unsafe override void CloseScreen()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.CloseScreen", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetCurrentPage
    /// </summary>
    public unsafe virtual void SetCurrentPage(int nPage)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.SetCurrentPage", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nPage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AppendPage
    /// </summary>
    public unsafe virtual void AppendPage(BmSDK.FString InName, BmSDK.FString InDevice, BmSDK.FString InScheme)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.AppendPage", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InDevice, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InScheme, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_RequestPages
    /// </summary>
    public unsafe virtual void XI_RequestPages(BmSDK.FString sPath)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.XI_RequestPages", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_SetBindByAbility
    /// </summary>
    public unsafe virtual void XI_SetBindByAbility(int InAbilityId, BmSDK.FString InKeyUnlocalized, bool bIsPrimary, int InTypeId)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.XI_SetBindByAbility", true);
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InAbilityId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InKeyUnlocalized, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsPrimary, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InTypeId, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_RequestControlData
    /// </summary>
    public unsafe virtual void XI_RequestControlData(BmSDK.FString BatmanAbilityNamesPath, BmSDK.FString BatmanKey1Path, BmSDK.FString BatmanKey2Path, BmSDK.FString PursuitAbilityNamesPath, BmSDK.FString PursuitKeys1Path, BmSDK.FString PursuitKeys2Path, BmSDK.FString BattleAbilityNamesPath, BmSDK.FString BattleKeys1Path, BmSDK.FString BattleKeys2Path)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.XI_RequestControlData", true);
        byte* paramsPtr = stackalloc byte[389];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatmanAbilityNamesPath, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatmanKey1Path, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatmanKey2Path, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PursuitAbilityNamesPath, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PursuitKeys1Path, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PursuitKeys2Path, paramsPtr + 80);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BattleAbilityNamesPath, paramsPtr + 96);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BattleKeys1Path, paramsPtr + 112);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BattleKeys2Path, paramsPtr + 128);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_OnOut
    /// </summary>
    public unsafe override void XI_OnOut()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.XI_OnOut", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_ThrowKeyBindPopup
    /// </summary>
    public unsafe virtual void XI_ThrowKeyBindPopup(BmSDK.FString InPath, int InTypeId, int InIndex, bool InbIsPrimaryKeyBind)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.XI_ThrowKeyBindPopup", true);
        byte* paramsPtr = stackalloc byte[45];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPath, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InTypeId, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InIndex, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InbIsPrimaryKeyBind, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetDefaultKey
    /// </summary>
    public unsafe virtual BmSDK.FString GetDefaultKey(int InTypeId, int InIndex, BmSDK.BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.KeyMap InKeyMap, bool GetUnlocalized = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.GetDefaultKey", true);
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InTypeId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InKeyMap, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GetUnlocalized, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: GetCurrentKey
    /// </summary>
    public unsafe virtual BmSDK.FString GetCurrentKey(int InTypeId, int InIndex, BmSDK.BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.KeyMap InKeyMap)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.GetCurrentKey", true);
        byte* paramsPtr = stackalloc byte[88];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InTypeId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InKeyMap, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: GetKey
    /// </summary>
    public unsafe virtual BmSDK.FString GetKey(BmSDK.BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.KeyBindSourceId InSource, int InTypeId, int InIndex, BmSDK.BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.KeyMap InKeyBind, bool GetUnlocalizedDefault = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.GetKey", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSource, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InTypeId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InIndex, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InKeyBind, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GetUnlocalizedDefault, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: XI_ThrowAreYouSurePopup
    /// </summary>
    public unsafe virtual void XI_ThrowAreYouSurePopup(BmSDK.FString InPath)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.XI_ThrowAreYouSurePopup", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_ButtonPCThrowAreYouSurePopup
    /// </summary>
    public unsafe virtual void XI_ButtonPCThrowAreYouSurePopup(BmSDK.FString InPath)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.XI_ButtonPCThrowAreYouSurePopup", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetKeyButtonBind
    /// </summary>
    public unsafe virtual void SetKeyButtonBind(BmSDK.FString InKey)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.SetKeyButtonBind", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InKey, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PopupRequester_Callback
    /// </summary>
    public unsafe override void PopupRequester_Callback(BmSDK.BmGame.RGFxMoviePopupRequester ThePopUpMsg, int ButtonId)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.PopupRequester_Callback", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThePopUpMsg, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonId, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: KeyBindPopUpResetToDefaultPressed
    /// </summary>
    public unsafe virtual void KeyBindPopUpResetToDefaultPressed(BmSDK.FString InDefaultKey)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.KeyBindPopUpResetToDefaultPressed", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InDefaultKey, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_OnBack
    /// </summary>
    public unsafe override void XI_OnBack()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.XI_OnBack", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_OnYPressed
    /// </summary>
    public unsafe virtual void XI_OnYPressed(BmSDK.FString Path)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.XI_OnYPressed", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Path, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ResetAllKeybindsToDefault
    /// </summary>
    public unsafe virtual void ResetAllKeybindsToDefault()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.ResetAllKeybindsToDefault", true);
        byte* paramsPtr = stackalloc byte[172];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override void Init(BmSDK.Engine.LocalPlayer LocPlay = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieUI_PauseOptionsControlsKeyboard.Init", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: KeyMap
    /// </summary>
    public enum KeyMap
    {
        KeyMap_Primary = 0,
        KeyMap_Secondary = 1,
        KeyMap_MAX = 2,
    }

    /// <summary>
    /// Enum: KeyBindSourceId
    /// </summary>
    public enum KeyBindSourceId
    {
        KeyBindSourceId_Default = 0,
        KeyBindSourceId_Current = 1,
        KeyBindSourceId_MAX = 2,
    }

    /// <summary>
    /// Enum: KeyboardBindTypeId
    /// </summary>
    public enum KeyboardBindTypeId
    {
        KeyboardBindTypeId_Batman = 0,
        KeyboardBindTypeId_Pursuit = 1,
        KeyboardBindTypeId_Battle = 2,
        KeyboardBindTypeId_DLC_Harley = 3,
        KeyboardBindTypeId_DLC_RedHood = 4,
        KeyboardBindTypeId_DLC_Batgirl = 5,
        KeyboardBindTypeId_MAX = 6,
    }

    /// <summary>
    /// StrProperty: CachedFunction_AddPage
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_AddPage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1612); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetCurrentPage
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetCurrentPage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1628); }
    }

    /// <summary>
    /// StructProperty: ControlsScreen
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieUI_PauseBase.FScreenDef ControlsScreen
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieUI_PauseBase.FScreenDef>(Ptr + 1644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1644); }
    }

    /// <summary>
    /// StrProperty: FunctionPath
    /// </summary>
    public unsafe BmSDK.FString FunctionPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1660); }
    }

    /// <summary>
    /// ObjectProperty: ApplyKeybindingsPopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester ApplyKeybindingsPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 1676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1676); }
    }

    /// <summary>
    /// ObjectProperty: KeyButtonRemoveDuplicateKeybindPopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester KeyButtonRemoveDuplicateKeybindPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 1684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1684); }
    }

    /// <summary>
    /// ObjectProperty: ButtonPCRemoveDuplicateKeybindPopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester ButtonPCRemoveDuplicateKeybindPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 1692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1692); }
    }

    /// <summary>
    /// ObjectProperty: SetKeybindPopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester SetKeybindPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 1700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1700); }
    }

    /// <summary>
    /// ObjectProperty: ResetAllToDefaultPopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester ResetAllToDefaultPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 1708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1708); }
    }

    /// <summary>
    /// IntProperty: NoOption
    /// </summary>
    public unsafe int NoOption
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1716); }
    }

    /// <summary>
    /// IntProperty: CancelOption
    /// </summary>
    public unsafe int CancelOption
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1720); }
    }

    /// <summary>
    /// StrProperty: DefaultKeyBind
    /// </summary>
    public unsafe BmSDK.FString DefaultKeyBind
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1724); }
    }

    /// <summary>
    /// BoolProperty: bHasModifier
    /// </summary>
    public unsafe bool bHasModifier
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1740) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1740); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1740); }
    }

    /// <summary>
    /// StrProperty: SelectedKeyBind
    /// </summary>
    public unsafe BmSDK.FString SelectedKeyBind
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1744); }
    }
}
