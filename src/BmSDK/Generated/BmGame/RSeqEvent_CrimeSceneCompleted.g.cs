#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqEvent_CrimeSceneCompleted<br/>
/// (size = 392)
/// (flags = 18)
/// </summary>
public partial class RSeqEvent_CrimeSceneCompleted : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqEvent_CrimeSceneCompleted", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvent_CrimeSceneCompleted() { }

    /// <summary>
    /// Constructs a new RSeqEvent_CrimeSceneCompleted
    /// </summary>
    public RSeqEvent_CrimeSceneCompleted(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvent_CrimeSceneCompleted Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvent_CrimeSceneCompleted(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSeqEvent_CrimeSceneCompleted.GetObjClassVersion", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: EvidenceTotalChanged
    /// </summary>
    public unsafe virtual void EvidenceTotalChanged(int TotalCollected, int TotalInCrimeScene)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSeqEvent_CrimeSceneCompleted.EvidenceTotalChanged", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TotalCollected, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TotalInCrimeScene, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: CrimeSceneCompletionLevel
    /// </summary>
    public enum CrimeSceneCompletionLevel
    {
        CSCL_FullyComplete = 0,
        CSCL_PercentageComplete = 1,
        CSCL_NumberComplete = 2,
        CSCL_MAX = 3,
    }

    /// <summary>
    /// FloatProperty: PartialCompletionPercentage
    /// </summary>
    public unsafe float PartialCompletionPercentage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// IntProperty: PartialCompletionNumber
    /// </summary>
    public unsafe int PartialCompletionNumber
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// IntProperty: LastTotal
    /// </summary>
    public unsafe int LastTotal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }
}
