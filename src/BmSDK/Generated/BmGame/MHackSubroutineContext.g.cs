#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MHackSubroutineContext<br/>
/// (flags = 0)
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
    /// Constructs a new MHackSubroutineContext
    /// </summary>
    public MHackSubroutineContext(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MHackSubroutineContext Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MHackSubroutineContext(nint ptr) : base(ptr) { }

}
