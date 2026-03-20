#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_LinkGangPoints<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_LinkGangPoints : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_LinkGangPoints", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_LinkGangPoints() { }

    /// <summary>
    /// Constructs a new RSeqAct_LinkGangPoints
    /// </summary>
    public RSeqAct_LinkGangPoints(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_LinkGangPoints Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_LinkGangPoints(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: Point1
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGangInteractPointBase> Point1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGangInteractPointBase>>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ObjectProperty: Point2
    /// </summary>
    public unsafe BmSDK.BmGame.RGangInteractPointBase Point2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGangInteractPointBase>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }
}
