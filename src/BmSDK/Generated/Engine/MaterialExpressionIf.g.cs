#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionIf<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MaterialExpressionIf : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionIf", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionIf() { }

    /// <summary>
    /// Constructs a new MaterialExpressionIf
    /// </summary>
    public MaterialExpressionIf(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionIf Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionIf(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: A
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpressionIf.B A
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpressionIf.B>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// StructProperty: B
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpressionIf.AGreaterThanB B
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpressionIf.AGreaterThanB>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// StructProperty: AGreaterThanB
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpressionIf.AEqualsB AGreaterThanB
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpressionIf.AEqualsB>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// StructProperty: AEqualsB
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpressionIf.ALessThanB AEqualsB
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpressionIf.ALessThanB>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }

    /// <summary>
    /// StructProperty: ALessThanB
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpression.Desc ALessThanB
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpression.Desc>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }
}
