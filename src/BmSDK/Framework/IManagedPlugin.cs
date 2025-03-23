namespace BmSDK.Framework;

public interface IManagedPlugin
{
    public void OnLoad();
    public void OnUnload();

    // public virtual void OnTick(float deltaTime) {}
}
