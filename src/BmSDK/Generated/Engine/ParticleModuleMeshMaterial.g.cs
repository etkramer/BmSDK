#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleMeshMaterial<br/>
/// (flags = 0)
/// </summary>
public partial class ParticleModuleMeshMaterial : BmSDK.Engine.ParticleModuleMaterialBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleMeshMaterial", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleMeshMaterial() { }

    /// <summary>
    /// Constructs a new ParticleModuleMeshMaterial
    /// </summary>
    public ParticleModuleMeshMaterial(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleMeshMaterial Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleMeshMaterial(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: MeshMaterials
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInterface> MeshMaterials
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInterface>>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }
}
