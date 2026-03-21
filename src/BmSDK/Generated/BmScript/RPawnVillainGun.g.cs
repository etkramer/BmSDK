#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RPawnVillainGun<br/>
/// (size = 3652)
/// (flags = 10485814)
/// </summary>
public partial class RPawnVillainGun : BmSDK.BmGame.RPawnVillainGunPredBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RPawnVillainGun", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPawnVillainGun() { }

    /// <summary>
    /// Constructs a new RPawnVillainGun
    /// </summary>
    public RPawnVillainGun(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPawnVillainGun Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnVillainGun(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGun>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGun>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGun>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGun>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGun>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGun>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGun>
        => ((GameObject)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: CreateFullPanicWeaponConfig
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RWeaponConfig CreateFullPanicWeaponConfig(BmSDK.GameObject NewOwner, BmSDK.Engine.AnimSet AnimSet1, BmSDK.Engine.AnimSet AnimSet2, BmSDK.Engine.AnimSet AnimSet3, BmSDK.Engine.AnimSet AnimSet4, BmSDK.Engine.AnimSet AnimSet5, BmSDK.Engine.AnimSet TurnAnimSet2, BmSDK.Engine.AnimSet TerrorTurnAnims)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainGun.CreateFullPanicWeaponConfig", true);
        byte* paramsPtr = stackalloc byte[16228];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet1, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet2, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet3, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet4, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet5, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TurnAnimSet2, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TerrorTurnAnims, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 32);
    }

    /// <summary>
    /// Function: AddPawnProps
    /// </summary>
    public unsafe override void AddPawnProps()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainGun.AddPawnProps", true);
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SonicBatarangCollarFX
    /// </summary>
    public unsafe override void SonicBatarangCollarFX(bool bKillEffect = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainGun.SonicBatarangCollarFX", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKillEffect, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoGrenadeVentThrow
    /// </summary>
    public unsafe override bool DoGrenadeVentThrow(System.Numerics.Vector3 ThrowVel, BmSDK.Rotator SpawnRot, System.Numerics.Vector3 TargetLoc)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainGun.DoGrenadeVentThrow", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowVel, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnRot, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLoc, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 36);
    }

    /// <summary>
    /// Function: NetStopBleep
    /// </summary>
    public unsafe virtual void NetStopBleep()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainGun.NetStopBleep", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StopBleep
    /// </summary>
    public unsafe override void StopBleep()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainGun.StopBleep", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NetStartBleep
    /// </summary>
    public unsafe virtual void NetStartBleep()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainGun.NetStartBleep", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartBleep
    /// </summary>
    public unsafe override void StartBleep()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainGun.StartBleep", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetArmBandMineSynced
    /// </summary>
    public unsafe override void SetArmBandMineSynced()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainGun.SetArmBandMineSynced", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetArmBandNormal
    /// </summary>
    public unsafe override void SetArmBandNormal()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainGun.SetArmBandNormal", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SurrenderGun
    /// </summary>
    public unsafe virtual void SurrenderGun()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainGun.SurrenderGun", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CreateWeapon
    /// </summary>
    public unsafe override BmSDK.BmGame.RBMWeapon CreateWeapon()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainGun.CreateWeapon", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMWeapon>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: PostInitCharacter
    /// </summary>
    public unsafe override void PostInitCharacter()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainGun.PostInitCharacter", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: InjuredBleepSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent InjuredBleepSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 3612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3612); }
    }

    /// <summary>
    /// NameProperty: CollarSocket
    /// </summary>
    public unsafe BmSDK.FName CollarSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 3616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3616); }
    }

    /// <summary>
    /// ObjectProperty: CollarMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant CollarMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 3624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3624); }
    }

    /// <summary>
    /// ObjectProperty: SonicBatarangCollarEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem SonicBatarangCollarEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 3628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3628); }
    }

    /// <summary>
    /// ObjectProperty: SonicBatarangDeathCollarEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem SonicBatarangDeathCollarEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 3632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3632); }
    }

    /// <summary>
    /// ObjectProperty: CollarSoundEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent CollarSoundEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 3636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3636); }
    }

    /// <summary>
    /// StructProperty: CollarSoundHandle
    /// </summary>
    public unsafe BmSDK.Engine.AkWwise.FAkSoundHandle CollarSoundHandle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkWwise.FAkSoundHandle>(Ptr + 3640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3640); }
    }
}
