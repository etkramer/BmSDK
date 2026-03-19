#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RBatarang_Controllable<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBatarang_Controllable : BmSDK.BmGame.RBatarang, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RBatarang_Controllable", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBatarang_Controllable() { }

    /// <summary>
    /// Constructs a new RBatarang_Controllable
    /// </summary>
    public RBatarang_Controllable(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBatarang_Controllable Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBatarang_Controllable(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatarang_Controllable>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatarang_Controllable>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatarang_Controllable>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatarang_Controllable>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatarang_Controllable>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatarang_Controllable>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatarang_Controllable>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: CatchBatarangFrontMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CatchBatarangFrontMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2640); }
    }

    /// <summary>
    /// ObjectProperty: CatchBatarangLeftMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CatchBatarangLeftMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2648); }
    }

    /// <summary>
    /// ObjectProperty: CatchBatarangRightMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CatchBatarangRightMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2656); }
    }

    /// <summary>
    /// ObjectProperty: CatchBatarangBackMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CatchBatarangBackMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2664); }
    }

    /// <summary>
    /// ObjectProperty: CatchBatarangGargoyleMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CatchBatarangGargoyleMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2672); }
    }

    /// <summary>
    /// ObjectProperty: CatchBatarangRailingMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CatchBatarangRailingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2680); }
    }

    /// <summary>
    /// ObjectProperty: CatchBatarangWireMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CatchBatarangWireMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2688); }
    }

    /// <summary>
    /// ObjectProperty: CatchBatarangCoverMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CatchBatarangCoverMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2696); }
    }

    /// <summary>
    /// ObjectProperty: Projectile
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Projectile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2704); }
    }

    /// <summary>
    /// ObjectProperty: ElectrifiedCatchAudio
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ElectrifiedCatchAudio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2712); }
    }

    /// <summary>
    /// ObjectProperty: RemoteControlBatarangMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RemoteControlBatarangMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2720); }
    }

    /// <summary>
    /// ObjectProperty: ChargingRoundTheBackarang
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ChargingRoundTheBackarang
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2728); }
    }

    /// <summary>
    /// ObjectProperty: CaughtBatarangSpecialMoveInstance
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CaughtBatarangSpecialMoveInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2736); }
    }

    /// <summary>
    /// ClassProperty: RoundTheBackarangProjectileClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RoundTheBackarangProjectileClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2744); }
    }

    /// <summary>
    /// ComponentProperty: ElectrifiedCatchParticles
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ElectrifiedCatchParticles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2752); }
    }

    /// <summary>
    /// BoolProperty: bCanUseRoundTheBackarang
    /// </summary>
    public unsafe bool bCanUseRoundTheBackarang
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2760) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2760); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2760); }
    }

    /// <summary>
    /// BoolProperty: FireRoundTheBackarang
    /// </summary>
    public unsafe bool FireRoundTheBackarang
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2760) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2760); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2760); }
    }

    /// <summary>
    /// BoolProperty: bChargingRoundTheBackarang
    /// </summary>
    public unsafe bool bChargingRoundTheBackarang
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2760) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2760); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2760); }
    }

    /// <summary>
    /// FloatProperty: RoundTheBackarangCharge
    /// </summary>
    public unsafe float RoundTheBackarangCharge
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2764); }
    }

    /// <summary>
    /// FloatProperty: RoundTheBackarangChargeTime
    /// </summary>
    public unsafe float RoundTheBackarangChargeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2768); }
    }

    /// <summary>
    /// StructProperty: LockOnSound
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LockOnSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2772); }
    }
}
