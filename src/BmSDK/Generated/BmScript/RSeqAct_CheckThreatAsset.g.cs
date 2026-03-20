#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_CheckThreatAsset<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqAct_CheckThreatAsset : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_CheckThreatAsset", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_CheckThreatAsset() { }

    /// <summary>
    /// Constructs a new RSeqAct_CheckThreatAsset
    /// </summary>
    public RSeqAct_CheckThreatAsset(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_CheckThreatAsset Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_CheckThreatAsset(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: ThreatAsset
    /// </summary>
    public unsafe BmSDK.GameObject ThreatAsset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }
}
