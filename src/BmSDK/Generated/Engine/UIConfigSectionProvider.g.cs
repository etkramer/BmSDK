#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: UIConfigSectionProvider<br/>
/// (size = 88)
/// (flags = 134217882)
/// </summary>
public partial class UIConfigSectionProvider : BmSDK.Engine.UIConfigProvider, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.UIConfigSectionProvider", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal UIConfigSectionProvider() { }

    /// <summary>
    /// Constructs a new UIConfigSectionProvider
    /// </summary>
    public UIConfigSectionProvider(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, UIConfigSectionProvider Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected UIConfigSectionProvider(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: SectionName
    /// </summary>
    public unsafe BmSDK.FString SectionName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 76); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }
    }
}
