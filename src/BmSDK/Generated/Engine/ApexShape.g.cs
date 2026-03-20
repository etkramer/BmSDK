#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// ABSTRACT Class: ApexShape<br/>
/// (size = 84)
/// (flags = 134221971)
/// </summary>
public partial class ApexShape : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ApexShape", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ApexShape() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ApexShape(nint ptr) : base(ptr) { }

}
