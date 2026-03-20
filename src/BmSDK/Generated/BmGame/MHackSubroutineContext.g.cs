#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: MHackSubroutineContext<br/>
/// (size = 84)
/// (flags = 134221971)
/// </summary>
public partial class MHackSubroutineContext : BmSDK.BmGame.RConfig, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MHackSubroutineContext", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MHackSubroutineContext() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MHackSubroutineContext(nint ptr) : base(ptr) { }

}
