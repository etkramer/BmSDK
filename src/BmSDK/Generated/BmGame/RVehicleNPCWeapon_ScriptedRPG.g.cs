#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RVehicleNPCWeapon_ScriptedRPG<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RVehicleNPCWeapon_ScriptedRPG : BmSDK.BmGame.RVehicleNPCWeapon_RPG, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RVehicleNPCWeapon_ScriptedRPG", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RVehicleNPCWeapon_ScriptedRPG() { }

    /// <summary>
    /// Constructs a new RVehicleNPCWeapon_ScriptedRPG
    /// </summary>
    public RVehicleNPCWeapon_ScriptedRPG(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RVehicleNPCWeapon_ScriptedRPG Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicleNPCWeapon_ScriptedRPG(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleNPCWeapon_ScriptedRPG>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleNPCWeapon_ScriptedRPG>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleNPCWeapon_ScriptedRPG>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleNPCWeapon_ScriptedRPG>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleNPCWeapon_ScriptedRPG>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleNPCWeapon_ScriptedRPG>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleNPCWeapon_ScriptedRPG>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: AttackAction
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AttackAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// ObjectProperty: HitActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HitActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// FloatProperty: InitialFireDelay
    /// </summary>
    public unsafe float InitialFireDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// FloatProperty: FireDelay
    /// </summary>
    public unsafe float FireDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// BoolProperty: HasFired
    /// </summary>
    public unsafe bool HasFired
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 860); }
    }

    /// <summary>
    /// BoolProperty: HasHit
    /// </summary>
    public unsafe bool HasHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 860); }
    }

    /// <summary>
    /// BoolProperty: UnderScriptControl
    /// </summary>
    public unsafe bool UnderScriptControl
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 860); }
    }

    /// <summary>
    /// BoolProperty: HitTargetActor
    /// </summary>
    public unsafe bool HitTargetActor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 860); }
    }

    /// <summary>
    /// FloatProperty: TimeOnScreenToShoot
    /// </summary>
    public unsafe float TimeOnScreenToShoot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }

    /// <summary>
    /// FloatProperty: TimeOnScreenTimeout
    /// </summary>
    public unsafe float TimeOnScreenTimeout
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// FloatProperty: TimeOnScreen
    /// </summary>
    public unsafe float TimeOnScreen
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// FloatProperty: TimeOut
    /// </summary>
    public unsafe float TimeOut
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }
}
