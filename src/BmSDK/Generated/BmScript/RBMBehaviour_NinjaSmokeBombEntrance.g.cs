#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RBMBehaviour_NinjaSmokeBombEntrance<br/>
/// (size = 424)
/// (flags = 8210)
/// </summary>
public partial class RBMBehaviour_NinjaSmokeBombEntrance : BmSDK.BmGame.RBMBehaviour_LunaticEntrance, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RBMBehaviour_NinjaSmokeBombEntrance", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_NinjaSmokeBombEntrance() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_NinjaSmokeBombEntrance
    /// </summary>
    public RBMBehaviour_NinjaSmokeBombEntrance(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_NinjaSmokeBombEntrance Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_NinjaSmokeBombEntrance(nint ptr) : base(ptr) { }

}
