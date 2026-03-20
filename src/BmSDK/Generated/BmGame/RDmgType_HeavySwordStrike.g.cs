#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_HeavySwordStrike<br/>
/// (size = 236)
/// (flags = 0)
/// </summary>
public partial class RDmgType_HeavySwordStrike : BmSDK.BmGame.RDmgType_HeavyStrike, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_HeavySwordStrike", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_HeavySwordStrike() { }

    /// <summary>
    /// Constructs a new RDmgType_HeavySwordStrike
    /// </summary>
    public RDmgType_HeavySwordStrike(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_HeavySwordStrike Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_HeavySwordStrike(nint ptr) : base(ptr) { }

}
