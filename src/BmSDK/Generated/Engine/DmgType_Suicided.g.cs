#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: DmgType_Suicided<br/>
/// (size = 160)
/// (flags = 0)
/// </summary>
public partial class DmgType_Suicided : BmSDK.Engine.KillZDamageType, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.DmgType_Suicided", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal DmgType_Suicided() { }

    /// <summary>
    /// Constructs a new DmgType_Suicided
    /// </summary>
    public DmgType_Suicided(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, DmgType_Suicided Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected DmgType_Suicided(nint ptr) : base(ptr) { }

}
