#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleOrientationAxisLock<br/>
/// (flags = 0)
/// </summary>
public partial class ParticleModuleOrientationAxisLock : BmSDK.Engine.ParticleModuleOrientationBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleOrientationAxisLock", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleOrientationAxisLock() { }

    /// <summary>
    /// Constructs a new ParticleModuleOrientationAxisLock
    /// </summary>
    public ParticleModuleOrientationAxisLock(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleOrientationAxisLock Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleOrientationAxisLock(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: LockAxisFlags
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleOrientationAxisLock.EParticleAxisLock LockAxisFlags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleOrientationAxisLock.EParticleAxisLock>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// Enum: EParticleAxisLock
    /// </summary>
    public enum EParticleAxisLock
    {
        EPAL_NONE = 0,
        EPAL_X = 1,
        EPAL_Y = 2,
        EPAL_Z = 3,
        EPAL_NEGATIVE_X = 4,
        EPAL_NEGATIVE_Y = 5,
        EPAL_NEGATIVE_Z = 6,
        EPAL_ROTATE_X = 7,
        EPAL_ROTATE_Y = 8,
        EPAL_ROTATE_Z = 9,
        EPAL_MAX = 10,
    }
}
