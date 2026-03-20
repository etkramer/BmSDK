#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_SetSideStoryWithoutMapMarker<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_SetSideStoryWithoutMapMarker : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_SetSideStoryWithoutMapMarker", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_SetSideStoryWithoutMapMarker() { }

    /// <summary>
    /// Constructs a new RSeqAct_SetSideStoryWithoutMapMarker
    /// </summary>
    public RSeqAct_SetSideStoryWithoutMapMarker(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_SetSideStoryWithoutMapMarker Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_SetSideStoryWithoutMapMarker(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: TheSideStory
    /// </summary>
    public unsafe BmSDK.BmGame.RSideStoryManager.ActiveSideStoryEnum TheSideStory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSideStoryManager.ActiveSideStoryEnum>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ByteProperty: OnlyIfCurrentSideStory
    /// </summary>
    public unsafe BmSDK.BmGame.RSideStoryManager.ActiveSideStoryEnum OnlyIfCurrentSideStory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSideStoryManager.ActiveSideStoryEnum>(Ptr + 353); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 353); }
    }
}
