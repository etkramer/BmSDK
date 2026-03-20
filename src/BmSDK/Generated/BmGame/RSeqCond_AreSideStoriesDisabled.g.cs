#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqCond_AreSideStoriesDisabled<br/>
/// (size = 324)
/// (flags = 18)
/// </summary>
public partial class RSeqCond_AreSideStoriesDisabled : BmSDK.Engine.SequenceCondition, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqCond_AreSideStoriesDisabled", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqCond_AreSideStoriesDisabled() { }

    /// <summary>
    /// Constructs a new RSeqCond_AreSideStoriesDisabled
    /// </summary>
    public RSeqCond_AreSideStoriesDisabled(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqCond_AreSideStoriesDisabled Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqCond_AreSideStoriesDisabled(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: Activated
    /// </summary>
    public unsafe override void Activated()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSeqCond_AreSideStoriesDisabled.Activated", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }
}
