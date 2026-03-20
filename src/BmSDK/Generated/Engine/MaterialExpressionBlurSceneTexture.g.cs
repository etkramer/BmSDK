#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionBlurSceneTexture<br/>
/// (size = 292)
/// (flags = 134226066)
/// </summary>
public partial class MaterialExpressionBlurSceneTexture : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionBlurSceneTexture", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionBlurSceneTexture() { }

    /// <summary>
    /// Constructs a new MaterialExpressionBlurSceneTexture
    /// </summary>
    public MaterialExpressionBlurSceneTexture(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionBlurSceneTexture Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionBlurSceneTexture(nint ptr) : base(ptr) { }

    /// <summary>
    /// Enum: ESampleBlurSceneType
    /// </summary>
    public enum ESampleBlurSceneType
    {
        SampleBlurScene_PoissonDisc = 0,
        SampleBlurScene_MAX = 1,
    }

    /// <summary>
    /// Enum: EBlurSceneTextureType
    /// </summary>
    public enum EBlurSceneTextureType
    {
        BlurSceneTex_Lighting = 0,
        BlurSceneTex_MAX = 1,
    }

    /// <summary>
    /// StructProperty: Coordinates
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpression.FExpressionInput Coordinates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpression.FExpressionInput>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// StructProperty: SampleRadius
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpression.FExpressionInput SampleRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpression.FExpressionInput>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// ByteProperty: BlurSceneTextureType
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpressionBlurSceneTexture.EBlurSceneTextureType BlurSceneTextureType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpressionBlurSceneTexture.EBlurSceneTextureType>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// ByteProperty: SampleBlurSceneType
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpressionBlurSceneTexture.ESampleBlurSceneType SampleBlurSceneType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpressionBlurSceneTexture.ESampleBlurSceneType>(Ptr + 277); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 277); }
    }

    /// <summary>
    /// BoolProperty: ScreenAlign
    /// </summary>
    public unsafe bool ScreenAlign
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 280); }
    }

    /// <summary>
    /// IntProperty: SampleNum
    /// </summary>
    public unsafe int SampleNum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// FloatProperty: SampleRadiusDefault
    /// </summary>
    public unsafe float SampleRadiusDefault
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }
}
