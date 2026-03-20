#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_LaserGrid_Blue<br/>
/// (size = 220)
/// (flags = 0)
/// </summary>
public partial class RDmgType_LaserGrid_Blue : BmSDK.BmGame.RDmgType_Electricity, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_LaserGrid_Blue", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_LaserGrid_Blue() { }

    /// <summary>
    /// Constructs a new RDmgType_LaserGrid_Blue
    /// </summary>
    public RDmgType_LaserGrid_Blue(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_LaserGrid_Blue Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_LaserGrid_Blue(nint ptr) : base(ptr) { }

}
