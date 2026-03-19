#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: LineBatchComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class LineBatchComponent : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.LineBatchComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal LineBatchComponent() { }

    /// <summary>
    /// Constructs a new LineBatchComponent
    /// </summary>
    public LineBatchComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, LineBatchComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected LineBatchComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: FPrimitiveDrawInterfaceVfTable
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FPrimitiveDrawInterfaceVfTable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// StructProperty: FPrimitiveDrawInterfaceView
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FPrimitiveDrawInterfaceView
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// StructProperty: ThreadCheckDummy
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ThreadCheckDummy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// IntProperty: BatchLineDrawDepth
    /// </summary>
    public unsafe int BatchLineDrawDepth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// ArrayProperty: BatchedLines
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT BatchedLines
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// ArrayProperty: BatchedPoints
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT BatchedPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// ArrayProperty: BatchedBoxes
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT BatchedBoxes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// FloatProperty: DefaultLifeTime
    /// </summary>
    public unsafe float DefaultLifeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// IntProperty: NextLineSubBatch
    /// </summary>
    public unsafe int NextLineSubBatch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// IntProperty: ActiveLineSubBatch
    /// </summary>
    public unsafe int ActiveLineSubBatch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// IntProperty: bUseSubBatching
    /// </summary>
    public unsafe int bUseSubBatching
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }
}
