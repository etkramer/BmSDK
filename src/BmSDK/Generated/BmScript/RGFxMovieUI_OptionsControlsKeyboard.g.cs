#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RGFxMovieUI_OptionsControlsKeyboard<br/>
/// (size = 1204)
/// (flags = 0)
/// </summary>
public partial class RGFxMovieUI_OptionsControlsKeyboard : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RGFxMovieUI_OptionsControlsKeyboard", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieUI_OptionsControlsKeyboard() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_OptionsControlsKeyboard
    /// </summary>
    public RGFxMovieUI_OptionsControlsKeyboard(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_OptionsControlsKeyboard Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_OptionsControlsKeyboard(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: XI_GetIsLeftCtrlPressed
    /// </summary>
    public unsafe void XI_GetIsLeftCtrlPressed(BmSDK.FString sPath)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.XI_GetIsLeftCtrlPressed", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_GetIsLeftShiftPressed
    /// </summary>
    public unsafe void XI_GetIsLeftShiftPressed(BmSDK.FString sPath)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.XI_GetIsLeftShiftPressed", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CloseScreen
    /// </summary>
    public unsafe void CloseScreen()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.CloseScreen", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetCurrentPage
    /// </summary>
    public unsafe void SetCurrentPage(int nPage)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.SetCurrentPage", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nPage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AppendPage
    /// </summary>
    public unsafe void AppendPage(BmSDK.FString InName, BmSDK.FString InDevice, BmSDK.FString InScheme)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.AppendPage", true);
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
    public unsafe void XI_RequestPages(BmSDK.FString sPath)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.XI_RequestPages", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_SetBindByAbility
    /// </summary>
    public unsafe void XI_SetBindByAbility(int InAbilityId, BmSDK.FString InKeyUnlocalized, bool bIsPrimary, int InTypeId)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.XI_SetBindByAbility", true);
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
    public unsafe void XI_RequestControlData(BmSDK.FString BatmanAbilityNamesPath, BmSDK.FString BatmanKey1Path, BmSDK.FString BatmanKey2Path, BmSDK.FString PursuitAbilityNamesPath, BmSDK.FString PursuitKeys1Path, BmSDK.FString PursuitKeys2Path, BmSDK.FString BattleAbilityNamesPath, BmSDK.FString BattleKeys1Path, BmSDK.FString BattleKeys2Path)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.XI_RequestControlData", true);
        byte* paramsPtr = stackalloc byte[308];
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
    /// Function: XI_ThrowKeyBindPopup
    /// </summary>
    public unsafe void XI_ThrowKeyBindPopup(BmSDK.FString InPath, int InTypeId, int InIndex, bool InbIsPrimaryKeyBind)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.XI_ThrowKeyBindPopup", true);
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
    public unsafe BmSDK.FString GetDefaultKey(int InTypeId, int InIndex, BmSDK.BmScript.RGFxMovieUI_OptionsControlsKeyboard.KeyMap InKeyMap, bool GetUnlocalized = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.GetDefaultKey", true);
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
    public unsafe BmSDK.FString GetCurrentKey(int InTypeId, int InIndex, BmSDK.BmScript.RGFxMovieUI_OptionsControlsKeyboard.KeyMap InKeyMap)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.GetCurrentKey", true);
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
    public unsafe BmSDK.FString GetKey(BmSDK.BmScript.RGFxMovieUI_OptionsControlsKeyboard.KeyBindSourceId InSource, int InTypeId, int InIndex, BmSDK.BmScript.RGFxMovieUI_OptionsControlsKeyboard.KeyMap InKeyMap, bool GetUnlocalizedDefault = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.GetKey", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSource, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InTypeId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InIndex, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InKeyMap, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GetUnlocalizedDefault, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: XI_ThrowAreYouSurePopup
    /// </summary>
    public unsafe void XI_ThrowAreYouSurePopup(BmSDK.FString InPath)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.XI_ThrowAreYouSurePopup", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_ButtonPCThrowAreYouSurePopup
    /// </summary>
    public unsafe void XI_ButtonPCThrowAreYouSurePopup(BmSDK.FString InPath)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.XI_ButtonPCThrowAreYouSurePopup", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetKeyButtonBind
    /// </summary>
    public unsafe void SetKeyButtonBind(BmSDK.FString InKey)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.SetKeyButtonBind", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InKey, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PopupRequester_Callback
    /// </summary>
    public unsafe void PopupRequester_Callback(BmSDK.BmGame.RGFxMoviePopupRequester ThePopUpMsg, int ButtonId)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.PopupRequester_Callback", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThePopUpMsg, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ButtonId, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: KeyBindPopUpResetToDefaultPressed
    /// </summary>
    public unsafe void KeyBindPopUpResetToDefaultPressed(BmSDK.FString InDefaultKey)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.KeyBindPopUpResetToDefaultPressed", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InDefaultKey, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_OnBack
    /// </summary>
    public unsafe void XI_OnBack()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.XI_OnBack", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_OnYPressed
    /// </summary>
    public unsafe void XI_OnYPressed(BmSDK.FString Path)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.XI_OnYPressed", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Path, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ResetAllKeybindsToDefault
    /// </summary>
    public unsafe void ResetAllKeybindsToDefault()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.ResetAllKeybindsToDefault", true);
        byte* paramsPtr = stackalloc byte[140];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe void Init(BmSDK.Engine.LocalPlayer LocPlay = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieUI_OptionsControlsKeyboard.Init", true);
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
        KeyboardBindTypeId_MAX = 3,
    }

    /// <summary>
    /// StrProperty: CachedFunction_AddPage
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_AddPage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetCurrentPage
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetCurrentPage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// StrProperty: FunctionPath
    /// </summary>
    public unsafe BmSDK.FString FunctionPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// ObjectProperty: ApplyKeybindingsPopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester ApplyKeybindingsPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// ObjectProperty: KeyButtonRemoveDuplicateKeybindPopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester KeyButtonRemoveDuplicateKeybindPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }

    /// <summary>
    /// ObjectProperty: ButtonPCRemoveDuplicateKeybindPopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester ButtonPCRemoveDuplicateKeybindPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// ObjectProperty: SetKeybindPopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester SetKeybindPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// ObjectProperty: ResetAllToDefaultPopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester ResetAllToDefaultPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// IntProperty: NoOption
    /// </summary>
    public unsafe int NoOption
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }

    /// <summary>
    /// IntProperty: CancelOption
    /// </summary>
    public unsafe int CancelOption
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1164); }
    }

    /// <summary>
    /// StrProperty: DefaultKeyBind
    /// </summary>
    public unsafe BmSDK.FString DefaultKeyBind
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// BoolProperty: bHasModifier
    /// </summary>
    public unsafe bool bHasModifier
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1184) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1184); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1184); }
    }

    /// <summary>
    /// StrProperty: SelectedKeyBind
    /// </summary>
    public unsafe BmSDK.FString SelectedKeyBind
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }
}
