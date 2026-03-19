#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RBMBehaviour_GangMovementBase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMBehaviour_GangMovementBase : BmSDK.BmGame.RBMBehaviour_GangMovementBaseBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RBMBehaviour_GangMovementBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_GangMovementBase() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_GangMovementBase
    /// </summary>
    public RBMBehaviour_GangMovementBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_GangMovementBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_GangMovementBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: DestinationActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DestinationActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ObjectProperty: NavHandle
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT NavHandle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// ObjectProperty: SavedAction
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SavedAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// ObjectProperty: SavedSpecToPOI
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SavedSpecToPOI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// NameProperty: SavedMovementStance
    /// </summary>
    public unsafe BmSDK.FName SavedMovementStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// NameProperty: SavedWeaponStance
    /// </summary>
    public unsafe BmSDK.FName SavedWeaponStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// NameProperty: NewMovementStance
    /// </summary>
    public unsafe BmSDK.FName NewMovementStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// NameProperty: NewWeaponStance
    /// </summary>
    public unsafe BmSDK.FName NewWeaponStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// StructProperty: SavedTransInPoint
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SavedTransInPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// StructProperty: SavedTransInRotation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SavedTransInRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// BoolProperty: bDetattchedFromCar
    /// </summary>
    public unsafe bool bDetattchedFromCar
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 860); }
    }

    /// <summary>
    /// BoolProperty: bCantFleeAtTheMoment
    /// </summary>
    public unsafe bool bCantFleeAtTheMoment
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 860); }
    }

    /// <summary>
    /// BoolProperty: bSecondTry
    /// </summary>
    public unsafe bool bSecondTry
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 860); }
    }

    /// <summary>
    /// BoolProperty: bSprayingGraffiti
    /// </summary>
    public unsafe bool bSprayingGraffiti
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 860); }
    }

    /// <summary>
    /// BoolProperty: bHasRegisteredPointWithBrain
    /// </summary>
    public unsafe bool bHasRegisteredPointWithBrain
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 860); }
    }

    /// <summary>
    /// BoolProperty: bHasDoneWaitState
    /// </summary>
    public unsafe bool bHasDoneWaitState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 860); }
    }

    /// <summary>
    /// FloatProperty: ChanceOfNewRunCycle
    /// </summary>
    public unsafe float ChanceOfNewRunCycle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }

    /// <summary>
    /// FloatProperty: StartleFriendDistance
    /// </summary>
    public unsafe float StartleFriendDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// StructProperty: FleeReactionID
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FleeReactionID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// ArrayProperty: FleeReactionFront
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>> FleeReactionFront
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// ArrayProperty: FleeReactionBack
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>> FleeReactionBack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// FloatProperty: CurrentSprayDuration
    /// </summary>
    public unsafe float CurrentSprayDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// FloatProperty: CurrentSprayTime
    /// </summary>
    public unsafe float CurrentSprayTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }

    /// <summary>
    /// IntProperty: CurrentSprayIndex
    /// </summary>
    public unsafe int CurrentSprayIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// IntProperty: WaitStateFrameTimer
    /// </summary>
    public unsafe int WaitStateFrameTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }
}
