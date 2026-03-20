#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleCameraOffset<br/>
/// (flags = 0)
/// </summary>
public partial class ParticleModuleCameraOffset : BmSDK.Engine.ParticleModuleCameraBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleCameraOffset", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleCameraOffset() { }

    /// <summary>
    /// Constructs a new ParticleModuleCameraOffset
    /// </summary>
    public ParticleModuleCameraOffset(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleCameraOffset Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleCameraOffset(nint ptr) : base(ptr) { }

    /// <summary>
    /// Enum: EParticleCameraOffsetUpdateMethod
    /// </summary>
    public enum EParticleCameraOffsetUpdateMethod
    {
        EPCOUM_DirectSet = 0,
        EPCOUM_Additive = 1,
        EPCOUM_Scalar = 2,
        EPCOUM_MAX = 3,
    }

    /// <summary>
    /// StructProperty: CameraOffset
    /// </summary>
    public unsafe BmSDK.DistributionFloat.FRawDistributionFloat CameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bSpawnTimeOnly
    /// </summary>
    public unsafe bool bSpawnTimeOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 132); }
    }

    /// <summary>
    /// ByteProperty: UpdateMethod
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleCameraOffset.EParticleCameraOffsetUpdateMethod UpdateMethod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleCameraOffset.EParticleCameraOffsetUpdateMethod>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }
}
