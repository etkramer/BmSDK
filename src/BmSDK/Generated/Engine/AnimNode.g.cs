#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AnimNode<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class AnimNode : BmSDK.Engine.AnimObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AnimNode", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AnimNode() { }

    /// <summary>
    /// Constructs a new AnimNode
    /// </summary>
    public AnimNode(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AnimNode Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AnimNode(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bRelevant
    /// </summary>
    public unsafe bool bRelevant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// BoolProperty: bJustBecameRelevant
    /// </summary>
    public unsafe bool bJustBecameRelevant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// BoolProperty: bTickDuringPausedAnims
    /// </summary>
    public unsafe bool bTickDuringPausedAnims
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// BoolProperty: bEditorOnly
    /// </summary>
    public unsafe bool bEditorOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// BoolProperty: bDisableCaching
    /// </summary>
    public unsafe bool bDisableCaching
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// BoolProperty: bCallScriptEventOnInit
    /// </summary>
    public unsafe bool bCallScriptEventOnInit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// BoolProperty: bCallScriptEventOnBecomeRelevant
    /// </summary>
    public unsafe bool bCallScriptEventOnBecomeRelevant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// BoolProperty: bCallScriptEventOnCeaseRelevant
    /// </summary>
    public unsafe bool bCallScriptEventOnCeaseRelevant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// IntProperty: NodeTickTag
    /// </summary>
    public unsafe int NodeTickTag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// IntProperty: NodeInitTag
    /// </summary>
    public unsafe int NodeInitTag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// IntProperty: NodeEndEventTick
    /// </summary>
    public unsafe int NodeEndEventTick
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// IntProperty: TickArrayIndex
    /// </summary>
    public unsafe int TickArrayIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// IntProperty: NodeCachedAtomsTag
    /// </summary>
    public unsafe int NodeCachedAtomsTag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// FloatProperty: NodeTotalWeight
    /// </summary>
    public unsafe float NodeTotalWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// ArrayProperty: ParentNodes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>> ParentNodes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// NameProperty: NodeName
    /// </summary>
    public unsafe BmSDK.FName NodeName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// ArrayProperty: CachedBoneAtoms
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>> CachedBoneAtoms
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// IntProperty: CachedNumDesiredBones
    /// </summary>
    public unsafe int CachedNumDesiredBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// StructProperty: CachedRootMotionDelta
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CachedRootMotionDelta
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// IntProperty: bCachedHasRootMotion
    /// </summary>
    public unsafe int bCachedHasRootMotion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// ArrayProperty: CachedCurveKeys
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> CachedCurveKeys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// IntProperty: SearchTag
    /// </summary>
    public unsafe int SearchTag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// ArrayProperty: LastUpdatedAnimMorphKeys
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> LastUpdatedAnimMorphKeys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// Struct: FCurveKey
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FCurveKey
    {
        /// <summary>
        /// NameProperty: CurveName
        /// </summary>
        public unsafe BmSDK.FName CurveName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: Weight
        /// </summary>
        public unsafe float Weight
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Enum: ESliderType
    /// </summary>
    public enum ESliderType
    {
        ST_1D = 0,
        ST_2D = 1,
        ST_MAX = 2,
    }
}
