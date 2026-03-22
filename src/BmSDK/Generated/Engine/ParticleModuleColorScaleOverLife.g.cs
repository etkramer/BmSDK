#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleColorScaleOverLife<br/>
/// (size = 116)
/// (flags = 142610578)
/// </summary>
public partial class ParticleModuleColorScaleOverLife : BmSDK.Engine.ParticleModuleColorBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleColorScaleOverLife", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleColorScaleOverLife() { }

    /// <summary>
    /// Constructs a new ParticleModuleColorScaleOverLife
    /// </summary>
    public ParticleModuleColorScaleOverLife(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleColorScaleOverLife Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleColorScaleOverLife(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: ColorScaleOverLife
    /// </summary>
    public unsafe BmSDK.DistributionVector.FRawDistributionVector ColorScaleOverLife
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionVector.FRawDistributionVector>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// StructProperty: AlphaScaleOverLife
    /// </summary>
    public unsafe BmSDK.DistributionFloat.FRawDistributionFloat AlphaScaleOverLife
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// BoolProperty: bEmitterTime
    /// </summary>
    public unsafe bool bEmitterTime
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }
}
