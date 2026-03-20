#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCwGrappleGun<br/>
/// (size = 7472)
/// (flags = 10485810)
/// </summary>
public partial class RCwGrappleGun : BmSDK.BmGame.RCwGrappleGunBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCwGrappleGun", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCwGrappleGun() { }

    /// <summary>
    /// Constructs a new RCwGrappleGun
    /// </summary>
    public RCwGrappleGun(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCwGrappleGun Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCwGrappleGun(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGun>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGun>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGun>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGun>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGun>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGun>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGun>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: CanAimGrapple
    /// </summary>
    public unsafe bool CanAimGrapple()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.CanAimGrapple", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: RecalculatePath
    /// </summary>
    public unsafe void RecalculatePath()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.RecalculatePath", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsWallClimbMove
    /// </summary>
    public unsafe bool IsWallClimbMove(BmSDK.BmGame.RSpecialMoveConfig Config)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.IsWallClimbMove", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: FindGrapplePointMultipleCones
    /// </summary>
    public unsafe void FindGrapplePointMultipleCones(out BmSDK.TArray<BmSDK.BmGame.RGrappleGun.FGrappleConeDefinition> Cones, float MinAngle)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.FindGrapplePointMultipleCones", true);
        byte* paramsPtr = stackalloc byte[164];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinAngle, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Cones = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGrappleGun.FGrappleConeDefinition>>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: AddCone
    /// </summary>
    public unsafe void AddCone(out BmSDK.TArray<BmSDK.BmGame.RGrappleGun.FGrappleConeDefinition> Cones, float MinAngle, System.Numerics.Vector3 CameraLocation, BmSDK.Rotator CameraRotation, System.Numerics.Vector3 PlayerLocation, bool bZoomed, float OverrideMaxDistance = default, BmSDK.FString Desc = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.AddCone", true);
        byte* paramsPtr = stackalloc byte[80];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinAngle, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraLocation, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraRotation, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerLocation, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bZoomed, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideMaxDistance, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Desc, paramsPtr + 64);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Cones = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGrappleGun.FGrappleConeDefinition>>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: ModifyCone
    /// </summary>
    public unsafe void ModifyCone(out BmSDK.TArray<BmSDK.BmGame.RGrappleGun.FGrappleConeDefinition> Cones, float MinAngle, System.Numerics.Vector3 CameraLocation, BmSDK.Rotator CameraRotation, System.Numerics.Vector3 PlayerLocation, bool bZoomed, float OverrideMaxDistance = default, BmSDK.FString Desc = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.ModifyCone", true);
        byte* paramsPtr = stackalloc byte[84];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinAngle, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraLocation, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraRotation, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerLocation, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bZoomed, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideMaxDistance, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Desc, paramsPtr + 64);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Cones = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGrappleGun.FGrappleConeDefinition>>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: ResetAutoSwing
    /// </summary>
    public unsafe void ResetAutoSwing()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.ResetAutoSwing", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartAutoSwing
    /// </summary>
    public unsafe void StartAutoSwing(bool bTriggeredFromEdge = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.StartAutoSwing", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTriggeredFromEdge, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanSwingFromEdge
    /// </summary>
    public unsafe bool CanSwingFromEdge()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.CanSwingFromEdge", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ScriptTick
    /// </summary>
    public unsafe void ScriptTick(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.ScriptTick", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DrawClimbRoute
    /// </summary>
    public unsafe void DrawClimbRoute(bool bPersistent = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.DrawClimbRoute", true);
        byte* paramsPtr = stackalloc byte[348];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistent, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CheckForSwingEdge
    /// </summary>
    public unsafe void CheckForSwingEdge()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.CheckForSwingEdge", true);
        byte* paramsPtr = stackalloc byte[204];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DrawDebugInfo
    /// </summary>
    public unsafe void DrawDebugInfo()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.DrawDebugInfo", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearDebugInfo
    /// </summary>
    public unsafe void ClearDebugInfo()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.ClearDebugInfo", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DumpTargetInfo
    /// </summary>
    public unsafe void DumpTargetInfo()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.DumpTargetInfo", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetIdealSwingParameters
    /// </summary>
    public unsafe void GetIdealSwingParameters(System.Numerics.Vector3 StartLocation, System.Numerics.Vector3 EndLocation, System.Numerics.Vector3 WallLocation, out float IdealSwingTime, out float IdealSwingLength)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.GetIdealSwingParameters", true);
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallLocation, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        IdealSwingTime = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 36);
        IdealSwingLength = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 40);
        return;
    }

    /// <summary>
    /// Function: GetAerialWhipConfig
    /// </summary>
    public unsafe BmSDK.BmScript.RSpecialMoveConfig_CwAerialWhipPounce GetAerialWhipConfig(System.Numerics.Vector3 StartLocation, System.Numerics.Vector3 EndLocation, System.Numerics.Vector3 WallLocation, BmSDK.BmGame.RPawnPlayerCatwomanBase.ESwingDirection SwingDirection = default, bool bGetSafeMove = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.GetAerialWhipConfig", true);
        byte* paramsPtr = stackalloc byte[76];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallLocation, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SwingDirection, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bGetSafeMove, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSpecialMoveConfig_CwAerialWhipPounce>(paramsPtr + 44);
    }

    /// <summary>
    /// Function: TriggerAerialWhipPounce
    /// </summary>
    public unsafe bool TriggerAerialWhipPounce()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.TriggerAerialWhipPounce", true);
        byte* paramsPtr = stackalloc byte[236];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: TriggerAerialAutoWhipPounce
    /// </summary>
    public unsafe bool TriggerAerialAutoWhipPounce()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.TriggerAerialAutoWhipPounce", true);
        byte* paramsPtr = stackalloc byte[96];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: StartWallClimbCamera
    /// </summary>
    public unsafe void StartWallClimbCamera(System.Numerics.Vector3 CurrentLandLocation, int FirstClimbPointIndex = default, bool bEstimatedLandPoint = default, bool bFromSwing = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.StartWallClimbCamera", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentLandLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FirstClimbPointIndex, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEstimatedLandPoint, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFromSwing, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerClawClimb
    /// </summary>
    public unsafe void TriggerClawClimb(bool bForceClawClimb)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.TriggerClawClimb", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceClawClimb, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerPounce
    /// </summary>
    public unsafe void TriggerPounce()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.TriggerPounce", true);
        byte* paramsPtr = stackalloc byte[228];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TryAerialSwingMove
    /// </summary>
    public unsafe bool TryAerialSwingMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.TryAerialSwingMove", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: Grapple
    /// </summary>
    public unsafe bool Grapple(BmSDK.BmGame.RSpecialMoveConfig OverrideGrappleMove = default, bool bForceSucced = default, bool bTryQueuedGrapple = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.Grapple", true);
        byte* paramsPtr = stackalloc byte[1412];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideGrappleMove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceSucced, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTryQueuedGrapple, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// IntProperty: FrameCount
    /// </summary>
    public unsafe int FrameCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7440); }
    }

    /// <summary>
    /// StructProperty: DirectPounceDetectShift
    /// </summary>
    public unsafe System.Numerics.Vector3 DirectPounceDetectShift
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 7444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7444); }
    }

    /// <summary>
    /// BoolProperty: bDebugDirectPounceFeatureDetection
    /// </summary>
    public unsafe bool bDebugDirectPounceFeatureDetection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7456) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7456); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7456); }
    }

    /// <summary>
    /// BoolProperty: IsAutomaticClimbWall
    /// </summary>
    public unsafe bool IsAutomaticClimbWall
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7456) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7456); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7456); }
    }

    /// <summary>
    /// FloatProperty: ShortJumpOffPitchDown
    /// </summary>
    public unsafe float ShortJumpOffPitchDown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7460); }
    }

    /// <summary>
    /// FloatProperty: ShortJumpOffRelativePitchDown
    /// </summary>
    public unsafe float ShortJumpOffRelativePitchDown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7464); }
    }

    /// <summary>
    /// IntProperty: MaximumClimb
    /// </summary>
    public unsafe int MaximumClimb
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7468); }
    }
}
