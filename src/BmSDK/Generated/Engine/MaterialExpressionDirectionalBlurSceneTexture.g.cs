#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionDirectionalBlurSceneTexture<br/>
/// (flags = 0)
/// </summary>
public partial class MaterialExpressionDirectionalBlurSceneTexture : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionDirectionalBlurSceneTexture", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionDirectionalBlurSceneTexture() { }

    /// <summary>
    /// Constructs a new MaterialExpressionDirectionalBlurSceneTexture
    /// </summary>
    public MaterialExpressionDirectionalBlurSceneTexture(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionDirectionalBlurSceneTexture Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionDirectionalBlurSceneTexture(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: Coordinates
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpression.FExpressionInput Coordinates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpression.FExpressionInput>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// StructProperty: SampleDirection
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpression.FExpressionInput SampleDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpression.FExpressionInput>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// BoolProperty: ScreenAlign
    /// </summary>
    public unsafe bool ScreenAlign
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 276); }
    }

    /// <summary>
    /// IntProperty: SampleNum
    /// </summary>
    public unsafe int SampleNum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }
}
