#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionDisplacementSampleLerp<br/>
/// (size = 132)
/// (flags = 134226066)
/// </summary>
public partial class MaterialExpressionDisplacementSampleLerp : BmSDK.Engine.MaterialExpressionTextureSample, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionDisplacementSampleLerp", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionDisplacementSampleLerp() { }

    /// <summary>
    /// Constructs a new MaterialExpressionDisplacementSampleLerp
    /// </summary>
    public MaterialExpressionDisplacementSampleLerp(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionDisplacementSampleLerp Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionDisplacementSampleLerp(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: Min
    /// </summary>
    public unsafe float Min
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// FloatProperty: Max
    /// </summary>
    public unsafe float Max
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }
}
