#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: UIDataStore_GameState<br/>
/// (flags = 0)
/// </summary>
public partial class UIDataStore_GameState : BmSDK.Engine.UIDataStore, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.UIDataStore_GameState", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal UIDataStore_GameState() { }

    /// <summary>
    /// Constructs a new UIDataStore_GameState
    /// </summary>
    public UIDataStore_GameState(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, UIDataStore_GameState Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected UIDataStore_GameState(nint ptr) : base(ptr) { }

    /// <summary>
    /// DelegateProperty: __OnRefreshDataFieldValue__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnRefreshDataFieldValue__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// Function: OnRefreshDataFieldValue
    /// </summary>
    public unsafe void OnRefreshDataFieldValue()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.UIDataStore_GameState.OnRefreshDataFieldValue", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }
}
