#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RDmgType_JokerBeatdownGas<br/>
/// (size = 120)
/// (flags = 18)
/// </summary>
public partial class RDmgType_JokerBeatdownGas : BmSDK.BmGame.RDamageType, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RDmgType_JokerBeatdownGas", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_JokerBeatdownGas() { }

    /// <summary>
    /// Constructs a new RDmgType_JokerBeatdownGas
    /// </summary>
    public RDmgType_JokerBeatdownGas(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_JokerBeatdownGas Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_JokerBeatdownGas(nint ptr) : base(ptr) { }

}
