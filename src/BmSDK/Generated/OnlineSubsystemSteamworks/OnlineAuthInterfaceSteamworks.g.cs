#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.OnlineSubsystemSteamworks;

/// <summary>
/// Class: OnlineAuthInterfaceSteamworks<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class OnlineAuthInterfaceSteamworks : BmSDK.IpDrv.OnlineAuthInterfaceImpl, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "OnlineSubsystemSteamworks.OnlineAuthInterfaceSteamworks", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal OnlineAuthInterfaceSteamworks() { }

    /// <summary>
    /// Constructs a new OnlineAuthInterfaceSteamworks
    /// </summary>
    public OnlineAuthInterfaceSteamworks(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, OnlineAuthInterfaceSteamworks Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected OnlineAuthInterfaceSteamworks(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: VfTable_IOnlineAuthInterface
    /// </summary>
    public unsafe System.IntPtr VfTable_IOnlineAuthInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ObjectProperty: OwningSubsystem
    /// </summary>
    public unsafe BmSDK.IpDrv.OnlineSubsystemCommonImpl OwningSubsystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.IpDrv.OnlineSubsystemCommonImpl>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: bAuthReady
    /// </summary>
    public unsafe bool bAuthReady
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// StructProperty: ClientAuthSessions
    /// </summary>
    public unsafe BmSDK.GameObject.FSparseArray_Mirror ClientAuthSessions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FSparseArray_Mirror>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// StructProperty: ServerAuthSessions
    /// </summary>
    public unsafe BmSDK.GameObject.FSparseArray_Mirror ServerAuthSessions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FSparseArray_Mirror>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// StructProperty: PeerAuthSessions
    /// </summary>
    public unsafe BmSDK.GameObject.FSparseArray_Mirror PeerAuthSessions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FSparseArray_Mirror>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }

    /// <summary>
    /// StructProperty: LocalClientAuthSessions
    /// </summary>
    public unsafe BmSDK.GameObject.FSparseArray_Mirror LocalClientAuthSessions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FSparseArray_Mirror>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// StructProperty: LocalServerAuthSessions
    /// </summary>
    public unsafe BmSDK.GameObject.FSparseArray_Mirror LocalServerAuthSessions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FSparseArray_Mirror>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }

    /// <summary>
    /// StructProperty: LocalPeerAuthSessions
    /// </summary>
    public unsafe BmSDK.GameObject.FSparseArray_Mirror LocalPeerAuthSessions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FSparseArray_Mirror>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// ArrayProperty: AuthReadyDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> AuthReadyDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }

    /// <summary>
    /// ArrayProperty: ClientAuthRequestDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> ClientAuthRequestDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// ArrayProperty: ServerAuthRequestDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> ServerAuthRequestDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }

    /// <summary>
    /// ArrayProperty: ClientAuthResponseDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> ClientAuthResponseDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// ArrayProperty: ServerAuthResponseDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> ServerAuthResponseDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// ArrayProperty: ClientAuthCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> ClientAuthCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// ArrayProperty: ServerAuthCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> ServerAuthCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// ArrayProperty: ClientAuthEndSessionRequestDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> ClientAuthEndSessionRequestDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// ArrayProperty: ServerAuthRetryRequestDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> ServerAuthRetryRequestDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// ArrayProperty: ClientConnectionCloseDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> ClientConnectionCloseDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// ArrayProperty: ServerConnectionCloseDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> ServerConnectionCloseDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// DelegateProperty: __OnAuthReady__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnAuthReady__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// DelegateProperty: __OnClientAuthRequest__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnClientAuthRequest__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }

    /// <summary>
    /// DelegateProperty: __OnServerAuthRequest__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnServerAuthRequest__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// DelegateProperty: __OnClientAuthResponse__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnClientAuthResponse__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// DelegateProperty: __OnServerAuthResponse__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnServerAuthResponse__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }

    /// <summary>
    /// DelegateProperty: __OnClientAuthComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnClientAuthComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// DelegateProperty: __OnServerAuthComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnServerAuthComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// DelegateProperty: __OnClientAuthEndSessionRequest__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnClientAuthEndSessionRequest__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// DelegateProperty: __OnServerAuthRetryRequest__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnServerAuthRetryRequest__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// DelegateProperty: __OnClientConnectionClose__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnClientConnectionClose__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// DelegateProperty: __OnServerConnectionClose__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnServerConnectionClose__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }
}
