#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RGFxMovieFlashMovie<br/>
/// (size = 528)
/// (flags = 18)
/// </summary>
public partial class RGFxMovieFlashMovie : BmSDK.BmGame.RGFxMovie, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RGFxMovieFlashMovie", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieFlashMovie() { }

    /// <summary>
    /// Constructs a new RGFxMovieFlashMovie
    /// </summary>
    public RGFxMovieFlashMovie(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieFlashMovie Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieFlashMovie(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GameMovieSetPauseState
    /// </summary>
    public unsafe override void GameMovieSetPauseState(bool bPause)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieFlashMovie.GameMovieSetPauseState", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPause, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HasGameMovieContent
    /// </summary>
    public unsafe override bool HasGameMovieContent()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieFlashMovie.HasGameMovieContent", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: OnClose
    /// </summary>
    public unsafe override void OnClose()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieFlashMovie.OnClose", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FlashOnClose
    /// </summary>
    public unsafe virtual void FlashOnClose()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieFlashMovie.FlashOnClose", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: MovieStartOutro
    /// </summary>
    public unsafe virtual void MovieStartOutro()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieFlashMovie.MovieStartOutro", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: MovieUpdateVolumes
    /// </summary>
    public unsafe virtual void MovieUpdateVolumes()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieFlashMovie.MovieUpdateVolumes", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Flash_SetVolumes
    /// </summary>
    public unsafe virtual void Flash_SetVolumes(float MainVol, float SubVol)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieFlashMovie.Flash_SetVolumes", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MainVol, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubVol, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AtEnd
    /// </summary>
    public unsafe virtual void AtEnd()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieFlashMovie.AtEnd", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: MovieClose
    /// </summary>
    public unsafe virtual void MovieClose()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieFlashMovie.MovieClose", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: MoviePause
    /// </summary>
    public unsafe virtual void MoviePause()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieFlashMovie.MoviePause", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: MoviePlay
    /// </summary>
    public unsafe virtual void MoviePlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieFlashMovie.MoviePlay", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HandleCUE
    /// </summary>
    public unsafe virtual void HandleCUE(BmSDK.FString CueStr)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieFlashMovie.HandleCUE", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CueStr, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetSubtitleTo
    /// </summary>
    public unsafe virtual void SetSubtitleTo(BmSDK.FString Message)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieFlashMovie.SetSubtitleTo", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Message, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateHudVisibility
    /// </summary>
    public unsafe override void UpdateHudVisibility(bool bVisible)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieFlashMovie.UpdateHudVisibility", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVisible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CustomInit
    /// </summary>
    public unsafe virtual bool CustomInit(BmSDK.BmGame.RPlayerController PC, BmSDK.FString USM_MovieName, float USM_BufferSize, bool bLoop, BmSDK.TArray<float> pos = default, BmSDK.TArray<float> Rot = default, bool bUseSubs = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieFlashMovie.CustomInit", true);
        byte* paramsPtr = stackalloc byte[84];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(USM_MovieName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(USM_BufferSize, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLoop, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pos, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rot, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseSubs, paramsPtr + 48);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 52);
    }

    /// <summary>
    /// ObjectProperty: TheAction
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_FlashTextureMovieControl TheAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_FlashTextureMovieControl>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// StrProperty: TheMovieName
    /// </summary>
    public unsafe BmSDK.FString TheMovieName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// BoolProperty: bFinished
    /// </summary>
    public unsafe bool bFinished
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 512) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 512); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 512); }
    }

    /// <summary>
    /// BoolProperty: bUseSubtitles
    /// </summary>
    public unsafe bool bUseSubtitles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 512) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 512); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 512); }
    }

    /// <summary>
    /// StrProperty: LastSub
    /// </summary>
    public unsafe BmSDK.FString LastSub
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }
}
