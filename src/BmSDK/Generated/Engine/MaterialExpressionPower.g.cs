#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionPower<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MaterialExpressionPower : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionPower", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionPower() { }

    /// <summary>
    /// Constructs a new MaterialExpressionPower
    /// </summary>
    public MaterialExpressionPower(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionPower Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionPower(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: Base
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpressionPower.Exponent Base
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpressionPower.Exponent>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// StructProperty: Exponent
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpression.Desc Exponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpression.Desc>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// BoolProperty: NonNegative
    /// </summary>
    public unsafe bool NonNegative
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 276); }
    }

    /// <summary>
    /// BoolProperty: NonZero
    /// </summary>
    public unsafe bool NonZero
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 276); }
    }
}
