#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: InterpTrackInstDirector<br/>
/// (size = 48)
/// (flags = 134217874)
/// </summary>
public partial class InterpTrackInstDirector : BmSDK.Engine.InterpTrackInst, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.InterpTrackInstDirector", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal InterpTrackInstDirector() { }

    /// <summary>
    /// Constructs a new InterpTrackInstDirector
    /// </summary>
    public InterpTrackInstDirector(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, InterpTrackInstDirector Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected InterpTrackInstDirector(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: OldViewTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor OldViewTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }
}
