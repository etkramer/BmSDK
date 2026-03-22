#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RDmgType_HarleyLedgeKick<br/>
/// (size = 140)
/// (flags = 18)
/// </summary>
public partial class RDmgType_HarleyLedgeKick : BmSDK.BmGame.RDmgType_Strike, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RDmgType_HarleyLedgeKick", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_HarleyLedgeKick() { }

    /// <summary>
    /// Constructs a new RDmgType_HarleyLedgeKick
    /// </summary>
    public RDmgType_HarleyLedgeKick(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_HarleyLedgeKick Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_HarleyLedgeKick(nint ptr) : base(ptr) { }

}
