#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_CriticalStrike<br/>
/// (size = 140)
/// (flags = 18)
/// </summary>
public partial class RDmgType_CriticalStrike : BmSDK.BmGame.RDmgType_HeavyStrike, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_CriticalStrike", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_CriticalStrike() { }

    /// <summary>
    /// Constructs a new RDmgType_CriticalStrike
    /// </summary>
    public RDmgType_CriticalStrike(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_CriticalStrike Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_CriticalStrike(nint ptr) : base(ptr) { }

}
