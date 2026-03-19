#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleUberLTISIVCLILIRSSBLIRR<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ParticleModuleUberLTISIVCLILIRSSBLIRR : BmSDK.Engine.ParticleModuleUberBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleUberLTISIVCLILIRSSBLIRR", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleUberLTISIVCLILIRSSBLIRR() { }

    /// <summary>
    /// Constructs a new ParticleModuleUberLTISIVCLILIRSSBLIRR
    /// </summary>
    public ParticleModuleUberLTISIVCLILIRSSBLIRR(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleUberLTISIVCLILIRSSBLIRR Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleUberLTISIVCLILIRSSBLIRR(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: Lifetime
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleUberLTISIVCLILIRSSBLIRR.StartSize Lifetime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleUberLTISIVCLILIRSSBLIRR.StartSize>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// StructProperty: StartSize
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleUberLTISIVCLILIRSSBLIRR.StartVelocity StartSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleUberLTISIVCLILIRSSBLIRR.StartVelocity>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// StructProperty: StartVelocity
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleUberLTISIVCLILIRSSBLIRR.StartVelocityRadial StartVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleUberLTISIVCLILIRSSBLIRR.StartVelocityRadial>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// StructProperty: StartVelocityRadial
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleUberLTISIVCLILIRSSBLIRR.ColorOverLife StartVelocityRadial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleUberLTISIVCLILIRSSBLIRR.ColorOverLife>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// StructProperty: ColorOverLife
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleUberLTISIVCLILIRSSBLIRR.AlphaOverLife ColorOverLife
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleUberLTISIVCLILIRSSBLIRR.AlphaOverLife>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }

    /// <summary>
    /// StructProperty: AlphaOverLife
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleUberLTISIVCLILIRSSBLIRR.StartLocation AlphaOverLife
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleUberLTISIVCLILIRSSBLIRR.StartLocation>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// StructProperty: StartLocation
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleUberLTISIVCLILIRSSBLIRR.StartRotation StartLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleUberLTISIVCLILIRSSBLIRR.StartRotation>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// StructProperty: StartRotation
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleUberLTISIVCLILIRSSBLIRR.SizeLifeMultiplier StartRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleUberLTISIVCLILIRSSBLIRR.SizeLifeMultiplier>(Ptr + 476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 476); }
    }

    /// <summary>
    /// StructProperty: SizeLifeMultiplier
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleUberLTISIVCLILIRSSBLIRR.StartRotationRate SizeLifeMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleUberLTISIVCLILIRSSBLIRR.StartRotationRate>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// BoolProperty: SizeMultiplyX
    /// </summary>
    public unsafe bool SizeMultiplyX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 576); }
    }

    /// <summary>
    /// BoolProperty: SizeMultiplyY
    /// </summary>
    public unsafe bool SizeMultiplyY
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 576); }
    }

    /// <summary>
    /// BoolProperty: SizeMultiplyZ
    /// </summary>
    public unsafe bool SizeMultiplyZ
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 576); }
    }

    /// <summary>
    /// StructProperty: StartRotationRate
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleUberBase.RequiredModules StartRotationRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleUberBase.RequiredModules>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }
}
