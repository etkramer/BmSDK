#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RCombatMove_BatmanDropWeapon<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RCombatMove_BatmanDropWeapon : BmSDK.BmGame.RCombatMove_BatmanWeaponAttack, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCombatMove_BatmanDropWeapon", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCombatMove_BatmanDropWeapon() { }

    /// <summary>
    /// Constructs a new RCombatMove_BatmanDropWeapon
    /// </summary>
    public RCombatMove_BatmanDropWeapon(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCombatMove_BatmanDropWeapon Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCombatMove_BatmanDropWeapon(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanDropWeapon>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanDropWeapon>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanDropWeapon>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanDropWeapon>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanDropWeapon>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanDropWeapon>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanDropWeapon>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// BoolProperty: bGrabbedWeaponLeft
    /// </summary>
    public unsafe bool bGrabbedWeaponLeft
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 836); }
    }

    /// <summary>
    /// BoolProperty: bGrabbedWeaponRight
    /// </summary>
    public unsafe bool bGrabbedWeaponRight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 836); }
    }

    /// <summary>
    /// BoolProperty: bHasWeaponIH
    /// </summary>
    public unsafe bool bHasWeaponIH
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 836); }
    }

    /// <summary>
    /// BoolProperty: bCanGrabWeapon
    /// </summary>
    public unsafe bool bCanGrabWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 836); }
    }

    /// <summary>
    /// BoolProperty: bDropWeaponOnExit
    /// </summary>
    public unsafe bool bDropWeaponOnExit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 836); }
    }

    /// <summary>
    /// ObjectProperty: TargetWeapon
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TargetWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// ObjectProperty: DroppedWeapon
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DroppedWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// ObjectProperty: WeaponToPickup
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WeaponToPickup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// FloatProperty: PickupCheckDist
    /// </summary>
    public unsafe float PickupCheckDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }
}
