#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: InterpTrackStereoConvergence<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class InterpTrackStereoConvergence : BmSDK.Engine.InterpTrackFloatBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.InterpTrackStereoConvergence", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal InterpTrackStereoConvergence() { }

    /// <summary>
    /// Constructs a new InterpTrackStereoConvergence
    /// </summary>
    public InterpTrackStereoConvergence(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, InterpTrackStereoConvergence Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected InterpTrackStereoConvergence(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: ResetConvergence
    /// </summary>
    public unsafe bool ResetConvergence
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }
}
