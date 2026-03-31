#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPawnBossRasBase<br/>
/// (size = 3884)
/// (flags = 144703670)
/// </summary>
public partial class RPawnBossRasBase : BmSDK.BmGame.RPawnVillainNinjaBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnBossRasBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPawnBossRasBase.
    /// </summary>
    public static RPawnBossRasBase DefaultObject => (RPawnBossRasBase)StaticClass().DefaultObject;

    internal RPawnBossRasBase() { }

    /// <summary>
    /// Constructs a new RPawnBossRasBase
    /// </summary>
    public RPawnBossRasBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPawnBossRasBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnBossRasBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnBossRasBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnBossRasBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnBossRasBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnBossRasBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnBossRasBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnBossRasBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnBossRasBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnBossRasBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: GetBurstOutEvent
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkEvent GetBurstOutEvent()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.GetBurstOutEvent", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetElectricutedEvent
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkEvent GetElectricutedEvent()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.GetElectricutedEvent", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetHitEvent
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkEvent GetHitEvent()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.GetHitEvent", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetShurikanHitSandEvent
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkEvent GetShurikanHitSandEvent()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.GetShurikanHitSandEvent", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetShurikanLoopEvent
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkEvent GetShurikanLoopEvent()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.GetShurikanLoopEvent", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetShurikanStopEvent
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkEvent GetShurikanStopEvent()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.GetShurikanStopEvent", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetBladeClusterHitBMEvent
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkEvent GetBladeClusterHitBMEvent()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.GetBladeClusterHitBMEvent", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetBladeClusterStopEvent
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkEvent GetBladeClusterStopEvent()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.GetBladeClusterStopEvent", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetBladeClusterFireEvent
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkEvent GetBladeClusterFireEvent()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.GetBladeClusterFireEvent", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetBladeClusterSpawnEvent
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkEvent GetBladeClusterSpawnEvent()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.GetBladeClusterSpawnEvent", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IntroTaunt
    /// </summary>
    public unsafe virtual void IntroTaunt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.IntroTaunt", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GiantAppearTaunt
    /// </summary>
    public unsafe virtual void GiantAppearTaunt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.GiantAppearTaunt", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShouldForceBeatDown
    /// </summary>
    public unsafe override bool ShouldForceBeatDown()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.ShouldForceBeatDown", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetForceIsInBeatdown
    /// </summary>
    public unsafe virtual void SetForceIsInBeatdown(bool bBeatdown)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.SetForceIsInBeatdown", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBeatdown, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowRECHelp
    /// </summary>
    public unsafe virtual void ShowRECHelp()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.ShowRECHelp", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TrySpawnDemonBlastAttack
    /// </summary>
    public unsafe virtual bool TrySpawnDemonBlastAttack()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.TrySpawnDemonBlastAttack", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: TrySpawnChopAttack
    /// </summary>
    public unsafe virtual bool TrySpawnChopAttack()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.TrySpawnChopAttack", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ClearLookAtPawn
    /// </summary>
    public unsafe virtual void ClearLookAtPawn()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.ClearLookAtPawn", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ImpactSmall
    /// </summary>
    public unsafe virtual void ImpactSmall()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.ImpactSmall", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ImpactStrong
    /// </summary>
    public unsafe virtual void ImpactStrong(bool bScreenShake = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.ImpactStrong", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bScreenShake, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShouldBlindFireBatarang
    /// </summary>
    public unsafe virtual bool ShouldBlindFireBatarang()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.ShouldBlindFireBatarang", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CanTeleport
    /// </summary>
    public unsafe virtual bool CanTeleport()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.CanTeleport", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ResetMaterials
    /// </summary>
    public unsafe virtual void ResetMaterials(BmSDK.Engine.SkeletalMeshComponent SMesh)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.ResetMaterials", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SMesh, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.Tick", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShouldGetUpWhenHitFloor
    /// </summary>
    public unsafe override bool ShouldGetUpWhenHitFloor()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.ShouldGetUpWhenHitFloor", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: UpdateDesintegrate
    /// </summary>
    public unsafe virtual bool UpdateDesintegrate(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.UpdateDesintegrate", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: SetDestroyPending
    /// </summary>
    public unsafe virtual void SetDestroyPending()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.SetDestroyPending", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnChargeComplete
    /// </summary>
    public unsafe virtual void OnChargeComplete()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.OnChargeComplete", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetCombatBehaviourState
    /// </summary>
    public unsafe virtual void SetCombatBehaviourState(BmSDK.FName NewState)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.SetCombatBehaviourState", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HideToBurstOut
    /// </summary>
    public unsafe virtual void HideToBurstOut()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.HideToBurstOut", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GotoLandAndCharge
    /// </summary>
    public unsafe virtual void GotoLandAndCharge()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.GotoLandAndCharge", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnFuryAttack
    /// </summary>
    public unsafe virtual void SpawnFuryAttack(bool bDoSmokeBomb = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.SpawnFuryAttack", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoSmokeBomb, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnDoneHide
    /// </summary>
    public unsafe virtual void OnDoneHide()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.OnDoneHide", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnStartedHide
    /// </summary>
    public unsafe virtual void OnStartedHide()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.OnStartedHide", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsHideDone
    /// </summary>
    public unsafe virtual bool IsHideDone()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.IsHideDone", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: Hidden
    /// </summary>
    public unsafe virtual void Hidden()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.Hidden", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartHide
    /// </summary>
    public unsafe virtual void StartHide(BmSDK.FName OnDoneHideFunc, System.Numerics.Vector3 HideLoc, bool bInstant = default, float HideTime = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.StartHide", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OnDoneHideFunc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HideLoc, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInstant, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HideTime, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnDesintegrateParticles
    /// </summary>
    public unsafe virtual void SpawnDesintegrateParticles(bool bPlaySfx = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.SpawnDesintegrateParticles", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlaySfx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayChargeInSpeech
    /// </summary>
    public unsafe virtual void PlayChargeInSpeech()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.PlayChargeInSpeech", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnSpectral
    /// </summary>
    public unsafe virtual void SpawnSpectral()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.SpawnSpectral", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetRealRas
    /// </summary>
    public unsafe virtual void SetRealRas()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.SetRealRas", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnCombatMoveExit
    /// </summary>
    public unsafe virtual void OnCombatMoveExit()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.OnCombatMoveExit", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetSandMesh
    /// </summary>
    public unsafe virtual void SetSandMesh()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.SetSandMesh", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetDefaultMesh
    /// </summary>
    public unsafe virtual void SetDefaultMesh(bool bPlayPfx = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.SetDefaultMesh", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayPfx, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DeactivateSandFieldFX
    /// </summary>
    public unsafe virtual void DeactivateSandFieldFX()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.DeactivateSandFieldFX", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ActivateSandFieldFX
    /// </summary>
    public unsafe virtual void ActivateSandFieldFX()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.ActivateSandFieldFX", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DeactivatePrecursor
    /// </summary>
    public unsafe virtual void DeactivatePrecursor()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.DeactivatePrecursor", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ActivatePrecursor
    /// </summary>
    public unsafe virtual void ActivatePrecursor()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.ActivatePrecursor", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DeactivateAura
    /// </summary>
    public unsafe virtual void DeactivateAura()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.DeactivateAura", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ActivateAura
    /// </summary>
    public unsafe virtual void ActivateAura()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.ActivateAura", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DeactivateWaistBlendFX
    /// </summary>
    public unsafe virtual void DeactivateWaistBlendFX()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.DeactivateWaistBlendFX", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ActivateWaistBlendFX
    /// </summary>
    public unsafe virtual void ActivateWaistBlendFX()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.ActivateWaistBlendFX", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetBatmanMovement
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnBossRasBase.EBatmanMovement GetBatmanMovement()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.GetBatmanMovement", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnBossRasBase.EBatmanMovement>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SpawnChopAttackBarrier
    /// </summary>
    public unsafe virtual void SpawnChopAttackBarrier(System.Numerics.Vector3 SwordLoc, BmSDK.Rotator SwordRot)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.SpawnChopAttackBarrier", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SwordLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SwordRot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetSwordRotation
    /// </summary>
    public unsafe virtual BmSDK.Rotator GetSwordRotation()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.GetSwordRotation", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetSwordLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetSwordLocation()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.GetSwordLocation", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsRasHit
    /// </summary>
    public unsafe virtual bool IsRasHit()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.IsRasHit", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: HitSwordWall
    /// </summary>
    public unsafe virtual void HitSwordWall()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.HitSwordWall", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShieldTurnToProtect
    /// </summary>
    public unsafe virtual void ShieldTurnToProtect()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.ShieldTurnToProtect", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ActivateShield
    /// </summary>
    public unsafe virtual void ActivateShield(bool bMultiGaps)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.ActivateShield", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMultiGaps, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TripAnyGooMines
    /// </summary>
    public unsafe virtual void TripAnyGooMines()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.TripAnyGooMines", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnHitReaction
    /// </summary>
    public unsafe virtual void SpawnHitReaction(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo, BmSDK.FName MovementStance)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.SpawnHitReaction", true);
        byte* paramsPtr = stackalloc byte[252];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 244);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnChopAttack
    /// </summary>
    public unsafe virtual void SpawnChopAttack()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.SpawnChopAttack", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnSwordAttack
    /// </summary>
    public unsafe virtual void SpawnSwordAttack(BmSDK.FName SummonPose, BmSDK.FName Transition)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.SpawnSwordAttack", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SummonPose, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Transition, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnChargeAttack
    /// </summary>
    public unsafe virtual void SpawnChargeAttack()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.SpawnChargeAttack", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnMoveDemonBlast
    /// </summary>
    public unsafe virtual void SpawnMoveDemonBlast()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.SpawnMoveDemonBlast", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetMeshMaterial
    /// </summary>
    public unsafe virtual void SetMeshMaterial(BmSDK.Engine.SkeletalMeshComponent TargetMesh, BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant> BodyOverrideMaterials)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossRasBase.SetMeshMaterial", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetMesh, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BodyOverrideMaterials, paramsPtr + 4);
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
    /// Enum: EBatmanMovement
    /// </summary>
    public enum EBatmanMovement
    {
        EBM_None = 0,
        EBM_Clockwise = 1,
        EBM_AntiClockwise = 2,
        EBM_ClockwiseRun = 3,
        EBM_AntiClockwiseRun = 4,
        EBM_MAX = 5,
    }

    /// <summary>
    /// ObjectProperty: BossController
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_RasBossLogicBase BossController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_RasBossLogicBase>(Ptr + 3600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3600); }
    }

    /// <summary>
    /// ObjectProperty: CombatBehaviour
    /// </summary>
    public unsafe BmSDK.BmGame.RBMBehaviour_CombatRas CombatBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMBehaviour_CombatRas>(Ptr + 3604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3604); }
    }

    /// <summary>
    /// ClassProperty: TakeHostageBehaviourClass
    /// </summary>
    public unsafe BmSDK.Class TakeHostageBehaviourClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 3608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3608); }
    }

    /// <summary>
    /// BoolProperty: bIsRealRas
    /// </summary>
    public unsafe bool bIsRealRas
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3612) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3612); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3612); }
    }

    /// <summary>
    /// BoolProperty: bDemonBlast
    /// </summary>
    public unsafe bool bDemonBlast
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3612) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3612); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3612); }
    }

    /// <summary>
    /// BoolProperty: bDestroyPending
    /// </summary>
    public unsafe bool bDestroyPending
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3612) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3612); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3612); }
    }

    /// <summary>
    /// BoolProperty: bDoIntroCharge
    /// </summary>
    public unsafe bool bDoIntroCharge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3612) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3612); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3612); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreGadgetHit
    /// </summary>
    public unsafe bool bIgnoreGadgetHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3612) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3612); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3612); }
    }

    /// <summary>
    /// ComponentProperty: MagBlastOverride
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionComponent MagBlastOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionComponent>(Ptr + 3616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3616); }
    }

    /// <summary>
    /// ComponentProperty: ChargeUpFXComp
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ChargeUpFXComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 3620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3620); }
    }

    /// <summary>
    /// ObjectProperty: FireDemonBlastFx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem FireDemonBlastFx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 3624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3624); }
    }

    /// <summary>
    /// ObjectProperty: DestroyedFx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem DestroyedFx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 3628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3628); }
    }

    /// <summary>
    /// ObjectProperty: DemonBlastImpactFx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem DemonBlastImpactFx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 3632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3632); }
    }

    /// <summary>
    /// ObjectProperty: DemonBlastImpactSandFx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem DemonBlastImpactSandFx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 3636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3636); }
    }

    /// <summary>
    /// ObjectProperty: DemonBlastImpactBatarangFx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem DemonBlastImpactBatarangFx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 3640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3640); }
    }

    /// <summary>
    /// ObjectProperty: ChargeBuildUpFx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ChargeBuildUpFx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 3644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3644); }
    }

    /// <summary>
    /// ObjectProperty: ShurikanChargeUp
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ShurikanChargeUp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 3648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3648); }
    }

    /// <summary>
    /// ObjectProperty: AttackSwordFx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem AttackSwordFx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 3652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3652); }
    }

    /// <summary>
    /// ObjectProperty: AttackSwordHitFx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem AttackSwordHitFx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 3656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3656); }
    }

    /// <summary>
    /// ObjectProperty: ChargingFx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ChargingFx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 3660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3660); }
    }

    /// <summary>
    /// ObjectProperty: PrecursorFx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem PrecursorFx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 3664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3664); }
    }

    /// <summary>
    /// ObjectProperty: SandFieldFx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem SandFieldFx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 3668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3668); }
    }

    /// <summary>
    /// ObjectProperty: SwordImpactBMVfx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem SwordImpactBMVfx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 3672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3672); }
    }

    /// <summary>
    /// ObjectProperty: SwordImpactEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent SwordImpactEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 3676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3676); }
    }

    /// <summary>
    /// ClassProperty: LastAttackClass
    /// </summary>
    public unsafe BmSDK.Class LastAttackClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 3680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3680); }
    }

    /// <summary>
    /// IntProperty: LastSwordSlot
    /// </summary>
    public unsafe int LastSwordSlot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3684); }
    }

    /// <summary>
    /// ClassProperty: FinalAttackClass
    /// </summary>
    public unsafe BmSDK.Class FinalAttackClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 3688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3688); }
    }

    /// <summary>
    /// ClassProperty: SwordGrabCounterClass
    /// </summary>
    public unsafe BmSDK.Class SwordGrabCounterClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 3692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3692); }
    }

    /// <summary>
    /// ClassProperty: FuryAttackClass
    /// </summary>
    public unsafe BmSDK.Class FuryAttackClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 3696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3696); }
    }

    /// <summary>
    /// ClassProperty: GiantBladeClass
    /// </summary>
    public unsafe BmSDK.Class GiantBladeClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 3700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3700); }
    }

    /// <summary>
    /// ObjectProperty: PairedAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PairedAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3704); }
    }

    /// <summary>
    /// ObjectProperty: BMPairedAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet BMPairedAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3708); }
    }

    /// <summary>
    /// ObjectProperty: CamAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet CamAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3712); }
    }

    /// <summary>
    /// ObjectProperty: BurlyHitAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet BurlyHitAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3716); }
    }

    /// <summary>
    /// StructProperty: HideLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 HideLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3720);

    /// <summary>
    /// FloatProperty: LastFuryJumpInYaw
    /// </summary>
    public unsafe float LastFuryJumpInYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3732); }
    }

    /// <summary>
    /// IntProperty: LastFurySpeech
    /// </summary>
    public unsafe int LastFurySpeech
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3736); }
    }

    /// <summary>
    /// StructProperty: ImpactScreenShake
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct ImpactScreenShake
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 3740);
}
