#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleUberLTISIVCLIL<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ParticleModuleUberLTISIVCLIL : BmSDK.Engine.ParticleModuleUberBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleUberLTISIVCLIL", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleUberLTISIVCLIL() { }

    /// <summary>
    /// Constructs a new ParticleModuleUberLTISIVCLIL
    /// </summary>
    public ParticleModuleUberLTISIVCLIL(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleUberLTISIVCLIL Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleUberLTISIVCLIL(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: Lifetime
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleUberLTISIVCLIL.StartSize Lifetime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleUberLTISIVCLIL.StartSize>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// StructProperty: StartSize
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleUberLTISIVCLIL.StartVelocity StartSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleUberLTISIVCLIL.StartVelocity>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// StructProperty: StartVelocity
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleUberLTISIVCLIL.StartVelocityRadial StartVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleUberLTISIVCLIL.StartVelocityRadial>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// StructProperty: StartVelocityRadial
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleUberLTISIVCLIL.ColorOverLife StartVelocityRadial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleUberLTISIVCLIL.ColorOverLife>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// StructProperty: ColorOverLife
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleUberLTISIVCLIL.AlphaOverLife ColorOverLife
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleUberLTISIVCLIL.AlphaOverLife>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }

    /// <summary>
    /// StructProperty: AlphaOverLife
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleUberLTISIVCLIL.StartLocation AlphaOverLife
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleUberLTISIVCLIL.StartLocation>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// StructProperty: StartLocation
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleUberBase.RequiredModules StartLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleUberBase.RequiredModules>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }
}
