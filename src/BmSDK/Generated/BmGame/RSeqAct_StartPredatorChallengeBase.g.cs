#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RSeqAct_StartPredatorChallengeBase<br/>
/// (size = 236)
/// (flags = 8211)
/// </summary>
public partial class RSeqAct_StartPredatorChallengeBase : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_StartPredatorChallengeBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_StartPredatorChallengeBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_StartPredatorChallengeBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: ActionPerformed
    /// </summary>
    public unsafe virtual bool ActionPerformed(BmSDK.BmGame.RGameInfo.EGameAction NewGameAction)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSeqAct_StartPredatorChallengeBase.ActionPerformed", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGameAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetChallengeTime
    /// </summary>
    public unsafe virtual float GetChallengeTime()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSeqAct_StartPredatorChallengeBase.GetChallengeTime", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// ObjectProperty: ChallengeVIP
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain ChallengeVIP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// ArrayProperty: PunchedEnemies
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnVillain> PunchedEnemies
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnVillain>>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }
}
