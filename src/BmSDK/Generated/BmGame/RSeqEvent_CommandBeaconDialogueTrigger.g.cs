#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqEvent_CommandBeaconDialogueTrigger<br/>
/// (size = 384)
/// (flags = 0)
/// </summary>
public partial class RSeqEvent_CommandBeaconDialogueTrigger : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqEvent_CommandBeaconDialogueTrigger", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvent_CommandBeaconDialogueTrigger() { }

    /// <summary>
    /// Constructs a new RSeqEvent_CommandBeaconDialogueTrigger
    /// </summary>
    public RSeqEvent_CommandBeaconDialogueTrigger(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvent_CommandBeaconDialogueTrigger Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvent_CommandBeaconDialogueTrigger(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSeqEvent_CommandBeaconDialogueTrigger.GetObjClassVersion", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// BoolProperty: DialogueEnabled
    /// </summary>
    public unsafe bool DialogueEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 380); }
    }

    /// <summary>
    /// Enum: CommandBeaconDialogue
    /// </summary>
    public enum CommandBeaconDialogue
    {
        eCBD_SecureArea = 0,
        eCBD_BatmobileDetected = 1,
        eCBD_BatmobileLost = 2,
        eCBD_InteractStarted = 3,
        eCBD_InteractDistanceWarning = 4,
        eCBD_InteractAbandoned = 5,
        eCBD_InteractComplete = 6,
        eCBD_TriggeredAttack = 7,
        eCBD_ExitedWinchRange = 8,
        eCBD_ReenteredWinchRange = 9,
        eCBD_MAX = 10,
    }
}
