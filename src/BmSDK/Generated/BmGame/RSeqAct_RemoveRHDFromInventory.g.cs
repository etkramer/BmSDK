#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_RemoveRHDFromInventory<br/>
/// (size = 352)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_RemoveRHDFromInventory : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_RemoveRHDFromInventory", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_RemoveRHDFromInventory() { }

    /// <summary>
    /// Constructs a new RSeqAct_RemoveRHDFromInventory
    /// </summary>
    public RSeqAct_RemoveRHDFromInventory(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_RemoveRHDFromInventory Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_RemoveRHDFromInventory(nint ptr) : base(ptr) { }

}
