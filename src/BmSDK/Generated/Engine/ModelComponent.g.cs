#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ModelComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ModelComponent : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ModelComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ModelComponent() { }

    /// <summary>
    /// Constructs a new ModelComponent
    /// </summary>
    public ModelComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ModelComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ModelComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Model
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Model
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// IntProperty: ZoneIndex
    /// </summary>
    public unsafe int ZoneIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// IntProperty: ComponentIndex
    /// </summary>
    public unsafe int ComponentIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// ArrayProperty: Nodes
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT Nodes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// ArrayProperty: Elements
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT Elements
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }
}
