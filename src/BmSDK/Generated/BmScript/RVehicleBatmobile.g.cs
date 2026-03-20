#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RVehicleBatmobile<br/>
/// (size = 8640)
/// (flags = 0)
/// </summary>
public partial class RVehicleBatmobile : BmSDK.BmGame.RVehicleBatmobileBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RVehicleBatmobile", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RVehicleBatmobile() { }

    /// <summary>
    /// Constructs a new RVehicleBatmobile
    /// </summary>
    public RVehicleBatmobile(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RVehicleBatmobile Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicleBatmobile(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleBatmobile>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleBatmobile>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleBatmobile>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleBatmobile>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleBatmobile>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleBatmobile>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleBatmobile>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: IsBatmobileTouchingAGlideOutOfBoundsVolume
    /// </summary>
    public unsafe bool IsBatmobileTouchingAGlideOutOfBoundsVolume()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.IsBatmobileTouchingAGlideOutOfBoundsVolume", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CheckForUpgrades
    /// </summary>
    public unsafe void CheckForUpgrades(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.CheckForUpgrades", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetOverrideCamera
    /// </summary>
    public unsafe BmSDK.FName GetOverrideCamera()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.GetOverrideCamera", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GrappleSwingIn
    /// </summary>
    public unsafe void GrappleSwingIn(BmSDK.BmGame.RPawnPlayer PlayerPawn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.GrappleSwingIn", true);
        byte* paramsPtr = stackalloc byte[140];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnThugStunEffect
    /// </summary>
    public unsafe void SpawnThugStunEffect(BmSDK.BmGame.RBMPawnAI Thug, System.Numerics.Vector3 ThugDiveDirection)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.SpawnThugStunEffect", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Thug, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThugDiveDirection, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StopWaterImpactEffect
    /// </summary>
    public unsafe void StopWaterImpactEffect()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.StopWaterImpactEffect", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnWaterImpactEffect
    /// </summary>
    public unsafe void SpawnWaterImpactEffect(System.Numerics.Vector3 HitLocation, BmSDK.Engine.Camera PlayerCamera)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.SpawnWaterImpactEffect", true);
        byte* paramsPtr = stackalloc byte[128];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerCamera, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnAbseilImpactRear
    /// </summary>
    public unsafe void SpawnAbseilImpactRear()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.SpawnAbseilImpactRear", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnAbseilImpactFront
    /// </summary>
    public unsafe void SpawnAbseilImpactFront()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.SpawnAbseilImpactFront", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UsedWhenStolen
    /// </summary>
    public unsafe void UsedWhenStolen()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.UsedWhenStolen", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetIsStolen
    /// </summary>
    public unsafe void SetIsStolen(bool Stolen, BmSDK.Engine.SequenceAction Action)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.SetIsStolen", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Stolen, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetDisabledByEMP
    /// </summary>
    public unsafe void SetDisabledByEMP(bool Disabled)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.SetDisabledByEMP", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Disabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateBatmanPickupRoute
    /// </summary>
    public unsafe void UpdateBatmanPickupRoute()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.UpdateBatmanPickupRoute", true);
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: EjectToSpot
    /// </summary>
    public unsafe void EjectToSpot(System.Numerics.Vector3 EjectTarget, BmSDK.BmGame.RPawnPlayer Batman, BmSDK.BmGame.RSpecialMoveConfig OverrideMove = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.EjectToSpot", true);
        byte* paramsPtr = stackalloc byte[160];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EjectTarget, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Batman, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideMove, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PickUpPlayer
    /// </summary>
    public unsafe void PickUpPlayer(BmSDK.BmGame.RPawnPlayer PlayerToPickUp, bool HighSpeedPickup = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.PickUpPlayer", true);
        byte* paramsPtr = stackalloc byte[152];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerToPickUp, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HighSpeedPickup, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DestReachedWithoutPlayer
    /// </summary>
    public unsafe void DestReachedWithoutPlayer()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.DestReachedWithoutPlayer", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DestReachedBrakeToStop
    /// </summary>
    public unsafe void DestReachedBrakeToStop()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.DestReachedBrakeToStop", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SkidToStopJumpIn
    /// </summary>
    public unsafe void SkidToStopJumpIn()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.SkidToStopJumpIn", true);
        byte* paramsPtr = stackalloc byte[140];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DestReachedSkidToStop
    /// </summary>
    public unsafe void DestReachedSkidToStop()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.DestReachedSkidToStop", true);
        byte* paramsPtr = stackalloc byte[140];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanEnterVehicle
    /// </summary>
    public unsafe bool CanEnterVehicle(BmSDK.Engine.Pawn P)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.CanEnterVehicle", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: PancakeOther
    /// </summary>
    public unsafe void PancakeOther(BmSDK.Engine.Pawn Other)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.PancakeOther", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FindExitLocation
    /// </summary>
    public unsafe bool FindExitLocation(out BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator Loc)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.FindExitLocation", true);
        byte* paramsPtr = stackalloc byte[148];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Loc = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 132);
    }

    /// <summary>
    /// Function: DriverLeave
    /// </summary>
    public unsafe bool DriverLeave(bool bForceLeave, bool bReallyForceLeave = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.DriverLeave", true);
        byte* paramsPtr = stackalloc byte[228];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceLeave, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bReallyForceLeave, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: AlertBatmanLeftCar
    /// </summary>
    public unsafe void AlertBatmanLeftCar()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.AlertBatmanLeftCar", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RescueMe
    /// </summary>
    public unsafe bool RescueMe(bool FindOffScreenLocation = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.RescueMe", true);
        byte* paramsPtr = stackalloc byte[268];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FindOffScreenLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: ChooseAlternateSpawnPoint
    /// </summary>
    public unsafe int ChooseAlternateSpawnPoint(out System.Numerics.Vector3 pos, out BmSDK.Rotator Rot)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.ChooseAlternateSpawnPoint", true);
        byte* paramsPtr = stackalloc byte[236];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        pos = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        Rot = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: TriggerWrongWayEvent
    /// </summary>
    public unsafe void TriggerWrongWayEvent()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.TriggerWrongWayEvent", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.Tick", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoXrayUpdate
    /// </summary>
    public unsafe void DoXrayUpdate()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.DoXrayUpdate", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TestTightAreas
    /// </summary>
    public unsafe void TestTightAreas()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.TestTightAreas", true);
        byte* paramsPtr = stackalloc byte[188];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnSleepRBPhysics
    /// </summary>
    public unsafe void OnSleepRBPhysics()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.OnSleepRBPhysics", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnWakeRBPhysics
    /// </summary>
    public unsafe void OnWakeRBPhysics()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.OnWakeRBPhysics", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DriverLeft
    /// </summary>
    public unsafe void DriverLeft()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.DriverLeft", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DriverEnter
    /// </summary>
    public unsafe bool DriverEnter(BmSDK.Engine.Pawn P)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.DriverEnter", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: SpawnRightExhaustBurst
    /// </summary>
    public unsafe void SpawnRightExhaustBurst()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.SpawnRightExhaustBurst", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnLeftExhaustBurst
    /// </summary>
    public unsafe void SpawnLeftExhaustBurst()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.SpawnLeftExhaustBurst", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnSideExhaustBurst
    /// </summary>
    public unsafe void SpawnSideExhaustBurst()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.SpawnSideExhaustBurst", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnExhaustBurst
    /// </summary>
    public unsafe void SpawnExhaustBurst(bool bFront, bool bDoSideExhaustBurst)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.SpawnExhaustBurst", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFront, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoSideExhaustBurst, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SlipstreamOff
    /// </summary>
    public unsafe void SlipstreamOff()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.SlipstreamOff", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SlipstreamOn
    /// </summary>
    public unsafe void SlipstreamOn()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.SlipstreamOn", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AfterburnerWarmupOff
    /// </summary>
    public unsafe void AfterburnerWarmupOff()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.AfterburnerWarmupOff", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AfterburnerWarmupOn
    /// </summary>
    public unsafe void AfterburnerWarmupOn()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.AfterburnerWarmupOn", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetAfterBurnerRumble
    /// </summary>
    public unsafe void SetAfterBurnerRumble(bool bPlay, float fRumbleStrength)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.SetAfterBurnerRumble", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlay, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fRumbleStrength, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AfterburnerOff
    /// </summary>
    public unsafe void AfterburnerOff()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.AfterburnerOff", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AfterburnerOn
    /// </summary>
    public unsafe void AfterburnerOn(bool bFront = default, bool bDoSideExhaustBurst = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.AfterburnerOn", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFront, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoSideExhaustBurst, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AfterburnerOnForDuration
    /// </summary>
    public unsafe void AfterburnerOnForDuration(float Duration, bool bFront = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.AfterburnerOnForDuration", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFront, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HeadlightsOff
    /// </summary>
    public unsafe void HeadlightsOff()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.HeadlightsOff", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ActivateBoostWarmup
    /// </summary>
    public unsafe void ActivateBoostWarmup(bool Activate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.ActivateBoostWarmup", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Activate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerBoost
    /// </summary>
    public unsafe void TriggerBoost()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.TriggerBoost", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TryToFallIn
    /// </summary>
    public unsafe void TryToFallIn(BmSDK.BmGame.RPawnPlayer Player)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.TryToFallIn", true);
        byte* paramsPtr = stackalloc byte[140];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TryToGlideIn
    /// </summary>
    public unsafe void TryToGlideIn(BmSDK.BmGame.RPawnPlayer Player)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.TryToGlideIn", true);
        byte* paramsPtr = stackalloc byte[140];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TryToDrive
    /// </summary>
    public unsafe bool TryToDrive(BmSDK.Engine.Pawn P)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.TryToDrive", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: GetInBatmobileInstant
    /// </summary>
    public unsafe void GetInBatmobileInstant(BmSDK.BmGame.RPawnPlayer PlayerGettingIn, bool bEndOfMatinee = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.GetInBatmobileInstant", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerGettingIn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEndOfMatinee, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetInBatmobile
    /// </summary>
    public unsafe void GetInBatmobile(BmSDK.Engine.Pawn PlayerGettingIn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.GetInBatmobile", true);
        byte* paramsPtr = stackalloc byte[148];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerGettingIn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CheckSpaceToGetOutOfBatmobileFromKismet
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBatmobileBase.EBatmobileGetOutSpace CheckSpaceToGetOutOfBatmobileFromKismet()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.CheckSpaceToGetOutOfBatmobileFromKismet", true);
        byte* paramsPtr = stackalloc byte[136];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBatmobileBase.EBatmobileGetOutSpace>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe void PostBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RVehicleBatmobile.PostBeginPlay", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: GetInMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GetInMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8352); }
    }

    /// <summary>
    /// ObjectProperty: GlideInMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GlideInMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8360); }
    }

    /// <summary>
    /// ObjectProperty: GlideBoostInMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GlideBoostInMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8368); }
    }

    /// <summary>
    /// ObjectProperty: FallInMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig FallInMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8376); }
    }

    /// <summary>
    /// ObjectProperty: GetOutMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GetOutMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8384); }
    }

    /// <summary>
    /// ObjectProperty: GetOutToStandFastMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GetOutToStandFastMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8392); }
    }

    /// <summary>
    /// ObjectProperty: GetOutOnTopMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GetOutOnTopMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8400); }
    }

    /// <summary>
    /// ObjectProperty: GetOutOnTopOnSteepInclineMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GetOutOnTopOnSteepInclineMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8408); }
    }

    /// <summary>
    /// ObjectProperty: EjectUpMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig EjectUpMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8416); }
    }

    /// <summary>
    /// ObjectProperty: EjectForwardMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig EjectForwardMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8424); }
    }

    /// <summary>
    /// ObjectProperty: GetInRemoteMoveFront
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GetInRemoteMoveFront
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8432); }
    }

    /// <summary>
    /// ObjectProperty: GetInRemoteMoveBack
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GetInRemoteMoveBack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8440); }
    }

    /// <summary>
    /// ObjectProperty: JumpInBatmobileSkidStopMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig JumpInBatmobileSkidStopMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8448); }
    }

    /// <summary>
    /// ObjectProperty: GetInWithoutAnimMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GetInWithoutAnimMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8456); }
    }

    /// <summary>
    /// ObjectProperty: EjectWhenBatmobileVerticalMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig EjectWhenBatmobileVerticalMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8464); }
    }

    /// <summary>
    /// ObjectProperty: EjectUpWhenBatmobileVerticalMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig EjectUpWhenBatmobileVerticalMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8472); }
    }

    /// <summary>
    /// ObjectProperty: GetInWhenBatmbileVerticalMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GetInWhenBatmbileVerticalMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8480); }
    }

    /// <summary>
    /// ObjectProperty: SwingInBatmobileAbseilingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig SwingInBatmobileAbseilingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8488); }
    }

    /// <summary>
    /// ObjectProperty: EjectToSpotMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig EjectToSpotMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8496); }
    }

    /// <summary>
    /// ObjectProperty: GetInOnSideMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GetInOnSideMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8504); }
    }

    /// <summary>
    /// ObjectProperty: GetOutOnSideMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GetOutOnSideMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8512); }
    }

    /// <summary>
    /// ObjectProperty: HighSpeedPickupMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig HighSpeedPickupMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 8520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8520); }
    }

    /// <summary>
    /// ObjectProperty: AfterburnerFFWaveForm
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform AfterburnerFFWaveForm
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 8528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8528); }
    }

    /// <summary>
    /// ObjectProperty: TaserSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent TaserSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 8536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8536); }
    }

    /// <summary>
    /// ObjectProperty: StolenAction
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_SetBatmobileState StolenAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_SetBatmobileState>(Ptr + 8544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8544); }
    }

    /// <summary>
    /// ComponentProperty: DisabledByEmpFx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent DisabledByEmpFx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 8552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8552); }
    }

    /// <summary>
    /// IntProperty: GetOutOnTopOnSteepInclinePitch
    /// </summary>
    public unsafe int GetOutOnTopOnSteepInclinePitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8560); }
    }

    /// <summary>
    /// BoolProperty: GlidingIn
    /// </summary>
    public unsafe bool GlidingIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8564) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8564); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8564); }
    }

    /// <summary>
    /// BoolProperty: bAfterburnerIsOn
    /// </summary>
    public unsafe bool bAfterburnerIsOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8564) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8564); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8564); }
    }

    /// <summary>
    /// BoolProperty: bBattleModeAfterBurnerIsOn
    /// </summary>
    public unsafe bool bBattleModeAfterBurnerIsOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8564) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8564); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8564); }
    }

    /// <summary>
    /// BoolProperty: bAfterburnerIsWarming
    /// </summary>
    public unsafe bool bAfterburnerIsWarming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8564) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8564); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8564); }
    }

    /// <summary>
    /// BoolProperty: XrayMaterialsAssigned
    /// </summary>
    public unsafe bool XrayMaterialsAssigned
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8564) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8564); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8564); }
    }

    /// <summary>
    /// ArrayProperty: LeaveCarListeners
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmScript.RCarListenerInterface> LeaveCarListeners
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.RCarListenerInterface>>(Ptr + 8568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8568); }
    }

    /// <summary>
    /// FloatProperty: fAfterburnerStartTime
    /// </summary>
    public unsafe float fAfterburnerStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8584); }
    }

    /// <summary>
    /// FloatProperty: fAfterBurnerRumbleStartStrength
    /// </summary>
    public unsafe float fAfterBurnerRumbleStartStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8588); }
    }

    /// <summary>
    /// FloatProperty: fAfterBurnerRumbleStrengthTimeMultiplier
    /// </summary>
    public unsafe float fAfterBurnerRumbleStrengthTimeMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8592); }
    }

    /// <summary>
    /// FloatProperty: fAfterburnerCutoffStartTime
    /// </summary>
    public unsafe float fAfterburnerCutoffStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8596); }
    }

    /// <summary>
    /// FloatProperty: fAfterBurnerRumbleCutoffStartStrength
    /// </summary>
    public unsafe float fAfterBurnerRumbleCutoffStartStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8600); }
    }

    /// <summary>
    /// FloatProperty: fAfterBurnerRumbleCutoffTimeMultiplier
    /// </summary>
    public unsafe float fAfterBurnerRumbleCutoffTimeMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8604); }
    }

    /// <summary>
    /// ArrayProperty: UpgradedGeneratorBonus
    /// </summary>
    public unsafe BmSDK.TArray<float> UpgradedGeneratorBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 8608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8608); }
    }

    /// <summary>
    /// ArrayProperty: UpgradedGeneratorShielding
    /// </summary>
    public unsafe BmSDK.TArray<float> UpgradedGeneratorShielding
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 8624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8624); }
    }
}
