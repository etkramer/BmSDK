#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleRotationOverLifetime<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ParticleModuleRotationOverLifetime : BmSDK.Engine.ParticleModuleRotationBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleRotationOverLifetime", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleRotationOverLifetime() { }

    /// <summary>
    /// Constructs a new ParticleModuleRotationOverLifetime
    /// </summary>
    public ParticleModuleRotationOverLifetime(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleRotationOverLifetime Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleRotationOverLifetime(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: RotationOverLife
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RotationOverLife
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: Scale
    /// </summary>
    public unsafe bool Scale
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 132); }
    }
}
