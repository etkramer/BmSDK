#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleSubUVDirect<br/>
/// (size = 224)
/// (flags = 142610578)
/// </summary>
public partial class ParticleModuleSubUVDirect : BmSDK.Engine.ParticleModuleSubUVBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleSubUVDirect", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleSubUVDirect() { }

    /// <summary>
    /// Constructs a new ParticleModuleSubUVDirect
    /// </summary>
    public ParticleModuleSubUVDirect(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleSubUVDirect Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleSubUVDirect(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: SubUVPosition
    /// </summary>
    public unsafe BmSDK.DistributionVector.FRawDistributionVector SubUVPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionVector.FRawDistributionVector>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// StructProperty: SubUVSize
    /// </summary>
    public unsafe BmSDK.DistributionVector.FRawDistributionVector SubUVSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionVector.FRawDistributionVector>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }
}
