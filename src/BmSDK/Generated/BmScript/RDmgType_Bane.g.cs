#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RDmgType_Bane<br/>
/// (size = 120)
/// (flags = 18)
/// </summary>
public partial class RDmgType_Bane : BmSDK.BmGame.RDamageType, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RDmgType_Bane", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_Bane() { }

    /// <summary>
    /// Constructs a new RDmgType_Bane
    /// </summary>
    public RDmgType_Bane(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_Bane Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_Bane(nint ptr) : base(ptr) { }

}
