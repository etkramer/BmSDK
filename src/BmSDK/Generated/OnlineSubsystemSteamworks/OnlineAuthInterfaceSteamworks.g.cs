#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.OnlineSubsystemSteamworks;

/// <summary>
/// Class: OnlineAuthInterfaceSteamworks<br/>
/// (size = 792)
/// (flags = 134217874)
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
    /// Function: GetServerAddr
    /// </summary>
    public unsafe override bool GetServerAddr(out int OutServerIP, out int OutServerPort)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "OnlineSubsystemSteamworks.OnlineAuthInterfaceSteamworks.GetServerAddr", true);
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutServerIP = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
        OutServerPort = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: GetServerUniqueId
    /// </summary>
    public unsafe override bool GetServerUniqueId(out BmSDK.Engine.OnlineSubsystem.FUniqueNetId OutServerUID)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "OnlineSubsystemSteamworks.OnlineAuthInterfaceSteamworks.GetServerUniqueId", true);
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutServerUID = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: VerifyServerAuthSession
    /// </summary>
    public unsafe override bool VerifyServerAuthSession(BmSDK.Engine.OnlineSubsystem.FUniqueNetId ServerUID, int ServerIP, int AuthTicketUID)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "OnlineSubsystemSteamworks.OnlineAuthInterfaceSteamworks.VerifyServerAuthSession", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerUID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerIP, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AuthTicketUID, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: CreateServerAuthSession
    /// </summary>
    public unsafe override bool CreateServerAuthSession(BmSDK.Engine.OnlineSubsystem.FUniqueNetId ClientUID, int ClientIP, int ClientPort, out int OutAuthTicketUID)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "OnlineSubsystemSteamworks.OnlineAuthInterfaceSteamworks.CreateServerAuthSession", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientUID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientIP, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientPort, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutAuthTicketUID = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: VerifyClientAuthSession
    /// </summary>
    public unsafe override bool VerifyClientAuthSession(BmSDK.Engine.OnlineSubsystem.FUniqueNetId ClientUID, int ClientIP, int ClientPort, int AuthTicketUID)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "OnlineSubsystemSteamworks.OnlineAuthInterfaceSteamworks.VerifyClientAuthSession", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientUID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientIP, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientPort, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AuthTicketUID, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: CreateClientAuthSession
    /// </summary>
    public unsafe override bool CreateClientAuthSession(BmSDK.Engine.OnlineSubsystem.FUniqueNetId ServerUID, int ServerIP, int ServerPort, bool bSecure, out int OutAuthTicketUID)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "OnlineSubsystemSteamworks.OnlineAuthInterfaceSteamworks.CreateClientAuthSession", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerUID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerIP, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerPort, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSecure, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutAuthTicketUID = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: SendServerAuthRequest
    /// </summary>
    public unsafe override bool SendServerAuthRequest(BmSDK.Engine.OnlineSubsystem.FUniqueNetId ServerUID)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "OnlineSubsystemSteamworks.OnlineAuthInterfaceSteamworks.SendServerAuthRequest", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ServerUID, paramsPtr + 0);
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
    /// Function: SendClientAuthRequest
    /// </summary>
    public unsafe override bool SendClientAuthRequest(BmSDK.Engine.Player ClientConnection, BmSDK.Engine.OnlineSubsystem.FUniqueNetId ClientUID)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "OnlineSubsystemSteamworks.OnlineAuthInterfaceSteamworks.SendClientAuthRequest", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientConnection, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClientUID, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }
}
