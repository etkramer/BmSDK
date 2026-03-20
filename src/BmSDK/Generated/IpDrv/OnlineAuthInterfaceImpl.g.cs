#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.IpDrv;

/// <summary>
/// Class: OnlineAuthInterfaceImpl<br/>
/// (flags = 0)
/// </summary>
public partial class OnlineAuthInterfaceImpl : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "IpDrv.OnlineAuthInterfaceImpl", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal OnlineAuthInterfaceImpl() { }

    /// <summary>
    /// Constructs a new OnlineAuthInterfaceImpl
    /// </summary>
    public OnlineAuthInterfaceImpl(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, OnlineAuthInterfaceImpl Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected OnlineAuthInterfaceImpl(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetServerAddr
    /// </summary>
    public unsafe bool GetServerAddr(out int OutServerIP, out int OutServerPort)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.GetServerAddr", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutServerIP = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
        OutServerPort = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: GetServerUniqueId
    /// </summary>
    public unsafe bool GetServerUniqueId(out BmSDK.Engine.OnlineSubsystem.FUniqueNetId OutServerUID)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.GetServerUniqueId", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutServerUID = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: FindLocalServerAuthSession
    /// </summary>
    public unsafe bool FindLocalServerAuthSession(BmSDK.Engine.Player ClientConnection, out BmSDK.Engine.OnlineAuthInterface.FLocalAuthSession OutSessionInfo)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.FindLocalServerAuthSession", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientConnection, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutSessionInfo = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineAuthInterface.FLocalAuthSession>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 28);
    }

    /// <summary>
    /// Function: FindServerAuthSession
    /// </summary>
    public unsafe bool FindServerAuthSession(BmSDK.Engine.Player ServerConnection, out BmSDK.Engine.OnlineAuthInterface.FAuthSession OutSessionInfo)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.FindServerAuthSession", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerConnection, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutSessionInfo = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineAuthInterface.FAuthSession>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 32);
    }

    /// <summary>
    /// Function: FindLocalClientAuthSession
    /// </summary>
    public unsafe bool FindLocalClientAuthSession(BmSDK.Engine.Player ServerConnection, out BmSDK.Engine.OnlineAuthInterface.FLocalAuthSession OutSessionInfo)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.FindLocalClientAuthSession", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerConnection, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutSessionInfo = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineAuthInterface.FLocalAuthSession>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 28);
    }

    /// <summary>
    /// Function: FindClientAuthSession
    /// </summary>
    public unsafe bool FindClientAuthSession(BmSDK.Engine.Player ClientConnection, out BmSDK.Engine.OnlineAuthInterface.FAuthSession OutSessionInfo)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.FindClientAuthSession", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientConnection, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutSessionInfo = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineAuthInterface.FAuthSession>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 32);
    }





    /// <summary>
    /// Function: EndAllRemoteServerAuthSessions
    /// </summary>
    public unsafe void EndAllRemoteServerAuthSessions()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.EndAllRemoteServerAuthSessions", true);
        byte* paramsPtr = stackalloc byte[64];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: EndAllLocalServerAuthSessions
    /// </summary>
    public unsafe void EndAllLocalServerAuthSessions()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.EndAllLocalServerAuthSessions", true);
        byte* paramsPtr = stackalloc byte[64];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: EndRemoteServerAuthSession
    /// </summary>
    public unsafe void EndRemoteServerAuthSession(BmSDK.Engine.OnlineSubsystem.FUniqueNetId ServerUID, int ServerIP)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.EndRemoteServerAuthSession", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerUID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerIP, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: EndLocalServerAuthSession
    /// </summary>
    public unsafe void EndLocalServerAuthSession(BmSDK.Engine.OnlineSubsystem.FUniqueNetId ClientUID, int ClientIP)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.EndLocalServerAuthSession", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientUID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientIP, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: VerifyServerAuthSession
    /// </summary>
    public unsafe bool VerifyServerAuthSession(BmSDK.Engine.OnlineSubsystem.FUniqueNetId ServerUID, int ServerIP, int AuthTicketUID)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.VerifyServerAuthSession", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerUID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerIP, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AuthTicketUID, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: CreateServerAuthSession
    /// </summary>
    public unsafe bool CreateServerAuthSession(BmSDK.Engine.OnlineSubsystem.FUniqueNetId ClientUID, int ClientIP, int ClientPort, out int OutAuthTicketUID)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.CreateServerAuthSession", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientUID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientIP, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientPort, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutAuthTicketUID = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: EndAllRemoteClientAuthSessions
    /// </summary>
    public unsafe void EndAllRemoteClientAuthSessions()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.EndAllRemoteClientAuthSessions", true);
        byte* paramsPtr = stackalloc byte[64];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: EndAllLocalClientAuthSessions
    /// </summary>
    public unsafe void EndAllLocalClientAuthSessions()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.EndAllLocalClientAuthSessions", true);
        byte* paramsPtr = stackalloc byte[64];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: EndRemoteClientAuthSession
    /// </summary>
    public unsafe void EndRemoteClientAuthSession(BmSDK.Engine.OnlineSubsystem.FUniqueNetId ClientUID, int ClientIP)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.EndRemoteClientAuthSession", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientUID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientIP, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: EndLocalClientAuthSession
    /// </summary>
    public unsafe void EndLocalClientAuthSession(BmSDK.Engine.OnlineSubsystem.FUniqueNetId ServerUID, int ServerIP, int ServerPort)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.EndLocalClientAuthSession", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerUID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerIP, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerPort, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: VerifyClientAuthSession
    /// </summary>
    public unsafe bool VerifyClientAuthSession(BmSDK.Engine.OnlineSubsystem.FUniqueNetId ClientUID, int ClientIP, int ClientPort, int AuthTicketUID)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.VerifyClientAuthSession", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientUID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientIP, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientPort, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AuthTicketUID, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: CreateClientAuthSession
    /// </summary>
    public unsafe bool CreateClientAuthSession(BmSDK.Engine.OnlineSubsystem.FUniqueNetId ServerUID, int ServerIP, int ServerPort, bool bSecure, out int OutAuthTicketUID)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.CreateClientAuthSession", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerUID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerIP, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerPort, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSecure, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutAuthTicketUID = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: SendServerAuthRetryRequest
    /// </summary>
    public unsafe bool SendServerAuthRetryRequest()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.SendServerAuthRetryRequest", true);
        byte* paramsPtr = stackalloc byte[64];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SendClientAuthEndSessionRequest
    /// </summary>
    public unsafe bool SendClientAuthEndSessionRequest(BmSDK.Engine.Player ClientConnection)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.SendClientAuthEndSessionRequest", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientConnection, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: SendServerAuthResponse
    /// </summary>
    public unsafe bool SendServerAuthResponse(BmSDK.Engine.Player ClientConnection, int AuthTicketUID)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.SendServerAuthResponse", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientConnection, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AuthTicketUID, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: SendClientAuthResponse
    /// </summary>
    public unsafe bool SendClientAuthResponse(int AuthTicketUID)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.SendClientAuthResponse", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AuthTicketUID, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: SendServerAuthRequest
    /// </summary>
    public unsafe bool SendServerAuthRequest(BmSDK.Engine.OnlineSubsystem.FUniqueNetId ServerUID)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.SendServerAuthRequest", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerUID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: SendClientAuthRequest
    /// </summary>
    public unsafe bool SendClientAuthRequest(BmSDK.Engine.Player ClientConnection, BmSDK.Engine.OnlineSubsystem.FUniqueNetId ClientUID)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.SendClientAuthRequest", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientConnection, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientUID, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: ClearServerConnectionCloseDelegate
    /// </summary>
    public unsafe void ClearServerConnectionCloseDelegate(System.IntPtr ServerConnectionCloseDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.ClearServerConnectionCloseDelegate", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerConnectionCloseDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddServerConnectionCloseDelegate
    /// </summary>
    public unsafe void AddServerConnectionCloseDelegate(System.IntPtr ServerConnectionCloseDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.AddServerConnectionCloseDelegate", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerConnectionCloseDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnServerConnectionClose
    /// </summary>
    public unsafe void OnServerConnectionClose(BmSDK.Engine.Player ServerConnection)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.OnServerConnectionClose", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerConnection, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearClientConnectionCloseDelegate
    /// </summary>
    public unsafe void ClearClientConnectionCloseDelegate(System.IntPtr ClientConnectionCloseDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.ClearClientConnectionCloseDelegate", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientConnectionCloseDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddClientConnectionCloseDelegate
    /// </summary>
    public unsafe void AddClientConnectionCloseDelegate(System.IntPtr ClientConnectionCloseDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.AddClientConnectionCloseDelegate", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientConnectionCloseDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnClientConnectionClose
    /// </summary>
    public unsafe void OnClientConnectionClose(BmSDK.Engine.Player ClientConnection)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.OnClientConnectionClose", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientConnection, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearServerAuthRetryRequestDelegate
    /// </summary>
    public unsafe void ClearServerAuthRetryRequestDelegate(System.IntPtr ServerAuthRetryRequestDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.ClearServerAuthRetryRequestDelegate", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerAuthRetryRequestDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddServerAuthRetryRequestDelegate
    /// </summary>
    public unsafe void AddServerAuthRetryRequestDelegate(System.IntPtr ServerAuthRetryRequestDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.AddServerAuthRetryRequestDelegate", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerAuthRetryRequestDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnServerAuthRetryRequest
    /// </summary>
    public unsafe void OnServerAuthRetryRequest(BmSDK.Engine.Player ClientConnection)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.OnServerAuthRetryRequest", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientConnection, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearClientAuthEndSessionRequestDelegate
    /// </summary>
    public unsafe void ClearClientAuthEndSessionRequestDelegate(System.IntPtr ClientAuthEndSessionRequestDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.ClearClientAuthEndSessionRequestDelegate", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientAuthEndSessionRequestDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddClientAuthEndSessionRequestDelegate
    /// </summary>
    public unsafe void AddClientAuthEndSessionRequestDelegate(System.IntPtr ClientAuthEndSessionRequestDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.AddClientAuthEndSessionRequestDelegate", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientAuthEndSessionRequestDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnClientAuthEndSessionRequest
    /// </summary>
    public unsafe void OnClientAuthEndSessionRequest(BmSDK.Engine.Player ServerConnection)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.OnClientAuthEndSessionRequest", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerConnection, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearServerAuthCompleteDelegate
    /// </summary>
    public unsafe void ClearServerAuthCompleteDelegate(System.IntPtr ServerAuthCompleteDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.ClearServerAuthCompleteDelegate", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerAuthCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddServerAuthCompleteDelegate
    /// </summary>
    public unsafe void AddServerAuthCompleteDelegate(System.IntPtr ServerAuthCompleteDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.AddServerAuthCompleteDelegate", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerAuthCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnServerAuthComplete
    /// </summary>
    public unsafe void OnServerAuthComplete(bool bSuccess, BmSDK.Engine.OnlineSubsystem.FUniqueNetId ServerUID, BmSDK.Engine.Player ServerConnection, BmSDK.FString ExtraInfo)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.OnServerAuthComplete", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSuccess, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerUID, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerConnection, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtraInfo, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearClientAuthCompleteDelegate
    /// </summary>
    public unsafe void ClearClientAuthCompleteDelegate(System.IntPtr ClientAuthCompleteDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.ClearClientAuthCompleteDelegate", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientAuthCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddClientAuthCompleteDelegate
    /// </summary>
    public unsafe void AddClientAuthCompleteDelegate(System.IntPtr ClientAuthCompleteDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.AddClientAuthCompleteDelegate", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientAuthCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnClientAuthComplete
    /// </summary>
    public unsafe void OnClientAuthComplete(bool bSuccess, BmSDK.Engine.OnlineSubsystem.FUniqueNetId ClientUID, BmSDK.Engine.Player ClientConnection, BmSDK.FString ExtraInfo)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.OnClientAuthComplete", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSuccess, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientUID, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientConnection, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtraInfo, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearServerAuthResponseDelegate
    /// </summary>
    public unsafe void ClearServerAuthResponseDelegate(System.IntPtr ServerAuthResponseDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.ClearServerAuthResponseDelegate", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerAuthResponseDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddServerAuthResponseDelegate
    /// </summary>
    public unsafe void AddServerAuthResponseDelegate(System.IntPtr ServerAuthResponseDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.AddServerAuthResponseDelegate", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerAuthResponseDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnServerAuthResponse
    /// </summary>
    public unsafe void OnServerAuthResponse(BmSDK.Engine.OnlineSubsystem.FUniqueNetId ServerUID, int ServerIP, int AuthTicketUID)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.OnServerAuthResponse", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerUID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerIP, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AuthTicketUID, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearClientAuthResponseDelegate
    /// </summary>
    public unsafe void ClearClientAuthResponseDelegate(System.IntPtr ClientAuthResponseDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.ClearClientAuthResponseDelegate", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientAuthResponseDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddClientAuthResponseDelegate
    /// </summary>
    public unsafe void AddClientAuthResponseDelegate(System.IntPtr ClientAuthResponseDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.AddClientAuthResponseDelegate", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientAuthResponseDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnClientAuthResponse
    /// </summary>
    public unsafe void OnClientAuthResponse(BmSDK.Engine.OnlineSubsystem.FUniqueNetId ClientUID, int ClientIP, int AuthTicketUID)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.OnClientAuthResponse", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientUID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientIP, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AuthTicketUID, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearServerAuthRequestDelegate
    /// </summary>
    public unsafe void ClearServerAuthRequestDelegate(System.IntPtr ServerAuthRequestDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.ClearServerAuthRequestDelegate", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerAuthRequestDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddServerAuthRequestDelegate
    /// </summary>
    public unsafe void AddServerAuthRequestDelegate(System.IntPtr ServerAuthRequestDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.AddServerAuthRequestDelegate", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerAuthRequestDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnServerAuthRequest
    /// </summary>
    public unsafe void OnServerAuthRequest(BmSDK.Engine.Player ClientConnection, BmSDK.Engine.OnlineSubsystem.FUniqueNetId ClientUID, int ClientIP, int ClientPort)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.OnServerAuthRequest", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientConnection, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientUID, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientIP, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientPort, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearClientAuthRequestDelegate
    /// </summary>
    public unsafe void ClearClientAuthRequestDelegate(System.IntPtr ClientAuthRequestDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.ClearClientAuthRequestDelegate", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientAuthRequestDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddClientAuthRequestDelegate
    /// </summary>
    public unsafe void AddClientAuthRequestDelegate(System.IntPtr ClientAuthRequestDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.AddClientAuthRequestDelegate", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientAuthRequestDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnClientAuthRequest
    /// </summary>
    public unsafe void OnClientAuthRequest(BmSDK.Engine.OnlineSubsystem.FUniqueNetId ServerUID, int ServerIP, int ServerPort, bool bSecure)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.OnClientAuthRequest", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerUID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerIP, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerPort, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSecure, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearAuthReadyDelegate
    /// </summary>
    public unsafe void ClearAuthReadyDelegate(System.IntPtr AuthReadyDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.ClearAuthReadyDelegate", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AuthReadyDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddAuthReadyDelegate
    /// </summary>
    public unsafe void AddAuthReadyDelegate(System.IntPtr AuthReadyDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.AddAuthReadyDelegate", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AuthReadyDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnAuthReady
    /// </summary>
    public unsafe void OnAuthReady()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.OnAuthReady", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsReady
    /// </summary>
    public unsafe bool IsReady()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.OnlineAuthInterfaceImpl.IsReady", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

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
