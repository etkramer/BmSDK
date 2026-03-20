#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialInstanceTimeVarying<br/>
/// (flags = 0)
/// </summary>
public partial class MaterialInstanceTimeVarying : BmSDK.Engine.MaterialInstance, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialInstanceTimeVarying", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialInstanceTimeVarying() { }

    /// <summary>
    /// Constructs a new MaterialInstanceTimeVarying
    /// </summary>
    public MaterialInstanceTimeVarying(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialInstanceTimeVarying Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialInstanceTimeVarying(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bAutoActivateAll
    /// </summary>
    public unsafe bool bAutoActivateAll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 312); }
    }

    /// <summary>
    /// FloatProperty: Duration
    /// </summary>
    public unsafe float Duration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// ArrayProperty: FontParameterValues
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInstanceTimeVarying.FFontParameterValueOverTime> FontParameterValues
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInstanceTimeVarying.FFontParameterValueOverTime>>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }

    /// <summary>
    /// ArrayProperty: ScalarParameterValues
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInstanceTimeVarying.FScalarParameterValueOverTime> ScalarParameterValues
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInstanceTimeVarying.FScalarParameterValueOverTime>>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }

    /// <summary>
    /// ArrayProperty: TextureParameterValues
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInstanceTimeVarying.FTextureParameterValueOverTime> TextureParameterValues
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInstanceTimeVarying.FTextureParameterValueOverTime>>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ArrayProperty: VectorParameterValues
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInstanceTimeVarying.FVectorParameterValueOverTime> VectorParameterValues
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInstanceTimeVarying.FVectorParameterValueOverTime>>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// ArrayProperty: LinearColorParameterValues
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInstanceTimeVarying.FLinearColorParameterValueOverTime> LinearColorParameterValues
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInstanceTimeVarying.FLinearColorParameterValueOverTime>>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// Struct: FLinearColorParameterValueOverTime
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FLinearColorParameterValueOverTime
    {
        /// <summary>
        /// StructProperty: ParameterValue
        /// </summary>
        public unsafe BmSDK.GameObject.FLinearColor ParameterValue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FLinearColor>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// StructProperty: ParameterValueCurve
        /// </summary>
        public unsafe BmSDK.GameObject.FInterpCurveLinearColor ParameterValueCurve
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FInterpCurveLinearColor>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }
    }

    /// <summary>
    /// Struct: FVectorParameterValueOverTime
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FVectorParameterValueOverTime
    {
        /// <summary>
        /// StructProperty: ParameterValue
        /// </summary>
        public unsafe BmSDK.GameObject.FLinearColor ParameterValue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FLinearColor>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// StructProperty: ParameterValueCurve
        /// </summary>
        public unsafe BmSDK.GameObject.FInterpCurveVector ParameterValueCurve
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FInterpCurveVector>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }
    }

    /// <summary>
    /// Struct: FTextureParameterValueOverTime
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FTextureParameterValueOverTime
    {
        /// <summary>
        /// ObjectProperty: ParameterValue
        /// </summary>
        public unsafe BmSDK.Engine.Texture ParameterValue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }
    }

    /// <summary>
    /// Struct: FScalarParameterValueOverTime
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FScalarParameterValueOverTime
    {
        /// <summary>
        /// FloatProperty: ParameterValue
        /// </summary>
        public unsafe float ParameterValue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// StructProperty: ParameterValueCurve
        /// </summary>
        public unsafe BmSDK.GameObject.FInterpCurveFloat ParameterValueCurve
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FInterpCurveFloat>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }
    }

    /// <summary>
    /// Struct: FFontParameterValueOverTime
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FFontParameterValueOverTime
    {
        /// <summary>
        /// ObjectProperty: FontValue
        /// </summary>
        public unsafe BmSDK.Engine.Font FontValue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Font>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// IntProperty: FontPage
        /// </summary>
        public unsafe int FontPage
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }
    }

    /// <summary>
    /// Struct: FParameterValueOverTime
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FParameterValueOverTime
    {
        /// <summary>
        /// StructProperty: ExpressionGUID
        /// </summary>
        public unsafe BmSDK.GameObject.FGuid ExpressionGUID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FGuid>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: StartTime
        /// </summary>
        public unsafe float StartTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// NameProperty: ParameterName
        /// </summary>
        public unsafe BmSDK.FName ParameterName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// BoolProperty: bLoop
        /// </summary>
        public unsafe bool bLoop
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 28); }; }
        }

        /// <summary>
        /// BoolProperty: bAutoActivate
        /// </summary>
        public unsafe bool bAutoActivate
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 28); }; }
        }

        /// <summary>
        /// FloatProperty: CycleTime
        /// </summary>
        public unsafe float CycleTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// BoolProperty: bNormalizeTime
        /// </summary>
        public unsafe bool bNormalizeTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 36); }; }
        }

        /// <summary>
        /// FloatProperty: OffsetTime
        /// </summary>
        public unsafe float OffsetTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: bOffsetFromEnd
        /// </summary>
        public unsafe bool bOffsetFromEnd
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 44); }; }
        }
    }
}
