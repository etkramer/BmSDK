#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ApexGridComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ApexGridComponent : BmSDK.Engine.ApexFieldSamplerComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ApexGridComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ApexGridComponent() { }

    /// <summary>
    /// Constructs a new ApexGridComponent
    /// </summary>
    public ApexGridComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ApexGridComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ApexGridComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: GridMinResolution
    /// </summary>
    public unsafe byte GridMinResolution
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// ByteProperty: GridMaxResolution
    /// </summary>
    public unsafe byte GridMaxResolution
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 605); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 605); }
    }

    /// <summary>
    /// StructProperty: GridXRange
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GridXRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// StructProperty: GridYRange
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GridYRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// StructProperty: GridZRange
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GridZRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// StructProperty: UpdatesPerFrameRange
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT UpdatesPerFrameRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }

    /// <summary>
    /// FloatProperty: GridSize
    /// </summary>
    public unsafe float GridSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// StructProperty: GridSize3D
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GridSize3D
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }

    /// <summary>
    /// FloatProperty: FluidVelocityMultiplier
    /// </summary>
    public unsafe float FluidVelocityMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// FloatProperty: FluidVelocityClamp
    /// </summary>
    public unsafe float FluidVelocityClamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 660); }
    }

    /// <summary>
    /// FloatProperty: AngularVelocityMultiplier
    /// </summary>
    public unsafe float AngularVelocityMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// FloatProperty: AngularVelocityClamp
    /// </summary>
    public unsafe float AngularVelocityClamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// FloatProperty: LinearVelocityMultiplier
    /// </summary>
    public unsafe float LinearVelocityMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// FloatProperty: LinearVelocityClamp
    /// </summary>
    public unsafe float LinearVelocityClamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// FloatProperty: BoundaryFadePercentage
    /// </summary>
    public unsafe float BoundaryFadePercentage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }

    /// <summary>
    /// FloatProperty: BoundarySizePercentage
    /// </summary>
    public unsafe float BoundarySizePercentage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// IntProperty: MaxCollidingObjects
    /// </summary>
    public unsafe int MaxCollidingObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// IntProperty: MaxHeatSources
    /// </summary>
    public unsafe int MaxHeatSources
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// StructProperty: ExternalVelocity
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ExternalVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// FloatProperty: FieldVelocityMultiplier
    /// </summary>
    public unsafe float FieldVelocityMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// FloatProperty: FieldVelocityWeight
    /// </summary>
    public unsafe float FieldVelocityWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: UseHeat
    /// </summary>
    public unsafe bool UseHeat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 716) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 716); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 716); }
    }

    /// <summary>
    /// BoolProperty: AutoVelocityEnabled
    /// </summary>
    public unsafe bool AutoVelocityEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 716) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 716); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 716); }
    }

    /// <summary>
    /// FloatProperty: TemperatureBasedForceMultiplier
    /// </summary>
    public unsafe float TemperatureBasedForceMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// FloatProperty: AmbientTemperature
    /// </summary>
    public unsafe float AmbientTemperature
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// StructProperty: HeatForceDirection
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT HeatForceDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// FloatProperty: AutoVelocityTeleportValue
    /// </summary>
    public unsafe float AutoVelocityTeleportValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// FloatProperty: AutoVelocityImpulseClamp
    /// </summary>
    public unsafe float AutoVelocityImpulseClamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// FloatProperty: AutoVelocitySmoothingTimeConstant
    /// </summary>
    public unsafe float AutoVelocitySmoothingTimeConstant
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// FloatProperty: DragCoeff
    /// </summary>
    public unsafe float DragCoeff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// FloatProperty: DragCoeffForRigidBody
    /// </summary>
    public unsafe float DragCoeffForRigidBody
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// FloatProperty: FluidViscosity
    /// </summary>
    public unsafe float FluidViscosity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// FloatProperty: VelocityFieldFade
    /// </summary>
    public unsafe float VelocityFieldFade
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// FloatProperty: VelocityFieldCleaningTime
    /// </summary>
    public unsafe float VelocityFieldCleaningTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// FloatProperty: VelocityFieldCleaningDelay
    /// </summary>
    public unsafe float VelocityFieldCleaningDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// FloatProperty: VelocityFieldCleaningIntensity
    /// </summary>
    public unsafe float VelocityFieldCleaningIntensity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }

    /// <summary>
    /// FloatProperty: NoiseStrength
    /// </summary>
    public unsafe float NoiseStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// FloatProperty: NoiseSpacePeriod
    /// </summary>
    public unsafe float NoiseSpacePeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// FloatProperty: NoiseTimePeriod
    /// </summary>
    public unsafe float NoiseTimePeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// IntProperty: NoiseOctaves
    /// </summary>
    public unsafe int NoiseOctaves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// Enum: EGridResolution
    /// </summary>
    public enum EGridResolution
    {
        EGR = 0,
        EGR_2 = 1,
        EGR_3 = 2,
        EGR_4 = 3,
        EGR_5 = 4,
        EGR_6 = 5,
        EGR_7 = 6,
        EGR_8 = 7,
        EGR_MAX = 8,
    }

    /// <summary>
    /// Struct: FSGridIntRange
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FSGridIntRange
    {
        /// <summary>
        /// FloatProperty: Min
        /// </summary>
        public unsafe float Min
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: Max
        /// </summary>
        public unsafe float Max
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FSGridFloatRange
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FSGridFloatRange
    {
        /// <summary>
        /// FloatProperty: Min
        /// </summary>
        public unsafe float Min
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: Max
        /// </summary>
        public unsafe float Max
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }
}
