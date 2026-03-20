#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_CriticalCounter<br/>
/// (size = 244)
/// (flags = 18)
/// </summary>
public partial class RDmgType_CriticalCounter : BmSDK.BmGame.RDmgType_Counter, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_CriticalCounter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_CriticalCounter() { }

    /// <summary>
    /// Constructs a new RDmgType_CriticalCounter
    /// </summary>
    public RDmgType_CriticalCounter(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_CriticalCounter Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_CriticalCounter(nint ptr) : base(ptr) { }

}
