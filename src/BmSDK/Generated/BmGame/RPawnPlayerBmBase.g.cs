#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RPawnPlayerBmBase<br/>
/// (size = 10252)
/// (flags = 144703671)
/// </summary>
public partial class RPawnPlayerBmBase : BmSDK.BmGame.RPawnPlayer, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnPlayerBmBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPawnPlayerBmBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnPlayerBmBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBmBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBmBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBmBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBmBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBmBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBmBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBmBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: ChangeComponentDepthPriorityGroup
    /// </summary>
    public unsafe override void ChangeComponentDepthPriorityGroup(BmSDK.Engine.Scene.ESceneDepthPriorityGroup FromDPG, BmSDK.Engine.Scene.ESceneDepthPriorityGroup ToDPG)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.ChangeComponentDepthPriorityGroup", true);
        byte* paramsPtr = stackalloc byte[2];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FromDPG, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ToDPG, paramsPtr + 1);
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
    /// Function: NPCCaughtBatarang
    /// </summary>
    public unsafe virtual void NPCCaughtBatarang()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.NPCCaughtBatarang", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanDoThrowCounter
    /// </summary>
    public unsafe override bool CanDoThrowCounter()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.CanDoThrowCounter", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.Tick", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CancelGauntletMovieWarning
    /// </summary>
    public unsafe virtual void CancelGauntletMovieWarning()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.CancelGauntletMovieWarning", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateGauntlet
    /// </summary>
    public unsafe virtual void UpdateGauntlet(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.UpdateGauntlet", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GauntletMovieWarning
    /// </summary>
    public unsafe virtual void GauntletMovieWarning()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.GauntletMovieWarning", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PossessedBy
    /// </summary>
    public unsafe override void PossessedBy(BmSDK.Engine.Controller C, bool bVehicleTransition)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.PossessedBy", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVehicleTransition, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetThoughts
    /// </summary>
    public unsafe override void GetThoughts(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList, BmSDK.FName SubGroup)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.GetThoughts", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubGroup, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: SetInXrayMode
    /// </summary>
    public unsafe override void SetInXrayMode(bool On, bool bForceOff)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.SetInXrayMode", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(On, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceOff, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoSlavedJokerHallucination
    /// </summary>
    public unsafe virtual void DoSlavedJokerHallucination(bool bAllowInterupt, bool bIgnoreCollisionCheck, BmSDK.BmGame.RPawnJokerHallucination.TypesOfHallucination HallucinationType = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.DoSlavedJokerHallucination", true);
        byte* paramsPtr = stackalloc byte[9];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowInterupt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreCollisionCheck, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HallucinationType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ProcessJokerHallucinationSpawn
    /// </summary>
    public unsafe virtual void ProcessJokerHallucinationSpawn(BmSDK.BmGame.RAnimNotify_JokerHallucinationSpawn JokerNotify)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.ProcessJokerHallucinationSpawn", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JokerNotify, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BeginSlavedJokerHallucinationOverrideNoCollision
    /// </summary>
    public unsafe virtual void BeginSlavedJokerHallucinationOverrideNoCollision()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.BeginSlavedJokerHallucinationOverrideNoCollision", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BeginSlavedJokerHallucinationOverride
    /// </summary>
    public unsafe virtual void BeginSlavedJokerHallucinationOverride()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.BeginSlavedJokerHallucinationOverride", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BeginSlavedJokerHallucinationNoCollision
    /// </summary>
    public unsafe virtual void BeginSlavedJokerHallucinationNoCollision()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.BeginSlavedJokerHallucinationNoCollision", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BeginSlavedJokerHallucination
    /// </summary>
    public unsafe virtual void BeginSlavedJokerHallucination()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.BeginSlavedJokerHallucination", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HideStaff
    /// </summary>
    public unsafe virtual void HideStaff()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.HideStaff", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NotifyForensicsUpdateRequired
    /// </summary>
    public unsafe virtual void NotifyForensicsUpdateRequired()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.NotifyForensicsUpdateRequired", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: EyeMaterialUpdated
    /// </summary>
    public unsafe virtual void EyeMaterialUpdated()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.EyeMaterialUpdated", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetUpPlayerCape
    /// </summary>
    public unsafe override void SetUpPlayerCape()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.SetUpPlayerCape", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CapeChangeGeneral
    /// </summary>
    public unsafe virtual void CapeChangeGeneral(BmSDK.BmGame.RPhysUtil.FCapeChangeData ChangeData)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.CapeChangeGeneral", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChangeData, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CapeChangeStateGeneral
    /// </summary>
    public unsafe virtual int CapeChangeStateGeneral(BmSDK.BmGame.RPhysUtil.FCapeStateChangeData StateChangeData)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.CapeChangeStateGeneral", true);
        byte* paramsPtr = stackalloc byte[80];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StateChangeData, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 76);
    }

    /// <summary>
    /// Function: CapeStartInState
    /// </summary>
    public unsafe virtual int CapeStartInState(BmSDK.FName NewCapeStateName, float AnimStartTime = default, float AnimPlayRate = default, BmSDK.BmGame.RPhysUtil.ECapeMirroredType MirroredType = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.CapeStartInState", true);
        byte* paramsPtr = stackalloc byte[100];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCapeStateName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimStartTime, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPlayRate, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MirroredType, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: CapeChangeStateAnim
    /// </summary>
    public unsafe virtual int CapeChangeStateAnim(BmSDK.FName NewCapeStateName, BmSDK.FName NewCapeAnimName, float AnimStartTime = default, float AnimPlayRate = default, BmSDK.BmGame.RPhysUtil.ECapeMirroredType MirroredType = default, float ScaleDepthBias = default, float ScaleHeadDepthBias = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.CapeChangeStateAnim", true);
        byte* paramsPtr = stackalloc byte[120];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCapeStateName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCapeAnimName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimStartTime, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPlayRate, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MirroredType, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScaleDepthBias, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScaleHeadDepthBias, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 36);
    }

    /// <summary>
    /// Function: CapeChangeState
    /// </summary>
    public unsafe virtual int CapeChangeState(BmSDK.FName NewCapeStateName, float AnimStartTime = default, float AnimPlayRate = default, BmSDK.BmGame.RPhysUtil.ECapeMirroredType MirroredType = default, float ScaleDepthBias = default, float ScaleHeadDepthBias = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.CapeChangeState", true);
        byte* paramsPtr = stackalloc byte[112];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCapeStateName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimStartTime, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimPlayRate, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MirroredType, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScaleDepthBias, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScaleHeadDepthBias, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 28);
    }

    /// <summary>
    /// Function: CapeGetPoseMirroredType
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPhysUtil.ECapeMirroredType CapeGetPoseMirroredType()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.CapeGetPoseMirroredType", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPhysUtil.ECapeMirroredType>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetCapeCurrentStateChangeIndex
    /// </summary>
    public unsafe virtual int GetCapeCurrentStateChangeIndex()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.GetCapeCurrentStateChangeIndex", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetCinematicCapeStateName
    /// </summary>
    public unsafe virtual BmSDK.FName GetCinematicCapeStateName()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.GetCinematicCapeStateName", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetCurrentCapeStateName
    /// </summary>
    public unsafe virtual BmSDK.FName GetCurrentCapeStateName()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.GetCurrentCapeStateName", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ShowBelt
    /// </summary>
    public unsafe virtual void ShowBelt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.ShowBelt", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HideBelt
    /// </summary>
    public unsafe virtual void HideBelt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.HideBelt", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.PostBeginPlay", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnIceSphere
    /// </summary>
    public unsafe virtual BmSDK.Engine.FogVolumeSphericalDensityInfo SpawnIceSphere(System.Numerics.Vector3 SpawnLocation, BmSDK.Rotator SpawnRotation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.SpawnIceSphere", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnRotation, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.FogVolumeSphericalDensityInfo>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: SetEnableHeadCollisionWithKActorsWhenCrouched
    /// </summary>
    public unsafe virtual void SetEnableHeadCollisionWithKActorsWhenCrouched(bool bEnableHeadCollisionWithKActors)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.SetEnableHeadCollisionWithKActorsWhenCrouched", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnableHeadCollisionWithKActors, paramsPtr + 0);
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
    /// Function: MatineeTeleport
    /// </summary>
    public unsafe override void MatineeTeleport(BmSDK.Engine.InterpGroupInst InterpGroupInst, BmSDK.FName DebugSource)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.MatineeTeleport", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InterpGroupInst, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DebugSource, paramsPtr + 8);
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
    /// Function: OnDestroyPhysicsAssetInstance
    /// </summary>
    public unsafe override void OnDestroyPhysicsAssetInstance(BmSDK.Engine.SkeletalMeshComponent AffectedComponent)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.OnDestroyPhysicsAssetInstance", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AffectedComponent, paramsPtr + 0);
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
    /// Function: OnCreatePhysicsAssetInstance
    /// </summary>
    public unsafe override void OnCreatePhysicsAssetInstance(BmSDK.Engine.SkeletalMeshComponent AffectedComponent)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.OnCreatePhysicsAssetInstance", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AffectedComponent, paramsPtr + 0);
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
    /// Function: CheckGrappleGun
    /// </summary>
    public unsafe override float CheckGrappleGun()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.CheckGrappleGun", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: EyesNormal
    /// </summary>
    public unsafe virtual bool EyesNormal()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerBmBase.EyesNormal", true);
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
    /// BoolProperty: bUseDamageMeshes
    /// </summary>
    public unsafe bool bUseDamageMeshes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10032) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10032); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10032); }
    }

    /// <summary>
    /// BoolProperty: DemonTrialsVulnerable
    /// </summary>
    public unsafe bool DemonTrialsVulnerable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10032) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10032); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10032); }
    }

    /// <summary>
    /// BoolProperty: bGauntletLightRunning
    /// </summary>
    public unsafe bool bGauntletLightRunning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10032) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10032); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10032); }
    }

    /// <summary>
    /// ComponentProperty: CapeSkeletalMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent CapeSkeletalMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 10036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10036); }
    }

    /// <summary>
    /// ComponentProperty: CapeComponent
    /// </summary>
    public unsafe BmSDK.BmGame.RCapeComponent CapeComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCapeComponent>(Ptr + 10044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10044); }
    }

    /// <summary>
    /// ComponentProperty: CapeRenderingComponent
    /// </summary>
    public unsafe BmSDK.BmGame.RCapeRenderingComponent CapeRenderingComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCapeRenderingComponent>(Ptr + 10052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10052); }
    }

    /// <summary>
    /// ObjectProperty: EyesMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant EyesMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 10060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10060); }
    }

    /// <summary>
    /// ObjectProperty: EyesMaterial2
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant EyesMaterial2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 10068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10068); }
    }

    /// <summary>
    /// ObjectProperty: EyeLashMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant EyeLashMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 10076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10076); }
    }

    /// <summary>
    /// ObjectProperty: GlideDirectionalDirectionNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeBlendDirectional GlideDirectionalDirectionNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeBlendDirectional>(Ptr + 10084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10084); }
    }

    /// <summary>
    /// ObjectProperty: GlideDirectionalStrengthNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeBlend GlideDirectionalStrengthNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeBlend>(Ptr + 10092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10092); }
    }

    /// <summary>
    /// ObjectProperty: GlideRetractBlendNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeBlend GlideRetractBlendNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeBlend>(Ptr + 10100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10100); }
    }

    /// <summary>
    /// ObjectProperty: GlideBaseNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNode GlideBaseNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNode>(Ptr + 10108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10108); }
    }

    /// <summary>
    /// ObjectProperty: GlideRetractBlendMixer
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeBlendPerBone GlideRetractBlendMixer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeBlendPerBone>(Ptr + 10116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10116); }
    }

    /// <summary>
    /// ObjectProperty: GlideFlutterStrengthNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeBlend GlideFlutterStrengthNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeBlend>(Ptr + 10124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10124); }
    }

    /// <summary>
    /// ObjectProperty: CapeWaterSprayEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem CapeWaterSprayEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 10132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10132); }
    }

    /// <summary>
    /// ObjectProperty: PlacedBombOnDownedEnemy
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain PlacedBombOnDownedEnemy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 10140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10140); }
    }

    /// <summary>
    /// ObjectProperty: JustShieldBlockedShotFrom
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCombat JustShieldBlockedShotFrom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(Ptr + 10148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10148); }
    }

    /// <summary>
    /// ObjectProperty: BarrelRollRight
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig BarrelRollRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 10156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10156); }
    }

    /// <summary>
    /// ObjectProperty: BarrelRollLeft
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig BarrelRollLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 10164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10164); }
    }

    /// <summary>
    /// ObjectProperty: CapeXrayMatInstConst
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant CapeXrayMatInstConst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 10172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10172); }
    }

    /// <summary>
    /// ComponentProperty: GauntletLight
    /// </summary>
    public unsafe BmSDK.Engine.PointLightComponent GauntletLight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PointLightComponent>(Ptr + 10180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10180); }
    }

    /// <summary>
    /// ComponentProperty: RightWingTipTrail
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent RightWingTipTrail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 10188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10188); }
    }

    /// <summary>
    /// ComponentProperty: LeftWingTipTrail
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent LeftWingTipTrail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 10196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10196); }
    }

    /// <summary>
    /// StructProperty: EyeGlowColour
    /// </summary>
    public unsafe BmSDK.GameObject.FLinearColor EyeGlowColour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FLinearColor>(Ptr + 10204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10204); }
    }

    /// <summary>
    /// FloatProperty: DivePullUpAnimStrength
    /// </summary>
    public unsafe float DivePullUpAnimStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10220); }
    }

    /// <summary>
    /// ArrayProperty: DemonSafeObjects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> DemonSafeObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 10224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10224); }
    }

    /// <summary>
    /// FloatProperty: CurrentPoisonFaceLevel
    /// </summary>
    public unsafe float CurrentPoisonFaceLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10240); }
    }

    /// <summary>
    /// FloatProperty: PoisonFaceLevelBlendTime
    /// </summary>
    public unsafe float PoisonFaceLevelBlendTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10244); }
    }

    /// <summary>
    /// FloatProperty: GauntletLightTimer
    /// </summary>
    public unsafe float GauntletLightTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10248); }
    }
}
