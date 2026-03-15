#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleLocationPrimitiveSphere<br/>
/// (size = 144)
/// (flags = 142610578)
/// </summary>
public partial class ParticleModuleLocationPrimitiveSphere : BmSDK.Engine.ParticleModuleLocationPrimitiveBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleLocationPrimitiveSphere", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleLocationPrimitiveSphere() { }

    /// <summary>
    /// Constructs a new ParticleModuleLocationPrimitiveSphere
    /// </summary>
    public ParticleModuleLocationPrimitiveSphere(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleLocationPrimitiveSphere Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleLocationPrimitiveSphere(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: StartRadius
    /// </summary>
    public unsafe BmSDK.DistributionFloat.FRawDistributionFloat StartRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }
}
