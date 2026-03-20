#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGauntletProjector<br/>
/// (size = 432)
/// (flags = 0)
/// </summary>
public partial class RGauntletProjector : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGauntletProjector", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGauntletProjector() { }

    /// <summary>
    /// Constructs a new RGauntletProjector
    /// </summary>
    public RGauntletProjector(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGauntletProjector Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGauntletProjector(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: PlayerTick
    /// </summary>
    public unsafe void PlayerTick(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGauntletProjector.PlayerTick", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FlashMovieFinished
    /// </summary>
    public unsafe void FlashMovieFinished(BmSDK.FString VideoResource)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGauntletProjector.FlashMovieFinished", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VideoResource, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ActuallyTurnOffProjector
    /// </summary>
    public unsafe void ActuallyTurnOffProjector()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGauntletProjector.ActuallyTurnOffProjector", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StopProjection
    /// </summary>
    public unsafe void StopProjection(BmSDK.BmGame.RSeqAct_PlayRadioOrThoughtDialogue caller = default, BmSDK.FString VideoResource = default, float fTransitionOutDurationOverride = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGauntletProjector.StopProjection", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(caller, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VideoResource, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fTransitionOutDurationOverride, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetOpaque
    /// </summary>
    public unsafe void SetOpaque(bool is_opaque)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGauntletProjector.SetOpaque", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_opaque, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: _InitializeHologram
    /// </summary>
    public unsafe void _InitializeHologram(BmSDK.BmGame.RGFxMovie iMovie, BmSDK.Engine.SkeletalMeshComponent iAttachToSkeleton = default, BmSDK.FName sAttachToBone = default, BmSDK.FName sAttachToSocket = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGauntletProjector._InitializeHologram", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iMovie, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iAttachToSkeleton, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sAttachToBone, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sAttachToSocket, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartHackingProjection
    /// </summary>
    public unsafe void StartHackingProjection(BmSDK.Engine.SkeletalMeshComponent iAttachToSkeleton = default, BmSDK.FName sAttachToBone = default, BmSDK.FName sAttachToSocket = default, bool bBrainHacking = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGauntletProjector.StartHackingProjection", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iAttachToSkeleton, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sAttachToBone, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sAttachToSocket, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBrainHacking, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetGauntletConnectionLost
    /// </summary>
    public unsafe void SetGauntletConnectionLost()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGauntletProjector.SetGauntletConnectionLost", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetVideoPortrait
    /// </summary>
    public unsafe void SetVideoPortrait(BmSDK.FString PortraitName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGauntletProjector.SetVideoPortrait", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PortraitName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartVideoProjection
    /// </summary>
    public unsafe void StartVideoProjection(BmSDK.FString sVideoResource, BmSDK.FString sHeaderText, bool bForceOpaque = default, bool bWithOverlay = default, bool bConnectionFailedOn = default, bool bSkipIntro = default, BmSDK.Engine.SkeletalMeshComponent meshToAttachTo = default, bool bNoMovie = default, bool bAutoPause = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGauntletProjector.StartVideoProjection", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sVideoResource, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sHeaderText, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceOpaque, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWithOverlay, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bConnectionFailedOn, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSkipIntro, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(meshToAttachTo, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNoMovie, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAutoPause, paramsPtr + 60);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: QueueVideoProjection
    /// </summary>
    public unsafe void QueueVideoProjection(BmSDK.FString sVideoResource, BmSDK.FString sHeaderText, bool bForceOpaque = default, bool bWithOverlay = default, bool bConnectionFailedOn = default, bool bSkipIntro = default, BmSDK.FString PortraitName = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGauntletProjector.QueueVideoProjection", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sVideoResource, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sHeaderText, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceOpaque, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWithOverlay, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bConnectionFailedOn, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSkipIntro, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PortraitName, paramsPtr + 48);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Initialise
    /// </summary>
    public unsafe void Initialise(BmSDK.BmGame.RPlayerController _RPC)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGauntletProjector.Initialise", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_RPC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: transitionState
    /// </summary>
    public enum transitionState
    {
        eTransIn = 0,
        eTransNone = 1,
        eTransOut = 2,
        transitionState_MAX = 3,
    }

    /// <summary>
    /// ObjectProperty: VideoPlayer
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieVideoPlayer VideoPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieVideoPlayer>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ObjectProperty: VideoOverlay
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieVideoOverlay VideoOverlay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieVideoOverlay>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ObjectProperty: HackingDevice
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieOmnitronBase HackingDevice
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieOmnitronBase>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ObjectProperty: PrimaryRenderTarget
    /// </summary>
    public unsafe BmSDK.Engine.TextureRenderTarget2D PrimaryRenderTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.TextureRenderTarget2D>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ObjectProperty: SecondaryRenderTarget
    /// </summary>
    public unsafe BmSDK.Engine.TextureRenderTarget2D SecondaryRenderTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.TextureRenderTarget2D>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// ObjectProperty: HologramMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant HologramMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ObjectProperty: HologramMovieMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant HologramMovieMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ObjectProperty: RHDInstancedMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant RHDInstancedMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ObjectProperty: RHDOriginalMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant RHDOriginalMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ObjectProperty: GauntletConvLightingRigArchetype
    /// </summary>
    public unsafe BmSDK.BmGame.RLightingRigActor GauntletConvLightingRigArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLightingRigActor>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// ObjectProperty: GauntletConvLightingRig
    /// </summary>
    public unsafe BmSDK.BmGame.RLightingRigActor GauntletConvLightingRig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLightingRigActor>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// ObjectProperty: RPC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController RPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// ObjectProperty: TVOnSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent TVOnSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// ObjectProperty: TVOffSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent TVOffSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// ObjectProperty: RHDOnSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent RHDOnSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// ObjectProperty: RHDOffSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent RHDOffSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// ObjectProperty: StopProjectionCachedCaller
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_PlayRadioOrThoughtDialogue StopProjectionCachedCaller
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_PlayRadioOrThoughtDialogue>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// ComponentProperty: XrayWorldMaskMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent XrayWorldMaskMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// ComponentProperty: XrayHighlightMaskMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent XrayHighlightMaskMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// ComponentProperty: ScreenHologramMovieMesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent ScreenHologramMovieMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// ComponentProperty: ScreenHologramMesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent ScreenHologramMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// ComponentProperty: ScreenHologram
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxWorldMovieComponent ScreenHologram
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxWorldMovieComponent>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// ComponentProperty: ScreenLight
    /// </summary>
    public unsafe BmSDK.Engine.LightComponent ScreenLight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.LightComponent>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// StrProperty: QueuedVideoResource
    /// </summary>
    public unsafe BmSDK.FString QueuedVideoResource
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// StrProperty: QueuedVideoHeaderText
    /// </summary>
    public unsafe BmSDK.FString QueuedVideoHeaderText
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// BoolProperty: QueuedVideoForceOpaque
    /// </summary>
    public unsafe bool QueuedVideoForceOpaque
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 300); }
    }

    /// <summary>
    /// BoolProperty: QueuedWithOverlay
    /// </summary>
    public unsafe bool QueuedWithOverlay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 300); }
    }

    /// <summary>
    /// BoolProperty: QueuedConnectionFailedOn
    /// </summary>
    public unsafe bool QueuedConnectionFailedOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 300); }
    }

    /// <summary>
    /// BoolProperty: QueuedSkipIntro
    /// </summary>
    public unsafe bool QueuedSkipIntro
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 300); }
    }

    /// <summary>
    /// BoolProperty: bRHDIsSetInDetectiveMode
    /// </summary>
    public unsafe bool bRHDIsSetInDetectiveMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 300); }
    }

    /// <summary>
    /// BoolProperty: ScreenOn
    /// </summary>
    public unsafe bool ScreenOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 300); }
    }

    /// <summary>
    /// BoolProperty: ScreenOverLayOn
    /// </summary>
    public unsafe bool ScreenOverLayOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 300); }
    }

    /// <summary>
    /// BoolProperty: bDontStop
    /// </summary>
    public unsafe bool bDontStop
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 300); }
    }

    /// <summary>
    /// BoolProperty: NeedToRestoreHudWhenFinished
    /// </summary>
    public unsafe bool NeedToRestoreHudWhenFinished
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 300); }
    }

    /// <summary>
    /// StrProperty: QueuedPortraitName
    /// </summary>
    public unsafe BmSDK.FString QueuedPortraitName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// FloatProperty: ScreenLightBrightness
    /// </summary>
    public unsafe float ScreenLightBrightness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }

    /// <summary>
    /// StructProperty: LeftCornerScreenOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 LeftCornerScreenOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// StructProperty: LeftCornerScreenRotationOffset
    /// </summary>
    public unsafe BmSDK.Rotator LeftCornerScreenRotationOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }

    /// <summary>
    /// StructProperty: ScreenToMeshOffset_Bone
    /// </summary>
    public unsafe System.Numerics.Vector3 ScreenToMeshOffset_Bone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// StructProperty: BatmanToMeshOffset_Batmobile
    /// </summary>
    public unsafe System.Numerics.Vector3 BatmanToMeshOffset_Batmobile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// StructProperty: BatmanToMeshRotation_Batmobile
    /// </summary>
    public unsafe BmSDK.Rotator BatmanToMeshRotation_Batmobile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// StrProperty: lastPlayedVideoResource
    /// </summary>
    public unsafe BmSDK.FString lastPlayedVideoResource
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// ByteProperty: transState
    /// </summary>
    public unsafe BmSDK.BmGame.RGauntletProjector.transitionState transState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGauntletProjector.transitionState>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// FloatProperty: transProportion
    /// </summary>
    public unsafe float transProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// FloatProperty: transInDuration
    /// </summary>
    public unsafe float transInDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// FloatProperty: transOutDuration
    /// </summary>
    public unsafe float transOutDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// StrProperty: StopProjectionCachedVideoResource
    /// </summary>
    public unsafe BmSDK.FString StopProjectionCachedVideoResource
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }
}
