#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_OverrideApexClothTeleport<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqAct_OverrideApexClothTeleport : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_OverrideApexClothTeleport", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_OverrideApexClothTeleport() { }

    /// <summary>
    /// Constructs a new RSeqAct_OverrideApexClothTeleport
    /// </summary>
    public RSeqAct_OverrideApexClothTeleport(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_OverrideApexClothTeleport Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_OverrideApexClothTeleport(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: ActorsToBeTeleported
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> ActorsToBeTeleported
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ByteProperty: TeleportMode
    /// </summary>
    public unsafe BmSDK.Engine.Actor.EApexClothTeleportMode TeleportMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor.EApexClothTeleportMode>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }
}
