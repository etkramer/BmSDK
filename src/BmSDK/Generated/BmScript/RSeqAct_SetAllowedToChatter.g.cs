#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_SetAllowedToChatter<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqAct_SetAllowedToChatter : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_SetAllowedToChatter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_SetAllowedToChatter() { }

    /// <summary>
    /// Constructs a new RSeqAct_SetAllowedToChatter
    /// </summary>
    public RSeqAct_SetAllowedToChatter(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_SetAllowedToChatter Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_SetAllowedToChatter(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: Pawns
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI> Pawns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI>>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }
}
