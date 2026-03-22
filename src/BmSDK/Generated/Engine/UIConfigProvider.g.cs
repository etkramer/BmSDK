#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// ABSTRACT Class: UIConfigProvider<br/>
/// (size = 76)
/// (flags = 134217883)
/// </summary>
public partial class UIConfigProvider : BmSDK.Engine.UIDataProvider, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.UIConfigProvider", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal UIConfigProvider() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected UIConfigProvider(nint ptr) : base(ptr) { }

}
