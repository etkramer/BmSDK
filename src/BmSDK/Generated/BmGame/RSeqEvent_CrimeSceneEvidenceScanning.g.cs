#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqEvent_CrimeSceneEvidenceScanning<br/>
/// (size = 380)
/// (flags = 0)
/// </summary>
public partial class RSeqEvent_CrimeSceneEvidenceScanning : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqEvent_CrimeSceneEvidenceScanning", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvent_CrimeSceneEvidenceScanning() { }

    /// <summary>
    /// Constructs a new RSeqEvent_CrimeSceneEvidenceScanning
    /// </summary>
    public RSeqEvent_CrimeSceneEvidenceScanning(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvent_CrimeSceneEvidenceScanning Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvent_CrimeSceneEvidenceScanning(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSeqEvent_CrimeSceneEvidenceScanning.GetObjClassVersion", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Enum: CrimeSceneEvidenceEvent
    /// </summary>
    public enum CrimeSceneEvidenceEvent
    {
        CSEE_ScanningBegins = 0,
        CSEE_ScanningAborted = 1,
        CSEE_ScanningComplete = 2,
        CSEE_EvidenceFirstSpotted = 3,
        CSEE_EvidenceRescanned = 4,
        CSEE_EvidenceResetScan = 5,
        CSEE_MAX = 6,
    }
}
