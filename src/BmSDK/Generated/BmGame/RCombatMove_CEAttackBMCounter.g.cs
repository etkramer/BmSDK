#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RCombatMove_CEAttackBMCounter<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RCombatMove_CEAttackBMCounter : BmSDK.BmGame.RCombatMove_VillainAttack, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCombatMove_CEAttackBMCounter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCombatMove_CEAttackBMCounter() { }

    /// <summary>
    /// Constructs a new RCombatMove_CEAttackBMCounter
    /// </summary>
    public RCombatMove_CEAttackBMCounter(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCombatMove_CEAttackBMCounter Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCombatMove_CEAttackBMCounter(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_CEAttackBMCounter>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_CEAttackBMCounter>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_CEAttackBMCounter>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_CEAttackBMCounter>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_CEAttackBMCounter>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_CEAttackBMCounter>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_CEAttackBMCounter>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// StructProperty: ImpactScreenShake
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ImpactScreenShake
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// FloatProperty: MoveTimeout
    /// </summary>
    public unsafe float MoveTimeout
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// ObjectProperty: VillainAnimSet
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VillainAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// ObjectProperty: TargetAnimSet
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TargetAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// ByteProperty: MC
    /// </summary>
    public unsafe byte MC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }

    /// <summary>
    /// StructProperty: VillainStrikeID
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VillainStrikeID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// StructProperty: TargetCounterID
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT TargetCounterID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// StructProperty: InitVillainLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT InitVillainLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// StructProperty: InitTargetLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT InitTargetLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }

    /// <summary>
    /// StructProperty: InitStrikeDir
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT InitStrikeDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// FloatProperty: AnimDurationScale
    /// </summary>
    public unsafe float AnimDurationScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// IntProperty: AttackNum
    /// </summary>
    public unsafe int AttackNum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// IntProperty: NumAttacksAllowed
    /// </summary>
    public unsafe int NumAttacksAllowed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// IntProperty: LastAttackType
    /// </summary>
    public unsafe int LastAttackType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// BoolProperty: bAllowNextStrike
    /// </summary>
    public unsafe bool bAllowNextStrike
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1044) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1044); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1044); }
    }

    /// <summary>
    /// BoolProperty: bCanExitViaMovement
    /// </summary>
    public unsafe bool bCanExitViaMovement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1044) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1044); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1044); }
    }

    /// <summary>
    /// BoolProperty: bTracking
    /// </summary>
    public unsafe bool bTracking
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1044) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1044); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1044); }
    }

    /// <summary>
    /// BoolProperty: bFinalAttack
    /// </summary>
    public unsafe bool bFinalAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1044) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1044); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1044); }
    }

    /// <summary>
    /// BoolProperty: bCounterQueued
    /// </summary>
    public unsafe bool bCounterQueued
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1044) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1044); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1044); }
    }

    /// <summary>
    /// BoolProperty: bStartedWhileCannotTrack
    /// </summary>
    public unsafe bool bStartedWhileCannotTrack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1044) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1044); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1044); }
    }

    /// <summary>
    /// FloatProperty: AttackRange
    /// </summary>
    public unsafe float AttackRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }

    /// <summary>
    /// FloatProperty: HitRange
    /// </summary>
    public unsafe float HitRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }

    /// <summary>
    /// FloatProperty: AvoidWallRange
    /// </summary>
    public unsafe float AvoidWallRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }

    /// <summary>
    /// FloatProperty: ScaleDelta
    /// </summary>
    public unsafe float ScaleDelta
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }

    /// <summary>
    /// StructProperty: animLoc
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT animLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }

    /// <summary>
    /// IntProperty: AnimYaw
    /// </summary>
    public unsafe int AnimYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// StructProperty: CurrInfo
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CurrInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// FloatProperty: AttackDelay
    /// </summary>
    public unsafe float AttackDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// FloatProperty: TimeOfLastCounter
    /// </summary>
    public unsafe float TimeOfLastCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// IntProperty: TimesCounterHasBeenPressed
    /// </summary>
    public unsafe int TimesCounterHasBeenPressed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// FloatProperty: TimeDualPlayQueued
    /// </summary>
    public unsafe float TimeDualPlayQueued
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }
}
