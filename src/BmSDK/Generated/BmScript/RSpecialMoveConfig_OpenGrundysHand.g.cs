#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSpecialMoveConfig_OpenGrundysHand<br/>
/// (size = 296)
/// (flags = 4114)
/// </summary>
public partial class RSpecialMoveConfig_OpenGrundysHand : BmSDK.BmGame.RSpecialMoveConfig, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSpecialMoveConfig_OpenGrundysHand", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_OpenGrundysHand() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_OpenGrundysHand
    /// </summary>
    public RSpecialMoveConfig_OpenGrundysHand(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_OpenGrundysHand Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_OpenGrundysHand(nint ptr) : base(ptr) { }

}
