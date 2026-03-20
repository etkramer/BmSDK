#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: PlayerManagerInteraction<br/>
/// (flags = 0)
/// </summary>
public partial class PlayerManagerInteraction : BmSDK.Engine.Interaction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.PlayerManagerInteraction", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal PlayerManagerInteraction() { }

    /// <summary>
    /// Constructs a new PlayerManagerInteraction
    /// </summary>
    public PlayerManagerInteraction(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, PlayerManagerInteraction Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected PlayerManagerInteraction(nint ptr) : base(ptr) { }

}
