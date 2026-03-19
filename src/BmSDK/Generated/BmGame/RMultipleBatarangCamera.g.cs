#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RMultipleBatarangCamera<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RMultipleBatarangCamera : BmSDK.BmGame.RBatarangCamera, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RMultipleBatarangCamera", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RMultipleBatarangCamera() { }

    /// <summary>
    /// Constructs a new RMultipleBatarangCamera
    /// </summary>
    public RMultipleBatarangCamera(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RMultipleBatarangCamera Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RMultipleBatarangCamera(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RMultipleBatarangCamera>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMultipleBatarangCamera>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RMultipleBatarangCamera>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMultipleBatarangCamera>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMultipleBatarangCamera>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RMultipleBatarangCamera>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMultipleBatarangCamera>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: TrackingBatarang
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TrackingBatarang
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }
    }

    /// <summary>
    /// ObjectProperty: TrackingActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TrackingActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }

    /// <summary>
    /// ObjectProperty: CurrentKillVolume
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CurrentKillVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1264); }
    }

    /// <summary>
    /// ObjectProperty: FlipAnimSet
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FlipAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1272); }
    }

    /// <summary>
    /// ObjectProperty: StoredTrackingEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT StoredTrackingEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1280); }
    }

    /// <summary>
    /// StructProperty: InitialRotation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT InitialRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1288); }
    }

    /// <summary>
    /// StructProperty: CameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1300); }
    }

    /// <summary>
    /// StructProperty: CameraRotationOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CameraRotationOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1312); }
    }

    /// <summary>
    /// BoolProperty: bIgnorePitch
    /// </summary>
    public unsafe bool bIgnorePitch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1324) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1324); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1324); }
    }

    /// <summary>
    /// BoolProperty: bDofChange
    /// </summary>
    public unsafe bool bDofChange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1324) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1324); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1324); }
    }

    /// <summary>
    /// BoolProperty: bAllowCancel
    /// </summary>
    public unsafe bool bAllowCancel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1324) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1324); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1324); }
    }

    /// <summary>
    /// BoolProperty: bFinished
    /// </summary>
    public unsafe bool bFinished
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1324) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1324); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1324); }
    }

    /// <summary>
    /// BoolProperty: bTrackingGrapple
    /// </summary>
    public unsafe bool bTrackingGrapple
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1324) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1324); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1324); }
    }

    /// <summary>
    /// BoolProperty: bExactBatarangAlignment
    /// </summary>
    public unsafe bool bExactBatarangAlignment
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1324) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1324); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1324); }
    }

    /// <summary>
    /// BoolProperty: bPlayingFlipAnimation
    /// </summary>
    public unsafe bool bPlayingFlipAnimation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1324) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1324); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1324); }
    }

    /// <summary>
    /// FloatProperty: FlightGameSpeed
    /// </summary>
    public unsafe float FlightGameSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1328); }
    }

    /// <summary>
    /// FloatProperty: SlowDownDuration
    /// </summary>
    public unsafe float SlowDownDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1332); }
    }

    /// <summary>
    /// FloatProperty: SpeedUpDuration
    /// </summary>
    public unsafe float SpeedUpDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1336); }
    }

    /// <summary>
    /// FloatProperty: CameraBlendSpeed
    /// </summary>
    public unsafe float CameraBlendSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1340); }
    }

    /// <summary>
    /// FloatProperty: BatarangComboFlightGameSpeed
    /// </summary>
    public unsafe float BatarangComboFlightGameSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1344); }
    }

    /// <summary>
    /// FloatProperty: BatarangComboSlowDownDuration
    /// </summary>
    public unsafe float BatarangComboSlowDownDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1348); }
    }

    /// <summary>
    /// FloatProperty: BatarangComboSpeedUpDuration
    /// </summary>
    public unsafe float BatarangComboSpeedUpDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1352); }
    }

    /// <summary>
    /// FloatProperty: ImpactTurnRate
    /// </summary>
    public unsafe float ImpactTurnRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1356); }
    }

    /// <summary>
    /// FloatProperty: CurrentGameSpeed
    /// </summary>
    public unsafe float CurrentGameSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1360); }
    }

    /// <summary>
    /// FloatProperty: MinFlightGameSpeed
    /// </summary>
    public unsafe float MinFlightGameSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1364); }
    }

    /// <summary>
    /// FloatProperty: HarpoonGameSpeed
    /// </summary>
    public unsafe float HarpoonGameSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1368); }
    }

    /// <summary>
    /// StructProperty: ScreenShakeSettings
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ScreenShakeSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1372); }
    }

    /// <summary>
    /// StructProperty: CameraDOFSettings
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CameraDOFSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1528); }
    }

    /// <summary>
    /// FloatProperty: BatarangCameraLag
    /// </summary>
    public unsafe float BatarangCameraLag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1548); }
    }

    /// <summary>
    /// FloatProperty: BatarangCameraRotationLag
    /// </summary>
    public unsafe float BatarangCameraRotationLag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1552); }
    }

    /// <summary>
    /// FloatProperty: OverrideFOV
    /// </summary>
    public unsafe float OverrideFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1556); }
    }

    /// <summary>
    /// FloatProperty: LastOverrideFOV
    /// </summary>
    public unsafe float LastOverrideFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1560); }
    }

    /// <summary>
    /// FloatProperty: OverrideFOVTimer
    /// </summary>
    public unsafe float OverrideFOVTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1564); }
    }

    /// <summary>
    /// FloatProperty: OverrideFOVTime
    /// </summary>
    public unsafe float OverrideFOVTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1568); }
    }

    /// <summary>
    /// FloatProperty: ExtraDistance
    /// </summary>
    public unsafe float ExtraDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1572); }
    }

    /// <summary>
    /// FloatProperty: LastExtraDistance
    /// </summary>
    public unsafe float LastExtraDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1576); }
    }

    /// <summary>
    /// FloatProperty: ExtraDistanceTimer
    /// </summary>
    public unsafe float ExtraDistanceTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1580); }
    }

    /// <summary>
    /// FloatProperty: ExtraDistanceTime
    /// </summary>
    public unsafe float ExtraDistanceTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1584); }
    }

    /// <summary>
    /// FloatProperty: CurrentExtraDistance
    /// </summary>
    public unsafe float CurrentExtraDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1588); }
    }

    /// <summary>
    /// StructProperty: OriginalCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT OriginalCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1592); }
    }

    /// <summary>
    /// FloatProperty: OriginalFOVAngle
    /// </summary>
    public unsafe float OriginalFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1604); }
    }

    /// <summary>
    /// FloatProperty: OverridePauseTime
    /// </summary>
    public unsafe float OverridePauseTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1608); }
    }

    /// <summary>
    /// ByteProperty: RollingDirection
    /// </summary>
    public unsafe byte RollingDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1612); }
    }

    /// <summary>
    /// NameProperty: FlipAnimName
    /// </summary>
    public unsafe BmSDK.FName FlipAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1616); }
    }

    /// <summary>
    /// StructProperty: FlipOldPosition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FlipOldPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1624); }
    }

    /// <summary>
    /// StructProperty: FlipOldRotation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FlipOldRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1636); }
    }

    /// <summary>
    /// StructProperty: InitialFlipAnimTransform
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT InitialFlipAnimTransform
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1648); }
    }

    /// <summary>
    /// StructProperty: InvInitialFlipAnimRotation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT InvInitialFlipAnimRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1664); }
    }
}
