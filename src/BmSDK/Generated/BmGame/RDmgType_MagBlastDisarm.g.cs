#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_MagBlastDisarm<br/>
/// (size = 216)
/// (flags = 0)
/// </summary>
public partial class RDmgType_MagBlastDisarm : BmSDK.BmGame.RDamageType, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_MagBlastDisarm", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_MagBlastDisarm() { }

    /// <summary>
    /// Constructs a new RDmgType_MagBlastDisarm
    /// </summary>
    public RDmgType_MagBlastDisarm(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_MagBlastDisarm Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_MagBlastDisarm(nint ptr) : base(ptr) { }

}
