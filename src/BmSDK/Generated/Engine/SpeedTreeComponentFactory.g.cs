#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SpeedTreeComponentFactory<br/>
/// (size = 56)
/// (flags = 142618770)
/// </summary>
public partial class SpeedTreeComponentFactory : BmSDK.Engine.PrimitiveComponentFactory, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SpeedTreeComponentFactory", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SpeedTreeComponentFactory() { }

    /// <summary>
    /// Constructs a new SpeedTreeComponentFactory
    /// </summary>
    public SpeedTreeComponentFactory(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SpeedTreeComponentFactory Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SpeedTreeComponentFactory(nint ptr) : base(ptr) { }

    /// <summary>
    /// ComponentProperty: SpeedTreeComponent
    /// </summary>
    public unsafe BmSDK.Engine.SpeedTreeComponent SpeedTreeComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SpeedTreeComponent>(Ptr + 52); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }
    }
}
