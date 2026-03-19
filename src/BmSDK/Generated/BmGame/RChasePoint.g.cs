#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RChasePoint<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RChasePoint : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RChasePoint", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RChasePoint() { }

    /// <summary>
    /// Constructs a new RChasePoint
    /// </summary>
    public RChasePoint(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RChasePoint Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RChasePoint(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: Location
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Location
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ObjectProperty: Pylon
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Pylon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// ObjectProperty: ParentPoint
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ParentPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// StructProperty: Edge
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Edge
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// StructProperty: NextPolyID
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT NextPolyID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// StructProperty: PrevPolyID
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PrevPolyID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// StructProperty: NextPolyParentID
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT NextPolyParentID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// StructProperty: PrevPolyParentID
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PrevPolyParentID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// ArrayProperty: VisibleVerts
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>> VisibleVerts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// BoolProperty: bDeadEnd
    /// </summary>
    public unsafe bool bDeadEnd
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bBeenChecked
    /// </summary>
    public unsafe bool bBeenChecked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bIsVisibleFromRoot
    /// </summary>
    public unsafe bool bIsVisibleFromRoot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bRegistered
    /// </summary>
    public unsafe bool bRegistered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bInvalid
    /// </summary>
    public unsafe bool bInvalid
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// ByteProperty: NumBranches
    /// </summary>
    public unsafe byte NumBranches
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// ByteProperty: NumAssigned
    /// </summary>
    public unsafe byte NumAssigned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 173); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 173); }
    }

    /// <summary>
    /// ByteProperty: AbstractChasers
    /// </summary>
    public unsafe byte AbstractChasers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 174); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 174); }
    }

    /// <summary>
    /// ArrayProperty: ChildPoints
    /// </summary>
    public unsafe BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT> ChildPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// FloatProperty: DistFromSearchStart
    /// </summary>
    public unsafe float DistFromSearchStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// ArrayProperty: AssignedChaser
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT AssignedChaser
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// IntProperty: DebugID
    /// </summary>
    public unsafe int DebugID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }
}
