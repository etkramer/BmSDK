#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqCond_CheckChapter<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqCond_CheckChapter : BmSDK.Engine.SequenceCondition, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqCond_CheckChapter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqCond_CheckChapter() { }

    /// <summary>
    /// Constructs a new RSeqCond_CheckChapter
    /// </summary>
    public RSeqCond_CheckChapter(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqCond_CheckChapter Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqCond_CheckChapter(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: SideStory
    /// </summary>
    public unsafe BmSDK.Engine.Actor.ESideStory SideStory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor.ESideStory>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// ByteProperty: SubChapter
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_MostWantedEndOfGameState.ESubChapter SubChapter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_MostWantedEndOfGameState.ESubChapter>(Ptr + 325); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 325); }
    }

    /// <summary>
    /// IntProperty: Chapter
    /// </summary>
    public unsafe int Chapter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }
}
