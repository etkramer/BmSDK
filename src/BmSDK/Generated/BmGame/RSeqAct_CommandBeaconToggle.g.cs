#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_CommandBeaconToggle<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_CommandBeaconToggle : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_CommandBeaconToggle", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_CommandBeaconToggle() { }

    /// <summary>
    /// Constructs a new RSeqAct_CommandBeaconToggle
    /// </summary>
    public RSeqAct_CommandBeaconToggle(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_CommandBeaconToggle Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_CommandBeaconToggle(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: beacon
    /// </summary>
    public unsafe BmSDK.BmGame.RCommandBeaconBase beacon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCommandBeaconBase>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }
}
