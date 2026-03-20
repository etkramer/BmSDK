#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPawnVillainNinjaBase<br/>
/// (flags = 0)
/// </summary>
public partial class RPawnVillainNinjaBase : BmSDK.BmGame.RPawnVillain, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnVillainNinjaBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPawnVillainNinjaBase() { }

    /// <summary>
    /// Constructs a new RPawnVillainNinjaBase
    /// </summary>
    public RPawnVillainNinjaBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPawnVillainNinjaBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnVillainNinjaBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainNinjaBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainNinjaBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainNinjaBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainNinjaBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainNinjaBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainNinjaBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainNinjaBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// BoolProperty: bForceTauntExit
    /// </summary>
    public unsafe bool bForceTauntExit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6664) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6664); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6664); }
    }

    /// <summary>
    /// BoolProperty: bTeleportInsteadOfDespawn
    /// </summary>
    public unsafe bool bTeleportInsteadOfDespawn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6664) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6664); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6664); }
    }

    /// <summary>
    /// ObjectProperty: teleportAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet teleportAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 6668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6668); }
    }

    /// <summary>
    /// ObjectProperty: smokeBombVFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem smokeBombVFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 6676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6676); }
    }

    /// <summary>
    /// ObjectProperty: CustomWhipTripAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet CustomWhipTripAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 6684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6684); }
    }

    /// <summary>
    /// ObjectProperty: DodgeTrail
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem DodgeTrail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 6692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6692); }
    }

    /// <summary>
    /// NameProperty: teleportAnim
    /// </summary>
    public unsafe BmSDK.FName teleportAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6700); }
    }

    /// <summary>
    /// ArrayProperty: EmitterList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Emitter> EmitterList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Emitter>>(Ptr + 6708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6708); }
    }
}
