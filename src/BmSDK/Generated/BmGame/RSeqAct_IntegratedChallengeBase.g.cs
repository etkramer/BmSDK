#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RSeqAct_IntegratedChallengeBase<br/>
/// (size = 376)
/// (flags = 134226067)
/// </summary>
public partial class RSeqAct_IntegratedChallengeBase : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_IntegratedChallengeBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_IntegratedChallengeBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_IntegratedChallengeBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: TeleportPlayerToStartPoint
    /// </summary>
    public unsafe virtual void TeleportPlayerToStartPoint()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSeqAct_IntegratedChallengeBase.TeleportPlayerToStartPoint", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AdjustTime
    /// </summary>
    public unsafe virtual void AdjustTime(float fTime, bool bBonus)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSeqAct_IntegratedChallengeBase.AdjustTime", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBonus, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AdjustScore
    /// </summary>
    public unsafe virtual void AdjustScore(int nScore, bool bCheat = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSeqAct_IntegratedChallengeBase.AdjustScore", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nScore, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCheat, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StopTimer
    /// </summary>
    public unsafe virtual void StopTimer()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSeqAct_IntegratedChallengeBase.StopTimer", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartTimer
    /// </summary>
    public unsafe virtual void StartTimer()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSeqAct_IntegratedChallengeBase.StartTimer", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetState
    /// </summary>
    public unsafe virtual bool GetState(BmSDK.BmGame.RSeqAct_IntegratedChallengeBase.IntegratedChallengeState eState)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSeqAct_IntegratedChallengeBase.GetState", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(eState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Enum: IntegratedChallengeState
    /// </summary>
    public enum IntegratedChallengeState
    {
        ICS_PlayerInvulnerable = 0,
        ICS_OneHitKills = 1,
        ICS_RadarEnabled = 2,
        ICS_SatNavEnabled = 3,
        ICS_ArrowEnabled = 4,
        ICS_BatmobileDisabled = 5,
        ICS_LockedInBatmobile = 6,
        ICS_MAX = 7,
    }
}
