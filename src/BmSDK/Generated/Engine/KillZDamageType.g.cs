#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: KillZDamageType<br/>
/// (flags = 0)
/// </summary>
public partial class KillZDamageType : BmSDK.Engine.DamageType, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.KillZDamageType", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal KillZDamageType() { }

    /// <summary>
    /// Constructs a new KillZDamageType
    /// </summary>
    public KillZDamageType(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, KillZDamageType Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected KillZDamageType(nint ptr) : base(ptr) { }

}
