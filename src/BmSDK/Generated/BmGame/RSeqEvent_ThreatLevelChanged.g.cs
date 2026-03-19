#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqEvent_ThreatLevelChanged<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqEvent_ThreatLevelChanged : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqEvent_ThreatLevelChanged", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvent_ThreatLevelChanged() { }

    /// <summary>
    /// Constructs a new RSeqEvent_ThreatLevelChanged
    /// </summary>
    public RSeqEvent_ThreatLevelChanged(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvent_ThreatLevelChanged Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvent_ThreatLevelChanged(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: ThreatType
    /// </summary>
    public unsafe byte ThreatType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// ByteProperty: CityDistrict
    /// </summary>
    public unsafe byte CityDistrict
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 381); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 381); }
    }
}
