#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_EnableSurveillance<br/>
/// (size = 204)
/// (flags = 134226066)
/// </summary>
public partial class RSeqAct_EnableSurveillance : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_EnableSurveillance", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_EnableSurveillance() { }

    /// <summary>
    /// Constructs a new RSeqAct_EnableSurveillance
    /// </summary>
    public RSeqAct_EnableSurveillance(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_EnableSurveillance Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_EnableSurveillance(nint ptr) : base(ptr) { }

}
