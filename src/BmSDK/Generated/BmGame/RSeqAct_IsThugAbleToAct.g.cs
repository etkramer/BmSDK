#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_IsThugAbleToAct<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_IsThugAbleToAct : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_IsThugAbleToAct", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_IsThugAbleToAct() { }

    /// <summary>
    /// Constructs a new RSeqAct_IsThugAbleToAct
    /// </summary>
    public RSeqAct_IsThugAbleToAct(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_IsThugAbleToAct Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_IsThugAbleToAct(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: BadGuy
    /// </summary>
    public unsafe BmSDK.Engine.Actor BadGuy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }
}
