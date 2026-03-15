#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.OnlineSubsystemPC;

/// <summary>
/// Class: _OnlineSubsystemPC<br/>
/// (size = 744)
/// (flags = 132)
/// </summary>
public partial class _OnlineSubsystemPC : BmSDK.IpDrv.OnlineSubsystemCommonImpl, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "OnlineSubsystemPC.OnlineSubsystemPC", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal _OnlineSubsystemPC() { }

    /// <summary>
    /// Constructs a new _OnlineSubsystemPC
    /// </summary>
    public _OnlineSubsystemPC(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, _OnlineSubsystemPC Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected _OnlineSubsystemPC(nint ptr) : base(ptr) { }

}
