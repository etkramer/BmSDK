#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RBMBehaviour_CityRunAway<br/>
/// (size = 1008)
/// (flags = 8210)
/// </summary>
public partial class RBMBehaviour_CityRunAway : BmSDK.BmGame.RBMBehaviour_CityRunAwayBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RBMBehaviour_CityRunAway", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_CityRunAway() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_CityRunAway
    /// </summary>
    public RBMBehaviour_CityRunAway(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_CityRunAway Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_CityRunAway(nint ptr) : base(ptr) { }

}
