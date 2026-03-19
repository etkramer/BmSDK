#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ApexNoiseComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ApexNoiseComponent : BmSDK.Engine.ApexFieldSamplerComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ApexNoiseComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ApexNoiseComponent() { }

    /// <summary>
    /// Constructs a new ApexNoiseComponent
    /// </summary>
    public ApexNoiseComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ApexNoiseComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ApexNoiseComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: BoundaryScale
    /// </summary>
    public unsafe float BoundaryScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// StructProperty: BoundarySize
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BoundarySize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// FloatProperty: BoundaryFadePercentage
    /// </summary>
    public unsafe float BoundaryFadePercentage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// ByteProperty: FieldType
    /// </summary>
    public unsafe byte FieldType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// ByteProperty: NoiseType
    /// </summary>
    public unsafe byte NoiseType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 625); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 625); }
    }

    /// <summary>
    /// FloatProperty: FieldDragCoeff
    /// </summary>
    public unsafe float FieldDragCoeff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }

    /// <summary>
    /// IntProperty: NoiseSeed
    /// </summary>
    public unsafe int NoiseSeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }

    /// <summary>
    /// FloatProperty: NoiseStrength
    /// </summary>
    public unsafe float NoiseStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }

    /// <summary>
    /// FloatProperty: NoiseSpacePeriod
    /// </summary>
    public unsafe float NoiseSpacePeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// FloatProperty: NoiseTimePeriod
    /// </summary>
    public unsafe float NoiseTimePeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }

    /// <summary>
    /// IntProperty: NoiseOctaves
    /// </summary>
    public unsafe int NoiseOctaves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// FloatProperty: NoiseStrengthOctaveMultiplier
    /// </summary>
    public unsafe float NoiseStrengthOctaveMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }

    /// <summary>
    /// FloatProperty: NoiseSpacePeriodOctaveMultiplier
    /// </summary>
    public unsafe float NoiseSpacePeriodOctaveMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// FloatProperty: NoiseTimePeriodOctaveMultiplier
    /// </summary>
    public unsafe float NoiseTimePeriodOctaveMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 660); }
    }
}
