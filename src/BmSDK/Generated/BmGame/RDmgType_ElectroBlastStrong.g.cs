#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_ElectroBlastStrong<br/>
/// (flags = 0)
/// </summary>
public partial class RDmgType_ElectroBlastStrong : BmSDK.BmGame.RDamageType, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_ElectroBlastStrong", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_ElectroBlastStrong() { }

    /// <summary>
    /// Constructs a new RDmgType_ElectroBlastStrong
    /// </summary>
    public RDmgType_ElectroBlastStrong(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_ElectroBlastStrong Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_ElectroBlastStrong(nint ptr) : base(ptr) { }

}
