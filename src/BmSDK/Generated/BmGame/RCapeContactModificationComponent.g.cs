#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RCapeContactModificationComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RCapeContactModificationComponent : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCapeContactModificationComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCapeContactModificationComponent() { }

    /// <summary>
    /// Constructs a new RCapeContactModificationComponent
    /// </summary>
    public RCapeContactModificationComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCapeContactModificationComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCapeContactModificationComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// ComponentProperty: CapeComponent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CapeComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }
}
