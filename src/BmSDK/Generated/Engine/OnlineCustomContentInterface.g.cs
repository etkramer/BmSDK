#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: OnlineCustomContentInterface<br/>
/// (flags = 0)
/// </summary>
public partial class OnlineCustomContentInterface : BmSDK.Interface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.OnlineCustomContentInterface", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal OnlineCustomContentInterface() { }

    /// <summary>
    /// Constructs a new OnlineCustomContentInterface
    /// </summary>
    public OnlineCustomContentInterface(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, OnlineCustomContentInterface Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected OnlineCustomContentInterface(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: CancelCustomContentRequest
    /// </summary>
    public unsafe void CancelCustomContentRequest(BmSDK.FString sCustomId)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineCustomContentInterface.CancelCustomContentRequest", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sCustomId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetCustomContentAsString
    /// </summary>
    public unsafe void GetCustomContentAsString(BmSDK.FString sCustomId, out BmSDK.FString ContentData)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineCustomContentInterface.GetCustomContentAsString", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sCustomId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ContentData = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 16);
        return;
    }

    /// <summary>
    /// Function: GetCustomContent
    /// </summary>
    public unsafe void GetCustomContent(BmSDK.FString sCustomId, out BmSDK.TArray<byte> ContentData)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineCustomContentInterface.GetCustomContent", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sCustomId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ContentData = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(paramsPtr + 16);
        return;
    }

    /// <summary>
    /// Function: StartCustomContentRequest
    /// </summary>
    public unsafe void StartCustomContentRequest(BmSDK.FString sContentName, BmSDK.FString sCustomId, System.IntPtr dReadCustomContentComplete, BmSDK.Engine.OnlineSubsystem.ECustomContentAccessMode eCCAM = default, BmSDK.FString Category = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineCustomContentInterface.StartCustomContentRequest", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sContentName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sCustomId, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dReadCustomContentComplete, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(eCCAM, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Category, paramsPtr + 52);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsCustomContentAccessModeAvailable
    /// </summary>
    public unsafe bool IsCustomContentAccessModeAvailable(BmSDK.Engine.OnlineSubsystem.ECustomContentAccessMode eCCAM)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineCustomContentInterface.IsCustomContentAccessModeAvailable", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(eCCAM, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IsCustomContentTypeAvailable
    /// </summary>
    public unsafe bool IsCustomContentTypeAvailable(BmSDK.Engine.OnlineSubsystem.ECustomContentType CustomContentType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineCustomContentInterface.IsCustomContentTypeAvailable", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomContentType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IsCustomContentAvailable
    /// </summary>
    public unsafe bool IsCustomContentAvailable()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineCustomContentInterface.IsCustomContentAvailable", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }
}
