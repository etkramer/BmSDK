#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_StreamoutUnwantedTextures<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqAct_StreamoutUnwantedTextures : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_StreamoutUnwantedTextures", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_StreamoutUnwantedTextures() { }

    /// <summary>
    /// Constructs a new RSeqAct_StreamoutUnwantedTextures
    /// </summary>
    public RSeqAct_StreamoutUnwantedTextures(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_StreamoutUnwantedTextures Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_StreamoutUnwantedTextures(nint ptr) : base(ptr) { }

}
