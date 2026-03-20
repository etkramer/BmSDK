#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDebugCameraController<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RDebugCameraController : BmSDK.Engine.DebugCameraController, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDebugCameraController", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDebugCameraController() { }

    /// <summary>
    /// Constructs a new RDebugCameraController
    /// </summary>
    public RDebugCameraController(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDebugCameraController Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDebugCameraController(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDebugCameraController>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDebugCameraController>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDebugCameraController>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDebugCameraController>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDebugCameraController>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDebugCameraController>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDebugCameraController>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: ActiveMenu
    /// </summary>
    public unsafe BmSDK.BmGame.RDynamicMenu ActiveMenu
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDynamicMenu>(Ptr + 1912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1912); }
    }

    /// <summary>
    /// ObjectProperty: DebugMenu
    /// </summary>
    public unsafe BmSDK.BmGame.RDebugMenu DebugMenu
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDebugMenu>(Ptr + 1920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1920); }
    }

    /// <summary>
    /// ObjectProperty: OldMainPlayerController
    /// </summary>
    public unsafe BmSDK.Engine.PlayerController OldMainPlayerController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PlayerController>(Ptr + 1928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1928); }
    }

    /// <summary>
    /// ObjectProperty: RPC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController RPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 1936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1936); }
    }

    /// <summary>
    /// ObjectProperty: TrackingActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor TrackingActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1944); }
    }

    /// <summary>
    /// ObjectProperty: CinematicScreenShake
    /// </summary>
    public unsafe BmSDK.Engine.CameraShake CinematicScreenShake
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CameraShake>(Ptr + 1952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1952); }
    }

    /// <summary>
    /// ComponentProperty: LightingTestSphere
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent LightingTestSphere
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 1960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1960); }
    }

    /// <summary>
    /// IntProperty: SpectatorStepFrame
    /// </summary>
    public unsafe int SpectatorStepFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1968); }
    }

    /// <summary>
    /// StructProperty: LightContainer1
    /// </summary>
    public unsafe BmSDK.Engine.LightComponent.FLightingChannelContainer LightContainer1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.LightComponent.FLightingChannelContainer>(Ptr + 1972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1972); }
    }

    /// <summary>
    /// StructProperty: LightContainer2
    /// </summary>
    public unsafe BmSDK.Engine.LightComponent.FLightingChannelContainer LightContainer2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.LightComponent.FLightingChannelContainer>(Ptr + 1976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1976); }
    }

    /// <summary>
    /// BoolProperty: bUsingEnvironmentSphere
    /// </summary>
    public unsafe bool bUsingEnvironmentSphere
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1980) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1980); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1980); }
    }

    /// <summary>
    /// BoolProperty: bUsingCharacterSphere
    /// </summary>
    public unsafe bool bUsingCharacterSphere
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1980) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1980); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1980); }
    }

    /// <summary>
    /// BoolProperty: LoadedSphere
    /// </summary>
    public unsafe bool LoadedSphere
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1980) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1980); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1980); }
    }

    /// <summary>
    /// BoolProperty: bShowDialogueInfo
    /// </summary>
    public unsafe bool bShowDialogueInfo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1980) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1980); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1980); }
    }

    /// <summary>
    /// BoolProperty: bOverrideDOF
    /// </summary>
    public unsafe bool bOverrideDOF
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1980) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1980); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1980); }
    }

    /// <summary>
    /// BoolProperty: bSpeedMod
    /// </summary>
    public unsafe bool bSpeedMod
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1980) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1980); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1980); }
    }

    /// <summary>
    /// BoolProperty: bOrbitShot
    /// </summary>
    public unsafe bool bOrbitShot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1980) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1980); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1980); }
    }

    /// <summary>
    /// BoolProperty: bOrbitShotXY
    /// </summary>
    public unsafe bool bOrbitShotXY
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1980) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1980); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1980); }
    }

    /// <summary>
    /// BoolProperty: CreateRoundShotFolders
    /// </summary>
    public unsafe bool CreateRoundShotFolders
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1980) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1980); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1980); }
    }

    /// <summary>
    /// BoolProperty: CreateOrbitShotFolders
    /// </summary>
    public unsafe bool CreateOrbitShotFolders
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1980) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1980); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1980); }
    }

    /// <summary>
    /// BoolProperty: bSetOrbitPivot
    /// </summary>
    public unsafe bool bSetOrbitPivot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1980) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1980); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1980); }
    }

    /// <summary>
    /// BoolProperty: bOldCollideWorld
    /// </summary>
    public unsafe bool bOldCollideWorld
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1980) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1980); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1980); }
    }

    /// <summary>
    /// BoolProperty: bOldOnScreenKismetWarnings
    /// </summary>
    public unsafe bool bOldOnScreenKismetWarnings
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1980) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1980); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1980); }
    }

    /// <summary>
    /// BoolProperty: bScreenshotMode
    /// </summary>
    public unsafe bool bScreenshotMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1980) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1980); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1980); }
    }

    /// <summary>
    /// BoolProperty: DebugMenuQualifierT
    /// </summary>
    public unsafe bool DebugMenuQualifierT
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1980) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1980); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1980); }
    }

    /// <summary>
    /// BoolProperty: DebugMenuQualifierB
    /// </summary>
    public unsafe bool DebugMenuQualifierB
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1980) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1980); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1980); }
    }

    /// <summary>
    /// FloatProperty: DesiredZoomSpeed
    /// </summary>
    public unsafe float DesiredZoomSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1984); }
    }

    /// <summary>
    /// FloatProperty: CurrentZoomSpeed
    /// </summary>
    public unsafe float CurrentZoomSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1988); }
    }

    /// <summary>
    /// FloatProperty: DesiredRollSpeed
    /// </summary>
    public unsafe float DesiredRollSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1992); }
    }

    /// <summary>
    /// FloatProperty: CurrentRollSpeed
    /// </summary>
    public unsafe float CurrentRollSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1996); }
    }

    /// <summary>
    /// FloatProperty: RollRemainder
    /// </summary>
    public unsafe float RollRemainder
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2000); }
    }

    /// <summary>
    /// IntProperty: CurrentDialogueCaptureLine
    /// </summary>
    public unsafe int CurrentDialogueCaptureLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2004); }
    }

    /// <summary>
    /// StructProperty: DOFSettings
    /// </summary>
    public unsafe BmSDK.Engine.PostProcessVolume.FPostProcessSettings DOFSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PostProcessVolume.FPostProcessSettings>(Ptr + 2008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2008); }
    }

    /// <summary>
    /// IntProperty: iShotIndex
    /// </summary>
    public unsafe int iShotIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2532); }
    }

    /// <summary>
    /// IntProperty: NumRoundShotsPerTake
    /// </summary>
    public unsafe int NumRoundShotsPerTake
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2536); }
    }

    /// <summary>
    /// IntProperty: iRoundshotTake
    /// </summary>
    public unsafe int iRoundshotTake
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2540); }
    }

    /// <summary>
    /// IntProperty: NumOrbitShotsPerTake
    /// </summary>
    public unsafe int NumOrbitShotsPerTake
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2544); }
    }

    /// <summary>
    /// IntProperty: iOrbitShotTake
    /// </summary>
    public unsafe int iOrbitShotTake
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2548); }
    }

    /// <summary>
    /// StructProperty: OrbitPivot
    /// </summary>
    public unsafe System.Numerics.Vector3 OrbitPivot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2552); }
    }

    /// <summary>
    /// StructProperty: OldCameraPosition
    /// </summary>
    public unsafe System.Numerics.Vector3 OldCameraPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2564); }
    }

    /// <summary>
    /// StructProperty: OldCameraRotation
    /// </summary>
    public unsafe BmSDK.Rotator OldCameraRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 2576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2576); }
    }

    /// <summary>
    /// StructProperty: TrackingOffset
    /// </summary>
    public unsafe BmSDK.Rotator TrackingOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 2588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2588); }
    }

    /// <summary>
    /// StructProperty: OrbitOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 OrbitOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2600); }
    }

    /// <summary>
    /// FloatProperty: CameraShakeStrength
    /// </summary>
    public unsafe float CameraShakeStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2612); }
    }
}
