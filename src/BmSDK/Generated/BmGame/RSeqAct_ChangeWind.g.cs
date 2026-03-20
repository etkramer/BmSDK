#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_ChangeWind<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqAct_ChangeWind : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_ChangeWind", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_ChangeWind() { }

    /// <summary>
    /// Constructs a new RSeqAct_ChangeWind
    /// </summary>
    public RSeqAct_ChangeWind(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_ChangeWind Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_ChangeWind(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: NewWindState
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.FRBasicWindConfig NewWindState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.FRBasicWindConfig>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }
}
