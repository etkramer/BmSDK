#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionDecodeMask<br/>
/// (size = 0)
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
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialExpressionDecodeMask.BlendFrom> Weight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialExpressionDecodeMask.BlendFrom>>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// StructProperty: Mask
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpressionDecodeMask.BlendFrom Mask
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpressionDecodeMask.BlendFrom>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// StructProperty: BlendFrom
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpressionDecodeMask.BlendTo BlendFrom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpressionDecodeMask.BlendTo>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// StructProperty: BlendTo
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpression.Desc BlendTo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpression.Desc>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }

    /// <summary>
    /// ByteProperty: DecodeBlendType
    /// </summary>
    public unsafe byte DecodeBlendType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }
}
