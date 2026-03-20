#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ROnlineCustomContentCacheInterface<br/>
/// (flags = 0)
/// </summary>
public partial class ROnlineCustomContentCacheInterface : BmSDK.Interface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ROnlineCustomContentCacheInterface", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ROnlineCustomContentCacheInterface() { }

    /// <summary>
    /// Constructs a new ROnlineCustomContentCacheInterface
    /// </summary>
    public ROnlineCustomContentCacheInterface(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ROnlineCustomContentCacheInterface Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ROnlineCustomContentCacheInterface(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: FlagObsoleteInRegistry
    /// </summary>
    public unsafe bool FlagObsoleteInRegistry(BmSDK.FString Filename, BmSDK.FString Subfolder)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.ROnlineCustomContentCacheInterface.FlagObsoleteInRegistry", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Subfolder, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 32);
    }

    /// <summary>
    /// Function: UpdateRegistry
    /// </summary>
    public unsafe void UpdateRegistry(BmSDK.FString Filename, BmSDK.FString Subfolder, int Crc32, int Size, bool bObsolete)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.ROnlineCustomContentCacheInterface.UpdateRegistry", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Subfolder, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Crc32, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Size, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bObsolete, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddToDeleteQueue
    /// </summary>
    public unsafe void AddToDeleteQueue(BmSDK.Engine.OnlineCustomContentRequestCacheableHydra Request)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.ROnlineCustomContentCacheInterface.AddToDeleteQueue", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Request, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddToWriteQueue
    /// </summary>
    public unsafe void AddToWriteQueue(BmSDK.Engine.OnlineCustomContentRequestCacheableHydra Request)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.ROnlineCustomContentCacheInterface.AddToWriteQueue", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Request, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RemoveFromReadQueue
    /// </summary>
    public unsafe void RemoveFromReadQueue(BmSDK.Engine.OnlineCustomContentRequestCacheableHydra Request)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.ROnlineCustomContentCacheInterface.RemoveFromReadQueue", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Request, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddToReadQueue
    /// </summary>
    public unsafe void AddToReadQueue(BmSDK.Engine.OnlineCustomContentRequestCacheableHydra Request)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.ROnlineCustomContentCacheInterface.AddToReadQueue", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Request, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }
}
