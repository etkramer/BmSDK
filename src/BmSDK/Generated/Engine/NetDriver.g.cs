#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// ABSTRACT Class: NetDriver<br/>
/// (size = 388)
/// (flags = 268435597)
/// </summary>
public partial class NetDriver : BmSDK.Subsystem, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.NetDriver", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal NetDriver() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected NetDriver(nint ptr) : base(ptr) { }

}
