#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_RemoveGrate<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_RemoveGrate : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_RemoveGrate", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_RemoveGrate() { }

    /// <summary>
    /// Constructs a new RSeqAct_RemoveGrate
    /// </summary>
    public RSeqAct_RemoveGrate(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_RemoveGrate Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_RemoveGrate(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: TargetGrate
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TargetGrate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }
}
