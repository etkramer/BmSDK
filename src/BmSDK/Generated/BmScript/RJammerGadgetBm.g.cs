#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RJammerGadgetBm<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RJammerGadgetBm : BmSDK.BmGame.RJammerGadget, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RJammerGadgetBm", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RJammerGadgetBm() { }

    /// <summary>
    /// Constructs a new RJammerGadgetBm
    /// </summary>
    public RJammerGadgetBm(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RJammerGadgetBm Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RJammerGadgetBm(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RJammerGadgetBm>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RJammerGadgetBm>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RJammerGadgetBm>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RJammerGadgetBm>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RJammerGadgetBm>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RJammerGadgetBm>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RJammerGadgetBm>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// BoolProperty: bCombatFire
    /// </summary>
    public unsafe bool bCombatFire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2068); }
    }

    /// <summary>
    /// BoolProperty: bCanDisableWeapon
    /// </summary>
    public unsafe bool bCanDisableWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2068); }
    }

    /// <summary>
    /// BoolProperty: bCanDetonateMine
    /// </summary>
    public unsafe bool bCanDetonateMine
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2068); }
    }

    /// <summary>
    /// BoolProperty: bCheatAllUpgrades
    /// </summary>
    public unsafe bool bCheatAllUpgrades
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2068); }
    }

    /// <summary>
    /// BoolProperty: bDebugSimulateOverworld
    /// </summary>
    public unsafe bool bDebugSimulateOverworld
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2068); }
    }

    /// <summary>
    /// InterfaceProperty: CurrentTarget
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CurrentTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2072); }
    }

    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RJammerGadget.FiredChargeOWLocations ThrowDirectionTypes_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RJammerGadget.FiredChargeOWLocations>(Ptr + 2088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2088); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RJammerGadget.FiredChargeOWLocations ThrowDirectionTypes_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RJammerGadget.FiredChargeOWLocations>(Ptr + 2104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2104); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RJammerGadget.FiredChargeOWLocations ThrowDirectionTypes_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RJammerGadget.FiredChargeOWLocations>(Ptr + 2120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2120); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RJammerGadget.FiredChargeOWLocations ThrowDirectionTypes_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RJammerGadget.FiredChargeOWLocations>(Ptr + 2136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2136); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RJammerGadget.FiredChargeOWLocations ThrowDirectionTypes_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RJammerGadget.FiredChargeOWLocations>(Ptr + 2152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2152); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RJammerGadget.FiredChargeOWLocations ThrowDirectionTypes_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RJammerGadget.FiredChargeOWLocations>(Ptr + 2168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2168); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RJammerGadget.FiredChargeOWLocations ThrowDirectionTypes_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RJammerGadget.FiredChargeOWLocations>(Ptr + 2184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2184); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RJammerGadget.FiredChargeOWLocations ThrowDirectionTypes_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RJammerGadget.FiredChargeOWLocations>(Ptr + 2200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2200); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RJammerGadget.FiredChargeOWLocations ThrowDirectionTypes_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RJammerGadget.FiredChargeOWLocations>(Ptr + 2216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2216); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RJammerGadget.FiredChargeOWLocations ThrowDirectionTypes_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RJammerGadget.FiredChargeOWLocations>(Ptr + 2232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2232); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RJammerGadget.FiredChargeOWLocations ThrowDirectionTypes_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RJammerGadget.FiredChargeOWLocations>(Ptr + 2248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2248); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RJammerGadget.FiredChargeOWLocations ThrowDirectionTypes_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RJammerGadget.FiredChargeOWLocations>(Ptr + 2264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2264); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RJammerGadget.FiredChargeOWLocations ThrowDirectionTypes_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RJammerGadget.FiredChargeOWLocations>(Ptr + 2280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2280); }
    }

    /// <summary>
    /// ByteProperty: LastMirrorChoice
    /// </summary>
    public unsafe byte LastMirrorChoice
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2296); }
    }

    /// <summary>
    /// FloatProperty: PrimaryButtonChargeTime
    /// </summary>
    public unsafe float PrimaryButtonChargeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2300); }
    }

    /// <summary>
    /// ArrayProperty: FiredChargeOWLocations
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> FiredChargeOWLocations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 2304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2304); }
    }

    /// <summary>
    /// FloatProperty: ReplenishTime
    /// </summary>
    public unsafe float ReplenishTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2320); }
    }

    /// <summary>
    /// ObjectProperty: ChargingLoopStartSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ChargingLoopStartSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2324); }
    }

    /// <summary>
    /// ObjectProperty: ChargingLoopStopSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ChargingLoopStopSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2332); }
    }

    /// <summary>
    /// ObjectProperty: ChargingFailSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ChargingFailSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2340); }
    }
}
