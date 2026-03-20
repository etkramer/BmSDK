#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// ABSTRACT Class: NetConnection<br/>
/// (size = 44792)
/// (flags = 268435597)
/// </summary>
public partial class NetConnection : BmSDK.Engine.Player, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.NetConnection", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal NetConnection() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected NetConnection(nint ptr) : base(ptr) { }

}
