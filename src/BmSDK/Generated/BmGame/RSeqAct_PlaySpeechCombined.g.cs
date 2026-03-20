#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_PlaySpeechCombined<br/>
/// (size = 828)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_PlaySpeechCombined : BmSDK.BmGame.RSeqAct_PlaySpeechBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_PlaySpeechCombined", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_PlaySpeechCombined() { }

    /// <summary>
    /// Constructs a new RSeqAct_PlaySpeechCombined
    /// </summary>
    public RSeqAct_PlaySpeechCombined(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_PlaySpeechCombined Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_PlaySpeechCombined(nint ptr) : base(ptr) { }

}
