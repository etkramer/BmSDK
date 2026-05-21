#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RPawnVillainGunPredFull<br/>
/// (size = 6808)
/// (flags = 10485814)
/// </summary>
public partial class RPawnVillainGunPredFull : BmSDK.BmScript.RPawnVillainGunPredAsset, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RPawnVillainGunPredFull", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPawnVillainGunPredFull.
    /// </summary>
    public static RPawnVillainGunPredFull DefaultObject => (RPawnVillainGunPredFull)StaticClass().DefaultObject;

    internal RPawnVillainGunPredFull() { }

    /// <summary>
    /// Constructs a new RPawnVillainGunPredFull
    /// </summary>
    public RPawnVillainGunPredFull(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnVillainGunPredFull(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunPredFull>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunPredFull>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunPredFull>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunPredFull>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunPredFull>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunPredFull>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunPredFull>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunPredFull>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: CreateFullPanicWeaponConfig
    /// </summary>
    public unsafe override BmSDK.BmGame.RWeaponConfig CreateFullPanicWeaponConfig(BmSDK.GameObject NewOwner, BmSDK.Engine.AnimSet AnimSet1, BmSDK.Engine.AnimSet AnimSet2, BmSDK.Engine.AnimSet AnimSet3, BmSDK.Engine.AnimSet AnimSet4, BmSDK.Engine.AnimSet TurnAnimSet2, BmSDK.Engine.AnimSet TerrorTurnAnims, BmSDK.Engine.AnimSet JammerPackAnims, BmSDK.Engine.AnimSet ManDownAnims, BmSDK.Engine.AnimSet MedicAnims, BmSDK.Engine.AnimSet MineLayerAnims, BmSDK.Engine.AnimSet ThermalAnims, BmSDK.Engine.AnimSet GuardAnims, BmSDK.Engine.AnimSet DroneAnims)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainGunPredFull.CreateFullPanicWeaponConfig", true);
        byte* paramsPtr = stackalloc byte[22236];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet1, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet2, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet3, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet4, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TurnAnimSet2, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TerrorTurnAnims, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JammerPackAnims, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ManDownAnims, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MedicAnims, paramsPtr + 72);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MineLayerAnims, paramsPtr + 80);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThermalAnims, paramsPtr + 88);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GuardAnims, paramsPtr + 96);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DroneAnims, paramsPtr + 104);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 112);
    }

    /// <summary>
    /// Function: GetRailPeekAimingConfig
    /// </summary>
    public unsafe static BmSDK.Engine.RAimingConfig GetRailPeekAimingConfig()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainGunPredFull.GetRailPeekAimingConfig", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAimingConfig>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetDisruptorReactionAnimset
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetDisruptorReactionAnimset()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainGunPredFull.GetDisruptorReactionAnimset", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetVoiceSynthAnimSet
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetVoiceSynthAnimSet()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainGunPredFull.GetVoiceSynthAnimSet", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetTerrorGuardAnimSet
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetTerrorGuardAnimSet()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainGunPredFull.GetTerrorGuardAnimSet", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetVaultExplosivesAnimSet
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetVaultExplosivesAnimSet()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainGunPredFull.GetVaultExplosivesAnimSet", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetCorePredAnimSet
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetCorePredAnimSet()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainGunPredFull.GetCorePredAnimSet", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetManDownAnimSet
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetManDownAnimSet()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainGunPredFull.GetManDownAnimSet", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetGrateLookAnimSet
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetGrateLookAnimSet()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainGunPredFull.GetGrateLookAnimSet", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetLedgeLookAnimSet
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetLedgeLookAnimSet()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainGunPredFull.GetLedgeLookAnimSet", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetBuddyBumpAnimset
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetBuddyBumpAnimset()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainGunPredFull.GetBuddyBumpAnimset", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetBuddyJoinAnimset
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetBuddyJoinAnimset()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainGunPredFull.GetBuddyJoinAnimset", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetSideRoomSearchAnimSet
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetSideRoomSearchAnimSet()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainGunPredFull.GetSideRoomSearchAnimSet", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetPairedCornerAnimSet
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetPairedCornerAnimSet()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainGunPredFull.GetPairedCornerAnimSet", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetSoloCornerAnimSet
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetSoloCornerAnimSet()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainGunPredFull.GetSoloCornerAnimSet", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: MineLayerSpawnedInPredVolume
    /// </summary>
    public unsafe override void MineLayerSpawnedInPredVolume()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainGunPredFull.MineLayerSpawnedInPredVolume", true);
        byte* paramsPtr = stackalloc byte[140];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoGrenadeVentThrow
    /// </summary>
    public unsafe override bool DoGrenadeVentThrow(System.Numerics.Vector3 ThrowVel, BmSDK.Rotator SpawnRot, System.Numerics.Vector3 TargetLoc, out BmSDK.BmGame.RProjectile_GrenadeBase NadeProj)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainGunPredFull.DoGrenadeVentThrow", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowVel, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnRot, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLoc, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        NadeProj = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectile_GrenadeBase>(paramsPtr + 36);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 44);
    }

    /// <summary>
    /// Function: SetArmBandMineSynced
    /// </summary>
    public unsafe override void SetArmBandMineSynced()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainGunPredFull.SetArmBandMineSynced", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetArmBandNormal
    /// </summary>
    public unsafe override void SetArmBandNormal()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainGunPredFull.SetArmBandNormal", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SurrenderGun
    /// </summary>
    public unsafe virtual void SurrenderGun()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainGunPredFull.SurrenderGun", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CreateWeapon
    /// </summary>
    public unsafe override BmSDK.BmGame.RBMWeapon CreateWeapon()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainGunPredFull.CreateWeapon", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMWeapon>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: OnFootstepNotify
    /// </summary>
    public unsafe override void OnFootstepNotify(BmSDK.BmGame.RAnimNotify_Footstep.EFoot Foot, BmSDK.BmGame.RAnimNotify_Footstep.EContactType Contact, BmSDK.BmGame.RAnimNotify_Footstep.EFootstepSurfaceFinder SurfaceFinder, System.Numerics.Vector3 FootLocation, float BlendWeight)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainGunPredFull.OnFootstepNotify", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Foot, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Contact, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SurfaceFinder, paramsPtr + 2);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FootLocation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendWeight, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnVantageMine
    /// </summary>
    public unsafe override BmSDK.BmGame.RVantageMineBase SpawnVantageMine()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainGunPredFull.SpawnVantageMine", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVantageMineBase>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetIncendiaryGrenadeClass
    /// </summary>
    public unsafe override BmSDK.Class GetIncendiaryGrenadeClass()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainGunPredFull.GetIncendiaryGrenadeClass", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetSentryGunSpawnClass
    /// </summary>
    public unsafe override BmSDK.Class GetSentryGunSpawnClass()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainGunPredFull.GetSentryGunSpawnClass", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetSentryGunPlacementBehaviourClass
    /// </summary>
    public unsafe override BmSDK.Class GetSentryGunPlacementBehaviourClass()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainGunPredFull.GetSentryGunPlacementBehaviourClass", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CanPlaceSentryGun
    /// </summary>
    public unsafe override bool CanPlaceSentryGun()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainGunPredFull.CanPlaceSentryGun", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetDetectiveModeDetectorAnimSet
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetDetectiveModeDetectorAnimSet()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainGunPredFull.GetDetectiveModeDetectorAnimSet", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetMedicAnimSet
    /// </summary>
    public unsafe override BmSDK.Engine.AnimSet GetMedicAnimSet()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainGunPredFull.GetMedicAnimSet", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    /// <summary>
    /// NameProperty: ArmbandSocket
    /// </summary>
    public unsafe BmSDK.FName ArmbandSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6792); }
    }

    /// <summary>
    /// ObjectProperty: ArmbandMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant ArmbandMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 6800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6800); }
    }
}
