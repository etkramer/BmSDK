#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqCond_VisibleLastFrame<br/>
/// (size = 324)
/// (flags = 0)
/// </summary>
public partial class RSeqCond_VisibleLastFrame : BmSDK.Engine.SequenceCondition, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqCond_VisibleLastFrame", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqCond_VisibleLastFrame() { }

    /// <summary>
    /// Constructs a new RSeqCond_VisibleLastFrame
    /// </summary>
    public RSeqCond_VisibleLastFrame(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqCond_VisibleLastFrame Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqCond_VisibleLastFrame(nint ptr) : base(ptr) { }

}
