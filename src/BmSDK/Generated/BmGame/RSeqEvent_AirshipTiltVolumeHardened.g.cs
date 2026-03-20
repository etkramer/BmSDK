#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqEvent_AirshipTiltVolumeHardened<br/>
/// (size = 380)
/// (flags = 18)
/// </summary>
public partial class RSeqEvent_AirshipTiltVolumeHardened : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqEvent_AirshipTiltVolumeHardened", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvent_AirshipTiltVolumeHardened() { }

    /// <summary>
    /// Constructs a new RSeqEvent_AirshipTiltVolumeHardened
    /// </summary>
    public RSeqEvent_AirshipTiltVolumeHardened(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvent_AirshipTiltVolumeHardened Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvent_AirshipTiltVolumeHardened(nint ptr) : base(ptr) { }

}
