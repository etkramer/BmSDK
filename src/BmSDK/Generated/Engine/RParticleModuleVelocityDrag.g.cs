#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RParticleModuleVelocityDrag<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RParticleModuleVelocityDrag : BmSDK.Engine.ParticleModuleVelocityBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RParticleModuleVelocityDrag", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RParticleModuleVelocityDrag() { }

    /// <summary>
    /// Constructs a new RParticleModuleVelocityDrag
    /// </summary>
    public RParticleModuleVelocityDrag(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RParticleModuleVelocityDrag Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RParticleModuleVelocityDrag(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: LinearDampingPerSecond
    /// </summary>
    public unsafe float LinearDampingPerSecond
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }
}
