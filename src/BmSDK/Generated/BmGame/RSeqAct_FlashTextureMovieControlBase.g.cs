#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_FlashTextureMovieControlBase<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqAct_FlashTextureMovieControlBase : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_FlashTextureMovieControlBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_FlashTextureMovieControlBase() { }

    /// <summary>
    /// Constructs a new RSeqAct_FlashTextureMovieControlBase
    /// </summary>
    public RSeqAct_FlashTextureMovieControlBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_FlashTextureMovieControlBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_FlashTextureMovieControlBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: AtEndClose
    /// </summary>
    public unsafe void AtEndClose()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSeqAct_FlashTextureMovieControlBase.AtEndClose", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }
}
