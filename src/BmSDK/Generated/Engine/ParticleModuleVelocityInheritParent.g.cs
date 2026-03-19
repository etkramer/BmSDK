#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleVelocityInheritParent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ParticleModuleVelocityInheritParent : BmSDK.Engine.ParticleModuleVelocityBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleVelocityInheritParent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleVelocityInheritParent() { }

    /// <summary>
    /// Constructs a new ParticleModuleVelocityInheritParent
    /// </summary>
    public ParticleModuleVelocityInheritParent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleVelocityInheritParent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleVelocityInheritParent(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: Scale
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Scale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }
}
