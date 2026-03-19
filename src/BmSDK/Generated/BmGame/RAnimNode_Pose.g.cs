#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAnimNode_Pose<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RAnimNode_Pose : BmSDK.Engine.AnimNode, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimNode_Pose", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimNode_Pose() { }

    /// <summary>
    /// Constructs a new RAnimNode_Pose
    /// </summary>
    public RAnimNode_Pose(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnimNode_Pose Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimNode_Pose(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: EnableRagdollSupport
    /// </summary>
    public unsafe bool EnableRagdollSupport
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 280); }
    }

    /// <summary>
    /// BoolProperty: EnableCheekyBlending
    /// </summary>
    public unsafe bool EnableCheekyBlending
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 280); }
    }

    /// <summary>
    /// BoolProperty: SyncToAudioTime
    /// </summary>
    public unsafe bool SyncToAudioTime
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 280); }
    }

    /// <summary>
    /// BoolProperty: DumpThoughts
    /// </summary>
    public unsafe bool DumpThoughts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 280); }
    }

    /// <summary>
    /// BoolProperty: TickLocked
    /// </summary>
    public unsafe bool TickLocked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 280); }
    }

    /// <summary>
    /// BoolProperty: BetweenTick1And2
    /// </summary>
    public unsafe bool BetweenTick1And2
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 280); }
    }

    /// <summary>
    /// BoolProperty: ForceResetOnInitAnim
    /// </summary>
    public unsafe bool ForceResetOnInitAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 280); }
    }

    /// <summary>
    /// BoolProperty: ForceBlockActorsOff
    /// </summary>
    public unsafe bool ForceBlockActorsOff
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 280); }
    }

    /// <summary>
    /// BoolProperty: ForceCollideWorldOff
    /// </summary>
    public unsafe bool ForceCollideWorldOff
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 280); }
    }

    /// <summary>
    /// BoolProperty: TempDisableCollisionCorrection
    /// </summary>
    public unsafe bool TempDisableCollisionCorrection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 280); }
    }

    /// <summary>
    /// BoolProperty: TempDisableLegIk
    /// </summary>
    public unsafe bool TempDisableLegIk
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 280); }
    }

    /// <summary>
    /// BoolProperty: Unconscious
    /// </summary>
    public unsafe bool Unconscious
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 280); }
    }

    /// <summary>
    /// BoolProperty: DisableBlink
    /// </summary>
    public unsafe bool DisableBlink
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 280); }
    }

    /// <summary>
    /// BoolProperty: ForceAnimatedAutomaticTransitionsOff
    /// </summary>
    public unsafe bool ForceAnimatedAutomaticTransitionsOff
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 280); }
    }

    /// <summary>
    /// BoolProperty: MouseSteering
    /// </summary>
    public unsafe bool MouseSteering
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 280); }
    }

    /// <summary>
    /// BoolProperty: EnableIndependentTick
    /// </summary>
    public unsafe bool EnableIndependentTick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 280); }
    }

    /// <summary>
    /// BoolProperty: TickDisabled
    /// </summary>
    public unsafe bool TickDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 280); }
    }

    /// <summary>
    /// BoolProperty: EnableLocalRotZ
    /// </summary>
    public unsafe bool EnableLocalRotZ
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 280); }
    }

    /// <summary>
    /// StructProperty: Editor
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimNode_Pose.PreviousEditor Editor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimNode_Pose.PreviousEditor>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// StructProperty: PreviousEditor
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimNode_Pose.CurrCurveFloatState PreviousEditor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimNode_Pose.CurrCurveFloatState>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// ObjectProperty: EditorMasterNode
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT EditorMasterNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 524); }
    }

    /// <summary>
    /// ObjectProperty: EditorMirrorNode
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT EditorMirrorNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// ObjectProperty: PhysicsOutput
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PhysicsOutput
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// ObjectProperty: FaceFXOutput
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FaceFXOutput
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// ObjectProperty: FloorCorrection
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FloorCorrection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// ObjectProperty: ShimmyCorrection
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ShimmyCorrection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// ObjectProperty: PreviousSkeletalMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PreviousSkeletalMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }

    /// <summary>
    /// ObjectProperty: PreviousPhysicsAsset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PreviousPhysicsAsset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }

    /// <summary>
    /// ObjectProperty: AimingBoneConfig
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AimingBoneConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// ObjectProperty: CurrentSwitchWeaponBoneNotify
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CurrentSwitchWeaponBoneNotify
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// ComponentProperty: PreviousSkelComponent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PreviousSkelComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// StructProperty: CurrCurveFloatState
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimNode_Pose.PosePlayer CurrCurveFloatState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimNode_Pose.PosePlayer>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// StructProperty: PosePlayer
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimNode_Pose.PendingQueuedTransitionCallback PosePlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimNode_Pose.PendingQueuedTransitionCallback>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }

    /// <summary>
    /// StructProperty: PendingQueuedTransitionCallback
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimNode_Pose.WeaponOverlays PendingQueuedTransitionCallback
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimNode_Pose.WeaponOverlays>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// StructProperty: MovementPlayer
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MovementPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// StructProperty: MovementOutput
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MovementOutput
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }
    }

    /// <summary>
    /// StructProperty: WeaponOverlays
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimNode_Pose.IdleOverlays WeaponOverlays
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimNode_Pose.IdleOverlays>(Ptr + 1312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1312); }
    }

    /// <summary>
    /// StructProperty: IdleOverlays
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimNode_Pose.AdditiveOverlays IdleOverlays
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimNode_Pose.AdditiveOverlays>(Ptr + 1340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1340); }
    }

    /// <summary>
    /// StructProperty: AdditiveOverlays
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimNode_Pose.GlobalAdditiveOverlays AdditiveOverlays
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimNode_Pose.GlobalAdditiveOverlays>(Ptr + 1368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1368); }
    }

    /// <summary>
    /// StructProperty: GlobalAdditiveOverlays
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimNode_Pose.TransientNotifyThoughts GlobalAdditiveOverlays
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimNode_Pose.TransientNotifyThoughts>(Ptr + 1392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1392); }
    }

    /// <summary>
    /// StructProperty: AnimAccumulator
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AnimAccumulator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1424); }
    }

    /// <summary>
    /// ArrayProperty: TransientNotifyThoughts
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<System.IntPtr>> TransientNotifyThoughts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>(Ptr + 1520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1520); }
    }

    /// <summary>
    /// StructProperty: Breathing
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Breathing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1536); }
    }

    /// <summary>
    /// FloatProperty: GlobalTimeScale
    /// </summary>
    public unsafe float GlobalTimeScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1548); }
    }

    /// <summary>
    /// StructProperty: NotifyAnim
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT NotifyAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1552); }
    }

    /// <summary>
    /// ArrayProperty: GlobalAdditiveAnims
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> GlobalAdditiveAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1580); }
    }

    /// <summary>
    /// StructProperty: GlobalGundummyAnim
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GlobalGundummyAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1596); }
    }

    /// <summary>
    /// FloatProperty: LocalRotZ
    /// </summary>
    public unsafe float LocalRotZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1612); }
    }

    /// <summary>
    /// StructProperty: AsyncJob
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AsyncJob
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1616); }
    }

    /// <summary>
    /// DelegateProperty: __DummyOnPlayedQueuedTransition__Delegate
    /// </summary>
    public unsafe System.IntPtr __DummyOnPlayedQueuedTransition__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1624); }
    }
}
