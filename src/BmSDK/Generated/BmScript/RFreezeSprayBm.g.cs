#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RFreezeSprayBm<br/>
/// (flags = 0)
/// </summary>
public partial class RFreezeSprayBm : BmSDK.BmGame.RFreezeSpray, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RFreezeSprayBm", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RFreezeSprayBm() { }

    /// <summary>
    /// Constructs a new RFreezeSprayBm
    /// </summary>
    public RFreezeSprayBm(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RFreezeSprayBm Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RFreezeSprayBm(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RFreezeSprayBm>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RFreezeSprayBm>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RFreezeSprayBm>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RFreezeSprayBm>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RFreezeSprayBm>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RFreezeSprayBm>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RFreezeSprayBm>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ComponentProperty: HandDryIce
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent HandDryIce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 2704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2704); }
    }

    /// <summary>
    /// StructProperty: HandDryIceOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 HandDryIceOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2712); }
    }

    /// <summary>
    /// ObjectProperty: NVHandDryIceParticleSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem NVHandDryIceParticleSystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 2724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2724); }
    }

    /// <summary>
    /// ObjectProperty: NVHandDryIceEmitter
    /// </summary>
    public unsafe BmSDK.Engine.Emitter NVHandDryIceEmitter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Emitter>(Ptr + 2732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2732); }
    }

    /// <summary>
    /// BoolProperty: NVAttachedToHandTrigger
    /// </summary>
    public unsafe bool NVAttachedToHandTrigger
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2740) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2740); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2740); }
    }
}
