#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_LoadCapeAnims<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqAct_LoadCapeAnims : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_LoadCapeAnims", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_LoadCapeAnims() { }

    /// <summary>
    /// Constructs a new RSeqAct_LoadCapeAnims
    /// </summary>
    public RSeqAct_LoadCapeAnims(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_LoadCapeAnims Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_LoadCapeAnims(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: CapeAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet CapeAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }
}
