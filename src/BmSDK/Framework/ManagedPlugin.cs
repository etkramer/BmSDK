namespace BmSDK.Framework;

public abstract class ManagedPlugin
{
    /// <summary>
    /// Called once when the engine first becomes ready. Should be used to perform basic setup
    /// that doesn't need access to the game world.
    /// </summary>
    public virtual void OnLoad() { }

    /// <summary>
    /// Called when we first load into the menu, after all actors have begun play.
    /// </summary>
    public virtual void OnGameStart() { }

    // /// <summary>
    // /// Called every time we load into a world, after all actors have begun play.
    // /// </summary>
    // public virtual void OnBeginPlay() { }

    // /// <summary>
    // /// Called once every world tick.
    // /// </summary>
    // public virtual void OnTick() { }
}
