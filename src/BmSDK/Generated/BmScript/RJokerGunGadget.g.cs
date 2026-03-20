#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RJokerGunGadget<br/>
/// (size = 2428)
/// (flags = 10485810)
/// </summary>
public partial class RJokerGunGadget : BmSDK.BmGame.RJokerGunGadgetBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RJokerGunGadget", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RJokerGunGadget() { }

    /// <summary>
    /// Constructs a new RJokerGunGadget
    /// </summary>
    public RJokerGunGadget(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RJokerGunGadget Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RJokerGunGadget(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RJokerGunGadget>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RJokerGunGadget>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RJokerGunGadget>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RJokerGunGadget>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RJokerGunGadget>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RJokerGunGadget>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RJokerGunGadget>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: UpdateWalkingVelocity
    /// </summary>
    public unsafe void UpdateWalkingVelocity(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerGunGadget.UpdateWalkingVelocity", true);
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CheckAutoTarget
    /// </summary>
    public unsafe bool CheckAutoTarget(BmSDK.Engine.Actor BatarangTarget, out System.Numerics.Vector3 BatarangTargetPosition, out float OverridePriority, out float OverrideMaxRange, out byte DoLOSCheck)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerGunGadget.CheckAutoTarget", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatarangTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        BatarangTargetPosition = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 8);
        OverridePriority = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 20);
        OverrideMaxRange = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 24);
        DoLOSCheck = BmSDK.Framework.MarshalUtil.ToManaged<byte>(paramsPtr + 28);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 32);
    }

    /// <summary>
    /// Function: PreRender
    /// </summary>
    public unsafe void PreRender(BmSDK.Engine.Canvas HudCanvas)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerGunGadget.PreRender", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HudCanvas, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CancelGadget
    /// </summary>
    public unsafe void CancelGadget()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerGunGadget.CancelGadget", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AimGadget
    /// </summary>
    public unsafe bool AimGadget()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerGunGadget.AimGadget", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetJokerGunAutoFireAnim
    /// </summary>
    public unsafe BmSDK.FName GetJokerGunAutoFireAnim(BmSDK.Rotator ThrowDirection, out BmSDK.BmGame.RPawnPlayerAnim.AimingConfigDesc AimingConfig)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerGunGadget.GetJokerGunAutoFireAnim", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowDirection, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        AimingConfig = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerAnim.AimingConfigDesc>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: CalculateAutoTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor CalculateAutoTarget()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerGunGadget.CalculateAutoTarget", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: UpdateGadgetLookSensitivity
    /// </summary>
    public unsafe void UpdateGadgetLookSensitivity(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerGunGadget.UpdateGadgetLookSensitivity", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe void PostBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerGunGadget.PostBeginPlay", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CalculateHitImpulse
    /// </summary>
    public unsafe System.Numerics.Vector3 CalculateHitImpulse(BmSDK.Engine.Actor.FImpactInfo HitImpactInfo, int HitVillainIndex)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerGunGadget.CalculateHitImpulse", true);
        byte* paramsPtr = stackalloc byte[128];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitImpactInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitVillainIndex, paramsPtr + 96);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 100);
    }

    /// <summary>
    /// Function: CalculateHitDamage
    /// </summary>
    public unsafe float CalculateHitDamage(BmSDK.Engine.Actor.FImpactInfo HitImpactInfo)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerGunGadget.CalculateHitDamage", true);
        byte* paramsPtr = stackalloc byte[100];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitImpactInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 96);
    }

    /// <summary>
    /// Function: AlertPeopleToGunFire
    /// </summary>
    public unsafe void AlertPeopleToGunFire()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerGunGadget.AlertPeopleToGunFire", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerGunFireRumble
    /// </summary>
    public unsafe void TriggerGunFireRumble()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerGunGadget.TriggerGunFireRumble", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerGunMuzzleFlashEffect
    /// </summary>
    public unsafe void TriggerGunMuzzleFlashEffect()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerGunGadget.TriggerGunMuzzleFlashEffect", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetImpactMaterial
    /// </summary>
    public unsafe BmSDK.Engine.RPhysicalMaterialProperty GetImpactMaterial(BmSDK.Engine.Actor.FImpactInfo Impact)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerGunGadget.GetImpactMaterial", true);
        byte* paramsPtr = stackalloc byte[104];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Impact, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RPhysicalMaterialProperty>(paramsPtr + 96);
    }

    /// <summary>
    /// Function: CreateHitEffect
    /// </summary>
    public unsafe void CreateHitEffect(bool bHitSomething, BmSDK.Engine.Actor.FImpactInfo HitImpactInfo, bool bSpawnTracer)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerGunGadget.CreateHitEffect", true);
        byte* paramsPtr = stackalloc byte[204];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHitSomething, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitImpactInfo, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSpawnTracer, paramsPtr + 100);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FireGunServer
    /// </summary>
    public unsafe void FireGunServer(BmSDK.Rotator FireRotation, System.Numerics.Vector3 FirePosition, bool bNoDamage)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerGunGadget.FireGunServer", true);
        byte* paramsPtr = stackalloc byte[520];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireRotation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FirePosition, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNoDamage, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsTwoface
    /// </summary>
    public unsafe bool IsTwoface(BmSDK.BmGame.RPawnVillain HitVillain)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerGunGadget.IsTwoface", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitVillain, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: IsRiddlerHostage
    /// </summary>
    public unsafe bool IsRiddlerHostage(BmSDK.BmGame.RPawnVillain HitVillain)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerGunGadget.IsRiddlerHostage", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitVillain, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: IsRiddler
    /// </summary>
    public unsafe bool IsRiddler(BmSDK.BmGame.RPawnVillain HitVillain)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerGunGadget.IsRiddler", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitVillain, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: IsPenguin
    /// </summary>
    public unsafe bool IsPenguin(BmSDK.BmGame.RPawnVillain HitVillain)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerGunGadget.IsPenguin", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitVillain, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: TriggerGunEffects
    /// </summary>
    public unsafe void TriggerGunEffects()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerGunGadget.TriggerGunEffects", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FireGunClient
    /// </summary>
    public unsafe void FireGunClient()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerGunGadget.FireGunClient", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FireGun
    /// </summary>
    public unsafe void FireGun()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerGunGadget.FireGun", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShootVentThug
    /// </summary>
    public unsafe void ShootVentThug()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerGunGadget.ShootVentThug", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CalculateBulletTrajectory
    /// </summary>
    public unsafe void CalculateBulletTrajectory(bool bFirst)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerGunGadget.CalculateBulletTrajectory", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFirst, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetGadgetLookSensitivity
    /// </summary>
    public unsafe float GetGadgetLookSensitivity(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerGunGadget.GetGadgetLookSensitivity", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: AdditiveArmAvoidance
    /// </summary>
    public unsafe void AdditiveArmAvoidance()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerGunGadget.AdditiveArmAvoidance", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShouldAimAt
    /// </summary>
    public unsafe bool ShouldAimAt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerGunGadget.ShouldAimAt", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CanThrowGadget
    /// </summary>
    public unsafe bool CanThrowGadget()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerGunGadget.CanThrowGadget", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetGadgetCamera
    /// </summary>
    public unsafe BmSDK.FName GetGadgetCamera(bool InSoftCover = default, BmSDK.BmGame.RInventoryGadget.CoverCornerType CornerType = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerGunGadget.GetGadgetCamera", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSoftCover, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CornerType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: GetPrimedPose
    /// </summary>
    public unsafe BmSDK.FName GetPrimedPose(out BmSDK.BmGame.RInventoryGadget.PlayerWantsToCrouch StanceIsCrouched, out BmSDK.BmGame.RAnimUtil.EMirrorChoice MirroredNess, bool InSoftCover, BmSDK.BmGame.RInventoryGadget.CoverCornerType CornerType, out BmSDK.FName OutCapeState, out BmSDK.FName OutCapeTransitionState)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerGunGadget.GetPrimedPose", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSoftCover, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CornerType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        StanceIsCrouched = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.PlayerWantsToCrouch>(paramsPtr + 0);
        MirroredNess = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil.EMirrorChoice>(paramsPtr + 1);
        OutCapeState = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 12);
        OutCapeTransitionState = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 28);
    }

    /// <summary>
    /// Function: CameraZoomChanged
    /// </summary>
    public unsafe void CameraZoomChanged(bool bCurrentlyZoomed)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerGunGadget.CameraZoomChanged", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCurrentlyZoomed, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetPromptName
    /// </summary>
    public unsafe static BmSDK.FName GetPromptName()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerGunGadget.GetPromptName", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetJokerRoom3
    /// </summary>
    public unsafe void SetJokerRoom3(bool On)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerGunGadget.SetJokerRoom3", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(On, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetAutomaticZoomCamera
    /// </summary>
    public unsafe void SetAutomaticZoomCamera(bool On)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerGunGadget.SetAutomaticZoomCamera", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(On, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// StructProperty: CurrTransitionId
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId CurrTransitionId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 2088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2088); }
    }

    /// <summary>
    /// StructProperty: CurrOverlayId
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId CurrOverlayId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId>(Ptr + 2092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2092); }
    }

    /// <summary>
    /// FloatProperty: DefaultHitDamage
    /// </summary>
    public unsafe float DefaultHitDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2100); }
    }

    /// <summary>
    /// FloatProperty: DefaultHitImpulse
    /// </summary>
    public unsafe float DefaultHitImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2104); }
    }

    /// <summary>
    /// FloatProperty: DefaultHitLift
    /// </summary>
    public unsafe float DefaultHitLift
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2108); }
    }

    /// <summary>
    /// FloatProperty: BulletImpulseReductionProportionPerVillain
    /// </summary>
    public unsafe float BulletImpulseReductionProportionPerVillain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2112); }
    }

    /// <summary>
    /// IntProperty: MaxNumVillainsWhichCanBeShotWithSingleBullet
    /// </summary>
    public unsafe int MaxNumVillainsWhichCanBeShotWithSingleBullet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2116); }
    }

    /// <summary>
    /// FloatProperty: AutoTargetAngle
    /// </summary>
    public unsafe float AutoTargetAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2120); }
    }

    /// <summary>
    /// FloatProperty: MaxTracerDiffAngle
    /// </summary>
    public unsafe float MaxTracerDiffAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2124); }
    }

    /// <summary>
    /// FloatProperty: AutoTargetRange
    /// </summary>
    public unsafe float AutoTargetRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2128); }
    }

    /// <summary>
    /// ComponentProperty: MuzzleFlash
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent MuzzleFlash
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 2132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2132); }
    }

    /// <summary>
    /// NameProperty: MuzzleFlashSocketName
    /// </summary>
    public unsafe BmSDK.FName MuzzleFlashSocketName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2140); }
    }

    /// <summary>
    /// ObjectProperty: HitEffectParticleSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem HitEffectParticleSystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 2148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2148); }
    }

    /// <summary>
    /// ObjectProperty: GunTracerParticleSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem GunTracerParticleSystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 2156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2156); }
    }

    /// <summary>
    /// ObjectProperty: GunFireRumble
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform GunFireRumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 2164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2164); }
    }

    /// <summary>
    /// ObjectProperty: LoadedGunFireSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent LoadedGunFireSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2172); }
    }

    /// <summary>
    /// ObjectProperty: CurrentBestTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor CurrentBestTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 2180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2180); }
    }

    /// <summary>
    /// ObjectProperty: PenguinHandTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor PenguinHandTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 2188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2188); }
    }

    /// <summary>
    /// ObjectProperty: penguin
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain penguin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 2196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2196); }
    }

    /// <summary>
    /// StructProperty: AutoAimFireDirections
    /// </summary>
    public unsafe BmSDK.BmScript.RCwBullwhip.FBatarangThrowDirection AutoAimFireDirections_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RCwBullwhip.FBatarangThrowDirection>(Ptr + 2204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2204); }
    }
    /// <summary>
    /// StructProperty: AutoAimFireDirections
    /// </summary>
    public unsafe BmSDK.BmScript.RCwBullwhip.FBatarangThrowDirection AutoAimFireDirections_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RCwBullwhip.FBatarangThrowDirection>(Ptr + 2248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2248); }
    }
    /// <summary>
    /// StructProperty: AutoAimFireDirections
    /// </summary>
    public unsafe BmSDK.BmScript.RCwBullwhip.FBatarangThrowDirection AutoAimFireDirections_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RCwBullwhip.FBatarangThrowDirection>(Ptr + 2292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2292); }
    }

    /// <summary>
    /// StructProperty: LastFireRotation
    /// </summary>
    public unsafe BmSDK.Rotator LastFireRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 2336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2336); }
    }

    /// <summary>
    /// StructProperty: LastFirePosition
    /// </summary>
    public unsafe System.Numerics.Vector3 LastFirePosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2348); }
    }

    /// <summary>
    /// IntProperty: BlunderbusShots
    /// </summary>
    public unsafe int BlunderbusShots
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2360); }
    }

    /// <summary>
    /// FloatProperty: BlunderbusRandom
    /// </summary>
    public unsafe float BlunderbusRandom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2364); }
    }

    /// <summary>
    /// BoolProperty: bTwoFaceIntro
    /// </summary>
    public unsafe bool bTwoFaceIntro
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2368) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2368); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2368); }
    }

    /// <summary>
    /// BoolProperty: bRoom3
    /// </summary>
    public unsafe bool bRoom3
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2368) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2368); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2368); }
    }

    /// <summary>
    /// BoolProperty: bClickAim
    /// </summary>
    public unsafe bool bClickAim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2368) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2368); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2368); }
    }

    /// <summary>
    /// BoolProperty: bInStumble
    /// </summary>
    public unsafe bool bInStumble
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2368) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2368); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2368); }
    }

    /// <summary>
    /// BoolProperty: InvertAdditiveVal
    /// </summary>
    public unsafe bool InvertAdditiveVal
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2368) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2368); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2368); }
    }

    /// <summary>
    /// BoolProperty: bForceDisableCrossHair
    /// </summary>
    public unsafe bool bForceDisableCrossHair
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2368) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2368); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2368); }
    }

    /// <summary>
    /// BoolProperty: bFirstShot
    /// </summary>
    public unsafe bool bFirstShot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2368) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2368); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2368); }
    }

    /// <summary>
    /// BoolProperty: bManageWalkingVelocity
    /// </summary>
    public unsafe bool bManageWalkingVelocity
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2368) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2368); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2368); }
    }

    /// <summary>
    /// BoolProperty: bAllowShootInTwofaceIntro
    /// </summary>
    public unsafe bool bAllowShootInTwofaceIntro
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2368) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2368); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2368); }
    }

    /// <summary>
    /// FloatProperty: DistForBringGunInToMax
    /// </summary>
    public unsafe float DistForBringGunInToMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2372); }
    }

    /// <summary>
    /// FloatProperty: DistForBringGunIn
    /// </summary>
    public unsafe float DistForBringGunIn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2376); }
    }

    /// <summary>
    /// FloatProperty: BringInLerpVal
    /// </summary>
    public unsafe float BringInLerpVal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2380); }
    }

    /// <summary>
    /// FloatProperty: CurrentBringInVal
    /// </summary>
    public unsafe float CurrentBringInVal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2384); }
    }

    /// <summary>
    /// ArrayProperty: ActorsHitThisShot
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> ActorsHitThisShot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 2388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2388); }
    }

    /// <summary>
    /// StructProperty: WalkingPawnVelocity
    /// </summary>
    public unsafe System.Numerics.Vector3 WalkingPawnVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2404); }
    }

    /// <summary>
    /// FloatProperty: WalkingPawnAccel
    /// </summary>
    public unsafe float WalkingPawnAccel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2416); }
    }

    /// <summary>
    /// FloatProperty: WalkingMaxSpeed
    /// </summary>
    public unsafe float WalkingMaxSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2420); }
    }

    /// <summary>
    /// FloatProperty: AimingMaxSpeed
    /// </summary>
    public unsafe float AimingMaxSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2424); }
    }
}
