#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: DmgType_Crushed<br/>
/// (flags = 0)
/// </summary>
public partial class DmgType_Crushed : BmSDK.Engine.DamageType, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.DmgType_Crushed", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal DmgType_Crushed() { }

    /// <summary>
    /// Constructs a new DmgType_Crushed
    /// </summary>
    public DmgType_Crushed(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, DmgType_Crushed Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected DmgType_Crushed(nint ptr) : base(ptr) { }

}
