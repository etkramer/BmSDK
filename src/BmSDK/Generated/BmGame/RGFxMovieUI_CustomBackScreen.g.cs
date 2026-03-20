#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieUI_CustomBackScreen<br/>
/// (flags = 0)
/// </summary>
public partial class RGFxMovieUI_CustomBackScreen : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieUI_CustomBackScreen", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieUI_CustomBackScreen() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_CustomBackScreen
    /// </summary>
    public RGFxMovieUI_CustomBackScreen(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_CustomBackScreen Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_CustomBackScreen(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: GFXFact
    /// </summary>
    public unsafe BmSDK.FString GFXFact
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// StructProperty: MenuIndex
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieUI.FMenuState MenuIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieUI.FMenuState>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// StrProperty: MenuPath
    /// </summary>
    public unsafe BmSDK.FString MenuPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// StrProperty: EventNameOnOut
    /// </summary>
    public unsafe BmSDK.FString EventNameOnOut
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bIsOptionsDefaults
    /// </summary>
    public unsafe bool bIsOptionsDefaults
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 764); }
    }

    /// <summary>
    /// BoolProperty: bIdByIndexNotName
    /// </summary>
    public unsafe bool bIdByIndexNotName
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 764); }
    }

    /// <summary>
    /// BoolProperty: bInputBlocked
    /// </summary>
    public unsafe bool bInputBlocked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 764); }
    }

    /// <summary>
    /// BoolProperty: bNoMenuSave
    /// </summary>
    public unsafe bool bNoMenuSave
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 764); }
    }

    /// <summary>
    /// BoolProperty: bInTransition
    /// </summary>
    public unsafe bool bInTransition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 764); }
    }

    /// <summary>
    /// BoolProperty: bClosing
    /// </summary>
    public unsafe bool bClosing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 764); }
    }

    /// <summary>
    /// BoolProperty: bShouldDoApplyCheck
    /// </summary>
    public unsafe bool bShouldDoApplyCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 764); }
    }

    /// <summary>
    /// BoolProperty: bDoingApply
    /// </summary>
    public unsafe bool bDoingApply
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 764); }
    }

    /// <summary>
    /// BoolProperty: bShouldCancelChanges
    /// </summary>
    public unsafe bool bShouldCancelChanges
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 764); }
    }

    /// <summary>
    /// BoolProperty: bSkipped1stFocusSFX
    /// </summary>
    public unsafe bool bSkipped1stFocusSFX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 764); }
    }

    /// <summary>
    /// BoolProperty: bShowApplyPrompt
    /// </summary>
    public unsafe bool bShowApplyPrompt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 764); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 764); }
    }

    /// <summary>
    /// ByteProperty: LastSetPrompt
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieUI.UIPromptType LastSetPrompt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieUI.UIPromptType>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// ArrayProperty: TextFieldFuncs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> TextFieldFuncs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ArrayProperty: TextFieldFuncPaths
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> TextFieldFuncPaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// StrProperty: IconSetPackage
    /// </summary>
    public unsafe BmSDK.FString IconSetPackage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// StrProperty: NameBaseRef
    /// </summary>
    public unsafe BmSDK.FString NameBaseRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// IntProperty: SavedButtonId
    /// </summary>
    public unsafe int SavedButtonId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// IntProperty: rowCounter
    /// </summary>
    public unsafe int rowCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// IntProperty: rowsUsed
    /// </summary>
    public unsafe int rowsUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// IntProperty: ButtonsX
    /// </summary>
    public unsafe int ButtonsX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// IntProperty: ButtonsY
    /// </summary>
    public unsafe int ButtonsY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// ArrayProperty: ButtonIds
    /// </summary>
    public unsafe BmSDK.TArray<int> ButtonIds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// ArrayProperty: ButtonStates
    /// </summary>
    public unsafe BmSDK.TArray<int> ButtonStates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// ArrayProperty: ButtonIconNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ButtonIconNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }

    /// <summary>
    /// ArrayProperty: ButtonIconPkgNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ButtonIconPkgNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }

    /// <summary>
    /// ArrayProperty: ButtonStringRefs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ButtonStringRefs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }

    /// <summary>
    /// StrProperty: MovieName
    /// </summary>
    public unsafe BmSDK.FString MovieName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// StrProperty: OnBackCmd
    /// </summary>
    public unsafe BmSDK.FString OnBackCmd
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// ObjectProperty: ApplyChangesOnExitPopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester ApplyChangesOnExitPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// ObjectProperty: ControllerImageRef
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie ControllerImageRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// MapProperty: VoicePromptMap
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ VoicePromptMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// ArrayProperty: SwfRefs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GFxUI.SwfMovie> SwfRefs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GFxUI.SwfMovie>>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }

}
