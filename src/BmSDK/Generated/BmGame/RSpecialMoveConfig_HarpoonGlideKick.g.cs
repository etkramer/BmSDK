#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveConfig_HarpoonGlideKick<br/>
/// (size = 644)
/// (flags = 4114)
/// </summary>
public partial class RSpecialMoveConfig_HarpoonGlideKick : BmSDK.BmGame.RSpecialMoveConfig_HarpoonThug, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveConfig_HarpoonGlideKick", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_HarpoonGlideKick() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_HarpoonGlideKick
    /// </summary>
    public RSpecialMoveConfig_HarpoonGlideKick(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_HarpoonGlideKick Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_HarpoonGlideKick(nint ptr) : base(ptr) { }

}
