#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RForensicsDevice<br/>
/// (size = 2100)
/// (flags = 144703634)
/// </summary>
public partial class RForensicsDevice : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RForensicsDevice", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RForensicsDevice() { }

    /// <summary>
    /// Constructs a new RForensicsDevice
    /// </summary>
    public RForensicsDevice(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RForensicsDevice Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RForensicsDevice(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RForensicsDevice>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RForensicsDevice>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RForensicsDevice>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RForensicsDevice>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RForensicsDevice>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RForensicsDevice>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RForensicsDevice>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: ResetAudioStates
    /// </summary>
    public unsafe virtual void ResetAudioStates()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.ResetAudioStates", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.Destroyed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ForensicsSetInBatmobile
    /// </summary>
    public unsafe virtual void ForensicsSetInBatmobile(bool in_batmobile)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.ForensicsSetInBatmobile", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(in_batmobile, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TryStartForensicSideStory
    /// </summary>
    public unsafe virtual bool TryStartForensicSideStory()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.TryStartForensicSideStory", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: TickSideStory
    /// </summary>
    public unsafe virtual void TickSideStory(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.TickSideStory", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetCurrentBatmobileForensicsSideStorySeqAct
    /// </summary>
    public unsafe virtual void SetCurrentBatmobileForensicsSideStorySeqAct(BmSDK.BmGame.RSeqAct_BatmobileForensicsSideStory the_sequence)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.SetCurrentBatmobileForensicsSideStorySeqAct", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(the_sequence, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TickSatNavArrows
    /// </summary>
    public unsafe virtual void TickSatNavArrows(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.TickSatNavArrows", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: UpdateSatNavArrowsAsync
    /// </summary>
    public unsafe virtual void UpdateSatNavArrowsAsync(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.UpdateSatNavArrowsAsync", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: UpdateSatNavArrowsInternal
    /// </summary>
    public unsafe virtual bool UpdateSatNavArrowsInternal(bool GotNewRoute, float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.UpdateSatNavArrowsInternal", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GotNewRoute, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: UpdateSatNavArrows
    /// </summary>
    public unsafe virtual void UpdateSatNavArrows(BmSDK.Engine.Actor Destination, float ObjectiveZ, bool OnlyMainRoads, bool SuppressEjectArrow, bool ToRoadAtSameHeight, bool ToRoadBelow, bool AllowArmouredRoads, float DeltaTime, BmSDK.TArray<BmSDK.BmGame.RRoadNetwork.FOneWayLink> OneWayLinks)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.UpdateSatNavArrows", true);
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Destination, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObjectiveZ, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OnlyMainRoads, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SuppressEjectArrow, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToRoadAtSameHeight, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToRoadBelow, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AllowArmouredRoads, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OneWayLinks, paramsPtr + 36);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: StopRadar
    /// </summary>
    public unsafe virtual void StopRadar()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.StopRadar", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CreateRadarHUD
    /// </summary>
    public unsafe virtual void CreateRadarHUD()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.CreateRadarHUD", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartStopRadarAuto
    /// </summary>
    public unsafe virtual void StartStopRadarAuto()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.StartStopRadarAuto", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetInRiddlerCave
    /// </summary>
    public unsafe virtual void SetInRiddlerCave(bool InRiddlerCave)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.SetInRiddlerCave", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InRiddlerCave, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetRootNetworkString
    /// </summary>
    public unsafe virtual void SetRootNetworkString(BmSDK.FString the_string, bool PermanentlyOnscreen = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.SetRootNetworkString", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(the_string, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PermanentlyOnscreen, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetHeavyTankTrackingActive
    /// </summary>
    public unsafe virtual void SetHeavyTankTrackingActive(bool is_active)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.SetHeavyTankTrackingActive", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_active, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetVehicleTrackingActive
    /// </summary>
    public unsafe virtual void SetVehicleTrackingActive(bool is_active)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.SetVehicleTrackingActive", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_active, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateLOSToCar
    /// </summary>
    public unsafe virtual void UpdateLOSToCar()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.UpdateLOSToCar", true);
        byte* paramsPtr = stackalloc byte[0];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: SetThroughWallViewMeshOutOfRange
    /// </summary>
    public unsafe virtual void SetThroughWallViewMeshOutOfRange(bool OutOfRange)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.SetThroughWallViewMeshOutOfRange", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutOfRange, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetThroughWallViewMeshVisible
    /// </summary>
    public unsafe virtual void SetThroughWallViewMeshVisible(bool bVisible)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.SetThroughWallViewMeshVisible", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVisible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsTrackingVehicle
    /// </summary>
    public unsafe virtual bool IsTrackingVehicle(BmSDK.BmGame.RVehicle TrackedVehicle)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.IsTrackingVehicle", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TrackedVehicle, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: IsTrackingAnyVehicle
    /// </summary>
    public unsafe virtual bool IsTrackingAnyVehicle()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.IsTrackingAnyVehicle", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: TrackedVehicleLost
    /// </summary>
    public unsafe virtual void TrackedVehicleLost()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.TrackedVehicleLost", true);
        byte* paramsPtr = stackalloc byte[9];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TrackVehicle
    /// </summary>
    public unsafe virtual void TrackVehicle(BmSDK.BmGame.RVehicle VehToTrack, bool CanLoseTarget = default, bool CanUntagTarget = default, float TrackingSplineDist = default, bool HighPriority = default, BmSDK.FString ObjectiveName = default, float OverrideSignalLossTime = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.TrackVehicle", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VehToTrack, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CanLoseTarget, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CanUntagTarget, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TrackingSplineDist, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HighPriority, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObjectiveName, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideSignalLossTime, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnSideStorySelected
    /// </summary>
    public unsafe virtual void OnSideStorySelected(BmSDK.BmGame.RSideStoryManager.ActiveSideStoryEnum OldActiveSideStory, BmSDK.BmGame.RSideStoryManager.ActiveSideStoryEnum NewActiveSideStory)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.OnSideStorySelected", true);
        byte* paramsPtr = stackalloc byte[2];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldActiveSideStory, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewActiveSideStory, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnSideStoryVehicleDestroyed
    /// </summary>
    public unsafe virtual void OnSideStoryVehicleDestroyed(BmSDK.BmGame.RVehicleNPC VehicleNPC)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.OnSideStoryVehicleDestroyed", true);
        byte* paramsPtr = stackalloc byte[17];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VehicleNPC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DrawRouteRadar
    /// </summary>
    public unsafe virtual void DrawRouteRadar(BmSDK.Engine.Canvas HudCanvas)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.DrawRouteRadar", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HudCanvas, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: DrawVehicleTargetRoute
    /// </summary>
    public unsafe virtual void DrawVehicleTargetRoute()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.DrawVehicleTargetRoute", true);
        byte* paramsPtr = stackalloc byte[0];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: PreRender
    /// </summary>
    public unsafe virtual void PreRender()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.PreRender", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateVehicleTracker
    /// </summary>
    public unsafe virtual void UpdateVehicleTracker(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.UpdateVehicleTracker", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: SetCameraPulseFxActive
    /// </summary>
    public unsafe virtual void SetCameraPulseFxActive(bool is_active)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.SetCameraPulseFxActive", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_active, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DestroyScanFx
    /// </summary>
    public unsafe virtual void DestroyScanFx()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.DestroyScanFx", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ActivateScanFx
    /// </summary>
    public unsafe virtual void ActivateScanFx()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.ActivateScanFx", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Deactivate
    /// </summary>
    public unsafe virtual void Deactivate()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.Deactivate", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TurnOnXray
    /// </summary>
    public unsafe virtual void TurnOnXray()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.TurnOnXray", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsDetectiveMode
    /// </summary>
    public unsafe virtual bool IsDetectiveMode()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.IsDetectiveMode", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ExitScanMode
    /// </summary>
    public unsafe virtual void ExitScanMode()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.ExitScanMode", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ToggleFilter
    /// </summary>
    public unsafe virtual void ToggleFilter(bool TurnOff = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.ToggleFilter", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TurnOff, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerActivateEvent
    /// </summary>
    public unsafe virtual void TriggerActivateEvent(int Output)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.TriggerActivateEvent", true);
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Output, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsEvidenceInView
    /// </summary>
    public unsafe virtual bool IsEvidenceInView(BmSDK.BmGame.RPhysicalEvidenceBase localEvidence)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.IsEvidenceInView", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(localEvidence, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: ActivateSpecialDeepScanPostProcess
    /// </summary>
    public unsafe virtual void ActivateSpecialDeepScanPostProcess(bool bDoActivate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.ActivateSpecialDeepScanPostProcess", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoActivate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RefreshEvidenceItems
    /// </summary>
    public unsafe virtual void RefreshEvidenceItems()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.RefreshEvidenceItems", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RestoreMaterialsForXray
    /// </summary>
    public unsafe virtual void RestoreMaterialsForXray(bool force_swap = default, bool DoNotSwapPlayerPawn = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.RestoreMaterialsForXray", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(force_swap, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DoNotSwapPlayerPawn, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ResetAllLightEnvironments
    /// </summary>
    public unsafe virtual void ResetAllLightEnvironments()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.ResetAllLightEnvironments", true);
        byte* paramsPtr = stackalloc byte[0];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: SwapMaterialsForXray
    /// </summary>
    public unsafe virtual void SwapMaterialsForXray(bool force_swap = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.SwapMaterialsForXray", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(force_swap, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetForensicsRenderType
    /// </summary>
    public unsafe virtual bool GetForensicsRenderType()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.GetForensicsRenderType", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetForensicsRenderType
    /// </summary>
    public unsafe virtual void SetForensicsRenderType(bool On)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.SetForensicsRenderType", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(On, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SwapMaterialsForGlitchedXray
    /// </summary>
    public unsafe virtual void SwapMaterialsForGlitchedXray(bool force_swap = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.SwapMaterialsForGlitchedXray", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(force_swap, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SwapMaterialsForJammedXray
    /// </summary>
    public unsafe virtual void SwapMaterialsForJammedXray(bool force_swap = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.SwapMaterialsForJammedXray", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(force_swap, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsUsingFilterView
    /// </summary>
    public unsafe virtual bool IsUsingFilterView()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.IsUsingFilterView", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: AddItemToEvidenceArray
    /// </summary>
    public unsafe virtual void AddItemToEvidenceArray(BmSDK.BmGame.RPhysicalEvidenceBase Item)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.AddItemToEvidenceArray", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Item, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: EvidenceItemIdentified
    /// </summary>
    public unsafe virtual void EvidenceItemIdentified()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.EvidenceItemIdentified", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddScannedItemToMap
    /// </summary>
    public unsafe virtual void AddScannedItemToMap(BmSDK.FString EvidenceTrailName, System.Numerics.Vector3 Loc)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.AddScannedItemToMap", true);
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EvidenceTrailName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetZeroToOnePitchScore
    /// </summary>
    public unsafe virtual float GetZeroToOnePitchScore(System.Numerics.Vector3 TargetVector)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.GetZeroToOnePitchScore", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetVector, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: SetSpecialTrackingModeDistance
    /// </summary>
    public unsafe virtual void SetSpecialTrackingModeDistance(float new_distance)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.SetSpecialTrackingModeDistance", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(new_distance, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TrailAdvanced
    /// </summary>
    public unsafe virtual void TrailAdvanced(BmSDK.BmGame.REvidence TheEvidence)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.TrailAdvanced", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheEvidence, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AutoUpdateDetectiveDisplay
    /// </summary>
    public unsafe virtual void AutoUpdateDetectiveDisplay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.AutoUpdateDetectiveDisplay", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetEvidenceDetailActor
    /// </summary>
    public unsafe virtual void SetEvidenceDetailActor(BmSDK.Engine.Actor TheActor)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.SetEvidenceDetailActor", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheActor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DrawHUD
    /// </summary>
    public unsafe virtual void DrawHUD(BmSDK.Engine.Canvas Canvas)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.DrawHUD", true);
        byte* paramsPtr = stackalloc byte[128];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Canvas, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CheckJamming
    /// </summary>
    public unsafe virtual void CheckJamming()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.CheckJamming", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SendJammerVillainToHud
    /// </summary>
    public unsafe virtual void SendJammerVillainToHud(BmSDK.Engine.Canvas Canvas, BmSDK.BmGame.RPawnVillain JammerVillain)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.SendJammerVillainToHud", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Canvas, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JammerVillain, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetAngularDistanceToTarget
    /// </summary>
    public unsafe virtual float GetAngularDistanceToTarget(System.Numerics.Vector3 target_location)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.GetAngularDistanceToTarget", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(target_location, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: GetDistanceToTarget
    /// </summary>
    public unsafe virtual float GetDistanceToTarget(System.Numerics.Vector3 target_location)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.GetDistanceToTarget", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(target_location, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: GetCommsDisruptorMinigameStringForInitialDisruption
    /// </summary>
    public unsafe virtual BmSDK.FString GetCommsDisruptorMinigameStringForInitialDisruption()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.GetCommsDisruptorMinigameStringForInitialDisruption", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetCommsDisruptorMinigameString
    /// </summary>
    public unsafe virtual BmSDK.FString GetCommsDisruptorMinigameString()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.GetCommsDisruptorMinigameString", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: FindClosestActiveJammerSource
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 FindClosestActiveJammerSource()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.FindClosestActiveJammerSource", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: UpdateJammerActorIcons
    /// </summary>
    public unsafe virtual void UpdateJammerActorIcons()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.UpdateJammerActorIcons", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RemoveActorFromJammerList
    /// </summary>
    public unsafe virtual void RemoveActorFromJammerList(BmSDK.Engine.Actor the_actor)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.RemoveActorFromJammerList", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(the_actor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddActorToJammerList
    /// </summary>
    public unsafe virtual void AddActorToJammerList(BmSDK.Engine.Actor the_actor)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.AddActorToJammerList", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(the_actor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShouldShowSatnavToTrackedVehicle
    /// </summary>
    public unsafe virtual bool ShouldShowSatnavToTrackedVehicle()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.ShouldShowSatnavToTrackedVehicle", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsActorValidJammer
    /// </summary>
    public unsafe virtual bool IsActorValidJammer(BmSDK.Engine.Actor the_actor)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.IsActorValidJammer", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(the_actor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: GetCompassAngleToLocation
    /// </summary>
    public unsafe virtual float GetCompassAngleToLocation(System.Numerics.Vector3 TargetLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.GetCompassAngleToLocation", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: GetDistanceFromFreezeLocation
    /// </summary>
    public unsafe virtual float GetDistanceFromFreezeLocation()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.GetDistanceFromFreezeLocation", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SortScreenInfoItemList
    /// </summary>
    public unsafe virtual void SortScreenInfoItemList(out BmSDK.TArray<BmSDK.BmGame.RForensicsDevice.FScreenInfoItem> Items)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.SortScreenInfoItemList", true);
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Items = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RForensicsDevice.FScreenInfoItem>>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: PlayerTick
    /// </summary>
    public unsafe virtual void PlayerTick(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.PlayerTick", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: ResetDetectiveModeGlitch
    /// </summary>
    public unsafe virtual void ResetDetectiveModeGlitch()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.ResetDetectiveModeGlitch", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsFilterChangingOrQueued
    /// </summary>
    public unsafe virtual bool IsFilterChangingOrQueued()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.IsFilterChangingOrQueued", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ChangeFilter
    /// </summary>
    public unsafe virtual void ChangeFilter(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.ChangeFilter", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetInvestigateMovieInfo
    /// </summary>
    public unsafe virtual void SetInvestigateMovieInfo()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.SetInvestigateMovieInfo", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ChangeFilterSettings
    /// </summary>
    public unsafe virtual void ChangeFilterSettings()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.ChangeFilterSettings", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetVisualHudModeInternal
    /// </summary>
    public unsafe virtual void SetVisualHudModeInternal(BmSDK.BmGame.RForensicsDevice.VisualHudMode new_mode)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.SetVisualHudModeInternal", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(new_mode, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ChangeToTargetVisionMode
    /// </summary>
    public unsafe virtual void ChangeToTargetVisionMode(bool ForceChange = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.ChangeToTargetVisionMode", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceChange, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PostChangeToTargetVisionMode
    /// </summary>
    public unsafe virtual void PostChangeToTargetVisionMode(bool WasInSpecialVisionMode, bool IsInSpecialVisionMode)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.PostChangeToTargetVisionMode", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WasInSpecialVisionMode, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsInSpecialVisionMode, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PreChangeToTargetVisionMode
    /// </summary>
    public unsafe virtual void PreChangeToTargetVisionMode()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.PreChangeToTargetVisionMode", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetTargetVisionMode
    /// </summary>
    public unsafe virtual void SetTargetVisionMode(BmSDK.BmGame.RForensicsDevice.VisualHudMode new_mode, bool ForceChange = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.SetTargetVisionMode", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(new_mode, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceChange, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: InstantlySetCurrentVisionMode
    /// </summary>
    public unsafe virtual void InstantlySetCurrentVisionMode(BmSDK.BmGame.RForensicsDevice.VisualHudMode new_mode, bool ForceChange = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.InstantlySetCurrentVisionMode", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(new_mode, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceChange, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ForceDetectiveModeReset
    /// </summary>
    public unsafe virtual void ForceDetectiveModeReset()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.ForceDetectiveModeReset", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayZoomSound
    /// </summary>
    public unsafe virtual void PlayZoomSound(bool ZoomingIn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.PlayZoomSound", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ZoomingIn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsRunning
    /// </summary>
    public unsafe virtual bool IsRunning()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.IsRunning", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsReady
    /// </summary>
    public unsafe virtual bool IsReady()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.IsReady", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: Initialise
    /// </summary>
    public unsafe virtual void Initialise(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.Initialise", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsEvidenceTrailActive
    /// </summary>
    public unsafe virtual bool IsEvidenceTrailActive(BmSDK.BmGame.REvidence EvidenceTrailInfo)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.IsEvidenceTrailActive", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EvidenceTrailInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: SetEvidenceTrailInactive
    /// </summary>
    public unsafe virtual void SetEvidenceTrailInactive(BmSDK.BmGame.REvidence EvidenceInfo)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.SetEvidenceTrailInactive", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EvidenceInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetEvidenceTrailActive
    /// </summary>
    public unsafe virtual void SetEvidenceTrailActive(BmSDK.BmGame.REvidence EvidenceInfo)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.SetEvidenceTrailActive", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EvidenceInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FireCrimeSceneCompletionEvent
    /// </summary>
    public unsafe virtual void FireCrimeSceneCompletionEvent(BmSDK.BmGame.RCrimeSceneBase TheCrimeScene)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.FireCrimeSceneCompletionEvent", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheCrimeScene, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FireCrimeSceneEvidenceEvent
    /// </summary>
    public unsafe virtual void FireCrimeSceneEvidenceEvent(BmSDK.BmGame.RPhysicalEvidenceCrimeScene CSE, int EvidenceEventIndex)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.FireCrimeSceneEvidenceEvent", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CSE, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EvidenceEventIndex, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsInRange
    /// </summary>
    public unsafe virtual bool IsInRange(BmSDK.BmGame.RPhysicalEvidenceBase evidence)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.IsInRange", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(evidence, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: CheckEvidenceScanable
    /// </summary>
    public unsafe virtual bool CheckEvidenceScanable(BmSDK.BmGame.RPhysicalEvidenceBase evidence, out float NotFullyVisible)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.CheckEvidenceScanable", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(evidence, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        NotFullyVisible = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: GetMissingPersonsCount
    /// </summary>
    public unsafe virtual int GetMissingPersonsCount()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.GetMissingPersonsCount", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsEvidenceTrailType
    /// </summary>
    public unsafe virtual bool IsEvidenceTrailType(BmSDK.BmGame.RForensicsDevice.SpecialTrackingMode test_type)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.IsEvidenceTrailType", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(test_type, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.PostBeginPlay", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetForwardRouteLinkAt
    /// </summary>
    public unsafe virtual int GetForwardRouteLinkAt(System.Numerics.Vector3 AtLoc, System.Numerics.Vector3 Dir, int MaxIndexInRoute, out int StartPt, out int IndexInRoute)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.GetForwardRouteLinkAt", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AtLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Dir, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxIndexInRoute, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        StartPt = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 28);
        IndexInRoute = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 32);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 36);
    }

    /// <summary>
    /// Function: GetForwardRouteDirectionAt
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetForwardRouteDirectionAt(System.Numerics.Vector3 AtLoc)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RForensicsDevice.GetForwardRouteDirectionAt", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AtLoc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
    }

    /// <summary>
    /// Struct: FScreenInfoItem
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial record struct FScreenInfoItem
    {
        /// <summary>
        /// FloatProperty: X
        /// </summary>
        public unsafe float X
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: Y
        /// </summary>
        public unsafe float Y
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ObjectProperty: Object
        /// </summary>
        public unsafe BmSDK.BmGame.RPhysicalEvidenceBase Object
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPhysicalEvidenceBase>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ObjectProperty: Actor
        /// </summary>
        public unsafe BmSDK.Engine.Actor Actor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// BoolProperty: Valid
        /// </summary>
        public unsafe bool Valid
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 24); }; }
        }

        /// <summary>
        /// StructProperty: Location
        /// </summary>
        public unsafe System.Numerics.Vector3 Location
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }
    }

    /// <summary>
    /// Enum: VisualHudMode
    /// </summary>
    public enum VisualHudMode
    {
        VHM_NormalView = 0,
        VHM_DetectiveMode = 1,
        VHM_ScanMode = 2,
        VHM_MAX = 3,
    }

    /// <summary>
    /// Enum: SpecialTrackingMode
    /// </summary>
    public enum SpecialTrackingMode
    {
        SPM_None = 0,
        SPM_RadioReceiver = 1,
        SPM_FreezeLocation = 2,
        SPM_MainPathEvidenceTrail = 3,
        SPM_SideStoryEvidenceTrail = 4,
        SPM_TripleEvidenceTrail = 5,
        SPM_MAX = 6,
    }

    /// <summary>
    /// Enum: FlashStates
    /// </summary>
    public enum FlashStates
    {
        FlS_Up = 0,
        FlS_Hold = 1,
        FlS_Down = 2,
        FlS_FinishOff = 3,
        FlS_End = 4,
        FlS_MAX = 5,
    }

    /// <summary>
    /// Enum: EvidenceVisibleState
    /// </summary>
    public enum EvidenceVisibleState
    {
        EVS_Hidden = 0,
        EVS_Visible_Physical = 1,
        EVS_Visible_Filter = 2,
        EVS_Highlighted = 3,
        EVS_MAX = 4,
    }

    /// <summary>
    /// Enum: EvidenceDisplayState
    /// </summary>
    public enum EvidenceDisplayState
    {
        EDS_ScannerNonScan = 0,
        EDS_Scanner = 1,
        EDS_Filter = 2,
        EDS_MAX = 3,
    }

    /// <summary>
    /// Enum: DevicePostProcessEffects
    /// </summary>
    public enum DevicePostProcessEffects
    {
        DPPE_Xray = 0,
        DPPE_Distortion = 1,
        DPPE_Scan = 2,
        DPPE_Off = 3,
        DPPE_MAX = 4,
    }

    /// <summary>
    /// ObjectProperty: RPC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController RPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ObjectProperty: FilterNoiseOn
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FilterNoiseOn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// ObjectProperty: FilterNoiseOff
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FilterNoiseOff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// ObjectProperty: ZoomInNoise
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ZoomInNoise
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// ObjectProperty: ZoomInState
    /// </summary>
    public unsafe BmSDK.Engine.AkStateName ZoomInState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkStateName>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// ObjectProperty: ZoomParameter
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName ZoomParameter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// ObjectProperty: ZoomOutNoise
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ZoomOutNoise
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// ObjectProperty: ZoomOutState
    /// </summary>
    public unsafe BmSDK.Engine.AkStateName ZoomOutState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkStateName>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// ObjectProperty: ChangeFilterModeSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ChangeFilterModeSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// ObjectProperty: DetectiveModeJammingOn
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent DetectiveModeJammingOn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// ObjectProperty: DetectiveModeJammingOff
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent DetectiveModeJammingOff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// ObjectProperty: mCaseFileDeactivateSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent mCaseFileDeactivateSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// ObjectProperty: mCaseFileActivateSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent mCaseFileActivateSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// ObjectProperty: ForensicTrailList
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionClass ForensicTrailList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionClass>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ObjectProperty: FreezeLocationMarker
    /// </summary>
    public unsafe BmSDK.Engine.Actor FreezeLocationMarker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// ObjectProperty: RadioLocationMarker
    /// </summary>
    public unsafe BmSDK.Engine.Actor RadioLocationMarker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// ObjectProperty: CurrentEvidenceDetailActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor CurrentEvidenceDetailActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// ObjectProperty: CurrentDetectiveDisplayActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor CurrentDetectiveDisplayActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// ObjectProperty: VehicleTrackerTrackedVehicle
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle VehicleTrackerTrackedVehicle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// ObjectProperty: VehicleTrackerLostVehicle
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle VehicleTrackerLostVehicle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// ObjectProperty: SideStoryFailedThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech SideStoryFailedThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// ObjectProperty: ActivePenguinVan
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleNPC ActivePenguinVan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPC>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// ObjectProperty: ActiveApc
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleNPC ActiveApc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPC>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// ObjectProperty: VehicleTrackerThroughWallViewMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface VehicleTrackerThroughWallViewMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// ObjectProperty: VehicleTrackerThroughWallViewOutOfRangeMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface VehicleTrackerThroughWallViewOutOfRangeMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// ObjectProperty: CurrentAugmentedForensicsSeqAct
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_AugmentedForensicsBase CurrentAugmentedForensicsSeqAct
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_AugmentedForensicsBase>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// ObjectProperty: SatNavSplineArchetype
    /// </summary>
    public unsafe BmSDK.Engine.SplineLoftActor SatNavSplineArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SplineLoftActor>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// ObjectProperty: SatNavRoadNetwork
    /// </summary>
    public unsafe BmSDK.BmGame.RRoadNetwork SatNavRoadNetwork
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadNetwork>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// ObjectProperty: SatNavSplineMat
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant SatNavSplineMat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// ObjectProperty: SatNavForwardRouteRoads
    /// </summary>
    public unsafe BmSDK.BmGame.RRoadNetwork SatNavForwardRouteRoads
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadNetwork>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// ObjectProperty: VehTrackSplineArchetype
    /// </summary>
    public unsafe BmSDK.Engine.SplineLoftActor VehTrackSplineArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SplineLoftActor>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// ObjectProperty: CurrentBatmobileForensicsSideStorySeqAct
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_BatmobileForensicsSideStory CurrentBatmobileForensicsSideStorySeqAct
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_BatmobileForensicsSideStory>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// ObjectProperty: CurrentAdvanceEvent
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqEvent_EvidenceTrailAdvanced CurrentAdvanceEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqEvent_EvidenceTrailAdvanced>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }

    /// <summary>
    /// ComponentProperty: SatNavUpArrow
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent SatNavUpArrow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// ComponentProperty: VehicleTrackerThroughWallViewMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent VehicleTrackerThroughWallViewMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// ComponentProperty: XrayLightFalloff
    /// </summary>
    public unsafe BmSDK.Engine.PointLightComponent XrayLightFalloff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PointLightComponent>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// ComponentProperty: XrayLight
    /// </summary>
    public unsafe BmSDK.Engine.PointLightComponent XrayLight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PointLightComponent>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// ComponentProperty: CameraPulseFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent CameraPulseFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// ComponentProperty: ScanFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ScanFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// ArrayProperty: ViewPP
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RViewPostProcess> ViewPP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RViewPostProcess>>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }

    /// <summary>
    /// ArrayProperty: EvidenceArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPhysicalEvidenceBase> EvidenceArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPhysicalEvidenceBase>>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// BoolProperty: bShowDetectiveModeInfoDuringCinematicMode
    /// </summary>
    public unsafe bool bShowDetectiveModeInfoDuringCinematicMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bHideDetectiveDataInNormalMode
    /// </summary>
    public unsafe bool bHideDetectiveDataInNormalMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bIsInFilterMode
    /// </summary>
    public unsafe bool bIsInFilterMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bFilterShutdownRequested
    /// </summary>
    public unsafe bool bFilterShutdownRequested
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bIsFlashOutro
    /// </summary>
    public unsafe bool bIsFlashOutro
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bInScanMode
    /// </summary>
    public unsafe bool bInScanMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bFilterChangeRequested
    /// </summary>
    public unsafe bool bFilterChangeRequested
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bRestoreXrayWhenFlashFinished
    /// </summary>
    public unsafe bool bRestoreXrayWhenFlashFinished
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bCameraPulseActive
    /// </summary>
    public unsafe bool bCameraPulseActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bUseCameraPulse
    /// </summary>
    public unsafe bool bUseCameraPulse
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bCanUseForensicsDeviceDirectly
    /// </summary>
    public unsafe bool bCanUseForensicsDeviceDirectly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bDisableForensicHUDMovie
    /// </summary>
    public unsafe bool bDisableForensicHUDMovie
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bDisableForensicHUDText
    /// </summary>
    public unsafe bool bDisableForensicHUDText
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bIsCommunicationDisrupted
    /// </summary>
    public unsafe bool bIsCommunicationDisrupted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bSuppressForensicsOffSound
    /// </summary>
    public unsafe bool bSuppressForensicsOffSound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bInRiddlerCave
    /// </summary>
    public unsafe bool bInRiddlerCave
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bDetectiveModeJammingSoundActive
    /// </summary>
    public unsafe bool bDetectiveModeJammingSoundActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: mbIsGlitchesEnable
    /// </summary>
    public unsafe bool mbIsGlitchesEnable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: mExitedCaseFile
    /// </summary>
    public unsafe bool mExitedCaseFile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bXrayKeepSceneLights
    /// </summary>
    public unsafe bool bXrayKeepSceneLights
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bXrayUseSpecialShading
    /// </summary>
    public unsafe bool bXrayUseSpecialShading
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bXrayUsePointCloudShader
    /// </summary>
    public unsafe bool bXrayUsePointCloudShader
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: SpecialTrackingModeAlertsEnabled
    /// </summary>
    public unsafe bool SpecialTrackingModeAlertsEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: LastEvidenceTrailActivationState
    /// </summary>
    public unsafe bool LastEvidenceTrailActivationState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bEvidenceIsHighlighted
    /// </summary>
    public unsafe bool bEvidenceIsHighlighted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bIsBatman
    /// </summary>
    public unsafe bool bIsBatman
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bIsRobin
    /// </summary>
    public unsafe bool bIsRobin
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: VehicleTrackerHighPriority
    /// </summary>
    public unsafe bool VehicleTrackerHighPriority
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: VehicleTrackerCarCountsAsVisible
    /// </summary>
    public unsafe bool VehicleTrackerCarCountsAsVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: VehicleTrackerCarReachedDestination
    /// </summary>
    public unsafe bool VehicleTrackerCarReachedDestination
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bFiredBatmanSeenTrackedVehicleEvent
    /// </summary>
    public unsafe bool bFiredBatmanSeenTrackedVehicleEvent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: ViewMeshOutOfRange
    /// </summary>
    public unsafe bool ViewMeshOutOfRange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1012); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1012); }
    }

    /// <summary>
    /// BoolProperty: bLocalRadarHudIsActive
    /// </summary>
    public unsafe bool bLocalRadarHudIsActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: bVehicleTrackerRadarActive
    /// </summary>
    public unsafe bool bVehicleTrackerRadarActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: bHeavyTankTrackerRadarActive
    /// </summary>
    public unsafe bool bHeavyTankTrackerRadarActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: LosBeneathThreshold
    /// </summary>
    public unsafe bool LosBeneathThreshold
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: bCanLoseTarget
    /// </summary>
    public unsafe bool bCanLoseTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: bCanUntagTarget
    /// </summary>
    public unsafe bool bCanUntagTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: bDrawTargetRoute
    /// </summary>
    public unsafe bool bDrawTargetRoute
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: DisableSatNav
    /// </summary>
    public unsafe bool DisableSatNav
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: SatNavRouteFull
    /// </summary>
    public unsafe bool SatNavRouteFull
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: SatNavWrongWay
    /// </summary>
    public unsafe bool SatNavWrongWay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: SatNavForwardRouteIsLoop
    /// </summary>
    public unsafe bool SatNavForwardRouteIsLoop
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: SatNavForwardRouteShowOnHUD
    /// </summary>
    public unsafe bool SatNavForwardRouteShowOnHUD
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: bRadarJammed
    /// </summary>
    public unsafe bool bRadarJammed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: ForceSatNavRefresh
    /// </summary>
    public unsafe bool ForceSatNavRefresh
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1016); }
    }

    /// <summary>
    /// FloatProperty: ScanTimer
    /// </summary>
    public unsafe float ScanTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// ByteProperty: RequestedFilterMode
    /// </summary>
    public unsafe BmSDK.BmGame.RForensicsDevice.DevicePostProcessEffects RequestedFilterMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RForensicsDevice.DevicePostProcessEffects>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// ByteProperty: CurrentFilterMode
    /// </summary>
    public unsafe BmSDK.BmGame.RForensicsDevice.DevicePostProcessEffects CurrentFilterMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RForensicsDevice.DevicePostProcessEffects>(Ptr + 1025); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1025); }
    }

    /// <summary>
    /// ByteProperty: RequestedFilterModeForDetectiveMode
    /// </summary>
    public unsafe BmSDK.BmGame.RForensicsDevice.DevicePostProcessEffects RequestedFilterModeForDetectiveMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RForensicsDevice.DevicePostProcessEffects>(Ptr + 1026); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1026); }
    }

    /// <summary>
    /// ByteProperty: TrackingModePostProcess
    /// </summary>
    public unsafe BmSDK.BmGame.RForensicsDevice.DevicePostProcessEffects TrackingModePostProcess
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RForensicsDevice.DevicePostProcessEffects>(Ptr + 1027); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1027); }
    }

    /// <summary>
    /// ByteProperty: CurrentVisualHudMode
    /// </summary>
    public unsafe BmSDK.BmGame.RForensicsDevice.VisualHudMode CurrentVisualHudMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RForensicsDevice.VisualHudMode>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// ByteProperty: CurrentVisionMode
    /// </summary>
    public unsafe BmSDK.BmGame.RForensicsDevice.VisualHudMode CurrentVisionMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RForensicsDevice.VisualHudMode>(Ptr + 1029); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1029); }
    }

    /// <summary>
    /// ByteProperty: TargetVisionMode
    /// </summary>
    public unsafe BmSDK.BmGame.RForensicsDevice.VisualHudMode TargetVisionMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RForensicsDevice.VisualHudMode>(Ptr + 1030); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1030); }
    }

    /// <summary>
    /// ByteProperty: CurrentFlashState
    /// </summary>
    public unsafe BmSDK.BmGame.RForensicsDevice.FlashStates CurrentFlashState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RForensicsDevice.FlashStates>(Ptr + 1031); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1031); }
    }

    /// <summary>
    /// ByteProperty: SideStoryFailed
    /// </summary>
    public unsafe BmSDK.BmGame.RSideStoryManager.ActiveSideStoryEnum SideStoryFailed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSideStoryManager.ActiveSideStoryEnum>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// IntProperty: FilterChangeFinishOffTicker
    /// </summary>
    public unsafe int FilterChangeFinishOffTicker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// FloatProperty: FilterChangeTimer
    /// </summary>
    public unsafe float FilterChangeTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// IntProperty: HasSetFilterMovieMode
    /// </summary>
    public unsafe int HasSetFilterMovieMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// FloatProperty: CurrentScannerPower
    /// </summary>
    public unsafe float CurrentScannerPower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }

    /// <summary>
    /// FloatProperty: TimeForFlash
    /// </summary>
    public unsafe float TimeForFlash
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }

    /// <summary>
    /// FloatProperty: TimeForHold
    /// </summary>
    public unsafe float TimeForHold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }

    /// <summary>
    /// FloatProperty: DistanceToTrailProximityNode
    /// </summary>
    public unsafe float DistanceToTrailProximityNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }

    /// <summary>
    /// FloatProperty: DistanceToTrailProximityNodeLast
    /// </summary>
    public unsafe float DistanceToTrailProximityNodeLast
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }

    /// <summary>
    /// FloatProperty: AngularDistanceFromProximityNode
    /// </summary>
    public unsafe float AngularDistanceFromProximityNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1068); }
    }

    /// <summary>
    /// StrProperty: TrailName
    /// </summary>
    public unsafe BmSDK.FString TrailName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceLastForensicsRequest
    /// </summary>
    public unsafe float TimeSinceLastForensicsRequest
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// ArrayProperty: JammingActors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> JammingActors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// InterfaceProperty: ClosestJammerActor
    /// </summary>
    public unsafe BmSDK.BmGame.RJammerInterface ClosestJammerActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RJammerInterface>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }

    /// <summary>
    /// IntProperty: NumJammingActorTargetsVisible
    /// </summary>
    public unsafe int NumJammingActorTargetsVisible
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }

    /// <summary>
    /// FloatProperty: SpecialTrackingModeAlertThreshold
    /// </summary>
    public unsafe float SpecialTrackingModeAlertThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }

    /// <summary>
    /// FloatProperty: SpecialTrackingModeCurrentBestDistance
    /// </summary>
    public unsafe float SpecialTrackingModeCurrentBestDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// StrProperty: LastEvidenceTrailQueried
    /// </summary>
    public unsafe BmSDK.FString LastEvidenceTrailQueried
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// StructProperty: vVirtualDisruptorTowerLocationStart
    /// </summary>
    public unsafe System.Numerics.Vector3 vVirtualDisruptorTowerLocationStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// StructProperty: vVirtualDisruptorTowerLocationEnd
    /// </summary>
    public unsafe System.Numerics.Vector3 vVirtualDisruptorTowerLocationEnd
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1164); }
    }

    /// <summary>
    /// FloatProperty: fVirtualDisruptorTowerTimer
    /// </summary>
    public unsafe float fVirtualDisruptorTowerTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }

    /// <summary>
    /// FloatProperty: fJammedDetectiveModeGlitchTimer
    /// </summary>
    public unsafe float fJammedDetectiveModeGlitchTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1180); }
    }

    /// <summary>
    /// IntProperty: iJammedDetectiveModeGlitchCount
    /// </summary>
    public unsafe int iJammedDetectiveModeGlitchCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }
    }

    /// <summary>
    /// FloatProperty: JammedDetectiveModeGlitchPeriodMin
    /// </summary>
    public unsafe float JammedDetectiveModeGlitchPeriodMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }

    /// <summary>
    /// FloatProperty: JammedDetectiveModeGlitchPeriodRange
    /// </summary>
    public unsafe float JammedDetectiveModeGlitchPeriodRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }
    }

    /// <summary>
    /// FloatProperty: JammedDetectiveModeGlitchDuration
    /// </summary>
    public unsafe float JammedDetectiveModeGlitchDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1196); }
    }

    /// <summary>
    /// FloatProperty: DetectiveModeFOVModifier
    /// </summary>
    public unsafe float DetectiveModeFOVModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1200); }
    }

    /// <summary>
    /// StructProperty: PostProcessOverride
    /// </summary>
    public unsafe BmSDK.Engine.PostProcessVolume.FPostProcessSettings PostProcessOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PostProcessVolume.FPostProcessSettings>(Ptr + 1204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1204); }
    }

    /// <summary>
    /// FloatProperty: VehicleTrackerLastRealLOSTime
    /// </summary>
    public unsafe float VehicleTrackerLastRealLOSTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1728); }
    }

    /// <summary>
    /// StrProperty: VehicleTrackerTrackedVehicleObjective
    /// </summary>
    public unsafe BmSDK.FString VehicleTrackerTrackedVehicleObjective
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1732); }
    }

    /// <summary>
    /// FloatProperty: SideStoryFailedDelay
    /// </summary>
    public unsafe float SideStoryFailedDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1748); }
    }

    /// <summary>
    /// FloatProperty: MaxOnscreenCos
    /// </summary>
    public unsafe float MaxOnscreenCos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1752); }
    }

    /// <summary>
    /// FloatProperty: LosLockon
    /// </summary>
    public unsafe float LosLockon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1756); }
    }

    /// <summary>
    /// FloatProperty: LosLockonOnHud
    /// </summary>
    public unsafe float LosLockonOnHud
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1760); }
    }

    /// <summary>
    /// FloatProperty: LockOn_TimeToFullyLose
    /// </summary>
    public unsafe float LockOn_TimeToFullyLose
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1764); }
    }

    /// <summary>
    /// FloatProperty: LockOn_TimeToFullyGain
    /// </summary>
    public unsafe float LockOn_TimeToFullyGain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1768); }
    }

    /// <summary>
    /// FloatProperty: LockOn_ThresholdForWarningFlash
    /// </summary>
    public unsafe float LockOn_ThresholdForWarningFlash
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1772); }
    }

    /// <summary>
    /// FloatProperty: OnscreenTime
    /// </summary>
    public unsafe float OnscreenTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1776); }
    }

    /// <summary>
    /// FloatProperty: OffScreenTime
    /// </summary>
    public unsafe float OffScreenTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1780); }
    }

    /// <summary>
    /// FloatProperty: VehicleTrackerMaxRangeForTestLos
    /// </summary>
    public unsafe float VehicleTrackerMaxRangeForTestLos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1784); }
    }

    /// <summary>
    /// FloatProperty: VehicleTrackerMaxRangeForTestLosInBatmobile
    /// </summary>
    public unsafe float VehicleTrackerMaxRangeForTestLosInBatmobile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1788); }
    }

    /// <summary>
    /// FloatProperty: carOffScreenGraceTime
    /// </summary>
    public unsafe float carOffScreenGraceTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1792); }
    }

    /// <summary>
    /// FloatProperty: DrawTargetRouteRange
    /// </summary>
    public unsafe float DrawTargetRouteRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1796); }
    }

    /// <summary>
    /// FloatProperty: ChaseSplineBackDist
    /// </summary>
    public unsafe float ChaseSplineBackDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1800); }
    }

    /// <summary>
    /// FloatProperty: ChaseSplineFwdDist
    /// </summary>
    public unsafe float ChaseSplineFwdDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1804); }
    }

    /// <summary>
    /// StructProperty: SatNavDestinationLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 SatNavDestinationLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1808); }
    }

    /// <summary>
    /// IntProperty: SatNavEndLinkRaw
    /// </summary>
    public unsafe int SatNavEndLinkRaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1820); }
    }

    /// <summary>
    /// FloatProperty: SatNavEndLinkRawTime
    /// </summary>
    public unsafe float SatNavEndLinkRawTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1824); }
    }

    /// <summary>
    /// ArrayProperty: SatNavRoute
    /// </summary>
    public unsafe BmSDK.TArray<int> SatNavRoute
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1828); }
    }

    /// <summary>
    /// ArrayProperty: SatNavRouteSpans
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RRoadNetwork.FRoadNetworkSpan> SatNavRouteSpans
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RRoadNetwork.FRoadNetworkSpan>>(Ptr + 1844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1844); }
    }

    /// <summary>
    /// ArrayProperty: SatNavRacingLine
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RRoadNetwork.FRacingLineSeg> SatNavRacingLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RRoadNetwork.FRacingLineSeg>>(Ptr + 1860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1860); }
    }

    /// <summary>
    /// IntProperty: SatNavStartLink
    /// </summary>
    public unsafe int SatNavStartLink
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1876); }
    }

    /// <summary>
    /// IntProperty: SatNavEndLink
    /// </summary>
    public unsafe int SatNavEndLink
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1880); }
    }

    /// <summary>
    /// IntProperty: SatNavStartPoint
    /// </summary>
    public unsafe int SatNavStartPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1884); }
    }

    /// <summary>
    /// ArrayProperty: SatNavSpline
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SplineLoftActor> SatNavSpline
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SplineLoftActor>>(Ptr + 1888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1888); }
    }

    /// <summary>
    /// NameProperty: SatNavSplineFadeNearName
    /// </summary>
    public unsafe BmSDK.FName SatNavSplineFadeNearName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1904); }
    }

    /// <summary>
    /// NameProperty: SatNavSplineFadeFarName
    /// </summary>
    public unsafe BmSDK.FName SatNavSplineFadeFarName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1912); }
    }

    /// <summary>
    /// NameProperty: SatNavSplineBrightnessName
    /// </summary>
    public unsafe BmSDK.FName SatNavSplineBrightnessName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1920); }
    }

    /// <summary>
    /// NameProperty: SatNavSplineWrongWayName
    /// </summary>
    public unsafe BmSDK.FName SatNavSplineWrongWayName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1928); }
    }

    /// <summary>
    /// FloatProperty: CameraToBatmobileDist
    /// </summary>
    public unsafe float CameraToBatmobileDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1936); }
    }

    /// <summary>
    /// FloatProperty: CameraToBatmobileAngle
    /// </summary>
    public unsafe float CameraToBatmobileAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1940); }
    }

    /// <summary>
    /// FloatProperty: SatNavFadeIn
    /// </summary>
    public unsafe float SatNavFadeIn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1944); }
    }

    /// <summary>
    /// FloatProperty: SatNavWantFadeIn
    /// </summary>
    public unsafe float SatNavWantFadeIn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1948); }
    }

    /// <summary>
    /// IntProperty: SatNavNumArrows
    /// </summary>
    public unsafe int SatNavNumArrows
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1952); }
    }

    /// <summary>
    /// FloatProperty: SatNavArrowsOffset
    /// </summary>
    public unsafe float SatNavArrowsOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1956); }
    }

    /// <summary>
    /// FloatProperty: SatNavArrowsSpacing
    /// </summary>
    public unsafe float SatNavArrowsSpacing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1960); }
    }

    /// <summary>
    /// StructProperty: SatNavFirstArrowDir
    /// </summary>
    public unsafe System.Numerics.Vector3 SatNavFirstArrowDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1964); }
    }

    /// <summary>
    /// StructProperty: SatNavFirstLinkDir
    /// </summary>
    public unsafe System.Numerics.Vector3 SatNavFirstLinkDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1976); }
    }

    /// <summary>
    /// StructProperty: SatNavEndLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 SatNavEndLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1988); }
    }

    /// <summary>
    /// StructProperty: SatNavBatmobileDir
    /// </summary>
    public unsafe System.Numerics.Vector3 SatNavBatmobileDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2000); }
    }

    /// <summary>
    /// FloatProperty: BatmobileStationaryTime
    /// </summary>
    public unsafe float BatmobileStationaryTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2012); }
    }

    /// <summary>
    /// FloatProperty: SatNavWrongWayTime
    /// </summary>
    public unsafe float SatNavWrongWayTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2016); }
    }

    /// <summary>
    /// IntProperty: SatNavSide
    /// </summary>
    public unsafe int SatNavSide
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2020); }
    }

    /// <summary>
    /// StructProperty: SatNavRouteJob
    /// </summary>
    public unsafe System.IntPtr SatNavRouteJob
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2024); }
    }

    /// <summary>
    /// IntProperty: SatNavForwardRouteStartPoint
    /// </summary>
    public unsafe int SatNavForwardRouteStartPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2032); }
    }

    /// <summary>
    /// ArrayProperty: SatNavForwardRoute
    /// </summary>
    public unsafe BmSDK.TArray<int> SatNavForwardRoute
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2036); }
    }

    /// <summary>
    /// IntProperty: SatNavForwardRouteNearLink
    /// </summary>
    public unsafe int SatNavForwardRouteNearLink
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2052); }
    }

    /// <summary>
    /// IntProperty: SatNavForwardRouteNearPoint
    /// </summary>
    public unsafe int SatNavForwardRouteNearPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2056); }
    }

    /// <summary>
    /// IntProperty: SatNavForwardRouteSide
    /// </summary>
    public unsafe int SatNavForwardRouteSide
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2060); }
    }

    /// <summary>
    /// IntProperty: SatNavForwardRouteCheckpoint
    /// </summary>
    public unsafe int SatNavForwardRouteCheckpoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2064); }
    }

    /// <summary>
    /// IntProperty: SatNavForwardRoutePrevCheckpoint
    /// </summary>
    public unsafe int SatNavForwardRoutePrevCheckpoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2068); }
    }

    /// <summary>
    /// IntProperty: SatNavForwardRoutePrevPrevCheckpoint
    /// </summary>
    public unsafe int SatNavForwardRoutePrevPrevCheckpoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2072); }
    }

    /// <summary>
    /// FloatProperty: SatNavForwardRouteSign
    /// </summary>
    public unsafe float SatNavForwardRouteSign
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2076); }
    }

    /// <summary>
    /// ArrayProperty: VehTrackArrows
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SplineLoftActor> VehTrackArrows
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SplineLoftActor>>(Ptr + 2080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2080); }
    }

    /// <summary>
    /// IntProperty: VehTrackNumArrows
    /// </summary>
    public unsafe int VehTrackNumArrows
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2096); }
    }
}
