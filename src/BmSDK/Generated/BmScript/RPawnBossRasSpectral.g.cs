#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RPawnBossRasSpectral<br/>
/// (size = 4044)
/// (flags = 10485814)
/// </summary>
public partial class RPawnBossRasSpectral : BmSDK.BmScript.RPawnBossRasScriptBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RPawnBossRasSpectral", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPawnBossRasSpectral() { }

    /// <summary>
    /// Constructs a new RPawnBossRasSpectral
    /// </summary>
    public RPawnBossRasSpectral(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPawnBossRasSpectral Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnBossRasSpectral(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnBossRasSpectral>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnBossRasSpectral>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnBossRasSpectral>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnBossRasSpectral>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnBossRasSpectral>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnBossRasSpectral>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnBossRasSpectral>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: GetCombatAimingConfig
    /// </summary>
    public unsafe override BmSDK.BmGame.RAimingConfig GetCombatAimingConfig()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossRasSpectral.GetCombatAimingConfig", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAimingConfig>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SpawnChopAttackBarrier
    /// </summary>
    public unsafe override void SpawnChopAttackBarrier(System.Numerics.Vector3 SwordLoc, BmSDK.Rotator SwordRot)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossRasSpectral.SpawnChopAttackBarrier", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SwordLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SwordRot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DeactivateWaistBlendFX
    /// </summary>
    public unsafe override void DeactivateWaistBlendFX()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossRasSpectral.DeactivateWaistBlendFX", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ActivateWaistBlendFX
    /// </summary>
    public unsafe override void ActivateWaistBlendFX()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossRasSpectral.ActivateWaistBlendFX", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearShurikans
    /// </summary>
    public unsafe virtual void ClearShurikans()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossRasSpectral.ClearShurikans", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossRasSpectral.Destroyed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CreateWeaponConfigUnarmed
    /// </summary>
    public unsafe override BmSDK.BmGame.RWeaponConfig CreateWeaponConfigUnarmed(BmSDK.GameObject NewOwner)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossRasSpectral.CreateWeaponConfigUnarmed", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: CreateSpectralWeaponConfig
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RWeaponConfig CreateSpectralWeaponConfig(BmSDK.GameObject NewOwner)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossRasSpectral.CreateSpectralWeaponConfig", true);
        byte* paramsPtr = stackalloc byte[900];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: Holster
    /// </summary>
    public unsafe virtual void Holster()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossRasSpectral.Holster", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GrabSword
    /// </summary>
    public unsafe virtual void GrabSword()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossRasSpectral.GrabSword", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetVisibilityFx
    /// </summary>
    public unsafe virtual void SetVisibilityFx(float Param)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossRasSpectral.SetVisibilityFx", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Param, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateVisibilityFx
    /// </summary>
    public unsafe virtual void UpdateVisibilityFx(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossRasSpectral.UpdateVisibilityFx", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartDisappear
    /// </summary>
    public unsafe virtual void StartDisappear()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossRasSpectral.StartDisappear", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateFacing
    /// </summary>
    public unsafe virtual void UpdateFacing(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossRasSpectral.UpdateFacing", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OpenEyes
    /// </summary>
    public unsafe virtual void OpenEyes()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossRasSpectral.OpenEyes", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossRasSpectral.Tick", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TryDemonBlastAttack
    /// </summary>
    public unsafe virtual void TryDemonBlastAttack()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossRasSpectral.TryDemonBlastAttack", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TryChopAttack
    /// </summary>
    public unsafe virtual void TryChopAttack()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossRasSpectral.TryChopAttack", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ThrowSFX
    /// </summary>
    public unsafe virtual void ThrowSFX()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossRasSpectral.ThrowSFX", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ChopSFX
    /// </summary>
    public unsafe virtual void ChopSFX()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossRasSpectral.ChopSFX", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SwordLift
    /// </summary>
    public unsafe virtual void SwordLift()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossRasSpectral.SwordLift", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SwordContact
    /// </summary>
    public unsafe virtual void SwordContact()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossRasSpectral.SwordContact", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ReleaseShurikanRight
    /// </summary>
    public unsafe virtual void ReleaseShurikanRight()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossRasSpectral.ReleaseShurikanRight", true);
        byte* paramsPtr = stackalloc byte[88];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnShurikanRight
    /// </summary>
    public unsafe virtual void SpawnShurikanRight()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossRasSpectral.SpawnShurikanRight", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ReleaseShurikanLeft
    /// </summary>
    public unsafe virtual void ReleaseShurikanLeft()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossRasSpectral.ReleaseShurikanLeft", true);
        byte* paramsPtr = stackalloc byte[88];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnShurikanLeft
    /// </summary>
    public unsafe virtual void SpawnShurikanLeft()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossRasSpectral.SpawnShurikanLeft", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TryQueueNextThrow
    /// </summary>
    public unsafe virtual void TryQueueNextThrow()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossRasSpectral.TryQueueNextThrow", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetSwordRotation
    /// </summary>
    public unsafe override BmSDK.Rotator GetSwordRotation()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossRasSpectral.GetSwordRotation", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetSwordLocation
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetSwordLocation()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossRasSpectral.GetSwordLocation", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CreateSword
    /// </summary>
    public unsafe virtual void CreateSword()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossRasSpectral.CreateSword", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetHealth
    /// </summary>
    public unsafe override void SetHealth()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnBossRasSpectral.SetHealth", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: RealRas
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnBossRasBase RealRas
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnBossRasBase>(Ptr + 3896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3896); }
    }

    /// <summary>
    /// IntProperty: CurrBlast
    /// </summary>
    public unsafe int CurrBlast
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3900); }
    }

    /// <summary>
    /// ObjectProperty: Sword
    /// </summary>
    public unsafe BmSDK.BmScript.RBMWeaponRasSword Sword
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RBMWeaponRasSword>(Ptr + 3904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3904); }
    }

    /// <summary>
    /// FloatProperty: MeshScale
    /// </summary>
    public unsafe float MeshScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3908); }
    }

    /// <summary>
    /// FloatProperty: MeshOffset
    /// </summary>
    public unsafe float MeshOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3912); }
    }

    /// <summary>
    /// FloatProperty: OffsetToRas
    /// </summary>
    public unsafe float OffsetToRas
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3916); }
    }

    /// <summary>
    /// FloatProperty: LeftShSpeed
    /// </summary>
    public unsafe float LeftShSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3920); }
    }

    /// <summary>
    /// FloatProperty: LeftShTurnSpeed
    /// </summary>
    public unsafe float LeftShTurnSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3924); }
    }

    /// <summary>
    /// FloatProperty: LeftShThrowDirMod
    /// </summary>
    public unsafe float LeftShThrowDirMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3928); }
    }

    /// <summary>
    /// FloatProperty: LeftShTargetLocMod
    /// </summary>
    public unsafe float LeftShTargetLocMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3932); }
    }

    /// <summary>
    /// FloatProperty: RightShSpeed
    /// </summary>
    public unsafe float RightShSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3936); }
    }

    /// <summary>
    /// FloatProperty: RightShTurnSpeed
    /// </summary>
    public unsafe float RightShTurnSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3940); }
    }

    /// <summary>
    /// FloatProperty: RightShThrowDirMod
    /// </summary>
    public unsafe float RightShThrowDirMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3944); }
    }

    /// <summary>
    /// FloatProperty: RightShTargetLocMod
    /// </summary>
    public unsafe float RightShTargetLocMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3948); }
    }

    /// <summary>
    /// FloatProperty: ShLandOffset
    /// </summary>
    public unsafe float ShLandOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3952); }
    }

    /// <summary>
    /// FloatProperty: ShGroupTargetDistOffset
    /// </summary>
    public unsafe float ShGroupTargetDistOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3956); }
    }

    /// <summary>
    /// FloatProperty: ShGroupTargetLeftOffset
    /// </summary>
    public unsafe float ShGroupTargetLeftOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3960); }
    }

    /// <summary>
    /// FloatProperty: ShGroupTargetRightOffset
    /// </summary>
    public unsafe float ShGroupTargetRightOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3964); }
    }

    /// <summary>
    /// ArrayProperty: AttachedShurikanLeftList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmScript.RRasDemonBlast> AttachedShurikanLeftList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.RRasDemonBlast>>(Ptr + 3968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3968); }
    }

    /// <summary>
    /// ArrayProperty: AttachedShurikanRightList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmScript.RRasDemonBlast> AttachedShurikanRightList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.RRasDemonBlast>>(Ptr + 3980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3980); }
    }

    /// <summary>
    /// ComponentProperty: WaistBlendFXComp
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WaistBlendFXComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 3992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3992); }
    }

    /// <summary>
    /// ComponentProperty: EyeFxLeft
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent EyeFxLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 3996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3996); }
    }

    /// <summary>
    /// ComponentProperty: EyeFxRight
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent EyeFxRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4000); }
    }

    /// <summary>
    /// ObjectProperty: WaistBlendFx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WaistBlendFx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4004); }
    }

    /// <summary>
    /// FloatProperty: VisibilityVal
    /// </summary>
    public unsafe float VisibilityVal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4008); }
    }

    /// <summary>
    /// FloatProperty: TargetVisibilityVal
    /// </summary>
    public unsafe float TargetVisibilityVal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4012); }
    }

    /// <summary>
    /// ObjectProperty: MaterialHair
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant MaterialHair
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 4016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4016); }
    }

    /// <summary>
    /// ObjectProperty: MaterialFace
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant MaterialFace
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 4020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4020); }
    }

    /// <summary>
    /// ObjectProperty: MaterialBody
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant MaterialBody
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 4024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4024); }
    }

    /// <summary>
    /// ObjectProperty: MaterialFins
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant MaterialFins
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 4028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4028); }
    }

    /// <summary>
    /// ObjectProperty: MaterialTrousers
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant MaterialTrousers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 4032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4032); }
    }

    /// <summary>
    /// BoolProperty: bCreateMic
    /// </summary>
    public unsafe bool bCreateMic
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4036) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4036); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4036); }
    }

    /// <summary>
    /// BoolProperty: bSwordInHand
    /// </summary>
    public unsafe bool bSwordInHand
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4036) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4036); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4036); }
    }

    /// <summary>
    /// BoolProperty: bFadeDone
    /// </summary>
    public unsafe bool bFadeDone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4036) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4036); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4036); }
    }

    /// <summary>
    /// FloatProperty: LastYawDelta
    /// </summary>
    public unsafe float LastYawDelta
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4040); }
    }
}
