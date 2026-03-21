#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RClimbLocatorContainer<br/>
/// (size = 56)
/// (flags = 134221970)
/// </summary>
public partial class RClimbLocatorContainer : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RClimbLocatorContainer", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RClimbLocatorContainer() { }

    /// <summary>
    /// Constructs a new RClimbLocatorContainer
    /// </summary>
    public RClimbLocatorContainer(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RClimbLocatorContainer Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RClimbLocatorContainer(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: Locators
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RClimbLocator> Locators
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RClimbLocator>>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }
}
