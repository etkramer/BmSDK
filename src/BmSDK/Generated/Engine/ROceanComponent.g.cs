#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ROceanComponent<br/>
/// (flags = 0)
/// </summary>
public partial class ROceanComponent : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ROceanComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ROceanComponent() { }

    /// <summary>
    /// Constructs a new ROceanComponent
    /// </summary>
    public ROceanComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ROceanComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ROceanComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: OceanSize
    /// </summary>
    public unsafe float OceanSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// StructProperty: WaveHeightData
    /// </summary>
    public unsafe System.IntPtr WaveHeightData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// StructProperty: OceanHeightData
    /// </summary>
    public unsafe System.IntPtr OceanHeightData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// ArrayProperty: OceanAttenuationData
    /// </summary>
    public unsafe BmSDK.TArray<float> OceanAttenuationData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// IntProperty: AttenDataResolution
    /// </summary>
    public unsafe int AttenDataResolution
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// StructProperty: AsyncJob
    /// </summary>
    public unsafe System.IntPtr AsyncJob
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }

    /// <summary>
    /// ComponentProperty: refSprayVFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent refSprayVFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// ComponentProperty: refSprayFarVFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent refSprayFarVFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// ArrayProperty: refImpactVFX
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.ParticleSystemComponent> refImpactVFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.ParticleSystemComponent>>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// ArrayProperty: refImpactTimers
    /// </summary>
    public unsafe BmSDK.TArray<float> refImpactTimers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// ObjectProperty: refDataMap
    /// </summary>
    public unsafe BmSDK.Engine.Texture2D refDataMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture2D>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }

    /// <summary>
    /// StructProperty: refBounds
    /// </summary>
    public unsafe BmSDK.GameObject.FBoxSphereBounds refBounds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FBoxSphereBounds>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }

    /// <summary>
    /// StructProperty: refLevelOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 refLevelOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// ArrayProperty: cachedPoissonDisc
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector2> cachedPoissonDisc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector2>>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// StructProperty: AsyncResults
    /// </summary>
    public unsafe BmSDK.Engine.ROceanComponent.FRockOceanAsyncResults AsyncResults
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ROceanComponent.FRockOceanAsyncResults>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// StructProperty: OceanSettings
    /// </summary>
    public unsafe BmSDK.Engine.ROceanComponent.FRockOceanSettings OceanSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ROceanComponent.FRockOceanSettings>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// StructProperty: WaveHeightTexRef
    /// </summary>
    public unsafe System.IntPtr WaveHeightTexRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// StructProperty: OceanHeightTexRef
    /// </summary>
    public unsafe System.IntPtr OceanHeightTexRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }
}
