#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPlayerControllerCombat<br/>
/// (flags = 0)
/// </summary>
public partial class RPlayerControllerCombat : BmSDK.BmGame.RPlayerController, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPlayerControllerCombat", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPlayerControllerCombat() { }

    /// <summary>
    /// Constructs a new RPlayerControllerCombat
    /// </summary>
    public RPlayerControllerCombat(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPlayerControllerCombat Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPlayerControllerCombat(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPlayerControllerCombat>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPlayerControllerCombat>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPlayerControllerCombat>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPlayerControllerCombat>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPlayerControllerCombat>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPlayerControllerCombat>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPlayerControllerCombat>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: PreRestart
    /// </summary>
    public unsafe void PreRestart()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.PreRestart", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CantSwitchPlayer
    /// </summary>
    public unsafe bool CantSwitchPlayer()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CantSwitchPlayer", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: BeatdownFromFloorPickup
    /// </summary>
    public unsafe void BeatdownFromFloorPickup()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.BeatdownFromFloorPickup", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpgradeQuickGadgetToSuperGadget
    /// </summary>
    public unsafe void UpgradeQuickGadgetToSuperGadget()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.UpgradeQuickGadgetToSuperGadget", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DontQuickThrowBatarang
    /// </summary>
    public unsafe void DontQuickThrowBatarang()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.DontQuickThrowBatarang", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ReEnableCombat
    /// </summary>
    public unsafe void ReEnableCombat()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ReEnableCombat", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DisableCombat
    /// </summary>
    public unsafe void DisableCombat(float Duration = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.DisableCombat", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ForceDodgeProjectile
    /// </summary>
    public unsafe bool ForceDodgeProjectile()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ForceDodgeProjectile", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SuperGadgetTimer
    /// </summary>
    public unsafe void SuperGadgetTimer()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SuperGadgetTimer", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: KeyboardSpecialGadgetComboTimer
    /// </summary>
    public unsafe void KeyboardSpecialGadgetComboTimer()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.KeyboardSpecialGadgetComboTimer", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ReleaseQuickGadgetY
    /// </summary>
    public unsafe void ReleaseQuickGadgetY()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ReleaseQuickGadgetY", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ReleaseQuickGadgetX
    /// </summary>
    public unsafe void ReleaseQuickGadgetX()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ReleaseQuickGadgetX", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ReleaseQuickGadgetB
    /// </summary>
    public unsafe void ReleaseQuickGadgetB()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ReleaseQuickGadgetB", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ReleaseQuickGadgetA
    /// </summary>
    public unsafe void ReleaseQuickGadgetA()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ReleaseQuickGadgetA", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: QuickGadgetB
    /// </summary>
    public unsafe void QuickGadgetB()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.QuickGadgetB", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: QuickGadgetX
    /// </summary>
    public unsafe void QuickGadgetX()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.QuickGadgetX", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: QuickGadgetY
    /// </summary>
    public unsafe void QuickGadgetY()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.QuickGadgetY", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: QuickGadgetA
    /// </summary>
    public unsafe void QuickGadgetA()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.QuickGadgetA", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ServerDamagePawn
    /// </summary>
    public unsafe void ServerDamagePawn(BmSDK.BmGame.RPawnVillain Target, BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ServerDamagePawn", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ServerDoHitPawn
    /// </summary>
    public unsafe void ServerDoHitPawn(BmSDK.BmGame.RPawnCombat DamageReceiver, float DmgAmount)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ServerDoHitPawn", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageReceiver, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgAmount, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UnRegisterComboValueReachedAction
    /// </summary>
    public unsafe void UnRegisterComboValueReachedAction(BmSDK.BmGame.RSeqAct_ComboValueReached OldAction)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.UnRegisterComboValueReachedAction", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RegisterComboValueReachedAction
    /// </summary>
    public unsafe void RegisterComboValueReachedAction(BmSDK.BmGame.RSeqAct_ComboValueReached NewAction)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.RegisterComboValueReachedAction", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: EnableCapeStun
    /// </summary>
    public unsafe void EnableCapeStun()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.EnableCapeStun", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DisableCapeStun
    /// </summary>
    public unsafe void DisableCapeStun()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.DisableCapeStun", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanStagger
    /// </summary>
    public unsafe bool CanStagger()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CanStagger", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: MakeBatmanLookAtEnemy
    /// </summary>
    public unsafe bool MakeBatmanLookAtEnemy(bool bReset = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.MakeBatmanLookAtEnemy", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bReset, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: ReadyGadgetOrCounterReleased
    /// </summary>
    public unsafe void ReadyGadgetOrCounterReleased()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ReadyGadgetOrCounterReleased", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: MouseReadyGadget
    /// </summary>
    public unsafe void MouseReadyGadget()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.MouseReadyGadget", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ReadyGadgetOrCounterPressed
    /// </summary>
    public unsafe void ReadyGadgetOrCounterPressed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ReadyGadgetOrCounterPressed", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GadgetOrQuickStrikePressed
    /// </summary>
    public unsafe void GadgetOrQuickStrikePressed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GadgetOrQuickStrikePressed", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GrappleOrStrikeGadgetPressed
    /// </summary>
    public unsafe void GrappleOrStrikeGadgetPressed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GrappleOrStrikeGadgetPressed", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerFlashBangMultiHitEvents
    /// </summary>
    public unsafe void TriggerFlashBangMultiHitEvents()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TriggerFlashBangMultiHitEvents", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RegisterGameAction
    /// </summary>
    public unsafe void RegisterGameAction(BmSDK.BmGame.RGameInfo.EGameAction Action, BmSDK.Engine.Actor XPTarget = default, int XPAmount = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.RegisterGameAction", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPTarget, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPAmount, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe void Destroyed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.Destroyed", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayImpactRumble
    /// </summary>
    public unsafe void PlayImpactRumble(float LeftAmp = default, float RightAmp = default, float Duration = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.PlayImpactRumble", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LeftAmp, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RightAmp, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NavManWTF
    /// </summary>
    public unsafe void NavManWTF()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.NavManWTF", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AIWTF
    /// </summary>
    public unsafe void AIWTF()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.AIWTF", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TutorialWTF
    /// </summary>
    public unsafe void TutorialWTF()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TutorialWTF", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PairedAnimWTF
    /// </summary>
    public unsafe void PairedAnimWTF()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.PairedAnimWTF", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StrikeWTF
    /// </summary>
    public unsafe void StrikeWTF()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.StrikeWTF", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CombatWTF
    /// </summary>
    public unsafe void CombatWTF()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CombatWTF", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SuppressVenomCamera
    /// </summary>
    public unsafe bool SuppressVenomCamera()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SuppressVenomCamera", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SuppressCombatCamera
    /// </summary>
    public unsafe bool SuppressCombatCamera()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SuppressCombatCamera", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ShouldGoSlowMoOnNextHit
    /// </summary>
    public unsafe bool ShouldGoSlowMoOnNextHit(int ComboInc)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ShouldGoSlowMoOnNextHit", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ComboInc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: UpdateCombatCameraSuppression
    /// </summary>
    public unsafe void UpdateCombatCameraSuppression()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.UpdateCombatCameraSuppression", true);
        byte* paramsPtr = stackalloc byte[64];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: CombatTick
    /// </summary>
    public unsafe void CombatTick(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CombatTick", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateCombatHUD
    /// </summary>
    public unsafe void UpdateCombatHUD()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.UpdateCombatHUD", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DestroyFixedCombatCam
    /// </summary>
    public unsafe void DestroyFixedCombatCam()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.DestroyFixedCombatCam", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateFixedCamera
    /// </summary>
    public unsafe void UpdateFixedCamera(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.UpdateFixedCamera", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: MoveFixedCamRotationTowardsPlayer
    /// </summary>
    public unsafe void MoveFixedCamRotationTowardsPlayer(float YawFollowPercent)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.MoveFixedCamRotationTowardsPlayer", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(YawFollowPercent, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetFixedCamRotation
    /// </summary>
    public unsafe BmSDK.Rotator GetFixedCamRotation(BmSDK.Rotator baseRot, BmSDK.Rotator RotRange, float MinDist, float MaxDist)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetFixedCamRotation", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(baseRot, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RotRange, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinDist, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxDist, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 32);
    }

    /// <summary>
    /// Function: GetFixedCamLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 GetFixedCamLocation(System.Numerics.Vector3 BaseLoc, System.Numerics.Vector3 LocRange, float MinDist, float MaxDist)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetFixedCamLocation", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BaseLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocRange, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinDist, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxDist, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 32);
    }

    /// <summary>
    /// Function: GetFixedCamFOV
    /// </summary>
    public unsafe float GetFixedCamFOV(float BaseFOV, float FovRange, float MinDist, float MaxDist)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetFixedCamFOV", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BaseFOV, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FovRange, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinDist, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxDist, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: SpawnFinishedCombatMove
    /// </summary>
    public unsafe void SpawnFinishedCombatMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SpawnFinishedCombatMove", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: QueueFinishedCombatMove
    /// </summary>
    public unsafe void QueueFinishedCombatMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.QueueFinishedCombatMove", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetComboOnHUD
    /// </summary>
    public unsafe void SetComboOnHUD()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SetComboOnHUD", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateComboOnHUD
    /// </summary>
    public unsafe void UpdateComboOnHUD()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.UpdateComboOnHUD", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ActualClearLastStrikeDir
    /// </summary>
    public unsafe void ActualClearLastStrikeDir()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ActualClearLastStrikeDir", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearLastStrikeDir
    /// </summary>
    public unsafe void ClearLastStrikeDir()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ClearLastStrikeDir", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetLastStrikeDir
    /// </summary>
    public unsafe void SetLastStrikeDir(System.Numerics.Vector3 StrikeDir)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SetLastStrikeDir", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrikeDir, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsTargetted
    /// </summary>
    public unsafe bool IsTargetted(BmSDK.BmGame.RPawnCombat IgnoreTargetter = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.IsTargetted", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IgnoreTargetter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: Untargetted
    /// </summary>
    public unsafe void Untargetted(BmSDK.BmGame.RPawnCombat Targetter)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.Untargetted", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Targetter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Targetted
    /// </summary>
    public unsafe void Targetted(BmSDK.BmGame.RPawnCombat Targetter)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.Targetted", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Targetter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Lasered
    /// </summary>
    public unsafe void Lasered()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.Lasered", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Zapped
    /// </summary>
    public unsafe void Zapped()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.Zapped", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Stunned
    /// </summary>
    public unsafe void Stunned(bool bDontPlaySfx = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.Stunned", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDontPlaySfx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CheckDodge
    /// </summary>
    public unsafe void CheckDodge(BmSDK.BmGame.RPawnCombat Attacker)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CheckDodge", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnRunningStun
    /// </summary>
    public unsafe void SpawnRunningStun()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SpawnRunningStun", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnRunningStrike
    /// </summary>
    public unsafe void SpawnRunningStrike()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SpawnRunningStrike", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsBatmobileTakedownReady
    /// </summary>
    public unsafe bool IsBatmobileTakedownReady()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.IsBatmobileTakedownReady", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsBatmobileTakedownAllowed
    /// </summary>
    public unsafe bool IsBatmobileTakedownAllowed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.IsBatmobileTakedownAllowed", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ShouldShowSpecialPrompt
    /// </summary>
    public unsafe bool ShouldShowSpecialPrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ShouldShowSpecialPrompt", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SpecialUnlocked
    /// </summary>
    public unsafe bool SpecialUnlocked()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SpecialUnlocked", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CanDoDualPlayTakedown
    /// </summary>
    public unsafe bool CanDoDualPlayTakedown()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CanDoDualPlayTakedown", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CanDoSecondaryGroupCombatMove
    /// </summary>
    public unsafe bool CanDoSecondaryGroupCombatMove(bool bDoComboCountCheck = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CanDoSecondaryGroupCombatMove", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoComboCountCheck, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: CanDoPrimaryGroupCombatMove
    /// </summary>
    public unsafe bool CanDoPrimaryGroupCombatMove(bool bDoComboCountCheck = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CanDoPrimaryGroupCombatMove", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoComboCountCheck, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: CanDoWeaponSnatch
    /// </summary>
    public unsafe bool CanDoWeaponSnatch(bool bDoComboCountCheck = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CanDoWeaponSnatch", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoComboCountCheck, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: CanDoWeaponDestroy
    /// </summary>
    public unsafe bool CanDoWeaponDestroy(bool bDoComboCountCheck = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CanDoWeaponDestroy", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoComboCountCheck, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: CanDoCombatTakedown
    /// </summary>
    public unsafe bool CanDoCombatTakedown(bool bDoComboCountCheck = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CanDoCombatTakedown", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoComboCountCheck, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: CanDoThrow
    /// </summary>
    public unsafe bool CanDoThrow()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CanDoThrow", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ServerSpawnFailMove
    /// </summary>
    public unsafe void ServerSpawnFailMove(BmSDK.FName FailAnim, bool bCanBecomeThrow, bool bCanBecomeTakedown, bool bCanBecomeFloorTakedown, BmSDK.FName FailCapeState, System.Numerics.Vector3 MoveDir)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ServerSpawnFailMove", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FailAnim, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanBecomeThrow, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanBecomeTakedown, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanBecomeFloorTakedown, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FailCapeState, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveDir, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ServerRequestComboTakedown
    /// </summary>
    public unsafe void ServerRequestComboTakedown(BmSDK.BmGame.RPawnVillain TargetPawn, BmSDK.BmGame.RPawnPlayerCombat.FTakedownInfo Info, float CollisionDist, System.Numerics.Vector3 Dir, float Dist, BmSDK.BmGame.RPawnPlayerCombat.ETakedownType takedownType, float HitTimeForward, float HitTimeBackward, bool FoundInValidDirection, bool InstantStart, System.Numerics.Vector3 AnimPos)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ServerRequestComboTakedown", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Info, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CollisionDist, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Dir, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Dist, paramsPtr + 72);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(takedownType, paramsPtr + 76);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitTimeForward, paramsPtr + 80);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitTimeBackward, paramsPtr + 84);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FoundInValidDirection, paramsPtr + 88);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstantStart, paramsPtr + 92);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPos, paramsPtr + 96);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnInterrogation
    /// </summary>
    public unsafe bool SpawnInterrogation(BmSDK.BmGame.RPawnVillain NewTarget)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SpawnInterrogation", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: TrySpawnDualComboTakedown
    /// </summary>
    public unsafe bool TrySpawnDualComboTakedown(bool bOverrideCurrentMove)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TrySpawnDualComboTakedown", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideCurrentMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: TrySpawnDualPlayClash
    /// </summary>
    public unsafe bool TrySpawnDualPlayClash(bool bOverrideCurrentMove = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TrySpawnDualPlayClash", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideCurrentMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: FindDualPlayClashTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain FindDualPlayClashTarget()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.FindDualPlayClashTarget", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SpawnTakedown
    /// </summary>
    public unsafe bool SpawnTakedown(bool bOverrideCurrentMove = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SpawnTakedown", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideCurrentMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: FindTakedownTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain FindTakedownTarget(BmSDK.Class dmgType = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.FindTakedownTarget", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: TryTakedown
    /// </summary>
    public unsafe bool TryTakedown()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TryTakedown", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsValidThrowTarget
    /// </summary>
    public unsafe bool IsValidThrowTarget(BmSDK.BmGame.RPawnVillain Target, System.Numerics.Vector3 MoveDir)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.IsValidThrowTarget", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveDir, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: TrySpawnWeaponSnatch
    /// </summary>
    public unsafe bool TrySpawnWeaponSnatch(bool bOverrideCurrentMove = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TrySpawnWeaponSnatch", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideCurrentMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: SpawnWeaponDestroy
    /// </summary>
    public unsafe bool SpawnWeaponDestroy(bool bOverrideCurrentMove = default, BmSDK.BmGame.RPawnVillain NewTarget = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SpawnWeaponDestroy", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideCurrentMove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: ServerRequestThrow
    /// </summary>
    public unsafe void ServerRequestThrow(BmSDK.BmGame.RPawnVillain Target, BmSDK.BmGame.RPawnPlayerCombat.FThrowInfo ThrowInfo, System.Numerics.Vector3 AnimPos, BmSDK.Rotator ThrowDir, bool bSetCapeState, bool bDirectThrow)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ServerRequestThrow", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowInfo, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPos, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowDir, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSetCapeState, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDirectThrow, paramsPtr + 68);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ServerRequestIntoThrow
    /// </summary>
    public unsafe void ServerRequestIntoThrow(BmSDK.BmGame.RPawnVillain Target, BmSDK.BmGame.RPawnCombat.TargetStrikeResponse TargetResponse, BmSDK.Rotator MoveDir, float TargetDist, System.Numerics.Vector3 AnimPos, float AnimRot)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ServerRequestIntoThrow", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetResponse, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveDir, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetDist, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPos, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimRot, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnThrow
    /// </summary>
    public unsafe bool SpawnThrow(bool bOverrideCurrentMove = default, BmSDK.BmGame.RPawnVillain NewTarget = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SpawnThrow", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideCurrentMove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: TryThrow
    /// </summary>
    public unsafe bool TryThrow()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TryThrow", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ServerRequestFloorTakedownSimulated
    /// </summary>
    public unsafe void ServerRequestFloorTakedownSimulated(BmSDK.BmGame.RPawnVillain TargetPawn, BmSDK.BmGame.RGameInfo.EGameAction ChallengeActionToTriggerIfSuccessful, float TargetDist, System.Numerics.Vector3 AnimPos, System.Numerics.Vector3 FacingDir)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ServerRequestFloorTakedownSimulated", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChallengeActionToTriggerIfSuccessful, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetDist, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPos, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FacingDir, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TryFloorTakedown
    /// </summary>
    public unsafe bool TryFloorTakedown(bool bOverrideCurrentMove = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TryFloorTakedown", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideCurrentMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: TryFloorStrike
    /// </summary>
    public unsafe bool TryFloorStrike(bool bOverrideCurrentMove = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TryFloorStrike", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideCurrentMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: TryFloorPickupThug
    /// </summary>
    public unsafe bool TryFloorPickupThug(bool bOverrideCurrentMove = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TryFloorPickupThug", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideCurrentMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: SetLastAttackTarget
    /// </summary>
    public unsafe void SetLastAttackTarget(BmSDK.BmGame.RPawnVillain Target)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SetLastAttackTarget", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ServerRequestProjectileCounter
    /// </summary>
    public unsafe void ServerRequestProjectileCounter(BmSDK.BmGame.RBMCombatThrownObject ThrownObject)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ServerRequestProjectileCounter", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrownObject, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ServerRequestCounter
    /// </summary>
    public unsafe void ServerRequestCounter(BmSDK.BmGame.RPawnVillain TargetPawn, BmSDK.Class CounterDmgType, int CounterInfoIndex, float CounterRot, System.Numerics.Vector3 AnimPos, bool bFinalBlow)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ServerRequestCounter", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CounterDmgType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CounterInfoIndex, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CounterRot, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPos, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFinalBlow, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TryBossCounter
    /// </summary>
    public unsafe bool TryBossCounter(BmSDK.BmGame.RPawnVillain targ)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TryBossCounter", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(targ, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: TryProjectileCounter
    /// </summary>
    public unsafe bool TryProjectileCounter(bool bCanCheckLongRange)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TryProjectileCounter", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanCheckLongRange, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: TryCounter
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayerCombat.ETryCounterResult TryCounter(bool bCanFail, float TimeInitiatedByPlayer = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TryCounter", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanFail, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeInitiatedByPlayer, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.ETryCounterResult>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: TrySimultaneousCounter
    /// </summary>
    public unsafe bool TrySimultaneousCounter(bool bCanStartMove, float TimeInitiatedByPlayer)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TrySimultaneousCounter", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanStartMove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeInitiatedByPlayer, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: TryStun
    /// </summary>
    public unsafe bool TryStun()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TryStun", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetStunMove
    /// </summary>
    public unsafe BmSDK.Class GetStunMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetStunMove", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ServerSpawnSpecialMove
    /// </summary>
    public unsafe void ServerSpawnSpecialMove(BmSDK.Class MoveClass, System.Numerics.Vector3 AnimPos, BmSDK.Rotator AnimRot)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ServerSpawnSpecialMove", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPos, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimRot, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ServerRequestStrike
    /// </summary>
    public unsafe void ServerRequestStrike(BmSDK.Class StrikeClass, BmSDK.BmGame.RPawnVillain Target, BmSDK.Class dmgType, int StrikeInfoIndex, bool bOverrideTargetStrike, float Dir, int Combo, BmSDK.BmGame.RPawnCombat.TargetStrikeResponse TargetResponse)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ServerRequestStrike", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrikeClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrikeInfoIndex, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideTargetStrike, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Dir, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Combo, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetResponse, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TryAirStrike
    /// </summary>
    public unsafe bool TryAirStrike(bool bOverrideCurrentMove = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TryAirStrike", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideCurrentMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: TryStrike
    /// </summary>
    public unsafe bool TryStrike(float TimeInitiatedByPlayer = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TryStrike", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeInitiatedByPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetBatclawStunTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain GetBatclawStunTarget(BmSDK.Class dmgType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetBatclawStunTarget", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: GetBatclawSlamTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain GetBatclawSlamTarget(BmSDK.Class dmgType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetBatclawSlamTarget", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: GetQuickStrikeDamageType
    /// </summary>
    public unsafe BmSDK.Class GetQuickStrikeDamageType()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetQuickStrikeDamageType", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetQuickStrikeType
    /// </summary>
    public unsafe BmSDK.Class GetQuickStrikeType()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetQuickStrikeType", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetHeavyStrikeType
    /// </summary>
    public unsafe BmSDK.Class GetHeavyStrikeType()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetHeavyStrikeType", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetHeavyStrikeDamageType
    /// </summary>
    public unsafe BmSDK.Class GetHeavyStrikeDamageType()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetHeavyStrikeDamageType", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetCriticalStrikeDamageType
    /// </summary>
    public unsafe BmSDK.Class GetCriticalStrikeDamageType()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetCriticalStrikeDamageType", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: TryBarge
    /// </summary>
    public unsafe bool TryBarge(bool bOverrideCurrentMove = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TryBarge", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideCurrentMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: StartRun
    /// </summary>
    public unsafe void StartRun()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.StartRun", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerGroundTakedown
    /// </summary>
    public unsafe bool TriggerGroundTakedown(bool bOverrideCurrentMove = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TriggerGroundTakedown", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideCurrentMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: TriggerCounter
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayerCombat.ETryCounterResult TriggerCounter(bool bCanFail)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TriggerCounter", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanFail, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.ETryCounterResult>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: TryToStartCombatInterrogation
    /// </summary>
    public unsafe bool TryToStartCombatInterrogation()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TryToStartCombatInterrogation", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: TryToStartCombatTakeDown
    /// </summary>
    public unsafe bool TryToStartCombatTakeDown()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TryToStartCombatTakeDown", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: BankPoints
    /// </summary>
    public unsafe void BankPoints()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.BankPoints", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BankPointsInternal
    /// </summary>
    public unsafe void BankPointsInternal()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.BankPointsInternal", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GrabReleased
    /// </summary>
    public unsafe void GrabReleased()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GrabReleased", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TrySecondaryGroupCombatMove
    /// </summary>
    public unsafe bool TrySecondaryGroupCombatMove(bool bOverrideCurrentMove = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TrySecondaryGroupCombatMove", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideCurrentMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: TryPrimaryGroupCombatMove
    /// </summary>
    public unsafe bool TryPrimaryGroupCombatMove(bool bOverrideCurrentMove = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TryPrimaryGroupCombatMove", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOverrideCurrentMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GrabPressed
    /// </summary>
    public unsafe void GrabPressed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GrabPressed", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FloorTakedownModifierReleased
    /// </summary>
    public unsafe void FloorTakedownModifierReleased()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.FloorTakedownModifierReleased", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FloorTakedownModifierPressed
    /// </summary>
    public unsafe void FloorTakedownModifierPressed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.FloorTakedownModifierPressed", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BlockBreakerReleased
    /// </summary>
    public unsafe void BlockBreakerReleased()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.BlockBreakerReleased", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoCapeStun
    /// </summary>
    public unsafe void DoCapeStun()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.DoCapeStun", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CapeStunTimer
    /// </summary>
    public unsafe void CapeStunTimer()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CapeStunTimer", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerBlockBreaker
    /// </summary>
    public unsafe void TriggerBlockBreaker()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TriggerBlockBreaker", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerSecondaryGroupCombatMove
    /// </summary>
    public unsafe void TriggerSecondaryGroupCombatMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TriggerSecondaryGroupCombatMove", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerPrimaryGroupCombatMove
    /// </summary>
    public unsafe void TriggerPrimaryGroupCombatMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TriggerPrimaryGroupCombatMove", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerCombatTakedown
    /// </summary>
    public unsafe void TriggerCombatTakedown()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TriggerCombatTakedown", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerWeaponDestroy
    /// </summary>
    public unsafe void TriggerWeaponDestroy()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TriggerWeaponDestroy", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerThrow
    /// </summary>
    public unsafe void TriggerThrow()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TriggerThrow", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerQuickStrike
    /// </summary>
    public unsafe void TriggerQuickStrike()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TriggerQuickStrike", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NewComboMoveStarted
    /// </summary>
    public unsafe void NewComboMoveStarted()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.NewComboMoveStarted", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateRunningTimers
    /// </summary>
    public unsafe void UpdateRunningTimers(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.UpdateRunningTimers", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnRoomChange
    /// </summary>
    public unsafe void OnRoomChange()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.OnRoomChange", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NotifyTakeDamage
    /// </summary>
    public unsafe void NotifyTakeDamage(int Damage, BmSDK.Engine.Controller InstigatedBy, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.Engine.Actor.FTraceHitInfo HitInfo = default, BmSDK.Engine.Actor DamageCauser = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.NotifyTakeDamage", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Damage, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstigatedBy, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitInfo, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageCauser, paramsPtr + 84);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateCombatHitVars
    /// </summary>
    public unsafe void UpdateCombatHitVars(BmSDK.Engine.Controller InstigatedBy, int Damage, BmSDK.Class DamageType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.UpdateCombatHitVars", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstigatedBy, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Damage, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddScore
    /// </summary>
    public unsafe void AddScore(int Amount)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.AddScore", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Amount, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddScoreForMove
    /// </summary>
    public unsafe void AddScoreForMove(BmSDK.BmGame.RGameInfo.EComboMoveType MoveType, int ComboMultiplier, BmSDK.BmGame.RPawnCombat Target, int NumTargets)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.AddScoreForMove", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ComboMultiplier, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumTargets, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TurnOffCounterPrompt
    /// </summary>
    public unsafe void TurnOffCounterPrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TurnOffCounterPrompt", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TurnOnCounterPrompt
    /// </summary>
    public unsafe void TurnOnCounterPrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TurnOnCounterPrompt", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetComboLevel
    /// </summary>
    public unsafe int GetComboLevel()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetComboLevel", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CanDoSpecialMove
    /// </summary>
    public unsafe bool CanDoSpecialMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CanDoSpecialMove", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SpecialMoveTargetInRange
    /// </summary>
    public unsafe bool SpecialMoveTargetInRange()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SpecialMoveTargetInRange", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: UpdateComboStatus
    /// </summary>
    public unsafe void UpdateComboStatus(BmSDK.BmGame.RPawnPlayerCombat CurrentPawn, BmSDK.BmGame.RPawnPlayerCombat NewPawn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.UpdateComboStatus", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPawn, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetComboLength
    /// </summary>
    public unsafe int GetComboLength()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetComboLength", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetNumAwayFromCombo
    /// </summary>
    public unsafe int GetNumAwayFromCombo()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetNumAwayFromCombo", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsInComboForSuper
    /// </summary>
    public unsafe bool IsInComboForSuper()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.IsInComboForSuper", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsInCombo
    /// </summary>
    public unsafe bool IsInCombo()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.IsInCombo", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetComboMinLength
    /// </summary>
    public unsafe int GetComboMinLength()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetComboMinLength", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CanContinueCombo
    /// </summary>
    public unsafe bool CanContinueCombo()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CanContinueCombo", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: DisableCombo
    /// </summary>
    public unsafe void DisableCombo()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.DisableCombo", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ContinueComboTimerComplete
    /// </summary>
    public unsafe void ContinueComboTimerComplete()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ContinueComboTimerComplete", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetComboTimerIfComboTimerRunning
    /// </summary>
    public unsafe void SetComboTimerIfComboTimerRunning(float TimeToSet)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SetComboTimerIfComboTimerRunning", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeToSet, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetContinueComboTimer
    /// </summary>
    public unsafe void SetContinueComboTimer(float ComboWindow = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SetContinueComboTimer", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ComboWindow, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CriticalComboMoveFailed
    /// </summary>
    public unsafe void CriticalComboMoveFailed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CriticalComboMoveFailed", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CriticalBeatdownPerformed
    /// </summary>
    public unsafe void CriticalBeatdownPerformed(int NumPerformed = default, bool bShowOnHud = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CriticalBeatdownPerformed", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumPerformed, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShowOnHud, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CriticalComboMovePerformed
    /// </summary>
    public unsafe void CriticalComboMovePerformed(int NumPerformed = default, bool bShowOnHud = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CriticalComboMovePerformed", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumPerformed, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShowOnHud, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnDropWeaponMove
    /// </summary>
    public unsafe void SpawnDropWeaponMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SpawnDropWeaponMove", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearCombo
    /// </summary>
    public unsafe void ClearCombo(BmSDK.FString Reason, bool bForceDropWeapon = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ClearCombo", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Reason, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceDropWeapon, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetCombatMoveDurationMulti
    /// </summary>
    public unsafe float GetCombatMoveDurationMulti()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetCombatMoveDurationMulti", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: TurnOffFinalBlowPP
    /// </summary>
    public unsafe void TurnOffFinalBlowPP()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TurnOffFinalBlowPP", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TurnOnFinalBlowPP
    /// </summary>
    public unsafe void TurnOnFinalBlowPP(float Amount)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TurnOnFinalBlowPP", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Amount, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsInFreeflowFocus
    /// </summary>
    public unsafe bool IsInFreeflowFocus()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.IsInFreeflowFocus", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CanDoGadgetSpecial
    /// </summary>
    public unsafe bool CanDoGadgetSpecial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CanDoGadgetSpecial", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetCombatFOVModifier
    /// </summary>
    public unsafe int GetCombatFOVModifier()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetCombatFOVModifier", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetBatmobileTakedownAdrenalineSpecialLimit
    /// </summary>
    public unsafe float GetBatmobileTakedownAdrenalineSpecialLimit()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetBatmobileTakedownAdrenalineSpecialLimit", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ShowBatmobileTakedownAdrenaline
    /// </summary>
    public unsafe void ShowBatmobileTakedownAdrenaline()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ShowBatmobileTakedownAdrenaline", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearBatmobileTakedownAdrenalineAtEndOfCombat
    /// </summary>
    public unsafe void ClearBatmobileTakedownAdrenalineAtEndOfCombat()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ClearBatmobileTakedownAdrenalineAtEndOfCombat", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpendBatmobileTakedownAdrenaline
    /// </summary>
    public unsafe void SpendBatmobileTakedownAdrenaline()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SpendBatmobileTakedownAdrenaline", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IncBatmobileTakedownAdrenaline
    /// </summary>
    public unsafe void IncBatmobileTakedownAdrenaline(float IncAmount)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.IncBatmobileTakedownAdrenaline", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IncAmount, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TrySpawnDualPlayMove
    /// </summary>
    public unsafe bool TrySpawnDualPlayMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TrySpawnDualPlayMove", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsRiddlerMechFight
    /// </summary>
    public unsafe bool IsRiddlerMechFight()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.IsRiddlerMechFight", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: HasDualPlayTargets
    /// </summary>
    public unsafe bool HasDualPlayTargets()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.HasDualPlayTargets", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: DualPlayReleased
    /// </summary>
    public unsafe void DualPlayReleased()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.DualPlayReleased", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DualPlayPressed
    /// </summary>
    public unsafe void DualPlayPressed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.DualPlayPressed", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanDualPlay
    /// </summary>
    public unsafe bool CanDualPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CanDualPlay", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ClearDualPlayAdrenalineAtEndOfCombat
    /// </summary>
    public unsafe void ClearDualPlayAdrenalineAtEndOfCombat()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ClearDualPlayAdrenalineAtEndOfCombat", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoDualplayAdrenalineSpent
    /// </summary>
    public unsafe void DoDualplayAdrenalineSpent()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.DoDualplayAdrenalineSpent", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoTakedownStateChangeEvent
    /// </summary>
    public unsafe void DoTakedownStateChangeEvent()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.DoTakedownStateChangeEvent", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpendDualPlayAdrenaline
    /// </summary>
    public unsafe void SpendDualPlayAdrenaline()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SpendDualPlayAdrenaline", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateDualPlayHud
    /// </summary>
    public unsafe void UpdateDualPlayHud()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.UpdateDualPlayHud", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IncDualPlayAdrenaline
    /// </summary>
    public unsafe void IncDualPlayAdrenaline(float IncAmount, bool bUpdateAdrenalineOnly = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.IncDualPlayAdrenaline", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IncAmount, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUpdateAdrenalineOnly, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetSniperPP
    /// </summary>
    public unsafe void SetSniperPP(float Opacity, bool bAuto = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SetSniperPP", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Opacity, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAuto, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TurnOffSniperPP
    /// </summary>
    public unsafe void TurnOffSniperPP()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TurnOffSniperPP", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TurnOnSniperPP
    /// </summary>
    public unsafe void TurnOnSniperPP()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TurnOnSniperPP", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateFreeflowFocusFX
    /// </summary>
    public unsafe void UpdateFreeflowFocusFX(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.UpdateFreeflowFocusFX", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearAdrenalineAtEndOfCombat
    /// </summary>
    public unsafe void ClearAdrenalineAtEndOfCombat()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ClearAdrenalineAtEndOfCombat", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearAdrenalineWhenComboLost
    /// </summary>
    public unsafe void ClearAdrenalineWhenComboLost()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ClearAdrenalineWhenComboLost", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearAdrenaline
    /// </summary>
    public unsafe void ClearAdrenaline()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ClearAdrenaline", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpendAdrenaline
    /// </summary>
    public unsafe void SpendAdrenaline()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SpendAdrenaline", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetAdrenalineOnHud
    /// </summary>
    public unsafe void SetAdrenalineOnHud(bool reduced_by_injury = default, bool bSpecialMoveTriggered = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SetAdrenalineOnHud", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(reduced_by_injury, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSpecialMoveTriggered, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetAdrenalineSuperSpecialLimit
    /// </summary>
    public unsafe float GetAdrenalineSuperSpecialLimit()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetAdrenalineSuperSpecialLimit", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetAdrenalineSpecialLimit
    /// </summary>
    public unsafe float GetAdrenalineSpecialLimit()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetAdrenalineSpecialLimit", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: DecAdrenaline
    /// </summary>
    public unsafe void DecAdrenaline(float DecAmount)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.DecAdrenaline", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DecAmount, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IncAdrenaline
    /// </summary>
    public unsafe void IncAdrenaline(float IncAmount)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.IncAdrenaline", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IncAmount, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DecCombo
    /// </summary>
    public unsafe void DecCombo()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.DecCombo", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IncCombo
    /// </summary>
    public unsafe void IncCombo(BmSDK.BmGame.RPawnCombat PawnAttacked = default, int IncAmount = default, int IncSpecialMoveCount = default, bool bDoNotIncBatmobileTakedown = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.IncCombo", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnAttacked, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IncAmount, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IncSpecialMoveCount, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoNotIncBatmobileTakedown, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetQuickStrikeAudioParam
    /// </summary>
    public unsafe void SetQuickStrikeAudioParam(float Scale)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SetQuickStrikeAudioParam", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Scale, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetComboIncCue
    /// </summary>
    public unsafe void SetComboIncCue(BmSDK.Engine.SoundCue NewCue)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SetComboIncCue", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BankXPForSave
    /// </summary>
    public unsafe void BankXPForSave()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.BankXPForSave", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowCombatBonusPoints
    /// </summary>
    public unsafe float ShowCombatBonusPoints()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ShowCombatBonusPoints", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: AwardCombatBonusPoints
    /// </summary>
    public unsafe int AwardCombatBonusPoints()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.AwardCombatBonusPoints", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: AwardPredatorSkillPoints
    /// </summary>
    public unsafe void AwardPredatorSkillPoints()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.AwardPredatorSkillPoints", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AwardCombatSkillPoints
    /// </summary>
    public unsafe void AwardCombatSkillPoints()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.AwardCombatSkillPoints", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpottedDuringPredator
    /// </summary>
    public unsafe void SpottedDuringPredator(BmSDK.BmGame.RPawnVillain Spotter)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SpottedDuringPredator", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Spotter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayerSpotted
    /// </summary>
    public unsafe void PlayerSpotted(BmSDK.BmGame.RPawnVillain Spotee)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.PlayerSpotted", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Spotee, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddPredatorXPBonus
    /// </summary>
    public unsafe void AddPredatorXPBonus()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.AddPredatorXPBonus", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddCombatXPBonus
    /// </summary>
    public unsafe void AddCombatXPBonus()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.AddCombatXPBonus", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateStoredCombatXPInfo
    /// </summary>
    public unsafe void UpdateStoredCombatXPInfo()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.UpdateStoredCombatXPInfo", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearXPAfterSuppression
    /// </summary>
    public unsafe void ClearXPAfterSuppression()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ClearXPAfterSuppression", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AwardXPAfterSuppression
    /// </summary>
    public unsafe void AwardXPAfterSuppression()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.AwardXPAfterSuppression", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NotifyCombatStarted
    /// </summary>
    public unsafe void NotifyCombatStarted()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.NotifyCombatStarted", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ResetPerFightStats
    /// </summary>
    public unsafe void ResetPerFightStats(bool bForce = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ResetPerFightStats", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForce, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ResetMaxCombatants
    /// </summary>
    public unsafe void ResetMaxCombatants()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ResetMaxCombatants", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ResetMaxComboSize
    /// </summary>
    public unsafe void ResetMaxComboSize()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ResetMaxComboSize", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetMaxComboSize
    /// </summary>
    public unsafe int GetMaxComboSize()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetMaxComboSize", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IncCombosStarted
    /// </summary>
    public unsafe void IncCombosStarted()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.IncCombosStarted", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetAverageCombo
    /// </summary>
    public unsafe int GetAverageCombo()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetAverageCombo", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetNumCombosStarted
    /// </summary>
    public unsafe int GetNumCombosStarted()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetNumCombosStarted", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ResetCombosStarted
    /// </summary>
    public unsafe void ResetCombosStarted()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ResetCombosStarted", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: EnterComboFlow
    /// </summary>
    public unsafe void EnterComboFlow()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.EnterComboFlow", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OutputComboMoves
    /// </summary>
    public unsafe void OutputComboMoves()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.OutputComboMoves", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearComboMoves
    /// </summary>
    public unsafe void ClearComboMoves()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ClearComboMoves", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetMaxVariation
    /// </summary>
    public unsafe void SetMaxVariation()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SetMaxVariation", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetMaxComboVariation
    /// </summary>
    public unsafe int GetMaxComboVariation(bool bIncludeGadgets = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetMaxComboVariation", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIncludeGadgets, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: ResetComboMoveTypes
    /// </summary>
    public unsafe void ResetComboMoveTypes()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ResetComboMoveTypes", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ResetMaxComboVariation
    /// </summary>
    public unsafe void ResetMaxComboVariation()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ResetMaxComboVariation", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ResetGadgetVariation
    /// </summary>
    public unsafe void ResetGadgetVariation()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ResetGadgetVariation", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetComboGadgetVariationScore
    /// </summary>
    public unsafe int GetComboGadgetVariationScore()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetComboGadgetVariationScore", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetComboVariationScore
    /// </summary>
    public unsafe int GetComboVariationScore(bool bIncludeGadgets = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetComboVariationScore", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIncludeGadgets, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: MovePerformed
    /// </summary>
    public unsafe void MovePerformed(BmSDK.BmGame.RGameInfo.EComboMoveType MoveType, BmSDK.BmGame.RPawnCombat Target, bool bAddScore = default, int ComboForScore = default, int NumOfTargets = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.MovePerformed", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAddScore, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ComboForScore, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumOfTargets, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IncTutorialProgressForMove
    /// </summary>
    public unsafe void IncTutorialProgressForMove(BmSDK.BmGame.RGameInfo.EComboMoveType MoveType, BmSDK.BmGame.RPawnCombat Target)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.IncTutorialProgressForMove", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RepelledByBrute
    /// </summary>
    public unsafe void RepelledByBrute()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.RepelledByBrute", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BlockedBy
    /// </summary>
    public unsafe void BlockedBy(BmSDK.BmGame.RPawnVillain Villain)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.BlockedBy", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Villain, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShouldShowAutoCombatHints
    /// </summary>
    public unsafe bool ShouldShowAutoCombatHints()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ShouldShowAutoCombatHints", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ClearChargesSinceBatarang
    /// </summary>
    public unsafe void ClearChargesSinceBatarang()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ClearChargesSinceBatarang", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IncChargesSinceBatarang
    /// </summary>
    public unsafe void IncChargesSinceBatarang()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.IncChargesSinceBatarang", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearHitsSinceCounter
    /// </summary>
    public unsafe void ClearHitsSinceCounter()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ClearHitsSinceCounter", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IncHitsSinceCounter
    /// </summary>
    public unsafe void IncHitsSinceCounter()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.IncHitsSinceCounter", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanDoComboProjectileGadget
    /// </summary>
    public unsafe bool CanDoComboProjectileGadget()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CanDoComboProjectileGadget", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CanDoComboWhip
    /// </summary>
    public unsafe bool CanDoComboWhip()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CanDoComboWhip", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CanDoComboBatarang
    /// </summary>
    public unsafe bool CanDoComboBatarang()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CanDoComboBatarang", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ServerRequestRedirect
    /// </summary>
    public unsafe void ServerRequestRedirect(BmSDK.BmGame.RPawnVillain TargetPawn, System.Numerics.Vector3 RedirectDir, System.Numerics.Vector3 AnimPos)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ServerRequestRedirect", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RedirectDir, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPos, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TryRedirect
    /// </summary>
    public unsafe bool TryRedirect(BmSDK.BmGame.RPawnVillain TargetPawn = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TryRedirect", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: ServerLockProjectileThrowTarget
    /// </summary>
    public unsafe void ServerLockProjectileThrowTarget(BmSDK.BmGame.RPawnVillain ThrowTarget, BmSDK.Rotator ThrowDir)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ServerLockProjectileThrowTarget", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowTarget, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowDir, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ServerRequestEvade
    /// </summary>
    public unsafe void ServerRequestEvade(System.Numerics.Vector3 EvadeDir, BmSDK.FName EvadeName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ServerRequestEvade", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EvadeDir, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EvadeName, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnEvade
    /// </summary>
    public unsafe void SpawnEvade(bool bCanQueue = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SpawnEvade", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanQueue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TryToQueueEvade
    /// </summary>
    public unsafe void TryToQueueEvade()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TryToQueueEvade", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetWallEvadeInfo
    /// </summary>
    public unsafe bool GetWallEvadeInfo(System.Numerics.Vector3 Dir, out System.Numerics.Vector3 WallLocation, out System.Numerics.Vector3 WallNormal)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetWallEvadeInfo", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Dir, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        WallLocation = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
        WallNormal = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 36);
    }

    /// <summary>
    /// Function: DialogueModeTimeout
    /// </summary>
    public unsafe void DialogueModeTimeout()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.DialogueModeTimeout", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TryingToSetDialogueMode
    /// </summary>
    public unsafe void TryingToSetDialogueMode()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.TryingToSetDialogueMode", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoubleTapRun
    /// </summary>
    public unsafe void DoubleTapRun()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.DoubleTapRun", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearLastTarget
    /// </summary>
    public unsafe void ClearLastTarget()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ClearLastTarget", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CombatMoveFinished
    /// </summary>
    public unsafe void CombatMoveFinished(BmSDK.BmGame.RCombatMove FinishedMove)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CombatMoveFinished", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FinishedMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CombatMoveInitialised
    /// </summary>
    public unsafe void CombatMoveInitialised()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CombatMoveInitialised", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetHelpPrompt
    /// </summary>
    public unsafe void GetHelpPrompt(BmSDK.BmGame.RHUDPrompt HelpPrompt, bool bKismetHelpOn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetHelpPrompt", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpPrompt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKismetHelpOn, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowTutorial
    /// </summary>
    public unsafe void ShowTutorial(BmSDK.BmGame.RHUDPrompt HelpPrompt, BmSDK.BmGame.RPersistentData.ETutorialType TutorialToShow)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ShowTutorial", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpPrompt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TutorialToShow, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowMultiStageTutorial
    /// </summary>
    public unsafe void ShowMultiStageTutorial(BmSDK.BmGame.RHUDPrompt HelpPrompt)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.ShowMultiStageTutorial", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpPrompt, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetAerialBeatdownIcon
    /// </summary>
    public unsafe BmSDK.BmGame.RHUDPrompt.EControlIcon GetAerialBeatdownIcon()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetAerialBeatdownIcon", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHUDPrompt.EControlIcon>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetBeatdownIcon
    /// </summary>
    public unsafe BmSDK.BmGame.RHUDPrompt.EControlIcon GetBeatdownIcon()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetBeatdownIcon", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHUDPrompt.EControlIcon>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetHighestPriorityBatmobileTutorial
    /// </summary>
    public unsafe void GetHighestPriorityBatmobileTutorial(out BmSDK.BmGame.RPersistentData.ETutorialType BestTutorial, out BmSDK.FString BestTutorialPrompt, out BmSDK.BmGame.RHUDPrompt.EControlIcon BestControlIcon, out int bShowTutorial)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetHighestPriorityBatmobileTutorial", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BestTutorial = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.ETutorialType>(paramsPtr + 0);
        BestTutorialPrompt = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 4);
        BestControlIcon = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHUDPrompt.EControlIcon>(paramsPtr + 20);
        bShowTutorial = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 24);
        return;
    }

    /// <summary>
    /// Function: GetHighestPriorityTutorial
    /// </summary>
    public unsafe void GetHighestPriorityTutorial(out BmSDK.BmGame.RPersistentData.ETutorialType BestTutorial, out BmSDK.FString BestTutorialPrompt, out BmSDK.BmGame.RHUDPrompt.EControlIcon BestControlIcon, out int bShowTutorial)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetHighestPriorityTutorial", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BestTutorial = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.ETutorialType>(paramsPtr + 0);
        BestTutorialPrompt = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 4);
        BestControlIcon = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHUDPrompt.EControlIcon>(paramsPtr + 20);
        bShowTutorial = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 24);
        return;
    }

    /// <summary>
    /// Function: GrabbableWeaponInRange
    /// </summary>
    public unsafe bool GrabbableWeaponInRange()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GrabbableWeaponInRange", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CheckTutorial
    /// </summary>
    public unsafe bool CheckTutorial(BmSDK.BmGame.RPersistentData.ETutorialType CheckTutorialType, out int BestPriority, out BmSDK.BmGame.RPersistentData.ETutorialType BestTutorial, out BmSDK.FString BestPrompt, out int bShowTutorial)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CheckTutorial", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckTutorialType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BestPriority = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
        BestTutorial = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.ETutorialType>(paramsPtr + 8);
        BestPrompt = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 12);
        bShowTutorial = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 28);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 32);
    }

    /// <summary>
    /// Function: CanTriggerCombatInterrogation
    /// </summary>
    public unsafe bool CanTriggerCombatInterrogation(bool bCheckValidContext = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CanTriggerCombatInterrogation", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCheckValidContext, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IsInCombat
    /// </summary>
    public unsafe bool IsInCombat(bool bForceCheck = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.IsInCombat", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceCheck, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetCM
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatManager GetCM()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetCM", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatManager>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: FindFloorTakedownTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain FindFloorTakedownTarget()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.FindFloorTakedownTarget", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: FindRedirectTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCombat FindRedirectTarget(float MaxDist)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.FindRedirectTarget", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxDist, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: InputHeading
    /// </summary>
    public unsafe System.Numerics.Vector3 InputHeading(bool bCanBeZero = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.InputHeading", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanBeZero, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: HasMovementInput
    /// </summary>
    public unsafe bool HasMovementInput()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.HasMovementInput", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsBatarangPrimed
    /// </summary>
    public unsafe bool IsBatarangPrimed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.IsBatarangPrimed", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CheckThrowSmokeBomb
    /// </summary>
    public unsafe bool CheckThrowSmokeBomb()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CheckThrowSmokeBomb", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CanDoCombat
    /// </summary>
    public unsafe bool CanDoCombat(bool CheckForEvade = default, bool bDebugOutput = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CanDoCombat", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckForEvade, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugOutput, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: CanBeAttacked
    /// </summary>
    public unsafe bool CanBeAttacked()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CanBeAttacked", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetLasered
    /// </summary>
    public unsafe void SetLasered(bool bNewValue)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SetLasered", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewValue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetZapped
    /// </summary>
    public unsafe void SetZapped(bool bNewValue)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.SetZapped", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewValue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsLasered
    /// </summary>
    public unsafe bool IsLasered()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.IsLasered", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsZapped
    /// </summary>
    public unsafe bool IsZapped()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.IsZapped", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsStunned
    /// </summary>
    public unsafe bool IsStunned()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.IsStunned", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: HasBeenHit
    /// </summary>
    public unsafe bool HasBeenHit()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.HasBeenHit", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: StartBeenHitCheck
    /// </summary>
    public unsafe void StartBeenHitCheck()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.StartBeenHitCheck", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HasEverBeenHit
    /// </summary>
    public unsafe bool HasEverBeenHit()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.HasEverBeenHit", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: StartEverBeenHitCheck
    /// </summary>
    public unsafe void StartEverBeenHitCheck()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.StartEverBeenHitCheck", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanShowFloorPickupPrompt
    /// </summary>
    public unsafe bool CanShowFloorPickupPrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.CanShowFloorPickupPrompt", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsValidStrikeTarget
    /// </summary>
    public unsafe bool IsValidStrikeTarget(System.Numerics.Vector3 FacingDir, BmSDK.Class dmgType, BmSDK.BmGame.RPawnVillain TestPawn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.IsValidStrikeTarget", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FacingDir, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 28);
    }

    /// <summary>
    /// Function: FindWeaponToPickupCacheUI
    /// </summary>
    public unsafe bool FindWeaponToPickupCacheUI(System.Numerics.Vector3 CheckDir, float CheckDist)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.FindWeaponToPickupCacheUI", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckDir, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckDist, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: FindWeaponToPickup
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatThrownObject FindWeaponToPickup(System.Numerics.Vector3 CheckDir, float CheckDist)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.FindWeaponToPickup", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckDir, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckDist, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatThrownObject>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: FindDeadTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain FindDeadTarget(System.Numerics.Vector3 FacingDir, BmSDK.Class dmgType = default, float CloseRangeDist = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.FindDeadTarget", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FacingDir, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CloseRangeDist, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: FindStrikeTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain FindStrikeTarget(System.Numerics.Vector3 FacingDir, BmSDK.Class dmgType = default, float CloseRangeDist = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.FindStrikeTarget", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FacingDir, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CloseRangeDist, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: GetLookAtEnemy
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCombat GetLookAtEnemy()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPlayerControllerCombat.GetLookAtEnemy", true);
        byte* paramsPtr = stackalloc byte[64];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(paramsPtr + 0);
    }

    /// <summary>
    /// Struct: FComboMoveInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FComboMoveInfo
    {
        /// <summary>
        /// ByteProperty: MoveType
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.EComboMoveType MoveType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EComboMoveType>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: MoveNum
        /// </summary>
        public unsafe int MoveNum
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FStruckInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FStruckInfo
    {
        /// <summary>
        /// ObjectProperty: PawnAttacked
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnCombat PawnAttacked
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: ConsecutiveHits
        /// </summary>
        public unsafe int ConsecutiveHits
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// ObjectProperty: CombatManager
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatManager CombatManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatManager>(Ptr + 7440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7440); }
    }

    /// <summary>
    /// ObjectProperty: ImpactRumble
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform ImpactRumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 7448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7448); }
    }

    /// <summary>
    /// ObjectProperty: LastAttackTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain LastAttackTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 7456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7456); }
    }

    /// <summary>
    /// ObjectProperty: DifficultyOverrideVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RDifficultyOverrideVolume DifficultyOverrideVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDifficultyOverrideVolume>(Ptr + 7464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7464); }
    }

    /// <summary>
    /// ObjectProperty: CurrentLookAtTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCombat CurrentLookAtTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(Ptr + 7472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7472); }
    }

    /// <summary>
    /// ObjectProperty: SniperPP
    /// </summary>
    public unsafe BmSDK.BmGame.RViewPostProcess SniperPP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RViewPostProcess>(Ptr + 7480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7480); }
    }

    /// <summary>
    /// ObjectProperty: FinalBlowPP
    /// </summary>
    public unsafe BmSDK.BmGame.RViewPostProcess FinalBlowPP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RViewPostProcess>(Ptr + 7488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7488); }
    }

    /// <summary>
    /// ObjectProperty: FixedCombatCam
    /// </summary>
    public unsafe BmSDK.BmGame.RCameraActor FixedCombatCam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCameraActor>(Ptr + 7496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7496); }
    }

    /// <summary>
    /// ObjectProperty: FixedCombatCam_HeliBase
    /// </summary>
    public unsafe BmSDK.BmGame.RHelicopterBase FixedCombatCam_HeliBase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHelicopterBase>(Ptr + 7504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7504); }
    }

    /// <summary>
    /// ComponentProperty: ComboIncAC
    /// </summary>
    public unsafe BmSDK.Engine.AudioComponent ComboIncAC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AudioComponent>(Ptr + 7512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7512); }
    }

    /// <summary>
    /// ComponentProperty: XPBonusRoom
    /// </summary>
    public unsafe BmSDK.BmGame.RBMRoomAIState XPBonusRoom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMRoomAIState>(Ptr + 7520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7520); }
    }

    /// <summary>
    /// IntProperty: ComboSize
    /// </summary>
    public unsafe int ComboSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7528); }
    }

    /// <summary>
    /// IntProperty: CurrMaxComboSize
    /// </summary>
    public unsafe int CurrMaxComboSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7532); }
    }

    /// <summary>
    /// IntProperty: TotalMaxComboSize
    /// </summary>
    public unsafe int TotalMaxComboSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7536); }
    }

    /// <summary>
    /// IntProperty: NumTimesHit
    /// </summary>
    public unsafe int NumTimesHit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7540); }
    }

    /// <summary>
    /// FloatProperty: AdrenalineValue
    /// </summary>
    public unsafe float AdrenalineValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7544); }
    }

    /// <summary>
    /// FloatProperty: AdrenalineSpecialLimit
    /// </summary>
    public unsafe float AdrenalineSpecialLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7548); }
    }

    /// <summary>
    /// FloatProperty: AdrenalineSuperSpecialLimit
    /// </summary>
    public unsafe float AdrenalineSuperSpecialLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7552); }
    }

    /// <summary>
    /// BoolProperty: bFirstSpecialMoveUsed
    /// </summary>
    public unsafe bool bFirstSpecialMoveUsed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: AdrenalineBarActive
    /// </summary>
    public unsafe bool AdrenalineBarActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bSuppressCombatCameraInCorridor
    /// </summary>
    public unsafe bool bSuppressCombatCameraInCorridor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bPlayFinishedCombatMoveWhenAble
    /// </summary>
    public unsafe bool bPlayFinishedCombatMoveWhenAble
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bForceSpecialCombo
    /// </summary>
    public unsafe bool bForceSpecialCombo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHit
    /// </summary>
    public unsafe bool bBeenHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bEverBeenHit
    /// </summary>
    public unsafe bool bEverBeenHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bShownDesignTutorial
    /// </summary>
    public unsafe bool bShownDesignTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitByStunStick
    /// </summary>
    public unsafe bool bBeenHitByStunStick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitByKnife
    /// </summary>
    public unsafe bool bBeenHitByKnife
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitBySword
    /// </summary>
    public unsafe bool bBeenHitBySword
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitByCombatGun
    /// </summary>
    public unsafe bool bBeenHitByCombatGun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitByChargedUpThug
    /// </summary>
    public unsafe bool bBeenHitByChargedUpThug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitByMultiWeaponFist
    /// </summary>
    public unsafe bool bBeenHitByMultiWeaponFist
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitByMultiWeaponShield
    /// </summary>
    public unsafe bool bBeenHitByMultiWeaponShield
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitBySimultaneousAttack
    /// </summary>
    public unsafe bool bBeenHitBySimultaneousAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitByArmouredThug
    /// </summary>
    public unsafe bool bBeenHitByArmouredThug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitByShieldThug
    /// </summary>
    public unsafe bool bBeenHitByShieldThug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitByLieutenant
    /// </summary>
    public unsafe bool bBeenHitByLieutenant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitByTitanHenchman
    /// </summary>
    public unsafe bool bBeenHitByTitanHenchman
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitByProjectile
    /// </summary>
    public unsafe bool bBeenHitByProjectile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitBySniper
    /// </summary>
    public unsafe bool bBeenHitBySniper
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bBeenHitByMine
    /// </summary>
    public unsafe bool bBeenHitByMine
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bSpottedByThermal
    /// </summary>
    public unsafe bool bSpottedByThermal
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bVantageMineWasUsedInPredatorSection
    /// </summary>
    public unsafe bool bVantageMineWasUsedInPredatorSection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bTryingToSetDialogueMode
    /// </summary>
    public unsafe bool bTryingToSetDialogueMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bShowEvadePrompt
    /// </summary>
    public unsafe bool bShowEvadePrompt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bShowQuickBatarangPrompt
    /// </summary>
    public unsafe bool bShowQuickBatarangPrompt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bCanDoComboBatarang
    /// </summary>
    public unsafe bool bCanDoComboBatarang
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bMirroredFailAnim
    /// </summary>
    public unsafe bool bMirroredFailAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bStoredNoHitBonus
    /// </summary>
    public unsafe bool bStoredNoHitBonus
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: bStoredPerfectFreeflow
    /// </summary>
    public unsafe bool bStoredPerfectFreeflow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7556); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7556); }
    }

    /// <summary>
    /// BoolProperty: StoredPredatorSeen
    /// </summary>
    public unsafe bool StoredPredatorSeen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7560); }
    }

    /// <summary>
    /// BoolProperty: bUseComboIncCue
    /// </summary>
    public unsafe bool bUseComboIncCue
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7560); }
    }

    /// <summary>
    /// BoolProperty: bLieutenantStrikeHelp
    /// </summary>
    public unsafe bool bLieutenantStrikeHelp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7560); }
    }

    /// <summary>
    /// BoolProperty: bDisallowCombat
    /// </summary>
    public unsafe bool bDisallowCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7560); }
    }

    /// <summary>
    /// BoolProperty: bAllowCombatWithNoMovement
    /// </summary>
    public unsafe bool bAllowCombatWithNoMovement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7560); }
    }

    /// <summary>
    /// BoolProperty: bCapeStunDisabled
    /// </summary>
    public unsafe bool bCapeStunDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7560); }
    }

    /// <summary>
    /// BoolProperty: bInFreeflowFocus
    /// </summary>
    public unsafe bool bInFreeflowFocus
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7560); }
    }

    /// <summary>
    /// BoolProperty: bSniperPPActive
    /// </summary>
    public unsafe bool bSniperPPActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7560); }
    }

    /// <summary>
    /// BoolProperty: bAllowInteractionMidCombat
    /// </summary>
    public unsafe bool bAllowInteractionMidCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7560); }
    }

    /// <summary>
    /// BoolProperty: bCouldDoCombatWhenCounterPressed
    /// </summary>
    public unsafe bool bCouldDoCombatWhenCounterPressed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7560); }
    }

    /// <summary>
    /// BoolProperty: bUnderAttackFromGunshipHomingMissiles
    /// </summary>
    public unsafe bool bUnderAttackFromGunshipHomingMissiles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7560); }
    }

    /// <summary>
    /// BoolProperty: bPrevCanDoDualPlayTakedown
    /// </summary>
    public unsafe bool bPrevCanDoDualPlayTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7560); }
    }

    /// <summary>
    /// BoolProperty: bCanDoReadyGadgetOrCounter
    /// </summary>
    public unsafe bool bCanDoReadyGadgetOrCounter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7560); }
    }

    /// <summary>
    /// BoolProperty: bNoGroundTakedown
    /// </summary>
    public unsafe bool bNoGroundTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7560); }
    }

    /// <summary>
    /// BoolProperty: bGroundTakedownDone
    /// </summary>
    public unsafe bool bGroundTakedownDone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7560); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7560); }
    }

    /// <summary>
    /// FloatProperty: DualPlayAdrenalineValue
    /// </summary>
    public unsafe float DualPlayAdrenalineValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7564); }
    }

    /// <summary>
    /// FloatProperty: DualPlayAdrenalineSpecialLimit
    /// </summary>
    public unsafe float DualPlayAdrenalineSpecialLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7568); }
    }

    /// <summary>
    /// FloatProperty: BatmobileTakedownAdrenalineValue
    /// </summary>
    public unsafe float BatmobileTakedownAdrenalineValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7572); }
    }

    /// <summary>
    /// FloatProperty: BatmobileTakedownAdrenalineSpecialLimit
    /// </summary>
    public unsafe float BatmobileTakedownAdrenalineSpecialLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7576); }
    }

    /// <summary>
    /// IntProperty: CombatScore
    /// </summary>
    public unsafe int CombatScore
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7580); }
    }

    /// <summary>
    /// ArrayProperty: TargettedBy
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnCombat> TargettedBy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnCombat>>(Ptr + 7584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7584); }
    }

    /// <summary>
    /// FloatProperty: LastAttackTargetTime
    /// </summary>
    public unsafe float LastAttackTargetTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7600); }
    }

    /// <summary>
    /// StructProperty: LastStrikeDir
    /// </summary>
    public unsafe System.Numerics.Vector3 LastStrikeDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 7604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7604); }
    }

    /// <summary>
    /// FloatProperty: FinishedCombatSpecialMoveTimeout
    /// </summary>
    public unsafe float FinishedCombatSpecialMoveTimeout
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7616); }
    }

    /// <summary>
    /// IntProperty: MovesSinceSpecial
    /// </summary>
    public unsafe int MovesSinceSpecial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7620); }
    }

    /// <summary>
    /// IntProperty: CombosStarted
    /// </summary>
    public unsafe int CombosStarted
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7624); }
    }

    /// <summary>
    /// IntProperty: CombosAchieved
    /// </summary>
    public unsafe int CombosAchieved
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7628); }
    }

    /// <summary>
    /// IntProperty: CummulativeComboAchieved
    /// </summary>
    public unsafe int CummulativeComboAchieved
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7632); }
    }

    /// <summary>
    /// IntProperty: CounterPrompt
    /// </summary>
    public unsafe int CounterPrompt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7636); }
    }

    /// <summary>
    /// FloatProperty: CounterPromptTimer
    /// </summary>
    public unsafe float CounterPromptTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7640); }
    }

    /// <summary>
    /// FloatProperty: LastFailTime
    /// </summary>
    public unsafe float LastFailTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7644); }
    }

    /// <summary>
    /// NameProperty: LastFailAnimName
    /// </summary>
    public unsafe BmSDK.FName LastFailAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 7648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7648); }
    }

    /// <summary>
    /// IntProperty: MaxComboSize
    /// </summary>
    public unsafe int MaxComboSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7656); }
    }

    /// <summary>
    /// IntProperty: MaxCombatants
    /// </summary>
    public unsafe int MaxCombatants
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7660); }
    }

    /// <summary>
    /// IntProperty: MaxComboVariation
    /// </summary>
    public unsafe int MaxComboVariation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7664); }
    }

    /// <summary>
    /// IntProperty: MaxComboVariationNoGadgets
    /// </summary>
    public unsafe int MaxComboVariationNoGadgets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7668); }
    }

    /// <summary>
    /// IntProperty: TimesHitInThisFight
    /// </summary>
    public unsafe int TimesHitInThisFight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7672); }
    }

    /// <summary>
    /// StructProperty: StoredCombatXPInfo
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.FCombatXPInfo StoredCombatXPInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.FCombatXPInfo>(Ptr + 7676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7676); }
    }

    /// <summary>
    /// IntProperty: StoredComboBonus
    /// </summary>
    public unsafe int StoredComboBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7776); }
    }

    /// <summary>
    /// IntProperty: StoredMaxCombatants
    /// </summary>
    public unsafe int StoredMaxCombatants
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7780); }
    }

    /// <summary>
    /// IntProperty: StoredVariationBonus
    /// </summary>
    public unsafe int StoredVariationBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7784); }
    }

    /// <summary>
    /// IntProperty: StoredGadgetVariationBonus
    /// </summary>
    public unsafe int StoredGadgetVariationBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7788); }
    }

    /// <summary>
    /// IntProperty: StoredNumberOfCombos
    /// </summary>
    public unsafe int StoredNumberOfCombos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7792); }
    }

    /// <summary>
    /// IntProperty: StoredNumCombatants
    /// </summary>
    public unsafe int StoredNumCombatants
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7796); }
    }

    /// <summary>
    /// IntProperty: StoredNumThugs
    /// </summary>
    public unsafe int StoredNumThugs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7800); }
    }

    /// <summary>
    /// IntProperty: StoredNumCombatExperts
    /// </summary>
    public unsafe int StoredNumCombatExperts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7804); }
    }

    /// <summary>
    /// IntProperty: StoredNumBrutes
    /// </summary>
    public unsafe int StoredNumBrutes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7808); }
    }

    /// <summary>
    /// IntProperty: StoredNumMedics
    /// </summary>
    public unsafe int StoredNumMedics
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7812); }
    }

    /// <summary>
    /// IntProperty: StoredNumRobots
    /// </summary>
    public unsafe int StoredNumRobots
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7816); }
    }

    /// <summary>
    /// IntProperty: StoredNumDollotrons
    /// </summary>
    public unsafe int StoredNumDollotrons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7820); }
    }

    /// <summary>
    /// IntProperty: StoredNumJokerBoxer
    /// </summary>
    public unsafe int StoredNumJokerBoxer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7824); }
    }

    /// <summary>
    /// IntProperty: StoredNumRiddlerMech
    /// </summary>
    public unsafe int StoredNumRiddlerMech
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7828); }
    }

    /// <summary>
    /// IntProperty: StoredNumPyg
    /// </summary>
    public unsafe int StoredNumPyg
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7832); }
    }

    /// <summary>
    /// IntProperty: StoredNumBlackfire
    /// </summary>
    public unsafe int StoredNumBlackfire
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7836); }
    }

    /// <summary>
    /// IntProperty: StoredNumBats
    /// </summary>
    public unsafe int StoredNumBats
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7840); }
    }

    /// <summary>
    /// IntProperty: StoredNumKnives
    /// </summary>
    public unsafe int StoredNumKnives
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7844); }
    }

    /// <summary>
    /// IntProperty: StoredNumShields
    /// </summary>
    public unsafe int StoredNumShields
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7848); }
    }

    /// <summary>
    /// IntProperty: StoredNumStunSticks
    /// </summary>
    public unsafe int StoredNumStunSticks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7852); }
    }

    /// <summary>
    /// IntProperty: StoredNumGuns
    /// </summary>
    public unsafe int StoredNumGuns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7856); }
    }

    /// <summary>
    /// IntProperty: StoredNumCrates
    /// </summary>
    public unsafe int StoredNumCrates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7860); }
    }

    /// <summary>
    /// StructProperty: StoredPredatorXPInfo
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.FPredatorXPInfo StoredPredatorXPInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.FPredatorXPInfo>(Ptr + 7864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7864); }
    }

    /// <summary>
    /// IntProperty: HitsSinceCounter
    /// </summary>
    public unsafe int HitsSinceCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7936); }
    }

    /// <summary>
    /// IntProperty: ChargesSinceBatarang
    /// </summary>
    public unsafe int ChargesSinceBatarang
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7940); }
    }

    /// <summary>
    /// IntProperty: SetComboFrames
    /// </summary>
    public unsafe int SetComboFrames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7944); }
    }

    /// <summary>
    /// IntProperty: ShowCriticalFrames
    /// </summary>
    public unsafe int ShowCriticalFrames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7948); }
    }

    /// <summary>
    /// IntProperty: CriticalComboChain
    /// </summary>
    public unsafe int CriticalComboChain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7952); }
    }

    /// <summary>
    /// FloatProperty: NotInCombatTimer
    /// </summary>
    public unsafe float NotInCombatTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7956); }
    }

    /// <summary>
    /// IntProperty: BlockedByArmouredSinceBeatdown
    /// </summary>
    public unsafe int BlockedByArmouredSinceBeatdown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7960); }
    }

    /// <summary>
    /// IntProperty: BlockedByMultiStageSinceBeatdown
    /// </summary>
    public unsafe int BlockedByMultiStageSinceBeatdown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7964); }
    }

    /// <summary>
    /// IntProperty: RepelledByMultiStageSinceBeatdown
    /// </summary>
    public unsafe int RepelledByMultiStageSinceBeatdown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7968); }
    }

    /// <summary>
    /// IntProperty: BlockedByShieldSinceAerial
    /// </summary>
    public unsafe int BlockedByShieldSinceAerial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7972); }
    }

    /// <summary>
    /// IntProperty: BlockedByTitanSinceSuperStun
    /// </summary>
    public unsafe int BlockedByTitanSinceSuperStun
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7976); }
    }

    /// <summary>
    /// IntProperty: StunStickHits
    /// </summary>
    public unsafe int StunStickHits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7980); }
    }

    /// <summary>
    /// IntProperty: BladeHits
    /// </summary>
    public unsafe int BladeHits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7984); }
    }

    /// <summary>
    /// ArrayProperty: ComboValueReachedActions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSeqAct_ComboValueReached> ComboValueReachedActions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSeqAct_ComboValueReached>>(Ptr + 7988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7988); }
    }

    /// <summary>
    /// IntProperty: ConsecutiveBatarangsOrRedirects
    /// </summary>
    public unsafe int ConsecutiveBatarangsOrRedirects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8004); }
    }

    /// <summary>
    /// StrProperty: CombatBonusSummaryString
    /// </summary>
    public unsafe BmSDK.FString CombatBonusSummaryString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 8008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8008); }
    }

    /// <summary>
    /// FloatProperty: CombatBonusDelayTime
    /// </summary>
    public unsafe float CombatBonusDelayTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8024); }
    }

    /// <summary>
    /// StructProperty: LastAttacked
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerControllerCombat.FStruckInfo LastAttacked
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerControllerCombat.FStruckInfo>(Ptr + 8028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8028); }
    }

    /// <summary>
    /// ArrayProperty: ComboMoves
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPlayerControllerCombat.FComboMoveInfo> ComboMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPlayerControllerCombat.FComboMoveInfo>>(Ptr + 8040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8040); }
    }

    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8056); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8060); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8064); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8068); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8072); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8076); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8080); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8084); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8088); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8092); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8096); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8100); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8104); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8108); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8112); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8116); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8120); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8124); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8128); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8132); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8136); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8140); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8144); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8148); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8152); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8156); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8160); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8164); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8168); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_29
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8172); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_30
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8176); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_31
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8180); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_32
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8184); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_33
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8188); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_34
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8192); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_35
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8196); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_36
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8200); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_37
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8204); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_38
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8208); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_39
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8212); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_40
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8216); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_41
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8220); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_42
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8224); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_43
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8228); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_44
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8232); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_45
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8236); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_46
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8240); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_47
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8244); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_48
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8248); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_49
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8252); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_50
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8256); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_51
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8260); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_52
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8264); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_53
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8268); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_54
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8272); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_55
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8276); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_56
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8280); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_57
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8284); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_58
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8288); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_59
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8292); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_60
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8296); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_61
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8300); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_62
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8304); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_63
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8308); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_64
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8312); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_65
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8316); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_66
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8320); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_67
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8324); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_68
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8328); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_69
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8332); }
    }
    /// <summary>
    /// IntProperty: MoveTypeCount
    /// </summary>
    public unsafe int MoveTypeCount_70
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8336); }
    }

    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8340); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8344); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8348); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8352); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8356); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8360); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8364); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8368); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8372); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8376); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8380); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8384); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8388); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8392); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8396); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8400); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8404); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8408); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8412); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8416); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8420); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8424); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8428); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8432); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8436); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8440); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8444); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8448); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8452); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_29
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8456); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_30
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8460); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_31
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8464); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_32
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8468); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_33
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8472); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_34
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8476); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_35
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8480); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_36
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8484); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_37
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8488); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_38
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8492); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_39
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8496); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_40
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8500); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_41
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8504); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_42
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8508); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_43
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8512); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_44
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8516); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_45
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8520); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_46
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8524); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_47
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8528); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_48
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8532); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_49
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8536); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_50
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8540); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_51
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8544); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_52
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8548); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_53
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8552); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_54
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8556); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_55
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8560); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_56
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8564); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_57
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8568); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_58
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8572); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_59
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8576); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_60
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8580); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_61
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8584); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_62
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8588); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_63
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8592); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_64
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8596); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_65
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8600); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_66
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8604); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_67
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8608); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_68
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8612); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_69
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8616); }
    }
    /// <summary>
    /// IntProperty: ComboMoveType
    /// </summary>
    public unsafe int ComboMoveType_70
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8620); }
    }

    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8624); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8628); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8632); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8636); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8640); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8644); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8648); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8652); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8656); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8660); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8664); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8668); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8672); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8676); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8680); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8684); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8688); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8692); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8696); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8700); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8704); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8708); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8712); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8716); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8720); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8724); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8728); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8732); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8736); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_29
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8740); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_30
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8744); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_31
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8748); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_32
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8752); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_33
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8756); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_34
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8760); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_35
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8764); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_36
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8768); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_37
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8772); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_38
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8776); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_39
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8780); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_40
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8784); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_41
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8788); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_42
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8792); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_43
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8796); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_44
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8800); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_45
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8804); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_46
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8808); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_47
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8812); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_48
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8816); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_49
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8820); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_50
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8824); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_51
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8828); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_52
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8832); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_53
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8836); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_54
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8840); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_55
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8844); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_56
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8848); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_57
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8852); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_58
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8856); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_59
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8860); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_60
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8864); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_61
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8868); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_62
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8872); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_63
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8876); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_64
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8880); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_65
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8884); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_66
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8888); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_67
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8892); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_68
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8896); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_69
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8900); }
    }
    /// <summary>
    /// IntProperty: GadgetMoveType
    /// </summary>
    public unsafe int GadgetMoveType_70
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8904); }
    }

    /// <summary>
    /// FloatProperty: CurrentLookAtTargetTime
    /// </summary>
    public unsafe float CurrentLookAtTargetTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8908); }
    }

    /// <summary>
    /// IntProperty: FrontCounters
    /// </summary>
    public unsafe int FrontCounters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8912); }
    }

    /// <summary>
    /// IntProperty: BackCounters
    /// </summary>
    public unsafe int BackCounters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8916); }
    }

    /// <summary>
    /// FloatProperty: CurrCombatCamDistModifier
    /// </summary>
    public unsafe float CurrCombatCamDistModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8920); }
    }

    /// <summary>
    /// FloatProperty: CurrSuperComboPPAmount
    /// </summary>
    public unsafe float CurrSuperComboPPAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8924); }
    }

    /// <summary>
    /// FloatProperty: SniperPPVal
    /// </summary>
    public unsafe float SniperPPVal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8928); }
    }

    /// <summary>
    /// FloatProperty: lastSniperPPUpdateTime
    /// </summary>
    public unsafe float lastSniperPPUpdateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8932); }
    }

    /// <summary>
    /// FloatProperty: MaxVariationSpeedMulti
    /// </summary>
    public unsafe float MaxVariationSpeedMulti
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8936); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceLastStrikeRequest
    /// </summary>
    public unsafe float TimeSinceLastStrikeRequest
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8940); }
    }

    /// <summary>
    /// FloatProperty: FixedCombatCam_NoBaseTimer
    /// </summary>
    public unsafe float FixedCombatCam_NoBaseTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8944); }
    }

    /// <summary>
    /// StrProperty: OverridenDeathTip
    /// </summary>
    public unsafe BmSDK.FString OverridenDeathTip
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 8948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8948); }
    }

    /// <summary>
    /// ArrayProperty: ClearComboReasons
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ClearComboReasons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 8964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8964); }
    }

    /// <summary>
    /// StrProperty: LastClearComboReason
    /// </summary>
    public unsafe BmSDK.FString LastClearComboReason
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 8980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8980); }
    }

    /// <summary>
    /// FloatProperty: lastFlashBangHitTime
    /// </summary>
    public unsafe float lastFlashBangHitTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8996); }
    }
}
