#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPawnJokerHallucination<br/>
/// (size = 4840)
/// (flags = 144703670)
/// </summary>
public partial class RPawnJokerHallucination : BmSDK.BmGame.RPawnFriendly, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnJokerHallucination", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPawnJokerHallucination() { }

    /// <summary>
    /// Constructs a new RPawnJokerHallucination
    /// </summary>
    public RPawnJokerHallucination(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPawnJokerHallucination Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnJokerHallucination(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnJokerHallucination>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnJokerHallucination>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnJokerHallucination>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnJokerHallucination>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnJokerHallucination>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnJokerHallucination>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnJokerHallucination>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: DrawPlacementSphere
    /// </summary>
    public unsafe virtual void DrawPlacementSphere()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnJokerHallucination.DrawPlacementSphere", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ForceSlaveToRef
    /// </summary>
    public unsafe virtual void ForceSlaveToRef()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnJokerHallucination.ForceSlaveToRef", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoesJokerTypeTrumpMine
    /// </summary>
    public unsafe virtual bool DoesJokerTypeTrumpMine(BmSDK.FString NewCaseIdentifier)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnJokerHallucination.DoesJokerTypeTrumpMine", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCaseIdentifier, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: InterceptNewJokerCall
    /// </summary>
    public unsafe virtual bool InterceptNewJokerCall(BmSDK.BmGame.RPawnJokerHallucination.TypesOfHallucination AppearanceType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnJokerHallucination.InterceptNewJokerCall", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AppearanceType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: StopAimAtBatman
    /// </summary>
    public unsafe virtual void StopAimAtBatman()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnJokerHallucination.StopAimAtBatman", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AimAtBatman
    /// </summary>
    public unsafe virtual void AimAtBatman()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnJokerHallucination.AimAtBatman", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TestSyncWalk
    /// </summary>
    public unsafe virtual void TestSyncWalk()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnJokerHallucination.TestSyncWalk", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ExitSyncWalk
    /// </summary>
    public unsafe virtual bool ExitSyncWalk()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnJokerHallucination.ExitSyncWalk", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SyncWalkNotify
    /// </summary>
    public unsafe virtual void SyncWalkNotify()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnJokerHallucination.SyncWalkNotify", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BeginSyncWalk
    /// </summary>
    public unsafe virtual void BeginSyncWalk(BmSDK.FName WalkName, BmSDK.BmGame.RBMPawnAI WalkNPC)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnJokerHallucination.BeginSyncWalk", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WalkName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WalkNPC, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GiveCamera
    /// </summary>
    public unsafe virtual void GiveCamera(bool bMirror = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnJokerHallucination.GiveCamera", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMirror, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayTakePhotoEffect
    /// </summary>
    public unsafe virtual void PlayTakePhotoEffect()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnJokerHallucination.PlayTakePhotoEffect", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: JokerHallucinationFadeNotify
    /// </summary>
    public unsafe virtual void JokerHallucinationFadeNotify(BmSDK.BmGame.RAnimNotify_JokerHallucination.EFadeType FadeType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnJokerHallucination.JokerHallucinationFadeNotify", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FadeType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TellControllerAboutCollisionWarning
    /// </summary>
    public unsafe override void TellControllerAboutCollisionWarning(BmSDK.Engine.Actor V, float Speed, BmSDK.BmGame.RGameInfo.EEvadeVehicleType EvadeType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnJokerHallucination.TellControllerAboutCollisionWarning", true);
        byte* paramsPtr = stackalloc byte[13];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(V, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speed, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EvadeType, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsFadedOut
    /// </summary>
    public unsafe virtual bool IsFadedOut()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnJokerHallucination.IsFadedOut", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: DestroyMe
    /// </summary>
    public unsafe virtual void DestroyMe()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnJokerHallucination.DestroyMe", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanBeSeenByBatmanForFadeIn
    /// </summary>
    public unsafe virtual bool CanBeSeenByBatmanForFadeIn()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnJokerHallucination.CanBeSeenByBatmanForFadeIn", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CanBeSeenByBatman
    /// </summary>
    public unsafe virtual bool CanBeSeenByBatman()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnJokerHallucination.CanBeSeenByBatman", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: FireDestroyEvent
    /// </summary>
    public unsafe virtual void FireDestroyEvent()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnJokerHallucination.FireDestroyEvent", true);
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NotifyFadedIn
    /// </summary>
    public unsafe virtual void NotifyFadedIn()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnJokerHallucination.NotifyFadedIn", true);
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnJokerHallucination.Tick", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateJoker
    /// </summary>
    public unsafe virtual void UpdateJoker(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnJokerHallucination.UpdateJoker", true);
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
    /// Function: GetJokerSickVector
    /// </summary>
    public unsafe static BmSDK.GameObject.FLinearColor GetJokerSickVector(BmSDK.Engine.WorldInfo MyWorldInfo)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnJokerHallucination.GetJokerSickVector", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MyWorldInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FLinearColor>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: PostInitCharacter
    /// </summary>
    public unsafe override void PostInitCharacter()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnJokerHallucination.PostInitCharacter", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ChangeShadowCast
    /// </summary>
    public unsafe virtual void ChangeShadowCast(bool bCast)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnJokerHallucination.ChangeShadowCast", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCast, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnDestroy
    /// </summary>
    public unsafe override void OnDestroy(BmSDK.Engine.SeqAct_Destroy Action)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnJokerHallucination.OnDestroy", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnJokerHallucination.Destroyed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AllowedToFireAtWithBatmobile
    /// </summary>
    public unsafe override bool AllowedToFireAtWithBatmobile()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnJokerHallucination.AllowedToFireAtWithBatmobile", true);
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
    /// BoolProperty: bShouldFadeIn
    /// </summary>
    public unsafe bool bShouldFadeIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4740); }
    }

    /// <summary>
    /// BoolProperty: bShouldFadeInSet
    /// </summary>
    public unsafe bool bShouldFadeInSet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4740); }
    }

    /// <summary>
    /// BoolProperty: bFadeInWhenOffScreen
    /// </summary>
    public unsafe bool bFadeInWhenOffScreen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4740); }
    }

    /// <summary>
    /// BoolProperty: bFadingOut
    /// </summary>
    public unsafe bool bFadingOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4740); }
    }

    /// <summary>
    /// BoolProperty: bFadeOutInstant
    /// </summary>
    public unsafe bool bFadeOutInstant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4740); }
    }

    /// <summary>
    /// BoolProperty: bWaitingToFadeOut
    /// </summary>
    public unsafe bool bWaitingToFadeOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4740); }
    }

    /// <summary>
    /// BoolProperty: bFadeWhenNotInTransition
    /// </summary>
    public unsafe bool bFadeWhenNotInTransition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4740); }
    }

    /// <summary>
    /// BoolProperty: bInSyncWalk
    /// </summary>
    public unsafe bool bInSyncWalk
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4740); }
    }

    /// <summary>
    /// BoolProperty: bAutoFadeIfBatmanTouches
    /// </summary>
    public unsafe bool bAutoFadeIfBatmanTouches
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4740); }
    }

    /// <summary>
    /// BoolProperty: bDontDeleteOnFade
    /// </summary>
    public unsafe bool bDontDeleteOnFade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4740); }
    }

    /// <summary>
    /// BoolProperty: bFadeOnCarWarning
    /// </summary>
    public unsafe bool bFadeOnCarWarning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4740); }
    }

    /// <summary>
    /// BoolProperty: bDrawSphere
    /// </summary>
    public unsafe bool bDrawSphere
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4740); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4740); }
    }

    /// <summary>
    /// ObjectProperty: JokerDefine
    /// </summary>
    public unsafe BmSDK.BmGame.RCharacterDefine JokerDefine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCharacterDefine>(Ptr + 4744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4744); }
    }

    /// <summary>
    /// ObjectProperty: JokerDefineNoApex
    /// </summary>
    public unsafe BmSDK.BmGame.RCharacterDefine JokerDefineNoApex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCharacterDefine>(Ptr + 4752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4752); }
    }

    /// <summary>
    /// ObjectProperty: SavedWalkNPC
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI SavedWalkNPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 4760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4760); }
    }

    /// <summary>
    /// ObjectProperty: CombatIncidentalActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor CombatIncidentalActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 4768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4768); }
    }

    /// <summary>
    /// ObjectProperty: SafeThug
    /// </summary>
    public unsafe BmSDK.Engine.Actor SafeThug
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 4776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4776); }
    }

    /// <summary>
    /// ObjectProperty: Camera
    /// </summary>
    public unsafe BmSDK.BmGame.RRiotObjectBase Camera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRiotObjectBase>(Ptr + 4784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4784); }
    }

    /// <summary>
    /// ClassProperty: JokerCharacter
    /// </summary>
    public unsafe BmSDK.Class JokerCharacter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4792); }
    }

    /// <summary>
    /// StrProperty: CaseIdentifier
    /// </summary>
    public unsafe BmSDK.FString CaseIdentifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4800); }
    }

    /// <summary>
    /// NameProperty: WalkSyncAnimName
    /// </summary>
    public unsafe BmSDK.FName WalkSyncAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4816); }
    }

    /// <summary>
    /// FloatProperty: FadeSpeedMultiplier
    /// </summary>
    public unsafe float FadeSpeedMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4824); }
    }

    /// <summary>
    /// ByteProperty: CurrentCombatQuality
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnJokerHallucination.CombatQualityType CurrentCombatQuality
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnJokerHallucination.CombatQualityType>(Ptr + 4828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4828); }
    }

    /// <summary>
    /// ByteProperty: InterceptHallucinationType
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnJokerHallucination.TypesOfHallucination InterceptHallucinationType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnJokerHallucination.TypesOfHallucination>(Ptr + 4829); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4829); }
    }

    /// <summary>
    /// FloatProperty: JokerSpawnTime
    /// </summary>
    public unsafe float JokerSpawnTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4832); }
    }

    /// <summary>
    /// IntProperty: FramesOffScreen
    /// </summary>
    public unsafe int FramesOffScreen
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4836); }
    }

    /// <summary>
    /// Enum: CombatQualityType
    /// </summary>
    public enum CombatQualityType
    {
        CQT_Lame = 0,
        CQT_Excellent = 1,
        CQT_Neutral = 2,
        CQT_MAX = 3,
    }

    /// <summary>
    /// Enum: TypesOfHallucination
    /// </summary>
    public enum TypesOfHallucination
    {
        JokerHallucination_Misc = 0,
        JokerHallucination_HidePoint = 1,
        JokerHallucination_CombatTakedown = 2,
        JokerHallucination_CombatFinalBlow = 3,
        JokerHallucination_InvertedTakedown = 4,
        JokerHallucination_PredatorTakedown = 5,
        JokerHallucination_WalkWithThug = 6,
        JokerHallucination_SpecialMove = 7,
        JokerHallucination_TeasePredThug = 8,
        JokerHallucination_TeaseCombatThug = 9,
        JokerHallucination_GrenadeGrate = 10,
        JokerHallucination_ManDown = 11,
        JokerHallucination_Sequence = 12,
        JokerHallucination_NumHallucinationTypes = 13,
        JokerHallucination_MAX = 14,
    }
}
