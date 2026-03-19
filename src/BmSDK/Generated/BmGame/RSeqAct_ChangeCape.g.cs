#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_ChangeCape<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_ChangeCape : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_ChangeCape", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_ChangeCape() { }

    /// <summary>
    /// Constructs a new RSeqAct_ChangeCape
    /// </summary>
    public RSeqAct_ChangeCape(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_ChangeCape Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_ChangeCape(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: StateChangeData
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT StateChangeData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// StructProperty: CapeChangeData
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CapeChangeData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }
}
