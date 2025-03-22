using System;

namespace BmSDK.Framework;

public abstract class IManagedPlugin
{
    public virtual void OnLoad() {}
    public virtual void OnUnload() {}

    // public virtual void OnTick(float deltaTime) {}
}
