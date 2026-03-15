#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SequenceFrameWrapped<br/>
/// (size = 152)
/// (flags = 134217874)
/// </summary>
public partial class SequenceFrameWrapped : BmSDK.Engine.SequenceFrame, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SequenceFrameWrapped", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SequenceFrameWrapped() { }

    /// <summary>
    /// Constructs a new SequenceFrameWrapped
    /// </summary>
    public SequenceFrameWrapped(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SequenceFrameWrapped Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SequenceFrameWrapped(nint ptr) : base(ptr) { }

}
