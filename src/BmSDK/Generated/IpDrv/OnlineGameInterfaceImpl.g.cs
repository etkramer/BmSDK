#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.IpDrv;

/// <summary>
/// Class: OnlineGameInterfaceImpl<br/>
/// (flags = 0)
/// </summary>
public partial class OnlineGameInterfaceImpl : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "IpDrv.OnlineGameInterfaceImpl", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal OnlineGameInterfaceImpl() { }

    /// <summary>
    /// Constructs a new OnlineGameInterfaceImpl
    /// </summary>
    public OnlineGameInterfaceImpl(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, OnlineGameInterfaceImpl Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected OnlineGameInterfaceImpl(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: OwningSubsystem
    /// </summary>
    public unsafe BmSDK.IpDrv.OnlineSubsystemCommonImpl OwningSubsystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.IpDrv.OnlineSubsystemCommonImpl>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ObjectProperty: GameSettings
    /// </summary>
    public unsafe BmSDK.Engine.OnlineGameSettings GameSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineGameSettings>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ObjectProperty: GameSearch
    /// </summary>
    public unsafe BmSDK.Engine.OnlineGameSearch GameSearch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineGameSearch>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ArrayProperty: CreateOnlineGameCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> CreateOnlineGameCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ArrayProperty: UpdateOnlineGameCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> UpdateOnlineGameCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ArrayProperty: DestroyOnlineGameCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> DestroyOnlineGameCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ArrayProperty: JoinOnlineGameCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> JoinOnlineGameCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// ArrayProperty: MigrateOnlineGameCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> MigrateOnlineGameCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// ArrayProperty: JoinMigratedOnlineGameCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> JoinMigratedOnlineGameCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// ArrayProperty: RecalculateSkillRatingCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> RecalculateSkillRatingCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// ArrayProperty: StartOnlineGameCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> StartOnlineGameCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// ArrayProperty: EndOnlineGameCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> EndOnlineGameCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// ArrayProperty: FindOnlineGamesCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> FindOnlineGamesCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// ArrayProperty: CancelFindOnlineGamesCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> CancelFindOnlineGamesCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// ByteProperty: LanBeaconState
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem.ELanBeaconState LanBeaconState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.ELanBeaconState>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// ByteProperty: LanNonce
    /// </summary>
    public unsafe byte LanNonce_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 285); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 285); }
    }
    /// <summary>
    /// ByteProperty: LanNonce
    /// </summary>
    public unsafe byte LanNonce_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 286); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 286); }
    }
    /// <summary>
    /// ByteProperty: LanNonce
    /// </summary>
    public unsafe byte LanNonce_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 287); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 287); }
    }
    /// <summary>
    /// ByteProperty: LanNonce
    /// </summary>
    public unsafe byte LanNonce_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }
    /// <summary>
    /// ByteProperty: LanNonce
    /// </summary>
    public unsafe byte LanNonce_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 289); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 289); }
    }
    /// <summary>
    /// ByteProperty: LanNonce
    /// </summary>
    public unsafe byte LanNonce_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 290); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 290); }
    }
    /// <summary>
    /// ByteProperty: LanNonce
    /// </summary>
    public unsafe byte LanNonce_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 291); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 291); }
    }
    /// <summary>
    /// ByteProperty: LanNonce
    /// </summary>
    public unsafe byte LanNonce_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// IntProperty: LanAnnouncePort
    /// </summary>
    public unsafe int LanAnnouncePort
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }

    /// <summary>
    /// IntProperty: LanGameUniqueId
    /// </summary>
    public unsafe int LanGameUniqueId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }
    }

    /// <summary>
    /// IntProperty: LanPacketPlatformMask
    /// </summary>
    public unsafe int LanPacketPlatformMask
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// FloatProperty: LanQueryTimeLeft
    /// </summary>
    public unsafe float LanQueryTimeLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// FloatProperty: LanQueryTimeout
    /// </summary>
    public unsafe float LanQueryTimeout
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }

    /// <summary>
    /// StructProperty: LanBeacon
    /// </summary>
    public unsafe System.IntPtr LanBeacon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// StructProperty: SessionInfo
    /// </summary>
    public unsafe System.IntPtr SessionInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// DelegateProperty: __OnFindOnlineGamesComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnFindOnlineGamesComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }

    /// <summary>
    /// DelegateProperty: __OnCreateOnlineGameComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnCreateOnlineGameComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// DelegateProperty: __OnUpdateOnlineGameComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnUpdateOnlineGameComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }

    /// <summary>
    /// DelegateProperty: __OnDestroyOnlineGameComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnDestroyOnlineGameComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// DelegateProperty: __OnCancelFindOnlineGamesComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnCancelFindOnlineGamesComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// DelegateProperty: __OnJoinOnlineGameComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnJoinOnlineGameComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// DelegateProperty: __OnRegisterPlayerComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnRegisterPlayerComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// DelegateProperty: __OnUnregisterPlayerComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnUnregisterPlayerComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// DelegateProperty: __OnStartOnlineGameComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnStartOnlineGameComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 460); }
    }

    /// <summary>
    /// DelegateProperty: __OnEndOnlineGameComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnEndOnlineGameComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 476); }
    }

    /// <summary>
    /// DelegateProperty: __OnArbitrationRegistrationComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnArbitrationRegistrationComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }

    /// <summary>
    /// DelegateProperty: __OnGameInviteAccepted__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnGameInviteAccepted__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }

    /// <summary>
    /// DelegateProperty: __OnRecalculateSkillRatingComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnRecalculateSkillRatingComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 524); }
    }

    /// <summary>
    /// DelegateProperty: __OnMigrateOnlineGameComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnMigrateOnlineGameComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// DelegateProperty: __OnJoinMigratedOnlineGameComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnJoinMigratedOnlineGameComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// DelegateProperty: __OnQosStatusChanged__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnQosStatusChanged__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }
}
