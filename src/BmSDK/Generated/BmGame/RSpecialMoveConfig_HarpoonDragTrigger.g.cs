#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveConfig_HarpoonDragTrigger<br/>
/// (size = 356)
/// (flags = 4114)
/// </summary>
public partial class RSpecialMoveConfig_HarpoonDragTrigger : BmSDK.BmGame.RSpecialMoveConfig_HarpoonDragObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveConfig_HarpoonDragTrigger", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_HarpoonDragTrigger() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_HarpoonDragTrigger
    /// </summary>
    public RSpecialMoveConfig_HarpoonDragTrigger(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_HarpoonDragTrigger Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_HarpoonDragTrigger(nint ptr) : base(ptr) { }

}
