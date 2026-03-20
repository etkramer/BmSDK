#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: AkSDEntityPawnsEnemySpottedPlayer<br/>
/// (size = 268)
/// (flags = 134221970)
/// </summary>
public partial class AkSDEntityPawnsEnemySpottedPlayer : BmSDK.AkAudio.AkSDEntityPawnsEnemy, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.AkSDEntityPawnsEnemySpottedPlayer", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkSDEntityPawnsEnemySpottedPlayer() { }

    /// <summary>
    /// Constructs a new AkSDEntityPawnsEnemySpottedPlayer
    /// </summary>
    public AkSDEntityPawnsEnemySpottedPlayer(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkSDEntityPawnsEnemySpottedPlayer Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkSDEntityPawnsEnemySpottedPlayer(nint ptr) : base(ptr) { }

}
