#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: OnlineAuthInterface<br/>
/// (size = 84)
/// (flags = 134234259)
/// </summary>
public partial interface OnlineAuthInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: GetServerAddr
    /// </summary>
    public unsafe bool GetServerAddr(out int OutServerIP, out int OutServerPort);

    /// <summary>
    /// Function: GetServerUniqueId
    /// </summary>
    public unsafe bool GetServerUniqueId(out BmSDK.Engine.OnlineSubsystem.FUniqueNetId OutServerUID);

    /// <summary>
    /// Function: FindLocalServerAuthSession
    /// </summary>
    public unsafe bool FindLocalServerAuthSession(BmSDK.Engine.Player ClientConnection, out BmSDK.Engine.OnlineAuthInterface.FLocalAuthSession OutSessionInfo);

    /// <summary>
    /// Function: FindServerAuthSession
    /// </summary>
    public unsafe bool FindServerAuthSession(BmSDK.Engine.Player ServerConnection, out BmSDK.Engine.OnlineAuthInterface.FAuthSession OutSessionInfo);

    /// <summary>
    /// Function: FindLocalClientAuthSession
    /// </summary>
    public unsafe bool FindLocalClientAuthSession(BmSDK.Engine.Player ServerConnection, out BmSDK.Engine.OnlineAuthInterface.FLocalAuthSession OutSessionInfo);

    /// <summary>
    /// Function: FindClientAuthSession
    /// </summary>
    public unsafe bool FindClientAuthSession(BmSDK.Engine.Player ClientConnection, out BmSDK.Engine.OnlineAuthInterface.FAuthSession OutSessionInfo);





    /// <summary>
    /// Function: EndAllRemoteServerAuthSessions
    /// </summary>
    public unsafe void EndAllRemoteServerAuthSessions();

    /// <summary>
    /// Function: EndAllLocalServerAuthSessions
    /// </summary>
    public unsafe void EndAllLocalServerAuthSessions();

    /// <summary>
    /// Function: EndRemoteServerAuthSession
    /// </summary>
    public unsafe void EndRemoteServerAuthSession(BmSDK.Engine.OnlineSubsystem.FUniqueNetId ServerUID, int ServerIP);

    /// <summary>
    /// Function: EndLocalServerAuthSession
    /// </summary>
    public unsafe void EndLocalServerAuthSession(BmSDK.Engine.OnlineSubsystem.FUniqueNetId ClientUID, int ClientIP);

    /// <summary>
    /// Function: VerifyServerAuthSession
    /// </summary>
    public unsafe bool VerifyServerAuthSession(BmSDK.Engine.OnlineSubsystem.FUniqueNetId ServerUID, int ServerIP, int AuthTicketUID);

    /// <summary>
    /// Function: CreateServerAuthSession
    /// </summary>
    public unsafe bool CreateServerAuthSession(BmSDK.Engine.OnlineSubsystem.FUniqueNetId ClientUID, int ClientIP, int ClientPort, out int OutAuthTicketUID);

    /// <summary>
    /// Function: EndAllRemoteClientAuthSessions
    /// </summary>
    public unsafe void EndAllRemoteClientAuthSessions();

    /// <summary>
    /// Function: EndAllLocalClientAuthSessions
    /// </summary>
    public unsafe void EndAllLocalClientAuthSessions();

    /// <summary>
    /// Function: EndRemoteClientAuthSession
    /// </summary>
    public unsafe void EndRemoteClientAuthSession(BmSDK.Engine.OnlineSubsystem.FUniqueNetId ClientUID, int ClientIP);

    /// <summary>
    /// Function: EndLocalClientAuthSession
    /// </summary>
    public unsafe void EndLocalClientAuthSession(BmSDK.Engine.OnlineSubsystem.FUniqueNetId ServerUID, int ServerIP, int ServerPort);

    /// <summary>
    /// Function: VerifyClientAuthSession
    /// </summary>
    public unsafe bool VerifyClientAuthSession(BmSDK.Engine.OnlineSubsystem.FUniqueNetId ClientUID, int ClientIP, int ClientPort, int AuthTicketUID);

    /// <summary>
    /// Function: CreateClientAuthSession
    /// </summary>
    public unsafe bool CreateClientAuthSession(BmSDK.Engine.OnlineSubsystem.FUniqueNetId ServerUID, int ServerIP, int ServerPort, bool bSecure, out int OutAuthTicketUID);

    /// <summary>
    /// Function: SendServerAuthRetryRequest
    /// </summary>
    public unsafe bool SendServerAuthRetryRequest();

    /// <summary>
    /// Function: SendClientAuthEndSessionRequest
    /// </summary>
    public unsafe bool SendClientAuthEndSessionRequest(BmSDK.Engine.Player ClientConnection);

    /// <summary>
    /// Function: SendServerAuthResponse
    /// </summary>
    public unsafe bool SendServerAuthResponse(BmSDK.Engine.Player ClientConnection, int AuthTicketUID);

    /// <summary>
    /// Function: SendClientAuthResponse
    /// </summary>
    public unsafe bool SendClientAuthResponse(int AuthTicketUID);

    /// <summary>
    /// Function: SendServerAuthRequest
    /// </summary>
    public unsafe bool SendServerAuthRequest(BmSDK.Engine.OnlineSubsystem.FUniqueNetId ServerUID);

    /// <summary>
    /// Function: SendClientAuthRequest
    /// </summary>
    public unsafe bool SendClientAuthRequest(BmSDK.Engine.Player ClientConnection, BmSDK.Engine.OnlineSubsystem.FUniqueNetId ClientUID);

    /// <summary>
    /// Function: ClearServerConnectionCloseDelegate
    /// </summary>
    public unsafe void ClearServerConnectionCloseDelegate(System.IntPtr ServerConnectionCloseDelegate);

    /// <summary>
    /// Function: AddServerConnectionCloseDelegate
    /// </summary>
    public unsafe void AddServerConnectionCloseDelegate(System.IntPtr ServerConnectionCloseDelegate);

    /// <summary>
    /// Function: OnServerConnectionClose
    /// </summary>
    public unsafe void OnServerConnectionClose(BmSDK.Engine.Player ServerConnection);

    /// <summary>
    /// Function: ClearClientConnectionCloseDelegate
    /// </summary>
    public unsafe void ClearClientConnectionCloseDelegate(System.IntPtr ClientConnectionCloseDelegate);

    /// <summary>
    /// Function: AddClientConnectionCloseDelegate
    /// </summary>
    public unsafe void AddClientConnectionCloseDelegate(System.IntPtr ClientConnectionCloseDelegate);

    /// <summary>
    /// Function: OnClientConnectionClose
    /// </summary>
    public unsafe void OnClientConnectionClose(BmSDK.Engine.Player ClientConnection);

    /// <summary>
    /// Function: ClearServerAuthRetryRequestDelegate
    /// </summary>
    public unsafe void ClearServerAuthRetryRequestDelegate(System.IntPtr ServerAuthRetryRequestDelegate);

    /// <summary>
    /// Function: AddServerAuthRetryRequestDelegate
    /// </summary>
    public unsafe void AddServerAuthRetryRequestDelegate(System.IntPtr ServerAuthRetryRequestDelegate);

    /// <summary>
    /// Function: OnServerAuthRetryRequest
    /// </summary>
    public unsafe void OnServerAuthRetryRequest(BmSDK.Engine.Player ClientConnection);

    /// <summary>
    /// Function: ClearClientAuthEndSessionRequestDelegate
    /// </summary>
    public unsafe void ClearClientAuthEndSessionRequestDelegate(System.IntPtr ClientAuthEndSessionRequestDelegate);

    /// <summary>
    /// Function: AddClientAuthEndSessionRequestDelegate
    /// </summary>
    public unsafe void AddClientAuthEndSessionRequestDelegate(System.IntPtr ClientAuthEndSessionRequestDelegate);

    /// <summary>
    /// Function: OnClientAuthEndSessionRequest
    /// </summary>
    public unsafe void OnClientAuthEndSessionRequest(BmSDK.Engine.Player ServerConnection);

    /// <summary>
    /// Function: ClearServerAuthCompleteDelegate
    /// </summary>
    public unsafe void ClearServerAuthCompleteDelegate(System.IntPtr ServerAuthCompleteDelegate);

    /// <summary>
    /// Function: AddServerAuthCompleteDelegate
    /// </summary>
    public unsafe void AddServerAuthCompleteDelegate(System.IntPtr ServerAuthCompleteDelegate);

    /// <summary>
    /// Function: OnServerAuthComplete
    /// </summary>
    public unsafe void OnServerAuthComplete(bool bSuccess, BmSDK.Engine.OnlineSubsystem.FUniqueNetId ServerUID, BmSDK.Engine.Player ServerConnection, BmSDK.FString ExtraInfo);

    /// <summary>
    /// Function: ClearClientAuthCompleteDelegate
    /// </summary>
    public unsafe void ClearClientAuthCompleteDelegate(System.IntPtr ClientAuthCompleteDelegate);

    /// <summary>
    /// Function: AddClientAuthCompleteDelegate
    /// </summary>
    public unsafe void AddClientAuthCompleteDelegate(System.IntPtr ClientAuthCompleteDelegate);

    /// <summary>
    /// Function: OnClientAuthComplete
    /// </summary>
    public unsafe void OnClientAuthComplete(bool bSuccess, BmSDK.Engine.OnlineSubsystem.FUniqueNetId ClientUID, BmSDK.Engine.Player ClientConnection, BmSDK.FString ExtraInfo);

    /// <summary>
    /// Function: ClearServerAuthResponseDelegate
    /// </summary>
    public unsafe void ClearServerAuthResponseDelegate(System.IntPtr ServerAuthResponseDelegate);

    /// <summary>
    /// Function: AddServerAuthResponseDelegate
    /// </summary>
    public unsafe void AddServerAuthResponseDelegate(System.IntPtr ServerAuthResponseDelegate);

    /// <summary>
    /// Function: OnServerAuthResponse
    /// </summary>
    public unsafe void OnServerAuthResponse(BmSDK.Engine.OnlineSubsystem.FUniqueNetId ServerUID, int ServerIP, int AuthTicketUID);

    /// <summary>
    /// Function: ClearClientAuthResponseDelegate
    /// </summary>
    public unsafe void ClearClientAuthResponseDelegate(System.IntPtr ClientAuthResponseDelegate);

    /// <summary>
    /// Function: AddClientAuthResponseDelegate
    /// </summary>
    public unsafe void AddClientAuthResponseDelegate(System.IntPtr ClientAuthResponseDelegate);

    /// <summary>
    /// Function: OnClientAuthResponse
    /// </summary>
    public unsafe void OnClientAuthResponse(BmSDK.Engine.OnlineSubsystem.FUniqueNetId ClientUID, int ClientIP, int AuthTicketUID);

    /// <summary>
    /// Function: ClearServerAuthRequestDelegate
    /// </summary>
    public unsafe void ClearServerAuthRequestDelegate(System.IntPtr ServerAuthRequestDelegate);

    /// <summary>
    /// Function: AddServerAuthRequestDelegate
    /// </summary>
    public unsafe void AddServerAuthRequestDelegate(System.IntPtr ServerAuthRequestDelegate);

    /// <summary>
    /// Function: OnServerAuthRequest
    /// </summary>
    public unsafe void OnServerAuthRequest(BmSDK.Engine.Player ClientConnection, BmSDK.Engine.OnlineSubsystem.FUniqueNetId ClientUID, int ClientIP, int ClientPort);

    /// <summary>
    /// Function: ClearClientAuthRequestDelegate
    /// </summary>
    public unsafe void ClearClientAuthRequestDelegate(System.IntPtr ClientAuthRequestDelegate);

    /// <summary>
    /// Function: AddClientAuthRequestDelegate
    /// </summary>
    public unsafe void AddClientAuthRequestDelegate(System.IntPtr ClientAuthRequestDelegate);

    /// <summary>
    /// Function: OnClientAuthRequest
    /// </summary>
    public unsafe void OnClientAuthRequest(BmSDK.Engine.OnlineSubsystem.FUniqueNetId ServerUID, int ServerIP, int ServerPort, bool bSecure);

    /// <summary>
    /// Function: ClearAuthReadyDelegate
    /// </summary>
    public unsafe void ClearAuthReadyDelegate(System.IntPtr AuthReadyDelegate);

    /// <summary>
    /// Function: AddAuthReadyDelegate
    /// </summary>
    public unsafe void AddAuthReadyDelegate(System.IntPtr AuthReadyDelegate);

    /// <summary>
    /// Function: OnAuthReady
    /// </summary>
    public unsafe void OnAuthReady();

    /// <summary>
    /// Function: IsReady
    /// </summary>
    public unsafe bool IsReady();

    /// <summary>
    /// Struct: FAuthSession
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FAuthSession
    {
        /// <summary>
        /// ByteProperty: AuthStatus
        /// </summary>
        public unsafe BmSDK.Engine.OnlineAuthInterface.EAuthStatus AuthStatus
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineAuthInterface.EAuthStatus>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: AuthTicketUID
        /// </summary>
        public unsafe int AuthTicketUID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Struct: FLocalAuthSession
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FLocalAuthSession
    {
        /// <summary>
        /// IntProperty: SessionUID
        /// </summary>
        public unsafe int SessionUID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FBaseAuthSession
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FBaseAuthSession
    {
        /// <summary>
        /// IntProperty: EndPointIP
        /// </summary>
        public unsafe int EndPointIP
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: EndPointPort
        /// </summary>
        public unsafe int EndPointPort
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: EndPointUID
        /// </summary>
        public unsafe BmSDK.Engine.OnlineSubsystem.FUniqueNetId EndPointUID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Enum: EAuthStatus
    /// </summary>
    public enum EAuthStatus
    {
        AUS_NotStarted = 0,
        AUS_Pending = 1,
        AUS_Authenticated = 2,
        AUS_Failed = 3,
        AUS_MAX = 4,
    }
}
