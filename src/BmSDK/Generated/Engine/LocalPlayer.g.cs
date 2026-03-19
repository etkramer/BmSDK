#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: LocalPlayer<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class LocalPlayer : BmSDK.Engine.Player, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.LocalPlayer", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal LocalPlayer() { }

    /// <summary>
    /// Constructs a new LocalPlayer
    /// </summary>
    public LocalPlayer(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, LocalPlayer Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected LocalPlayer(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: VfTable_FObserverInterface
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VfTable_FObserverInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// IntProperty: ControllerId
    /// </summary>
    public unsafe int ControllerId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// BoolProperty: bIsBound
    /// </summary>
    public unsafe bool bIsBound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 140); }
    }

    /// <summary>
    /// BoolProperty: IsXrayEnabled
    /// </summary>
    public unsafe bool IsXrayEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 140); }
    }

    /// <summary>
    /// BoolProperty: IsXrayKeepSceneLights
    /// </summary>
    public unsafe bool IsXrayKeepSceneLights
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 140); }
    }

    /// <summary>
    /// BoolProperty: IsXraySpecialShadingEnabled
    /// </summary>
    public unsafe bool IsXraySpecialShadingEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 140); }
    }

    /// <summary>
    /// BoolProperty: IsXrayPointCloudVSEnabled
    /// </summary>
    public unsafe bool IsXrayPointCloudVSEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 140); }
    }

    /// <summary>
    /// BoolProperty: IsXrayInstantReset
    /// </summary>
    public unsafe bool IsXrayInstantReset
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 140); }
    }

    /// <summary>
    /// BoolProperty: IsScanModeEnabled
    /// </summary>
    public unsafe bool IsScanModeEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 140); }
    }

    /// <summary>
    /// BoolProperty: IsThermalEnabled
    /// </summary>
    public unsafe bool IsThermalEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 140); }
    }

    /// <summary>
    /// BoolProperty: IsMapViewEnabled
    /// </summary>
    public unsafe bool IsMapViewEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 140); }
    }

    /// <summary>
    /// BoolProperty: IsBatMobileEnabled
    /// </summary>
    public unsafe bool IsBatMobileEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 140); }
    }

    /// <summary>
    /// BoolProperty: IsGauntletProjectionEnabled
    /// </summary>
    public unsafe bool IsGauntletProjectionEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 140); }
    }

    /// <summary>
    /// BoolProperty: IsDisruptorSniperViewModeEnabled
    /// </summary>
    public unsafe bool IsDisruptorSniperViewModeEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 140); }
    }

    /// <summary>
    /// BoolProperty: IsDLCExtraViewModeEnabled
    /// </summary>
    public unsafe bool IsDLCExtraViewModeEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 140); }
    }

    /// <summary>
    /// BoolProperty: IsInsignificantForLODs
    /// </summary>
    public unsafe bool IsInsignificantForLODs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 140); }
    }

    /// <summary>
    /// BoolProperty: bForceDefaultPostProcessChain
    /// </summary>
    public unsafe bool bForceDefaultPostProcessChain
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 140); }
    }

    /// <summary>
    /// BoolProperty: bWantToResetToMapDefaultPP
    /// </summary>
    public unsafe bool bWantToResetToMapDefaultPP
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 140); }
    }

    /// <summary>
    /// BoolProperty: bSentSplitJoin
    /// </summary>
    public unsafe bool bSentSplitJoin
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 140); }
    }

    /// <summary>
    /// BoolProperty: bInstantlySwitchPostProcessVolume
    /// </summary>
    public unsafe bool bInstantlySwitchPostProcessVolume
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 140); }
    }

    /// <summary>
    /// BoolProperty: bPendingServerAuth
    /// </summary>
    public unsafe bool bPendingServerAuth
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 140); }
    }

    /// <summary>
    /// ObjectProperty: ViewportClient
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ViewportClient
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// ObjectProperty: PlayerPostProcess
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerPostProcess
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// ObjectProperty: TagContext
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TagContext
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// StructProperty: Origin
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Origin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// StructProperty: Size
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Size
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// ArrayProperty: PlayerPostProcessChains
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.LocalPlayer.LevelPPInfo> PlayerPostProcessChains
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.LocalPlayer.LevelPPInfo>>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }

    /// <summary>
    /// StructProperty: ViewState
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ViewState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// StructProperty: ViewState2
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ViewState2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// StructProperty: ActorVisibilityHistory
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ActorVisibilityHistory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }

    /// <summary>
    /// StructProperty: LastViewLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LastViewLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }

    /// <summary>
    /// StructProperty: CurrentPPInfo
    /// </summary>
    public unsafe BmSDK.Engine.LocalPlayer.LevelPPInfo CurrentPPInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.LocalPlayer.LevelPPInfo>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// StructProperty: LevelPPInfo
    /// </summary>
    public unsafe BmSDK.Engine.LocalPlayer.ActivePPOverrides LevelPPInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.LocalPlayer.ActivePPOverrides>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// ArrayProperty: ActivePPOverrides
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ActivePPOverrides
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1324); }
    }

    /// <summary>
    /// ByteProperty: AspectRatioAxisConstraint
    /// </summary>
    public unsafe byte AspectRatioAxisConstraint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1340); }
    }

    /// <summary>
    /// StrProperty: LastMap
    /// </summary>
    public unsafe BmSDK.FString LastMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1344); }
    }

    /// <summary>
    /// InterfaceProperty: CachedAuthInt
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CachedAuthInt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1360); }
    }

    /// <summary>
    /// FloatProperty: ServerAuthTimestamp
    /// </summary>
    public unsafe float ServerAuthTimestamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1376); }
    }

    /// <summary>
    /// IntProperty: ServerAuthTimeout
    /// </summary>
    public unsafe int ServerAuthTimeout
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1380); }
    }

    /// <summary>
    /// IntProperty: ServerAuthRetryCount
    /// </summary>
    public unsafe int ServerAuthRetryCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1384); }
    }

    /// <summary>
    /// IntProperty: MaxServerAuthRetryCount
    /// </summary>
    public unsafe int MaxServerAuthRetryCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1388); }
    }

    /// <summary>
    /// StructProperty: ServerAuthUID
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ServerAuthUID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1392); }
    }
}
