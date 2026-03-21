#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: UIDataStore_Strings<br/>
/// (size = 120)
/// (flags = 134217882)
/// </summary>
public partial class UIDataStore_Strings : BmSDK.Engine.UIDataStore_StringBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.UIDataStore_Strings", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal UIDataStore_Strings() { }

    /// <summary>
    /// Constructs a new UIDataStore_Strings
    /// </summary>
    public UIDataStore_Strings(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, UIDataStore_Strings Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected UIDataStore_Strings(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: LocFileProviders
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.UIConfigFileProvider> LocFileProviders
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.UIConfigFileProvider>>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }
}
