#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: CodecMovieBink<br/>
/// (flags = 0)
/// </summary>
public partial class CodecMovieBink : BmSDK.Engine.CodecMovie, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.CodecMovieBink", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal CodecMovieBink() { }

    /// <summary>
    /// Constructs a new CodecMovieBink
    /// </summary>
    public CodecMovieBink(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, CodecMovieBink Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected CodecMovieBink(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: PlaybackDuration
    /// </summary>
    public unsafe float PlaybackDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
}
