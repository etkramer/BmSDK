#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: WindPointSourceComponent<br/>
/// (size = 100)
/// (flags = 142618770)
/// </summary>
public partial class WindPointSourceComponent : BmSDK.Engine.WindDirectionalSourceComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.WindPointSourceComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal WindPointSourceComponent() { }

    /// <summary>
    /// Constructs a new WindPointSourceComponent
    /// </summary>
    public WindPointSourceComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, WindPointSourceComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected WindPointSourceComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// ComponentProperty: PreviewRadiusComponent
    /// </summary>
    public unsafe BmSDK.Engine.DrawSphereComponent PreviewRadiusComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DrawSphereComponent>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// FloatProperty: Radius
    /// </summary>
    public unsafe float Radius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }
}
