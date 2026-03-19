#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_MostWantedEndOfGameState<br/>
/// (size = 0)
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
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ObjectProperty: FlagMan
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FlagMan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// ByteProperty: SideStory
    /// </summary>
    public unsafe byte SideStory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// ByteProperty: SubChapter
    /// </summary>
    public unsafe byte SubChapter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 369); }
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
