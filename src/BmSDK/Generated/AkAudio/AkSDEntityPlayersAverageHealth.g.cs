#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: AkSDEntityPlayersAverageHealth<br/>
/// (size = 252)
/// (flags = 0)
/// </summary>
public partial class AkSDEntityPlayersAverageHealth : BmSDK.AkAudio.AkSDEntityPlayerBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.AkSDEntityPlayersAverageHealth", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkSDEntityPlayersAverageHealth() { }

    /// <summary>
    /// Constructs a new AkSDEntityPlayersAverageHealth
    /// </summary>
    public AkSDEntityPlayersAverageHealth(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkSDEntityPlayersAverageHealth Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkSDEntityPlayersAverageHealth(nint ptr) : base(ptr) { }

}
