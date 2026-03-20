#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: AkSDEntityPawnsEnemyFiring<br/>
/// (flags = 0)
/// </summary>
public partial class AkSDEntityPawnsEnemyFiring : BmSDK.AkAudio.AkSDEntityPawnsEnemy, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.AkSDEntityPawnsEnemyFiring", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkSDEntityPawnsEnemyFiring() { }

    /// <summary>
    /// Constructs a new AkSDEntityPawnsEnemyFiring
    /// </summary>
    public AkSDEntityPawnsEnemyFiring(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkSDEntityPawnsEnemyFiring Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkSDEntityPawnsEnemyFiring(nint ptr) : base(ptr) { }

}
