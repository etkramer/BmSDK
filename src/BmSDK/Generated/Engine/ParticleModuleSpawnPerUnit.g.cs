#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleSpawnPerUnit<br/>
/// (flags = 0)
/// </summary>
public partial class ParticleModuleSpawnPerUnit : BmSDK.Engine.ParticleModuleSpawnBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleSpawnPerUnit", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleSpawnPerUnit() { }

    /// <summary>
    /// Constructs a new ParticleModuleSpawnPerUnit
    /// </summary>
    public ParticleModuleSpawnPerUnit(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleSpawnPerUnit Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleSpawnPerUnit(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: UnitScalar
    /// </summary>
    public unsafe float UnitScalar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// StructProperty: SpawnPerUnit
    /// </summary>
    public unsafe BmSDK.DistributionFloat.FRawDistributionFloat SpawnPerUnit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreSpawnRateWhenMoving
    /// </summary>
    public unsafe bool bIgnoreSpawnRateWhenMoving
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 140); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreMovementAlongX
    /// </summary>
    public unsafe bool bIgnoreMovementAlongX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 140); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreMovementAlongY
    /// </summary>
    public unsafe bool bIgnoreMovementAlongY
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 140); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreMovementAlongZ
    /// </summary>
    public unsafe bool bIgnoreMovementAlongZ
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 140); }
    }

    /// <summary>
    /// FloatProperty: MovementTolerance
    /// </summary>
    public unsafe float MovementTolerance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// FloatProperty: MaxFrameDistance
    /// </summary>
    public unsafe float MaxFrameDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// FloatProperty: MinFrameDistance
    /// </summary>
    public unsafe float MinFrameDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }
}
