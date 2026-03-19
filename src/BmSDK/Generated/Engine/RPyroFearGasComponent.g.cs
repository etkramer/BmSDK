#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RPyroFearGasComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RPyroFearGasComponent : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RPyroFearGasComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPyroFearGasComponent() { }

    /// <summary>
    /// Constructs a new RPyroFearGasComponent
    /// </summary>
    public RPyroFearGasComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPyroFearGasComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPyroFearGasComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: PyroFearGasSize
    /// </summary>
    public unsafe float PyroFearGasSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// StructProperty: AsyncJob
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AsyncJob
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// ObjectProperty: refDataMap
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT refDataMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// ObjectProperty: refLightMap
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT refLightMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// StructProperty: refBounds
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT refBounds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// StructProperty: refLevelOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT refLevelOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// ArrayProperty: cachedPoissonDisc
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT cachedPoissonDisc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// StructProperty: AsyncResults
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AsyncResults
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// StructProperty: PyroFearGasSettings
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PyroFearGasSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// StructProperty: WaveHeightTexRef
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT WaveHeightTexRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// StructProperty: PyroFearGasHeightTexRef
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PyroFearGasHeightTexRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }
}
