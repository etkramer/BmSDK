#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_MostWantedEndOfGameState<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqAct_MostWantedEndOfGameState : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_MostWantedEndOfGameState", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_MostWantedEndOfGameState() { }

    /// <summary>
    /// Constructs a new RSeqAct_MostWantedEndOfGameState
    /// </summary>
    public RSeqAct_MostWantedEndOfGameState(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_MostWantedEndOfGameState Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_MostWantedEndOfGameState(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: RPC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController RPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ObjectProperty: FlagMan
    /// </summary>
    public unsafe BmSDK.BmGame.RFlagManager FlagMan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RFlagManager>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// ByteProperty: SideStory
    /// </summary>
    public unsafe BmSDK.Engine.Actor.ESideStory SideStory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor.ESideStory>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// ByteProperty: SubChapter
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_MostWantedEndOfGameState.ESubChapter SubChapter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_MostWantedEndOfGameState.ESubChapter>(Ptr + 369); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 369); }
    }

    /// <summary>
    /// IntProperty: Chapter
    /// </summary>
    public unsafe int Chapter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }
}
