#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_QuickSwordStrike<br/>
/// (size = 236)
/// (flags = 0)
/// </summary>
public partial class RDmgType_QuickSwordStrike : BmSDK.BmGame.RDmgType_QuickStrike, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_QuickSwordStrike", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_QuickSwordStrike() { }

    /// <summary>
    /// Constructs a new RDmgType_QuickSwordStrike
    /// </summary>
    public RDmgType_QuickSwordStrike(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_QuickSwordStrike Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_QuickSwordStrike(nint ptr) : base(ptr) { }

}
