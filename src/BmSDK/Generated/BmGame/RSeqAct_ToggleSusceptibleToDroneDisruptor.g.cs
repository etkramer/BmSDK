#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_ToggleSusceptibleToDroneDisruptor<br/>
/// (size = 352)
/// (flags = 8210)
/// </summary>
public partial class RSeqAct_ToggleSusceptibleToDroneDisruptor : BmSDK.Engine.SeqAct_Toggle, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_ToggleSusceptibleToDroneDisruptor", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_ToggleSusceptibleToDroneDisruptor() { }

    /// <summary>
    /// Constructs a new RSeqAct_ToggleSusceptibleToDroneDisruptor
    /// </summary>
    public RSeqAct_ToggleSusceptibleToDroneDisruptor(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_ToggleSusceptibleToDroneDisruptor Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_ToggleSusceptibleToDroneDisruptor(nint ptr) : base(ptr) { }

}
