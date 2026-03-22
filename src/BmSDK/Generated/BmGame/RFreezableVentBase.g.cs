#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RFreezableVentBase<br/>
/// (size = 460)
/// (flags = 142606483)
/// </summary>
public partial class RFreezableVentBase : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RFreezableVentBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RFreezableVentBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RFreezableVentBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RFreezableVentBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RFreezableVentBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RFreezableVentBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RFreezableVentBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RFreezableVentBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RFreezableVentBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RFreezableVentBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ComponentProperty: SteamPS
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent SteamPS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// ComponentProperty: FrozenPS
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent FrozenPS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// ComponentProperty: VentMeshComponent
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent VentMeshComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }

    /// <summary>
    /// ComponentProperty: Blocker
    /// </summary>
    public unsafe BmSDK.BmGame.RAggGeomCollisionComponent Blocker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAggGeomCollisionComponent>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }

    /// <summary>
    /// FloatProperty: BlockerHeight
    /// </summary>
    public unsafe float BlockerHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// FloatProperty: BlockerWidth
    /// </summary>
    public unsafe float BlockerWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// FloatProperty: BlockerDepth
    /// </summary>
    public unsafe float BlockerDepth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// FloatProperty: BlockerOffset
    /// </summary>
    public unsafe float BlockerOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }
}
