#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK;

/// <summary>
/// ABSTRACT Class: Exporter<br/>
/// (size = 84)
/// (flags = 268435593)
/// </summary>
public partial class Exporter : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Core.Exporter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal Exporter() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected Exporter(nint ptr) : base(ptr) { }

}
