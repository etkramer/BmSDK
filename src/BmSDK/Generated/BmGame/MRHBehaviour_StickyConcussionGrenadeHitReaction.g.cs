#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MRHBehaviour_StickyConcussionGrenadeHitReaction<br/>
/// (size = 912)
/// (flags = 0)
/// </summary>
public partial class MRHBehaviour_StickyConcussionGrenadeHitReaction : BmSDK.BmGame.RBMBehaviour_HitReaction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MRHBehaviour_StickyConcussionGrenadeHitReaction", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MRHBehaviour_StickyConcussionGrenadeHitReaction() { }

    /// <summary>
    /// Constructs a new MRHBehaviour_StickyConcussionGrenadeHitReaction
    /// </summary>
    public MRHBehaviour_StickyConcussionGrenadeHitReaction(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MRHBehaviour_StickyConcussionGrenadeHitReaction Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MRHBehaviour_StickyConcussionGrenadeHitReaction(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: ExitStickyConcussionGrenadeHitReaction
    /// </summary>
    public unsafe void ExitStickyConcussionGrenadeHitReaction()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MRHBehaviour_StickyConcussionGrenadeHitReaction.ExitStickyConcussionGrenadeHitReaction", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ResetStunDuration
    /// </summary>
    public unsafe void ResetStunDuration()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MRHBehaviour_StickyConcussionGrenadeHitReaction.ResetStunDuration", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Initialise
    /// </summary>
    public unsafe void Initialise(BmSDK.BmGame.RPawnCombat.FDamageInfo NewDmgInfo, bool bNewInterruptedHitReaction = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MRHBehaviour_StickyConcussionGrenadeHitReaction.Initialise", true);
        byte* paramsPtr = stackalloc byte[252];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewDmgInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewInterruptedHitReaction, paramsPtr + 248);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AwareOfPlayer
    /// </summary>
    public unsafe bool AwareOfPlayer(BmSDK.Engine.Actor Player, BmSDK.Class dmgType = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MRHBehaviour_StickyConcussionGrenadeHitReaction.AwareOfPlayer", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// FloatProperty: OriginalStunTime
    /// </summary>
    public unsafe float OriginalStunTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }
}
