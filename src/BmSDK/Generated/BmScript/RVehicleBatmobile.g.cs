#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RVehicleBatmobile<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RVehicleBatmobile : BmSDK.BmGame.RVehicleBatmobileBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RVehicleBatmobile", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RVehicleBatmobile() { }

    /// <summary>
    /// Constructs a new RVehicleBatmobile
    /// </summary>
    public RVehicleBatmobile(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RVehicleBatmobile Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicleBatmobile(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleBatmobile>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleBatmobile>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleBatmobile>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleBatmobile>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleBatmobile>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleBatmobile>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleBatmobile>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: GetInMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GetInMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8352); }
    }

    /// <summary>
    /// ObjectProperty: GlideInMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GlideInMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8360); }
    }

    /// <summary>
    /// ObjectProperty: GlideBoostInMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GlideBoostInMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8368); }
    }

    /// <summary>
    /// ObjectProperty: FallInMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig FallInMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8376); }
    }

    /// <summary>
    /// ObjectProperty: GetOutMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GetOutMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8384); }
    }

    /// <summary>
    /// ObjectProperty: GetOutToStandFastMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GetOutToStandFastMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8392); }
    }

    /// <summary>
    /// ObjectProperty: GetOutOnTopMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GetOutOnTopMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8400); }
    }

    /// <summary>
    /// ObjectProperty: GetOutOnTopOnSteepInclineMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GetOutOnTopOnSteepInclineMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8408); }
    }

    /// <summary>
    /// ObjectProperty: EjectUpMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig EjectUpMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8416); }
    }

    /// <summary>
    /// ObjectProperty: EjectForwardMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig EjectForwardMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8424); }
    }

    /// <summary>
    /// ObjectProperty: GetInRemoteMoveFront
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GetInRemoteMoveFront
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8432); }
    }

    /// <summary>
    /// ObjectProperty: GetInRemoteMoveBack
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GetInRemoteMoveBack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8440); }
    }

    /// <summary>
    /// ObjectProperty: JumpInBatmobileSkidStopMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig JumpInBatmobileSkidStopMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8448); }
    }

    /// <summary>
    /// ObjectProperty: GetInWithoutAnimMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GetInWithoutAnimMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8456); }
    }

    /// <summary>
    /// ObjectProperty: EjectWhenBatmobileVerticalMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig EjectWhenBatmobileVerticalMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8464); }
    }

    /// <summary>
    /// ObjectProperty: EjectUpWhenBatmobileVerticalMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig EjectUpWhenBatmobileVerticalMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8472); }
    }

    /// <summary>
    /// ObjectProperty: GetInWhenBatmbileVerticalMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GetInWhenBatmbileVerticalMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8480); }
    }

    /// <summary>
    /// ObjectProperty: SwingInBatmobileAbseilingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig SwingInBatmobileAbseilingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8488); }
    }

    /// <summary>
    /// ObjectProperty: EjectToSpotMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig EjectToSpotMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8496); }
    }

    /// <summary>
    /// ObjectProperty: GetInOnSideMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GetInOnSideMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8504); }
    }

    /// <summary>
    /// ObjectProperty: GetOutOnSideMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GetOutOnSideMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8512); }
    }

    /// <summary>
    /// ObjectProperty: HighSpeedPickupMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig HighSpeedPickupMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8520); }
    }

    /// <summary>
    /// ObjectProperty: AfterburnerFFWaveForm
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform AfterburnerFFWaveForm
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 8528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8528); }
    }

    /// <summary>
    /// ObjectProperty: TaserSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent TaserSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 8536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8536); }
    }

    /// <summary>
    /// ObjectProperty: StolenAction
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_SetBatmobileState StolenAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_SetBatmobileState>(Ptr + 8544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8544); }
    }

    /// <summary>
    /// ComponentProperty: DisabledByEmpFx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent DisabledByEmpFx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 8552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8552); }
    }

    /// <summary>
    /// IntProperty: GetOutOnTopOnSteepInclinePitch
    /// </summary>
    public unsafe int GetOutOnTopOnSteepInclinePitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8560); }
    }

    /// <summary>
    /// BoolProperty: GlidingIn
    /// </summary>
    public unsafe bool GlidingIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8564) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8564); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8564); }
    }

    /// <summary>
    /// BoolProperty: bAfterburnerIsOn
    /// </summary>
    public unsafe bool bAfterburnerIsOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8564) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8564); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8564); }
    }

    /// <summary>
    /// BoolProperty: bBattleModeAfterBurnerIsOn
    /// </summary>
    public unsafe bool bBattleModeAfterBurnerIsOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8564) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8564); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8564); }
    }

    /// <summary>
    /// BoolProperty: bAfterburnerIsWarming
    /// </summary>
    public unsafe bool bAfterburnerIsWarming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8564) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8564); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8564); }
    }

    /// <summary>
    /// BoolProperty: XrayMaterialsAssigned
    /// </summary>
    public unsafe bool XrayMaterialsAssigned
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8564) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8564); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8564); }
    }

    /// <summary>
    /// ArrayProperty: LeaveCarListeners
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmScript.RCarListenerInterface> LeaveCarListeners
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.RCarListenerInterface>>(Ptr + 8568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8568); }
    }

    /// <summary>
    /// FloatProperty: fAfterburnerStartTime
    /// </summary>
    public unsafe float fAfterburnerStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8584); }
    }

    /// <summary>
    /// FloatProperty: fAfterBurnerRumbleStartStrength
    /// </summary>
    public unsafe float fAfterBurnerRumbleStartStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8588); }
    }

    /// <summary>
    /// FloatProperty: fAfterBurnerRumbleStrengthTimeMultiplier
    /// </summary>
    public unsafe float fAfterBurnerRumbleStrengthTimeMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8592); }
    }

    /// <summary>
    /// FloatProperty: fAfterburnerCutoffStartTime
    /// </summary>
    public unsafe float fAfterburnerCutoffStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8596); }
    }

    /// <summary>
    /// FloatProperty: fAfterBurnerRumbleCutoffStartStrength
    /// </summary>
    public unsafe float fAfterBurnerRumbleCutoffStartStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8600); }
    }

    /// <summary>
    /// FloatProperty: fAfterBurnerRumbleCutoffTimeMultiplier
    /// </summary>
    public unsafe float fAfterBurnerRumbleCutoffTimeMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8604); }
    }

    /// <summary>
    /// ArrayProperty: UpgradedGeneratorBonus
    /// </summary>
    public unsafe BmSDK.TArray<float> UpgradedGeneratorBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 8608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8608); }
    }

    /// <summary>
    /// ArrayProperty: UpgradedGeneratorShielding
    /// </summary>
    public unsafe BmSDK.TArray<float> UpgradedGeneratorShielding
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 8624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8624); }
    }
}
