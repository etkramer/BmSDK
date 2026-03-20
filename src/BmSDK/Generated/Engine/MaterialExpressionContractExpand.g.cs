#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionContractExpand<br/>
/// (size = 225)
/// (flags = 0)
/// </summary>
public partial class MaterialExpressionContractExpand : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionContractExpand", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionContractExpand() { }

    /// <summary>
    /// Constructs a new MaterialExpressionContractExpand
    /// </summary>
    public MaterialExpressionContractExpand(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionContractExpand Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionContractExpand(nint ptr) : base(ptr) { }

    /// <summary>
    /// Enum: EContractOrExpandInput
    /// </summary>
    public enum EContractOrExpandInput
    {
        Contract_Input = 0,
        Expand_Input = 1,
        EContractOrExpandInput_MAX = 2,
    }

    /// <summary>
    /// StructProperty: Input
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpression.FExpressionInput Input
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpression.FExpressionInput>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// ByteProperty: ContractOrExpandInput
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpressionContractExpand.EContractOrExpandInput ContractOrExpandInput
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpressionContractExpand.EContractOrExpandInput>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }
}
