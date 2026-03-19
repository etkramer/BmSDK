#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_FlameManagerBase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_FlameManagerBase : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_FlameManagerBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_FlameManagerBase() { }

    /// <summary>
    /// Constructs a new RSeqAct_FlameManagerBase
    /// </summary>
    public RSeqAct_FlameManagerBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_FlameManagerBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_FlameManagerBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: RPC
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }
}
