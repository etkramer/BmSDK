#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionFunctionInput<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MaterialExpressionFunctionInput : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionFunctionInput", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionFunctionInput() { }

    /// <summary>
    /// Constructs a new MaterialExpressionFunctionInput
    /// </summary>
    public MaterialExpressionFunctionInput(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionFunctionInput Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionFunctionInput(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: Preview
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpressionFunctionInput.InputName Preview
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpressionFunctionInput.InputName>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// StrProperty: InputName
    /// </summary>
    public unsafe BmSDK.FString InputName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// StrProperty: Description
    /// </summary>
    public unsafe BmSDK.FString Description
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// StructProperty: Id
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Id
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// ByteProperty: InputType
    /// </summary>
    public unsafe byte InputType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// StructProperty: PreviewValue
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PreviewValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// BoolProperty: bUsePreviewValueAsDefault
    /// </summary>
    public unsafe bool bUsePreviewValueAsDefault
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 304) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 304); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 304); }
    }

    /// <summary>
    /// BoolProperty: bCompilingFunctionPreview
    /// </summary>
    public unsafe bool bCompilingFunctionPreview
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 304) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 304); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 304); }
    }

    /// <summary>
    /// IntProperty: SortPriority
    /// </summary>
    public unsafe int SortPriority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }
}
