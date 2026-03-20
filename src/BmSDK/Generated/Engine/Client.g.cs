#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// ABSTRACT Class: Client<br/>
/// (size = 120)
/// (flags = 268435589)
/// </summary>
public partial class Client : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.Client", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal Client() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected Client(nint ptr) : base(ptr) { }

}
