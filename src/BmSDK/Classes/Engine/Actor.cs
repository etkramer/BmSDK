using BmSDK.Framework;

namespace BmSDK.Engine;

public partial class Actor
{
    /// <inheritdoc cref="GameObject.Clone"/>
    public new Actor Clone() => Game.SpawnActor(Class, Location, Rotation, this, Owner);
}
