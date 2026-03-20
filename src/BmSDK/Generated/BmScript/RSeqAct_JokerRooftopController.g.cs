#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_JokerRooftopController<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqAct_JokerRooftopController : BmSDK.BmGame.RSeqAct_JokerRooftopControllerBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_JokerRooftopController", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_JokerRooftopController() { }

    /// <summary>
    /// Constructs a new RSeqAct_JokerRooftopController
    /// </summary>
    public RSeqAct_JokerRooftopController(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_JokerRooftopController Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_JokerRooftopController(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: CurrentSideStorySelectedLine
    /// </summary>
    public unsafe int CurrentSideStorySelectedLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }
}
