#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: UIConfigFileProvider<br/>
/// (size = 100)
/// (flags = 134217882)
/// </summary>
public partial class UIConfigFileProvider : BmSDK.Engine.UIConfigProvider, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.UIConfigFileProvider", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal UIConfigFileProvider() { }

    /// <summary>
    /// Constructs a new UIConfigFileProvider
    /// </summary>
    public UIConfigFileProvider(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, UIConfigFileProvider Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected UIConfigFileProvider(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: Sections
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.UIConfigSectionProvider> Sections
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.UIConfigSectionProvider>>(Ptr + 76); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }
    }

    /// <summary>
    /// StrProperty: ConfigFileName
    /// </summary>
    public unsafe BmSDK.FString ConfigFileName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }
}
