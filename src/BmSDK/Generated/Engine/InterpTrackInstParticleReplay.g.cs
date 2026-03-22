#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: InterpTrackInstParticleReplay<br/>
/// (size = 48)
/// (flags = 134217874)
/// </summary>
public partial class InterpTrackInstParticleReplay : BmSDK.Engine.InterpTrackInst, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.InterpTrackInstParticleReplay", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal InterpTrackInstParticleReplay() { }

    /// <summary>
    /// Constructs a new InterpTrackInstParticleReplay
    /// </summary>
    public InterpTrackInstParticleReplay(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, InterpTrackInstParticleReplay Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected InterpTrackInstParticleReplay(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: LastUpdatePosition
    /// </summary>
    public unsafe float LastUpdatePosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }
}
