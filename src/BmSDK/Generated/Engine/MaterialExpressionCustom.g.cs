#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionCustom<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MaterialExpressionCustom : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionCustom", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionCustom() { }

    /// <summary>
    /// Constructs a new MaterialExpressionCustom
    /// </summary>
    public MaterialExpressionCustom(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionCustom Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionCustom(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: Code
    /// </summary>
    public unsafe BmSDK.FString Code
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// ByteProperty: OutputType
    /// </summary>
    public unsafe byte OutputType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// StrProperty: Description
    /// </summary>
    public unsafe BmSDK.FString Description
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// ArrayProperty: Inputs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> Inputs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// Struct: FCustomInput
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FCustomInput
    {
        /// <summary>
        /// StrProperty: InputName
        /// </summary>
        public unsafe BmSDK.FString InputName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Input
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Input
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Enum: ECustomMaterialOutputType
    /// </summary>
    public enum ECustomMaterialOutputType
    {
        CMOT_Float1 = 0,
        CMOT_Float2 = 1,
        CMOT_Float3 = 2,
        CMOT_Float4 = 3,
        CMOT_MAX = 4,
    }
}
