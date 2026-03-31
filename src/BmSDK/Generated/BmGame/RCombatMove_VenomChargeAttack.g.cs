#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RCombatMove_VenomChargeAttack<br/>
/// (size = 524)
/// (flags = 8388626)
/// </summary>
public partial class RCombatMove_VenomChargeAttack : BmSDK.BmGame.RCombatMove_VillainAttack, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCombatMove_VenomChargeAttack", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RCombatMove_VenomChargeAttack.
    /// </summary>
    public static RCombatMove_VenomChargeAttack DefaultObject => (RCombatMove_VenomChargeAttack)StaticClass().DefaultObject;

    internal RCombatMove_VenomChargeAttack() { }

    /// <summary>
    /// Constructs a new RCombatMove_VenomChargeAttack
    /// </summary>
    public RCombatMove_VenomChargeAttack(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCombatMove_VenomChargeAttack Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCombatMove_VenomChargeAttack(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VenomChargeAttack>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VenomChargeAttack>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VenomChargeAttack>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VenomChargeAttack>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VenomChargeAttack>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VenomChargeAttack>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VenomChargeAttack>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VenomChargeAttack>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: ExitMove
    /// </summary>
    public unsafe override void ExitMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCombatMove_VenomChargeAttack.ExitMove", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsBatmanInteruptable
    /// </summary>
    public unsafe virtual bool IsBatmanInteruptable()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCombatMove_VenomChargeAttack.IsBatmanInteruptable", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: StartTrack
    /// </summary>
    public unsafe virtual void StartTrack()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCombatMove_VenomChargeAttack.StartTrack", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DamagedBy
    /// </summary>
    public unsafe override BmSDK.BmGame.RPawnCombat.DamageResult DamagedBy(BmSDK.BmGame.RPawnCombat DamageReceiver, BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCombatMove_VenomChargeAttack.DamagedBy", true);
        byte* paramsPtr = stackalloc byte[249];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageReceiver, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 248);
    }

    /// <summary>
    /// Function: RecoverFromBatarang
    /// </summary>
    public unsafe virtual void RecoverFromBatarang()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCombatMove_VenomChargeAttack.RecoverFromBatarang", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OverrideHitReaction
    /// </summary>
    public unsafe override bool OverrideHitReaction(BmSDK.BmGame.RPawnCombat HitPawn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCombatMove_VenomChargeAttack.OverrideHitReaction", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IsAttacking
    /// </summary>
    public unsafe override bool IsAttacking()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCombatMove_VenomChargeAttack.IsAttacking", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: HitDisruptableLaserGrid
    /// </summary>
    public unsafe virtual bool HitDisruptableLaserGrid()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCombatMove_VenomChargeAttack.HitDisruptableLaserGrid", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: StopCharge
    /// </summary>
    public unsafe virtual void StopCharge(bool bDelay = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCombatMove_VenomChargeAttack.StopCharge", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDelay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanRedirect
    /// </summary>
    public unsafe override bool CanRedirect()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCombatMove_VenomChargeAttack.CanRedirect", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetHitPSLocation
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetHitPSLocation()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCombatMove_VenomChargeAttack.GetHitPSLocation", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetHitPS
    /// </summary>
    public unsafe override BmSDK.Engine.ParticleSystem GetHitPS()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCombatMove_VenomChargeAttack.GetHitPS", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: DamageCollisionWithObject
    /// </summary>
    public unsafe override void DamageCollisionWithObject(BmSDK.Engine.Actor Object)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCombatMove_VenomChargeAttack.DamageCollisionWithObject", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Object, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ChargedIntoPawn
    /// </summary>
    public unsafe virtual void ChargedIntoPawn(BmSDK.BmGame.RPawnCombat Pawn2, System.Numerics.Vector3 DamageDir)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCombatMove_VenomChargeAttack.ChargedIntoPawn", true);
        byte* paramsPtr = stackalloc byte[264];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn2, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageDir, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: EnableRedirect
    /// </summary>
    public unsafe virtual void EnableRedirect()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCombatMove_VenomChargeAttack.EnableRedirect", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnBraceWall
    /// </summary>
    public unsafe virtual void OnBraceWall()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCombatMove_VenomChargeAttack.OnBraceWall", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnCollideWall
    /// </summary>
    public unsafe virtual void OnCollideWall()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCombatMove_VenomChargeAttack.OnCollideWall", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: MovementOn
    /// </summary>
    public unsafe virtual void MovementOn()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCombatMove_VenomChargeAttack.MovementOn", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ChargeBegin
    /// </summary>
    public unsafe virtual void ChargeBegin()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCombatMove_VenomChargeAttack.ChargeBegin", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HitObject
    /// </summary>
    public unsafe virtual void HitObject(BmSDK.Engine.Actor ActorHit)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCombatMove_VenomChargeAttack.HitObject", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActorHit, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CollisionBetween
    /// </summary>
    public unsafe override void CollisionBetween(BmSDK.BmGame.RPawnCombat Pawn1, BmSDK.BmGame.RPawnCombat Pawn2)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCombatMove_VenomChargeAttack.CollisionBetween", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn1, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn2, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CollisionBetweenActor
    /// </summary>
    public unsafe override void CollisionBetweenActor(BmSDK.BmGame.RPawnCombat Pawn1, BmSDK.Engine.Actor OtherActor)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCombatMove_VenomChargeAttack.CollisionBetweenActor", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn1, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherActor, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Initialise
    /// </summary>
    public unsafe override void Initialise()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCombatMove_VenomChargeAttack.Initialise", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanBeUsed
    /// </summary>
    public unsafe static bool CanBeUsed(BmSDK.BmGame.RBMCombatManager CombatManager, BmSDK.BmGame.RPawnCombat User, BmSDK.BmGame.RPawnCombat NewTarget)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCombatMove_VenomChargeAttack.CanBeUsed", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CombatManager, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(User, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTarget, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// StructProperty: TransitionId
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId TransitionId
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 484);

    /// <summary>
    /// ArrayProperty: HitTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> HitTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// BoolProperty: StopPlayed
    /// </summary>
    public unsafe bool StopPlayed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 500); }
    }

    /// <summary>
    /// BoolProperty: IsMoving
    /// </summary>
    public unsafe bool IsMoving
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 500); }
    }

    /// <summary>
    /// BoolProperty: bCanRedirect
    /// </summary>
    public unsafe bool bCanRedirect
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 500); }
    }

    /// <summary>
    /// BoolProperty: bHitTarget
    /// </summary>
    public unsafe bool bHitTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 500); }
    }

    /// <summary>
    /// BoolProperty: bBataranged
    /// </summary>
    public unsafe bool bBataranged
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 500); }
    }

    /// <summary>
    /// BoolProperty: bQuickBataranged
    /// </summary>
    public unsafe bool bQuickBataranged
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 500); }
    }

    /// <summary>
    /// BoolProperty: bIsAttacking
    /// </summary>
    public unsafe bool bIsAttacking
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 500); }
    }

    /// <summary>
    /// BoolProperty: bLastHitWasRagdoll
    /// </summary>
    public unsafe bool bLastHitWasRagdoll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 500); }
    }

    /// <summary>
    /// FloatProperty: StopDelay
    /// </summary>
    public unsafe float StopDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// StructProperty: TrackHeading
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TrackHeading
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 508);

    /// <summary>
    /// ObjectProperty: Venom
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnBossVenomBase Venom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnBossVenomBase>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }
}
