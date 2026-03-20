#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RPawnVillainCombatExpert<br/>
/// (size = 6820)
/// (flags = 10485814)
/// </summary>
public partial class RPawnVillainCombatExpert : BmSDK.BmGame.RPawnVillainCombatExpertBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RPawnVillainCombatExpert", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPawnVillainCombatExpert() { }

    /// <summary>
    /// Constructs a new RPawnVillainCombatExpert
    /// </summary>
    public RPawnVillainCombatExpert(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPawnVillainCombatExpert Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnVillainCombatExpert(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainCombatExpert>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainCombatExpert>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainCombatExpert>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainCombatExpert>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainCombatExpert>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainCombatExpert>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainCombatExpert>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: InitialisePlayerSpecificAnimsets
    /// </summary>
    public unsafe void InitialisePlayerSpecificAnimsets(BmSDK.BmGame.RPawnPlayerCombat NewPlayer, int PlayerIndex)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainCombatExpert.InitialisePlayerSpecificAnimsets", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPlayer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerIndex, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlaySound_ImpactAI
    /// </summary>
    public unsafe void PlaySound_ImpactAI(BmSDK.Engine.Actor playOn, bool bIsStrike, bool bFinishingBlow, bool bIsHeadImpact, bool bIsPunch, bool bIsStrong, bool bIsBlocked, bool bCanEmote = default, bool bIsQuick = default, bool bPlayerAttacked = default, bool bForceEmote = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainCombatExpert.PlaySound_ImpactAI", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(playOn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsStrike, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFinishingBlow, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsHeadImpact, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsPunch, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsStrong, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsBlocked, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanEmote, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsQuick, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayerAttacked, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceEmote, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CreateCombatWeaponConfig
    /// </summary>
    public unsafe BmSDK.BmGame.RWeaponConfig CreateCombatWeaponConfig(BmSDK.GameObject NewOwner, BmSDK.Engine.AnimSet AnimSet1, BmSDK.Engine.AnimSet AnimSet2, BmSDK.Engine.AnimSet AnimSet3, BmSDK.Engine.AnimSet AnimSet4, BmSDK.Engine.AnimSet AnimSet5)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainCombatExpert.CreateCombatWeaponConfig", true);
        byte* paramsPtr = stackalloc byte[6912];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet1, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet2, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet3, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet4, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet5, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 48);
    }

    /// <summary>
    /// Function: CreateRagdollWeaponConfig
    /// </summary>
    public unsafe BmSDK.BmGame.RWeaponConfig CreateRagdollWeaponConfig(BmSDK.GameObject NewOwner, BmSDK.Engine.AnimSet AnimSet1, BmSDK.Engine.AnimSet AnimSet2, BmSDK.Engine.AnimSet AnimSet3 = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainCombatExpert.CreateRagdollWeaponConfig", true);
        byte* paramsPtr = stackalloc byte[4836];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet1, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet2, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet3, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 32);
    }

    /// <summary>
    /// Function: CreateWeaponConfigUnarmed
    /// </summary>
    public unsafe BmSDK.BmGame.RWeaponConfig CreateWeaponConfigUnarmed(BmSDK.GameObject NewOwner)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainCombatExpert.CreateWeaponConfigUnarmed", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: GetCombatAimingConfig
    /// </summary>
    public unsafe static BmSDK.Engine.RAimingConfig GetCombatAimingConfig()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainCombatExpert.GetCombatAimingConfig", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAimingConfig>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetPlayerAerialAttackAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet GetPlayerAerialAttackAnimset(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainCombatExpert.GetPlayerAerialAttackAnimset", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: GetVillainAerialAttackAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet GetVillainAerialAttackAnimset(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainCombatExpert.GetVillainAerialAttackAnimset", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: StartAttackingFX
    /// </summary>
    public unsafe void StartAttackingFX(int CTypeInt, BmSDK.BmGame.RPlayerController PC = default, BmSDK.FName OverrideBoneName = default, bool bForceShow = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainCombatExpert.StartAttackingFX", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CTypeInt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideBoneName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceShow, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetStrikeImpactPS
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem GetStrikeImpactPS()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainCombatExpert.GetStrikeImpactPS", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetStrikeTrailPS
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem GetStrikeTrailPS()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainCombatExpert.GetStrikeTrailPS", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetPlayerImpactBone
    /// </summary>
    public unsafe BmSDK.FName GetPlayerImpactBone()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainCombatExpert.GetPlayerImpactBone", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SpawnVulnerableStrike
    /// </summary>
    public unsafe bool SpawnVulnerableStrike(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainCombatExpert.SpawnVulnerableStrike", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: SpawnBlock
    /// </summary>
    public unsafe bool SpawnBlock(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainCombatExpert.SpawnBlock", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: SpawnNormalStrike
    /// </summary>
    public unsafe bool SpawnNormalStrike(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainCombatExpert.SpawnNormalStrike", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: OverrideCanDodgeProjectile
    /// </summary>
    public unsafe bool OverrideCanDodgeProjectile(System.Numerics.Vector3 ThrownFromPos, int CheckBatarangID)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainCombatExpert.OverrideCanDodgeProjectile", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrownFromPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckBatarangID, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: DodgeStrike
    /// </summary>
    public unsafe void DodgeStrike(BmSDK.BmGame.RPawnCombat Attacker, BmSDK.Class dmgType, bool bFar)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainCombatExpert.DodgeStrike", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFar, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanDodgeAttack
    /// </summary>
    public unsafe bool CanDodgeAttack(BmSDK.BmGame.RPawnCombat Attacker, BmSDK.Class dmgType, bool bFar)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainCombatExpert.CanDodgeAttack", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFar, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: GetDodgeChance
    /// </summary>
    public unsafe float GetDodgeChance()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainCombatExpert.GetDodgeChance", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ShouldGoRagdoll
    /// </summary>
    public unsafe bool ShouldGoRagdoll(BmSDK.Class dmgType, float DamageAmount)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainCombatExpert.ShouldGoRagdoll", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageAmount, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: CanBePushedBy
    /// </summary>
    public unsafe bool CanBePushedBy(BmSDK.BmGame.RPawnVillain Pusher)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainCombatExpert.CanBePushedBy", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pusher, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: CreateWeapon
    /// </summary>
    public unsafe BmSDK.BmGame.RBMWeapon CreateWeapon()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainCombatExpert.CreateWeapon", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMWeapon>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe void PostBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainCombatExpert.PostBeginPlay", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BladeOff
    /// </summary>
    public unsafe void BladeOff()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainCombatExpert.BladeOff", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BladeOn
    /// </summary>
    public unsafe void BladeOn()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainCombatExpert.BladeOn", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: EyesOff
    /// </summary>
    public unsafe void EyesOff()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainCombatExpert.EyesOff", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: EyesOn
    /// </summary>
    public unsafe void EyesOn()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainCombatExpert.EyesOn", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ArrayProperty: NormalStepList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> NormalStepList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 6780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6780); }
    }

    /// <summary>
    /// ComponentProperty: EyeFxLeftComp
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent EyeFxLeftComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 6796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6796); }
    }

    /// <summary>
    /// ComponentProperty: EyeFxRightComp
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent EyeFxRightComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 6804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6804); }
    }

    /// <summary>
    /// ComponentProperty: BladeFxComp
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent BladeFxComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 6812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6812); }
    }
}
