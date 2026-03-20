#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionFoliageNormalizedRotationAxisAndAngle<br/>
/// (flags = 0)
/// </summary>
public partial class MaterialExpressionFoliageNormalizedRotationAxisAndAngle : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionFoliageNormalizedRotationAxisAndAngle", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionFoliageNormalizedRotationAxisAndAngle() { }

    /// <summary>
    /// Constructs a new MaterialExpressionFoliageNormalizedRotationAxisAndAngle
    /// </summary>
    public MaterialExpressionFoliageNormalizedRotationAxisAndAngle(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionFoliageNormalizedRotationAxisAndAngle Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionFoliageNormalizedRotationAxisAndAngle(nint ptr) : base(ptr) { }

}
