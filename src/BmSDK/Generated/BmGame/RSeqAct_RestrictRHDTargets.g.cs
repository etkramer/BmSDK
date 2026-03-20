#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_RestrictRHDTargets<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqAct_RestrictRHDTargets : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_RestrictRHDTargets", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_RestrictRHDTargets() { }

    /// <summary>
    /// Constructs a new RSeqAct_RestrictRHDTargets
    /// </summary>
    public RSeqAct_RestrictRHDTargets(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_RestrictRHDTargets Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_RestrictRHDTargets(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: AllowedTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> AllowedTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ArrayProperty: BlockedTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> BlockedTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }
}
