#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: UIGameInfoSummary<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class UIGameInfoSummary : BmSDK.Engine.UIResourceDataProvider, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.UIGameInfoSummary", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal UIGameInfoSummary() { }

    /// <summary>
    /// Constructs a new UIGameInfoSummary
    /// </summary>
    public UIGameInfoSummary(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, UIGameInfoSummary Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected UIGameInfoSummary(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: BadCapsLocContexts
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT BadCapsLocContexts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 92); }
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
