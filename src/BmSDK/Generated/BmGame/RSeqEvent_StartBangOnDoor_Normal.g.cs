#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqEvent_StartBangOnDoor_Normal<br/>
/// (size = 388)
/// (flags = 18)
/// </summary>
public partial class RSeqEvent_StartBangOnDoor_Normal : BmSDK.BmGame.RSeqEvent_StartBangOnDoor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqEvent_StartBangOnDoor_Normal", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvent_StartBangOnDoor_Normal() { }

    /// <summary>
    /// Constructs a new RSeqEvent_StartBangOnDoor_Normal
    /// </summary>
    public RSeqEvent_StartBangOnDoor_Normal(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvent_StartBangOnDoor_Normal Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvent_StartBangOnDoor_Normal(nint ptr) : base(ptr) { }

}
