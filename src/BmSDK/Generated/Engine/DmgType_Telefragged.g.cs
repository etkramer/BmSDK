#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: DmgType_Telefragged<br/>
/// (flags = 0)
/// </summary>
public partial class DmgType_Telefragged : BmSDK.Engine.DamageType, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.DmgType_Telefragged", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal DmgType_Telefragged() { }

    /// <summary>
    /// Constructs a new DmgType_Telefragged
    /// </summary>
    public DmgType_Telefragged(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, DmgType_Telefragged Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected DmgType_Telefragged(nint ptr) : base(ptr) { }

}
