namespace BmSDK.Framework;

public abstract class ManagedPlugin
{
    /// <summary>
    /// Called once when the engine first becomes ready. Should be used to perform basic setup
    /// that doesn't need access to the game world.
    /// </summary>
    public virtual void OnReady() { }

    /// <summary>
    /// Called once every world tick.
    /// </summary>
    public virtual void OnTick() { }
}
