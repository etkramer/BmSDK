#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: DrawConeComponent<br/>
/// (size = 420)
/// (flags = 2290102418)
/// </summary>
public partial class DrawConeComponent : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.DrawConeComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal DrawConeComponent() { }

    /// <summary>
    /// Constructs a new DrawConeComponent
    /// </summary>
    public DrawConeComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, DrawConeComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected DrawConeComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: ConeColor
    /// </summary>
    public unsafe BmSDK.GameObject.FColor ConeColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// FloatProperty: ConeRadius
    /// </summary>
    public unsafe float ConeRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// FloatProperty: ConeAngle
    /// </summary>
    public unsafe float ConeAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// IntProperty: ConeSides
    /// </summary>
    public unsafe int ConeSides
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }
}
