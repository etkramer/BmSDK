#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionRefract<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MaterialExpressionRefract : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionRefract", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionRefract() { }

    /// <summary>
    /// Constructs a new MaterialExpressionRefract
    /// </summary>
    public MaterialExpressionRefract(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionRefract Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionRefract(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: Ray
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpressionRefract.Normal Ray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpressionRefract.Normal>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// StructProperty: Normal
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpressionRefract.IOR Normal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpressionRefract.IOR>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// StructProperty: IOR
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpression.Desc IOR
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpression.Desc>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// FloatProperty: DefaultIOR
    /// </summary>
    public unsafe float DefaultIOR
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }
}
