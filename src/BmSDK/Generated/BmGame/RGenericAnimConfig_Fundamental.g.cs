#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RGenericAnimConfig_Fundamental<br/>
/// (size = 68)
/// (flags = 19)
/// </summary>
public partial class RGenericAnimConfig_Fundamental : BmSDK.BmGame.RPoseConfig, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGenericAnimConfig_Fundamental", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGenericAnimConfig_Fundamental() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGenericAnimConfig_Fundamental(nint ptr) : base(ptr) { }

}
