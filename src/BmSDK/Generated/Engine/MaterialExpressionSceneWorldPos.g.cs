#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionSceneWorldPos<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MaterialExpressionSceneWorldPos : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionSceneWorldPos", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionSceneWorldPos() { }

    /// <summary>
    /// Constructs a new MaterialExpressionSceneWorldPos
    /// </summary>
    public MaterialExpressionSceneWorldPos(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionSceneWorldPos Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionSceneWorldPos(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: TexCoord
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpression.FExpressionInput TexCoord
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpression.FExpressionInput>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }
}
