#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionDecodeMask<br/>
/// (size = 349)
/// (flags = 0)
/// </summary>
public partial class MaterialExpressionDecodeMask : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionDecodeMask", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionDecodeMask() { }

    /// <summary>
    /// Constructs a new MaterialExpressionDecodeMask
    /// </summary>
    public MaterialExpressionDecodeMask(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionDecodeMask Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionDecodeMask(nint ptr) : base(ptr) { }

    /// <summary>
    /// Enum: EDecodeBlendType
    /// </summary>
    public enum EDecodeBlendType
    {
        DECODE_Replace = 0,
        DECODE_Add = 1,
        DECODE_MAX = 2,
    }

    /// <summary>
    /// Struct: FWeightInput
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public partial record struct FWeightInput
    {
        /// <summary>
        /// StrProperty: WeightName
        /// </summary>
        public unsafe BmSDK.FString WeightName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Input
        /// </summary>
        public unsafe BmSDK.Engine.MaterialExpression.FExpressionInput Input
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpression.FExpressionInput>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// IntProperty: StepSize
    /// </summary>
    public unsafe int StepSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// ArrayProperty: Weight
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialExpressionDecodeMask.FWeightInput> Weight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialExpressionDecodeMask.FWeightInput>>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// StructProperty: Mask
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpression.FExpressionInput Mask
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpression.FExpressionInput>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// StructProperty: BlendFrom
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpression.FExpressionInput BlendFrom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpression.FExpressionInput>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// StructProperty: BlendTo
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpression.FExpressionInput BlendTo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpression.FExpressionInput>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }

    /// <summary>
    /// ByteProperty: DecodeBlendType
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpressionDecodeMask.EDecodeBlendType DecodeBlendType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpressionDecodeMask.EDecodeBlendType>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }
}
