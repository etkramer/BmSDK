#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionParameter<br/>
/// (size = 104)
/// (flags = 134226066)
/// </summary>
public partial class MaterialExpressionParameter : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionParameter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionParameter() { }

    /// <summary>
    /// Constructs a new MaterialExpressionParameter
    /// </summary>
    public MaterialExpressionParameter(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionParameter Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionParameter(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: ParameterName
    /// </summary>
    public unsafe BmSDK.FName ParameterName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// StructProperty: ExpressionGUID
    /// </summary>
    public unsafe BmSDK.GameObject.FGuid ExpressionGUID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FGuid>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }
}
