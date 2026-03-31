#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RPawnVillainMadHatter<br/>
/// (size = 3640)
/// (flags = 10485814)
/// </summary>
public partial class RPawnVillainMadHatter : BmSDK.BmGame.RPawnVillainMadHatterBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RPawnVillainMadHatter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPawnVillainMadHatter.
    /// </summary>
    public static RPawnVillainMadHatter DefaultObject => (RPawnVillainMadHatter)StaticClass().DefaultObject;

    internal RPawnVillainMadHatter() { }

    /// <summary>
    /// Constructs a new RPawnVillainMadHatter
    /// </summary>
    public RPawnVillainMadHatter(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPawnVillainMadHatter Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnVillainMadHatter(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainMadHatter>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainMadHatter>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainMadHatter>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainMadHatter>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainMadHatter>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainMadHatter>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainMadHatter>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainMadHatter>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: ShouldCombatantLockDoors
    /// </summary>
    public unsafe override bool ShouldCombatantLockDoors()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainMadHatter.ShouldCombatantLockDoors", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CreateBasicWeaponConfig
    /// </summary>
    public unsafe override BmSDK.BmGame.RWeaponConfig CreateBasicWeaponConfig(BmSDK.GameObject NewOwner, BmSDK.TArray<BmSDK.Engine.AnimSet> AnimSets, BmSDK.Engine.AnimSet TurnAnimSet = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainMadHatter.CreateBasicWeaponConfig", true);
        byte* paramsPtr = stackalloc byte[372];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSets, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TurnAnimSet, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: KeepInView
    /// </summary>
    public unsafe virtual void KeepInView(BmSDK.Engine.Actor Pawn, float MaxYaw = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainMadHatter.KeepInView", true);
        byte* paramsPtr = stackalloc byte[104];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxYaw, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateKeepInViewTarget
    /// </summary>
    public unsafe virtual void UpdateKeepInViewTarget()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainMadHatter.UpdateKeepInViewTarget", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: EnableKeepInView
    /// </summary>
    public unsafe virtual void EnableKeepInView()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainMadHatter.EnableKeepInView", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Died
    /// </summary>
    public unsafe override bool Died(BmSDK.Engine.Controller Killer, BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainMadHatter.Died", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: TriggerDespawnFX
    /// </summary>
    public unsafe virtual void TriggerDespawnFX()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainMadHatter.TriggerDespawnFX", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AllOver
    /// </summary>
    public unsafe virtual void AllOver()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainMadHatter.AllOver", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HideMask
    /// </summary>
    public unsafe virtual void HideMask()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainMadHatter.HideMask", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowMask
    /// </summary>
    public unsafe virtual void ShowMask()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainMadHatter.ShowMask", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StompHat
    /// </summary>
    public unsafe virtual void StompHat()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainMadHatter.StompHat", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SwapToNormalHead
    /// </summary>
    public unsafe virtual void SwapToNormalHead()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainMadHatter.SwapToNormalHead", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartEdgeFadeOut
    /// </summary>
    public unsafe virtual void StartEdgeFadeOut()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainMadHatter.StartEdgeFadeOut", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerTeleport
    /// </summary>
    public unsafe virtual void TriggerTeleport()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainMadHatter.TriggerTeleport", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartEdgeFadeIn
    /// </summary>
    public unsafe virtual void StartEdgeFadeIn()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainMadHatter.StartEdgeFadeIn", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetTakedownable
    /// </summary>
    public unsafe virtual void SetTakedownable()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainMadHatter.SetTakedownable", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DamagedBy
    /// </summary>
    public unsafe override BmSDK.BmGame.RPawnCombat.DamageResult DamagedBy(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainMadHatter.DamagedBy", true);
        byte* paramsPtr = stackalloc byte[252];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 244);
    }

    /// <summary>
    /// Function: ApplyFakeDamage
    /// </summary>
    public unsafe override void ApplyFakeDamage()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainMadHatter.ApplyFakeDamage", true);
        byte* paramsPtr = stackalloc byte[248];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NotifyBatclawed
    /// </summary>
    public unsafe override void NotifyBatclawed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainMadHatter.NotifyBatclawed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float UpdateTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainMadHatter.Tick", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UpdateTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CamShouldLookAtMe
    /// </summary>
    public unsafe virtual bool CamShouldLookAtMe()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainMadHatter.CamShouldLookAtMe", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe virtual void Init(BmSDK.BmScript.RSeqAct_MadHatterSpawner Seq, bool KOAble)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainMadHatter.Init", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Seq, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KOAble, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanRedirect
    /// </summary>
    public unsafe override bool CanRedirect()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainMadHatter.CanRedirect", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CanBeHitInCombat
    /// </summary>
    public unsafe override bool CanBeHitInCombat(BmSDK.BmGame.RDamageType DamageType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainMadHatter.CanBeHitInCombat", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IsAwareOfPlayer
    /// </summary>
    public unsafe override bool IsAwareOfPlayer(BmSDK.BmGame.RPawnPlayer PlayerPawn, BmSDK.Class dmgType = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainMadHatter.IsAwareOfPlayer", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: IsVulnerableToTakedown
    /// </summary>
    public unsafe override bool IsVulnerableToTakedown(BmSDK.FString takedown)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainMadHatter.IsVulnerableToTakedown", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(takedown, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: SpawnSpecialAttack
    /// </summary>
    public unsafe override bool SpawnSpecialAttack(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn, BmSDK.Class dmgType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainMadHatter.SpawnSpecialAttack", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainMadHatter.PostBeginPlay", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: SeqAct
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_MadHatterSpawner SeqAct
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_MadHatterSpawner>(Ptr + 3560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3560); }
    }

    /// <summary>
    /// FloatProperty: actionTimer
    /// </summary>
    public unsafe float actionTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3564); }
    }

    /// <summary>
    /// BoolProperty: bBeenHit
    /// </summary>
    public unsafe bool bBeenHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3568); }
    }

    /// <summary>
    /// BoolProperty: bAwaitingTakedown
    /// </summary>
    public unsafe bool bAwaitingTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3568); }
    }

    /// <summary>
    /// BoolProperty: bSuspendKeepInView
    /// </summary>
    public unsafe bool bSuspendKeepInView
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3568); }
    }

    /// <summary>
    /// BoolProperty: bTakenDown
    /// </summary>
    public unsafe bool bTakenDown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3568); }
    }

    /// <summary>
    /// BoolProperty: bKOAble
    /// </summary>
    public unsafe bool bKOAble
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3568); }
    }

    /// <summary>
    /// BoolProperty: bTakedownPrepComplete
    /// </summary>
    public unsafe bool bTakedownPrepComplete
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3568); }
    }

    /// <summary>
    /// FloatProperty: powerUpSoundDuration
    /// </summary>
    public unsafe float powerUpSoundDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3572); }
    }

    /// <summary>
    /// ComponentProperty: SpawnInFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent SpawnInFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 3576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3576); }
    }

    /// <summary>
    /// ComponentProperty: GizmoFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent GizmoFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 3580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3580); }
    }

    /// <summary>
    /// FloatProperty: SFXMin
    /// </summary>
    public unsafe float SFXMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3584); }
    }

    /// <summary>
    /// FloatProperty: SFXMax
    /// </summary>
    public unsafe float SFXMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3588); }
    }

    /// <summary>
    /// FloatProperty: VFXAlphaMin
    /// </summary>
    public unsafe float VFXAlphaMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3592); }
    }

    /// <summary>
    /// FloatProperty: VFXAlphaMax
    /// </summary>
    public unsafe float VFXAlphaMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3596); }
    }

    /// <summary>
    /// FloatProperty: VFXScaleMin
    /// </summary>
    public unsafe float VFXScaleMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3600); }
    }

    /// <summary>
    /// FloatProperty: VFXScaleMax
    /// </summary>
    public unsafe float VFXScaleMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3604); }
    }

    /// <summary>
    /// StructProperty: SoundHandle
    /// </summary>
    public unsafe ref BmSDK.Engine.AkWwise.FAkSoundHandle SoundHandle
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.AkWwise.FAkSoundHandle>(Ptr + 3608);

    /// <summary>
    /// FloatProperty: CurrMaxYawOffset
    /// </summary>
    public unsafe float CurrMaxYawOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3620); }
    }

    /// <summary>
    /// FloatProperty: lookOffsetZ
    /// </summary>
    public unsafe float lookOffsetZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3624); }
    }

    /// <summary>
    /// ComponentProperty: pocketWatchComp
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent pocketWatchComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 3628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3628); }
    }

    /// <summary>
    /// ComponentProperty: Len
    /// </summary>
    public unsafe BmSDK.Engine.DynamicLightEnvironmentComponent Len
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DynamicLightEnvironmentComponent>(Ptr + 3632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3632); }
    }

    /// <summary>
    /// IntProperty: RFlapsTeleportFrames
    /// </summary>
    public unsafe int RFlapsTeleportFrames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3636); }
    }
}
