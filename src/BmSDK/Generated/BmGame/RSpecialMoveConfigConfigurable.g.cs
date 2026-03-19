#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveConfigConfigurable<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSpecialMoveConfigConfigurable : BmSDK.BmGame.RSpecialMoveConfig, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveConfigConfigurable", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfigConfigurable() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfigConfigurable
    /// </summary>
    public RSpecialMoveConfigConfigurable(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfigConfigurable Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfigConfigurable(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Config
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Config
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }
}
