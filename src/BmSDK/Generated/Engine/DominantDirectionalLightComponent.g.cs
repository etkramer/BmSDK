#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: DominantDirectionalLightComponent<br/>
/// (size = 848)
/// (flags = 0)
/// </summary>
public partial class DominantDirectionalLightComponent : BmSDK.Engine.DirectionalLightComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.DominantDirectionalLightComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal DominantDirectionalLightComponent() { }

    /// <summary>
    /// Constructs a new DominantDirectionalLightComponent
    /// </summary>
    public DominantDirectionalLightComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, DominantDirectionalLightComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected DominantDirectionalLightComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: DominantLightShadowInfo
    /// </summary>
    public unsafe BmSDK.Engine.EngineTypes.FDominantShadowInfo DominantLightShadowInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.EngineTypes.FDominantShadowInfo>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// StructProperty: DominantLightShadowMap
    /// </summary>
    public unsafe BmSDK.GameObject.FArray_Mirror DominantLightShadowMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FArray_Mirror>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }
}
