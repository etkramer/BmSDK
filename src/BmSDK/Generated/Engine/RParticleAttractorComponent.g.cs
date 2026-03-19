#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RParticleAttractorComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RParticleAttractorComponent : BmSDK.Engine.ActorComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RParticleAttractorComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RParticleAttractorComponent() { }

    /// <summary>
    /// Constructs a new RParticleAttractorComponent
    /// </summary>
    public RParticleAttractorComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RParticleAttractorComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RParticleAttractorComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: AttractorChannel
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AttractorChannel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// StructProperty: Range
    /// </summary>
    public unsafe BmSDK.Engine.RParticleAttractorComponent.Strength Range
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RParticleAttractorComponent.Strength>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// StructProperty: Strength
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Strength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: StrengthByDistance
    /// </summary>
    public unsafe bool StrengthByDistance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 216) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 216); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 216); }
    }

    /// <summary>
    /// BoolProperty: bAffectBaseVelocity
    /// </summary>
    public unsafe bool bAffectBaseVelocity
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 216) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 216); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 216); }
    }

    /// <summary>
    /// BoolProperty: bOverrideVelocity
    /// </summary>
    public unsafe bool bOverrideVelocity
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 216) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 216); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 216); }
    }
}
