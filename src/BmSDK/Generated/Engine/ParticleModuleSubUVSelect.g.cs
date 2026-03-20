#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleSubUVSelect<br/>
/// (size = 160)
/// (flags = 0)
/// </summary>
public partial class ParticleModuleSubUVSelect : BmSDK.Engine.ParticleModuleSubUVBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleSubUVSelect", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleSubUVSelect() { }

    /// <summary>
    /// Constructs a new ParticleModuleSubUVSelect
    /// </summary>
    public ParticleModuleSubUVSelect(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleSubUVSelect Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleSubUVSelect(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: SubImageSelect
    /// </summary>
    public unsafe BmSDK.DistributionVector.FRawDistributionVector SubImageSelect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionVector.FRawDistributionVector>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }
}
