#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionReflectionUV<br/>
/// (size = 108)
/// (flags = 134226066)
/// </summary>
public partial class MaterialExpressionReflectionUV : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionReflectionUV", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionReflectionUV() { }

    /// <summary>
    /// Constructs a new MaterialExpressionReflectionUV
    /// </summary>
    public MaterialExpressionReflectionUV(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionReflectionUV Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionReflectionUV(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: MaskTexture
    /// </summary>
    public unsafe BmSDK.Engine.Texture MaskTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ObjectProperty: ReflectionBufferTexture
    /// </summary>
    public unsafe BmSDK.Engine.Texture ReflectionBufferTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bUseMaskTexture
    /// </summary>
    public unsafe bool bUseMaskTexture
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// FloatProperty: NormalWeight
    /// </summary>
    public unsafe float NormalWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }
}
