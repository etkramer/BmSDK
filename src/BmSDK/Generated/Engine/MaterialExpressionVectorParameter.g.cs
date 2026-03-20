#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionVectorParameter<br/>
/// (size = 220)
/// (flags = 0)
/// </summary>
public partial class MaterialExpressionVectorParameter : BmSDK.Engine.MaterialExpressionParameter, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionVectorParameter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionVectorParameter() { }

    /// <summary>
    /// Constructs a new MaterialExpressionVectorParameter
    /// </summary>
    public MaterialExpressionVectorParameter(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionVectorParameter Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionVectorParameter(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: DefaultValue
    /// </summary>
    public unsafe BmSDK.GameObject.FLinearColor DefaultValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FLinearColor>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }
}
