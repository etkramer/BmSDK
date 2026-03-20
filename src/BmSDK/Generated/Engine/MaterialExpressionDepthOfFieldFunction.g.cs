#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionDepthOfFieldFunction<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MaterialExpressionDepthOfFieldFunction : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionDepthOfFieldFunction", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionDepthOfFieldFunction() { }

    /// <summary>
    /// Constructs a new MaterialExpressionDepthOfFieldFunction
    /// </summary>
    public MaterialExpressionDepthOfFieldFunction(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionDepthOfFieldFunction Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionDepthOfFieldFunction(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: FunctionValue
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpressionDepthOfFieldFunction.EDepthOfFieldFunctionValue FunctionValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpressionDepthOfFieldFunction.EDepthOfFieldFunctionValue>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// StructProperty: Depth
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpression.FExpressionInput Depth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpression.FExpressionInput>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// Enum: EDepthOfFieldFunctionValue
    /// </summary>
    public enum EDepthOfFieldFunctionValue
    {
        TDOF_NearAndFarMask = 0,
        TDOF_NearMask = 1,
        TDOF_FarMask = 2,
        TDOF_MAX = 3,
    }
}
