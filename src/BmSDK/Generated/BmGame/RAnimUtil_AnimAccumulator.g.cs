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

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimUtil_AnimAccumulator>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAnimUtil_AnimAccumulator>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimUtil_AnimAccumulator>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Struct: FAnimAccumulator
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 3576)]
    public partial record struct FAnimAccumulator
    {
        /// <summary>
        /// StructProperty: RemainingPoseWeight
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil.FBodyWeight RemainingPoseWeight_0
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FBodyWeight>((IntPtr)thisPtr + 0); } }
        }
        /// <summary>
        /// StructProperty: RemainingPoseWeight
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil.FBodyWeight RemainingPoseWeight_1
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FBodyWeight>((IntPtr)thisPtr + 28); } }
        }
        /// <summary>
        /// StructProperty: RemainingPoseWeight
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil.FBodyWeight RemainingPoseWeight_2
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FBodyWeight>((IntPtr)thisPtr + 56); } }
        }
        /// <summary>
        /// StructProperty: RemainingPoseWeight
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil.FBodyWeight RemainingPoseWeight_3
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FBodyWeight>((IntPtr)thisPtr + 84); } }
        }
        /// <summary>
        /// StructProperty: RemainingPoseWeight
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil.FBodyWeight RemainingPoseWeight_4
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FBodyWeight>((IntPtr)thisPtr + 112); } }
        }
        /// <summary>
        /// StructProperty: RemainingPoseWeight
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil.FBodyWeight RemainingPoseWeight_5
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FBodyWeight>((IntPtr)thisPtr + 140); } }
        }

        /// <summary>
        /// StructProperty: AnimOutput
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSampleArray AnimOutput
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSampleArray>((IntPtr)thisPtr + 168); } }
        }

        /// <summary>
        /// StructProperty: AdditiveAnimOutput
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSampleArray AdditiveAnimOutput
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSampleArray>((IntPtr)thisPtr + 2476); } }
        }

        /// <summary>
        /// StructProperty: MotionOutput
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil.FTranslationYaw MotionOutput
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FTranslationYaw>((IntPtr)thisPtr + 3504); } }
        }

        /// <summary>
        /// StructProperty: ProportionalMotion
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil.FProportionalMotion ProportionalMotion
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FProportionalMotion>((IntPtr)thisPtr + 3520); } }
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
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample Data_0
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample>((IntPtr)thisPtr + 0); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample Data_1
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample>((IntPtr)thisPtr + 64); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample Data_2
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample>((IntPtr)thisPtr + 128); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample Data_3
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample>((IntPtr)thisPtr + 192); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample Data_4
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample>((IntPtr)thisPtr + 256); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample Data_5
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample>((IntPtr)thisPtr + 320); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample Data_6
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample>((IntPtr)thisPtr + 384); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample Data_7
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample>((IntPtr)thisPtr + 448); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample Data_8
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample>((IntPtr)thisPtr + 512); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample Data_9
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample>((IntPtr)thisPtr + 576); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample Data_10
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample>((IntPtr)thisPtr + 640); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample Data_11
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample>((IntPtr)thisPtr + 704); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample Data_12
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample>((IntPtr)thisPtr + 768); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample Data_13
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample>((IntPtr)thisPtr + 832); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample Data_14
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample>((IntPtr)thisPtr + 896); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample Data_15
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAdditiveAnimSample>((IntPtr)thisPtr + 960); } }
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
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimAccumulator.FAdditiveAnimSample Sample
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FAdditiveAnimSample>((IntPtr)thisPtr + 0); } }
        }

        /// <summary>
        /// StructProperty: Weight
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimConfig.FWeight Weight
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimConfig.FWeight>((IntPtr)thisPtr + 56); } }
        }

        /// <summary>
        /// StructProperty: MotionWeight
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimConfig.FWeight MotionWeight
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimConfig.FWeight>((IntPtr)thisPtr + 60); } }
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
        public unsafe ref BmSDK.BmGame.RAnimUtil.FResolvedAdditiveAnimConfig AnimConfig
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FResolvedAdditiveAnimConfig>((IntPtr)thisPtr + 0); } }
        }

        /// <summary>
        /// StructProperty: AddTime
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil.FNormalizedTimeSpan AddTime
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FNormalizedTimeSpan>((IntPtr)thisPtr + 12); } }
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
        public unsafe ref System.Numerics.Vector3 BeginRootBoneTranslationOffset
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>((IntPtr)thisPtr + 28); } }
        }

        /// <summary>
        /// StructProperty: EndRootBoneTranslationOffset
        /// </summary>
        public unsafe ref System.Numerics.Vector3 EndRootBoneTranslationOffset
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>((IntPtr)thisPtr + 40); } }
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
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_0
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>((IntPtr)thisPtr + 0); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_1
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>((IntPtr)thisPtr + 96); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_2
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>((IntPtr)thisPtr + 192); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_3
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>((IntPtr)thisPtr + 288); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_4
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>((IntPtr)thisPtr + 384); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_5
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>((IntPtr)thisPtr + 480); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_6
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>((IntPtr)thisPtr + 576); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_7
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>((IntPtr)thisPtr + 672); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_8
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>((IntPtr)thisPtr + 768); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_9
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>((IntPtr)thisPtr + 864); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_10
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>((IntPtr)thisPtr + 960); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_11
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>((IntPtr)thisPtr + 1056); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_12
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>((IntPtr)thisPtr + 1152); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_13
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>((IntPtr)thisPtr + 1248); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_14
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>((IntPtr)thisPtr + 1344); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_15
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>((IntPtr)thisPtr + 1440); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_16
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>((IntPtr)thisPtr + 1536); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_17
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>((IntPtr)thisPtr + 1632); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_18
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>((IntPtr)thisPtr + 1728); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_19
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>((IntPtr)thisPtr + 1824); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_20
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>((IntPtr)thisPtr + 1920); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_21
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>((IntPtr)thisPtr + 2016); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_22
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>((IntPtr)thisPtr + 2112); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample Data_23
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FWeightedAnimSample>((IntPtr)thisPtr + 2208); } }
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
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimAccumulator.FAnimSample Sample
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimAccumulator.FAnimSample>((IntPtr)thisPtr + 0); } }
        }

        /// <summary>
        /// StructProperty: Weight
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil.FBodyWeight Weight
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FBodyWeight>((IntPtr)thisPtr + 68); } }
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
        public unsafe ref BmSDK.BmGame.RAnimUtil.FNormalizedTimeSpan Time
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FNormalizedTimeSpan>((IntPtr)thisPtr + 12); } }
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
        public unsafe ref System.Numerics.Vector3 BeginRootBoneTranslationOffset
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>((IntPtr)thisPtr + 40); } }
        }

        /// <summary>
        /// StructProperty: EndRootBoneTranslationOffset
        /// </summary>
        public unsafe ref System.Numerics.Vector3 EndRootBoneTranslationOffset
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>((IntPtr)thisPtr + 52); } }
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
