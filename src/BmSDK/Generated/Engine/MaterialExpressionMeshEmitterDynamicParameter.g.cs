#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionMeshEmitterDynamicParameter<br/>
/// (flags = 0)
/// </summary>
public partial class MaterialExpressionMeshEmitterDynamicParameter : BmSDK.Engine.MaterialExpressionDynamicParameter, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionMeshEmitterDynamicParameter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionMeshEmitterDynamicParameter() { }

    /// <summary>
    /// Constructs a new MaterialExpressionMeshEmitterDynamicParameter
    /// </summary>
    public MaterialExpressionMeshEmitterDynamicParameter(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionMeshEmitterDynamicParameter Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionMeshEmitterDynamicParameter(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: ParamNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ParamNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bUsedWithMeshEmitter
    /// </summary>
    public unsafe bool bUsedWithMeshEmitter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 188) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 188); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 188); }
    }
}
