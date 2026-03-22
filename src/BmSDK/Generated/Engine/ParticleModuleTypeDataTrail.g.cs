#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleTypeDataTrail<br/>
/// (size = 104)
/// (flags = 142618770)
/// </summary>
public partial class ParticleModuleTypeDataTrail : BmSDK.Engine.ParticleModuleTypeDataBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleTypeDataTrail", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleTypeDataTrail() { }

    /// <summary>
    /// Constructs a new ParticleModuleTypeDataTrail
    /// </summary>
    public ParticleModuleTypeDataTrail(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleTypeDataTrail Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleTypeDataTrail(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: RenderGeometry
    /// </summary>
    public unsafe bool RenderGeometry
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: RenderLines
    /// </summary>
    public unsafe bool RenderLines
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: RenderTessellation
    /// </summary>
    public unsafe bool RenderTessellation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: Tapered
    /// </summary>
    public unsafe bool Tapered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: SpawnByDistance
    /// </summary>
    public unsafe bool SpawnByDistance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// IntProperty: TessellationFactor
    /// </summary>
    public unsafe int TessellationFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }

    /// <summary>
    /// StructProperty: Tension
    /// </summary>
    public unsafe BmSDK.DistributionFloat.FRawDistributionFloat Tension
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 64); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }
    }

    /// <summary>
    /// StructProperty: SpawnDistance
    /// </summary>
    public unsafe System.Numerics.Vector3 SpawnDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }
}
