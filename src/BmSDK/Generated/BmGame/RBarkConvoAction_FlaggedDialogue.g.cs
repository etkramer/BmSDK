#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBarkConvoAction_FlaggedDialogue<br/>
/// (flags = 0)
/// </summary>
public partial class RBarkConvoAction_FlaggedDialogue : BmSDK.BmGame.RBarkConvoAction_SpeechBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBarkConvoAction_FlaggedDialogue", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBarkConvoAction_FlaggedDialogue() { }

    /// <summary>
    /// Constructs a new RBarkConvoAction_FlaggedDialogue
    /// </summary>
    public RBarkConvoAction_FlaggedDialogue(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBarkConvoAction_FlaggedDialogue Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBarkConvoAction_FlaggedDialogue(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetCurrentDialogueType
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueType GetCurrentDialogueType()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBarkConvoAction_FlaggedDialogue.GetCurrentDialogueType", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueType>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetBestDataAndIndex
    /// </summary>
    public unsafe void GetBestDataAndIndex(BmSDK.BmGame.RBarkFlagBase ContextFlags, out BmSDK.BmGame.RBarkConvoData_FlagNode OutData, out int BestIndex)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBarkConvoAction_FlaggedDialogue.GetBestDataAndIndex", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContextFlags, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutData = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkConvoData_FlagNode>(paramsPtr + 8);
        BestIndex = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 16);
        return;
    }

    /// <summary>
    /// Function: AddIndividualFlagsFor
    /// </summary>
    public unsafe void AddIndividualFlagsFor(BmSDK.Engine.Actor Speaker, out BmSDK.BmGame.RBarkFlagBase context)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBarkConvoAction_FlaggedDialogue.AddIndividualFlagsFor", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speaker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        context = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkFlagBase>(paramsPtr + 8);
        return;
    }

    /// <summary>
    /// Function: GBFSSearchHandlePawnRefList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBarkConvo.FVoicePawnRef> GBFSSearchHandlePawnRefList(BmSDK.TArray<BmSDK.BmGame.RBarkConvo.FVoicePawnRef> InList)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBarkConvoAction_FlaggedDialogue.GBFSSearchHandlePawnRefList", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InList, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBarkConvo.FVoicePawnRef>>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: GetPawnRefList
    /// </summary>
    public unsafe void GetPawnRefList(int SearchID, out BmSDK.TArray<BmSDK.BmGame.RBarkConvo.FVoicePawnRef> PawnRefList)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBarkConvoAction_FlaggedDialogue.GetPawnRefList", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SearchID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        PawnRefList = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBarkConvo.FVoicePawnRef>>(paramsPtr + 4);
        return;
    }

    /// <summary>
    /// Function: GetLocalPlayedScore
    /// </summary>
    public unsafe float GetLocalPlayedScore()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBarkConvoAction_FlaggedDialogue.GetLocalPlayedScore", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsFinished
    /// </summary>
    public unsafe bool IsFinished()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBarkConvoAction_FlaggedDialogue.IsFinished", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: Stop
    /// </summary>
    public unsafe void Stop(bool bHardStop, bool bOrphan = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBarkConvoAction_FlaggedDialogue.Stop", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHardStop, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOrphan, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnActivate
    /// </summary>
    public unsafe void OnActivate()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBarkConvoAction_FlaggedDialogue.OnActivate", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: ConvoFlagSource
    /// </summary>
    public enum ConvoFlagSource
    {
        CFS_Base = 0,
        CFS_BaseAndSpeaker = 1,
        CFS_Speaker = 2,
        CFS_MAX = 3,
    }

    /// <summary>
    /// ArrayProperty: ConvoData
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBarkConvoData_FlagNode> ConvoData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBarkConvoData_FlagNode>>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }

    /// <summary>
    /// ByteProperty: FlagSource
    /// </summary>
    public unsafe BmSDK.BmGame.RBarkConvoAction_FlaggedDialogue.ConvoFlagSource FlagSource
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkConvoAction_FlaggedDialogue.ConvoFlagSource>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// IntProperty: HandleID
    /// </summary>
    public unsafe int HandleID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// ObjectProperty: PawnRef
    /// </summary>
    public unsafe BmSDK.BmGame.RBarkConvoPawnRef PawnRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkConvoPawnRef>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// ObjectProperty: triggeredSpeech
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech triggeredSpeech
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }
}
