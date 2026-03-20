#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBarkConvoAction_SpeechBase<br/>
/// (size = 184)
/// (flags = 134217874)
/// </summary>
public partial class RBarkConvoAction_SpeechBase : BmSDK.BmGame.RBarkConvoAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBarkConvoAction_SpeechBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBarkConvoAction_SpeechBase() { }

    /// <summary>
    /// Constructs a new RBarkConvoAction_SpeechBase
    /// </summary>
    public RBarkConvoAction_SpeechBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBarkConvoAction_SpeechBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBarkConvoAction_SpeechBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetCurrentDialogueType
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueType GetCurrentDialogueType()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBarkConvoAction_SpeechBase.GetCurrentDialogueType", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueType>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: StopSpeechCallback
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogue.AkDialogueCallbackResult StopSpeechCallback(int speechId, bool interrupted)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBarkConvoAction_SpeechBase.StopSpeechCallback", true);
        byte* paramsPtr = stackalloc byte[9];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(speechId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(interrupted, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogue.AkDialogueCallbackResult>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: StartLineCallback
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogue.AkDialogueCallbackResult StartLineCallback(BmSDK.Engine.AkDialogueLine dlgLine, BmSDK.Engine.AkDialogueEvent dlgEvent, BmSDK.GameObject Speaker, bool bBarkSquelch)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBarkConvoAction_SpeechBase.StartLineCallback", true);
        byte* paramsPtr = stackalloc byte[29];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgLine, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dlgEvent, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speaker, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBarkSquelch, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogue.AkDialogueCallbackResult>(paramsPtr + 28);
    }

    /// <summary>
    /// Function: SetCoreSpeechOptions
    /// </summary>
    public unsafe void SetCoreSpeechOptions(out BmSDK.Engine.AkDialogue.FAkSpeechOptions Opt)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBarkConvoAction_SpeechBase.SetCoreSpeechOptions", true);
        byte* paramsPtr = stackalloc byte[116];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Opt = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogue.FAkSpeechOptions>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// BoolProperty: bAllowOnKnockedOutPawns
    /// </summary>
    public unsafe bool bAllowOnKnockedOutPawns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 180); }
    }
}
