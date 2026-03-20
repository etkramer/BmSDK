#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RVehicleNPCBatmobile<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RVehicleNPCBatmobile : BmSDK.BmGame.RVehicleNPC, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RVehicleNPCBatmobile", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RVehicleNPCBatmobile() { }

    /// <summary>
    /// Constructs a new RVehicleNPCBatmobile
    /// </summary>
    public RVehicleNPCBatmobile(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RVehicleNPCBatmobile Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicleNPCBatmobile(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleNPCBatmobile>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleNPCBatmobile>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleNPCBatmobile>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleNPCBatmobile>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleNPCBatmobile>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleNPCBatmobile>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleNPCBatmobile>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// BoolProperty: ArmouredMode
    /// </summary>
    public unsafe bool ArmouredMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7620) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7620); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7620); }
    }

    /// <summary>
    /// BoolProperty: bTransforming
    /// </summary>
    public unsafe bool bTransforming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7620) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7620); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7620); }
    }

    /// <summary>
    /// BoolProperty: bWeaponsReady
    /// </summary>
    public unsafe bool bWeaponsReady
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7620) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7620); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7620); }
    }

    /// <summary>
    /// BoolProperty: TurretAimIsGood
    /// </summary>
    public unsafe bool TurretAimIsGood
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7620) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7620); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7620); }
    }

    /// <summary>
    /// BoolProperty: IsBattleModeJammed
    /// </summary>
    public unsafe bool IsBattleModeJammed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7620) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7620); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7620); }
    }

    /// <summary>
    /// BoolProperty: SelfDriveAllowBoost
    /// </summary>
    public unsafe bool SelfDriveAllowBoost
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7620) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7620); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7620); }
    }

    /// <summary>
    /// ComponentProperty: AfterburnerSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent AfterburnerSystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 7624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7624); }
    }

    /// <summary>
    /// ObjectProperty: ExhaustBurstEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ExhaustBurstEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 7632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7632); }
    }

    /// <summary>
    /// ObjectProperty: PursuitModePrimaryWeapon
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon PursuitModePrimaryWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 7640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7640); }
    }

    /// <summary>
    /// ObjectProperty: BattleModePrimaryWeapon
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon BattleModePrimaryWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 7648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7648); }
    }

    /// <summary>
    /// ObjectProperty: CurrentWeapon
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon CurrentWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 7656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7656); }
    }

    /// <summary>
    /// ObjectProperty: SecondaryWeapon
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon SecondaryWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 7664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7664); }
    }

    /// <summary>
    /// ObjectProperty: TransformationAnimNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeSequence TransformationAnimNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeSequence>(Ptr + 7672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7672); }
    }

    /// <summary>
    /// ObjectProperty: CockpitAnimNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeSequence CockpitAnimNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeSequence>(Ptr + 7680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7680); }
    }

    /// <summary>
    /// ObjectProperty: TurretController
    /// </summary>
    public unsafe BmSDK.Engine.SkelControlSingleBone TurretController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkelControlSingleBone>(Ptr + 7688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7688); }
    }

    /// <summary>
    /// ArrayProperty: TurretPitchControllers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkelControlSingleBone> TurretPitchControllers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkelControlSingleBone>>(Ptr + 7696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7696); }
    }

    /// <summary>
    /// NameProperty: BattleModeTransformationAnimName
    /// </summary>
    public unsafe BmSDK.FName BattleModeTransformationAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 7712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7712); }
    }

    /// <summary>
    /// NameProperty: PursuitModeTransformationAnimName
    /// </summary>
    public unsafe BmSDK.FName PursuitModeTransformationAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 7720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7720); }
    }
}
