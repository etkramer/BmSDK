#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieGadgetReward<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RGFxMovieGadgetReward : BmSDK.BmGame.RGFxMovie, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieGadgetReward", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieGadgetReward() { }

    /// <summary>
    /// Constructs a new RGFxMovieGadgetReward
    /// </summary>
    public RGFxMovieGadgetReward(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieGadgetReward Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieGadgetReward(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: ParentSeqAct
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ParentSeqAct
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }
}
