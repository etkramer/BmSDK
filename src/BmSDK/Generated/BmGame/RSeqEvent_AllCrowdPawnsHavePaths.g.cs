#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqEvent_AllCrowdPawnsHavePaths<br/>
/// (size = 228)
/// (flags = 18)
/// </summary>
public partial class RSeqEvent_AllCrowdPawnsHavePaths : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqEvent_AllCrowdPawnsHavePaths", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvent_AllCrowdPawnsHavePaths() { }

    /// <summary>
    /// Constructs a new RSeqEvent_AllCrowdPawnsHavePaths
    /// </summary>
    public RSeqEvent_AllCrowdPawnsHavePaths(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvent_AllCrowdPawnsHavePaths Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvent_AllCrowdPawnsHavePaths(nint ptr) : base(ptr) { }

}
