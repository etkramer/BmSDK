#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RockAtmos<br/>
/// (size = 404)
/// (flags = 0)
/// </summary>
public partial class RockAtmos : BmSDK.Engine.DOFBloomMotionBlurEffect, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RockAtmos", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RockAtmos() { }

    /// <summary>
    /// Constructs a new RockAtmos
    /// </summary>
    public RockAtmos(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RockAtmos Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RockAtmos(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: AtmosD1_Colour_PP
    /// </summary>
    public unsafe BmSDK.GameObject.FColor AtmosD1_Colour_PP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// FloatProperty: AtmosD1_Density_PP
    /// </summary>
    public unsafe float AtmosD1_Density_PP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// FloatProperty: AtmosD1_DistanceStart_PP
    /// </summary>
    public unsafe float AtmosD1_DistanceStart_PP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }

    /// <summary>
    /// FloatProperty: AtmosD1_DistanceEnd_PP
    /// </summary>
    public unsafe float AtmosD1_DistanceEnd_PP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// StructProperty: AtmosD2_Colour_PP
    /// </summary>
    public unsafe BmSDK.GameObject.FColor AtmosD2_Colour_PP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// FloatProperty: AtmosD2_Density_PP
    /// </summary>
    public unsafe float AtmosD2_Density_PP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// FloatProperty: AtmosD2_DistanceStart_PP
    /// </summary>
    public unsafe float AtmosD2_DistanceStart_PP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// FloatProperty: AtmosD2_DistanceEnd_PP
    /// </summary>
    public unsafe float AtmosD2_DistanceEnd_PP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// StructProperty: AtmosH1_Colour_PP
    /// </summary>
    public unsafe BmSDK.GameObject.FColor AtmosH1_Colour_PP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// FloatProperty: AtmosH1_Density_PP
    /// </summary>
    public unsafe float AtmosH1_Density_PP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// FloatProperty: AtmosH1_GradientSize_PP
    /// </summary>
    public unsafe float AtmosH1_GradientSize_PP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }

    /// <summary>
    /// FloatProperty: AtmosH1_GradientPosition_PP
    /// </summary>
    public unsafe float AtmosH1_GradientPosition_PP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// StructProperty: AtmosH2_Colour_PP
    /// </summary>
    public unsafe BmSDK.GameObject.FColor AtmosH2_Colour_PP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// FloatProperty: AtmosH2_Density_PP
    /// </summary>
    public unsafe float AtmosH2_Density_PP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// FloatProperty: AtmosH2_GradientSize_PP
    /// </summary>
    public unsafe float AtmosH2_GradientSize_PP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }

    /// <summary>
    /// FloatProperty: AtmosH2_GradientPosition_PP
    /// </summary>
    public unsafe float AtmosH2_GradientPosition_PP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// StructProperty: AtmosGlobal_Gradient_Colour_PP
    /// </summary>
    public unsafe BmSDK.GameObject.FColor AtmosGlobal_Gradient_Colour_PP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// StructProperty: AtmosGlobal_Gradient_Direction_PP
    /// </summary>
    public unsafe System.Numerics.Vector3 AtmosGlobal_Gradient_Direction_PP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// FloatProperty: AtmosGlobal_Gradient_Density_PP
    /// </summary>
    public unsafe float AtmosGlobal_Gradient_Density_PP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// FloatProperty: AtmosGlobal_Gradient_Cosine_PP
    /// </summary>
    public unsafe float AtmosGlobal_Gradient_Cosine_PP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// FloatProperty: AtmosHazeWeight_PP
    /// </summary>
    public unsafe float AtmosHazeWeight_PP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// FloatProperty: AtmosHazeNear_PP
    /// </summary>
    public unsafe float AtmosHazeNear_PP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// FloatProperty: AtmosHazeFar_PP
    /// </summary>
    public unsafe float AtmosHazeFar_PP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// StructProperty: AtmosAmbientD1_PP
    /// </summary>
    public unsafe BmSDK.GameObject.FLinearColor AtmosAmbientD1_PP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FLinearColor>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// StructProperty: AtmosAmbientD2_PP
    /// </summary>
    public unsafe BmSDK.GameObject.FLinearColor AtmosAmbientD2_PP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FLinearColor>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// StructProperty: AtmosAmbientH1_PP
    /// </summary>
    public unsafe BmSDK.GameObject.FLinearColor AtmosAmbientH1_PP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FLinearColor>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// StructProperty: AtmosAmbientH2_PP
    /// </summary>
    public unsafe BmSDK.GameObject.FLinearColor AtmosAmbientH2_PP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FLinearColor>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// FloatProperty: AtmosNoiseD1_PP
    /// </summary>
    public unsafe float AtmosNoiseD1_PP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }

    /// <summary>
    /// FloatProperty: AtmosNoiseD2_PP
    /// </summary>
    public unsafe float AtmosNoiseD2_PP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 344); }
    }

    /// <summary>
    /// FloatProperty: AtmosNoiseH1_PP
    /// </summary>
    public unsafe float AtmosNoiseH1_PP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// FloatProperty: AtmosNoiseH2_PP
    /// </summary>
    public unsafe float AtmosNoiseH2_PP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// StructProperty: AtmosHeightMapModD1_PP
    /// </summary>
    public unsafe System.Numerics.Vector3 AtmosHeightMapModD1_PP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// StructProperty: AtmosHeightMapModD2_PP
    /// </summary>
    public unsafe System.Numerics.Vector3 AtmosHeightMapModD2_PP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// StructProperty: AtmosHeightMapModH1_PP
    /// </summary>
    public unsafe System.Numerics.Vector3 AtmosHeightMapModH1_PP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// StructProperty: AtmosHeightMapModH2_PP
    /// </summary>
    public unsafe System.Numerics.Vector3 AtmosHeightMapModH2_PP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }
}
