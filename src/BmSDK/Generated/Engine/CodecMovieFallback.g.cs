#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: CodecMovieFallback<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class CodecMovieFallback : BmSDK.Engine.CodecMovie, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.CodecMovieFallback", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal CodecMovieFallback() { }

    /// <summary>
    /// Constructs a new CodecMovieFallback
    /// </summary>
    public CodecMovieFallback(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, CodecMovieFallback Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected CodecMovieFallback(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: CurrentTime
    /// </summary>
    public unsafe float CurrentTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }
}
