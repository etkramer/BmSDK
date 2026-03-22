#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// ABSTRACT Class: ParticleEventManager<br/>
/// (size = 428)
/// (flags = 142606483)
/// </summary>
public partial class ParticleEventManager : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleEventManager", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleEventManager() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleEventManager(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ParticleEventManager>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleEventManager>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ParticleEventManager>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleEventManager>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleEventManager>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ParticleEventManager>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleEventManager>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: HandleParticleModuleEventSendToGame
    /// </summary>
    public unsafe virtual void HandleParticleModuleEventSendToGame(BmSDK.Engine.ParticleModuleEventSendToGame InEvent, out System.Numerics.Vector3 InCollideDirection, out System.Numerics.Vector3 InHitLocation, out System.Numerics.Vector3 InHitNormal, out BmSDK.FName InBoneName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.ParticleEventManager.HandleParticleModuleEventSendToGame", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InEvent, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        InCollideDirection = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 4);
        InHitLocation = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 16);
        InHitNormal = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 28);
        InBoneName = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 40);
        return;
    }
}
