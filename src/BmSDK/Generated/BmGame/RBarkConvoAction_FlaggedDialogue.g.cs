#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBarkConvoAction_FlaggedDialogue<br/>
/// (size = 0)
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
    /// ArrayProperty: ConvoData
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>> ConvoData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }

    /// <summary>
    /// ByteProperty: FlagSource
    /// </summary>
    public unsafe byte FlagSource
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 200); }
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
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PawnRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// ObjectProperty: triggeredSpeech
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT triggeredSpeech
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }
}
