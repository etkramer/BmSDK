#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_ReformDestructibleProp<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_ReformDestructibleProp : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_ReformDestructibleProp", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_ReformDestructibleProp() { }

    /// <summary>
    /// Constructs a new RSeqAct_ReformDestructibleProp
    /// </summary>
    public RSeqAct_ReformDestructibleProp(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_ReformDestructibleProp Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_ReformDestructibleProp(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: DestructiblePropsToReform
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RDestructibleProp> DestructiblePropsToReform
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RDestructibleProp>>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }
}
