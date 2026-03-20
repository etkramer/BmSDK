#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_ToggleRoadLinkAlt<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqAct_ToggleRoadLinkAlt : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_ToggleRoadLinkAlt", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_ToggleRoadLinkAlt() { }

    /// <summary>
    /// Constructs a new RSeqAct_ToggleRoadLinkAlt
    /// </summary>
    public RSeqAct_ToggleRoadLinkAlt(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_ToggleRoadLinkAlt Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_ToggleRoadLinkAlt(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: RoadLink
    /// </summary>
    public unsafe BmSDK.BmGame.RRoadLink RoadLink
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadLink>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ObjectProperty: RoadLink2
    /// </summary>
    public unsafe BmSDK.BmGame.RRoadLink RoadLink2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadLink>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// ObjectProperty: RoadLink3
    /// </summary>
    public unsafe BmSDK.BmGame.RRoadLink RoadLink3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadLink>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// ObjectProperty: RoadLink4
    /// </summary>
    public unsafe BmSDK.BmGame.RRoadLink RoadLink4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadLink>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// ArrayProperty: RoadLinks
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RRoadLink> RoadLinks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RRoadLink>>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }
}
