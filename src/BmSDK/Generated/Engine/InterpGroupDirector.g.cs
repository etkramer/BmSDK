#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: InterpGroupDirector<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class InterpGroupDirector : BmSDK.Engine.InterpGroup, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.InterpGroupDirector", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal InterpGroupDirector() { }

    /// <summary>
    /// Constructs a new InterpGroupDirector
    /// </summary>
    public InterpGroupDirector(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, InterpGroupDirector Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected InterpGroupDirector(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: VfTable_FInterpEdInputInterface
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VfTable_FInterpEdInputInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ArrayProperty: InterpTracks
    /// </summary>
    public unsafe BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT> InterpTracks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// NameProperty: GroupName
    /// </summary>
    public unsafe BmSDK.FName GroupName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// StructProperty: GroupColor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GroupColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// ArrayProperty: GroupAnimSets
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT GroupAnimSets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: bCollapsed
    /// </summary>
    public unsafe bool bCollapsed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 136); }
    }

    /// <summary>
    /// BoolProperty: bVisible
    /// </summary>
    public unsafe bool bVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 136); }
    }

    /// <summary>
    /// BoolProperty: bIsFolder
    /// </summary>
    public unsafe bool bIsFolder
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 136); }
    }

    /// <summary>
    /// BoolProperty: bIsParented
    /// </summary>
    public unsafe bool bIsParented
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 136); }
    }

    /// <summary>
    /// BoolProperty: bIsSelected
    /// </summary>
    public unsafe bool bIsSelected
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 136); }
    }

    /// <summary>
    /// BoolProperty: CinematicProxy_DisableChangePoseOnFinish
    /// </summary>
    public unsafe bool CinematicProxy_DisableChangePoseOnFinish
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 136); }
    }

    /// <summary>
    /// BoolProperty: CinematicProxy_VehicleRollingAtEnd
    /// </summary>
    public unsafe bool CinematicProxy_VehicleRollingAtEnd
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 136); }
    }

    /// <summary>
    /// BoolProperty: CinematicProxy_VehicleSleepAtEnd
    /// </summary>
    public unsafe bool CinematicProxy_VehicleSleepAtEnd
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 136); }
    }

    /// <summary>
    /// BoolProperty: CinematicProxy_VehicleFullyAnimated
    /// </summary>
    public unsafe bool CinematicProxy_VehicleFullyAnimated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 136); }
    }

    /// <summary>
    /// BoolProperty: CinematicProxy_VehicleFullyAnimatedUseCustomAnimNode
    /// </summary>
    public unsafe bool CinematicProxy_VehicleFullyAnimatedUseCustomAnimNode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 136); }
    }

    /// <summary>
    /// BoolProperty: CinematicProxy_VehicleRemainsDynamic
    /// </summary>
    public unsafe bool CinematicProxy_VehicleRemainsDynamic
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 136); }
    }

    /// <summary>
    /// BoolProperty: CinematicProxy_VehicleBlendAllAxes
    /// </summary>
    public unsafe bool CinematicProxy_VehicleBlendAllAxes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 136); }
    }

    /// <summary>
    /// BoolProperty: CinematicProxy_VehicleChainMatineeAtEnd
    /// </summary>
    public unsafe bool CinematicProxy_VehicleChainMatineeAtEnd
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 136); }
    }

    /// <summary>
    /// BoolProperty: CinematicProxy_SimpleBlendFromBattleMode
    /// </summary>
    public unsafe bool CinematicProxy_SimpleBlendFromBattleMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 136); }
    }

    /// <summary>
    /// BoolProperty: CinematicProxy_VehicleResetWheelRotationAtStart
    /// </summary>
    public unsafe bool CinematicProxy_VehicleResetWheelRotationAtStart
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 136); }
    }

    /// <summary>
    /// BoolProperty: CinematicProxy_VehicleDisableFakeWheelUpdate
    /// </summary>
    public unsafe bool CinematicProxy_VehicleDisableFakeWheelUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 136); }
    }

    /// <summary>
    /// FloatProperty: CinematicProxy_BlendInDuration
    /// </summary>
    public unsafe float CinematicProxy_BlendInDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// FloatProperty: CinematicProxy_BlendOutDuration
    /// </summary>
    public unsafe float CinematicProxy_BlendOutDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// FloatProperty: CinematicProxy_VehicleThrottle
    /// </summary>
    public unsafe float CinematicProxy_VehicleThrottle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// NameProperty: CinematicProxy_PlayerEndState
    /// </summary>
    public unsafe BmSDK.FName CinematicProxy_PlayerEndState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// FloatProperty: DelayedStartupTime
    /// </summary>
    public unsafe float DelayedStartupTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }
}
