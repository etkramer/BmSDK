#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RJokerBossBatmanBotController<br/>
/// (size = 1584)
/// (flags = 10485778)
/// </summary>
public partial class RJokerBossBatmanBotController : BmSDK.BmGame.RBotController, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RJokerBossBatmanBotController", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RJokerBossBatmanBotController() { }

    /// <summary>
    /// Constructs a new RJokerBossBatmanBotController
    /// </summary>
    public RJokerBossBatmanBotController(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RJokerBossBatmanBotController Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RJokerBossBatmanBotController(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RJokerBossBatmanBotController>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RJokerBossBatmanBotController>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RJokerBossBatmanBotController>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RJokerBossBatmanBotController>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RJokerBossBatmanBotController>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RJokerBossBatmanBotController>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RJokerBossBatmanBotController>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: CanDoSteamVent
    /// </summary>
    public unsafe bool CanDoSteamVent()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerBossBatmanBotController.CanDoSteamVent", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CanDoLantern
    /// </summary>
    public unsafe bool CanDoLantern()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerBossBatmanBotController.CanDoLantern", true);
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: NotifyShot
    /// </summary>
    public unsafe void NotifyShot()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerBossBatmanBotController.NotifyShot", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NotifyShow
    /// </summary>
    public unsafe void NotifyShow()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerBossBatmanBotController.NotifyShow", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NotifyHideInstant
    /// </summary>
    public unsafe void NotifyHideInstant()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerBossBatmanBotController.NotifyHideInstant", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NotifyHide
    /// </summary>
    public unsafe void NotifyHide()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerBossBatmanBotController.NotifyHide", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ActualShow
    /// </summary>
    public unsafe void ActualShow()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerBossBatmanBotController.ActualShow", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ActualHide
    /// </summary>
    public unsafe void ActualHide()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerBossBatmanBotController.ActualHide", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BeginAppearFX
    /// </summary>
    public unsafe void BeginAppearFX()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerBossBatmanBotController.BeginAppearFX", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BeginTeleport
    /// </summary>
    public unsafe void BeginTeleport()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerBossBatmanBotController.BeginTeleport", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetJokerSickVector
    /// </summary>
    public unsafe BmSDK.GameObject.FLinearColor GetJokerSickVector()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerBossBatmanBotController.GetJokerSickVector", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FLinearColor>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: UpdateJokerSickLevel
    /// </summary>
    public unsafe void UpdateJokerSickLevel(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerBossBatmanBotController.UpdateJokerSickLevel", true);
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetJokerFullySick
    /// </summary>
    public unsafe void SetJokerFullySick()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerBossBatmanBotController.SetJokerFullySick", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ProgressJokerSickLevel
    /// </summary>
    public unsafe void ProgressJokerSickLevel()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerBossBatmanBotController.ProgressJokerSickLevel", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: JokerNearEdge
    /// </summary>
    public unsafe bool JokerNearEdge()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerBossBatmanBotController.JokerNearEdge", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: PlayerPulledTrigger
    /// </summary>
    public unsafe bool PlayerPulledTrigger()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerBossBatmanBotController.PlayerPulledTrigger", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: HitByJokerShotgun
    /// </summary>
    public unsafe void HitByJokerShotgun()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerBossBatmanBotController.HitByJokerShotgun", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanDoRedHerring
    /// </summary>
    public unsafe bool CanDoRedHerring()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerBossBatmanBotController.CanDoRedHerring", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CanTakedown
    /// </summary>
    public unsafe bool CanTakedown(BmSDK.BmScript.RJokerBossBatmanBotController.JokerBossTakedownTypes takedownType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerBossBatmanBotController.CanTakedown", true);
        byte* paramsPtr = stackalloc byte[88];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(takedownType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: UpdateFades
    /// </summary>
    public unsafe void UpdateFades(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerBossBatmanBotController.UpdateFades", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SwapMatsToFadeMats
    /// </summary>
    public unsafe void SwapMatsToFadeMats(bool ToFade)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerBossBatmanBotController.SwapMatsToFadeMats", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToFade, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GoingToRedHerring
    /// </summary>
    public unsafe void GoingToRedHerring()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerBossBatmanBotController.GoingToRedHerring", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CheckForRedHerring
    /// </summary>
    public unsafe void CheckForRedHerring()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerBossBatmanBotController.CheckForRedHerring", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerBossBatmanBotController.Tick", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetPlayerPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer GetPlayerPawn()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerBossBatmanBotController.GetPlayerPawn", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ClearNavigation
    /// </summary>
    public unsafe void ClearNavigation()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerBossBatmanBotController.ClearNavigation", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UnPossess
    /// </summary>
    public unsafe void UnPossess()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerBossBatmanBotController.UnPossess", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Possess
    /// </summary>
    public unsafe void Possess(BmSDK.Engine.Pawn inPawn, bool bVehicleTransition)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerBossBatmanBotController.Possess", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVehicleTransition, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe void PostBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RJokerBossBatmanBotController.PostBeginPlay", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: JokerBossTakedownTypes
    /// </summary>
    public enum JokerBossTakedownTypes
    {
        JBTT_NoTakedown = 0,
        JBTT_Grate = 1,
        JBTT_Railing = 2,
        JBTT_Manequin = 3,
        JBTT_Num = 4,
        JBTT_MAX = 5,
    }

    /// <summary>
    /// Enum: JokerBossCameraLookAtStage
    /// </summary>
    public enum JokerBossCameraLookAtStage
    {
        JBCLAS_NotInLookAt = 0,
        JBCLAS_ForceCamera = 1,
        JBCLAS_AllowBreak = 2,
        JBCLAS_Num = 3,
        JBCLAS_MAX = 4,
    }

    /// <summary>
    /// ObjectProperty: GRI
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI GRI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// ObjectProperty: PlayerPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayerFPS PlayerPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerFPS>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// ObjectProperty: BotPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer BotPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// ObjectProperty: NavHandle
    /// </summary>
    public unsafe BmSDK.BmGame.RNavigationHandle NavHandle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationHandle>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }

    /// <summary>
    /// ObjectProperty: CentrePoint
    /// </summary>
    public unsafe BmSDK.Engine.Actor CentrePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// ObjectProperty: FloorArea
    /// </summary>
    public unsafe BmSDK.Engine.Volume FloorArea
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Volume>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }

    /// <summary>
    /// ObjectProperty: JokerOutOfWayLocator
    /// </summary>
    public unsafe BmSDK.Engine.Actor JokerOutOfWayLocator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }
    }

    /// <summary>
    /// ObjectProperty: DisarmedByBatman
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DisarmedByBatman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }
    }

    /// <summary>
    /// ObjectProperty: DisarmedByBatman180
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DisarmedByBatman180
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1200); }
    }

    /// <summary>
    /// ObjectProperty: HiddenJoker
    /// </summary>
    public unsafe BmSDK.BmScript.RPawnBossJokerNukeGun HiddenJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RPawnBossJokerNukeGun>(Ptr + 1208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1208); }
    }

    /// <summary>
    /// ObjectProperty: UsingTunnelGrate
    /// </summary>
    public unsafe BmSDK.BmScript.RTunnelGrate UsingTunnelGrate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RTunnelGrate>(Ptr + 1216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1216); }
    }

    /// <summary>
    /// ObjectProperty: UsingRailingPoint
    /// </summary>
    public unsafe BmSDK.Engine.Actor UsingRailingPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1224); }
    }

    /// <summary>
    /// ObjectProperty: UsingManequinPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RJokerManequin UsingManequinPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RJokerManequin>(Ptr + 1232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1232); }
    }

    /// <summary>
    /// StructProperty: WalkDestination
    /// </summary>
    public unsafe System.Numerics.Vector3 WalkDestination
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }
    }

    /// <summary>
    /// StructProperty: TeleportDestination
    /// </summary>
    public unsafe System.Numerics.Vector3 TeleportDestination
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1252); }
    }

    /// <summary>
    /// ArrayProperty: CornerPoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> CornerPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 1264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1264); }
    }

    /// <summary>
    /// FloatProperty: TeleportTime
    /// </summary>
    public unsafe float TeleportTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1280); }
    }

    /// <summary>
    /// BoolProperty: bPickedInitialWalkDest
    /// </summary>
    public unsafe bool bPickedInitialWalkDest
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1284) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1284); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1284); }
    }

    /// <summary>
    /// BoolProperty: bPauseTakedowns
    /// </summary>
    public unsafe bool bPauseTakedowns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1284) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1284); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1284); }
    }

    /// <summary>
    /// BoolProperty: bUseCameraLookForAttacks
    /// </summary>
    public unsafe bool bUseCameraLookForAttacks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1284) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1284); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1284); }
    }

    /// <summary>
    /// BoolProperty: bPlayerInGrabMove
    /// </summary>
    public unsafe bool bPlayerInGrabMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1284) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1284); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1284); }
    }

    /// <summary>
    /// BoolProperty: bNextAttackIsRedHerring
    /// </summary>
    public unsafe bool bNextAttackIsRedHerring
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1284) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1284); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1284); }
    }

    /// <summary>
    /// BoolProperty: bHasStartedHerring
    /// </summary>
    public unsafe bool bHasStartedHerring
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1284) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1284); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1284); }
    }

    /// <summary>
    /// BoolProperty: bHasDoneLantern
    /// </summary>
    public unsafe bool bHasDoneLantern
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1284) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1284); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1284); }
    }

    /// <summary>
    /// BoolProperty: bHasDoneSteamVent
    /// </summary>
    public unsafe bool bHasDoneSteamVent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1284) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1284); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1284); }
    }

    /// <summary>
    /// BoolProperty: bForceSecondPhase
    /// </summary>
    public unsafe bool bForceSecondPhase
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1284) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1284); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1284); }
    }

    /// <summary>
    /// BoolProperty: bFadingIn
    /// </summary>
    public unsafe bool bFadingIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1284) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1284); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1284); }
    }

    /// <summary>
    /// BoolProperty: bFadingOut
    /// </summary>
    public unsafe bool bFadingOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1284) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1284); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1284); }
    }

    /// <summary>
    /// BoolProperty: bFadeOutIn
    /// </summary>
    public unsafe bool bFadeOutIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1284) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1284); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1284); }
    }

    /// <summary>
    /// IntProperty: NumTakedownsAttempted
    /// </summary>
    public unsafe int NumTakedownsAttempted
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1288); }
    }

    /// <summary>
    /// IntProperty: NumTakeDownsForFinal
    /// </summary>
    public unsafe int NumTakeDownsForFinal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1292); }
    }

    /// <summary>
    /// FloatProperty: IdleTime
    /// </summary>
    public unsafe float IdleTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1296); }
    }

    /// <summary>
    /// FloatProperty: MinTimeBetweenTakedowns
    /// </summary>
    public unsafe float MinTimeBetweenTakedowns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1300); }
    }

    /// <summary>
    /// StructProperty: SafeLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 SafeLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1304); }
    }

    /// <summary>
    /// NameProperty: PickedTakedownName
    /// </summary>
    public unsafe BmSDK.FName PickedTakedownName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1316); }
    }

    /// <summary>
    /// StructProperty: CurrentTransitionId
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId CurrentTransitionId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 1324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1324); }
    }

    /// <summary>
    /// ArrayProperty: Railings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> Railings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 1328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1328); }
    }

    /// <summary>
    /// ArrayProperty: ManequinPlinths
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RJokerManequin> ManequinPlinths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RJokerManequin>>(Ptr + 1344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1344); }
    }

    /// <summary>
    /// ArrayProperty: ForcedRailings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> ForcedRailings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 1360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1360); }
    }

    /// <summary>
    /// ArrayProperty: ForcedManequinPlinths
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> ForcedManequinPlinths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 1376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1376); }
    }

    /// <summary>
    /// ArrayProperty: ForcedGrates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> ForcedGrates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 1392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1392); }
    }

    /// <summary>
    /// IntProperty: NumGratesToMiss
    /// </summary>
    public unsafe int NumGratesToMiss
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1408); }
    }

    /// <summary>
    /// IntProperty: NumRailingsToMiss
    /// </summary>
    public unsafe int NumRailingsToMiss
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1412); }
    }

    /// <summary>
    /// IntProperty: NumManequinsToMiss
    /// </summary>
    public unsafe int NumManequinsToMiss
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1416); }
    }

    /// <summary>
    /// ArrayProperty: LastTestedGrates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> LastTestedGrates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 1420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1420); }
    }

    /// <summary>
    /// ArrayProperty: LastTestedManequins
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> LastTestedManequins
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 1436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1436); }
    }

    /// <summary>
    /// ArrayProperty: LastTestedRailings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> LastTestedRailings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 1452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1452); }
    }

    /// <summary>
    /// ByteProperty: CameraLookStage
    /// </summary>
    public unsafe BmSDK.BmScript.RJokerBossBatmanBotController.JokerBossCameraLookAtStage CameraLookStage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RJokerBossBatmanBotController.JokerBossCameraLookAtStage>(Ptr + 1468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1468); }
    }

    /// <summary>
    /// ByteProperty: LastTakedownAttempted
    /// </summary>
    public unsafe BmSDK.BmScript.RJokerBossBatmanBotController.JokerBossTakedownTypes LastTakedownAttempted
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RJokerBossBatmanBotController.JokerBossTakedownTypes>(Ptr + 1469); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1469); }
    }

    /// <summary>
    /// ByteProperty: ForceTakeDownType
    /// </summary>
    public unsafe BmSDK.BmScript.RJokerBossBatmanBotController.JokerBossTakedownTypes ForceTakeDownType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RJokerBossBatmanBotController.JokerBossTakedownTypes>(Ptr + 1470); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1470); }
    }

    /// <summary>
    /// StructProperty: SavedLookAtPoint
    /// </summary>
    public unsafe System.Numerics.Vector3 SavedLookAtPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1472); }
    }

    /// <summary>
    /// FloatProperty: TimeInCameraLookAt
    /// </summary>
    public unsafe float TimeInCameraLookAt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1484); }
    }

    /// <summary>
    /// FloatProperty: DotForCameraLookAtComplete
    /// </summary>
    public unsafe float DotForCameraLookAtComplete
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1488); }
    }

    /// <summary>
    /// FloatProperty: TimeForForcedCameraLook
    /// </summary>
    public unsafe float TimeForForcedCameraLook
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1492); }
    }

    /// <summary>
    /// StructProperty: SavedRefPoint
    /// </summary>
    public unsafe System.Numerics.Vector3 SavedRefPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1496); }
    }

    /// <summary>
    /// StructProperty: SavedRotPoint
    /// </summary>
    public unsafe BmSDK.Rotator SavedRotPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 1508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1508); }
    }

    /// <summary>
    /// FloatProperty: timeInState
    /// </summary>
    public unsafe float timeInState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1520); }
    }

    /// <summary>
    /// FloatProperty: HerringWaitTime
    /// </summary>
    public unsafe float HerringWaitTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1524); }
    }

    /// <summary>
    /// IntProperty: SavedSteamPoint
    /// </summary>
    public unsafe int SavedSteamPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1528); }
    }

    /// <summary>
    /// ArrayProperty: AttemptedTakedownTypes
    /// </summary>
    public unsafe BmSDK.TArray<int> AttemptedTakedownTypes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1532); }
    }

    /// <summary>
    /// FloatProperty: fadeTime
    /// </summary>
    public unsafe float fadeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1548); }
    }

    /// <summary>
    /// FloatProperty: FadeTimeForNormal
    /// </summary>
    public unsafe float FadeTimeForNormal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1552); }
    }

    /// <summary>
    /// FloatProperty: FadeTimeForInOut
    /// </summary>
    public unsafe float FadeTimeForInOut
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1556); }
    }

    /// <summary>
    /// NameProperty: FadeParamName
    /// </summary>
    public unsafe BmSDK.FName FadeParamName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1560); }
    }

    /// <summary>
    /// ArrayProperty: OldMaterials
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInterface> OldMaterials
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInterface>>(Ptr + 1568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1568); }
    }
}
