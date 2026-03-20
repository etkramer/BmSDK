#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// ABSTRACT Class: RDesignerWarning<br/>
/// (size = 104)
/// (flags = 19)
/// </summary>
public partial class RDesignerWarning : BmSDK.Engine.LocalMessage, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RDesignerWarning", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDesignerWarning() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDesignerWarning(nint ptr) : base(ptr) { }

}
