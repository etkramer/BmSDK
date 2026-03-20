#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AmbientPlus3DirectionalLightComponent<br/>
/// (size = 700)
/// (flags = 0)
/// </summary>
public partial class AmbientPlus3DirectionalLightComponent : BmSDK.Engine.LightComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AmbientPlus3DirectionalLightComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AmbientPlus3DirectionalLightComponent() { }

    /// <summary>
    /// Constructs a new AmbientPlus3DirectionalLightComponent
    /// </summary>
    public AmbientPlus3DirectionalLightComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AmbientPlus3DirectionalLightComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AmbientPlus3DirectionalLightComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bRenderBeforeModShadows
    /// </summary>
    public unsafe bool bRenderBeforeModShadows
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 612); }
    }

    /// <summary>
    /// StructProperty: LightDirections
    /// </summary>
    public unsafe System.Numerics.Vector3 LightDirections_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }
    /// <summary>
    /// StructProperty: LightDirections
    /// </summary>
    public unsafe System.Numerics.Vector3 LightDirections_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }
    /// <summary>
    /// StructProperty: LightDirections
    /// </summary>
    public unsafe System.Numerics.Vector3 LightDirections_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// StructProperty: LightColours
    /// </summary>
    public unsafe System.Numerics.Vector3 LightColours_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }
    /// <summary>
    /// StructProperty: LightColours
    /// </summary>
    public unsafe System.Numerics.Vector3 LightColours_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }
    /// <summary>
    /// StructProperty: LightColours
    /// </summary>
    public unsafe System.Numerics.Vector3 LightColours_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// StructProperty: Ambient
    /// </summary>
    public unsafe System.Numerics.Vector3 Ambient
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }
}
