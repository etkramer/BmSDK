#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_AssignHostageToSeePlayerVol<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_AssignHostageToSeePlayerVol : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_AssignHostageToSeePlayerVol", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_AssignHostageToSeePlayerVol() { }

    /// <summary>
    /// Constructs a new RSeqAct_AssignHostageToSeePlayerVol
    /// </summary>
    public RSeqAct_AssignHostageToSeePlayerVol(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_AssignHostageToSeePlayerVol Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_AssignHostageToSeePlayerVol(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: SeePlayerVol
    /// </summary>
    public unsafe BmSDK.BmGame.RHostageSeesPlayerVolume SeePlayerVol
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHostageSeesPlayerVolume>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ObjectProperty: HostagePawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnFriendly HostagePawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnFriendly>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }
}
