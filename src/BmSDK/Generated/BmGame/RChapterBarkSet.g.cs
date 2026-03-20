#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RChapterBarkSet<br/>
/// (flags = 0)
/// </summary>
public partial class RChapterBarkSet : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RChapterBarkSet", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RChapterBarkSet() { }

    /// <summary>
    /// Constructs a new RChapterBarkSet
    /// </summary>
    public RChapterBarkSet(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RChapterBarkSet Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RChapterBarkSet(nint ptr) : base(ptr) { }

}
