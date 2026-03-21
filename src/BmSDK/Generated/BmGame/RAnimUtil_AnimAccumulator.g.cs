#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RAnimUtil_AnimAccumulator<br/>
/// (size = 44)
/// (flags = 134217875)
/// </summary>
public partial class RAnimUtil_AnimAccumulator : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimUtil_AnimAccumulator", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimUtil_AnimAccumulator() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimUtil_AnimAccumulator(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAnimUtil_AnimAccumulator>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimUtil_AnimAccumulator>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAnimUtil_AnimAccumulator>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimUtil_AnimAccumulator>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimUtil_AnimAccumulator>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAnimUtil_AnimAccumulator>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimUtil_AnimAccumulator>
        => ((GameObject)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Struct: FAnimAccumulator
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 3576)]
    public partial record struct FAnimAccumulator
    {
        /// <summary>
        /// StructProperty: RemainingPoseWeight
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil.FBodyWeight RemainingPoseWeight_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil.FBodyWeight>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
        /// <summary>
        /// StructProperty: RemainingPoseWeight
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil.FBodyWeight RemainingPoseWeight_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil.FBodyWeight>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }
        /// <summary>
        /// StructProperty: RemainingPoseWeight
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil.FBodyWeight RemainingPoseWeight_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil.FBodyWeight>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }
        /// <summary>
        /// StructProperty: RemainingPoseWeight
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil.FBodyWeight RemainingPoseWeight_3
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil.FBodyWeight>(Ptr + 84); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }; }
        }
        /// <summary>
        /// StructProperty: RemainingPoseWeight
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil.FBodyWeight RemainingPoseWeight_4
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil.FBodyWeight>(Ptr + 112); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }; }
        }
        /// <summary>
        /// StructProperty: RemainingPoseWeight
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil.FBodyWeight RemainingPoseWeight_5
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil.FBodyWeight>(Ptr + 140); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }; }
        }

        /// <summary>
        /// StructProperty: AnimOutput
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSampleArray AnimOutput
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSampleArray>(Ptr + 168); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }; }
        }

        /// <summary>
        /// StructProperty: AdditiveAnimOutput
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSampleArray AdditiveAnimOutput
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSampleArray>(Ptr + 2476); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2476); }; }
        }

        /// <summary>
        /// StructProperty: MotionOutput
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil.FTranslationYaw MotionOutput
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil.FTranslationYaw>(Ptr + 3504); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3504); }; }
        }

        /// <summary>
        /// StructProperty: ProportionalMotion
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil.FProportionalMotion ProportionalMotion
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil.FProportionalMotion>(Ptr + 3520); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3520); }; }
        }
    }

    /// <summary>
    /// Struct: FWeightedAdditiveAnimSampleArray
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 1028)]
    public partial record struct FWeightedAdditiveAnimSampleArray
    {
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample Data_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample Data_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample Data_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample>(Ptr + 128); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample Data_3
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample>(Ptr + 192); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample Data_4
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample>(Ptr + 256); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample Data_5
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample>(Ptr + 320); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample Data_6
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample>(Ptr + 384); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample Data_7
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample>(Ptr + 448); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample Data_8
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample>(Ptr + 512); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample Data_9
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample>(Ptr + 576); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample Data_10
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample>(Ptr + 640); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample Data_11
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample>(Ptr + 704); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample Data_12
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample>(Ptr + 768); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample Data_13
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample>(Ptr + 832); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample Data_14
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample>(Ptr + 896); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample Data_15
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample>(Ptr + 960); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }; }
        }

        /// <summary>
        /// IntProperty: Num
        /// </summary>
        public unsafe int Num
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }; }
        }
    }

    /// <summary>
    /// Struct: FWeightedAdditiveAnimSample
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial record struct FWeightedAdditiveAnimSample
    {
        /// <summary>
        /// StructProperty: Sample
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AnimAccumulator.FAdditiveAnimSample Sample
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FAdditiveAnimSample>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Weight
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimConfig.FWeight Weight
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimConfig.FWeight>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// StructProperty: MotionWeight
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimConfig.FWeight MotionWeight
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimConfig.FWeight>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }
    }

    /// <summary>
    /// Struct: FAdditiveAnimSample
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial record struct FAdditiveAnimSample
    {
        /// <summary>
        /// StructProperty: AnimConfig
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil.FResolvedAdditiveAnimConfig AnimConfig
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil.FResolvedAdditiveAnimConfig>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: AddTime
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil.FNormalizedTimeSpan AddTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil.FNormalizedTimeSpan>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ByteProperty: RootBoneSubtractionMode
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil.ERootBoneSubtractionMode RootBoneSubtractionMode
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil.ERootBoneSubtractionMode>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// StructProperty: BeginRootBoneTranslationOffset
        /// </summary>
        public unsafe System.Numerics.Vector3 BeginRootBoneTranslationOffset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// StructProperty: EndRootBoneTranslationOffset
        /// </summary>
        public unsafe System.Numerics.Vector3 EndRootBoneTranslationOffset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: Mirrored
        /// </summary>
        public unsafe bool Mirrored
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }; }
        }

        /// <summary>
        /// BoolProperty: IssueNotifies
        /// </summary>
        public unsafe bool IssueNotifies
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }; }
        }
    }

    /// <summary>
    /// Struct: FWeightedAnimSampleArray
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 2308)]
    public partial record struct FWeightedAnimSampleArray
    {
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>(Ptr + 96); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>(Ptr + 192); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_3
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>(Ptr + 288); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_4
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>(Ptr + 384); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_5
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>(Ptr + 480); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_6
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>(Ptr + 576); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_7
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>(Ptr + 672); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_8
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>(Ptr + 768); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_9
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>(Ptr + 864); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_10
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>(Ptr + 960); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_11
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>(Ptr + 1056); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_12
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>(Ptr + 1152); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_13
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>(Ptr + 1248); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_14
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>(Ptr + 1344); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1344); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_15
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>(Ptr + 1440); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1440); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_16
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>(Ptr + 1536); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1536); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_17
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>(Ptr + 1632); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1632); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_18
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>(Ptr + 1728); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1728); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_19
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>(Ptr + 1824); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1824); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_20
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>(Ptr + 1920); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1920); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_21
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>(Ptr + 2016); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2016); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_22
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>(Ptr + 2112); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2112); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_23
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>(Ptr + 2208); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2208); }; }
        }

        /// <summary>
        /// IntProperty: Num
        /// </summary>
        public unsafe int Num
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2304); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2304); }; }
        }
    }

    /// <summary>
    /// Struct: FWeightedAnimSample
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public partial record struct FWeightedAnimSample
    {
        /// <summary>
        /// StructProperty: Sample
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AnimAccumulator.FAnimSample Sample
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FAnimSample>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Weight
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil.FBodyWeight Weight
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil.FBodyWeight>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }
    }

    /// <summary>
    /// Struct: FAnimSample
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public partial record struct FAnimSample
    {
        /// <summary>
        /// ObjectProperty: UpperBodyAnim
        /// </summary>
        public unsafe BmSDK.Engine.AnimSequence UpperBodyAnim
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: LowerBodyAnim
        /// </summary>
        public unsafe BmSDK.Engine.AnimSequence LowerBodyAnim
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ObjectProperty: AimingConfig
        /// </summary>
        public unsafe BmSDK.BmGame.RAimingConfig AimingConfig
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAimingConfig>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StructProperty: Time
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil.FNormalizedTimeSpan Time
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil.FNormalizedTimeSpan>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ByteProperty: RootBoneSubtractionMode
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil.ERootBoneSubtractionMode RootBoneSubtractionMode
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil.ERootBoneSubtractionMode>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ObjectProperty: RootBoneSubtractionAnim
        /// </summary>
        public unsafe BmSDK.Engine.AnimSequence RootBoneSubtractionAnim
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// FloatProperty: RootBoneExtractionYaw
        /// </summary>
        public unsafe float RootBoneExtractionYaw
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// FloatProperty: RootBoneExtractionScale
        /// </summary>
        public unsafe float RootBoneExtractionScale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// StructProperty: BeginRootBoneTranslationOffset
        /// </summary>
        public unsafe System.Numerics.Vector3 BeginRootBoneTranslationOffset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// StructProperty: EndRootBoneTranslationOffset
        /// </summary>
        public unsafe System.Numerics.Vector3 EndRootBoneTranslationOffset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// BoolProperty: AllowNotifies
        /// </summary>
        public unsafe bool AllowNotifies
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }; }
        }

        /// <summary>
        /// BoolProperty: Mirrored
        /// </summary>
        public unsafe bool Mirrored
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }; }
        }

        /// <summary>
        /// BoolProperty: PerAnimAiming
        /// </summary>
        public unsafe bool PerAnimAiming
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }; }
        }
    }
}
