#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSpecialMoveConfig_AttachPlayerToPawn<br/>
/// (size = 400)
/// (flags = 4114)
/// </summary>
public partial class RSpecialMoveConfig_AttachPlayerToPawn : BmSDK.BmGame.RSpecialMoveConfig, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSpecialMoveConfig_AttachPlayerToPawn", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_AttachPlayerToPawn() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_AttachPlayerToPawn
    /// </summary>
    public RSpecialMoveConfig_AttachPlayerToPawn(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_AttachPlayerToPawn Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_AttachPlayerToPawn(nint ptr) : base(ptr) { }

}
