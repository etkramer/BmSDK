#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqEvent_HelicopterDialogueTrigger<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqEvent_HelicopterDialogueTrigger : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqEvent_HelicopterDialogueTrigger", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvent_HelicopterDialogueTrigger() { }

    /// <summary>
    /// Constructs a new RSeqEvent_HelicopterDialogueTrigger
    /// </summary>
    public RSeqEvent_HelicopterDialogueTrigger(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvent_HelicopterDialogueTrigger Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvent_HelicopterDialogueTrigger(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqEvent_HelicopterDialogueTrigger.GetObjClassVersion", true);
        byte* paramsPtr = stackalloc byte[64];
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
    /// Enum: HeliDialogue
    /// </summary>
    public enum HeliDialogue
    {
        HD_BatmanSeen = 0,
        HD_BatmanCombatSeen = 1,
        HD_BatmanCombatFinished = 2,
        HD_BatmanCombatRunAway = 3,
        HD_BatmanOutOfSight = 4,
        HD_BatmanLost = 5,
        HD_BatmanKilled = 6,
        HD_BatmanShootingAt = 7,
        HD_BatmanMissileLocked = 8,
        HD_BatmanMissileFired = 9,
        HD_BatmanMissileHit = 10,
        HD_BatmanMissileMissed = 11,
        HD_BatmanSeenFirstTime = 12,
        HD_BatmanReacquired = 13,
        HD_BatmanGrapplesAboard = 14,
        HD_HitByRec = 15,
        HD_RecoversFromRec = 16,
        HD_PassiveHelicopterMadeAggro = 17,
        HD_HelicopterWeaponJammed = 18,
        HD_HelicopterWeaponRepaired = 19,
        HD_MAX = 20,
    }
}
