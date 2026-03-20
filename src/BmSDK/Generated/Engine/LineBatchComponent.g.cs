#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: LineBatchComponent<br/>
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
    public unsafe System.IntPtr FPrimitiveDrawInterfaceVfTable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// StructProperty: FPrimitiveDrawInterfaceView
    /// </summary>
    public unsafe System.IntPtr FPrimitiveDrawInterfaceView
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// StructProperty: ThreadCheckDummy
    /// </summary>
    public unsafe System.IntPtr ThreadCheckDummy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 556); }
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
    public unsafe BmSDK.TArray<System.IntPtr> BatchedLines
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// ArrayProperty: BatchedPoints
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> BatchedPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// ArrayProperty: BatchedBoxes
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> BatchedBoxes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 600); }
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
