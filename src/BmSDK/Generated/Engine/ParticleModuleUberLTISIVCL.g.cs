#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleUberLTISIVCL<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ParticleModuleUberLTISIVCL : BmSDK.Engine.ParticleModuleUberBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleUberLTISIVCL", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleUberLTISIVCL() { }

    /// <summary>
    /// Constructs a new ParticleModuleUberLTISIVCL
    /// </summary>
    public ParticleModuleUberLTISIVCL(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleUberLTISIVCL Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleUberLTISIVCL(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: Lifetime
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleUberLTISIVCL.StartSize Lifetime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleUberLTISIVCL.StartSize>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// StructProperty: StartSize
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleUberLTISIVCL.StartVelocity StartSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleUberLTISIVCL.StartVelocity>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// StructProperty: StartVelocity
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleUberLTISIVCL.StartVelocityRadial StartVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleUberLTISIVCL.StartVelocityRadial>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// StructProperty: StartVelocityRadial
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleUberLTISIVCL.ColorOverLife StartVelocityRadial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleUberLTISIVCL.ColorOverLife>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// StructProperty: ColorOverLife
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleUberLTISIVCL.AlphaOverLife ColorOverLife
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleUberLTISIVCL.AlphaOverLife>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }

    /// <summary>
    /// StructProperty: AlphaOverLife
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleUberBase.RequiredModules AlphaOverLife
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleUberBase.RequiredModules>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }
}
