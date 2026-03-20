#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionBlendMode<br/>
/// (size = 333)
/// (flags = 134226066)
/// </summary>
public partial class MaterialExpressionBlendMode : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionBlendMode", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionBlendMode() { }

    /// <summary>
    /// Constructs a new MaterialExpressionBlendMode
    /// </summary>
    public MaterialExpressionBlendMode(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionBlendMode Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionBlendMode(nint ptr) : base(ptr) { }

    /// <summary>
    /// Enum: EBlendModeFilter
    /// </summary>
    public enum EBlendModeFilter
    {
        BlendMode_Normal = 0,
        BlendMode_Darken = 1,
        BlendMode_Multiply = 2,
        BlendMode_ColourBurn = 3,
        BlendMode_Lighten = 4,
        BlendMode_Screen_EXPENSIVE = 5,
        BlendMode_Screen_CHEAP = 6,
        BlendMode_ColourDodge = 7,
        BlendMode_LinearDodge = 8,
        BlendMode_Overlay_EXPENSIVE = 9,
        BlendMode_Overlay_CHEAP = 10,
        BlendMode_SoftLight_EXPENSIVE = 11,
        BlendMode_SoftLight_CHEAP = 12,
        BlendMode_HardLight = 13,
        BlendMode_Difference = 14,
        BlendMode_Exclusion = 15,
        BlendMode_Negation = 16,
        BlendMode_MAX = 17,
    }

    /// <summary>
    /// StructProperty: A
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpression.FExpressionInput A
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpression.FExpressionInput>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// StructProperty: B
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpression.FExpressionInput B
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpression.FExpressionInput>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// StructProperty: Percent
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpression.FExpressionInput Percent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpression.FExpressionInput>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// FloatProperty: DefaultPercent
    /// </summary>
    public unsafe float DefaultPercent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }

    /// <summary>
    /// ByteProperty: BlendModeSelect
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpressionBlendMode.EBlendModeFilter BlendModeSelect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpressionBlendMode.EBlendModeFilter>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }
}
