#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionSceneTexture<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MaterialExpressionSceneTexture : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionSceneTexture", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionSceneTexture() { }

    /// <summary>
    /// Constructs a new MaterialExpressionSceneTexture
    /// </summary>
    public MaterialExpressionSceneTexture(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionSceneTexture Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionSceneTexture(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: Coordinates
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpression.Desc Coordinates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpression.Desc>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// ByteProperty: SceneTextureType
    /// </summary>
    public unsafe byte SceneTextureType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// BoolProperty: ScreenAlign
    /// </summary>
    public unsafe bool ScreenAlign
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 228) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 228); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 228); }
    }
}
