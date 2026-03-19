#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: UIDataProvider_OnlinePlayerDataBase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class UIDataProvider_OnlinePlayerDataBase : BmSDK.Engine.UIDataProvider, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.UIDataProvider_OnlinePlayerDataBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal UIDataProvider_OnlinePlayerDataBase() { }

    /// <summary>
    /// Constructs a new UIDataProvider_OnlinePlayerDataBase
    /// </summary>
    public UIDataProvider_OnlinePlayerDataBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, UIDataProvider_OnlinePlayerDataBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected UIDataProvider_OnlinePlayerDataBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: PlayerControllerId
    /// </summary>
    public unsafe int PlayerControllerId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }
}
