#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// ABSTRACT Class: ParticleModuleFieldSamplerBase<br/>
/// (size = 104)
/// (flags = 142610579)
/// </summary>
public partial class ParticleModuleFieldSamplerBase : BmSDK.Engine.ParticleModule, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleFieldSamplerBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleFieldSamplerBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleFieldSamplerBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetApexFieldSamplerInstance
    /// </summary>
    public unsafe virtual BmSDK.Engine.ApexFieldSamplerComponent GetApexFieldSamplerInstance(System.Numerics.Vector3 Location)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.ParticleModuleFieldSamplerBase.GetApexFieldSamplerInstance", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Location, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ApexFieldSamplerComponent>(paramsPtr + 12);
    }

    /// <summary>
    /// ComponentProperty: FieldSamplerComponent
    /// </summary>
    public unsafe BmSDK.Engine.ApexFieldSamplerComponent FieldSamplerComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ApexFieldSamplerComponent>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }
}
