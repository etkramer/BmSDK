#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_CompletedSilentKnightWithKnockoutSmashes<br/>
/// (size = 352)
/// (flags = 8210)
/// </summary>
public partial class RSeqAct_CompletedSilentKnightWithKnockoutSmashes : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_CompletedSilentKnightWithKnockoutSmashes", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_CompletedSilentKnightWithKnockoutSmashes() { }

    /// <summary>
    /// Constructs a new RSeqAct_CompletedSilentKnightWithKnockoutSmashes
    /// </summary>
    public RSeqAct_CompletedSilentKnightWithKnockoutSmashes(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_CompletedSilentKnightWithKnockoutSmashes Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_CompletedSilentKnightWithKnockoutSmashes(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: Activated
    /// </summary>
    public unsafe override void Activated()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSeqAct_CompletedSilentKnightWithKnockoutSmashes.Activated", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }
}
