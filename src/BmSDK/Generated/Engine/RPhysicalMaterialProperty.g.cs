#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RPhysicalMaterialProperty<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RPhysicalMaterialProperty : BmSDK.Engine.PhysicalMaterialPropertyBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RPhysicalMaterialProperty", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPhysicalMaterialProperty() { }

    /// <summary>
    /// Constructs a new RPhysicalMaterialProperty
    /// </summary>
    public RPhysicalMaterialProperty(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPhysicalMaterialProperty Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPhysicalMaterialProperty(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: FootstepInfo
    /// </summary>
    public unsafe BmSDK.Engine.RPhysicalMaterialProperty.FMaterialFootstepInfo FootstepInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RPhysicalMaterialProperty.FMaterialFootstepInfo>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ObjectProperty: GelExplosionSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent GelExplosionSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// StructProperty: ImpactInfo
    /// </summary>
    public unsafe BmSDK.Engine.RPhysicalMaterialProperty.FImpactEffectInfo ImpactInfo_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RPhysicalMaterialProperty.FImpactEffectInfo>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }
    /// <summary>
    /// StructProperty: ImpactInfo
    /// </summary>
    public unsafe BmSDK.Engine.RPhysicalMaterialProperty.FImpactEffectInfo ImpactInfo_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RPhysicalMaterialProperty.FImpactEffectInfo>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }
    /// <summary>
    /// StructProperty: ImpactInfo
    /// </summary>
    public unsafe BmSDK.Engine.RPhysicalMaterialProperty.FImpactEffectInfo ImpactInfo_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RPhysicalMaterialProperty.FImpactEffectInfo>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }
    /// <summary>
    /// StructProperty: ImpactInfo
    /// </summary>
    public unsafe BmSDK.Engine.RPhysicalMaterialProperty.FImpactEffectInfo ImpactInfo_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RPhysicalMaterialProperty.FImpactEffectInfo>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }
    /// <summary>
    /// StructProperty: ImpactInfo
    /// </summary>
    public unsafe BmSDK.Engine.RPhysicalMaterialProperty.FImpactEffectInfo ImpactInfo_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RPhysicalMaterialProperty.FImpactEffectInfo>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }
    /// <summary>
    /// StructProperty: ImpactInfo
    /// </summary>
    public unsafe BmSDK.Engine.RPhysicalMaterialProperty.FImpactEffectInfo ImpactInfo_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RPhysicalMaterialProperty.FImpactEffectInfo>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }
    /// <summary>
    /// StructProperty: ImpactInfo
    /// </summary>
    public unsafe BmSDK.Engine.RPhysicalMaterialProperty.FImpactEffectInfo ImpactInfo_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RPhysicalMaterialProperty.FImpactEffectInfo>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// StructProperty: AdvancedImpactInfo
    /// </summary>
    public unsafe BmSDK.Engine.RPhysicalMaterialProperty.FAdvancedImpactEffectInfo AdvancedImpactInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RPhysicalMaterialProperty.FAdvancedImpactEffectInfo>(Ptr + 460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 460); }
    }

    /// <summary>
    /// Struct: FMaterialFootstepInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FMaterialFootstepInfo
    {
        /// <summary>
        /// BoolProperty: bPlayParticleWhenWalking
        /// </summary>
        public unsafe bool bPlayParticleWhenWalking
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: ParticleEffect
        /// </summary>
        public unsafe BmSDK.Engine.ParticleSystem ParticleEffect
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ObjectProperty: HandStepParticleEffect
        /// </summary>
        public unsafe BmSDK.Engine.ParticleSystem HandStepParticleEffect
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ObjectProperty: SlideParticleEffect
        /// </summary>
        public unsafe BmSDK.Engine.ParticleSystem SlideParticleEffect
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// ObjectProperty: WetSlideParticleEffect
        /// </summary>
        public unsafe BmSDK.Engine.ParticleSystem WetSlideParticleEffect
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// ObjectProperty: CrouchedParticleEffect
        /// </summary>
        public unsafe BmSDK.Engine.ParticleSystem CrouchedParticleEffect
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// ObjectProperty: WetParticleEffect
        /// </summary>
        public unsafe BmSDK.Engine.ParticleSystem WetParticleEffect
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// ObjectProperty: FearGasParticleEffect
        /// </summary>
        public unsafe BmSDK.Engine.ParticleSystem FearGasParticleEffect
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }
    }
}
