#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SmokeTestCommandlet<br/>
/// (size = 168)
/// (flags = 268435624)
/// </summary>
public partial class SmokeTestCommandlet : BmSDK.Commandlet, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SmokeTestCommandlet", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SmokeTestCommandlet() { }

    /// <summary>
    /// Constructs a new SmokeTestCommandlet
    /// </summary>
    public SmokeTestCommandlet(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SmokeTestCommandlet Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SmokeTestCommandlet(nint ptr) : base(ptr) { }

}
