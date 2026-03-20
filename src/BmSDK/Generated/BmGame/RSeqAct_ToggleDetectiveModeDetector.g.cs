#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_ToggleDetectiveModeDetector<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqAct_ToggleDetectiveModeDetector : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_ToggleDetectiveModeDetector", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_ToggleDetectiveModeDetector() { }

    /// <summary>
    /// Constructs a new RSeqAct_ToggleDetectiveModeDetector
    /// </summary>
    public RSeqAct_ToggleDetectiveModeDetector(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_ToggleDetectiveModeDetector Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_ToggleDetectiveModeDetector(nint ptr) : base(ptr) { }

    /// <summary>
    /// ComponentProperty: RoomState
    /// </summary>
    public unsafe BmSDK.BmGame.RBMRoomAIState RoomState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMRoomAIState>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }
}
