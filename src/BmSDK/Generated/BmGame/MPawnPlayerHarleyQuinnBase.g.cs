#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MPawnPlayerHarleyQuinnBase<br/>
/// (flags = 0)
/// </summary>
public partial class MPawnPlayerHarleyQuinnBase : BmSDK.BmGame.RPawnPlayerCatwomanBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MPawnPlayerHarleyQuinnBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MPawnPlayerHarleyQuinnBase() { }

    /// <summary>
    /// Constructs a new MPawnPlayerHarleyQuinnBase
    /// </summary>
    public MPawnPlayerHarleyQuinnBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MPawnPlayerHarleyQuinnBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MPawnPlayerHarleyQuinnBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerHarleyQuinnBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerHarleyQuinnBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerHarleyQuinnBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerHarleyQuinnBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerHarleyQuinnBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerHarleyQuinnBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerHarleyQuinnBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: TakedownConversation
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueConversation TakedownConversation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueConversation>(Ptr + 10340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10340); }
    }

    /// <summary>
    /// ObjectProperty: BatConversation
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueConversation BatConversation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueConversation>(Ptr + 10348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10348); }
    }

    /// <summary>
    /// ObjectProperty: NightwingDamageConversation
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueConversation NightwingDamageConversation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueConversation>(Ptr + 10356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10356); }
    }

    /// <summary>
    /// ObjectProperty: CounterConversation
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueConversation CounterConversation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueConversation>(Ptr + 10364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10364); }
    }

    /// <summary>
    /// ObjectProperty: CounterNightwingConversation
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueConversation CounterNightwingConversation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueConversation>(Ptr + 10372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10372); }
    }

    /// <summary>
    /// ObjectProperty: GrabbedConversation
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueConversation GrabbedConversation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueConversation>(Ptr + 10380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10380); }
    }

    /// <summary>
    /// ObjectProperty: AttackConversation
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueConversation AttackConversation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueConversation>(Ptr + 10388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10388); }
    }

    /// <summary>
    /// ObjectProperty: CopApproachJackBoxConversation
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueConversation CopApproachJackBoxConversation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueConversation>(Ptr + 10396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10396); }
    }

    /// <summary>
    /// ObjectProperty: PredIdleConversation
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueConversation PredIdleConversation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueConversation>(Ptr + 10404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10404); }
    }

    /// <summary>
    /// ObjectProperty: IdleConversation
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueConversation IdleConversation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueConversation>(Ptr + 10412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10412); }
    }

    /// <summary>
    /// ObjectProperty: PsychoStartIdleConversation
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueConversation PsychoStartIdleConversation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueConversation>(Ptr + 10420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10420); }
    }

    /// <summary>
    /// ObjectProperty: PsychoEndIdleConversation
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueConversation PsychoEndIdleConversation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueConversation>(Ptr + 10428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10428); }
    }

    /// <summary>
    /// ObjectProperty: InvisibleConversation
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueConversation InvisibleConversation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueConversation>(Ptr + 10436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10436); }
    }

    /// <summary>
    /// ObjectProperty: MayhemIntroConversation
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueConversation MayhemIntroConversation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueConversation>(Ptr + 10444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10444); }
    }

    /// <summary>
    /// ObjectProperty: MayhemTakedownConversation
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueConversation MayhemTakedownConversation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueConversation>(Ptr + 10452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10452); }
    }

    /// <summary>
    /// ObjectProperty: MayhemOutroConversation
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueConversation MayhemOutroConversation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueConversation>(Ptr + 10460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10460); }
    }

    /// <summary>
    /// ObjectProperty: PlantConversation
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueConversation PlantConversation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueConversation>(Ptr + 10468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10468); }
    }

    /// <summary>
    /// ObjectProperty: StrikeContactEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent StrikeContactEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 10476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10476); }
    }

    /// <summary>
    /// ObjectProperty: StrikeRiotShieldContactEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent StrikeRiotShieldContactEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 10484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10484); }
    }

    /// <summary>
    /// ObjectProperty: DamageStunStickEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent DamageStunStickEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 10492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10492); }
    }

    /// <summary>
    /// ObjectProperty: MayhemIntroEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent MayhemIntroEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 10500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10500); }
    }

    /// <summary>
    /// ObjectProperty: MayhemOutroEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent MayhemOutroEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 10508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10508); }
    }

    /// <summary>
    /// ObjectProperty: MayhemResetEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent MayhemResetEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 10516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10516); }
    }

    /// <summary>
    /// ObjectProperty: MayhemPostProcess
    /// </summary>
    public unsafe BmSDK.BmGame.RViewPostProcess MayhemPostProcess
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RViewPostProcess>(Ptr + 10524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10524); }
    }

    /// <summary>
    /// ObjectProperty: MayhemMaskMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface MayhemMaskMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 10532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10532); }
    }

    /// <summary>
    /// ArrayProperty: ReminderConversations
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AkDialogueConversation> ReminderConversations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AkDialogueConversation>>(Ptr + 10540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10540); }
    }

    /// <summary>
    /// ArrayProperty: ImportantIdleConversations
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AkDialogueConversation> ImportantIdleConversations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AkDialogueConversation>>(Ptr + 10556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10556); }
    }

    /// <summary>
    /// ArrayProperty: LocationPenguinIdleConversations
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AkDialogueConversation> LocationPenguinIdleConversations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AkDialogueConversation>>(Ptr + 10572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10572); }
    }

    /// <summary>
    /// ArrayProperty: LocationPsychoIdleConversations
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AkDialogueConversation> LocationPsychoIdleConversations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AkDialogueConversation>>(Ptr + 10588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10588); }
    }

    /// <summary>
    /// ByteProperty: CurrentVisibility
    /// </summary>
    public unsafe BmSDK.BmGame.MPawnPlayerHarleyQuinnBase.EHarleyVisibilityState CurrentVisibility
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MPawnPlayerHarleyQuinnBase.EHarleyVisibilityState>(Ptr + 10604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10604); }
    }

    /// <summary>
    /// FloatProperty: QuickSwingEscapeTimeout
    /// </summary>
    public unsafe float QuickSwingEscapeTimeout
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10608); }
    }

    /// <summary>
    /// IntProperty: QuickSwingEscapeThreshold
    /// </summary>
    public unsafe int QuickSwingEscapeThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10612); }
    }

    /// <summary>
    /// FloatProperty: QuickSwingEscapeDelay
    /// </summary>
    public unsafe float QuickSwingEscapeDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10616); }
    }

    /// <summary>
    /// BoolProperty: bDebugHarleyVisibility
    /// </summary>
    public unsafe bool bDebugHarleyVisibility
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10620) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10620); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10620); }
    }

    /// <summary>
    /// BoolProperty: bDebugHarleyMayhemMode
    /// </summary>
    public unsafe bool bDebugHarleyMayhemMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10620) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10620); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10620); }
    }

    /// <summary>
    /// BoolProperty: bVulnerableToGuns
    /// </summary>
    public unsafe bool bVulnerableToGuns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10620) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10620); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10620); }
    }

    /// <summary>
    /// BoolProperty: IsInJITBTutorial
    /// </summary>
    public unsafe bool IsInJITBTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10620) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10620); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10620); }
    }

    /// <summary>
    /// BoolProperty: IsJITBTutorialCompleted
    /// </summary>
    public unsafe bool IsJITBTutorialCompleted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10620) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10620); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10620); }
    }

    /// <summary>
    /// BoolProperty: MayhemOn
    /// </summary>
    public unsafe bool MayhemOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10620) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10620); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10620); }
    }

    /// <summary>
    /// BoolProperty: bUpdateMayhemMeterBounds
    /// </summary>
    public unsafe bool bUpdateMayhemMeterBounds
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10620) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10620); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10620); }
    }

    /// <summary>
    /// BoolProperty: FirstMayhemModeInstructionShowned
    /// </summary>
    public unsafe bool FirstMayhemModeInstructionShowned
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10620) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10620); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10620); }
    }

    /// <summary>
    /// FloatProperty: FracturedWallTakedownRange
    /// </summary>
    public unsafe float FracturedWallTakedownRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10624); }
    }

    /// <summary>
    /// FloatProperty: MayhemMeter
    /// </summary>
    public unsafe float MayhemMeter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10628); }
    }

    /// <summary>
    /// FloatProperty: MayhemMeterMax
    /// </summary>
    public unsafe float MayhemMeterMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10632); }
    }

    /// <summary>
    /// FloatProperty: MayhemMeterTimer
    /// </summary>
    public unsafe float MayhemMeterTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10636); }
    }

    /// <summary>
    /// FloatProperty: MayhemMeterDuration
    /// </summary>
    public unsafe float MayhemMeterDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10640); }
    }

    /// <summary>
    /// FloatProperty: MayhemAnimScale
    /// </summary>
    public unsafe float MayhemAnimScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10644); }
    }

    /// <summary>
    /// FloatProperty: MayhemTransitionDuration
    /// </summary>
    public unsafe float MayhemTransitionDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10648); }
    }

    /// <summary>
    /// FloatProperty: MayhemTransitionTime
    /// </summary>
    public unsafe float MayhemTransitionTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10652); }
    }

    /// <summary>
    /// StructProperty: LastTransitionId
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId LastTransitionId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 10656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10656); }
    }

    /// <summary>
    /// FloatProperty: ForceMayhemHUDVisibleTime
    /// </summary>
    public unsafe float ForceMayhemHUDVisibleTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10660); }
    }
}
