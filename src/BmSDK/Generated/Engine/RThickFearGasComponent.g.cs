#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RThickFearGasComponent<br/>
/// (flags = 0)
/// </summary>
public partial class RThickFearGasComponent : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RThickFearGasComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RThickFearGasComponent() { }

    /// <summary>
    /// Constructs a new RThickFearGasComponent
    /// </summary>
    public RThickFearGasComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RThickFearGasComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RThickFearGasComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: MeshRenderVolume
    /// </summary>
    public unsafe BmSDK.Engine.StaticMesh MeshRenderVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMesh>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// ObjectProperty: LightMap
    /// </summary>
    public unsafe BmSDK.Engine.Texture2D LightMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture2D>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// StructProperty: refLevelOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 refLevelOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// FloatProperty: activeDensityMod
    /// </summary>
    public unsafe float activeDensityMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// StructProperty: ThickFearGas
    /// </summary>
    public unsafe BmSDK.Engine.RThickFearGasComponent.FThickFearGasSettings ThickFearGas
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RThickFearGasComponent.FThickFearGasSettings>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }
}
