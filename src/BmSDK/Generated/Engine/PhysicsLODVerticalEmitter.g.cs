#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: PhysicsLODVerticalEmitter<br/>
/// (size = 88)
/// (flags = 0)
/// </summary>
public partial class PhysicsLODVerticalEmitter : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.PhysicsLODVerticalEmitter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal PhysicsLODVerticalEmitter() { }

    /// <summary>
    /// Constructs a new PhysicsLODVerticalEmitter
    /// </summary>
    public PhysicsLODVerticalEmitter(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, PhysicsLODVerticalEmitter Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected PhysicsLODVerticalEmitter(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: ParticlePercentage
    /// </summary>
    public unsafe int ParticlePercentage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
}
