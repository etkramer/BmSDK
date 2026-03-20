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
