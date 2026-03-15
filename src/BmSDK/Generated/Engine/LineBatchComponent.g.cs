#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: LineBatchComponent<br/>
/// (size = 456)
/// (flags = 2155872658)
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
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// StructProperty: FPrimitiveDrawInterfaceView
    /// </summary>
    public unsafe System.IntPtr FPrimitiveDrawInterfaceView
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// IntProperty: BatchLineDrawDepth
    /// </summary>
    public unsafe int BatchLineDrawDepth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// ArrayProperty: BatchedLines
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> BatchedLines
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// ArrayProperty: BatchedPoints
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> BatchedPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// FloatProperty: DefaultLifeTime
    /// </summary>
    public unsafe float DefaultLifeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }

    /// <summary>
    /// IntProperty: NextLineSubBatch
    /// </summary>
    public unsafe int NextLineSubBatch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// IntProperty: ActiveLineSubBatch
    /// </summary>
    public unsafe int ActiveLineSubBatch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// IntProperty: bUseSubBatching
    /// </summary>
    public unsafe int bUseSubBatching
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }
}
