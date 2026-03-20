#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_BeatDownCriticalEnd<br/>
/// (size = 236)
/// (flags = 0)
/// </summary>
public partial class RDmgType_BeatDownCriticalEnd : BmSDK.BmGame.RDmgType_BeatDownEnd, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_BeatDownCriticalEnd", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_BeatDownCriticalEnd() { }

    /// <summary>
    /// Constructs a new RDmgType_BeatDownCriticalEnd
    /// </summary>
    public RDmgType_BeatDownCriticalEnd(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_BeatDownCriticalEnd Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_BeatDownCriticalEnd(nint ptr) : base(ptr) { }

}
