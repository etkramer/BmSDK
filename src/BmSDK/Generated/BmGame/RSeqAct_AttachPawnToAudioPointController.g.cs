#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_AttachPawnToAudioPointController<br/>
/// (size = 352)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_AttachPawnToAudioPointController : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_AttachPawnToAudioPointController", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_AttachPawnToAudioPointController() { }

    /// <summary>
    /// Constructs a new RSeqAct_AttachPawnToAudioPointController
    /// </summary>
    public RSeqAct_AttachPawnToAudioPointController(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_AttachPawnToAudioPointController Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_AttachPawnToAudioPointController(nint ptr) : base(ptr) { }

}
