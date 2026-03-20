#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RVehicleHeavyTank<br/>
/// (size = 8728)
/// (flags = 144704182)
/// </summary>
public partial class RVehicleHeavyTank : BmSDK.BmGame.RVehicleTank, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RVehicleHeavyTank", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RVehicleHeavyTank() { }

    /// <summary>
    /// Constructs a new RVehicleHeavyTank
    /// </summary>
    public RVehicleHeavyTank(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RVehicleHeavyTank Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicleHeavyTank(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleHeavyTank>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleHeavyTank>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleHeavyTank>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleHeavyTank>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleHeavyTank>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleHeavyTank>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleHeavyTank>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: NoReplanBackToIsland
    /// </summary>
    public unsafe virtual void NoReplanBackToIsland()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.NoReplanBackToIsland", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DeathExplosionRumble
    /// </summary>
    public unsafe override void DeathExplosionRumble()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.DeathExplosionRumble", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanBasePawn
    /// </summary>
    public unsafe override bool CanBasePawn(BmSDK.Engine.Pawn P)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.CanBasePawn", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: UnBlind
    /// </summary>
    public unsafe override void UnBlind()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.UnBlind", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Blind
    /// </summary>
    public unsafe override void Blind(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.Blind", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateAttackWarningModifier
    /// </summary>
    public unsafe override void UpdateAttackWarningModifier()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.UpdateAttackWarningModifier", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetLockedOntoPlayer
    /// </summary>
    public unsafe virtual void SetLockedOntoPlayer(bool LockedOn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.SetLockedOntoPlayer", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LockedOn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DebugDestroyAllWeakPoints
    /// </summary>
    public unsafe virtual void DebugDestroyAllWeakPoints()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.DebugDestroyAllWeakPoints", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BatmobileLost
    /// </summary>
    public unsafe virtual void BatmobileLost()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.BatmobileLost", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BatmobileSpotted
    /// </summary>
    public unsafe virtual void BatmobileSpotted()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.BatmobileSpotted", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayStagedBasedDialogue
    /// </summary>
    public unsafe virtual void PlayStagedBasedDialogue(BmSDK.BmGame.RVehicleHeavyTank.ECommandTankStageBasedDialogue Dialogue)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.PlayStagedBasedDialogue", true);
        byte* paramsPtr = stackalloc byte[140];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Dialogue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetDialogueStage
    /// </summary>
    public unsafe virtual int GetDialogueStage()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.GetDialogueStage", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: MakeCloudburstVulnerable
    /// </summary>
    public unsafe virtual void MakeCloudburstVulnerable()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.MakeCloudburstVulnerable", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetCloudburstState
    /// </summary>
    public unsafe virtual void SetCloudburstState(int WeakPointsRemaining)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.SetCloudburstState", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeakPointsRemaining, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowHeat
    /// </summary>
    public unsafe virtual void ShowHeat()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.ShowHeat", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: WeakPointHit
    /// </summary>
    public unsafe virtual void WeakPointHit(int EyeHit)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.WeakPointHit", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EyeHit, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: EyeShot
    /// </summary>
    public unsafe override bool EyeShot(int EyeHit)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.EyeShot", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EyeHit, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: TickWeakPoints
    /// </summary>
    public unsafe virtual void TickWeakPoints(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.TickWeakPoints", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ScanWeakPoints
    /// </summary>
    public unsafe virtual void ScanWeakPoints(System.Numerics.Vector3 ScanOrigin)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.ScanWeakPoints", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScanOrigin, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: MakeWeakPointVisible
    /// </summary>
    public unsafe virtual void MakeWeakPointVisible(int I)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.MakeWeakPointVisible", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(I, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ScanningFinished
    /// </summary>
    public unsafe virtual void ScanningFinished()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.ScanningFinished", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StopForAttacking
    /// </summary>
    public unsafe virtual bool StopForAttacking()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.StopForAttacking", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetNumSimultaneousAttackSlots
    /// </summary>
    public unsafe override int GetNumSimultaneousAttackSlots(int WeaponIndex)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.GetNumSimultaneousAttackSlots", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetShootTarget
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetShootTarget(BmSDK.Engine.Actor Target)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.GetShootTarget", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: IsAttacking
    /// </summary>
    public unsafe override bool IsAttacking()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.IsAttacking", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: StartAttack
    /// </summary>
    public unsafe override bool StartAttack(BmSDK.Engine.Actor Target, float WarningTime, System.Numerics.Vector3 AttackLoc = default, int WeaponIndex = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.StartAttack", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WarningTime, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttackLoc, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponIndex, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 28);
    }

    /// <summary>
    /// Function: SetCurrentBossStage
    /// </summary>
    public unsafe virtual void SetCurrentBossStage(int CurrentStage)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.SetCurrentBossStage", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentStage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FireNow
    /// </summary>
    public unsafe override void FireNow()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.FireNow", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateDamageFromEMP
    /// </summary>
    public unsafe override void UpdateDamageFromEMP(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.UpdateDamageFromEMP", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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
    /// Function: TakeDamageFromEMP
    /// </summary>
    public unsafe override void TakeDamageFromEMP(BmSDK.Engine.Controller DamageInstigator, float DamageDuration)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.TakeDamageFromEMP", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageInstigator, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageDuration, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OverrideVehicleTakedown
    /// </summary>
    public unsafe override bool OverrideVehicleTakedown(BmSDK.BmGame.RPawnPlayer Player)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.OverrideVehicleTakedown", true);
        byte* paramsPtr = stackalloc byte[144];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: TickAimAndShootAtBatman
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 TickAimAndShootAtBatman(float DeltaTime, float CombatRange, System.Numerics.Vector3 ScanDirIn, bool ScanTurnsTurret = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.TickAimAndShootAtBatman", true);
        byte* paramsPtr = stackalloc byte[112];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CombatRange, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScanDirIn, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScanTurnsTurret, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: DisableShield
    /// </summary>
    public unsafe virtual void DisableShield()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.DisableShield", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ProjectBounds
    /// </summary>
    public unsafe virtual void ProjectBounds(BmSDK.BmGame.RPlayerController RPC, System.Numerics.Vector3 TargetLoc, float TargetRadiusHorz, float TargetRadiusVert, out System.Numerics.Vector2 OutMin, out System.Numerics.Vector2 OutMax)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.ProjectBounds", true);
        byte* paramsPtr = stackalloc byte[116];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLoc, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetRadiusHorz, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetRadiusVert, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutMin = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(paramsPtr + 28);
        OutMax = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(paramsPtr + 36);
        return;
    }

    /// <summary>
    /// Function: CheckVisibility
    /// </summary>
    public unsafe virtual bool CheckVisibility(BmSDK.BmGame.RPlayerController RPC, out int FailReason)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.CheckVisibility", true);
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        FailReason = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: Died
    /// </summary>
    public unsafe override bool Died(BmSDK.Engine.Controller Killer, BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.Died", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 28);
    }

    /// <summary>
    /// Function: CanAttackTarget
    /// </summary>
    public unsafe override BmSDK.BmGame.RVehicleNPC.ECanAttackTargetResult CanAttackTarget(BmSDK.Engine.Actor Target, int WeaponID)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.CanAttackTarget", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponID, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPC.ECanAttackTargetResult>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: UpdateLaserAudioSource
    /// </summary>
    public unsafe virtual void UpdateLaserAudioSource(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.UpdateLaserAudioSource", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.Tick", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetScanLaserActive
    /// </summary>
    public unsafe virtual void SetScanLaserActive(bool OnOrOff)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.SetScanLaserActive", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OnOrOff, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetScanLaserScale
    /// </summary>
    public unsafe virtual void SetScanLaserScale(float Scale)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.SetScanLaserScale", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Scale, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RigidBodyCollision
    /// </summary>
    public unsafe override void RigidBodyCollision(BmSDK.Engine.PrimitiveComponent HitComponent, BmSDK.Engine.PrimitiveComponent OtherComponent, out BmSDK.Engine.Actor.FCollisionImpactData RigidCollisionData, int ContactIndex, float Speed, int Index0, int Index1)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.RigidBodyCollision", true);
        byte* paramsPtr = stackalloc byte[128];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitComponent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComponent, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContactIndex, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speed, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index0, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index1, paramsPtr + 68);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        RigidCollisionData = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor.FCollisionImpactData>(paramsPtr + 16);
        return;
    }

    /// <summary>
    /// Function: GetComboTimer
    /// </summary>
    public unsafe override float GetComboTimer()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.GetComboTimer", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetMissileTargetLocation
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetMissileTargetLocation()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.GetMissileTargetLocation", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetWeaponLockOnLocation
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetWeaponLockOnLocation(out int InSight)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.GetWeaponLockOnLocation", true);
        byte* paramsPtr = stackalloc byte[76];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        InSight = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: DetachWeakPoint
    /// </summary>
    public unsafe virtual void DetachWeakPoint()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.DetachWeakPoint", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AttachWeakPoint
    /// </summary>
    public unsafe virtual void AttachWeakPoint()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.AttachWeakPoint", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StopsProjectile
    /// </summary>
    public unsafe override bool StopsProjectile(BmSDK.Engine.Projectile P, BmSDK.Engine.PrimitiveComponent HitComponent = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.StopsProjectile", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitComponent, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: ShieldCooldown
    /// </summary>
    public unsafe virtual void ShieldCooldown()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.ShieldCooldown", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Touch
    /// </summary>
    public unsafe override void Touch(BmSDK.Engine.Actor Other, BmSDK.Engine.PrimitiveComponent OtherComp, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 HitNormal)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.Touch", true);
        byte* paramsPtr = stackalloc byte[88];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComp, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TakeDamage
    /// </summary>
    public unsafe override void TakeDamage(int DamageAmount, BmSDK.Engine.Controller EventInstigator, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.Engine.Actor.FTraceHitInfo HitInfo = default, BmSDK.Engine.Actor DamageCauser = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.TakeDamage", true);
        byte* paramsPtr = stackalloc byte[120];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageAmount, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventInstigator, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitInfo, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageCauser, paramsPtr + 84);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TakeDamageFromWeapon
    /// </summary>
    public unsafe override BmSDK.Engine.Actor.EWeaponDamageResult TakeDamageFromWeapon(int DamageAmount, BmSDK.Engine.Controller EventInstigator, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 HitNormal, System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.Engine.Actor.FTraceHitInfo HitInfo = default, BmSDK.Engine.Actor DamageCauser = default, bool bHeadShot = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.TakeDamageFromWeapon", true);
        byte* paramsPtr = stackalloc byte[109];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageAmount, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventInstigator, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitInfo, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageCauser, paramsPtr + 96);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHeadShot, paramsPtr + 104);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor.EWeaponDamageResult>(paramsPtr + 108);
    }

    /// <summary>
    /// Function: SetLightState
    /// </summary>
    public unsafe virtual void SetLightState(int LightState)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.SetLightState", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LightState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CancelAttack
    /// </summary>
    public unsafe override void CancelAttack(bool DueToBeingRammed)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.CancelAttack", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DueToBeingRammed, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PowerUp
    /// </summary>
    public unsafe virtual void PowerUp()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.PowerUp", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PoweredDownAnnounce
    /// </summary>
    public unsafe virtual void PoweredDownAnnounce()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.PoweredDownAnnounce", true);
        byte* paramsPtr = stackalloc byte[132];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PowerDown
    /// </summary>
    public unsafe virtual void PowerDown()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.PowerDown", true);
        byte* paramsPtr = stackalloc byte[136];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetWeakPointRevealed
    /// </summary>
    public unsafe virtual void SetWeakPointRevealed(bool Revealed)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.SetWeakPointRevealed", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Revealed, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleHeavyTank.PostBeginPlay", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FCommandTankDialogueCont
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FCommandTankDialogueCont
    {
        /// <summary>
        /// ArrayProperty: Lines
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.AkDialogueSpeech> Lines
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AkDialogueSpeech>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Enum: ECommandTankStageBasedDialogue
    /// </summary>
    public enum ECommandTankStageBasedDialogue
    {
        ESBD_WeakPointHit = 0,
        ESBD_BatmanSpotted = 1,
        ESBD_SearchOneShot = 2,
        ESBD_ChaseOneShot = 3,
        ESBD_ChaseBegins = 4,
        ESBD_ChaseEnds = 5,
        ESBD_MAX = 6,
    }

    /// <summary>
    /// Struct: FCommanderTankWeakPoint
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FCommanderTankWeakPoint
    {
        /// <summary>
        /// NameProperty: Socket
        /// </summary>
        public unsafe BmSDK.FName Socket
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: VisibleDuration
        /// </summary>
        public unsafe float VisibleDuration
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// BoolProperty: bDestroyed
        /// </summary>
        public unsafe bool bDestroyed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// ComponentProperty: WeakPointPS
        /// </summary>
        public unsafe BmSDK.Engine.ParticleSystemComponent WeakPointPS
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FCommanderTankStage
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public partial record struct FCommanderTankStage
    {
        /// <summary>
        /// ArrayProperty: AvailableWeapons
        /// </summary>
        public unsafe BmSDK.TArray<int> AvailableWeapons
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: MaxHealthPct
        /// </summary>
        public unsafe float MaxHealthPct
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: NextStageHealth
        /// </summary>
        public unsafe int NextStageHealth
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// FloatProperty: Duration
        /// </summary>
        public unsafe float Duration
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// IntProperty: NextStageTimeout
        /// </summary>
        public unsafe int NextStageTimeout
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// IntProperty: MinSimultaneousAttacks
        /// </summary>
        public unsafe int MinSimultaneousAttacks
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// FloatProperty: DifficultyMod
        /// </summary>
        public unsafe float DifficultyMod
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// FloatProperty: OverrideAttackInterval
        /// </summary>
        public unsafe float OverrideAttackInterval
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }
    }

    /// <summary>
    /// ComponentProperty: WeakPoint
    /// </summary>
    public unsafe BmSDK.Engine.PrimitiveComponent WeakPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PrimitiveComponent>(Ptr + 8112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8112); }
    }

    /// <summary>
    /// BoolProperty: HideWeakPointWhenPatrolling
    /// </summary>
    public unsafe bool HideWeakPointWhenPatrolling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// BoolProperty: DisableLaserCollision
    /// </summary>
    public unsafe bool DisableLaserCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// BoolProperty: Shielded
    /// </summary>
    public unsafe bool Shielded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// BoolProperty: bDrawScanLaserDebug
    /// </summary>
    public unsafe bool bDrawScanLaserDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// BoolProperty: WeakPointRevealed
    /// </summary>
    public unsafe bool WeakPointRevealed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// BoolProperty: DisallowEngageTarget
    /// </summary>
    public unsafe bool DisallowEngageTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// BoolProperty: bCloudburstVulnerable
    /// </summary>
    public unsafe bool bCloudburstVulnerable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// BoolProperty: bNoScanLasers
    /// </summary>
    public unsafe bool bNoScanLasers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// BoolProperty: bWeakPointsTargettable
    /// </summary>
    public unsafe bool bWeakPointsTargettable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// BoolProperty: bVulnderableOnStartup
    /// </summary>
    public unsafe bool bVulnderableOnStartup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// BoolProperty: bLockedOnToPlayer
    /// </summary>
    public unsafe bool bLockedOnToPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// BoolProperty: PlayedLostDialogueThisStage
    /// </summary>
    public unsafe bool PlayedLostDialogueThisStage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8120); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8120); }
    }

    /// <summary>
    /// FloatProperty: ScanRange
    /// </summary>
    public unsafe float ScanRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8124); }
    }

    /// <summary>
    /// ComponentProperty: ScannerLightSource
    /// </summary>
    public unsafe BmSDK.Engine.SpotLightComponent ScannerLightSource
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SpotLightComponent>(Ptr + 8128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8128); }
    }

    /// <summary>
    /// StructProperty: SearchLightColour
    /// </summary>
    public unsafe BmSDK.GameObject.FColor SearchLightColour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 8136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8136); }
    }

    /// <summary>
    /// StructProperty: Sweep360LightColour
    /// </summary>
    public unsafe BmSDK.GameObject.FColor Sweep360LightColour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 8140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8140); }
    }

    /// <summary>
    /// StructProperty: AttackLightColour
    /// </summary>
    public unsafe BmSDK.GameObject.FColor AttackLightColour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 8144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8144); }
    }

    /// <summary>
    /// ObjectProperty: ScanLaser
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleScanLaser ScanLaser
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleScanLaser>(Ptr + 8148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8148); }
    }

    /// <summary>
    /// ObjectProperty: BattleViewMaterialInst
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant BattleViewMaterialInst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 8156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8156); }
    }

    /// <summary>
    /// ObjectProperty: LightMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant LightMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 8164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8164); }
    }

    /// <summary>
    /// ObjectProperty: LaserAudible
    /// </summary>
    public unsafe BmSDK.Engine.RAkAudible LaserAudible
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAkAudible>(Ptr + 8172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8172); }
    }

    /// <summary>
    /// ObjectProperty: LaserEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent LaserEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 8180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8180); }
    }

    /// <summary>
    /// ObjectProperty: DisableShieldMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DisableShieldMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8188); }
    }

    /// <summary>
    /// ObjectProperty: ShieldImpactMat
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant ShieldImpactMat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 8196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8196); }
    }

    /// <summary>
    /// ObjectProperty: ShieldFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ShieldFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 8204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8204); }
    }

    /// <summary>
    /// ObjectProperty: MuzzleWarningFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem MuzzleWarningFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 8212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8212); }
    }

    /// <summary>
    /// ObjectProperty: BatmobileContactParticles
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem BatmobileContactParticles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 8220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8220); }
    }

    /// <summary>
    /// ObjectProperty: BatmobileContactSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent BatmobileContactSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 8228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8228); }
    }

    /// <summary>
    /// ObjectProperty: BossMovieInstance
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie BossMovieInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 8236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8236); }
    }

    /// <summary>
    /// ObjectProperty: TurretDestroyedMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMesh TurretDestroyedMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh>(Ptr + 8244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8244); }
    }

    /// <summary>
    /// ObjectProperty: CloudburstOverheatedLine
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech CloudburstOverheatedLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 8252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8252); }
    }

    /// <summary>
    /// ObjectProperty: PostScanLine
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech PostScanLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 8260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8260); }
    }

    /// <summary>
    /// ObjectProperty: PostPowerDownLine
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech PostPowerDownLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 8268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8268); }
    }

    /// <summary>
    /// ObjectProperty: EMPIneffectiveLine
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech EMPIneffectiveLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 8276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8276); }
    }

    /// <summary>
    /// ObjectProperty: CachedShutDownBehaviour
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBehaviour CachedShutDownBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBehaviour>(Ptr + 8284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8284); }
    }

    /// <summary>
    /// ObjectProperty: WeakPointTarget
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WeakPointTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 8292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8292); }
    }

    /// <summary>
    /// ObjectProperty: CloudburstCriticalOn
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent CloudburstCriticalOn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 8300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8300); }
    }

    /// <summary>
    /// ObjectProperty: CloudburstCriticalOff
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent CloudburstCriticalOff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 8308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8308); }
    }

    /// <summary>
    /// ObjectProperty: CloudburstCriticalValue
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName CloudburstCriticalValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 8316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8316); }
    }

    /// <summary>
    /// ObjectProperty: MainWeaponChargeSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent MainWeaponChargeSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 8324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8324); }
    }

    /// <summary>
    /// ObjectProperty: CloudburstMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant CloudburstMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 8332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8332); }
    }

    /// <summary>
    /// ObjectProperty: DeathExplosionWaveform
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform DeathExplosionWaveform
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 8340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8340); }
    }

    /// <summary>
    /// ComponentProperty: CloudburstPS
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent CloudburstPS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 8348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8348); }
    }

    /// <summary>
    /// ComponentProperty: TurretDestroyedPersistentPfx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent TurretDestroyedPersistentPfx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 8356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8356); }
    }

    /// <summary>
    /// ComponentProperty: TurretDestroyedPfx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent TurretDestroyedPfx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 8364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8364); }
    }

    /// <summary>
    /// ComponentProperty: TurretMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent TurretMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 8372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8372); }
    }

    /// <summary>
    /// ComponentProperty: Cloudburst
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent Cloudburst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 8380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8380); }
    }

    /// <summary>
    /// ComponentProperty: WeakPointMeshComp
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent WeakPointMeshComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 8388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8388); }
    }

    /// <summary>
    /// ComponentProperty: ShieldImpactComp
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent ShieldImpactComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 8396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8396); }
    }

    /// <summary>
    /// ComponentProperty: ShieldMeshComp
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent ShieldMeshComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 8404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8404); }
    }

    /// <summary>
    /// ComponentProperty: Shield
    /// </summary>
    public unsafe BmSDK.Engine.PrimitiveComponent Shield
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PrimitiveComponent>(Ptr + 8412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8412); }
    }

    /// <summary>
    /// NameProperty: ScannerSocker
    /// </summary>
    public unsafe BmSDK.FName ScannerSocker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8420); }
    }

    /// <summary>
    /// IntProperty: NumScanLasers
    /// </summary>
    public unsafe int NumScanLasers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8428); }
    }

    /// <summary>
    /// ArrayProperty: ActualLasers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicleScanLaser> ActualLasers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleScanLaser>>(Ptr + 8432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8432); }
    }

    /// <summary>
    /// IntProperty: CurrentCollisionLaser
    /// </summary>
    public unsafe int CurrentCollisionLaser
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8448); }
    }

    /// <summary>
    /// FloatProperty: WeakPointRadius
    /// </summary>
    public unsafe float WeakPointRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8452); }
    }

    /// <summary>
    /// FloatProperty: MaxLaserSoundVelocity
    /// </summary>
    public unsafe float MaxLaserSoundVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8456); }
    }

    /// <summary>
    /// ArrayProperty: LaserSoundPositions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AkWwise.FAkSourceSpatial> LaserSoundPositions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AkWwise.FAkSourceSpatial>>(Ptr + 8460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8460); }
    }

    /// <summary>
    /// FloatProperty: MuzzleWarningDuration
    /// </summary>
    public unsafe float MuzzleWarningDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8476); }
    }

    /// <summary>
    /// FloatProperty: BatmobileContactDamagePerSecond
    /// </summary>
    public unsafe float BatmobileContactDamagePerSecond
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8480); }
    }

    /// <summary>
    /// FloatProperty: BatmobileContactImpulse
    /// </summary>
    public unsafe float BatmobileContactImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8484); }
    }

    /// <summary>
    /// FloatProperty: ContactDamageDelay
    /// </summary>
    public unsafe float ContactDamageDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8488); }
    }

    /// <summary>
    /// FloatProperty: ScanForBatmanAngle
    /// </summary>
    public unsafe float ScanForBatmanAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8492); }
    }

    /// <summary>
    /// FloatProperty: VisibilityTimeMod
    /// </summary>
    public unsafe float VisibilityTimeMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8496); }
    }

    /// <summary>
    /// IntProperty: NumNonTurretLightMaterialInst
    /// </summary>
    public unsafe int NumNonTurretLightMaterialInst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8500); }
    }

    /// <summary>
    /// ArrayProperty: AllWeapons
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicleNPC.FWalkerWeaponContainer> AllWeapons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleNPC.FWalkerWeaponContainer>>(Ptr + 8504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8504); }
    }

    /// <summary>
    /// ArrayProperty: BossStages
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicleHeavyTank.FCommanderTankStage> BossStages
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleHeavyTank.FCommanderTankStage>>(Ptr + 8520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8520); }
    }

    /// <summary>
    /// FloatProperty: CloudburstHeat
    /// </summary>
    public unsafe float CloudburstHeat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8536); }
    }

    /// <summary>
    /// IntProperty: CurrentBossStage
    /// </summary>
    public unsafe int CurrentBossStage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8540); }
    }

    /// <summary>
    /// FloatProperty: StartingHealth
    /// </summary>
    public unsafe float StartingHealth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8544); }
    }

    /// <summary>
    /// FloatProperty: CurrentStageTimeout
    /// </summary>
    public unsafe float CurrentStageTimeout
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8548); }
    }

    /// <summary>
    /// ArrayProperty: WeakPoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicleHeavyTank.FCommanderTankWeakPoint> WeakPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleHeavyTank.FCommanderTankWeakPoint>>(Ptr + 8552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8552); }
    }

    /// <summary>
    /// ArrayProperty: WeakPointsDestroyedGotoStage
    /// </summary>
    public unsafe BmSDK.TArray<int> WeakPointsDestroyedGotoStage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 8568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8568); }
    }

    /// <summary>
    /// FloatProperty: PostPowerDownLineDelay
    /// </summary>
    public unsafe float PostPowerDownLineDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8584); }
    }

    /// <summary>
    /// StructProperty: StageBasedDialogue
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleHeavyTank.FCommandTankDialogueCont StageBasedDialogue_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleHeavyTank.FCommandTankDialogueCont>(Ptr + 8588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8588); }
    }
    /// <summary>
    /// StructProperty: StageBasedDialogue
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleHeavyTank.FCommandTankDialogueCont StageBasedDialogue_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleHeavyTank.FCommandTankDialogueCont>(Ptr + 8604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8604); }
    }
    /// <summary>
    /// StructProperty: StageBasedDialogue
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleHeavyTank.FCommandTankDialogueCont StageBasedDialogue_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleHeavyTank.FCommandTankDialogueCont>(Ptr + 8620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8620); }
    }
    /// <summary>
    /// StructProperty: StageBasedDialogue
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleHeavyTank.FCommandTankDialogueCont StageBasedDialogue_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleHeavyTank.FCommandTankDialogueCont>(Ptr + 8636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8636); }
    }
    /// <summary>
    /// StructProperty: StageBasedDialogue
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleHeavyTank.FCommandTankDialogueCont StageBasedDialogue_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleHeavyTank.FCommandTankDialogueCont>(Ptr + 8652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8652); }
    }
    /// <summary>
    /// StructProperty: StageBasedDialogue
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleHeavyTank.FCommandTankDialogueCont StageBasedDialogue_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleHeavyTank.FCommandTankDialogueCont>(Ptr + 8668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8668); }
    }

    /// <summary>
    /// ArrayProperty: CloudburstDamageTemplate
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.ParticleSystem> CloudburstDamageTemplate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.ParticleSystem>>(Ptr + 8684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8684); }
    }

    /// <summary>
    /// ArrayProperty: MaterialHeatValues
    /// </summary>
    public unsafe BmSDK.TArray<float> MaterialHeatValues
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 8700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8700); }
    }

    /// <summary>
    /// FloatProperty: PowerDownPowerBackUpDelay
    /// </summary>
    public unsafe float PowerDownPowerBackUpDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8716); }
    }

    /// <summary>
    /// NameProperty: LastAimSocket
    /// </summary>
    public unsafe BmSDK.FName LastAimSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8720); }
    }
}
