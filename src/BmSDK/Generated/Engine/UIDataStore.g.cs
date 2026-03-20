#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// ABSTRACT Class: UIDataStore<br/>
/// (size = 148)
/// (flags = 134217887)
/// </summary>
public partial class UIDataStore : BmSDK.Engine.UIDataProvider, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.UIDataStore", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal UIDataStore() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected UIDataStore(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetDataStoreClient
    /// </summary>
    public unsafe virtual BmSDK.Engine.DataStoreClient GetDataStoreClient()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.UIDataStore.GetDataStoreClient", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DataStoreClient>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: RefreshSubscribers
    /// </summary>
    public unsafe virtual void RefreshSubscribers(BmSDK.FName PropertyTag = default, bool bInvalidateValues = default, BmSDK.Engine.UIDataProvider SourceProvider = default, int ArrayIndex = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.UIDataStore.RefreshSubscribers", true);
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PropertyTag, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInvalidateValues, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SourceProvider, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArrayIndex, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NotifyGameSessionEnded
    /// </summary>
    public unsafe virtual bool NotifyGameSessionEnded()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.UIDataStore.NotifyGameSessionEnded", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SubscriberDetached
    /// </summary>
    public unsafe virtual void SubscriberDetached(BmSDK.Engine.UIDataStoreSubscriber Subscriber)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.UIDataStore.SubscriberDetached", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Subscriber, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SubscriberAttached
    /// </summary>
    public unsafe virtual void SubscriberAttached(BmSDK.Engine.UIDataStoreSubscriber Subscriber)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.UIDataStore.SubscriberAttached", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Subscriber, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Unregistered
    /// </summary>
    public unsafe virtual void Unregistered(BmSDK.Engine.LocalPlayer PlayerOwner)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.UIDataStore.Unregistered", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerOwner, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Registered
    /// </summary>
    public unsafe virtual void Registered(BmSDK.Engine.LocalPlayer PlayerOwner)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.UIDataStore.Registered", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerOwner, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnDataStoreValueUpdated
    /// </summary>
    public unsafe virtual void OnDataStoreValueUpdated(BmSDK.Engine.UIDataStore SourceDataStore, bool bValuesInvalidated, BmSDK.FName PropertyTag, BmSDK.Engine.UIDataProvider SourceProvider, int ArrayIndex)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.UIDataStore.OnDataStoreValueUpdated", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SourceDataStore, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bValuesInvalidated, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PropertyTag, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SourceProvider, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArrayIndex, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// NameProperty: Tag
    /// </summary>
    public unsafe BmSDK.FName Tag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ArrayProperty: RefreshSubscriberNotifies
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> RefreshSubscriberNotifies
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// DelegateProperty: __OnDataStoreValueUpdated__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnDataStoreValueUpdated__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }
}
