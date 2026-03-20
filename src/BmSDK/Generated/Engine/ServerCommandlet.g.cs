#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ServerCommandlet<br/>
/// (size = 168)
/// (flags = 268435624)
/// </summary>
public partial class ServerCommandlet : BmSDK.Commandlet, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ServerCommandlet", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ServerCommandlet() { }

    /// <summary>
    /// Constructs a new ServerCommandlet
    /// </summary>
    public ServerCommandlet(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ServerCommandlet Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ServerCommandlet(nint ptr) : base(ptr) { }

}
