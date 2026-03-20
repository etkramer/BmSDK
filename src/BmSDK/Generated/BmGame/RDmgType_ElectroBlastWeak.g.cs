#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_ElectroBlastWeak<br/>
/// (size = 216)
/// (flags = 0)
/// </summary>
public partial class RDmgType_ElectroBlastWeak : BmSDK.BmGame.RDamageType, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_ElectroBlastWeak", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_ElectroBlastWeak() { }

    /// <summary>
    /// Constructs a new RDmgType_ElectroBlastWeak
    /// </summary>
    public RDmgType_ElectroBlastWeak(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_ElectroBlastWeak Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_ElectroBlastWeak(nint ptr) : base(ptr) { }

}
