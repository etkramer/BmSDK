#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionStaticComponentMaskParameter<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MaterialExpressionStaticComponentMaskParameter : BmSDK.Engine.MaterialExpressionParameter, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionStaticComponentMaskParameter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionStaticComponentMaskParameter() { }

    /// <summary>
    /// Constructs a new MaterialExpressionStaticComponentMaskParameter
    /// </summary>
    public MaterialExpressionStaticComponentMaskParameter(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionStaticComponentMaskParameter Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionStaticComponentMaskParameter(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: Input
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpression.Desc Input
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpression.Desc>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// BoolProperty: DefaultR
    /// </summary>
    public unsafe bool DefaultR
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: DefaultG
    /// </summary>
    public unsafe bool DefaultG
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: DefaultB
    /// </summary>
    public unsafe bool DefaultB
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: DefaultA
    /// </summary>
    public unsafe bool DefaultA
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// StructProperty: InstanceOverride
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT InstanceOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }
}
