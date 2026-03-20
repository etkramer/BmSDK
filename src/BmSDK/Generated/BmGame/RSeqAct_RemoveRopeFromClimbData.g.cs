#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_RemoveRopeFromClimbData<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqAct_RemoveRopeFromClimbData : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_RemoveRopeFromClimbData", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_RemoveRopeFromClimbData() { }

    /// <summary>
    /// Constructs a new RSeqAct_RemoveRopeFromClimbData
    /// </summary>
    public RSeqAct_RemoveRopeFromClimbData(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_RemoveRopeFromClimbData Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_RemoveRopeFromClimbData(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Rope
    /// </summary>
    public unsafe BmSDK.Engine.Actor Rope
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }
}
