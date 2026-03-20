#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGameViewportClient<br/>
/// (flags = 0)
/// </summary>
public partial class RGameViewportClient : BmSDK.Engine.GameViewportClient, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGameViewportClient", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGameViewportClient() { }

    /// <summary>
    /// Constructs a new RGameViewportClient
    /// </summary>
    public RGameViewportClient(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGameViewportClient Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGameViewportClient(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: VfTable_FExec
    /// </summary>
    public unsafe System.IntPtr VfTable_FExec
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// StructProperty: Viewport
    /// </summary>
    public unsafe System.IntPtr Viewport
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// StructProperty: ViewportFrame
    /// </summary>
    public unsafe System.IntPtr ViewportFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ArrayProperty: GlobalInteractions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Interaction> GlobalInteractions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Interaction>>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// ClassProperty: UIControllerClass
    /// </summary>
    public unsafe BmSDK.Class UIControllerClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ObjectProperty: UIController
    /// </summary>
    public unsafe BmSDK.Engine.UIInteraction UIController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.UIInteraction>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ObjectProperty: ViewportConsole
    /// </summary>
    public unsafe BmSDK.Engine._Console ViewportConsole
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine._Console>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ObjectProperty: CanvasObject
    /// </summary>
    public unsafe BmSDK.Engine.Canvas CanvasObject
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Canvas>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// StructProperty: ShowFlags
    /// </summary>
    public unsafe BmSDK.Engine.GameViewportClient.FExportShowFlags_Mirror ShowFlags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameViewportClient.FExportShowFlags_Mirror>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// StructProperty: RockShowFlags
    /// </summary>
    public unsafe ulong RockShowFlags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<ulong>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// ByteProperty: ShowCollisionFilter
    /// </summary>
    public unsafe byte ShowCollisionFilter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// ByteProperty: DesiredSplitscreenType
    /// </summary>
    public unsafe BmSDK.Engine.GameViewportClient.ESplitScreenType DesiredSplitscreenType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameViewportClient.ESplitScreenType>(Ptr + 189); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 189); }
    }

    /// <summary>
    /// ByteProperty: ActiveSplitscreenType
    /// </summary>
    public unsafe BmSDK.Engine.GameViewportClient.ESplitScreenType ActiveSplitscreenType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameViewportClient.ESplitScreenType>(Ptr + 190); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 190); }
    }

    /// <summary>
    /// ByteProperty: Default2PSplitType
    /// </summary>
    public unsafe BmSDK.Engine.GameViewportClient.ESplitScreenType Default2PSplitType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameViewportClient.ESplitScreenType>(Ptr + 191); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 191); }
    }

    /// <summary>
    /// ByteProperty: Default3PSplitType
    /// </summary>
    public unsafe BmSDK.Engine.GameViewportClient.ESplitScreenType Default3PSplitType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameViewportClient.ESplitScreenType>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// StrProperty: LoadingMessage
    /// </summary>
    public unsafe BmSDK.FString LoadingMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// StrProperty: SavingMessage
    /// </summary>
    public unsafe BmSDK.FString SavingMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// StrProperty: ConnectingMessage
    /// </summary>
    public unsafe BmSDK.FString ConnectingMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// StrProperty: PausedMessage
    /// </summary>
    public unsafe BmSDK.FString PausedMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// StrProperty: PrecachingMessage
    /// </summary>
    public unsafe BmSDK.FString PrecachingMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bShowTitleSafeZone
    /// </summary>
    public unsafe bool bShowTitleSafeZone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 276); }
    }

    /// <summary>
    /// BoolProperty: bDisplayHardwareMouseCursor
    /// </summary>
    public unsafe bool bDisplayHardwareMouseCursor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 276); }
    }

    /// <summary>
    /// BoolProperty: bOverrideDiffuseAndSpecular
    /// </summary>
    public unsafe bool bOverrideDiffuseAndSpecular
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 276); }
    }

    /// <summary>
    /// BoolProperty: bIsPlayInEditorViewport
    /// </summary>
    public unsafe bool bIsPlayInEditorViewport
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 276); }
    }

    /// <summary>
    /// BoolProperty: bShowSystemMouseCursor
    /// </summary>
    public unsafe bool bShowSystemMouseCursor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 276); }
    }

    /// <summary>
    /// BoolProperty: bCollisionLight
    /// </summary>
    public unsafe bool bCollisionLight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 276); }
    }

    /// <summary>
    /// BoolProperty: bDisableWorldRendering
    /// </summary>
    public unsafe bool bDisableWorldRendering
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 276); }
    }

    /// <summary>
    /// BoolProperty: bDebugNoGFxUI
    /// </summary>
    public unsafe bool bDebugNoGFxUI
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 276); }
    }

    /// <summary>
    /// StructProperty: TitleSafeZone
    /// </summary>
    public unsafe BmSDK.Engine.GameViewportClient.FTitleSafeZoneArea TitleSafeZone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameViewportClient.FTitleSafeZoneArea>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }

    /// <summary>
    /// IntProperty: ReflectionVolumeMode
    /// </summary>
    public unsafe int ReflectionVolumeMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// StructProperty: CollisionLightSavedShowFlags
    /// </summary>
    public unsafe BmSDK.Engine.GameViewportClient.FExportShowFlags_Mirror CollisionLightSavedShowFlags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameViewportClient.FExportShowFlags_Mirror>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// ArrayProperty: SplitscreenInfo
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.GameViewportClient.FSplitscreenData> SplitscreenInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.GameViewportClient.FSplitscreenData>>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// StrProperty: ProgressMessage
    /// </summary>
    public unsafe BmSDK.FString ProgressMessage_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }
    /// <summary>
    /// StrProperty: ProgressMessage
    /// </summary>
    public unsafe BmSDK.FString ProgressMessage_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// FloatProperty: ProgressTimeOut
    /// </summary>
    public unsafe float ProgressTimeOut
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// FloatProperty: ProgressFadeTime
    /// </summary>
    public unsafe float ProgressFadeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// ArrayProperty: DebugProperties
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.GameViewportClient.FDebugDisplayProperty> DebugProperties
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.GameViewportClient.FDebugDisplayProperty>>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// StructProperty: ScaleformInteraction
    /// </summary>
    public unsafe System.IntPtr ScaleformInteraction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// StructProperty: ViewFamily
    /// </summary>
    public unsafe System.IntPtr ViewFamily
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// DelegateProperty: __HandleInputKey__Delegate
    /// </summary>
    public unsafe System.IntPtr __HandleInputKey__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// DelegateProperty: __HandleInputAxis__Delegate
    /// </summary>
    public unsafe System.IntPtr __HandleInputAxis__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// DelegateProperty: __HandleInputChar__Delegate
    /// </summary>
    public unsafe System.IntPtr __HandleInputChar__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }
}
