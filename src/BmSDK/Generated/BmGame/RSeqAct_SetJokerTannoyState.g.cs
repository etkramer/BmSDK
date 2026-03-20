#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_SetJokerTannoyState<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_SetJokerTannoyState : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_SetJokerTannoyState", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_SetJokerTannoyState() { }

    /// <summary>
    /// Constructs a new RSeqAct_SetJokerTannoyState
    /// </summary>
    public RSeqAct_SetJokerTannoyState(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_SetJokerTannoyState Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_SetJokerTannoyState(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: ThisTannoy
    /// </summary>
    public unsafe BmSDK.BmGame.RJokerTannoy ThisTannoy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RJokerTannoy>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }
}
