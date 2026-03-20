#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAnimNotify_AnimStopSpeech<br/>
/// (flags = 0)
/// </summary>
public partial class RAnimNotify_AnimStopSpeech : BmSDK.BmGame.RAnimNotify_Script, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimNotify_AnimStopSpeech", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimNotify_AnimStopSpeech() { }

    /// <summary>
    /// Constructs a new RAnimNotify_AnimStopSpeech
    /// </summary>
    public RAnimNotify_AnimStopSpeech(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnimNotify_AnimStopSpeech Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimNotify_AnimStopSpeech(nint ptr) : base(ptr) { }

}
