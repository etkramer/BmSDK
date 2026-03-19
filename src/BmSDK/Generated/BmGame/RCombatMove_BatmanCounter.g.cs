#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RCombatMove_BatmanCounter<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RCombatMove_BatmanCounter : BmSDK.BmGame.RCombatMove_BatmanWeaponAttack, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCombatMove_BatmanCounter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCombatMove_BatmanCounter() { }

    /// <summary>
    /// Constructs a new RCombatMove_BatmanCounter
    /// </summary>
    public RCombatMove_BatmanCounter(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCombatMove_BatmanCounter Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCombatMove_BatmanCounter(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanCounter>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanCounter>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanCounter>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanCounter>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanCounter>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanCounter>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanCounter>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// StructProperty: ImpactScreenShake
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ImpactScreenShake
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// StructProperty: CounterAnimID
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CounterAnimID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// StructProperty: TargetCounteredAnimID
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT TargetCounteredAnimID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// ClassProperty: CounterDmgType
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CounterDmgType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// StructProperty: CounterDir
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CounterDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// StructProperty: CounterRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CounterRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }

    /// <summary>
    /// NameProperty: AnimName
    /// </summary>
    public unsafe BmSDK.FName AnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }

    /// <summary>
    /// NameProperty: ForceAnimName
    /// </summary>
    public unsafe BmSDK.FName ForceAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// ObjectProperty: CounterCameraAnimset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CounterCameraAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// ObjectProperty: BatmanCounterAnimSequence
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BatmanCounterAnimSequence
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// ObjectProperty: BatmanAnimSet
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BatmanAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// ObjectProperty: TargetAnimSet
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TargetAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// BoolProperty: bPlayedCameraAnim
    /// </summary>
    public unsafe bool bPlayedCameraAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1112); }
    }

    /// <summary>
    /// BoolProperty: bAddedScore
    /// </summary>
    public unsafe bool bAddedScore
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1112); }
    }

    /// <summary>
    /// BoolProperty: bDoCameraAssistOnLastHit
    /// </summary>
    public unsafe bool bDoCameraAssistOnLastHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1112); }
    }

    /// <summary>
    /// BoolProperty: bAppliedDamage
    /// </summary>
    public unsafe bool bAppliedDamage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1112); }
    }

    /// <summary>
    /// BoolProperty: bSlowMo
    /// </summary>
    public unsafe bool bSlowMo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1112); }
    }

    /// <summary>
    /// BoolProperty: bTargetGoRagdollNextFrame
    /// </summary>
    public unsafe bool bTargetGoRagdollNextFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1112); }
    }

    /// <summary>
    /// BoolProperty: bTargetGoRagdollAfterFinalHit
    /// </summary>
    public unsafe bool bTargetGoRagdollAfterFinalHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1112); }
    }

    /// <summary>
    /// BoolProperty: bFinalBlow
    /// </summary>
    public unsafe bool bFinalBlow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1112); }
    }

    /// <summary>
    /// BoolProperty: bShouldKill
    /// </summary>
    public unsafe bool bShouldKill
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1112); }
    }

    /// <summary>
    /// BoolProperty: bFirstSlowMo
    /// </summary>
    public unsafe bool bFirstSlowMo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1112); }
    }

    /// <summary>
    /// BoolProperty: bCachedMoveBeyondCheck
    /// </summary>
    public unsafe bool bCachedMoveBeyondCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1112); }
    }

    /// <summary>
    /// BoolProperty: bCanMoveBeyondTarget
    /// </summary>
    public unsafe bool bCanMoveBeyondTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1112); }
    }

    /// <summary>
    /// BoolProperty: bApplyDamageOnExit
    /// </summary>
    public unsafe bool bApplyDamageOnExit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1112); }
    }

    /// <summary>
    /// BoolProperty: bFinalHitHappened
    /// </summary>
    public unsafe bool bFinalHitHappened
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1112); }
    }

    /// <summary>
    /// BoolProperty: bEnvCounter
    /// </summary>
    public unsafe bool bEnvCounter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1112); }
    }

    /// <summary>
    /// BoolProperty: bOnStep
    /// </summary>
    public unsafe bool bOnStep
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1112); }
    }

    /// <summary>
    /// BoolProperty: bCanFlashTeleport
    /// </summary>
    public unsafe bool bCanFlashTeleport
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1112); }
    }

    /// <summary>
    /// BoolProperty: bWillTeleport
    /// </summary>
    public unsafe bool bWillTeleport
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1112); }
    }

    /// <summary>
    /// BoolProperty: bTargetIsInvulnerable
    /// </summary>
    public unsafe bool bTargetIsInvulnerable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1112); }
    }

    /// <summary>
    /// BoolProperty: bInformedDeathCutsceneOfFinalHit
    /// </summary>
    public unsafe bool bInformedDeathCutsceneOfFinalHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1112); }
    }

    /// <summary>
    /// BoolProperty: bIsThrowCounter
    /// </summary>
    public unsafe bool bIsThrowCounter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1112); }
    }

    /// <summary>
    /// StructProperty: CounterInfo
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CounterInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// NameProperty: LastHitBone
    /// </summary>
    public unsafe BmSDK.FName LastHitBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1200); }
    }

    /// <summary>
    /// FloatProperty: ChapterNumber
    /// </summary>
    public unsafe float ChapterNumber
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1208); }
    }

    /// <summary>
    /// IntProperty: NumCounterHits
    /// </summary>
    public unsafe int NumCounterHits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1212); }
    }

    /// <summary>
    /// IntProperty: CurrCounterHit
    /// </summary>
    public unsafe int CurrCounterHit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1216); }
    }

    /// <summary>
    /// ArrayProperty: SlowMoHitTimes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>> SlowMoHitTimes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>(Ptr + 1220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1220); }
    }

    /// <summary>
    /// FloatProperty: FirstCounterHitTime
    /// </summary>
    public unsafe float FirstCounterHitTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1236); }
    }

    /// <summary>
    /// FloatProperty: CounterTime
    /// </summary>
    public unsafe float CounterTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }
    }

    /// <summary>
    /// StructProperty: AnimPos
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AnimPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1244); }
    }

    /// <summary>
    /// ByteProperty: CounterWallDir
    /// </summary>
    public unsafe byte CounterWallDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }

    /// <summary>
    /// ByteProperty: CounterRailDir
    /// </summary>
    public unsafe byte CounterRailDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1257); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1257); }
    }

    /// <summary>
    /// ByteProperty: OverrideMoveType
    /// </summary>
    public unsafe byte OverrideMoveType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1258); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1258); }
    }

    /// <summary>
    /// StructProperty: EnvCounterLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT EnvCounterLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1260); }
    }

    /// <summary>
    /// StructProperty: EnvCounterNormal
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT EnvCounterNormal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1272); }
    }

    /// <summary>
    /// IntProperty: OverrideComboInc
    /// </summary>
    public unsafe int OverrideComboInc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1284); }
    }

    /// <summary>
    /// IntProperty: CapeStateChangeIndex
    /// </summary>
    public unsafe int CapeStateChangeIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1288); }
    }

    /// <summary>
    /// IntProperty: LastHitIndex
    /// </summary>
    public unsafe int LastHitIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1292); }
    }
}
