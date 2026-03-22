#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_PDLC1_KickToPressStartIfNoStory<br/>
/// (size = 204)
/// (flags = 8210)
/// </summary>
public partial class RSeqAct_PDLC1_KickToPressStartIfNoStory : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_PDLC1_KickToPressStartIfNoStory", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_PDLC1_KickToPressStartIfNoStory() { }

    /// <summary>
    /// Constructs a new RSeqAct_PDLC1_KickToPressStartIfNoStory
    /// </summary>
    public RSeqAct_PDLC1_KickToPressStartIfNoStory(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_PDLC1_KickToPressStartIfNoStory Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_PDLC1_KickToPressStartIfNoStory(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: Activated
    /// </summary>
    public unsafe override void Activated()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_PDLC1_KickToPressStartIfNoStory.Activated", true);
        byte* paramsPtr = stackalloc byte[5];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }
}
