#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionPlatformConstant<br/>
/// (size = 104)
/// (flags = 134226066)
/// </summary>
public partial class MaterialExpressionPlatformConstant : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionPlatformConstant", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionPlatformConstant() { }

    /// <summary>
    /// Constructs a new MaterialExpressionPlatformConstant
    /// </summary>
    public MaterialExpressionPlatformConstant(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionPlatformConstant Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionPlatformConstant(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: PC
    /// </summary>
    public unsafe float PC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// FloatProperty: Ps3
    /// </summary>
    public unsafe float Ps3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// FloatProperty: XBox
    /// </summary>
    public unsafe float XBox
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }
}
