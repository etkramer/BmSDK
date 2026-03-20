#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleMaterialByParameter<br/>
/// (flags = 0)
/// </summary>
public partial class ParticleModuleMaterialByParameter : BmSDK.Engine.ParticleModuleMaterialBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleMaterialByParameter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleMaterialByParameter() { }

    /// <summary>
    /// Constructs a new ParticleModuleMaterialByParameter
    /// </summary>
    public ParticleModuleMaterialByParameter(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleMaterialByParameter Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleMaterialByParameter(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: MaterialParameters
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> MaterialParameters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// ArrayProperty: DefaultMaterials
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInterface> DefaultMaterials
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInterface>>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }
}
