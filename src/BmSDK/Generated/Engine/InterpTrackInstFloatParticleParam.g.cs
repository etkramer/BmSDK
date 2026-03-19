#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: InterpTrackInstFloatParticleParam<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class InterpTrackInstFloatParticleParam : BmSDK.Engine.InterpTrackInst, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.InterpTrackInstFloatParticleParam", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal InterpTrackInstFloatParticleParam() { }

    /// <summary>
    /// Constructs a new InterpTrackInstFloatParticleParam
    /// </summary>
    public InterpTrackInstFloatParticleParam(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, InterpTrackInstFloatParticleParam Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected InterpTrackInstFloatParticleParam(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: ResetFloat
    /// </summary>
    public unsafe float ResetFloat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
}
