#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqEvent_KilledByElectricFloor<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqEvent_KilledByElectricFloor : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqEvent_KilledByElectricFloor", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvent_KilledByElectricFloor() { }

    /// <summary>
    /// Constructs a new RSeqEvent_KilledByElectricFloor
    /// </summary>
    public RSeqEvent_KilledByElectricFloor(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvent_KilledByElectricFloor Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvent_KilledByElectricFloor(nint ptr) : base(ptr) { }

}
