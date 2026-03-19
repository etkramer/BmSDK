#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: FlexComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class FlexComponent : BmSDK.Engine.StaticMeshComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.FlexComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal FlexComponent() { }

    /// <summary>
    /// Constructs a new FlexComponent
    /// </summary>
    public FlexComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, FlexComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected FlexComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: FlexComponentContainerTemplate
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FlexComponentContainerTemplate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// IntProperty: FlexComponentPhaseId
    /// </summary>
    public unsafe int FlexComponentPhaseId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// BoolProperty: bFlexComponentAutoAssignPhase
    /// </summary>
    public unsafe bool bFlexComponentAutoAssignPhase
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 760); }
    }

    /// <summary>
    /// BoolProperty: bFlexComponentAttachToRigids
    /// </summary>
    public unsafe bool bFlexComponentAttachToRigids
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 760); }
    }

    /// <summary>
    /// BoolProperty: bIsDebrisMoving
    /// </summary>
    public unsafe bool bIsDebrisMoving
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 760); }
    }

    /// <summary>
    /// BoolProperty: bHasDebrisRested
    /// </summary>
    public unsafe bool bHasDebrisRested
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 760); }
    }

    /// <summary>
    /// StructProperty: FlexComponentAssetInstance
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FlexComponentAssetInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// StructProperty: FlexComponentContainerInstance
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FlexComponentContainerInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ArrayProperty: FlexComponentPreSimPositions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>>>>>>>> FlexComponentPreSimPositions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>>>>>>>>>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// ArrayProperty: SimBuffers
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT SimBuffers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// FloatProperty: AverageKineticEnergy
    /// </summary>
    public unsafe float AverageKineticEnergy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// FloatProperty: PrevAverageKineticEnergy
    /// </summary>
    public unsafe float PrevAverageKineticEnergy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// FloatProperty: FlexComponentDistanceBeforeSleep
    /// </summary>
    public unsafe float FlexComponentDistanceBeforeSleep
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// IntProperty: FlexComponentInvisibleFramesBeforeSleep
    /// </summary>
    public unsafe int FlexComponentInvisibleFramesBeforeSleep
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }
}
