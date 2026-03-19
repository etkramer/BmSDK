#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionScalarParameter<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MaterialExpressionScalarParameter : BmSDK.Engine.MaterialExpressionParameter, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionScalarParameter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionScalarParameter() { }

    /// <summary>
    /// Constructs a new MaterialExpressionScalarParameter
    /// </summary>
    public MaterialExpressionScalarParameter(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionScalarParameter Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionScalarParameter(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: DefaultValue
    /// </summary>
    public unsafe float DefaultValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }
}
