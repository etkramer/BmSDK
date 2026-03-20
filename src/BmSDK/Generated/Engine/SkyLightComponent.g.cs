#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SkyLightComponent<br/>
/// (size = 620)
/// (flags = 136319122)
/// </summary>
public partial class SkyLightComponent : BmSDK.Engine.LightComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SkyLightComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SkyLightComponent() { }

    /// <summary>
    /// Constructs a new SkyLightComponent
    /// </summary>
    public SkyLightComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SkyLightComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SkyLightComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: LowerBrightness
    /// </summary>
    public unsafe float LowerBrightness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// StructProperty: LowerColor
    /// </summary>
    public unsafe BmSDK.GameObject.FColor LowerColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }
}
