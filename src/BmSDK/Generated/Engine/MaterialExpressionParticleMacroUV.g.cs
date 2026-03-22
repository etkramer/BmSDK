#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionParticleMacroUV<br/>
/// (size = 96)
/// (flags = 134217874)
/// </summary>
public partial class MaterialExpressionParticleMacroUV : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionParticleMacroUV", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionParticleMacroUV() { }

    /// <summary>
    /// Constructs a new MaterialExpressionParticleMacroUV
    /// </summary>
    public MaterialExpressionParticleMacroUV(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionParticleMacroUV Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionParticleMacroUV(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bUseViewSpace
    /// </summary>
    public unsafe bool bUseViewSpace
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }
}
