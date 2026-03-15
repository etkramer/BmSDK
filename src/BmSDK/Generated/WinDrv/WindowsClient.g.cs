#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.WinDrv;

/// <summary>
/// Class: WindowsClient<br/>
/// (size = 500)
/// (flags = 268435596)
/// </summary>
public partial class WindowsClient : BmSDK.Engine.Client, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "WinDrv.WindowsClient", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal WindowsClient() { }

    /// <summary>
    /// Constructs a new WindowsClient
    /// </summary>
    public WindowsClient(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, WindowsClient Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected WindowsClient(nint ptr) : base(ptr) { }

}
