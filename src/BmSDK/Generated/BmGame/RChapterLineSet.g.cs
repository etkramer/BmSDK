#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RChapterLineSet<br/>
/// (flags = 0)
/// </summary>
public partial class RChapterLineSet : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RChapterLineSet", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RChapterLineSet() { }

    /// <summary>
    /// Constructs a new RChapterLineSet
    /// </summary>
    public RChapterLineSet(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RChapterLineSet Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RChapterLineSet(nint ptr) : base(ptr) { }

}
