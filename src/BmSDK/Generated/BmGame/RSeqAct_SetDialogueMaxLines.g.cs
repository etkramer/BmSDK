#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_SetDialogueMaxLines<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqAct_SetDialogueMaxLines : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_SetDialogueMaxLines", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_SetDialogueMaxLines() { }

    /// <summary>
    /// Constructs a new RSeqAct_SetDialogueMaxLines
    /// </summary>
    public RSeqAct_SetDialogueMaxLines(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_SetDialogueMaxLines Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_SetDialogueMaxLines(nint ptr) : base(ptr) { }

}
