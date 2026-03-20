#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionBumpOffset<br/>
/// (flags = 0)
/// </summary>
public partial class MaterialExpressionBumpOffset : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionBumpOffset", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionBumpOffset() { }

    /// <summary>
    /// Constructs a new MaterialExpressionBumpOffset
    /// </summary>
    public MaterialExpressionBumpOffset(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionBumpOffset Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionBumpOffset(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: Coordinate
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpression.FExpressionInput Coordinate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpression.FExpressionInput>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// StructProperty: Height
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpression.FExpressionInput Height
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpression.FExpressionInput>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// StructProperty: HeightRatioInput
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpression.FExpressionInput HeightRatioInput
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpression.FExpressionInput>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// FloatProperty: HeightRatio
    /// </summary>
    public unsafe float HeightRatio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }

    /// <summary>
    /// FloatProperty: ReferencePlane
    /// </summary>
    public unsafe float ReferencePlane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }
}
