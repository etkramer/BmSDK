#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RPawnPlayerFPS_Cop<br/>
/// (size = 3260)
/// (flags = 10485814)
/// </summary>
public partial class RPawnPlayerFPS_Cop : BmSDK.BmGame.RPawnPlayerFPS, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RPawnPlayerFPS_Cop", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPawnPlayerFPS_Cop() { }

    /// <summary>
    /// Constructs a new RPawnPlayerFPS_Cop
    /// </summary>
    public RPawnPlayerFPS_Cop(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPawnPlayerFPS_Cop Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnPlayerFPS_Cop(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerFPS_Cop>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerFPS_Cop>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerFPS_Cop>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerFPS_Cop>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerFPS_Cop>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerFPS_Cop>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerFPS_Cop>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe void PostBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerFPS_Cop.PostBeginPlay", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CauseMuzzleFlash
    /// </summary>
    public unsafe void CauseMuzzleFlash()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerFPS_Cop.CauseMuzzleFlash", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoShotFX
    /// </summary>
    public unsafe void DoShotFX(System.Numerics.Vector3 HitTarget, BmSDK.Engine.Actor HitActor, System.Numerics.Vector3 OriginalShotOrig, System.Numerics.Vector3 OriginalShotDir)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerFPS_Cop.DoShotFX", true);
        byte* paramsPtr = stackalloc byte[176];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitTarget, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitActor, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OriginalShotOrig, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OriginalShotDir, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CalcImpact
    /// </summary>
    public unsafe BmSDK.Engine.Actor.FImpactInfo CalcImpact(System.Numerics.Vector3 StartTrace, System.Numerics.Vector3 EndTrace, BmSDK.Engine.Actor HitTarget)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerFPS_Cop.CalcImpact", true);
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
    public unsafe bool DoHitDecal(BmSDK.Engine.Actor.FImpactInfo HitImpactInfo, System.Numerics.Vector3 HitTarget, BmSDK.Engine.Actor HitActor, System.Numerics.Vector3 GunMuzzle)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerFPS_Cop.DoHitDecal", true);
        byte* paramsPtr = stackalloc byte[188];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitImpactInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitTarget, paramsPtr + 96);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitActor, paramsPtr + 108);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GunMuzzle, paramsPtr + 116);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 128);
    }

    /// <summary>
    /// Function: FireGunNow
    /// </summary>
    public unsafe bool FireGunNow(bool bGunAnimOnly = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerFPS_Cop.FireGunNow", true);
        byte* paramsPtr = stackalloc byte[388];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bGunAnimOnly, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
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
    /// FloatProperty: BulletImpulse
    /// </summary>
    public unsafe float BulletImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3240); }
    }

    /// <summary>
    /// ObjectProperty: HitEffectParticleSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem HitEffectParticleSystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 3244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3244); }
    }

    /// <summary>
    /// ObjectProperty: ShotGun
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform ShotGun
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 3252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3252); }
    }
}
