#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionMaterialFunctionCall<br/>
/// (flags = 0)
/// </summary>
public partial class MaterialExpressionMaterialFunctionCall : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionMaterialFunctionCall", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionMaterialFunctionCall() { }

    /// <summary>
    /// Constructs a new MaterialExpressionMaterialFunctionCall
    /// </summary>
    public MaterialExpressionMaterialFunctionCall(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionMaterialFunctionCall Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionMaterialFunctionCall(nint ptr) : base(ptr) { }

    /// <summary>
    /// Struct: FFunctionExpressionOutput
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FFunctionExpressionOutput
    {
        /// <summary>
        /// ObjectProperty: ExpressionOutput
        /// </summary>
        public unsafe BmSDK.Engine.MaterialExpressionFunctionOutput ExpressionOutput
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpressionFunctionOutput>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: ExpressionOutputId
        /// </summary>
        public unsafe BmSDK.GameObject.FGuid ExpressionOutputId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FGuid>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StructProperty: Output
        /// </summary>
        public unsafe BmSDK.Engine.MaterialExpression.FExpressionOutput Output
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpression.FExpressionOutput>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Struct: FFunctionExpressionInput
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FFunctionExpressionInput
    {
        /// <summary>
        /// ObjectProperty: ExpressionInput
        /// </summary>
        public unsafe BmSDK.Engine.MaterialExpressionFunctionInput ExpressionInput
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpressionFunctionInput>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: ExpressionInputId
        /// </summary>
        public unsafe BmSDK.GameObject.FGuid ExpressionInputId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FGuid>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StructProperty: Input
        /// </summary>
        public unsafe BmSDK.Engine.MaterialExpression.FExpressionInput Input
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpression.FExpressionInput>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// ObjectProperty: MaterialFunction
    /// </summary>
    public unsafe BmSDK.Engine.MaterialFunction MaterialFunction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialFunction>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// ArrayProperty: FunctionInputs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialExpressionMaterialFunctionCall.FFunctionExpressionInput> FunctionInputs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialExpressionMaterialFunctionCall.FFunctionExpressionInput>>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// ArrayProperty: FunctionOutputs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialExpressionMaterialFunctionCall.FFunctionExpressionOutput> FunctionOutputs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialExpressionMaterialFunctionCall.FFunctionExpressionOutput>>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }
}
