namespace BmSDK.Framework;

/// <summary>
/// Base class for user-defined scripts.
/// </summary>
public abstract class Script
{
    /// <summary>
    /// Name of this script, used mainly for logging. Defaults to the name of
    /// the original .cs file, but can be customized using the [Script] attribute.
    /// </summary>
    public string Name { get; set; } = "Script";

    /// <summary>
    /// Script entry point, called once when the engine first becomes ready.
    /// Should be used to perform basic setup that doesn't need access to the game world.
    /// </summary>
    public virtual void Main() { }

    /// <summary>
    /// Called when we first load into the main menu, after all actors have begun play.
    /// </summary>
    public virtual void OnEnterMenu() { }

    /// <summary>
    /// Called every time we load into a new world, after all actors have begun play.
    /// Does not get called when levels are streamed in dynamically.
    /// </summary>
    public virtual void OnEnterGame() { }

    /// <summary>
    /// Called once every world tick.
    /// </summary>
    public virtual void OnTick() { }

    /// <summary>
    /// Called every time a key is pressed.
    /// </summary>
    public virtual void OnKeyDown(Keys key) { }

    /// <summary>
    /// Called when the hot reloading system uninstalls
    /// the old version of the script class
    /// </summary>
    public virtual void OnUnload() { }

    /// <summary>
    /// Called only when the hot reloading system installs
    /// the new verison of the scripts class
    /// </summary>
    public virtual void OnLoad() { }
}
