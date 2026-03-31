using BmSDK.Framework;

namespace BmSDK.Engine;

public partial class Actor
{
    /// <summary>
    /// Returns true if this actor is part of an active level in the current world.
    /// Returns false for actors that are in memory from a <see cref="Game.LoadPackage"/> call
    /// but whose level has not been streamed into the world.
    /// </summary>
    public bool IsSpawned => Outer?.Outer is World;

    /// <inheritdoc cref="GameObject.Clone"/>
    public new Actor Clone() => Game.SpawnActor(Class, Location, Rotation, this, Owner);
}
