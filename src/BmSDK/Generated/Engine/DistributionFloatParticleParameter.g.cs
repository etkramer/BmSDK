#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: DistributionFloatParticleParameter<br/>
/// (size = 96)
/// (flags = 134230162)
/// </summary>
public partial class DistributionFloatParticleParameter : BmSDK.Engine.DistributionFloatParameterBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.DistributionFloatParticleParameter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal DistributionFloatParticleParameter() { }

    /// <summary>
    /// Constructs a new DistributionFloatParticleParameter
    /// </summary>
    public DistributionFloatParticleParameter(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, DistributionFloatParticleParameter Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected DistributionFloatParticleParameter(nint ptr) : base(ptr) { }

}
