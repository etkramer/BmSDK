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
    public unsafe System.IntPtr AsyncJob
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// ObjectProperty: refDataMap
    /// </summary>
    public unsafe BmSDK.Engine.Texture2D refDataMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture2D>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// ObjectProperty: refLightMap
    /// </summary>
    public unsafe BmSDK.Engine.Texture2D refLightMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture2D>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// StructProperty: refBounds
    /// </summary>
    public unsafe BmSDK.GameObject.FBoxSphereBounds refBounds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FBoxSphereBounds>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// StructProperty: refLevelOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 refLevelOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// ArrayProperty: cachedPoissonDisc
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector2> cachedPoissonDisc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector2>>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// StructProperty: AsyncResults
    /// </summary>
    public unsafe BmSDK.Engine.RPyroFearGasComponent.FRockPyroFearGasAsyncResults AsyncResults
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RPyroFearGasComponent.FRockPyroFearGasAsyncResults>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// StructProperty: PyroFearGasSettings
    /// </summary>
    public unsafe BmSDK.Engine.RPyroFearGasComponent.FRockPyroFearGasSettings PyroFearGasSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RPyroFearGasComponent.FRockPyroFearGasSettings>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// StructProperty: WaveHeightTexRef
    /// </summary>
    public unsafe System.IntPtr WaveHeightTexRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// StructProperty: PyroFearGasHeightTexRef
    /// </summary>
    public unsafe System.IntPtr PyroFearGasHeightTexRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }
}
