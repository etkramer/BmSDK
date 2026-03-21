#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBM2IdleLookAtConfigs<br/>
/// (size = 44)
/// (flags = 18)
/// </summary>
public partial class RBM2IdleLookAtConfigs : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBM2IdleLookAtConfigs", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBM2IdleLookAtConfigs() { }

    /// <summary>
    /// Constructs a new RBM2IdleLookAtConfigs
    /// </summary>
    public RBM2IdleLookAtConfigs(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBM2IdleLookAtConfigs Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBM2IdleLookAtConfigs(nint ptr) : base(ptr) { }

}
