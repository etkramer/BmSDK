#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_SuperStunFinalCharge<br/>
/// (size = 236)
/// (flags = 0)
/// </summary>
public partial class RDmgType_SuperStunFinalCharge : BmSDK.BmGame.RDmgType_SuperStunFinal, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_SuperStunFinalCharge", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_SuperStunFinalCharge() { }

    /// <summary>
    /// Constructs a new RDmgType_SuperStunFinalCharge
    /// </summary>
    public RDmgType_SuperStunFinalCharge(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_SuperStunFinalCharge Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_SuperStunFinalCharge(nint ptr) : base(ptr) { }

}
