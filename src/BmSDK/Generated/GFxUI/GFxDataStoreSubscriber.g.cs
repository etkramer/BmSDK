#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.GFxUI;

/// <summary>
/// Class: GFxDataStoreSubscriber<br/>
/// (size = 52)
/// (flags = 134217874)
/// </summary>
public partial class GFxDataStoreSubscriber : BmSDK.GameObject, BmSDK.Engine.UIDataStorePublisher, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "GFxUI.GFxDataStoreSubscriber", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal GFxDataStoreSubscriber() { }

    /// <summary>
    /// Constructs a new GFxDataStoreSubscriber
    /// </summary>
    public GFxDataStoreSubscriber(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GFxDataStoreSubscriber Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GFxDataStoreSubscriber(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: SaveSubscriberValue
    /// </summary>
    public unsafe virtual bool SaveSubscriberValue(out BmSDK.TArray<BmSDK.Engine.UIDataStore> out_BoundDataStores, int BindingIndex = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "GFxUI.GFxDataStoreSubscriber.SaveSubscriberValue", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BindingIndex, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_BoundDataStores = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.UIDataStore>>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: ClearBoundDataStores
    /// </summary>
    public unsafe virtual void ClearBoundDataStores()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "GFxUI.GFxDataStoreSubscriber.ClearBoundDataStores", true);
        byte* paramsPtr = stackalloc byte[0];
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
    /// Function: GetBoundDataStores
    /// </summary>
    public unsafe virtual void GetBoundDataStores(out BmSDK.TArray<BmSDK.Engine.UIDataStore> out_BoundDataStores)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "GFxUI.GFxDataStoreSubscriber.GetBoundDataStores", true);
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_BoundDataStores = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.UIDataStore>>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: NotifyDataStoreValueUpdated
    /// </summary>
    public unsafe virtual void NotifyDataStoreValueUpdated(BmSDK.Engine.UIDataStore SourceDataStore, bool bValuesInvalidated, BmSDK.FName PropertyTag, BmSDK.Engine.UIDataProvider SourceProvider, int ArrayIndex)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "GFxUI.GFxDataStoreSubscriber.NotifyDataStoreValueUpdated", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SourceDataStore, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bValuesInvalidated, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PropertyTag, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SourceProvider, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArrayIndex, paramsPtr + 20);
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
    /// Function: RefreshSubscriberValue
    /// </summary>
    public unsafe virtual bool RefreshSubscriberValue(int BindingIndex = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "GFxUI.GFxDataStoreSubscriber.RefreshSubscriberValue", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BindingIndex, paramsPtr + 0);
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
    /// Function: GetDataStoreBinding
    /// </summary>
    public unsafe virtual BmSDK.FString GetDataStoreBinding(int BindingIndex = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "GFxUI.GFxDataStoreSubscriber.GetDataStoreBinding", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BindingIndex, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: SetDataStoreBinding
    /// </summary>
    public unsafe virtual void SetDataStoreBinding(BmSDK.FString MarkupText, int BindingIndex = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "GFxUI.GFxDataStoreSubscriber.SetDataStoreBinding", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MarkupText, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BindingIndex, paramsPtr + 12);
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
    /// Function: PublishValues
    /// </summary>
    public unsafe virtual void PublishValues()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "GFxUI.GFxDataStoreSubscriber.PublishValues", true);
        byte* paramsPtr = stackalloc byte[0];
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
    /// StructProperty: VfTable_IUIDataStorePublisher
    /// </summary>
    public unsafe System.IntPtr VfTable_IUIDataStorePublisher
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// ObjectProperty: Movie
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxMoviePlayer Movie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxMoviePlayer>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }
}
