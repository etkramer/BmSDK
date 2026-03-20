#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqEvent_StartBangOnDoor<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqEvent_StartBangOnDoor : BmSDK.BmGame.RBMSeqEvent_BehaviourRoot, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqEvent_StartBangOnDoor", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvent_StartBangOnDoor() { }

    /// <summary>
    /// Constructs a new RSeqEvent_StartBangOnDoor
    /// </summary>
    public RSeqEvent_StartBangOnDoor(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvent_StartBangOnDoor Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvent_StartBangOnDoor(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: AECSub
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_LockedInRoot AECSub
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_LockedInRoot>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }
}
