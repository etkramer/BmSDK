#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MPawnPlayerBatgirlBase<br/>
/// (size = 10308)
/// (flags = 0)
/// </summary>
public partial class MPawnPlayerBatgirlBase : BmSDK.BmGame.RPawnPlayerBmBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MPawnPlayerBatgirlBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MPawnPlayerBatgirlBase() { }

    /// <summary>
    /// Constructs a new MPawnPlayerBatgirlBase
    /// </summary>
    public MPawnPlayerBatgirlBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MPawnPlayerBatgirlBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MPawnPlayerBatgirlBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerBatgirlBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerBatgirlBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerBatgirlBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerBatgirlBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerBatgirlBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerBatgirlBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerBatgirlBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe void PostBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MPawnPlayerBatgirlBase.PostBeginPlay", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FixIncorrectShimmyNotify
    /// </summary>
    public unsafe void FixIncorrectShimmyNotify(BmSDK.Engine.AnimSet VantageAnimSet, BmSDK.FName AnimName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MPawnPlayerBatgirlBase.FixIncorrectShimmyNotify", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VantageAnimSet, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateThugsDefeatedDuringScareHack
    /// </summary>
    public unsafe void UpdateThugsDefeatedDuringScareHack()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MPawnPlayerBatgirlBase.UpdateThugsDefeatedDuringScareHack", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateThugsDefeatedDuringHacking
    /// </summary>
    public unsafe void UpdateThugsDefeatedDuringHacking()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MPawnPlayerBatgirlBase.UpdateThugsDefeatedDuringHacking", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DelayedRestartLocalLight
    /// </summary>
    public unsafe void DelayedRestartLocalLight()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MPawnPlayerBatgirlBase.DelayedRestartLocalLight", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: LocalLightReactivationDelay
    /// </summary>
    public unsafe void LocalLightReactivationDelay(float TimerDelay)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MPawnPlayerBatgirlBase.LocalLightReactivationDelay", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimerDelay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ForceLocalLightChange
    /// </summary>
    public unsafe void ForceLocalLightChange(bool bOn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MPawnPlayerBatgirlBase.ForceLocalLightChange", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateCollectableProgression
    /// </summary>
    public unsafe void UpdateCollectableProgression()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MPawnPlayerBatgirlBase.UpdateCollectableProgression", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetRemaningCollectables
    /// </summary>
    public unsafe void GetRemaningCollectables(out int NbBalloon, out int NbTheeth, out int NbJITB)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MPawnPlayerBatgirlBase.GetRemaningCollectables", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        NbBalloon = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
        NbTheeth = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
        NbJITB = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
        return;
    }

    /// <summary>
    /// Function: GetNumberCollectables
    /// </summary>
    public unsafe void GetNumberCollectables(out int NbBalloon, out int NbTheeth, out int NbJITB)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MPawnPlayerBatgirlBase.GetNumberCollectables", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        NbBalloon = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
        NbTheeth = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
        NbJITB = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
        return;
    }

    /// <summary>
    /// Function: NotifyKilledForTannoy
    /// </summary>
    public unsafe void NotifyKilledForTannoy(BmSDK.Engine.Pawn KilledPawn, BmSDK.BmGame.RBMRoomAIState RoomState)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MPawnPlayerBatgirlBase.NotifyKilledForTannoy", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KilledPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RoomState, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NotifyAfterRescue
    /// </summary>
    public unsafe void NotifyAfterRescue()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MPawnPlayerBatgirlBase.NotifyAfterRescue", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayHackInDangerAreaBarks
    /// </summary>
    public unsafe void PlayHackInDangerAreaBarks()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MPawnPlayerBatgirlBase.PlayHackInDangerAreaBarks", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayBombHackBarks
    /// </summary>
    public unsafe void PlayBombHackBarks(bool havePlayedIntro)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MPawnPlayerBatgirlBase.PlayBombHackBarks", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(havePlayedIntro, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsScareTakedown
    /// </summary>
    public unsafe bool IsScareTakedown(BmSDK.BmGame.RGameInfo.EStealthTakeDownStages Type)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MPawnPlayerBatgirlBase.IsScareTakedown", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: OverrideTakedownTarget
    /// </summary>
    public unsafe void OverrideTakedownTarget()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MPawnPlayerBatgirlBase.OverrideTakedownTarget", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OverrideTakedown
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EStealthTakeDownStages OverrideTakedown(BmSDK.FName StateName, BmSDK.BmGame.RPawnPlayer.FPlayerTakedownInfo Info, BmSDK.BmGame.RPawnVillain Victim, BmSDK.BmGame.RPawnVillain Victim2)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MPawnPlayerBatgirlBase.OverrideTakedown", true);
        byte* paramsPtr = stackalloc byte[53];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StateName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Info, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Victim, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Victim2, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EStealthTakeDownStages>(paramsPtr + 52);
    }

    /// <summary>
    /// Function: SetSwingChuteSpecialMove
    /// </summary>
    public unsafe void SetSwingChuteSpecialMove(out BmSDK.BmGame.RSpecialMoveConfig SwingMove, out BmSDK.BmGame.RSpecialMoveConfig GlideMove, out BmSDK.BmGame.RSpecialMoveConfig CrouchInMove, out BmSDK.BmGame.RSpecialMoveConfig RollOutOfChute)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MPawnPlayerBatgirlBase.SetSwingChuteSpecialMove", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        SwingMove = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(paramsPtr + 0);
        GlideMove = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(paramsPtr + 8);
        CrouchInMove = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(paramsPtr + 16);
        RollOutOfChute = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(paramsPtr + 24);
        return;
    }

    /// <summary>
    /// Function: SetLadderSpecialMove
    /// </summary>
    public unsafe void SetLadderSpecialMove(out BmSDK.BmGame.RSpecialMoveConfig BatmanClimbRunMove, out BmSDK.BmGame.RSpecialMoveConfig BatmanClimbStandMove, out BmSDK.BmGame.RSpecialMoveConfig BatmanGrateMove)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MPawnPlayerBatgirlBase.SetLadderSpecialMove", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BatmanClimbRunMove = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(paramsPtr + 0);
        BatmanClimbStandMove = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(paramsPtr + 8);
        BatmanGrateMove = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(paramsPtr + 16);
        return;
    }

    /// <summary>
    /// Function: HideStaff
    /// </summary>
    public unsafe void HideStaff()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MPawnPlayerBatgirlBase.HideStaff", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SelectDeathTip_BG
    /// </summary>
    public unsafe BmSDK.FString SelectDeathTip_BG(BmSDK.Engine.Controller Killer, BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MPawnPlayerBatgirlBase.SelectDeathTip_BG", true);
        byte* paramsPtr = stackalloc byte[116];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 28);
    }

    /// <summary>
    /// Function: SelectDeathMovie_BG
    /// </summary>
    public unsafe BmSDK.FString SelectDeathMovie_BG(BmSDK.Engine.Controller Killer, BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MPawnPlayerBatgirlBase.SelectDeathMovie_BG", true);
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 28);
    }

    /// <summary>
    /// Function: Died
    /// </summary>
    public unsafe bool Died(BmSDK.Engine.Controller Killer, BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MPawnPlayerBatgirlBase.Died", true);
        byte* paramsPtr = stackalloc byte[76];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 28);
    }

    /// <summary>
    /// ObjectProperty: PlayerCounterAnimset_JokerKnife
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PlayerCounterAnimset_JokerKnife
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 10252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10252); }
    }

    /// <summary>
    /// ObjectProperty: VillainCounterAnimset_JokerKnife
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VillainCounterAnimset_JokerKnife
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 10260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10260); }
    }

    /// <summary>
    /// ObjectProperty: BatgirlHackingGadget
    /// </summary>
    public unsafe BmSDK.BmGame.MHackingGadgetBase BatgirlHackingGadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MHackingGadgetBase>(Ptr + 10268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10268); }
    }

    /// <summary>
    /// BoolProperty: bDebugBatgirlAttractHackVisibility
    /// </summary>
    public unsafe bool bDebugBatgirlAttractHackVisibility
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10276) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10276); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10276); }
    }

    /// <summary>
    /// BoolProperty: bScareModeOn
    /// </summary>
    public unsafe bool bScareModeOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10276) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10276); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10276); }
    }

    /// <summary>
    /// BoolProperty: bBlindModeOn
    /// </summary>
    public unsafe bool bBlindModeOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10276) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10276); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10276); }
    }

    /// <summary>
    /// IntProperty: MaxBalloon
    /// </summary>
    public unsafe int MaxBalloon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10280); }
    }

    /// <summary>
    /// IntProperty: MaxTheeth
    /// </summary>
    public unsafe int MaxTheeth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10284); }
    }

    /// <summary>
    /// IntProperty: MaxJITB
    /// </summary>
    public unsafe int MaxJITB
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10288); }
    }

    /// <summary>
    /// IntProperty: Achievement_Scared_ThugDefeated_Amount_Needed
    /// </summary>
    public unsafe int Achievement_Scared_ThugDefeated_Amount_Needed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10292); }
    }

    /// <summary>
    /// IntProperty: Achievement_Scared_ThugsDefeated
    /// </summary>
    public unsafe int Achievement_Scared_ThugsDefeated
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10296); }
    }

    /// <summary>
    /// IntProperty: Achievement_ThugDefeated_DuringHack_Amount_Needed
    /// </summary>
    public unsafe int Achievement_ThugDefeated_DuringHack_Amount_Needed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10300); }
    }

    /// <summary>
    /// IntProperty: Achievement_ThugDefeated_DuringHack
    /// </summary>
    public unsafe int Achievement_ThugDefeated_DuringHack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10304); }
    }
}
