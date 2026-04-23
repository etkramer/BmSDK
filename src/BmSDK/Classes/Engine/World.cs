using BmSDK.Framework;

namespace BmSDK.Engine;

public partial class World
{
    /// <summary>
    /// The level that newly-spawned actors are placed into. Swap this around
    /// <see cref="Game.SpawnActor"/> to target a specific streaming level.
    /// </summary>
    public Level CurrentLevel
    {
        get => MarshalUtil.ToManaged<Level>(Ptr + 88);
        set => MarshalUtil.ToUnmanaged(value, Ptr + 88);
    }
}
