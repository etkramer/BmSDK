#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: UIGameInfoSummary<br/>
/// (size = 108)
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

}
