#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDistributionVectorParticleArrayParameter<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RDistributionVectorParticleArrayParameter : BmSDK.Engine.DistributionVectorParameterBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDistributionVectorParticleArrayParameter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDistributionVectorParticleArrayParameter() { }

    /// <summary>
    /// Constructs a new RDistributionVectorParticleArrayParameter
    /// </summary>
    public RDistributionVectorParticleArrayParameter(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDistributionVectorParticleArrayParameter Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDistributionVectorParticleArrayParameter(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: LastRenderTime
    /// </summary>
    public unsafe float LastRenderTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// IntProperty: ParticleIndex
    /// </summary>
    public unsafe int ParticleIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// IntProperty: DynamicCount
    /// </summary>
    public unsafe int DynamicCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }
}
