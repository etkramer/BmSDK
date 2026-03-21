#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: InterpTrackInstStereoConvergence<br/>
/// (size = 48)
/// (flags = 134217874)
/// </summary>
public partial class InterpTrackInstStereoConvergence : BmSDK.Engine.InterpTrackInst, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.InterpTrackInstStereoConvergence", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal InterpTrackInstStereoConvergence() { }

    /// <summary>
    /// Constructs a new InterpTrackInstStereoConvergence
    /// </summary>
    public InterpTrackInstStereoConvergence(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, InterpTrackInstStereoConvergence Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected InterpTrackInstStereoConvergence(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: storedStereoConvergence
    /// </summary>
    public unsafe float storedStereoConvergence
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }
}
