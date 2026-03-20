#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: UIResourceDataProvider<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class UIResourceDataProvider : BmSDK.Engine.UIPropertyDataProvider, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.UIResourceDataProvider", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal UIResourceDataProvider() { }

    /// <summary>
    /// Constructs a new UIResourceDataProvider
    /// </summary>
    public UIResourceDataProvider(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, UIResourceDataProvider Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected UIResourceDataProvider(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: BadCapsLocContexts
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> BadCapsLocContexts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// Enum: EInputPlatformType
    /// </summary>
    public enum EInputPlatformType
    {
        IPT_PC = 0,
        IPT = 1,
        IPT_PS3 = 2,
        IPT_MAX = 3,
    }
}
