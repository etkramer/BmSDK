#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionOneMinus<br/>
/// (size = 120)
/// (flags = 134226066)
/// </summary>
public partial class MaterialExpressionOneMinus : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionOneMinus", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionOneMinus() { }

    /// <summary>
    /// Constructs a new MaterialExpressionOneMinus
    /// </summary>
    public MaterialExpressionOneMinus(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionOneMinus Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionOneMinus(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: Input
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpression.FExpressionInput Input
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpression.FExpressionInput>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }
}
