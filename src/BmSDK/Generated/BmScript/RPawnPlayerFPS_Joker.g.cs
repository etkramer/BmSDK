#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RPawnPlayerFPS_Joker<br/>
/// (size = 3376)
/// (flags = 10485814)
/// </summary>
public partial class RPawnPlayerFPS_Joker : BmSDK.BmGame.RPawnPlayerFPS, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RPawnPlayerFPS_Joker", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPawnPlayerFPS_Joker() { }

    /// <summary>
    /// Constructs a new RPawnPlayerFPS_Joker
    /// </summary>
    public RPawnPlayerFPS_Joker(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPawnPlayerFPS_Joker Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnPlayerFPS_Joker(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerFPS_Joker>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerFPS_Joker>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerFPS_Joker>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerFPS_Joker>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerFPS_Joker>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerFPS_Joker>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerFPS_Joker>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: DoKismetAttachment
    /// </summary>
    public unsafe void DoKismetAttachment(BmSDK.Engine.Actor Attachment, BmSDK.Engine.SeqAct_AttachToActor Action)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerFPS_Joker.DoKismetAttachment", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attachment, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HideHead
    /// </summary>
    public unsafe void HideHead()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerFPS_Joker.HideHead", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowHead
    /// </summary>
    public unsafe void ShowHead()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerFPS_Joker.ShowHead", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe void PostBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerFPS_Joker.PostBeginPlay", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CauseMuzzleFlash
    /// </summary>
    public unsafe void CauseMuzzleFlash()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerFPS_Joker.CauseMuzzleFlash", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoShotFX
    /// </summary>
    public unsafe void DoShotFX(System.Numerics.Vector3 HitTarget, BmSDK.Engine.Actor HitActor, System.Numerics.Vector3 HitNormal, System.Numerics.Vector3 OriginalShotOrig, System.Numerics.Vector3 OriginalShotDir)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerFPS_Joker.DoShotFX", true);
        byte* paramsPtr = stackalloc byte[188];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitTarget, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitActor, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OriginalShotOrig, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OriginalShotDir, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CalcImpact
    /// </summary>
    public unsafe BmSDK.Engine.Actor.FImpactInfo CalcImpact(System.Numerics.Vector3 StartTrace, System.Numerics.Vector3 EndTrace, BmSDK.Engine.Actor HitTarget)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerFPS_Joker.CalcImpact", true);
        byte* paramsPtr = stackalloc byte[304];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartTrace, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndTrace, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitTarget, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor.FImpactInfo>(paramsPtr + 32);
    }

    /// <summary>
    /// Function: DoHitDecal
    /// </summary>
    public unsafe bool DoHitDecal(BmSDK.Engine.Actor.FImpactInfo HitImpactInfo, System.Numerics.Vector3 HitTarget, BmSDK.Engine.Actor HitActor, System.Numerics.Vector3 GunMuzzle, System.Numerics.Vector3 HitNormal)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerFPS_Joker.DoHitDecal", true);
        byte* paramsPtr = stackalloc byte[200];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitImpactInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitTarget, paramsPtr + 96);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitActor, paramsPtr + 108);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GunMuzzle, paramsPtr + 116);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 128);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 140);
    }

    /// <summary>
    /// Function: TakeDamage
    /// </summary>
    public unsafe void TakeDamage(int Damage, BmSDK.Engine.Controller InstigatedBy, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.Engine.Actor.FTraceHitInfo HitInfo = default, BmSDK.Engine.Actor DamageCauser = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerFPS_Joker.TakeDamage", true);
        byte* paramsPtr = stackalloc byte[92];
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
    /// Function: CheckRDPForLowBounds
    /// </summary>
    public unsafe void CheckRDPForLowBounds()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerFPS_Joker.CheckRDPForLowBounds", true);
        byte* paramsPtr = stackalloc byte[124];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Bump
    /// </summary>
    public unsafe void Bump(BmSDK.Engine.Actor Other, BmSDK.Engine.PrimitiveComponent OtherComp, System.Numerics.Vector3 HitNormal)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerFPS_Joker.Bump", true);
        byte* paramsPtr = stackalloc byte[156];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComp, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FireGunNow
    /// </summary>
    public unsafe bool FireGunNow(bool bGunAnimOnly = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerFPS_Joker.FireGunNow", true);
        byte* paramsPtr = stackalloc byte[156];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bGunAnimOnly, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: Reload
    /// </summary>
    public unsafe void Reload()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerFPS_Joker.Reload", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PutGunInRightHand
    /// </summary>
    public unsafe void PutGunInRightHand()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerFPS_Joker.PutGunInRightHand", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PutGunInLeftHand
    /// </summary>
    public unsafe void PutGunInLeftHand()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerFPS_Joker.PutGunInLeftHand", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TurnOnLight
    /// </summary>
    public unsafe void TurnOnLight()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerFPS_Joker.TurnOnLight", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CalculateBulletTrajectory
    /// </summary>
    public unsafe void CalculateBulletTrajectory()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerFPS_Joker.CalculateBulletTrajectory", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AdditiveArmAvoidance
    /// </summary>
    public unsafe void AdditiveArmAvoidance()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerFPS_Joker.AdditiveArmAvoidance", true);
        byte* paramsPtr = stackalloc byte[80];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PreRender
    /// </summary>
    public unsafe void PreRender(BmSDK.Engine.Canvas HudCanvas)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerFPS_Joker.PreRender", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HudCanvas, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowCrossHair
    /// </summary>
    public unsafe bool ShowCrossHair()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerFPS_Joker.ShowCrossHair", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: Zoom
    /// </summary>
    public unsafe void Zoom(bool bZoom)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerFPS_Joker.Zoom", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bZoom, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ToggleZoom
    /// </summary>
    public unsafe void ToggleZoom()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerFPS_Joker.ToggleZoom", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ComponentProperty: MuzzleFlashLight
    /// </summary>
    public unsafe BmSDK.Engine.PointLightComponent MuzzleFlashLight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PointLightComponent>(Ptr + 3200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3200); }
    }

    /// <summary>
    /// NameProperty: MuzzleFlashLightSocket
    /// </summary>
    public unsafe BmSDK.FName MuzzleFlashLightSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 3208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3208); }
    }

    /// <summary>
    /// ComponentProperty: MuzzleFlash
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent MuzzleFlash
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 3216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3216); }
    }

    /// <summary>
    /// NameProperty: MuzzleFlashSocket
    /// </summary>
    public unsafe BmSDK.FName MuzzleFlashSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 3224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3224); }
    }

    /// <summary>
    /// ComponentProperty: MuzzleFlashBullet
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent MuzzleFlashBullet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 3232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3232); }
    }

    /// <summary>
    /// ObjectProperty: GunTracerParticleSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem GunTracerParticleSystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 3240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3240); }
    }

    /// <summary>
    /// ObjectProperty: HitEffectParticleSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem HitEffectParticleSystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 3248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3248); }
    }

    /// <summary>
    /// FloatProperty: BulletImpulse
    /// </summary>
    public unsafe float BulletImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3256); }
    }

    /// <summary>
    /// FloatProperty: BulletImpulseForRDP
    /// </summary>
    public unsafe float BulletImpulseForRDP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3260); }
    }

    /// <summary>
    /// FloatProperty: BulletRadiusForRDP
    /// </summary>
    public unsafe float BulletRadiusForRDP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3264); }
    }

    /// <summary>
    /// BoolProperty: bTryFakeImpactForRDP
    /// </summary>
    public unsafe bool bTryFakeImpactForRDP
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3268) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3268); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3268); }
    }

    /// <summary>
    /// BoolProperty: bInAdditiveOverlay
    /// </summary>
    public unsafe bool bInAdditiveOverlay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3268) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3268); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3268); }
    }

    /// <summary>
    /// BoolProperty: bBlendingOutDueToWalk
    /// </summary>
    public unsafe bool bBlendingOutDueToWalk
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3268) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3268); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3268); }
    }

    /// <summary>
    /// BoolProperty: bHeadVisible
    /// </summary>
    public unsafe bool bHeadVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3268) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3268); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3268); }
    }

    /// <summary>
    /// BoolProperty: bShowCrossHair
    /// </summary>
    public unsafe bool bShowCrossHair
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3268) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3268); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3268); }
    }

    /// <summary>
    /// BoolProperty: bTorchOn
    /// </summary>
    public unsafe bool bTorchOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3268) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3268); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3268); }
    }

    /// <summary>
    /// StructProperty: FakeImpactOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 FakeImpactOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3272); }
    }

    /// <summary>
    /// FloatProperty: FakeImpactRadius
    /// </summary>
    public unsafe float FakeImpactRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3284); }
    }

    /// <summary>
    /// IntProperty: BlunderbusShots
    /// </summary>
    public unsafe int BlunderbusShots
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3288); }
    }

    /// <summary>
    /// FloatProperty: BlunderbusRandom
    /// </summary>
    public unsafe float BlunderbusRandom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3292); }
    }

    /// <summary>
    /// StructProperty: LastFireRotation
    /// </summary>
    public unsafe BmSDK.Rotator LastFireRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 3296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3296); }
    }

    /// <summary>
    /// StructProperty: LastFirePosition
    /// </summary>
    public unsafe System.Numerics.Vector3 LastFirePosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3308); }
    }

    /// <summary>
    /// FloatProperty: TimeTillNextAdditiveOverlay
    /// </summary>
    public unsafe float TimeTillNextAdditiveOverlay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3320); }
    }

    /// <summary>
    /// FloatProperty: AdditiveOverlayTimer
    /// </summary>
    public unsafe float AdditiveOverlayTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3324); }
    }

    /// <summary>
    /// IntProperty: CurrentAdditiveOverlayIndex
    /// </summary>
    public unsafe int CurrentAdditiveOverlayIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3328); }
    }

    /// <summary>
    /// FloatProperty: DistForBringGunInToMax
    /// </summary>
    public unsafe float DistForBringGunInToMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3332); }
    }

    /// <summary>
    /// FloatProperty: DistForBringGunIn
    /// </summary>
    public unsafe float DistForBringGunIn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3336); }
    }

    /// <summary>
    /// FloatProperty: BringInLerpVal
    /// </summary>
    public unsafe float BringInLerpVal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3340); }
    }

    /// <summary>
    /// FloatProperty: BringOutLerpVal
    /// </summary>
    public unsafe float BringOutLerpVal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3344); }
    }

    /// <summary>
    /// FloatProperty: BringGunInMax
    /// </summary>
    public unsafe float BringGunInMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3348); }
    }

    /// <summary>
    /// FloatProperty: CurrentBringInVal
    /// </summary>
    public unsafe float CurrentBringInVal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3352); }
    }

    /// <summary>
    /// FloatProperty: GunDummyBringInOffsetDist
    /// </summary>
    public unsafe float GunDummyBringInOffsetDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3356); }
    }

    /// <summary>
    /// FloatProperty: AdditiveBlendWeight
    /// </summary>
    public unsafe float AdditiveBlendWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3360); }
    }

    /// <summary>
    /// FloatProperty: ChanceOfShotDecal
    /// </summary>
    public unsafe float ChanceOfShotDecal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3364); }
    }

    /// <summary>
    /// IntProperty: FramesSinceMatinee
    /// </summary>
    public unsafe int FramesSinceMatinee
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3368); }
    }

    /// <summary>
    /// IntProperty: HitsOnFinalWall
    /// </summary>
    public unsafe int HitsOnFinalWall
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3372); }
    }
}
