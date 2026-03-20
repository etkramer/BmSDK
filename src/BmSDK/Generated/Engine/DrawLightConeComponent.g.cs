#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: DrawLightConeComponent<br/>
/// (flags = 0)
/// </summary>
public partial class DrawLightConeComponent : BmSDK.Engine.DrawConeComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.DrawLightConeComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal DrawLightConeComponent() { }

    /// <summary>
    /// Constructs a new DrawLightConeComponent
    /// </summary>
    public DrawLightConeComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, DrawLightConeComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected DrawLightConeComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: ConeColor
    /// </summary>
    public unsafe BmSDK.GameObject.FColor ConeColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// FloatProperty: ConeRadius
    /// </summary>
    public unsafe float ConeRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// FloatProperty: ConeAngle
    /// </summary>
    public unsafe float ConeAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// IntProperty: ConeSides
    /// </summary>
    public unsafe int ConeSides
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }
}
