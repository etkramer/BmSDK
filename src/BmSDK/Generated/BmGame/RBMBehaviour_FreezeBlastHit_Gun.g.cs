#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_FreezeBlastHit_Gun<br/>
/// (flags = 0)
/// </summary>
public partial class RBMBehaviour_FreezeBlastHit_Gun : BmSDK.BmGame.RBMBehaviour_FreezeBlastHit, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_FreezeBlastHit_Gun", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_FreezeBlastHit_Gun() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_FreezeBlastHit_Gun
    /// </summary>
    public RBMBehaviour_FreezeBlastHit_Gun(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_FreezeBlastHit_Gun Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_FreezeBlastHit_Gun(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: PlayerAlert
    /// </summary>
    public unsafe BmSDK.BmGame.AlertInstance PlayerAlert
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.AlertInstance>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }

    /// <summary>
    /// FloatProperty: NotShootableTime
    /// </summary>
    public unsafe float NotShootableTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// StructProperty: DiscoveryAnimID
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId DiscoveryAnimID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }
}
