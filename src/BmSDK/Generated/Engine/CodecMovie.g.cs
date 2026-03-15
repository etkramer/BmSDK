#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// ABSTRACT Class: CodecMovie<br/>
/// (size = 48)
/// (flags = 134217883)
/// </summary>
public partial class CodecMovie : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.CodecMovie", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal CodecMovie() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected CodecMovie(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: PlaybackDuration
    /// </summary>
    public unsafe float PlaybackDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }
}
