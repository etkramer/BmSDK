#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionSphericalMapping<br/>
/// (size = 173)
/// (flags = 0)
/// </summary>
public partial class MaterialExpressionSphericalMapping : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionSphericalMapping", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionSphericalMapping() { }

    /// <summary>
    /// Constructs a new MaterialExpressionSphericalMapping
    /// </summary>
    public MaterialExpressionSphericalMapping(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionSphericalMapping Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionSphericalMapping(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: SphericalMappingType
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpressionSphericalMapping.ESphericalMappingType SphericalMappingType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpressionSphericalMapping.ESphericalMappingType>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// Enum: ESphericalMappingType
    /// </summary>
    public enum ESphericalMappingType
    {
        SPHERICALMAPPING_Correct = 0,
        SPHERICALMAPPING_CheapAlternative = 1,
        SPHERICALMAPPING_MAX = 2,
    }
}
