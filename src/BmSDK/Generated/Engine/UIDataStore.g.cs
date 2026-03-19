#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: UIDataStore<br/>
/// (size = 0)
/// (flags = 0)
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
    /// Constructs a new UIDataStore
    /// </summary>
    public UIDataStore(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, UIDataStore Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected UIDataStore(nint ptr) : base(ptr) { }

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
