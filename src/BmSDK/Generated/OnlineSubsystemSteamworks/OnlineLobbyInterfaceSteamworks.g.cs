#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.OnlineSubsystemSteamworks;

/// <summary>
/// Class: OnlineLobbyInterfaceSteamworks<br/>
/// (flags = 0)
/// </summary>
public partial class OnlineLobbyInterfaceSteamworks : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "OnlineSubsystemSteamworks.OnlineLobbyInterfaceSteamworks", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal OnlineLobbyInterfaceSteamworks() { }

    /// <summary>
    /// Constructs a new OnlineLobbyInterfaceSteamworks
    /// </summary>
    public OnlineLobbyInterfaceSteamworks(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, OnlineLobbyInterfaceSteamworks Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected OnlineLobbyInterfaceSteamworks(nint ptr) : base(ptr) { }

}
