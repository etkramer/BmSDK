#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// ABSTRACT Class: MaterialExpressionTextureSampleParameter<br/>
/// (size = 136)
/// (flags = 134226067)
/// </summary>
public partial class MaterialExpressionTextureSampleParameter : BmSDK.Engine.MaterialExpressionTextureSample, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionTextureSampleParameter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionTextureSampleParameter() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionTextureSampleParameter(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: ParameterName
    /// </summary>
    public unsafe BmSDK.FName ParameterName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// StructProperty: ExpressionGUID
    /// </summary>
    public unsafe BmSDK.GameObject.FGuid ExpressionGUID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FGuid>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }
}
