#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionLightmassReplace<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MaterialExpressionLightmassReplace : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionLightmassReplace", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionLightmassReplace() { }

    /// <summary>
    /// Constructs a new MaterialExpressionLightmassReplace
    /// </summary>
    public MaterialExpressionLightmassReplace(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionLightmassReplace Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionLightmassReplace(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: Realtime
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpressionLightmassReplace.Lightmass Realtime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpressionLightmassReplace.Lightmass>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// StructProperty: Lightmass
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpression.Desc Lightmass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpression.Desc>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }
}
