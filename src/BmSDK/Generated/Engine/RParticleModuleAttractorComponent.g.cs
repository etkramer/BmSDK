#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RParticleModuleAttractorComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RParticleModuleAttractorComponent : BmSDK.Engine.ParticleModuleAttractorBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RParticleModuleAttractorComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RParticleModuleAttractorComponent() { }

    /// <summary>
    /// Constructs a new RParticleModuleAttractorComponent
    /// </summary>
    public RParticleModuleAttractorComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RParticleModuleAttractorComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RParticleModuleAttractorComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: AttractorChannel
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AttractorChannel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: PlayerCharacter
    /// </summary>
    public unsafe bool PlayerCharacter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// StructProperty: StrengthMultiplier
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT StrengthMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }
}
