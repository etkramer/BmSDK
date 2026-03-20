#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RGFxMovieBackScreen_Normal<br/>
/// (size = 2316)
/// (flags = 0)
/// </summary>
public partial class RGFxMovieBackScreen_Normal : BmSDK.BmGame.RGFxMovieBackScreen, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RGFxMovieBackScreen_Normal", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieBackScreen_Normal() { }

    /// <summary>
    /// Constructs a new RGFxMovieBackScreen_Normal
    /// </summary>
    public RGFxMovieBackScreen_Normal(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieBackScreen_Normal Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieBackScreen_Normal(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: XI_GetSideOverlay
    /// </summary>
    public unsafe BmSDK.FString XI_GetSideOverlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_GetSideOverlay", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: XI_OnLineStopped
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogue.AkDialogueCallbackResult XI_OnLineStopped(BmSDK.Engine.AkDialogueLine dlgLine, BmSDK.Engine.AkDialogueEvent dlgEvent, BmSDK.GameObject dlgSpeaker, bool interrupted)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_OnLineStopped", true);
        byte* paramsPtr = stackalloc byte[29];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgLine, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgEvent, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgSpeaker, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(interrupted, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogue.AkDialogueCallbackResult>(paramsPtr + 28);
    }

    /// <summary>
    /// Function: XI_OnLineStarted
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogue.AkDialogueCallbackResult XI_OnLineStarted(BmSDK.Engine.AkDialogueLine dlgLine, BmSDK.Engine.AkDialogueEvent dlgEvent, BmSDK.GameObject dlgSpeaker, bool bBarkSquelch)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_OnLineStarted", true);
        byte* paramsPtr = stackalloc byte[29];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgLine, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgEvent, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgSpeaker, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBarkSquelch, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogue.AkDialogueCallbackResult>(paramsPtr + 28);
    }

    /// <summary>
    /// Function: XI_OnSpeechStopped
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogue.AkDialogueCallbackResult XI_OnSpeechStopped(int speechId, bool interrupted)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_OnSpeechStopped", true);
        byte* paramsPtr = stackalloc byte[9];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(speechId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(interrupted, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogue.AkDialogueCallbackResult>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: XI_OnSpeechStarted
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogue.AkDialogueCallbackResult XI_OnSpeechStarted(int speechId)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_OnSpeechStarted", true);
        byte* paramsPtr = stackalloc byte[5];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(speechId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogue.AkDialogueCallbackResult>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: XI_IsDialogActive
    /// </summary>
    public unsafe bool XI_IsDialogActive()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_IsDialogActive", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: XI_StopDialog
    /// </summary>
    public unsafe void XI_StopDialog()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_StopDialog", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_PlayDialog
    /// </summary>
    public unsafe BmSDK.FString XI_PlayDialog(BmSDK.FString RefName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_PlayDialog", true);
        byte* paramsPtr = stackalloc byte[152];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RefName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: LeaderboardTick
    /// </summary>
    public unsafe void LeaderboardTick()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.LeaderboardTick", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsPollingBoards
    /// </summary>
    public unsafe bool IsPollingBoards()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.IsPollingBoards", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: FetchLeaderboard
    /// </summary>
    public unsafe void FetchLeaderboard()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.FetchLeaderboard", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UC_TriggerLeaderboard
    /// </summary>
    public unsafe void UC_TriggerLeaderboard(int FriendCount)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.UC_TriggerLeaderboard", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendCount, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SendLeaderBoardToFlash
    /// </summary>
    public unsafe void SendLeaderBoardToFlash(int Id, int total, BmSDK.TArray<int> FriendIndex, BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> NetIDs, BmSDK.TArray<int> Ranks, BmSDK.TArray<BmSDK.FString> NickNames, BmSDK.TArray<int> Medals, BmSDK.TArray<float> Scores, BmSDK.TArray<int> RivalPoints, BmSDK.TArray<float> Story, BmSDK.TArray<float> MW, BmSDK.TArray<float> AR)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.SendLeaderBoardToFlash", true);
        byte* paramsPtr = stackalloc byte[212];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(total, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendIndex, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NetIDs, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Ranks, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NickNames, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Medals, paramsPtr + 72);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Scores, paramsPtr + 88);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RivalPoints, paramsPtr + 104);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Story, paramsPtr + 120);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MW, paramsPtr + 136);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AR, paramsPtr + 152);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UC_SetLeaderboardLine
    /// </summary>
    public unsafe void UC_SetLeaderboardLine(int Index, int Rank, BmSDK.FString NickName, int Medals, BmSDK.FString Score, bool bIsMe)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.UC_SetLeaderboardLine", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rank, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NickName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Medals, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Score, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsMe, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_RegisterLeaderboardPath
    /// </summary>
    public unsafe void XI_RegisterLeaderboardPath(BmSDK.FString TargetPath)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_RegisterLeaderboardPath", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_GetVideoProgressName
    /// </summary>
    public unsafe BmSDK.FString XI_GetVideoProgressName(BmSDK.FString MissionName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_GetVideoProgressName", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MissionName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: XI_OpenScreen
    /// </summary>
    public unsafe void XI_OpenScreen(BmSDK.FString ScreenName, bool bIsFirstScreen)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_OpenScreen", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScreenName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsFirstScreen, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_Tick
    /// </summary>
    public unsafe void XI_Tick()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_Tick", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_PromptClicked
    /// </summary>
    public unsafe void XI_PromptClicked(int PromptId)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_PromptClicked", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PromptId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_OnOut
    /// </summary>
    public unsafe void XI_OnOut()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_OnOut", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_SetupTabMenu
    /// </summary>
    public unsafe int XI_SetupTabMenu(BmSDK.FString TargetPath)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_SetupTabMenu", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: PlayAzraelMinigameDialogue
    /// </summary>
    public unsafe void PlayAzraelMinigameDialogue(byte dialogue_index)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.PlayAzraelMinigameDialogue", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dialogue_index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_SetRumbleFromFlash
    /// </summary>
    public unsafe void XI_SetRumbleFromFlash(float left_rumble, float right_rumble)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_SetRumbleFromFlash", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(left_rumble, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(right_rumble, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetMouseCursorEnabled
    /// </summary>
    public unsafe void SetMouseCursorEnabled(bool is_enabled)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.SetMouseCursorEnabled", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_enabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PreemptivelyBlockInputForMinigame
    /// </summary>
    public unsafe void PreemptivelyBlockInputForMinigame()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.PreemptivelyBlockInputForMinigame", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PrepBatmanChallengeRequirements
    /// </summary>
    public unsafe void PrepBatmanChallengeRequirements(out BmSDK.TArray<int> AreNotPossible)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.PrepBatmanChallengeRequirements", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        AreNotPossible = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: XI_RiddlerScreenShowMapItemSecret
    /// </summary>
    public unsafe bool XI_RiddlerScreenShowMapItemSecret(BmSDK.FString sItemName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_RiddlerScreenShowMapItemSecret", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sItemName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: XI_RiddlerScreenGotoReward
    /// </summary>
    public unsafe void XI_RiddlerScreenGotoReward(BmSDK.FString sReward)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_RiddlerScreenGotoReward", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sReward, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_RiddlerScreenUnlockReward
    /// </summary>
    public unsafe void XI_RiddlerScreenUnlockReward(BmSDK.FString sReward)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_RiddlerScreenUnlockReward", true);
        byte* paramsPtr = stackalloc byte[17];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sReward, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_RiddlerScreenSetPieceCompleted
    /// </summary>
    public unsafe void XI_RiddlerScreenSetPieceCompleted(int nPuzzle, int nPiece)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_RiddlerScreenSetPieceCompleted", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nPuzzle, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nPiece, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_RiddlerScreenSetPieceViewed
    /// </summary>
    public unsafe void XI_RiddlerScreenSetPieceViewed(int nPuzzle, int nPiece)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_RiddlerScreenSetPieceViewed", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nPuzzle, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nPiece, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_RiddlerScreenSetPieceActive
    /// </summary>
    public unsafe void XI_RiddlerScreenSetPieceActive(int nPuzzle, int nPiece)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_RiddlerScreenSetPieceActive", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nPuzzle, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nPiece, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_RiddlerScreenRequestData
    /// </summary>
    public unsafe void XI_RiddlerScreenRequestData(BmSDK.FString TargetPath)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_RiddlerScreenRequestData", true);
        byte* paramsPtr = stackalloc byte[128];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UC_RiddlerScreenSetSelection
    /// </summary>
    public unsafe void UC_RiddlerScreenSetSelection(int nPuzzleId, int nPieceIndex, bool bImmediate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.UC_RiddlerScreenSetSelection", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nPuzzleId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nPieceIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bImmediate, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UC_RiddlerScreenAddPuzzle
    /// </summary>
    public unsafe void UC_RiddlerScreenAddPuzzle(int nId, BmSDK.FString sCategory, BmSDK.FString sPuzzle, BmSDK.FString sPrize)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.UC_RiddlerScreenAddPuzzle", true);
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sCategory, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sPuzzle, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sPrize, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_CitySave
    /// </summary>
    public unsafe void XI_CitySave(int Index, int PageIndex, int TapeIndex)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_CitySave", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PageIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TapeIndex, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_BioSave
    /// </summary>
    public unsafe void XI_BioSave(int LocIndex, int Loc0Index, int Loc1Index, int Loc2Index, int PageIndex, int TapeIndex)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_BioSave", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc0Index, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc1Index, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc2Index, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PageIndex, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TapeIndex, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_ClearCityStoryNew
    /// </summary>
    public unsafe void XI_ClearCityStoryNew(int Index)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_ClearCityStoryNew", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_ClearBioNew
    /// </summary>
    public unsafe void XI_ClearBioNew(int Index)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_ClearBioNew", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_RequestBiosLocNews
    /// </summary>
    public unsafe void XI_RequestBiosLocNews(BmSDK.FString TargetPath)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_RequestBiosLocNews", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_RequestBiosData
    /// </summary>
    public unsafe void XI_RequestBiosData(int PageId, BmSDK.FString TargetPath)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_RequestBiosData", true);
        byte* paramsPtr = stackalloc byte[160];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PageId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPath, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_RequestBiosBaseData
    /// </summary>
    public unsafe void XI_RequestBiosBaseData(BmSDK.FString TargetPath)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_RequestBiosBaseData", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetBioCharacterList
    /// </summary>
    public unsafe void GetBioCharacterList(out BmSDK.TArray<BmSDK.FString> CharList)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.GetBioCharacterList", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        CharList = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: XI_UpgradeScreenCommit
    /// </summary>
    public unsafe void XI_UpgradeScreenCommit(BmSDK.FString sUpgrade, int nValue)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_UpgradeScreenCommit", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sUpgrade, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nValue, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_UpgradeScreenRequestPage
    /// </summary>
    public unsafe void XI_UpgradeScreenRequestPage(BmSDK.FString sPage)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_UpgradeScreenRequestPage", true);
        byte* paramsPtr = stackalloc byte[256];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sPage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_UpgradeScreenRequestExperience
    /// </summary>
    public unsafe void XI_UpgradeScreenRequestExperience()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_UpgradeScreenRequestExperience", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_UpgradeScreenSetup
    /// </summary>
    public unsafe void XI_UpgradeScreenSetup(BmSDK.FString sPath)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_UpgradeScreenSetup", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_UpgradeScreenViewedItem
    /// </summary>
    public unsafe void XI_UpgradeScreenViewedItem(BmSDK.FString sUpgrade)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_UpgradeScreenViewedItem", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sUpgrade, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UC_UpgradeAddNode
    /// </summary>
    public unsafe void UC_UpgradeAddNode(int nX, int nY, int nDX, int nDY, BmSDK.FString sUpgrade, BmSDK.FString sIcon, BmSDK.FString sBackground, BmSDK.FString sState, BmSDK.FString sAction, int nValue, int nTotal, float fScale)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.UC_UpgradeAddNode", true);
        byte* paramsPtr = stackalloc byte[108];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nX, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nY, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nDX, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nDY, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sUpgrade, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sIcon, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sBackground, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sState, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sAction, paramsPtr + 80);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nValue, paramsPtr + 96);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nTotal, paramsPtr + 100);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fScale, paramsPtr + 104);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UC_UpgradeAddHeader
    /// </summary>
    public unsafe void UC_UpgradeAddHeader(int nNodeX, int nNodeY, BmSDK.FString sHeader, bool bLeftJustify, float fOX, float fOY, float fTX, float fTY)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.UC_UpgradeAddHeader", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nNodeX, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nNodeY, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sHeader, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLeftJustify, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fOX, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fOY, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fTX, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fTY, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UC_UpgradeSetExperience
    /// </summary>
    public unsafe void UC_UpgradeSetExperience(int nAwards, int nPoints, int nTotal, BmSDK.FString sDescription, int iPlayerLevel, int iUpgradesRemaining)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.UC_UpgradeSetExperience", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nAwards, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nPoints, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nTotal, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sDescription, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iPlayerLevel, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iUpgradesRemaining, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_GetFanActive
    /// </summary>
    public unsafe bool XI_GetFanActive(int FloorNumber)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_GetFanActive", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FloorNumber, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: XI_GetBatmobileScrewState
    /// </summary>
    public unsafe float XI_GetBatmobileScrewState()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_GetBatmobileScrewState", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: XI_GetStickAngMag
    /// </summary>
    public unsafe void XI_GetStickAngMag(BmSDK.FString TargetBasePath)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_GetStickAngMag", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetBasePath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetCameraRotation
    /// </summary>
    public unsafe float GetCameraRotation(int Axis)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.GetCameraRotation", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Axis, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetPlayerRoomDescription
    /// </summary>
    public unsafe BmSDK.FString GetPlayerRoomDescription()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.GetPlayerRoomDescription", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: XI_RiddleNameCorrect
    /// </summary>
    public unsafe BmSDK.FString XI_RiddleNameCorrect(BmSDK.FString ItemName, BmSDK.FString InName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_RiddleNameCorrect", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InName, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 32);
    }

    /// <summary>
    /// Function: XI_SetCustomWaypointSideStoryInfo
    /// </summary>
    public unsafe void XI_SetCustomWaypointSideStoryInfo(BmSDK.FString SS_Character, BmSDK.FString VisibleFlag, BmSDK.FString DoneFlag, BmSDK.FString StatesNew)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_SetCustomWaypointSideStoryInfo", true);
        byte* paramsPtr = stackalloc byte[84];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SS_Character, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VisibleFlag, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DoneFlag, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatesNew, paramsPtr + 48);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_SetIconState
    /// </summary>
    public unsafe void XI_SetIconState(bool bVisible)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_SetIconState", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVisible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_SetCustomWaypoint
    /// </summary>
    public unsafe void XI_SetCustomWaypoint(bool bEnabled, float atX, float atY, float atZ, BmSDK.FString WaypointName, BmSDK.FString WaypointTypeName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_SetCustomWaypoint", true);
        byte* paramsPtr = stackalloc byte[76];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnabled, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atX, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atY, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atZ, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WaypointName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WaypointTypeName, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_OnCustomWaypointDisabled
    /// </summary>
    public unsafe void XI_OnCustomWaypointDisabled(BmSDK.FString WaypointName, BmSDK.FString WaypointTypeName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_OnCustomWaypointDisabled", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WaypointName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WaypointTypeName, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_GetFloorZAtPosition
    /// </summary>
    public unsafe void XI_GetFloorZAtPosition(float atX, float atY, float atZ)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_GetFloorZAtPosition", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atX, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atY, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atZ, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_ChangeIconFilter
    /// </summary>
    public unsafe void XI_ChangeIconFilter(int FilterId)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_ChangeIconFilter", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FilterId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetActiveFilters
    /// </summary>
    public unsafe BmSDK.TArray<int> GetActiveFilters()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.GetActiveFilters", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: XI_RemoveMapObj
    /// </summary>
    public unsafe void XI_RemoveMapObj(BmSDK.FString ItemName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_RemoveMapObj", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_MapSave
    /// </summary>
    public unsafe void XI_MapSave(int DBIndex)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_MapSave", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DBIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_RequestMapIconData
    /// </summary>
    public unsafe void XI_RequestMapIconData(BmSDK.FString MapName, BmSDK.FString TargetBasePath)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_RequestMapIconData", true);
        byte* paramsPtr = stackalloc byte[120];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetBasePath, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RequestMapFlagData
    /// </summary>
    public unsafe void RequestMapFlagData(BmSDK.FString TargetBasePath)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.RequestMapFlagData", true);
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetBasePath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_RequestMapData
    /// </summary>
    public unsafe void XI_RequestMapData(BmSDK.FString TargetBasePath)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_RequestMapData", true);
        byte* paramsPtr = stackalloc byte[112];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetBasePath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_FetchSelectedItemData
    /// </summary>
    public unsafe void XI_FetchSelectedItemData(BmSDK.FString TargetBasePath)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_FetchSelectedItemData", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetBasePath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UC_SetIconInfo
    /// </summary>
    public unsafe void UC_SetIconInfo(int Index, BmSDK.FString TypeName, BmSDK.FString instancename, int X, int Y, int Z, int Flags, BmSDK.FString RemapTypeName, BmSDK.FString RemapInstanceName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.UC_SetIconInfo", true);
        byte* paramsPtr = stackalloc byte[100];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TypeName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(instancename, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Z, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Flags, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RemapTypeName, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RemapInstanceName, paramsPtr + 68);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_GetHowToUnlockMsg
    /// </summary>
    public unsafe BmSDK.FString XI_GetHowToUnlockMsg(BmSDK.FString instancename)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_GetHowToUnlockMsg", true);
        byte* paramsPtr = stackalloc byte[84];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(instancename, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: XI_IsChallengeUnLocked
    /// </summary>
    public unsafe bool XI_IsChallengeUnLocked(BmSDK.FString instancename)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_IsChallengeUnLocked", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(instancename, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: XI_IsChallengeRevealed
    /// </summary>
    public unsafe bool XI_IsChallengeRevealed(BmSDK.FString instancename)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_IsChallengeRevealed", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(instancename, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: XI_GetMedalCount
    /// </summary>
    public unsafe BmSDK.FString XI_GetMedalCount(BmSDK.FString instancename)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_GetMedalCount", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(instancename, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: GetARChallengeMedalCount
    /// </summary>
    public unsafe int GetARChallengeMedalCount(BmSDK.FString instancename)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.GetARChallengeMedalCount", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(instancename, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: XI_GetActualChallengeDesc
    /// </summary>
    public unsafe BmSDK.FString XI_GetActualChallengeDesc(BmSDK.FString instancename)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_GetActualChallengeDesc", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(instancename, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: XI_GetActualChallengeName
    /// </summary>
    public unsafe BmSDK.FString XI_GetActualChallengeName(BmSDK.FString instancename, bool bMixedCase)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_GetActualChallengeName", true);
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(instancename, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMixedCase, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: GetCoOrdStr
    /// </summary>
    public unsafe BmSDK.FString GetCoOrdStr()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.GetCoOrdStr", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: XI_Map3DMoveBy
    /// </summary>
    public unsafe int XI_Map3DMoveBy(float DX, float DY, float dRotation, float dElevation, float dDistance)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_Map3DMoveBy", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DX, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DY, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dRotation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dElevation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dDistance, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: ApplyLimits
    /// </summary>
    public unsafe int ApplyLimits()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.ApplyLimits", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: XI_GetScreenSize
    /// </summary>
    public unsafe void XI_GetScreenSize(BmSDK.FString TargetBasePath)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_GetScreenSize", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetBasePath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_GetMouseCoodinates
    /// </summary>
    public unsafe void XI_GetMouseCoodinates(BmSDK.FString TargetBasePath)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_GetMouseCoodinates", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetBasePath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_GetbUsingGamepad
    /// </summary>
    public unsafe void XI_GetbUsingGamepad(BmSDK.FString TargetBasePath)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_GetbUsingGamepad", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetBasePath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UC_Map3DCityArea
    /// </summary>
    public unsafe void UC_Map3DCityArea(BmSDK.FString sArea)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.UC_Map3DCityArea", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sArea, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_GetMap3DCoordinates
    /// </summary>
    public unsafe void XI_GetMap3DCoordinates()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_GetMap3DCoordinates", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UC_Map3DMoved
    /// </summary>
    public unsafe void UC_Map3DMoved(float ToPosX, float ToPosY, float ToPosZ, float toRot, float ToElev, float ToDist, BmSDK.FString CoOrdStr)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.UC_Map3DMoved", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToPosX, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToPosY, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToPosZ, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(toRot, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToElev, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToDist, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CoOrdStr, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UC_PushCoOrd
    /// </summary>
    public unsafe void UC_PushCoOrd(BmSDK.FString CoOrdStr, bool bMoving, bool bTilting)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.UC_PushCoOrd", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CoOrdStr, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMoving, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTilting, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FindFloor
    /// </summary>
    public unsafe System.Numerics.Vector3 FindFloor(System.Numerics.Vector3 pos, System.Numerics.Vector3 Dest)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.FindFloor", true);
        byte* paramsPtr = stackalloc byte[120];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Dest, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: XI_CalcMapScreenStick
    /// </summary>
    public unsafe int XI_CalcMapScreenStick()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_CalcMapScreenStick", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetupNextPanTarget
    /// </summary>
    public unsafe void SetupNextPanTarget()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.SetupNextPanTarget", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetPanWait
    /// </summary>
    public unsafe void SetPanWait()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.SetPanWait", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_PanToXYZ
    /// </summary>
    public unsafe void XI_PanToXYZ(float X, float Y, float Z)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_PanToXYZ", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Z, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_CenterMap
    /// </summary>
    public unsafe void XI_CenterMap()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_CenterMap", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_CanCenter
    /// </summary>
    public unsafe bool XI_CanCenter()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_CanCenter", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: FindItemInList
    /// </summary>
    public unsafe int FindItemInList(BmSDK.FString ItemName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.FindItemInList", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: XI_GetDroneDifficulty
    /// </summary>
    public unsafe BmSDK.FString XI_GetDroneDifficulty(BmSDK.FString IconInstanceName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_GetDroneDifficulty", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IconInstanceName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: XI_GetRiddlerInfoFor
    /// </summary>
    public unsafe BmSDK.FString XI_GetRiddlerInfoFor(BmSDK.FString ItemTypeName, BmSDK.FString ItemName, bool bIs2DMap)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_GetRiddlerInfoFor", true);
        byte* paramsPtr = stackalloc byte[80];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemTypeName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIs2DMap, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 36);
    }

    /// <summary>
    /// Function: XI_FetchSecretsCountFor
    /// </summary>
    public unsafe bool XI_FetchSecretsCountFor(BmSDK.FString PrevLocName, BmSDK.FString NextLocName, BmSDK.FString TargetPath)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_FetchSecretsCountFor", true);
        byte* paramsPtr = stackalloc byte[100];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PrevLocName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextLocName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPath, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 48);
    }

    /// <summary>
    /// Function: GetSecretsLocationName
    /// </summary>
    public unsafe BmSDK.FString GetSecretsLocationName(BmSDK.FString sName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.GetSecretsLocationName", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: XI_SecretsCounterAvailable
    /// </summary>
    public unsafe bool XI_SecretsCounterAvailable()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_SecretsCounterAvailable", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetMap3DThreatLevel
    /// </summary>
    public unsafe void SetMap3DThreatLevel(int Area, bool bAllowThreats)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.SetMap3DThreatLevel", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Area, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowThreats, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateThreatMeter
    /// </summary>
    public unsafe void UpdateThreatMeter(int NewArea, bool TutorialMode = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.UpdateThreatMeter", true);
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewArea, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TutorialMode, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoThreatLevelIntroAnim
    /// </summary>
    public unsafe void DoThreatLevelIntroAnim()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.DoThreatLevelIntroAnim", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetThreatLevel
    /// </summary>
    public unsafe void SetThreatLevel(BmSDK.FString sCityName, BmSDK.FString sThreats, bool bBatmobileAvailable, bool bTutorialMode)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.SetThreatLevel", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sCityName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sThreats, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBatmobileAvailable, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTutorialMode, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_RegisterThreatLevelMeter
    /// </summary>
    public unsafe void XI_RegisterThreatLevelMeter(BmSDK.FString TargetPath)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_RegisterThreatLevelMeter", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_RefreshThreatLevelMeter
    /// </summary>
    public unsafe void XI_RefreshThreatLevelMeter(int AreaId)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_RefreshThreatLevelMeter", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AreaId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RoughlyCalcCityArea
    /// </summary>
    public unsafe int RoughlyCalcCityArea(float PosX, float PosY)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.RoughlyCalcCityArea", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PosX, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PosY, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: XI_OutroTween
    /// </summary>
    public unsafe bool XI_OutroTween()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_OutroTween", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: XI_OnOutro
    /// </summary>
    public unsafe void XI_OnOutro()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_OnOutro", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_IntroTween
    /// </summary>
    public unsafe bool XI_IntroTween()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_IntroTween", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: XI_OnIn
    /// </summary>
    public unsafe void XI_OnIn()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_OnIn", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_OnIntro
    /// </summary>
    public unsafe void XI_OnIntro()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_OnIntro", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetMap3DRenderingCustomWaypoint
    /// </summary>
    public unsafe void SetMap3DRenderingCustomWaypoint()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.SetMap3DRenderingCustomWaypoint", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Setup3DAutopan
    /// </summary>
    public unsafe void Setup3DAutopan(bool bIsSubMap)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.Setup3DAutopan", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsSubMap, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RequestStickCameraData
    /// </summary>
    public unsafe void RequestStickCameraData(BmSDK.FString TargetPath)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.RequestStickCameraData", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateVolumes
    /// </summary>
    public unsafe void UpdateVolumes(BmSDK.FString PlayerMap, BmSDK.FString TargettedIcon)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.UpdateVolumes", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerMap, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargettedIcon, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearMeshVolumes
    /// </summary>
    public unsafe void ClearMeshVolumes()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.ClearMeshVolumes", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FindHighlightVolumeActors
    /// </summary>
    public unsafe void FindHighlightVolumeActors()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.FindHighlightVolumeActors", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_RequestMapScreen3DData
    /// </summary>
    public unsafe void XI_RequestMapScreen3DData(BmSDK.FString TargetBasePath)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_RequestMapScreen3DData", true);
        byte* paramsPtr = stackalloc byte[112];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetBasePath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetObjectiveStyle
    /// </summary>
    public unsafe BmSDK.FString GetObjectiveStyle()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.GetObjectiveStyle", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsOverworldGameplay
    /// </summary>
    public unsafe bool IsOverworldGameplay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.IsOverworldGameplay", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: XI_RequestMapScreenData
    /// </summary>
    public unsafe void XI_RequestMapScreenData(BmSDK.FString TargetBasePath)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_RequestMapScreenData", true);
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetBasePath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_RequestObjectiveData
    /// </summary>
    public unsafe int XI_RequestObjectiveData(BmSDK.FString TargetBasePath)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.XI_RequestObjectiveData", true);
        byte* paramsPtr = stackalloc byte[76];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetBasePath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: StoreVariablesToPData
    /// </summary>
    public unsafe void StoreVariablesToPData()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.StoreVariablesToPData", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetVariablesFromPData
    /// </summary>
    public unsafe void SetVariablesFromPData()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.SetVariablesFromPData", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetVariablesFromPDD
    /// </summary>
    public unsafe void SetVariablesFromPDD()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieBackScreen_Normal.SetVariablesFromPDD", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FDialogEntry
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public partial record struct FDialogEntry
    {
        /// <summary>
        /// StrProperty: RefName
        /// </summary>
        public unsafe BmSDK.FString RefName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: AkLineRef
        /// </summary>
        public unsafe BmSDK.Engine.AkHash AkLineRef
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkHash>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StrProperty: Who
        /// </summary>
        public unsafe BmSDK.FString Who
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// BoolProperty: KillOnClose
        /// </summary>
        public unsafe bool KillOnClose
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }
    }

    /// <summary>
    /// Struct: FPromptEntry
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FPromptEntry
    {
        /// <summary>
        /// ByteProperty: Id
        /// </summary>
        public unsafe BmSDK.BmGame.RHUDPrompt.EControlIcon Id
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHUDPrompt.EControlIcon>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: Label
        /// </summary>
        public unsafe BmSDK.FString Label
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FSubMapDefault
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FSubMapDefault
    {
        /// <summary>
        /// StrProperty: MapName
        /// </summary>
        public unsafe BmSDK.FString MapName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: Rotation
        /// </summary>
        public unsafe float Rotation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: Elevation
        /// </summary>
        public unsafe float Elevation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// FloatProperty: Distance
        /// </summary>
        public unsafe float Distance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// BoolProperty: bReadPending
    /// </summary>
    public unsafe bool bReadPending
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1712); }
    }

    /// <summary>
    /// BoolProperty: bMovedUserMarker
    /// </summary>
    public unsafe bool bMovedUserMarker
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1712); }
    }

    /// <summary>
    /// BoolProperty: bCreatedIcons
    /// </summary>
    public unsafe bool bCreatedIcons
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1712); }
    }

    /// <summary>
    /// BoolProperty: bPanEnabled
    /// </summary>
    public unsafe bool bPanEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1712); }
    }

    /// <summary>
    /// BoolProperty: bPanEnabledLast
    /// </summary>
    public unsafe bool bPanEnabledLast
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1712); }
    }

    /// <summary>
    /// BoolProperty: bPanNoFirstEntryDelay
    /// </summary>
    public unsafe bool bPanNoFirstEntryDelay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1712); }
    }

    /// <summary>
    /// BoolProperty: bPanTweenElevationToo
    /// </summary>
    public unsafe bool bPanTweenElevationToo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1712); }
    }

    /// <summary>
    /// BoolProperty: bUpgradeCommitted
    /// </summary>
    public unsafe bool bUpgradeCommitted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1712); }
    }

    /// <summary>
    /// BoolProperty: BioAutoSelect
    /// </summary>
    public unsafe bool BioAutoSelect
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1712); }
    }

    /// <summary>
    /// BoolProperty: BiobAutoPlay
    /// </summary>
    public unsafe bool BiobAutoPlay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1712); }
    }

    /// <summary>
    /// BoolProperty: RumbleActive
    /// </summary>
    public unsafe bool RumbleActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1712); }
    }

    /// <summary>
    /// BoolProperty: bManualOpen
    /// </summary>
    public unsafe bool bManualOpen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1712); }
    }

    /// <summary>
    /// BoolProperty: bSaveGameWhenClosed
    /// </summary>
    public unsafe bool bSaveGameWhenClosed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1712); }
    }

    /// <summary>
    /// IntProperty: ChallengeID
    /// </summary>
    public unsafe int ChallengeID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1716); }
    }

    /// <summary>
    /// StrProperty: LeaderboardPath
    /// </summary>
    public unsafe BmSDK.FString LeaderboardPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1720); }
    }

    /// <summary>
    /// FloatProperty: LerpRatio
    /// </summary>
    public unsafe float LerpRatio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1736); }
    }

    /// <summary>
    /// IntProperty: ChapterId
    /// </summary>
    public unsafe int ChapterId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1740); }
    }

    /// <summary>
    /// StrProperty: ASClassPathTmp
    /// </summary>
    public unsafe BmSDK.FString ASClassPathTmp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1744); }
    }

    /// <summary>
    /// ArrayProperty: SubMapDefaults
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmScript.RGFxMovieBackScreen_Normal.FSubMapDefault> SubMapDefaults
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.RGFxMovieBackScreen_Normal.FSubMapDefault>>(Ptr + 1760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1760); }
    }

    /// <summary>
    /// ArrayProperty: Dialogs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmScript.RGFxMovieBackScreen_Normal.FDialogEntry> Dialogs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.RGFxMovieBackScreen_Normal.FDialogEntry>>(Ptr + 1776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1776); }
    }

    /// <summary>
    /// ArrayProperty: SpeechIdsActive
    /// </summary>
    public unsafe BmSDK.TArray<int> SpeechIdsActive
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1792); }
    }

    /// <summary>
    /// IntProperty: IdOfGlobalSpeechPlaying
    /// </summary>
    public unsafe int IdOfGlobalSpeechPlaying
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1808); }
    }

    /// <summary>
    /// IntProperty: IndexOfLastGlobalSpeech
    /// </summary>
    public unsafe int IndexOfLastGlobalSpeech
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1812); }
    }

    /// <summary>
    /// ArrayProperty: MapRiddleIconsInSubLocations
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> MapRiddleIconsInSubLocations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1816); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetThreatLevel
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetThreatLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1832); }
    }

    /// <summary>
    /// IntProperty: ThreatLevelAreaLast
    /// </summary>
    public unsafe int ThreatLevelAreaLast
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1848); }
    }

    /// <summary>
    /// ArrayProperty: ThreatLevels
    /// </summary>
    public unsafe BmSDK.TArray<int> ThreatLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1852); }
    }

    /// <summary>
    /// ArrayProperty: ThreatLevelsLast
    /// </summary>
    public unsafe BmSDK.TArray<int> ThreatLevelsLast
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1868); }
    }

    /// <summary>
    /// ArrayProperty: OW_IncludeTheseExceptions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> OW_IncludeTheseExceptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1884); }
    }

    /// <summary>
    /// ArrayProperty: OW_ExcludeTheseExceptions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> OW_ExcludeTheseExceptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1900); }
    }

    /// <summary>
    /// StrProperty: MapScreenBasePath
    /// </summary>
    public unsafe BmSDK.FString MapScreenBasePath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1916); }
    }

    /// <summary>
    /// StrProperty: MapScript
    /// </summary>
    public unsafe BmSDK.FString MapScript
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1932); }
    }

    /// <summary>
    /// StrProperty: MapCallback
    /// </summary>
    public unsafe BmSDK.FString MapCallback
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1948); }
    }

    /// <summary>
    /// FloatProperty: TweenInRate
    /// </summary>
    public unsafe float TweenInRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1964); }
    }

    /// <summary>
    /// FloatProperty: TweenOutRate
    /// </summary>
    public unsafe float TweenOutRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1968); }
    }

    /// <summary>
    /// FloatProperty: DefaultHeight
    /// </summary>
    public unsafe float DefaultHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1972); }
    }

    /// <summary>
    /// FloatProperty: DefaultElevation
    /// </summary>
    public unsafe float DefaultElevation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1976); }
    }

    /// <summary>
    /// FloatProperty: DefaultDistance
    /// </summary>
    public unsafe float DefaultDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1980); }
    }

    /// <summary>
    /// StructProperty: StickLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 StickLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1984); }
    }

    /// <summary>
    /// FloatProperty: StickRotation
    /// </summary>
    public unsafe float StickRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1996); }
    }

    /// <summary>
    /// FloatProperty: StickElevation
    /// </summary>
    public unsafe float StickElevation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2000); }
    }

    /// <summary>
    /// FloatProperty: StickDistance
    /// </summary>
    public unsafe float StickDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2004); }
    }

    /// <summary>
    /// StructProperty: TweenSourceLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 TweenSourceLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2008); }
    }

    /// <summary>
    /// StructProperty: TweenSourceRotation
    /// </summary>
    public unsafe BmSDK.Rotator TweenSourceRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 2020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2020); }
    }

    /// <summary>
    /// FloatProperty: TweenSourceFOV
    /// </summary>
    public unsafe float TweenSourceFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2032); }
    }

    /// <summary>
    /// StructProperty: TweenTargetLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 TweenTargetLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2036); }
    }

    /// <summary>
    /// StructProperty: TweenTargetRotation
    /// </summary>
    public unsafe BmSDK.Rotator TweenTargetRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 2048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2048); }
    }

    /// <summary>
    /// FloatProperty: TweenTargetFOV
    /// </summary>
    public unsafe float TweenTargetFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2060); }
    }

    /// <summary>
    /// StructProperty: CityOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 CityOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2064); }
    }

    /// <summary>
    /// ArrayProperty: PanToIcons
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> PanToIcons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 2076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2076); }
    }

    /// <summary>
    /// StructProperty: PanReturnToLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 PanReturnToLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2092); }
    }

    /// <summary>
    /// StructProperty: PanDelta
    /// </summary>
    public unsafe System.Numerics.Vector3 PanDelta
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2104); }
    }

    /// <summary>
    /// StructProperty: PanXYZTarget
    /// </summary>
    public unsafe System.Numerics.Vector3 PanXYZTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2116); }
    }

    /// <summary>
    /// IntProperty: PanStep
    /// </summary>
    public unsafe int PanStep
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2128); }
    }

    /// <summary>
    /// IntProperty: PanWait
    /// </summary>
    public unsafe int PanWait
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2132); }
    }

    /// <summary>
    /// FloatProperty: PanRate
    /// </summary>
    public unsafe float PanRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2136); }
    }

    /// <summary>
    /// FloatProperty: PanDeltaElev
    /// </summary>
    public unsafe float PanDeltaElev
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2140); }
    }

    /// <summary>
    /// ArrayProperty: VolumeActors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RockMapHighlight> VolumeActors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RockMapHighlight>>(Ptr + 2144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2144); }
    }

    /// <summary>
    /// StrProperty: TargettedIconLast
    /// </summary>
    public unsafe BmSDK.FString TargettedIconLast
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2160); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerItems_InBuildings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> RiddlerItems_InBuildings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 2176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2176); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerItem_OffsetNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> RiddlerItem_OffsetNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 2192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2192); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerItem_OffsetValues
    /// </summary>
    public unsafe BmSDK.TArray<int> RiddlerItem_OffsetValues
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2208); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_UpgradeScreen
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_UpgradeScreen
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2224); }
    }

    /// <summary>
    /// ArrayProperty: UpgradePrompts
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmScript.RGFxMovieBackScreen_Normal.FPromptEntry> UpgradePrompts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.RGFxMovieBackScreen_Normal.FPromptEntry>>(Ptr + 2240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2240); }
    }

    /// <summary>
    /// IntProperty: BioLocIndex
    /// </summary>
    public unsafe int BioLocIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2256); }
    }

    /// <summary>
    /// ArrayProperty: BioIndex
    /// </summary>
    public unsafe BmSDK.TArray<int> BioIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2260); }
    }

    /// <summary>
    /// IntProperty: BioPageId
    /// </summary>
    public unsafe int BioPageId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2276); }
    }

    /// <summary>
    /// IntProperty: BioTapeId
    /// </summary>
    public unsafe int BioTapeId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2280); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_RiddlerScreen
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_RiddlerScreen
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2284); }
    }

    /// <summary>
    /// FloatProperty: FlashRumbleValueLeft
    /// </summary>
    public unsafe float FlashRumbleValueLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2300); }
    }

    /// <summary>
    /// FloatProperty: FlashRumbleValueRight
    /// </summary>
    public unsafe float FlashRumbleValueRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2304); }
    }

    /// <summary>
    /// ObjectProperty: MinigameFFWaveForm
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform MinigameFFWaveForm
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 2308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2308); }
    }
}
