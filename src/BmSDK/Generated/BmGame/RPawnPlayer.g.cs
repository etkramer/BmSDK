#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPawnPlayer<br/>
/// (size = 5956)
/// (flags = 144703670)
/// </summary>
public partial class RPawnPlayer : BmSDK.BmGame.RPawnPlayerCombat, BmSDK.BmGame.RBatarangableInterface, BmSDK.BmGame.RSpotableInterface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnPlayer", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPawnPlayer() { }

    /// <summary>
    /// Constructs a new RPawnPlayer
    /// </summary>
    public RPawnPlayer(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPawnPlayer Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnPlayer(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayer>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayer>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayer>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayer>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayer>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayer>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayer>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: JustJumped
    /// </summary>
    public unsafe void JustJumped()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.JustJumped", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CheckForFractureWall
    /// </summary>
    public unsafe BmSDK.BmGame.RFractureWallBase CheckForFractureWall(System.Numerics.Vector3 CheckPos, System.Numerics.Vector3 CheckExtent)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.CheckForFractureWall", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckExtent, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RFractureWallBase>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: UpdatePunchFractureWalls
    /// </summary>
    public unsafe void UpdatePunchFractureWalls()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.UpdatePunchFractureWalls", true);
        byte* paramsPtr = stackalloc byte[84];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FrontBarrierIsEdge
    /// </summary>
    public unsafe bool FrontBarrierIsEdge()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.FrontBarrierIsEdge", true);
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
    /// Function: Destroyed
    /// </summary>
    public unsafe void Destroyed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.Destroyed", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearIngoreCollision
    /// </summary>
    public unsafe void ClearIngoreCollision()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.ClearIngoreCollision", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetWantsToCrouch
    /// </summary>
    public unsafe void SetWantsToCrouch(bool NewWantsToCrouch)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.SetWantsToCrouch", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWantsToCrouch, paramsPtr + 0);
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
    /// Function: OnBeginStateSpecialMove
    /// </summary>
    public unsafe void OnBeginStateSpecialMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.OnBeginStateSpecialMove", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsInSpecialMove
    /// </summary>
    public unsafe bool IsInSpecialMove(BmSDK.BmGame.RSpecialMoveConfig Test)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.IsInSpecialMove", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Test, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetCinematicModeMovementStance
    /// </summary>
    public unsafe BmSDK.FName GetCinematicModeMovementStance()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.GetCinematicModeMovementStance", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetWalkingModeMovementStance
    /// </summary>
    public unsafe BmSDK.FName GetWalkingModeMovementStance()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.GetWalkingModeMovementStance", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetStaticMeshBounds
    /// </summary>
    public unsafe BmSDK.GameObject.FBoxSphereBounds GetStaticMeshBounds(BmSDK.Engine.StaticMesh M)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.GetStaticMeshBounds", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(M, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FBoxSphereBounds>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: ResetSlippedCorner
    /// </summary>
    public unsafe void ResetSlippedCorner()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.ResetSlippedCorner", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanSpawnIceRaft
    /// </summary>
    public unsafe bool CanSpawnIceRaft(out System.Numerics.Vector3 NewLocation, System.Numerics.Vector3 RaftExtent)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.CanSpawnIceRaft", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RaftExtent, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        NewLocation = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: CheckForExistingIceRafts
    /// </summary>
    public unsafe bool CheckForExistingIceRafts()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.CheckForExistingIceRafts", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: RemoveIceRaft
    /// </summary>
    public unsafe void RemoveIceRaft(BmSDK.BmGame.RFloatingRaft raft)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.RemoveIceRaft", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(raft, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddIceRaft
    /// </summary>
    public unsafe void AddIceRaft(BmSDK.BmGame.RFloatingRaft raft)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.AddIceRaft", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(raft, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: JumpOffPawn
    /// </summary>
    public unsafe void JumpOffPawn()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.JumpOffPawn", true);
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
    /// Function: OnLevelChange
    /// </summary>
    public unsafe void OnLevelChange()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.OnLevelChange", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnRoomChange
    /// </summary>
    public unsafe void OnRoomChange()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.OnRoomChange", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: InformCurrentRoomTwoThugsLeft
    /// </summary>
    public unsafe void InformCurrentRoomTwoThugsLeft()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.InformCurrentRoomTwoThugsLeft", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerInterrogationMove
    /// </summary>
    public unsafe void TriggerInterrogationMove(BmSDK.BmGame.RPawnVillain Target, BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.TriggerInterrogationMove", true);
        byte* paramsPtr = stackalloc byte[280];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CheckSpaceForFloorInterrogation
    /// </summary>
    public unsafe bool CheckSpaceForFloorInterrogation(BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc, BmSDK.BmGame.RPawnVillain Target, bool bDebugDraw = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.CheckSpaceForFloorInterrogation", true);
        byte* paramsPtr = stackalloc byte[124];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 112);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugDraw, paramsPtr + 116);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 120);
    }

    /// <summary>
    /// Function: CheckForRagdolls
    /// </summary>
    public unsafe bool CheckForRagdolls(System.Numerics.Vector3 CheckStart, System.Numerics.Vector3 CheckEnd, float Radius, BmSDK.BmGame.RPawnVillain Target, bool bDebugDraw = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.CheckForRagdolls", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckStart, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckEnd, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Radius, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugDraw, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 36);
    }

    /// <summary>
    /// Function: CantPullOffGrateLine
    /// </summary>
    public unsafe void CantPullOffGrateLine()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.CantPullOffGrateLine", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsRunning
    /// </summary>
    public unsafe bool IsRunning()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.IsRunning", true);
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
    /// Function: OverrideAkComponentDefaults
    /// </summary>
    public unsafe void OverrideAkComponentDefaults(BmSDK.Engine.AkComponent akComp)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.OverrideAkComponentDefaults", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(akComp, paramsPtr + 0);
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
    /// Function: GetTransitionFootStepPhaseAndTime
    /// </summary>
    public unsafe bool GetTransitionFootStepPhaseAndTime(out BmSDK.BmGame.RAnimUtil.EFootSyncPoint CurrentFootStage, out float FootStageTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.GetTransitionFootStepPhaseAndTime", true);
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        CurrentFootStage = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil.EFootSyncPoint>(paramsPtr + 0);
        FootStageTime = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: PreBeginPlay
    /// </summary>
    public unsafe void PreBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.PreBeginPlay", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetupPlayerMesh
    /// </summary>
    public unsafe void SetupPlayerMesh(bool InPlay)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.SetupPlayerMesh", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DynamicCreateNearbyRigidBodies
    /// </summary>
    public unsafe void DynamicCreateNearbyRigidBodies()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.DynamicCreateNearbyRigidBodies", true);
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
    /// Function: ApplyMeshData
    /// </summary>
    public unsafe void ApplyMeshData(BmSDK.BmGame.RAddContentPlayerCharacterMesh MeshData, bool InPlay)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.ApplyMeshData", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MeshData, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPlay, paramsPtr + 4);
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
    /// Function: GetPlayerConfig
    /// </summary>
    public unsafe BmSDK.BmGame.RAddContentPlayerCharacter GetPlayerConfig(out BmSDK.BmGame.RAddContentPlayerCharacterMesh MeshData)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.GetPlayerConfig", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        MeshData = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAddContentPlayerCharacterMesh>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAddContentPlayerCharacter>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: InvestigateModeEyes
    /// </summary>
    public unsafe void InvestigateModeEyes(bool bOnOrOff)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.InvestigateModeEyes", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnOrOff, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanBeSeenByHelicopter
    /// </summary>
    public unsafe bool CanBeSeenByHelicopter()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.CanBeSeenByHelicopter", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetupSnowMaterials
    /// </summary>
    public unsafe void SetupSnowMaterials()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.SetupSnowMaterials", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetInferredTransitionReference
    /// </summary>
    public unsafe static bool GetInferredTransitionReference(BmSDK.BmGame.RPawnCharacter Pawn, BmSDK.Engine.SkeletalMeshComponent SkelComp, out System.Numerics.Vector3 InferredReferencePointPosition, out BmSDK.Rotator InferredReferencePointRotation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.GetInferredTransitionReference", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelComp, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        InferredReferencePointPosition = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 8);
        InferredReferencePointRotation = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 32);
    }

    /// <summary>
    /// Function: ClampLineSegmentToRange
    /// </summary>
    public unsafe bool ClampLineSegmentToRange(System.Numerics.Vector3 PointA, System.Numerics.Vector3 PointB, System.Numerics.Vector3 CheckLocation, float Radius, out System.Numerics.Vector3 NewA, out System.Numerics.Vector3 NewB, bool bDebugClamp = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.ClampLineSegmentToRange", true);
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PointA, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PointB, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckLocation, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Radius, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugClamp, paramsPtr + 64);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        NewA = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 40);
        NewB = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 52);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 68);
    }

    /// <summary>
    /// Function: AllowInteractableItem
    /// </summary>
    public unsafe bool AllowInteractableItem(BmSDK.BmGame.RInteractableItem InteractableItem)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.AllowInteractableItem", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InteractableItem, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: DieThisFrame
    /// </summary>
    public unsafe void DieThisFrame()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.DieThisFrame", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CantRunInDirectionTimeout
    /// </summary>
    public unsafe void CantRunInDirectionTimeout()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.CantRunInDirectionTimeout", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StopRunInDirection
    /// </summary>
    public unsafe void StopRunInDirection(System.Numerics.Vector3 Direction, float Time)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.StopRunInDirection", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddDefaultInventoryAfterInit
    /// </summary>
    public unsafe void AddDefaultInventoryAfterInit()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.AddDefaultInventoryAfterInit", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PointAndLineCheck
    /// </summary>
    public unsafe bool PointAndLineCheck(out System.Numerics.Vector3 HitLocation, out System.Numerics.Vector3 HitNormal, System.Numerics.Vector3 End, System.Numerics.Vector3 Start, System.Numerics.Vector3 Extent, int ExtraTraceFlags = default, bool bDebugDraw = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.PointAndLineCheck", true);
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(End, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Extent, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtraTraceFlags, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugDraw, paramsPtr + 64);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        HitLocation = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        HitNormal = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 68);
    }

    /// <summary>
    /// Function: GetFreeRotation
    /// </summary>
    public unsafe BmSDK.Rotator GetFreeRotation()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.GetFreeRotation", true);
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: PlayGenericScreenShake
    /// </summary>
    public unsafe void PlayGenericScreenShake()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.PlayGenericScreenShake", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerHeatConcealEffect
    /// </summary>
    public unsafe void TriggerHeatConcealEffect()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.TriggerHeatConcealEffect", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearGargoyleMoveFlag
    /// </summary>
    public unsafe void ClearGargoyleMoveFlag()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.ClearGargoyleMoveFlag", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OverrideChangeRunningModeStance
    /// </summary>
    public unsafe bool OverrideChangeRunningModeStance()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.OverrideChangeRunningModeStance", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: OverrideChangeWalkingModeStance
    /// </summary>
    public unsafe bool OverrideChangeWalkingModeStance()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.OverrideChangeWalkingModeStance", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: AttackPressedInFallingState
    /// </summary>
    public unsafe void AttackPressedInFallingState()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.AttackPressedInFallingState", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriedToUseGadgetOnHostageTaker
    /// </summary>
    public unsafe void TriedToUseGadgetOnHostageTaker()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.TriedToUseGadgetOnHostageTaker", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GiveUnlockableGadget
    /// </summary>
    public unsafe void GiveUnlockableGadget(BmSDK.FName UnlockName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.GiveUnlockableGadget", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnlockName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UnPossessed
    /// </summary>
    public unsafe void UnPossessed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.UnPossessed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetAudioEnvironment
    /// </summary>
    public unsafe bool SetAudioEnvironment(BmSDK.TArray<BmSDK.Engine.AkWwise.FAkEnvironmentSettings> Environments, bool EnableEnvironments, float OcclusionMultiplier = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.SetAudioEnvironment", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Environments, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EnableEnvironments, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OcclusionMultiplier, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: GetFuturePosition
    /// </summary>
    public unsafe System.Numerics.Vector3 GetFuturePosition(System.Numerics.Vector3 StartLocation, System.Numerics.Vector3 StartSpeed, float LookAheadTime, int NumIncrements, int IgnoreFirstNChecks, float minZ, out float FlightTimeToHit, out int IterationsToHit, out System.Numerics.Vector3 HitNormal, out System.Numerics.Vector3 EndVelocity, bool bDebugDraw)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.GetFuturePosition", true);
        byte* paramsPtr = stackalloc byte[88];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartSpeed, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LookAheadTime, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumIncrements, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IgnoreFirstNChecks, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(minZ, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugDraw, paramsPtr + 72);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        FlightTimeToHit = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 40);
        IterationsToHit = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 44);
        HitNormal = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 48);
        EndVelocity = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 60);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 76);
    }

    /// <summary>
    /// Function: GetFutureFallPosition
    /// </summary>
    public unsafe System.Numerics.Vector3 GetFutureFallPosition(float LookAheadTime, int NumIncrements, out System.Numerics.Vector3 HitNormal)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.GetFutureFallPosition", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LookAheadTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumIncrements, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        HitNormal = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: GetFlightPathPosition
    /// </summary>
    public unsafe System.Numerics.Vector3 GetFlightPathPosition(System.Numerics.Vector3 StartPoint, System.Numerics.Vector3 EndPoint, System.Numerics.Vector3 StartVelocity, System.Numerics.Vector3 EndVelocity, float T, float FlightTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.GetFlightPathPosition", true);
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndPoint, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartVelocity, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndVelocity, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(T, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlightTime, paramsPtr + 52);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 56);
    }

    /// <summary>
    /// Function: UpdateFallingTarget
    /// </summary>
    public unsafe void UpdateFallingTarget(System.Numerics.Vector3 TestLocation, System.Numerics.Vector3 TestVelocity, float LookForward = default, bool HighPriorityOnly = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.UpdateFallingTarget", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestVelocity, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LookForward, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HighPriorityOnly, paramsPtr + 28);
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
    /// Function: NofifyBeginStateBatarangPrimed
    /// </summary>
    public unsafe void NofifyBeginStateBatarangPrimed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.NofifyBeginStateBatarangPrimed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NotifyGadgetEquip
    /// </summary>
    public unsafe void NotifyGadgetEquip(bool equip)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.NotifyGadgetEquip", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(equip, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ThrowFatalBatarang
    /// </summary>
    public unsafe void ThrowFatalBatarang(BmSDK.BmGame.RPawnVillain Victim, System.Numerics.Vector3 TargetLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.ThrowFatalBatarang", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Victim, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PossessedBy
    /// </summary>
    public unsafe void PossessedBy(BmSDK.Engine.Controller C, bool bVehicleTransition)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.PossessedBy", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVehicleTransition, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanClimbToCatwalk
    /// </summary>
    public unsafe bool CanClimbToCatwalk(BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.CanClimbToCatwalk", true);
        byte* paramsPtr = stackalloc byte[120];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 112);
    }

    /// <summary>
    /// Function: CanClimbToCeiling
    /// </summary>
    public unsafe bool CanClimbToCeiling(BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.CanClimbToCeiling", true);
        byte* paramsPtr = stackalloc byte[180];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 112);
    }

    /// <summary>
    /// Function: IsValidCeilingLocator
    /// </summary>
    public unsafe bool IsValidCeilingLocator(BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.IsValidCeilingLocator", true);
        byte* paramsPtr = stackalloc byte[132];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 112);
    }

    /// <summary>
    /// Function: GetCeilingLocator
    /// </summary>
    public unsafe bool GetCeilingLocator(BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc, out BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc2)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.GetCeilingLocator", true);
        byte* paramsPtr = stackalloc byte[252];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Loc2 = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(paramsPtr + 112);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 224);
    }

    /// <summary>
    /// Function: SetClimbPointFeatureType
    /// </summary>
    public unsafe void SetClimbPointFeatureType(out BmSDK.BmGame.RPawnPlayer.FCeilingClimbPoint ClimbPoint)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.SetClimbPointFeatureType", true);
        byte* paramsPtr = stackalloc byte[112];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ClimbPoint = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FCeilingClimbPoint>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: TriggerGrateFromCeilingMove
    /// </summary>
    public unsafe void TriggerGrateFromCeilingMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.TriggerGrateFromCeilingMove", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerGrateToCeilingMove
    /// </summary>
    public unsafe void TriggerGrateToCeilingMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.TriggerGrateToCeilingMove", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PounceOnThug
    /// </summary>
    public unsafe void PounceOnThug(BmSDK.BmGame.RPawnVillain Target)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.PounceOnThug", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerPickPocketing
    /// </summary>
    public unsafe void TriggerPickPocketing(BmSDK.BmGame.RPawnVillain Target)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.TriggerPickPocketing", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerCeilingToCatwalkFarMove
    /// </summary>
    public unsafe void TriggerCeilingToCatwalkFarMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.TriggerCeilingToCatwalkFarMove", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerCeilingToCatwalkCloseMove
    /// </summary>
    public unsafe void TriggerCeilingToCatwalkCloseMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.TriggerCeilingToCatwalkCloseMove", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerCatwalkToCeilingFarMove
    /// </summary>
    public unsafe void TriggerCatwalkToCeilingFarMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.TriggerCatwalkToCeilingFarMove", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerCatwalkToCeilingCloseMove
    /// </summary>
    public unsafe void TriggerCatwalkToCeilingCloseMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.TriggerCatwalkToCeilingCloseMove", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerDangleToCeilingMove
    /// </summary>
    public unsafe void TriggerDangleToCeilingMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.TriggerDangleToCeilingMove", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerCeilingToDangleMove
    /// </summary>
    public unsafe void TriggerCeilingToDangleMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.TriggerCeilingToDangleMove", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerDropFromCeilingMove
    /// </summary>
    public unsafe void TriggerDropFromCeilingMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.TriggerDropFromCeilingMove", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerPounceToCeilingMove
    /// </summary>
    public unsafe void TriggerPounceToCeilingMove(System.Numerics.Vector3 Position)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.TriggerPounceToCeilingMove", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UnequipLineLauncher
    /// </summary>
    public unsafe void UnequipLineLauncher()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.UnequipLineLauncher", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: EquipLineLauncher
    /// </summary>
    public unsafe void EquipLineLauncher()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.EquipLineLauncher", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetReflectionNoSee
    /// </summary>
    public unsafe void SetReflectionNoSee(bool bNoSee)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.SetReflectionNoSee", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNoSee, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CreateXrayMaskMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent CreateXrayMaskMesh(BmSDK.Engine.SkeletalMeshComponent Template, BmSDK.Engine.SkeletalMeshComponent ParentAnimComponent, BmSDK.Engine.MaterialInterface Material)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.CreateXrayMaskMesh", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Template, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParentAnimComponent, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Material, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: DetachXrayMaskMesh
    /// </summary>
    public unsafe void DetachXrayMaskMesh(BmSDK.Engine.SkeletalMeshComponent InMesh)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.DetachXrayMaskMesh", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InMesh, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FinishAnimControl
    /// </summary>
    public unsafe void FinishAnimControl(BmSDK.Engine.InterpGroup InInterpGroup)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.FinishAnimControl", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInterpGroup, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BlendOutAnimControl
    /// </summary>
    public unsafe void BlendOutAnimControl(BmSDK.Engine.InterpGroup InInterpGroup)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.BlendOutAnimControl", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInterpGroup, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BeginAnimControl
    /// </summary>
    public unsafe void BeginAnimControl(BmSDK.Engine.InterpGroup InInterpGroup)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.BeginAnimControl", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInterpGroup, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetGravityZ
    /// </summary>
    public unsafe float GetGravityZ()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.GetGravityZ", true);
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
    /// Function: IncrementWireBounce
    /// </summary>
    public unsafe void IncrementWireBounce(float Speed, float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.IncrementWireBounce", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speed, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 4);
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
    /// Function: TurnOffWireBounce
    /// </summary>
    public unsafe void TurnOffWireBounce()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.TurnOffWireBounce", true);
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
    /// Function: InitialiseWireBounce
    /// </summary>
    public unsafe void InitialiseWireBounce(float InitialBounce)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.InitialiseWireBounce", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InitialBounce, paramsPtr + 0);
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
    /// Function: CheckForSmallDropOffRailing
    /// </summary>
    public unsafe bool CheckForSmallDropOffRailing(System.Numerics.Vector3 Direction, out BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Locator)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.CheckForSmallDropOffRailing", true);
        byte* paramsPtr = stackalloc byte[128];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Locator = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 124);
    }

    /// <summary>
    /// Function: CorrectFallingVelocity
    /// </summary>
    public unsafe void CorrectFallingVelocity(out System.Numerics.Vector3 DesiredPosition, float Max2DAccel, float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.CorrectFallingVelocity", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Max2DAccel, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        DesiredPosition = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: GetGrappleEndLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 GetGrappleEndLocation()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.GetGrappleEndLocation", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ServerTriggerSpecialMoveFromClient
    /// </summary>
    public unsafe void ServerTriggerSpecialMoveFromClient(BmSDK.BmGame.RSpecialMoveConfig SpecMove, BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.ServerTriggerSpecialMoveFromClient", true);
        byte* paramsPtr = stackalloc byte[116];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpecMove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClientTriggerSpecialMoveFromServer
    /// </summary>
    public unsafe void ClientTriggerSpecialMoveFromServer(BmSDK.BmGame.RSpecialMoveConfig SpecMove, BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc, bool ForceOnClient)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.ClientTriggerSpecialMoveFromServer", true);
        byte* paramsPtr = stackalloc byte[120];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpecMove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceOnClient, paramsPtr + 116);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpecialMoveFinished
    /// </summary>
    public unsafe void SpecialMoveFinished(BmSDK.BmGame.RSpecialMoveInstance FinishedMove)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.SpecialMoveFinished", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FinishedMove, paramsPtr + 0);
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
    /// Function: SetCurrentSpecialMove
    /// </summary>
    public unsafe void SetCurrentSpecialMove(BmSDK.BmGame.RSpecialMoveInstance NewMove)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.SetCurrentSpecialMove", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMove, paramsPtr + 0);
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
    /// Function: TriggerSpecialMove
    /// </summary>
    public unsafe void TriggerSpecialMove(BmSDK.BmGame.RSpecialMoveConfig SpecMove, BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc, bool ForceReplicateToClient)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.TriggerSpecialMove", true);
        byte* paramsPtr = stackalloc byte[128];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpecMove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceReplicateToClient, paramsPtr + 116);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearEnvironmentFeatures
    /// </summary>
    public unsafe void ClearEnvironmentFeatures()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.ClearEnvironmentFeatures", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PersistentMapChanged
    /// </summary>
    public unsafe void PersistentMapChanged()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.PersistentMapChanged", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HopOffVantagePoint
    /// </summary>
    public unsafe void HopOffVantagePoint()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.HopOffVantagePoint", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UnreliableClientRemoteSpecialMoveEvent
    /// </summary>
    public unsafe void UnreliableClientRemoteSpecialMoveEvent(BmSDK.BmGame.RSpecialMoveConfig Move, BmSDK.FName MoveEvent)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.UnreliableClientRemoteSpecialMoveEvent", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Move, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveEvent, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UnreliableServerRemoteSpecialMoveEvent
    /// </summary>
    public unsafe void UnreliableServerRemoteSpecialMoveEvent(BmSDK.BmGame.RSpecialMoveConfig Move, BmSDK.FName MoveEvent)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.UnreliableServerRemoteSpecialMoveEvent", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Move, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveEvent, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UnreliableRemoteSpecialMoveEvent
    /// </summary>
    public unsafe void UnreliableRemoteSpecialMoveEvent(BmSDK.BmGame.RSpecialMoveConfig Move, BmSDK.FName MoveEvent)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.UnreliableRemoteSpecialMoveEvent", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Move, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveEvent, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClientRemoteSpecialMoveEvent
    /// </summary>
    public unsafe void ClientRemoteSpecialMoveEvent(BmSDK.BmGame.RSpecialMoveConfig Move, BmSDK.FName MoveEvent)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.ClientRemoteSpecialMoveEvent", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Move, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveEvent, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ServerRemoteSpecialMoveEvent
    /// </summary>
    public unsafe void ServerRemoteSpecialMoveEvent(BmSDK.BmGame.RSpecialMoveConfig Move, BmSDK.FName MoveEvent)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.ServerRemoteSpecialMoveEvent", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Move, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveEvent, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RemoteSpecialMoveEvent
    /// </summary>
    public unsafe void RemoteSpecialMoveEvent(BmSDK.BmGame.RSpecialMoveConfig Move, BmSDK.FName MoveEvent)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.RemoteSpecialMoveEvent", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Move, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveEvent, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsHangingFromGarg
    /// </summary>
    public unsafe bool IsHangingFromGarg()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.IsHangingFromGarg", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsOnRailing
    /// </summary>
    public unsafe bool IsOnRailing()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.IsOnRailing", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsInVantage
    /// </summary>
    public unsafe bool IsInVantage()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.IsInVantage", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: AgilityBoost
    /// </summary>
    public unsafe void AgilityBoost()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.AgilityBoost", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ServerSetWireWalking
    /// </summary>
    public unsafe void ServerSetWireWalking(bool OnOrOff, BmSDK.BmGame.RHidePoint_RopeBase NewWire)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.ServerSetWireWalking", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OnOrOff, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWire, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AuthoritySetWireWalking
    /// </summary>
    public unsafe void AuthoritySetWireWalking(bool OnOrOff, BmSDK.BmGame.RHidePoint_RopeBase NewWire)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.AuthoritySetWireWalking", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OnOrOff, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWire, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetWireWalking
    /// </summary>
    public unsafe void SetWireWalking(bool OnOrOff, BmSDK.BmGame.RHidePoint_RopeBase NewWire)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.SetWireWalking", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OnOrOff, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWire, paramsPtr + 4);
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
    /// Function: FindRailing
    /// </summary>
    public unsafe bool FindRailing(System.Numerics.Vector3 Direction, out BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator RailingLoc)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.FindRailing", true);
        byte* paramsPtr = stackalloc byte[128];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        RailingLoc = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 124);
    }

    /// <summary>
    /// Function: ClearGrapplePointControlPoint
    /// </summary>
    public unsafe void ClearGrapplePointControlPoint()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.ClearGrapplePointControlPoint", true);
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
    /// Function: CreateGrappleWireControlPoint
    /// </summary>
    public unsafe void CreateGrappleWireControlPoint(BmSDK.BmGame.RHidePoint_RopeBase Wire, System.Numerics.Vector3 ApproxPosition)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.CreateGrappleWireControlPoint", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Wire, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ApproxPosition, paramsPtr + 4);
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
    /// Function: SetLastWirePoint
    /// </summary>
    public unsafe void SetLastWirePoint(BmSDK.BmGame.RHidePoint_RopeBase NewWire)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.SetLastWirePoint", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWire, paramsPtr + 0);
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
    /// Function: WireLimbAllOff
    /// </summary>
    public unsafe void WireLimbAllOff()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.WireLimbAllOff", true);
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
    /// Function: WireLimbOnOrOff
    /// </summary>
    public unsafe void WireLimbOnOrOff(BmSDK.BmGame.RPawnPlayer.OverheadRopeControlPointType LimbType, bool bOnOrOff)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.WireLimbOnOrOff", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LimbType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnOrOff, paramsPtr + 4);
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
    /// Function: OverrideUnderEdgeCollection
    /// </summary>
    public unsafe void OverrideUnderEdgeCollection(BmSDK.Engine.PrimitiveComponent Comp)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.OverrideUnderEdgeCollection", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Comp, paramsPtr + 0);
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
    /// Function: AddFakeCollisionNormal
    /// </summary>
    public unsafe void AddFakeCollisionNormal(out System.Numerics.Vector3 CollisionNormal)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.AddFakeCollisionNormal", true);
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        CollisionNormal = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: GetRailingJumpDirection
    /// </summary>
    public unsafe System.Numerics.Vector3 GetRailingJumpDirection()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.GetRailingJumpDirection", true);
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetSecondRailingTop
    /// </summary>
    public unsafe void GetSecondRailingTop(out System.Numerics.Vector3 PointA, out System.Numerics.Vector3 PointB)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.GetSecondRailingTop", true);
        byte* paramsPtr = stackalloc byte[24];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        PointA = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        PointB = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    /// <summary>
    /// Function: GetRailingTop
    /// </summary>
    public unsafe void GetRailingTop(out System.Numerics.Vector3 PointA, out System.Numerics.Vector3 PointB)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.GetRailingTop", true);
        byte* paramsPtr = stackalloc byte[24];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        PointA = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        PointB = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    /// <summary>
    /// Function: GetRailingInfo
    /// </summary>
    public unsafe bool GetRailingInfo(System.Numerics.Vector3 MoveDirection = default, bool bActuallyLanding = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.GetRailingInfo", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveDirection, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bActuallyLanding, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: V2PredTriggerSpotted
    /// </summary>
    public unsafe void V2PredTriggerSpotted(BmSDK.BmGame.RBMAIController Spotter)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.V2PredTriggerSpotted", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Spotter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ServerPlayRelativeTransition
    /// </summary>
    public unsafe void ServerPlayRelativeTransition(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, System.Numerics.Vector3 TransitionTargetPosition, int TransitionTargetYaw, float TransitionMeetingPoint, BmSDK.FName TransitionName = default, bool Mirrored = default, BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig CustomTransition = default, BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig CustomIdle = default, BmSDK.BmGame.RAnimUtil.EMirrorChoice TransitionMirrored = default, float TransitionDurationScale = default, float TransitionStartTime = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.ServerPlayRelativeTransition", true);
        byte* paramsPtr = stackalloc byte[140];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetPosition, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetYaw, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMeetingPoint, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mirrored, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomTransition, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIdle, paramsPtr + 88);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMirrored, paramsPtr + 128);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionDurationScale, paramsPtr + 132);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionStartTime, paramsPtr + 136);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClientPlayRelativeTransition
    /// </summary>
    public unsafe void ClientPlayRelativeTransition(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, System.Numerics.Vector3 TransitionTargetPosition, int TransitionTargetYaw, float TransitionMeetingPoint, BmSDK.FName TransitionName = default, bool Mirrored = default, BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig CustomTransition = default, BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig CustomIdle = default, BmSDK.BmGame.RAnimUtil.EMirrorChoice TransitionMirrored = default, float TransitionDurationScale = default, float TransitionStartTime = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.ClientPlayRelativeTransition", true);
        byte* paramsPtr = stackalloc byte[140];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetPosition, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetYaw, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMeetingPoint, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mirrored, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomTransition, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIdle, paramsPtr + 88);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMirrored, paramsPtr + 128);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionDurationScale, paramsPtr + 132);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionStartTime, paramsPtr + 136);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayReplicatedRelativeTransitionEx
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId PlayReplicatedRelativeTransitionEx(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, System.Numerics.Vector3 TransitionTargetPosition, int TransitionTargetYaw, float TransitionMeetingPoint, BmSDK.FName TransitionName = default, bool Mirrored = default, BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig CustomTransition = default, BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig CustomIdle = default, BmSDK.BmGame.RAnimUtil.EMirrorChoice TransitionMirrored = default, float TransitionDurationScale = default, float TransitionStartTime = default, bool bReplicateToServer = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.PlayReplicatedRelativeTransitionEx", true);
        byte* paramsPtr = stackalloc byte[152];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetPosition, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetYaw, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMeetingPoint, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mirrored, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomTransition, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIdle, paramsPtr + 88);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMirrored, paramsPtr + 128);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionDurationScale, paramsPtr + 132);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionStartTime, paramsPtr + 136);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bReplicateToServer, paramsPtr + 140);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 144);
    }

    /// <summary>
    /// Function: PlayReplicatedRelativeTransition
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId PlayReplicatedRelativeTransition(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, System.Numerics.Vector3 TransitionTargetPosition, int TransitionTargetYaw, float TransitionMeetingPoint, BmSDK.FName TransitionName = default, bool Mirrored = default, BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig CustomTransition = default, BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig CustomIdle = default, BmSDK.BmGame.RAnimUtil.EMirrorChoice TransitionMirrored = default, float TransitionDurationScale = default, float TransitionStartTime = default, bool bReplicateToServer = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.PlayReplicatedRelativeTransition", true);
        byte* paramsPtr = stackalloc byte[152];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetPosition, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetYaw, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMeetingPoint, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mirrored, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomTransition, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIdle, paramsPtr + 88);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMirrored, paramsPtr + 128);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionDurationScale, paramsPtr + 132);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionStartTime, paramsPtr + 136);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bReplicateToServer, paramsPtr + 140);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 144);
    }

    /// <summary>
    /// Function: ServerPlayRelativeTransitionRotationOnly
    /// </summary>
    public unsafe void ServerPlayRelativeTransitionRotationOnly(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, int TransitionTargetYaw, float TransitionMeetingPoint, BmSDK.FName TransitionName = default, bool Mirrored = default, BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig CustomTransition = default, BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig CustomIdle = default, BmSDK.BmGame.RAnimUtil.EMirrorChoice TransitionMirrored = default, float TransitionDurationScale = default, float TransitionStartTime = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.ServerPlayRelativeTransitionRotationOnly", true);
        byte* paramsPtr = stackalloc byte[128];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetYaw, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMeetingPoint, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mirrored, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomTransition, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIdle, paramsPtr + 76);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMirrored, paramsPtr + 116);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionDurationScale, paramsPtr + 120);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionStartTime, paramsPtr + 124);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClientPlayRelativeTransitionRotationOnly
    /// </summary>
    public unsafe void ClientPlayRelativeTransitionRotationOnly(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, int TransitionTargetYaw, float TransitionMeetingPoint, BmSDK.FName TransitionName = default, bool Mirrored = default, BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig CustomTransition = default, BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig CustomIdle = default, BmSDK.BmGame.RAnimUtil.EMirrorChoice TransitionMirrored = default, float TransitionDurationScale = default, float TransitionStartTime = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.ClientPlayRelativeTransitionRotationOnly", true);
        byte* paramsPtr = stackalloc byte[128];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetYaw, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMeetingPoint, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mirrored, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomTransition, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIdle, paramsPtr + 76);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMirrored, paramsPtr + 116);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionDurationScale, paramsPtr + 120);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionStartTime, paramsPtr + 124);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayReplicatedRelativeTransitionRotationOnly
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId PlayReplicatedRelativeTransitionRotationOnly(BmSDK.FName MovementStance, BmSDK.FName WeaponStance, int TransitionTargetYaw, float TransitionMeetingPoint, BmSDK.FName TransitionName = default, bool Mirrored = default, BmSDK.BmGame.RPawnCharacter.FCustomTransitionConfig CustomTransition = default, BmSDK.BmGame.RPawnCharacter.FCustomIdleConfig CustomIdle = default, BmSDK.BmGame.RAnimUtil.EMirrorChoice TransitionMirrored = default, float TransitionDurationScale = default, float TransitionStartTime = default, bool bReplicateToServer = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.PlayReplicatedRelativeTransitionRotationOnly", true);
        byte* paramsPtr = stackalloc byte[140];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionTargetYaw, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMeetingPoint, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionName, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mirrored, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomTransition, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIdle, paramsPtr + 76);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMirrored, paramsPtr + 116);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionDurationScale, paramsPtr + 120);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionStartTime, paramsPtr + 124);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bReplicateToServer, paramsPtr + 128);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 132);
    }

    /// <summary>
    /// Function: StopAimAt
    /// </summary>
    public unsafe void StopAimAt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.StopAimAt", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AimInDirection
    /// </summary>
    public unsafe void AimInDirection(System.Numerics.Vector3 Direction, BmSDK.FName Description = default, BmSDK.BmGame.RAnimConfig.EYesNoDefault AllowTurningToAim = default, float LimitScale = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.AimInDirection", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Description, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AllowTurningToAim, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LimitScale, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DestroyAllProjectiles
    /// </summary>
    public unsafe void DestroyAllProjectiles()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.DestroyAllProjectiles", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UnHideHead
    /// </summary>
    public unsafe void UnHideHead()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.UnHideHead", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HideHead
    /// </summary>
    public unsafe void HideHead()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.HideHead", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetVenomHenchmanRidden
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnBossVenomBase GetVenomHenchmanRidden()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.GetVenomHenchmanRidden", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnBossVenomBase>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsRidingVenomHenchman
    /// </summary>
    public unsafe bool IsRidingVenomHenchman()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.IsRidingVenomHenchman", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: OnPlayerHasBeenMoved
    /// </summary>
    public unsafe void OnPlayerHasBeenMoved()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.OnPlayerHasBeenMoved", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetDesiredPoseType
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.EBatmanPoseType GetDesiredPoseType()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.GetDesiredPoseType", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.EBatmanPoseType>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ResetRagdollLinearDamping
    /// </summary>
    public unsafe void ResetRagdollLinearDamping()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.ResetRagdollLinearDamping", true);
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
    /// Function: SetRagdollLinearDampingForGrappleDeath
    /// </summary>
    public unsafe void SetRagdollLinearDampingForGrappleDeath()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.SetRagdollLinearDampingForGrappleDeath", true);
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
    /// Function: ResetRagdollDamping
    /// </summary>
    public unsafe void ResetRagdollDamping()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.ResetRagdollDamping", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SlowDownRagdollDeath
    /// </summary>
    public unsafe void SlowDownRagdollDeath()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.SlowDownRagdollDeath", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanBeTracked
    /// </summary>
    public unsafe bool CanBeTracked()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.CanBeTracked", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetCameraStateName
    /// </summary>
    public unsafe BmSDK.FName GetCameraStateName()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.GetCameraStateName", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetPCStateName
    /// </summary>
    public unsafe BmSDK.FName GetPCStateName()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.GetPCStateName", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetThoughts
    /// </summary>
    public unsafe void GetThoughts(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.GetThoughts", true);
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: GetDamageResistance
    /// </summary>
    public unsafe int GetDamageResistance()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.GetDamageResistance", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetRangedDamageResistance
    /// </summary>
    public unsafe int GetRangedDamageResistance()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.GetRangedDamageResistance", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: AllowIdleOverlaysAgain
    /// </summary>
    public unsafe void AllowIdleOverlaysAgain()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.AllowIdleOverlaysAgain", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TempStopIdleOverlays
    /// </summary>
    public unsafe void TempStopIdleOverlays(float T = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.TempStopIdleOverlays", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(T, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TakeDamage
    /// </summary>
    public unsafe void TakeDamage(int Damage, BmSDK.Engine.Controller InstigatedBy, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.Engine.Actor.FTraceHitInfo HitInfo = default, BmSDK.Engine.Actor DamageCauser = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.TakeDamage", true);
        byte* paramsPtr = stackalloc byte[104];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Damage, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstigatedBy, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitInfo, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageCauser, paramsPtr + 72);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StruckEnemy
    /// </summary>
    public unsafe void StruckEnemy(BmSDK.BmGame.RPawnCombat TheEnemy)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.StruckEnemy", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheEnemy, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsFullArmour
    /// </summary>
    public unsafe bool IsFullArmour()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.IsFullArmour", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ApplyArmour
    /// </summary>
    public unsafe void ApplyArmour(out int Damage, BmSDK.Class DamageType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.ApplyArmour", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Damage = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: RestoreArmour
    /// </summary>
    public unsafe void RestoreArmour(int ExtraHealth)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.RestoreArmour", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtraHealth, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DebugRemoveArmour
    /// </summary>
    public unsafe void DebugRemoveArmour()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.DebugRemoveArmour", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DebugGiveArmour
    /// </summary>
    public unsafe void DebugGiveArmour()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.DebugGiveArmour", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShouldPlayHitReaction
    /// </summary>
    public unsafe bool ShouldPlayHitReaction(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo, BmSDK.Class RangedDmgType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.ShouldPlayHitReaction", true);
        byte* paramsPtr = stackalloc byte[252];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RangedDmgType, paramsPtr + 244);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 248);
    }

    /// <summary>
    /// Function: ShotBy
    /// </summary>
    public unsafe void ShotBy(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo, System.Numerics.Vector3 HitLocation = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.ShotBy", true);
        byte* paramsPtr = stackalloc byte[272];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 244);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HealDamage
    /// </summary>
    public unsafe bool HealDamage(int Amount, BmSDK.Engine.Controller Healer, BmSDK.Class DamageType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.HealDamage", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Amount, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Healer, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: RestoreHealthAndArmour
    /// </summary>
    public unsafe void RestoreHealthAndArmour(int HealthToRecover)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.RestoreHealthAndArmour", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HealthToRecover, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ExperienceAwarded
    /// </summary>
    public unsafe void ExperienceAwarded(int XPAwarded, int TeethXpAwarded)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.ExperienceAwarded", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(XPAwarded, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TeethXpAwarded, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayDeathAnim
    /// </summary>
    public unsafe void PlayDeathAnim(BmSDK.FName DeathAnim, BmSDK.Engine.AnimSet AnimSet, System.Numerics.Vector3 HitDir = default, bool bDelayTransitionForRagDoll = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.PlayDeathAnim", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeathAnim, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitDir, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDelayTransitionForRagDoll, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayDeathAnimAndCape
    /// </summary>
    public unsafe void PlayDeathAnimAndCape(BmSDK.FName DeathAnim, BmSDK.Engine.AnimSet AnimSet, System.Numerics.Vector3 HitDir = default, bool bDelayTransitionForRagDoll = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.PlayDeathAnimAndCape", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeathAnim, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitDir, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDelayTransitionForRagDoll, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: WillFlightPathHit
    /// </summary>
    public unsafe bool WillFlightPathHit(float FlightTime, out System.Numerics.Vector3 OverrideStartPos, bool bDrawDebug)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.WillFlightPathHit", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlightTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDrawDebug, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OverrideStartPos = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: SetupLocatorFromCornerPoint
    /// </summary>
    public unsafe void SetupLocatorFromCornerPoint(BmSDK.BmGame.RCornerWallMarkerBase Corner, out BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.SetupLocatorFromCornerPoint", true);
        byte* paramsPtr = stackalloc byte[116];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Corner, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Loc = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(paramsPtr + 4);
        return;
    }

    /// <summary>
    /// Function: GetRailingTopAndNormal
    /// </summary>
    public unsafe void GetRailingTopAndNormal(BmSDK.Engine.StaticMeshActorBase Railing, out BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator out_Locator)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.GetRailingTopAndNormal", true);
        byte* paramsPtr = stackalloc byte[116];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Railing, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_Locator = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(paramsPtr + 4);
        return;
    }

    /// <summary>
    /// Function: SetDeferredVelocity
    /// </summary>
    public unsafe void SetDeferredVelocity(System.Numerics.Vector3 NewVelocity)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.SetDeferredVelocity", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewVelocity, paramsPtr + 0);
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
    /// Function: ShouldIFallOffEdge
    /// </summary>
    public unsafe bool ShouldIFallOffEdge(bool bCheckForLand = default, bool bForceCheck = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.ShouldIFallOffEdge", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCheckForLand, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceCheck, paramsPtr + 4);
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
    /// Function: FindContactName
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FindContactName(BmSDK.BmGame.RAnimNotify_Footstep.EFoot Foot, BmSDK.BmGame.RAnimNotify_Footstep.EContactType Contact)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.FindContactName", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Foot, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Contact, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: SetOwnerNoSee
    /// </summary>
    public unsafe void SetOwnerNoSee(bool bNewOwnerNoSee)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.SetOwnerNoSee", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewOwnerNoSee, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CheckSpaceForGrappleRoll
    /// </summary>
    public unsafe bool CheckSpaceForGrappleRoll(BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.CheckSpaceForGrappleRoll", true);
        byte* paramsPtr = stackalloc byte[116];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 112);
    }

    /// <summary>
    /// Function: CanPerformLandRoll
    /// </summary>
    public unsafe bool CanPerformLandRoll(System.Numerics.Vector3 LandLocation, System.Numerics.Vector3 Direction, float Distance, bool bCheckDropAtEnd = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.CanPerformLandRoll", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LandLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Distance, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCheckDropAtEnd, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 32);
    }

    /// <summary>
    /// Function: IsLedgeATunnelLedge
    /// </summary>
    public unsafe bool IsLedgeATunnelLedge(BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.IsLedgeATunnelLedge", true);
        byte* paramsPtr = stackalloc byte[116];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 112);
    }

    /// <summary>
    /// Function: IsLedgeADangleLedge
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.EHangLedgeType IsLedgeADangleLedge(BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.IsLedgeADangleLedge", true);
        byte* paramsPtr = stackalloc byte[113];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.EHangLedgeType>(paramsPtr + 112);
    }

    /// <summary>
    /// Function: OnDestroyPhysicsAssetInstance
    /// </summary>
    public unsafe void OnDestroyPhysicsAssetInstance(BmSDK.Engine.SkeletalMeshComponent AffectedComponent)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.OnDestroyPhysicsAssetInstance", true);
        byte* paramsPtr = stackalloc byte[4];
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
    public unsafe void OnCreatePhysicsAssetInstance(BmSDK.Engine.SkeletalMeshComponent AffectedComponent)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.OnCreatePhysicsAssetInstance", true);
        byte* paramsPtr = stackalloc byte[4];
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
    /// Function: IsBatarangable
    /// </summary>
    public unsafe bool IsBatarangable()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.IsBatarangable", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: EndGelSpray
    /// </summary>
    public unsafe void EndGelSpray()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.EndGelSpray", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartGelSpray
    /// </summary>
    public unsafe void StartGelSpray()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.StartGelSpray", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FireLineLauncher
    /// </summary>
    public unsafe void FireLineLauncher()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.FireLineLauncher", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DebugInfiniteAmmo
    /// </summary>
    public unsafe void DebugInfiniteAmmo()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.DebugInfiniteAmmo", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RestoreAmmo
    /// </summary>
    public unsafe void RestoreAmmo()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.RestoreAmmo", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DebugGiveFreezeBlast
    /// </summary>
    public unsafe void DebugGiveFreezeBlast()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.DebugGiveFreezeBlast", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DebugGiveAllGadgets
    /// </summary>
    public unsafe void DebugGiveAllGadgets()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.DebugGiveAllGadgets", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GiveGadget
    /// </summary>
    public unsafe void GiveGadget(BmSDK.Class GadgetClass, bool UpdateHud = default, bool bDuringSetup = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.GiveGadget", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GadgetClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UpdateHud, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDuringSetup, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ReplaceGadget
    /// </summary>
    public unsafe void ReplaceGadget(BmSDK.FName current_gadget, BmSDK.FName new_gadget)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.ReplaceGadget", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(current_gadget, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(new_gadget, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnGiveInventory
    /// </summary>
    public unsafe void OnGiveInventory(BmSDK.Engine.SeqAct_GiveInventory inAction)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.OnGiveInventory", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayCrowStartledLine
    /// </summary>
    public unsafe void PlayCrowStartledLine()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.PlayCrowStartledLine", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayWouldBreakNewGamePlusLine
    /// </summary>
    public unsafe void PlayWouldBreakNewGamePlusLine()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.PlayWouldBreakNewGamePlusLine", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateInvClass
    /// </summary>
    public unsafe BmSDK.Class UpdateInvClass(BmSDK.Class InvClass)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.UpdateInvClass", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InvClass, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: ClearOverridableTransition
    /// </summary>
    public unsafe void ClearOverridableTransition()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.ClearOverridableTransition", true);
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
    /// Function: AnimationTriggerCallback
    /// </summary>
    public unsafe void AnimationTriggerCallback(BmSDK.FName TagName, BmSDK.TArray<BmSDK.FString> Params, BmSDK.Engine.AnimSet TagAnimSet, float Time)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.AnimationTriggerCallback", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TagName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Params, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TagAnimSet, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: EncroachedBy
    /// </summary>
    public unsafe void EncroachedBy(BmSDK.Engine.Actor Other)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.EncroachedBy", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Touch
    /// </summary>
    public unsafe void Touch(BmSDK.Engine.Actor Other, BmSDK.Engine.PrimitiveComponent OtherComp, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 HitNormal)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.Touch", true);
        byte* paramsPtr = stackalloc byte[76];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComp, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HitWall
    /// </summary>
    public unsafe void HitWall(System.Numerics.Vector3 HitNormal, BmSDK.Engine.Actor Wall, BmSDK.Engine.PrimitiveComponent WallComp)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.HitWall", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Wall, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallComp, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Bump
    /// </summary>
    public unsafe void Bump(BmSDK.Engine.Actor Other, BmSDK.Engine.PrimitiveComponent OtherComp, System.Numerics.Vector3 HitNormal)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.Bump", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComp, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ResetGroundFriction
    /// </summary>
    public unsafe void ResetGroundFriction()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.ResetGroundFriction", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: EndCrouch
    /// </summary>
    public unsafe void EndCrouch(float HeightAdjust)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.EndCrouch", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HeightAdjust, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartCrouch
    /// </summary>
    public unsafe void StartCrouch(float HeightAdjust)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.StartCrouch", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HeightAdjust, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IndirectAwareness_UpdateData
    /// </summary>
    public unsafe void IndirectAwareness_UpdateData(System.Numerics.Vector3 AlertLoc, float BackDateTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.IndirectAwareness_UpdateData", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AlertLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BackDateTime, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DrawLastSeenDebugVis
    /// </summary>
    public unsafe void DrawLastSeenDebugVis()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.DrawLastSeenDebugVis", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HasBeenSeen_UpdateData
    /// </summary>
    public unsafe void HasBeenSeen_UpdateData()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.HasBeenSeen_UpdateData", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetGlanceScore
    /// </summary>
    public unsafe int GetGlanceScore()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.GetGlanceScore", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: DoCustomVisCheck
    /// </summary>
    public unsafe bool DoCustomVisCheck()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.DoCustomVisCheck", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ScriptCheckVisibility
    /// </summary>
    public unsafe bool ScriptCheckVisibility(BmSDK.BmGame.RBMAIController TestController)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.ScriptCheckVisibility", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestController, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetBatarangSpeedBoost
    /// </summary>
    public unsafe float GetBatarangSpeedBoost()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.GetBatarangSpeedBoost", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ForceHitAtEndOfFlight
    /// </summary>
    public unsafe bool ForceHitAtEndOfFlight()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.ForceHitAtEndOfFlight", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetBatarangPriority
    /// </summary>
    public unsafe float GetBatarangPriority()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.GetBatarangPriority", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetBatarangTargetPosition
    /// </summary>
    public unsafe System.Numerics.Vector3 GetBatarangTargetPosition(System.Numerics.Vector3 AimLocation, System.Numerics.Vector3 AimDirection, bool bDuringTargetPhase = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.GetBatarangTargetPosition", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AimDirection, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDuringTargetPhase, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 28);
    }

    /// <summary>
    /// Function: GetHarpoonOpenGrateMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GetHarpoonOpenGrateMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.GetHarpoonOpenGrateMove", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: UpdateGrateExcluder
    /// </summary>
    public unsafe void UpdateGrateExcluder()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.UpdateGrateExcluder", true);
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
    /// Function: FindNearbyLedge
    /// </summary>
    public unsafe bool FindNearbyLedge(System.Numerics.Vector3 PlayerLocation, out BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Locator, float MinimalDrop = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.FindNearbyLedge", true);
        byte* paramsPtr = stackalloc byte[132];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinimalDrop, paramsPtr + 124);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Locator = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 128);
    }

    /// <summary>
    /// Function: ForceUnCrouch
    /// </summary>
    public unsafe void ForceUnCrouch()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.ForceUnCrouch", true);
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
    /// Function: UpdateShimmyEnv
    /// </summary>
    public unsafe void UpdateShimmyEnv(float CollisionHeight, float CollisionRadius, float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.UpdateShimmyEnv", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CollisionHeight, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CollisionRadius, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 8);
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
    /// Function: CheckSurroundingEnvironment
    /// </summary>
    public unsafe void CheckSurroundingEnvironment(float CollisionHeight, float CollisionRadius, float DeltaTime, BmSDK.Engine.PrimitiveComponent HintPrimitive = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.CheckSurroundingEnvironment", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CollisionHeight, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CollisionRadius, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HintPrimitive, paramsPtr + 12);
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
    /// Function: CheckForInterrogationEnvironment
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator CheckForInterrogationEnvironment(BmSDK.BmGame.RPawnCombat CheckPawn, float FeatureCheckDistance = default, BmSDK.BmGame.RBM2IdleConfig.EInterrogationPose InterrogationPose = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.CheckForInterrogationEnvironment", true);
        byte* paramsPtr = stackalloc byte[124];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FeatureCheckDistance, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InterrogationPose, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: ServerChangeAttachedGadget
    /// </summary>
    public unsafe void ServerChangeAttachedGadget(BmSDK.Class NewAttachedGadget)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.ServerChangeAttachedGadget", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAttachedGadget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NetworkTick
    /// </summary>
    public unsafe void NetworkTick(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.NetworkTick", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateReplenishingHealth
    /// </summary>
    public unsafe void UpdateReplenishingHealth(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.UpdateReplenishingHealth", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateGlideWake
    /// </summary>
    public unsafe void UpdateGlideWake()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.UpdateGlideWake", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.Tick", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnFootstepNotify
    /// </summary>
    public unsafe void OnFootstepNotify(BmSDK.BmGame.RAnimNotify_Footstep.EFoot Foot, BmSDK.BmGame.RAnimNotify_Footstep.EContactType Contact, BmSDK.BmGame.RAnimNotify_Footstep.EFootstepSurfaceFinder SurfaceFinder, System.Numerics.Vector3 FootLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.OnFootstepNotify", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Foot, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Contact, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SurfaceFinder, paramsPtr + 2);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FootLocation, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DrawHUD
    /// </summary>
    public unsafe void DrawHUD(BmSDK.Engine.HUD H)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.DrawHUD", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(H, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ApplyDistributedForceToRagdoll
    /// </summary>
    public unsafe void ApplyDistributedForceToRagdoll()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.ApplyDistributedForceToRagdoll", true);
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
    /// Function: Died
    /// </summary>
    public unsafe bool Died(BmSDK.Engine.Controller Killer, BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.Died", true);
        byte* paramsPtr = stackalloc byte[76];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: SelectDeathTip
    /// </summary>
    public unsafe void SelectDeathTip(BmSDK.Engine.Controller Killer, BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation, bool bKilledInCombat)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.SelectDeathTip", true);
        byte* paramsPtr = stackalloc byte[88];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKilledInCombat, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SelectDeathMovie
    /// </summary>
    public unsafe void SelectDeathMovie(BmSDK.Engine.Controller Killer, BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.SelectDeathMovie", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FindAndPlayOverrideDeathAnim
    /// </summary>
    public unsafe bool FindAndPlayOverrideDeathAnim(BmSDK.Class DamageType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.FindAndPlayOverrideDeathAnim", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: ReplicateDied
    /// </summary>
    public unsafe void ReplicateDied(BmSDK.Engine.Controller Killer, BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation, BmSDK.Engine.Actor DmgCauser, System.Numerics.Vector3 DmgImpulse, BmSDK.FName DmgBoneName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.ReplicateDied", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgCauser, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgImpulse, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgBoneName, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GoRagdoll
    /// </summary>
    public unsafe void GoRagdoll()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.GoRagdoll", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowHealthAndArmour
    /// </summary>
    public unsafe void ShowHealthAndArmour()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.ShowHealthAndArmour", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HasUpgrade
    /// </summary>
    public unsafe bool HasUpgrade(BmSDK.FString UpgradeFlag)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.HasUpgrade", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UpgradeFlag, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: SetArmourCurrent
    /// </summary>
    public unsafe void SetArmourCurrent(BmSDK.BmGame.RPawnPlayer.EArmourType armour_type, int current_armour)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.SetArmourCurrent", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(armour_type, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(current_armour, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetArmourMaximum
    /// </summary>
    public unsafe int GetArmourMaximum(BmSDK.BmGame.RPawnPlayer.EArmourType armour_type)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.GetArmourMaximum", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(armour_type, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: SetArmourMaximum
    /// </summary>
    public unsafe void SetArmourMaximum(BmSDK.BmGame.RPawnPlayer.EArmourType armour_type, int max_armour)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.SetArmourMaximum", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(armour_type, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(max_armour, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateMaximumHealthAndArmour
    /// </summary>
    public unsafe void UpdateMaximumHealthAndArmour(bool bReplenishArmour = default, bool bInitialUpdate = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.UpdateMaximumHealthAndArmour", true);
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bReplenishArmour, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInitialUpdate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetUnlockedMeleeArmourLevel
    /// </summary>
    public unsafe int GetUnlockedMeleeArmourLevel()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.GetUnlockedMeleeArmourLevel", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetUnlockedBallisticArmourLevel
    /// </summary>
    public unsafe int GetUnlockedBallisticArmourLevel()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.GetUnlockedBallisticArmourLevel", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetPersistentMeleeArmour
    /// </summary>
    public unsafe void SetPersistentMeleeArmour(int armour)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.SetPersistentMeleeArmour", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(armour, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetPersistentBallisticArmour
    /// </summary>
    public unsafe void SetPersistentBallisticArmour(int armour)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.SetPersistentBallisticArmour", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(armour, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetPersistentMeleeArmour
    /// </summary>
    public unsafe int GetPersistentMeleeArmour()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.GetPersistentMeleeArmour", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetPersistentBallisticArmour
    /// </summary>
    public unsafe int GetPersistentBallisticArmour()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.GetPersistentBallisticArmour", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: HealthUpdated
    /// </summary>
    public unsafe void HealthUpdated()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.HealthUpdated", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnModifyHealth
    /// </summary>
    public unsafe void OnModifyHealth(BmSDK.Engine.SeqAct_ModifyHealth Action)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.OnModifyHealth", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: LoadHealth
    /// </summary>
    public unsafe void LoadHealth()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.LoadHealth", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe void PostBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.PostBeginPlay", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StopMoveTo
    /// </summary>
    public unsafe void StopMoveTo()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.StopMoveTo", true);
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
    /// Function: MoveInDirection
    /// </summary>
    public unsafe void MoveInDirection(System.Numerics.Vector3 Direction)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.MoveInDirection", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 0);
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
    /// Function: SetChargeStrikeSpeed
    /// </summary>
    public unsafe void SetChargeStrikeSpeed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.SetChargeStrikeSpeed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetStealthSpeed
    /// </summary>
    public unsafe void SetStealthSpeed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.SetStealthSpeed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetAimSpeed
    /// </summary>
    public unsafe void SetAimSpeed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.SetAimSpeed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetGlideSpeed
    /// </summary>
    public unsafe void SetGlideSpeed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.SetGlideSpeed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetBatarangWalkSpeed
    /// </summary>
    public unsafe void SetBatarangWalkSpeed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.SetBatarangWalkSpeed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetWalkSpeed
    /// </summary>
    public unsafe void SetWalkSpeed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.SetWalkSpeed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetRunSpeed
    /// </summary>
    public unsafe void SetRunSpeed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.SetRunSpeed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AdjustMovementDirection
    /// </summary>
    public unsafe System.Numerics.Vector3 AdjustMovementDirection(System.Numerics.Vector3 MovDir)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.AdjustMovementDirection", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovDir, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: StartPlayerIconFX
    /// </summary>
    public unsafe void StartPlayerIconFX(BmSDK.Engine.ParticleSystem OverrideFX, bool bInNetworkedShowOnlyOtherPlayer)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.StartPlayerIconFX", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideFX, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInNetworkedShowOnlyOtherPlayer, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsShimmying
    /// </summary>
    public unsafe bool IsShimmying()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.IsShimmying", true);
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
    /// Function: PointInTriangle2D
    /// </summary>
    public unsafe static bool PointInTriangle2D(System.Numerics.Vector3 Point, System.Numerics.Vector3 Vert0, System.Numerics.Vector3 Vert1, System.Numerics.Vector3 Vert2)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.PointInTriangle2D", true);
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Point, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Vert0, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Vert1, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Vert2, paramsPtr + 36);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 48);
    }

    /// <summary>
    /// Function: SetDamageLevel
    /// </summary>
    public unsafe void SetDamageLevel(BmSDK.FName PlayerCharacterName, int NewDamageLevel)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.SetDamageLevel", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerCharacterName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewDamageLevel, paramsPtr + 8);
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
    /// Function: CanCapeGlide
    /// </summary>
    public unsafe bool CanCapeGlide(bool ActuallyTryingToTriggerGlide)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayer.CanCapeGlide", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActuallyTryingToTriggerGlide, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Enum: EQuickGadgetType
    /// </summary>
    public enum EQuickGadgetType
    {
        QGT_GadgetLT = 0,
        QGT_GadgetRT = 1,
        QGT_GadgetB = 2,
        QGT_GadgetX = 3,
        QGT_GadgetY = 4,
        QGT_QuickGadgetTypeMAX = 5,
        QGT_MAX = 6,
    }

    /// <summary>
    /// Struct: FWireBounceUpdater
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public partial record struct FWireBounceUpdater
    {
        /// <summary>
        /// FloatProperty: CurrentCorrection
        /// </summary>
        public unsafe float CurrentCorrection
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: CurrentAmplitude
        /// </summary>
        public unsafe float CurrentAmplitude
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: CurrentTimer
        /// </summary>
        public unsafe float CurrentTimer
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: CurrentPeriod
        /// </summary>
        public unsafe float CurrentPeriod
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: IncrementedSpeed
        /// </summary>
        public unsafe bool IncrementedSpeed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: MinPeriod
        /// </summary>
        public unsafe float MinPeriod
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// FloatProperty: MaxPeriod
        /// </summary>
        public unsafe float MaxPeriod
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// FloatProperty: MaxCorrection
        /// </summary>
        public unsafe float MaxCorrection
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// FloatProperty: MinCorrection
        /// </summary>
        public unsafe float MinCorrection
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// FloatProperty: MovementCorrection
        /// </summary>
        public unsafe float MovementCorrection
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// FloatProperty: MovementPeriod
        /// </summary>
        public unsafe float MovementPeriod
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// FloatProperty: BlendInStrength
        /// </summary>
        public unsafe float BlendInStrength
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// FloatProperty: DecayStrength
        /// </summary>
        public unsafe float DecayStrength
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// FloatProperty: BuildUpStrength
        /// </summary>
        public unsafe float BuildUpStrength
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// FloatProperty: MinBounceDist
        /// </summary>
        public unsafe float MinBounceDist
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// FloatProperty: MaxBounceDist
        /// </summary>
        public unsafe float MaxBounceDist
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// BoolProperty: bActive
        /// </summary>
        public unsafe bool bActive
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }; }
        }
    }

    /// <summary>
    /// Enum: PerchDirection
    /// </summary>
    public enum PerchDirection
    {
        PD_Forward = 0,
        PD_Backward = 1,
        PD_MAX = 2,
    }

    /// <summary>
    /// Enum: OverheadRopeControlPointType
    /// </summary>
    public enum OverheadRopeControlPointType
    {
        ORCT_LeftHand = 0,
        ORCT_RightHand = 1,
        ORCT_LeftFoot = 2,
        ORCT_RightFoot = 3,
        ORCT_GrapplePoint = 4,
        ORCT_MAX = 5,
    }

    /// <summary>
    /// Struct: FFakeWall
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FFakeWall
    {
        /// <summary>
        /// StructProperty: FakeCollisionNormal
        /// </summary>
        public unsafe System.Numerics.Vector3 FakeCollisionNormal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: FakeCollisionNormalActive
        /// </summary>
        public unsafe bool FakeCollisionNormalActive
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Enum: EStealthTakeDownStages
    /// </summary>
    public enum EStealthTakeDownStages
    {
        ESTDS_CornerGrab = 0,
        ESTDS_FallingTakeDown = 1,
        ESTDS_GlassAttack = 2,
        ESTDS_GrabFromCrouch = 3,
        ESTDS_GrabFromCrouch2 = 4,
        ESTDS_GrabFromCrouchAware = 5,
        ESTDS_GrabFromHang = 6,
        ESTDS_GrabOnFloor = 7,
        ESTDS_LedgeAttack = 8,
        ESTDS_DoubleLedgeAttack = 9,
        ESTDS_RailingAttack = 10,
        ESTDS_SneakyCombatTakeDown = 11,
        ESTDS_ReverseChokeAttack = 12,
        ESTDS_DoubleHead = 13,
        ESTDS_FromAbove = 14,
        ESTDS_LineLauncherTakeDown = 15,
        ESTDS_CwInvertedFromCeilingGrab = 16,
        ESTDS_CwInvertedFromCeilingEnd = 17,
        ESTDS_CwInvertedFromCeilingSuccess = 18,
        ESTDS_FractureWallTakeDown = 19,
        ESTDS_CwPullFromCatwalk = 20,
        ESTDS_TunnelGrateGrab = 21,
        ESTDS_VentAttack = 22,
        ESTDS_BoostGlideTackle = 23,
        ESTDS_SuperGlideTakedown = 24,
        ESTDS_GrappleBoostTakedown = 25,
        ESTDS_LineLauncherAttack = 26,
        ESTDS_LongRangeLedgeTakedown = 27,
        ESTDS_LongRangeRailingTakedown = 28,
        ESTDS_StandingQuickTakedown = 29,
        ESTDS_HangingFearFinish = 30,
        ESTDS_GlassTakedownFinish = 31,
        ESTDS_ReverseChokeFinish = 32,
        ESTDS_TunnelGrateEnd = 33,
        ESTDS_StealthTakeDownStageMAX = 34,
        ESTDS_MAX = 35,
    }

    /// <summary>
    /// Enum: EBatmanPoseType
    /// </summary>
    public enum EBatmanPoseType
    {
        EBPT_Standard = 0,
        EBPT_Combat = 1,
        EBPT_SilentPredator = 2,
        EBPT_DontCare = 3,
        EBPT_MAX = 4,
    }

    /// <summary>
    /// Struct: FCoverDescriptor
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial record struct FCoverDescriptor
    {
        /// <summary>
        /// FloatProperty: LeftCoverDistance
        /// </summary>
        public unsafe float LeftCoverDistance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: LeftCoverNormal
        /// </summary>
        public unsafe System.Numerics.Vector3 LeftCoverNormal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: RightCoverDistance
        /// </summary>
        public unsafe float RightCoverDistance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StructProperty: RightCoverNormal
        /// </summary>
        public unsafe System.Numerics.Vector3 RightCoverNormal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// BoolProperty: bCoveredLeft
        /// </summary>
        public unsafe bool bCoveredLeft
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 32); }; }
        }

        /// <summary>
        /// BoolProperty: bCoveredRight
        /// </summary>
        public unsafe bool bCoveredRight
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 32); }; }
        }

        /// <summary>
        /// BoolProperty: bInCover
        /// </summary>
        public unsafe bool bInCover
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 32); }; }
        }

        /// <summary>
        /// StructProperty: CoverRotator
        /// </summary>
        public unsafe BmSDK.Rotator CoverRotator
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// StructProperty: DesiredCoverPosition
        /// </summary>
        public unsafe System.Numerics.Vector3 DesiredCoverPosition
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// FloatProperty: LROffset
        /// </summary>
        public unsafe float LROffset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }
    }

    /// <summary>
    /// Struct: FRailingInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 21)]
    public partial record struct FRailingInfo
    {
        /// <summary>
        /// StructProperty: EdgeColl
        /// </summary>
        public unsafe System.IntPtr EdgeColl
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: RailingIndex
        /// </summary>
        public unsafe int RailingIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: PointOnRailing
        /// </summary>
        public unsafe System.Numerics.Vector3 PointOnRailing
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ByteProperty: RailingType
        /// </summary>
        public unsafe byte RailingType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Struct: FPlayerEdgeColl
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FPlayerEdgeColl
    {
        /// <summary>
        /// StructProperty: LevelCollection
        /// </summary>
        public unsafe System.IntPtr LevelCollection
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: CollectionIndex
        /// </summary>
        public unsafe int CollectionIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ObjectProperty: Level
        /// </summary>
        public unsafe BmSDK.GameObject Level
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Enum: EArmourType
    /// </summary>
    public enum EArmourType
    {
        EA_ArmourMelee = 0,
        EA_ArmourBallistic = 1,
        EA_MAX = 2,
    }

    /// <summary>
    /// Struct: FCeilingClimbPoint
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 112)]
    public partial record struct FCeilingClimbPoint
    {
        /// <summary>
        /// StructProperty: FeatureLocator
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator FeatureLocator
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Struct: FEnvironmentSpecialMoveLocator
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 112)]
    public partial record struct FEnvironmentSpecialMoveLocator
    {
        /// <summary>
        /// ByteProperty: Type
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnPlayer.EnvironmentSpecialMoveTypes Type
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.EnvironmentSpecialMoveTypes>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: OverrideChosenAnim
        /// </summary>
        public unsafe byte OverrideChosenAnim
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1); }; }
        }

        /// <summary>
        /// ByteProperty: EdgeType
        /// </summary>
        public unsafe byte EdgeType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2); }; }
        }

        /// <summary>
        /// ByteProperty: AnimDir
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnPlayer.EnvironmentAnimationDirection AnimDir
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.EnvironmentAnimationDirection>(Ptr + 3); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3); }; }
        }

        /// <summary>
        /// StructProperty: Location
        /// </summary>
        public unsafe System.Numerics.Vector3 Location
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: Normal
        /// </summary>
        public unsafe System.Numerics.Vector3 Normal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: Distance
        /// </summary>
        public unsafe float Distance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// FloatProperty: AnimTimeOverride
        /// </summary>
        public unsafe float AnimTimeOverride
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// FloatProperty: TransitionDurationScale
        /// </summary>
        public unsafe float TransitionDurationScale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// ObjectProperty: ActorInstance
        /// </summary>
        public unsafe BmSDK.Engine.Actor ActorInstance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: bCantOverrideDirection
        /// </summary>
        public unsafe bool bCantOverrideDirection
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 44); }; }
        }

        /// <summary>
        /// BoolProperty: bForceMirror
        /// </summary>
        public unsafe bool bForceMirror
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 44); }; }
        }

        /// <summary>
        /// BoolProperty: bForceMirrorChoice
        /// </summary>
        public unsafe bool bForceMirrorChoice
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 44); }; }
        }

        /// <summary>
        /// StructProperty: ExtraVectorInfo
        /// </summary>
        public unsafe System.Numerics.Vector3 ExtraVectorInfo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// FloatProperty: ExtraFloatInfo
        /// </summary>
        public unsafe float ExtraFloatInfo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 96); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }; }
        }
    }

    /// <summary>
    /// Enum: EPlayerLandMoves
    /// </summary>
    public enum EPlayerLandMoves
    {
        PLM_StraightLand = 0,
        PLM_JumpLandToRun = 1,
        PLM_JumpLandToStand = 2,
        PLM_StraightLandToRun = 3,
        PLM_JumpLandOnSpot = 4,
        PLM_VeryFastFallLand = 5,
        PLM_PlayerLandMovesMAX = 6,
        PLM_MAX = 7,
    }

    /// <summary>
    /// Enum: EBatmanGadgetList
    /// </summary>
    public enum EBatmanGadgetList
    {
        BGL_Batarang = 0,
        BGL_RCBatarang = 1,
        BGL_MultiBatarang = 2,
        BGL_SonicBatarang = 3,
        BGL_BatClaw = 4,
        BGL_ExplosiveGel = 5,
        BGL_LineLauncher = 6,
        BGL_Resonator = 7,
        BGL_MagneticBlast = 8,
        BGL_FreezeBlast = 9,
        BGL_SmokeBomb = 10,
        BGL_FreezeGunJammer = 11,
        BGL_JammerGadget = 12,
        BGL_FreezeClusterGrenade = 13,
        BGL_MAX = 14,
    }

    /// <summary>
    /// Enum: EnvironmentAnimationDirection
    /// </summary>
    public enum EnvironmentAnimationDirection
    {
        EAD_DoesntMatter = 0,
        EAD_Left = 1,
        EAD_Right = 2,
        EAD_MAX = 3,
    }

    /// <summary>
    /// Enum: EnvironmentFeelerState
    /// </summary>
    public enum EnvironmentFeelerState
    {
        EFS_Walking = 0,
        EFS_InCover = 1,
        EFS_Gliding = 2,
        EFS_Shimmy = 3,
        EFS_ShimmyClimbOnly = 4,
        EFS_Falling = 5,
        EFS_CombatFeelers = 6,
        EFS_CinematicMode = 7,
        EFS_RailingClimbDown = 8,
        EFS_NoFeelers = 9,
        EFS_MAX = 10,
    }

    /// <summary>
    /// Struct: FMovementControllerHistory
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FMovementControllerHistory
    {
        /// <summary>
        /// StructProperty: Direction
        /// </summary>
        public unsafe System.Numerics.Vector3 Direction
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: InputSpeed
        /// </summary>
        public unsafe float InputSpeed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: Time
        /// </summary>
        public unsafe float Time
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FEnvironmentSpecialMoveTypesContainer
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FEnvironmentSpecialMoveTypesContainer
    {
        /// <summary>
        /// BoolProperty: ReservedNone
        /// </summary>
        public unsafe bool ReservedNone
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: LowBarrier
        /// </summary>
        public unsafe bool LowBarrier
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: MediumBarrier
        /// </summary>
        public unsafe bool MediumBarrier
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: HighBarrier
        /// </summary>
        public unsafe bool HighBarrier
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: LowWall
        /// </summary>
        public unsafe bool LowWall
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 16) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: MediumWall
        /// </summary>
        public unsafe bool MediumWall
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 32) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: HighWall
        /// </summary>
        public unsafe bool HighWall
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 64) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: UnscalableWall
        /// </summary>
        public unsafe bool UnscalableWall
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 128) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Floor
        /// </summary>
        public unsafe bool Floor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 256) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: JumpGap512
        /// </summary>
        public unsafe bool JumpGap512
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 512) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Edge
        /// </summary>
        public unsafe bool Edge
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1024) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: JumpGap256
        /// </summary>
        public unsafe bool JumpGap256
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 2048) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: JumpGap384
        /// </summary>
        public unsafe bool JumpGap384
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 4096) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: GapNoHeadRoom
        /// </summary>
        public unsafe bool GapNoHeadRoom
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 8192) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: ShimmyLedge
        /// </summary>
        public unsafe bool ShimmyLedge
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 16384) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: DangleLedge
        /// </summary>
        public unsafe bool DangleLedge
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 32768) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: DangleLedgeWithRailing
        /// </summary>
        public unsafe bool DangleLedgeWithRailing
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 65536) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: CoverCorner
        /// </summary>
        public unsafe bool CoverCorner
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 131072) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: ShimmyLedgeWithRailing
        /// </summary>
        public unsafe bool ShimmyLedgeWithRailing
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 262144) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: LowWallWithRailing
        /// </summary>
        public unsafe bool LowWallWithRailing
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 524288) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: MediumWallWithRailing
        /// </summary>
        public unsafe bool MediumWallWithRailing
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1048576) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: HighWallWithRailing
        /// </summary>
        public unsafe bool HighWallWithRailing
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 2097152) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: LowBarrierWithDrop
        /// </summary>
        public unsafe bool LowBarrierWithDrop
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 4194304) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: MediumBarrierWithDrop
        /// </summary>
        public unsafe bool MediumBarrierWithDrop
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 8388608) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: HighBarrierWithDrop
        /// </summary>
        public unsafe bool HighBarrierWithDrop
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 16777216) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: LowRailingWithDrop
        /// </summary>
        public unsafe bool LowRailingWithDrop
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 33554432) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: ShimmyCrevice
        /// </summary>
        public unsafe bool ShimmyCrevice
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 67108864) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: DangleCrevice
        /// </summary>
        public unsafe bool DangleCrevice
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 134217728) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: CoverCornerLeft
        /// </summary>
        public unsafe bool CoverCornerLeft
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 268435456) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: JumpGap512NoShimmy
        /// </summary>
        public unsafe bool JumpGap512NoShimmy
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 536870912) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: EdgeNoShimmy
        /// </summary>
        public unsafe bool EdgeNoShimmy
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1073741824) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: JumpGap256NoShimmy
        /// </summary>
        public unsafe bool JumpGap256NoShimmy
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & -2147483648) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: JumpGap384NoShimmy
        /// </summary>
        public unsafe bool JumpGap384NoShimmy
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: JumpGap256ToRailing
        /// </summary>
        public unsafe bool JumpGap256ToRailing
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: JumpGap256ToRailingNoShimmy
        /// </summary>
        public unsafe bool JumpGap256ToRailingNoShimmy
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: ShimmyHangRailing
        /// </summary>
        public unsafe bool ShimmyHangRailing
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: ShimmyDangleRailing
        /// </summary>
        public unsafe bool ShimmyDangleRailing
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 16) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: MediumWallWithRailingNoShimmy
        /// </summary>
        public unsafe bool MediumWallWithRailingNoShimmy
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 32) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: LowBarrierNoVault
        /// </summary>
        public unsafe bool LowBarrierNoVault
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 64) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: MediumBarrierNoVault
        /// </summary>
        public unsafe bool MediumBarrierNoVault
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 128) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: HighBarrierNoVault
        /// </summary>
        public unsafe bool HighBarrierNoVault
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 256) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: ScrambleToShimmy
        /// </summary>
        public unsafe bool ScrambleToShimmy
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 512) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Enum: EHangLedgeType
    /// </summary>
    public enum EHangLedgeType
    {
        HLT_Braced = 0,
        HLT_Dangle = 1,
        HLT_DangleNoRoomToSwing = 2,
        HLT_MAX = 3,
    }

    /// <summary>
    /// Enum: EnvironmentSpecialMoveTypes
    /// </summary>
    public enum EnvironmentSpecialMoveTypes
    {
        ESMT_None = 0,
        ESMT_LowBarrier = 1,
        ESMT_MediumBarrier = 2,
        ESMT_HighBarrier = 3,
        ESMT_LowWall = 4,
        ESMT_MediumWall = 5,
        ESMT_HighWall = 6,
        ESMT_UnscalableWall = 7,
        ESMT_Floor = 8,
        ESMT_JumpGap512 = 9,
        ESMT_Edge = 10,
        ESMT_JumpGap256 = 11,
        ESMT_JumpGap384 = 12,
        ESMT_GapNoHeadRoom = 13,
        ESMT_ShimmyLedge = 14,
        ESMT_DangleLedge = 15,
        ESMT_DangleLedgeWithRailing = 16,
        ESMT_CoverCorner = 17,
        ESMT_ShimmyLedgeWithRailing = 18,
        ESMT_LowWallWithRailing = 19,
        ESMT_MediumWallWithRailing = 20,
        ESMT_HighWallWithRailing = 21,
        ESMT_LowBarrierWithDrop = 22,
        ESMT_MediumBarrierWithDrop = 23,
        ESMT_HighBarrierWithDrop = 24,
        ESMT_LowRailingWithDrop = 25,
        ESMT_ShimmyCrevice = 26,
        ESMT_DangleCrevice = 27,
        ESMT_CoverCornerLeft = 28,
        ESMT_JumpGap512NoShimmy = 29,
        ESMT_EdgeNoShimmy = 30,
        ESMT_JumpGap256NoShimmy = 31,
        ESMT_JumpGap384NoShimmy = 32,
        ESMT_JumpGap256ToRailing = 33,
        ESMT_JumpGap256ToRailingNoShimmy = 34,
        ESMT_ShimmyHangRailing = 35,
        ESMT_ShimmyDangleRailing = 36,
        ESMT_MediumWallWithRailingNoShimmy = 37,
        ESMT_LowBarrierNoVault = 38,
        ESMT_MediumBarrierNoVault = 39,
        ESMT_HighBarrierNoVault = 40,
        ESMT_ScrambleToShimmy = 41,
        ESMT_RailingEnd128 = 42,
        ESMT_Actor = 43,
        ESMT_MAX = 44,
    }

    /// <summary>
    /// StructProperty: VfTable_IRSpotableInterface
    /// </summary>
    public unsafe System.IntPtr VfTable_IRSpotableInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2432); }
    }

    /// <summary>
    /// ObjectProperty: V2AttackCoord
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_Attack_Base V2AttackCoord
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_Attack_Base>(Ptr + 2436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2436); }
    }

    /// <summary>
    /// ObjectProperty: MostRecentThugToSeePlayer
    /// </summary>
    public unsafe BmSDK.BmGame.RBMAIController MostRecentThugToSeePlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIController>(Ptr + 2440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2440); }
    }

    /// <summary>
    /// StructProperty: LastSeenPos
    /// </summary>
    public unsafe System.Numerics.Vector3 LastSeenPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2444); }
    }

    /// <summary>
    /// FloatProperty: LastSeenTime
    /// </summary>
    public unsafe float LastSeenTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2456); }
    }

    /// <summary>
    /// BoolProperty: bWasOnRailing
    /// </summary>
    public unsafe bool bWasOnRailing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2460); }
    }

    /// <summary>
    /// BoolProperty: bWasUsingVantage
    /// </summary>
    public unsafe bool bWasUsingVantage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2460); }
    }

    /// <summary>
    /// BoolProperty: bWasVantageInverted
    /// </summary>
    public unsafe bool bWasVantageInverted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2460); }
    }

    /// <summary>
    /// BoolProperty: bWasDoingSpecialMovePredictable
    /// </summary>
    public unsafe bool bWasDoingSpecialMovePredictable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2460); }
    }

    /// <summary>
    /// BoolProperty: bWasInAir
    /// </summary>
    public unsafe bool bWasInAir
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2460); }
    }

    /// <summary>
    /// BoolProperty: bWasDangling
    /// </summary>
    public unsafe bool bWasDangling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2460); }
    }

    /// <summary>
    /// BoolProperty: bCheatTrackBMInVent
    /// </summary>
    public unsafe bool bCheatTrackBMInVent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2460); }
    }

    /// <summary>
    /// BoolProperty: bWasOnCeiling
    /// </summary>
    public unsafe bool bWasOnCeiling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2460); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreNavMeshForAvoidance
    /// </summary>
    public unsafe bool bIgnoreNavMeshForAvoidance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2460); }
    }

    /// <summary>
    /// BoolProperty: bWalkingOnWire
    /// </summary>
    public unsafe bool bWalkingOnWire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2460); }
    }

    /// <summary>
    /// BoolProperty: bCanUseRailings
    /// </summary>
    public unsafe bool bCanUseRailings
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2460); }
    }

    /// <summary>
    /// BoolProperty: bCanUseSwingKick
    /// </summary>
    public unsafe bool bCanUseSwingKick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2460); }
    }

    /// <summary>
    /// BoolProperty: bCanUseVantageGrappling
    /// </summary>
    public unsafe bool bCanUseVantageGrappling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2460); }
    }

    /// <summary>
    /// BoolProperty: bCanDoAbove384Takedowns
    /// </summary>
    public unsafe bool bCanDoAbove384Takedowns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2460); }
    }

    /// <summary>
    /// BoolProperty: bCanDoDoubleStealthAttacks
    /// </summary>
    public unsafe bool bCanDoDoubleStealthAttacks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2460); }
    }

    /// <summary>
    /// BoolProperty: bCanHangFromVantagePoint
    /// </summary>
    public unsafe bool bCanHangFromVantagePoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2460); }
    }

    /// <summary>
    /// BoolProperty: bCanInterrogate
    /// </summary>
    public unsafe bool bCanInterrogate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2460); }
    }

    /// <summary>
    /// BoolProperty: bAllowBackScreen
    /// </summary>
    public unsafe bool bAllowBackScreen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2460); }
    }

    /// <summary>
    /// BoolProperty: bCanRemoveGrates
    /// </summary>
    public unsafe bool bCanRemoveGrates
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2460); }
    }

    /// <summary>
    /// BoolProperty: DisableTaunts
    /// </summary>
    public unsafe bool DisableTaunts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2460); }
    }

    /// <summary>
    /// BoolProperty: CanUseSuperComboGadgets
    /// </summary>
    public unsafe bool CanUseSuperComboGadgets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2460); }
    }

    /// <summary>
    /// BoolProperty: bReplenishHealth
    /// </summary>
    public unsafe bool bReplenishHealth
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2460); }
    }

    /// <summary>
    /// BoolProperty: DeferedVelocitySet
    /// </summary>
    public unsafe bool DeferedVelocitySet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2460); }
    }

    /// <summary>
    /// BoolProperty: IsGrappling
    /// </summary>
    public unsafe bool IsGrappling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2460); }
    }

    /// <summary>
    /// BoolProperty: bGliding
    /// </summary>
    public unsafe bool bGliding
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2460); }
    }

    /// <summary>
    /// BoolProperty: IsLineLaunching
    /// </summary>
    public unsafe bool IsLineLaunching
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2460); }
    }

    /// <summary>
    /// BoolProperty: CanPerchOnVantagePoints
    /// </summary>
    public unsafe bool CanPerchOnVantagePoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2460); }
    }

    /// <summary>
    /// BoolProperty: IsSlidingUnderVolume
    /// </summary>
    public unsafe bool IsSlidingUnderVolume
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2460); }
    }

    /// <summary>
    /// BoolProperty: bCanClimb
    /// </summary>
    public unsafe bool bCanClimb
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2460); }
    }

    /// <summary>
    /// BoolProperty: bCanCapeGlide
    /// </summary>
    public unsafe bool bCanCapeGlide
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2460); }
    }

    /// <summary>
    /// BoolProperty: bCanGrappleBoost
    /// </summary>
    public unsafe bool bCanGrappleBoost
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2460); }
    }

    /// <summary>
    /// BoolProperty: bCapeGlideDisabledByIce
    /// </summary>
    public unsafe bool bCapeGlideDisabledByIce
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2460); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2460); }
    }

    /// <summary>
    /// BoolProperty: bCanDiveBoost
    /// </summary>
    public unsafe bool bCanDiveBoost
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2464); }
    }

    /// <summary>
    /// BoolProperty: bCantDropOffLedges
    /// </summary>
    public unsafe bool bCantDropOffLedges
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2464); }
    }

    /// <summary>
    /// BoolProperty: bDisableAllTakedowns
    /// </summary>
    public unsafe bool bDisableAllTakedowns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2464); }
    }

    /// <summary>
    /// BoolProperty: bDisableDoubleTakedownOnInformants
    /// </summary>
    public unsafe bool bDisableDoubleTakedownOnInformants
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2464); }
    }

    /// <summary>
    /// BoolProperty: bSimulateLastThugIsInformant
    /// </summary>
    public unsafe bool bSimulateLastThugIsInformant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2464); }
    }

    /// <summary>
    /// BoolProperty: bCanPounceOnThugs
    /// </summary>
    public unsafe bool bCanPounceOnThugs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2464); }
    }

    /// <summary>
    /// BoolProperty: bCanPickPocket
    /// </summary>
    public unsafe bool bCanPickPocket
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2464); }
    }

    /// <summary>
    /// BoolProperty: bExitStealthOnGlide
    /// </summary>
    public unsafe bool bExitStealthOnGlide
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2464); }
    }

    /// <summary>
    /// BoolProperty: bThugsHaveCommentedOnGrapple
    /// </summary>
    public unsafe bool bThugsHaveCommentedOnGrapple
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2464); }
    }

    /// <summary>
    /// BoolProperty: StandingOffEdge
    /// </summary>
    public unsafe bool StandingOffEdge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2464); }
    }

    /// <summary>
    /// BoolProperty: GoingToHangFromVantagePoint
    /// </summary>
    public unsafe bool GoingToHangFromVantagePoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2464); }
    }

    /// <summary>
    /// BoolProperty: ClimbingBackToVantagePoint
    /// </summary>
    public unsafe bool ClimbingBackToVantagePoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2464); }
    }

    /// <summary>
    /// BoolProperty: CheckingToDiveThroughWindows
    /// </summary>
    public unsafe bool CheckingToDiveThroughWindows
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2464); }
    }

    /// <summary>
    /// BoolProperty: CheckingSwingFloor
    /// </summary>
    public unsafe bool CheckingSwingFloor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2464); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysTrackForDamage
    /// </summary>
    public unsafe bool bAlwaysTrackForDamage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2464); }
    }

    /// <summary>
    /// BoolProperty: GrapplingToVantagePoint
    /// </summary>
    public unsafe bool GrapplingToVantagePoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2464); }
    }

    /// <summary>
    /// BoolProperty: bAllowZoom
    /// </summary>
    public unsafe bool bAllowZoom
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2464); }
    }

    /// <summary>
    /// BoolProperty: bCanUseSurv
    /// </summary>
    public unsafe bool bCanUseSurv
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2464); }
    }

    /// <summary>
    /// BoolProperty: bEnableGrateExcluders
    /// </summary>
    public unsafe bool bEnableGrateExcluders
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2464); }
    }

    /// <summary>
    /// BoolProperty: bGB3HostagesKilled
    /// </summary>
    public unsafe bool bGB3HostagesKilled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2464); }
    }

    /// <summary>
    /// BoolProperty: bDoingAutonmousMovement
    /// </summary>
    public unsafe bool bDoingAutonmousMovement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2464); }
    }

    /// <summary>
    /// BoolProperty: ShouldCrouchForReplication
    /// </summary>
    public unsafe bool ShouldCrouchForReplication
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2464); }
    }

    /// <summary>
    /// BoolProperty: bHasJustMovedOntoGargoyle
    /// </summary>
    public unsafe bool bHasJustMovedOntoGargoyle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2464); }
    }

    /// <summary>
    /// BoolProperty: bCanAvoidMines
    /// </summary>
    public unsafe bool bCanAvoidMines
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2464); }
    }

    /// <summary>
    /// BoolProperty: DoingUnderBarrierCheck
    /// </summary>
    public unsafe bool DoingUnderBarrierCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2464); }
    }

    /// <summary>
    /// BoolProperty: bThoughtsShowAnimNames
    /// </summary>
    public unsafe bool bThoughtsShowAnimNames
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2464); }
    }

    /// <summary>
    /// BoolProperty: bThoughtsShowBlendedAnimDetails
    /// </summary>
    public unsafe bool bThoughtsShowBlendedAnimDetails
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2464); }
    }

    /// <summary>
    /// BoolProperty: bCheckNonBlockingCombatPawns
    /// </summary>
    public unsafe bool bCheckNonBlockingCombatPawns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2464); }
    }

    /// <summary>
    /// BoolProperty: bPawnCanGrateCrawl
    /// </summary>
    public unsafe bool bPawnCanGrateCrawl
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2464); }
    }

    /// <summary>
    /// BoolProperty: bCanClimbToCeilingLedge
    /// </summary>
    public unsafe bool bCanClimbToCeilingLedge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2464); }
    }

    /// <summary>
    /// BoolProperty: bCanClimbToCeilingFar
    /// </summary>
    public unsafe bool bCanClimbToCeilingFar
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2464); }
    }

    /// <summary>
    /// BoolProperty: bCanClimbToCatwalkFar
    /// </summary>
    public unsafe bool bCanClimbToCatwalkFar
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2464); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2464); }
    }

    /// <summary>
    /// BoolProperty: bCanPounceToCeiling
    /// </summary>
    public unsafe bool bCanPounceToCeiling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2468) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2468); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2468); }
    }

    /// <summary>
    /// BoolProperty: bJumpedThisFrame
    /// </summary>
    public unsafe bool bJumpedThisFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2468) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2468); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2468); }
    }

    /// <summary>
    /// BoolProperty: bPlayerIconPSActive
    /// </summary>
    public unsafe bool bPlayerIconPSActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2468) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2468); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2468); }
    }

    /// <summary>
    /// BoolProperty: bDebugObstacleAvoidance
    /// </summary>
    public unsafe bool bDebugObstacleAvoidance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2468) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2468); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2468); }
    }

    /// <summary>
    /// BoolProperty: bDebugNewCeilingMoves
    /// </summary>
    public unsafe bool bDebugNewCeilingMoves
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2468) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2468); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2468); }
    }

    /// <summary>
    /// BoolProperty: bDebugGrateMoves
    /// </summary>
    public unsafe bool bDebugGrateMoves
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2468) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2468); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2468); }
    }

    /// <summary>
    /// BoolProperty: bJumpFromWhipSwing
    /// </summary>
    public unsafe bool bJumpFromWhipSwing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2468) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2468); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2468); }
    }

    /// <summary>
    /// BoolProperty: bAddedDefaultInventoryAfterInit
    /// </summary>
    public unsafe bool bAddedDefaultInventoryAfterInit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2468) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2468); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2468); }
    }

    /// <summary>
    /// BoolProperty: bDebugForceCriticalLand
    /// </summary>
    public unsafe bool bDebugForceCriticalLand
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2468) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2468); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2468); }
    }

    /// <summary>
    /// BoolProperty: bDebugShowLandRollCheck
    /// </summary>
    public unsafe bool bDebugShowLandRollCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2468) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2468); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2468); }
    }

    /// <summary>
    /// BoolProperty: bSilentRunning
    /// </summary>
    public unsafe bool bSilentRunning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2468) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2468); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2468); }
    }

    /// <summary>
    /// BoolProperty: bGrappleWake
    /// </summary>
    public unsafe bool bGrappleWake
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2468) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2468); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2468); }
    }

    /// <summary>
    /// BoolProperty: bGrappleWakeEmitter
    /// </summary>
    public unsafe bool bGrappleWakeEmitter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2468) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2468); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2468); }
    }

    /// <summary>
    /// BoolProperty: DelayUnderWaterCheck
    /// </summary>
    public unsafe bool DelayUnderWaterCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2468) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2468); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2468); }
    }

    /// <summary>
    /// BoolProperty: bDebugInterrogationDetection
    /// </summary>
    public unsafe bool bDebugInterrogationDetection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2468) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2468); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2468); }
    }

    /// <summary>
    /// BoolProperty: bInterrogationIgnoreIsSafeCheck
    /// </summary>
    public unsafe bool bInterrogationIgnoreIsSafeCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2468) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2468); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2468); }
    }

    /// <summary>
    /// BoolProperty: bDrawRelativeAnimRefPoint
    /// </summary>
    public unsafe bool bDrawRelativeAnimRefPoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2468) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2468); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2468); }
    }

    /// <summary>
    /// BoolProperty: bSimulateInterrogationMovesNotLoaded
    /// </summary>
    public unsafe bool bSimulateInterrogationMovesNotLoaded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2468) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2468); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2468); }
    }

    /// <summary>
    /// BoolProperty: bHealthModifierActive
    /// </summary>
    public unsafe bool bHealthModifierActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2468) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2468); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2468); }
    }

    /// <summary>
    /// BoolProperty: WasDamageProxyActive
    /// </summary>
    public unsafe bool WasDamageProxyActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2468) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2468); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2468); }
    }

    /// <summary>
    /// StructProperty: WasOnRailingPointA
    /// </summary>
    public unsafe System.Numerics.Vector3 WasOnRailingPointA
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2472); }
    }

    /// <summary>
    /// StructProperty: WasOnRailingPointB
    /// </summary>
    public unsafe System.Numerics.Vector3 WasOnRailingPointB
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2484); }
    }

    /// <summary>
    /// ObjectProperty: LastSeenVantage
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint LastSeenVantage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 2496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2496); }
    }

    /// <summary>
    /// StructProperty: CachedLedgeRefPoint
    /// </summary>
    public unsafe System.Numerics.Vector3 CachedLedgeRefPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2500); }
    }

    /// <summary>
    /// StructProperty: CachedLedgeRefDir
    /// </summary>
    public unsafe System.Numerics.Vector3 CachedLedgeRefDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2512); }
    }

    /// <summary>
    /// StructProperty: AggressiveLandLoc
    /// </summary>
    public unsafe System.Numerics.Vector3 AggressiveLandLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2524); }
    }

    /// <summary>
    /// ByteProperty: BarkAvailable
    /// </summary>
    public unsafe BmSDK.BmGame.RBMAIController.BarkType BarkAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIController.BarkType>(Ptr + 2536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2536); }
    }

    /// <summary>
    /// ByteProperty: FeelerState
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.EnvironmentFeelerState FeelerState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.EnvironmentFeelerState>(Ptr + 2537); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2537); }
    }

    /// <summary>
    /// ByteProperty: MovementSpeed
    /// </summary>
    public unsafe BmSDK.BmGame.RPoseConfig.EMovementSpeed MovementSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig.EMovementSpeed>(Ptr + 2538); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2538); }
    }

    /// <summary>
    /// ByteProperty: CurrentPoseType
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.EBatmanPoseType CurrentPoseType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.EBatmanPoseType>(Ptr + 2539); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2539); }
    }

    /// <summary>
    /// ByteProperty: UpAllowSubClasses
    /// </summary>
    public unsafe byte UpAllowSubClasses
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2540); }
    }

    /// <summary>
    /// ByteProperty: DownAllowSubClasses
    /// </summary>
    public unsafe byte DownAllowSubClasses
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2548); }
    }

    /// <summary>
    /// ByteProperty: CurrentPerchDir
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.PerchDirection CurrentPerchDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.PerchDirection>(Ptr + 2553); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2553); }
    }

    /// <summary>
    /// FloatProperty: CapeGlideGravity
    /// </summary>
    public unsafe float CapeGlideGravity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2556); }
    }

    /// <summary>
    /// ObjectProperty: XrayMaskMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface XrayMaskMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2560); }
    }

    /// <summary>
    /// ObjectProperty: XrayMaskMaterialCape
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface XrayMaskMaterialCape
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2564); }
    }

    /// <summary>
    /// ComponentProperty: XrayMaskBodyMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent XrayMaskBodyMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 2568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2568); }
    }

    /// <summary>
    /// ComponentProperty: XrayMaskHeadMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent XrayMaskHeadMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 2572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2572); }
    }

    /// <summary>
    /// ComponentProperty: XrayMaskCapeMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent XrayMaskCapeMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 2576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2576); }
    }

    /// <summary>
    /// ArrayProperty: SnowMaterials
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant> SnowMaterials
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant>>(Ptr + 2580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2580); }
    }

    /// <summary>
    /// NameProperty: SnowParameterName
    /// </summary>
    public unsafe BmSDK.FName SnowParameterName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2592); }
    }

    /// <summary>
    /// StructProperty: GrappleLoopSoundHandle
    /// </summary>
    public unsafe BmSDK.Engine.AkWwise.FAkSoundHandle GrappleLoopSoundHandle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkWwise.FAkSoundHandle>(Ptr + 2600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2600); }
    }

    /// <summary>
    /// FloatProperty: PlayerWalkSpeed
    /// </summary>
    public unsafe float PlayerWalkSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2612); }
    }

    /// <summary>
    /// FloatProperty: PlayerRunSpeed
    /// </summary>
    public unsafe float PlayerRunSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2616); }
    }

    /// <summary>
    /// FloatProperty: PlayerStealthSpeed
    /// </summary>
    public unsafe float PlayerStealthSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2620); }
    }

    /// <summary>
    /// FloatProperty: PlayerGlideSpeed
    /// </summary>
    public unsafe float PlayerGlideSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2624); }
    }

    /// <summary>
    /// FloatProperty: PlayerChargeStrikeSpeedModifier
    /// </summary>
    public unsafe float PlayerChargeStrikeSpeedModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2628); }
    }

    /// <summary>
    /// ObjectProperty: GrappleGun
    /// </summary>
    public unsafe BmSDK.BmGame.RGrappleGun GrappleGun
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrappleGun>(Ptr + 2632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2632); }
    }

    /// <summary>
    /// ObjectProperty: HarpoonGun
    /// </summary>
    public unsafe BmSDK.BmGame.RHarpoonGun HarpoonGun
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHarpoonGun>(Ptr + 2636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2636); }
    }

    /// <summary>
    /// ObjectProperty: ResonatorTuner
    /// </summary>
    public unsafe BmSDK.BmGame.RResonatorTuner ResonatorTuner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RResonatorTuner>(Ptr + 2640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2640); }
    }

    /// <summary>
    /// ObjectProperty: LineLauncher
    /// </summary>
    public unsafe BmSDK.BmGame.RLineLauncher LineLauncher
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLineLauncher>(Ptr + 2644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2644); }
    }

    /// <summary>
    /// ObjectProperty: Batarang
    /// </summary>
    public unsafe BmSDK.BmGame.RBatarang Batarang
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBatarang>(Ptr + 2648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2648); }
    }

    /// <summary>
    /// ObjectProperty: GooSpray
    /// </summary>
    public unsafe BmSDK.BmGame.RGooSpray GooSpray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGooSpray>(Ptr + 2652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2652); }
    }

    /// <summary>
    /// ObjectProperty: MagneticBlast
    /// </summary>
    public unsafe BmSDK.BmGame.RMagneticBlast MagneticBlast
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagneticBlast>(Ptr + 2656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2656); }
    }

    /// <summary>
    /// ObjectProperty: FreezeSpray
    /// </summary>
    public unsafe BmSDK.BmGame.RFreezeSpray FreezeSpray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RFreezeSpray>(Ptr + 2660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2660); }
    }

    /// <summary>
    /// ObjectProperty: FreezeClusterGrenade
    /// </summary>
    public unsafe BmSDK.BmGame.RFreezeClusterGrenade FreezeClusterGrenade
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RFreezeClusterGrenade>(Ptr + 2664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2664); }
    }

    /// <summary>
    /// ObjectProperty: FreezeJammer
    /// </summary>
    public unsafe BmSDK.BmGame.RFreezeGunJammer FreezeJammer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RFreezeGunJammer>(Ptr + 2668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2668); }
    }

    /// <summary>
    /// ObjectProperty: JammerGadget
    /// </summary>
    public unsafe BmSDK.BmGame.RJammerGadget JammerGadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RJammerGadget>(Ptr + 2672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2672); }
    }

    /// <summary>
    /// ObjectProperty: Caltrops
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectileGadgetBase Caltrops
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectileGadgetBase>(Ptr + 2676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2676); }
    }

    /// <summary>
    /// ObjectProperty: Whip
    /// </summary>
    public unsafe BmSDK.BmGame.RWhipBase Whip
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWhipBase>(Ptr + 2680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2680); }
    }

    /// <summary>
    /// ObjectProperty: Staff
    /// </summary>
    public unsafe BmSDK.BmGame.RStaffBase Staff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStaffBase>(Ptr + 2684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2684); }
    }

    /// <summary>
    /// ObjectProperty: Sticks
    /// </summary>
    public unsafe BmSDK.BmGame.RSticksGadgetBase Sticks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSticksGadgetBase>(Ptr + 2688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2688); }
    }

    /// <summary>
    /// ObjectProperty: BlowDart
    /// </summary>
    public unsafe BmSDK.BmGame.RBlowDartBase BlowDart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBlowDartBase>(Ptr + 2692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2692); }
    }

    /// <summary>
    /// ObjectProperty: RCBatarang
    /// </summary>
    public unsafe BmSDK.BmGame.RBatarang RCBatarang
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBatarang>(Ptr + 2696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2696); }
    }

    /// <summary>
    /// ObjectProperty: SonicBatarang
    /// </summary>
    public unsafe BmSDK.BmGame.RBatarang SonicBatarang
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBatarang>(Ptr + 2700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2700); }
    }

    /// <summary>
    /// ArrayProperty: IceRafts
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RFloatingRaft> IceRafts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RFloatingRaft>>(Ptr + 2704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2704); }
    }

    /// <summary>
    /// FloatProperty: MaxIceRafts
    /// </summary>
    public unsafe float MaxIceRafts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2716); }
    }

    /// <summary>
    /// FloatProperty: GrappleSpeed
    /// </summary>
    public unsafe float GrappleSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2720); }
    }

    /// <summary>
    /// FloatProperty: MaxGrappleSpeed
    /// </summary>
    public unsafe float MaxGrappleSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2724); }
    }

    /// <summary>
    /// FloatProperty: MinGrappleSpeed
    /// </summary>
    public unsafe float MinGrappleSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2728); }
    }

    /// <summary>
    /// FloatProperty: MinGrappleSpeedDist
    /// </summary>
    public unsafe float MinGrappleSpeedDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2732); }
    }

    /// <summary>
    /// FloatProperty: MaxGrappleSpeedDist
    /// </summary>
    public unsafe float MaxGrappleSpeedDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2736); }
    }

    /// <summary>
    /// FloatProperty: GrappleDampingCoeff
    /// </summary>
    public unsafe float GrappleDampingCoeff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2740); }
    }

    /// <summary>
    /// FloatProperty: GrappleBoostFactor
    /// </summary>
    public unsafe float GrappleBoostFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2744); }
    }

    /// <summary>
    /// ArrayProperty: HealthUpgrades
    /// </summary>
    public unsafe BmSDK.TArray<int> HealthUpgrades
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2748); }
    }

    /// <summary>
    /// ArrayProperty: MeleeArmourUpgrades
    /// </summary>
    public unsafe BmSDK.TArray<int> MeleeArmourUpgrades
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2760); }
    }

    /// <summary>
    /// ArrayProperty: BallisticArmourUpgrades
    /// </summary>
    public unsafe BmSDK.TArray<int> BallisticArmourUpgrades
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2772); }
    }

    /// <summary>
    /// ArrayProperty: CurrentArmourLevels
    /// </summary>
    public unsafe BmSDK.TArray<int> CurrentArmourLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2784); }
    }

    /// <summary>
    /// ArrayProperty: CurrentArmourMaxima
    /// </summary>
    public unsafe BmSDK.TArray<int> CurrentArmourMaxima
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2796); }
    }

    /// <summary>
    /// FloatProperty: ReplenishRate
    /// </summary>
    public unsafe float ReplenishRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2808); }
    }

    /// <summary>
    /// FloatProperty: TimeBeforeReplenish
    /// </summary>
    public unsafe float TimeBeforeReplenish
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2812); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceDamage
    /// </summary>
    public unsafe float TimeSinceDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2816); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceReplenish
    /// </summary>
    public unsafe float TimeSinceReplenish
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2820); }
    }

    /// <summary>
    /// StructProperty: FrontBarrier
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator FrontBarrier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(Ptr + 2824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2824); }
    }

    /// <summary>
    /// StructProperty: UnderBarrier
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator UnderBarrier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(Ptr + 2936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2936); }
    }

    /// <summary>
    /// StructProperty: UpperBarrier
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator UpperBarrier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(Ptr + 3048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3048); }
    }

    /// <summary>
    /// StructProperty: LeftFeature
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator LeftFeature
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(Ptr + 3160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3160); }
    }

    /// <summary>
    /// StructProperty: RightFeature
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator RightFeature
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(Ptr + 3272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3272); }
    }

    /// <summary>
    /// StructProperty: UnderEdgeColl
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.FPlayerEdgeColl UnderEdgeColl
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FPlayerEdgeColl>(Ptr + 3384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3384); }
    }

    /// <summary>
    /// StructProperty: ShimmyEdgeColl
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.FPlayerEdgeColl ShimmyEdgeColl
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FPlayerEdgeColl>(Ptr + 3396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3396); }
    }

    /// <summary>
    /// StructProperty: CurrentRailing
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.FRailingInfo CurrentRailing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FRailingInfo>(Ptr + 3408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3408); }
    }

    /// <summary>
    /// StructProperty: SecondRailing
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.FRailingInfo SecondRailing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FRailingInfo>(Ptr + 3432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3432); }
    }

    /// <summary>
    /// ObjectProperty: LandMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig LandMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3456); }
    }

    /// <summary>
    /// ObjectProperty: RailingLandMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig RailingLandMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3480); }
    }

    /// <summary>
    /// ObjectProperty: RailingLandWalkMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig RailingLandWalkMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3484); }
    }

    /// <summary>
    /// ObjectProperty: DeepFallLandSuccess
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DeepFallLandSuccess
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3488); }
    }

    /// <summary>
    /// ObjectProperty: DeepFallLandRunSuccess
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DeepFallLandRunSuccess
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3492); }
    }

    /// <summary>
    /// ObjectProperty: DeepFallRailingLandSuccess
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DeepFallRailingLandSuccess
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3496); }
    }

    /// <summary>
    /// ObjectProperty: DeepFallRailingWalkLandSuccess
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DeepFallRailingWalkLandSuccess
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3500); }
    }

    /// <summary>
    /// ObjectProperty: CornerSlipMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CornerSlipMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3504); }
    }

    /// <summary>
    /// ObjectProperty: CornerSlipCrouchMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CornerSlipCrouchMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3508); }
    }

    /// <summary>
    /// FloatProperty: CriticalFallHeight
    /// </summary>
    public unsafe float CriticalFallHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3512); }
    }

    /// <summary>
    /// FloatProperty: CriticalFallHeightWarnTime
    /// </summary>
    public unsafe float CriticalFallHeightWarnTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3516); }
    }

    /// <summary>
    /// FloatProperty: MinCriticalFallSpeed
    /// </summary>
    public unsafe float MinCriticalFallSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3520); }
    }

    /// <summary>
    /// FloatProperty: MaxCriticalFallSpeed
    /// </summary>
    public unsafe float MaxCriticalFallSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3524); }
    }

    /// <summary>
    /// FloatProperty: MinCriticalFallDamage
    /// </summary>
    public unsafe float MinCriticalFallDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3528); }
    }

    /// <summary>
    /// FloatProperty: MaxCriticalFallDamage
    /// </summary>
    public unsafe float MaxCriticalFallDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3532); }
    }

    /// <summary>
    /// StructProperty: CriticalFallImpactLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 CriticalFallImpactLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3536); }
    }

    /// <summary>
    /// ObjectProperty: SwingKickMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig SwingKickMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3548); }
    }

    /// <summary>
    /// ObjectProperty: OverrideVantageSwingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig OverrideVantageSwingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3552); }
    }

    /// <summary>
    /// ObjectProperty: OverrideVantageLandMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig OverrideVantageLandMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3556); }
    }

    /// <summary>
    /// ObjectProperty: OverrideLampSwingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig OverrideLampSwingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3560); }
    }

    /// <summary>
    /// StructProperty: CoverDescription
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.FCoverDescriptor CoverDescription
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FCoverDescriptor>(Ptr + 3564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3564); }
    }

    /// <summary>
    /// StructProperty: StandMeshOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 StandMeshOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3628); }
    }

    /// <summary>
    /// StructProperty: CrouchMeshOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 CrouchMeshOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3640); }
    }

    /// <summary>
    /// ObjectProperty: PhotoScanner
    /// </summary>
    public unsafe BmSDK.BmGame.RPhotoScanner PhotoScanner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPhotoScanner>(Ptr + 3652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3652); }
    }

    /// <summary>
    /// ObjectProperty: PhysicsGrabber
    /// </summary>
    public unsafe BmSDK.BmGame.RPhysicsGrabber PhysicsGrabber
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPhysicsGrabber>(Ptr + 3656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3656); }
    }

    /// <summary>
    /// ObjectProperty: MagicSmasher
    /// </summary>
    public unsafe BmSDK.BmGame.RMagicSmasher MagicSmasher
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagicSmasher>(Ptr + 3660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3660); }
    }

    /// <summary>
    /// ObjectProperty: MagicGunStartle
    /// </summary>
    public unsafe BmSDK.BmGame.RMagicGunStartle MagicGunStartle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagicGunStartle>(Ptr + 3664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3664); }
    }

    /// <summary>
    /// FloatProperty: MaxTurnDegreesPerSecond
    /// </summary>
    public unsafe float MaxTurnDegreesPerSecond
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3668); }
    }

    /// <summary>
    /// FloatProperty: GlideTurnDegreesPerSecond
    /// </summary>
    public unsafe float GlideTurnDegreesPerSecond
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3672); }
    }

    /// <summary>
    /// FloatProperty: WalkTurnDegreesPerSecond
    /// </summary>
    public unsafe float WalkTurnDegreesPerSecond
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3676); }
    }

    /// <summary>
    /// ObjectProperty: EvidenceLog
    /// </summary>
    public unsafe BmSDK.BmGame.REvidenceLog EvidenceLog
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REvidenceLog>(Ptr + 3680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3680); }
    }

    /// <summary>
    /// FloatProperty: OverrideTime
    /// </summary>
    public unsafe float OverrideTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3684); }
    }

    /// <summary>
    /// ObjectProperty: ExplosionEffect
    /// </summary>
    public unsafe BmSDK.BmGame.RExplosionPostProcess ExplosionEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RExplosionPostProcess>(Ptr + 3688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3688); }
    }

    /// <summary>
    /// StructProperty: OverridableTransition
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId OverridableTransition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 3692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3692); }
    }

    /// <summary>
    /// StructProperty: MovementDir
    /// </summary>
    public unsafe System.Numerics.Vector3 MovementDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3696); }
    }

    /// <summary>
    /// StructProperty: PreCorrectionVelocity
    /// </summary>
    public unsafe System.Numerics.Vector3 PreCorrectionVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3708); }
    }

    /// <summary>
    /// StructProperty: GadgetTransition
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId GadgetTransition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 3720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3720); }
    }

    /// <summary>
    /// FloatProperty: LastDeltaTime
    /// </summary>
    public unsafe float LastDeltaTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3724); }
    }

    /// <summary>
    /// StructProperty: DeferedVelocity
    /// </summary>
    public unsafe System.Numerics.Vector3 DeferedVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3728); }
    }

    /// <summary>
    /// ArrayProperty: LOSCapeChecks
    /// </summary>
    public unsafe BmSDK.TArray<int> LOSCapeChecks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 3740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3740); }
    }

    /// <summary>
    /// ArrayProperty: CoverRightLOSCheckBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> CoverRightLOSCheckBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 3752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3752); }
    }

    /// <summary>
    /// ArrayProperty: CoverLeftLOSCheckBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> CoverLeftLOSCheckBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 3764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3764); }
    }

    /// <summary>
    /// ArrayProperty: HangingLOSCheckBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> HangingLOSCheckBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 3776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3776); }
    }

    /// <summary>
    /// ArrayProperty: BracedLOSCheckBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> BracedLOSCheckBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 3788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3788); }
    }

    /// <summary>
    /// ArrayProperty: HangingLOSCapeChecks
    /// </summary>
    public unsafe BmSDK.TArray<int> HangingLOSCapeChecks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 3800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3800); }
    }

    /// <summary>
    /// FloatProperty: WallStopCosAngle
    /// </summary>
    public unsafe float WallStopCosAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3812); }
    }

    /// <summary>
    /// FloatProperty: WallStopCheckRadius
    /// </summary>
    public unsafe float WallStopCheckRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3816); }
    }

    /// <summary>
    /// StructProperty: ControllerHistory
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.FMovementControllerHistory ControllerHistory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FMovementControllerHistory>(Ptr + 3820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3820); }
    }

    /// <summary>
    /// IntProperty: ControllerHistoryPosition
    /// </summary>
    public unsafe int ControllerHistoryPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4020); }
    }

    /// <summary>
    /// IntProperty: ControllerHistoryMax
    /// </summary>
    public unsafe int ControllerHistoryMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4024); }
    }

    /// <summary>
    /// InterfaceProperty: PassThroughAdjustMovementDirection
    /// </summary>
    public unsafe BmSDK.BmGame.RPassThroughAdjustMovementDirectionInterface PassThroughAdjustMovementDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPassThroughAdjustMovementDirectionInterface>(Ptr + 4028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4028); }
    }

    /// <summary>
    /// FloatProperty: MinCapeGlideTanAngle
    /// </summary>
    public unsafe float MinCapeGlideTanAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4036); }
    }

    /// <summary>
    /// FloatProperty: MaxCapeGlideTanAngle
    /// </summary>
    public unsafe float MaxCapeGlideTanAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4040); }
    }

    /// <summary>
    /// FloatProperty: MaxPounceAttackTanAngle
    /// </summary>
    public unsafe float MaxPounceAttackTanAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4044); }
    }

    /// <summary>
    /// FloatProperty: GlideAttackRange
    /// </summary>
    public unsafe float GlideAttackRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4048); }
    }

    /// <summary>
    /// FloatProperty: PounceAttackRange
    /// </summary>
    public unsafe float PounceAttackRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4052); }
    }

    /// <summary>
    /// ArrayProperty: HealthRecoverRate
    /// </summary>
    public unsafe BmSDK.TArray<float> HealthRecoverRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 4056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4056); }
    }

    /// <summary>
    /// IntProperty: MaxHealth
    /// </summary>
    public unsafe int MaxHealth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4068); }
    }

    /// <summary>
    /// IntProperty: DeathCount
    /// </summary>
    public unsafe int DeathCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4072); }
    }

    /// <summary>
    /// ArrayProperty: FrontDamageOverlays
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> FrontDamageOverlays
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 4076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4076); }
    }

    /// <summary>
    /// ArrayProperty: BackDamageOverlays
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> BackDamageOverlays
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 4088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4088); }
    }

    /// <summary>
    /// ArrayProperty: ElectricityDamageOverlays
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> ElectricityDamageOverlays
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 4100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4100); }
    }

    /// <summary>
    /// StructProperty: DamageOverlay
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId DamageOverlay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_OverlayPlayer.FOverlayId>(Ptr + 4112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4112); }
    }

    /// <summary>
    /// FloatProperty: DesiredMovementScale
    /// </summary>
    public unsafe float DesiredMovementScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4120); }
    }

    /// <summary>
    /// FloatProperty: ActualMovementScale
    /// </summary>
    public unsafe float ActualMovementScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4124); }
    }

    /// <summary>
    /// FloatProperty: MovementScaleChangeSpeed
    /// </summary>
    public unsafe float MovementScaleChangeSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4128); }
    }

    /// <summary>
    /// FloatProperty: TunnelSpeedScale
    /// </summary>
    public unsafe float TunnelSpeedScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4132); }
    }

    /// <summary>
    /// FloatProperty: FirstPersonSpeedScale
    /// </summary>
    public unsafe float FirstPersonSpeedScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4136); }
    }

    /// <summary>
    /// StructProperty: StandingOffEdgeDir
    /// </summary>
    public unsafe System.Numerics.Vector3 StandingOffEdgeDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4140); }
    }

    /// <summary>
    /// FloatProperty: ActualMovementSpeed
    /// </summary>
    public unsafe float ActualMovementSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4152); }
    }

    /// <summary>
    /// StructProperty: NetworkMoveVector
    /// </summary>
    public unsafe System.Numerics.Vector3 NetworkMoveVector
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4156); }
    }

    /// <summary>
    /// ObjectProperty: LastGadget
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget LastGadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 4168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4168); }
    }

    /// <summary>
    /// ArrayProperty: PoseIdleStances
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> PoseIdleStances
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 4172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4172); }
    }

    /// <summary>
    /// ClassProperty: AttachedGadget
    /// </summary>
    public unsafe BmSDK.Class AttachedGadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4184); }
    }

    /// <summary>
    /// ClassProperty: TakeDowns
    /// </summary>
    public unsafe BmSDK.Class TakeDowns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4188); }
    }

    /// <summary>
    /// IntProperty: ProjectileLaunchId
    /// </summary>
    public unsafe int ProjectileLaunchId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4324); }
    }

    /// <summary>
    /// ObjectProperty: ActiveTunnelFunnel
    /// </summary>
    public unsafe BmSDK.BmGame.RTunnelFunnel ActiveTunnelFunnel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTunnelFunnel>(Ptr + 4328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4328); }
    }

    /// <summary>
    /// ObjectProperty: NearestTunnelFunnel
    /// </summary>
    public unsafe BmSDK.BmGame.RTunnelFunnel NearestTunnelFunnel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTunnelFunnel>(Ptr + 4332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4332); }
    }

    /// <summary>
    /// IntProperty: LastTakedownId
    /// </summary>
    public unsafe int LastTakedownId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4336); }
    }

    /// <summary>
    /// IntProperty: LastTakedownStageAnimId
    /// </summary>
    public unsafe int LastTakedownStageAnimId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4340); }
    }

    /// <summary>
    /// FloatProperty: LastStaggerTime
    /// </summary>
    public unsafe float LastStaggerTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4344); }
    }

    /// <summary>
    /// FloatProperty: MinShotStaggerTime
    /// </summary>
    public unsafe float MinShotStaggerTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4348); }
    }

    /// <summary>
    /// IntProperty: DamageResistance
    /// </summary>
    public unsafe int DamageResistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4352); }
    }

    /// <summary>
    /// IntProperty: DamageRemainder
    /// </summary>
    public unsafe int DamageRemainder
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4356); }
    }

    /// <summary>
    /// ObjectProperty: PlayerDeathEmote
    /// </summary>
    public unsafe BmSDK.Engine.RDialogueLine PlayerDeathEmote
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4360); }
    }

    /// <summary>
    /// ObjectProperty: GrateExcluder
    /// </summary>
    public unsafe BmSDK.Engine.RB_BodyInstance GrateExcluder
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RB_BodyInstance>(Ptr + 4364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4364); }
    }

    /// <summary>
    /// ObjectProperty: LegGrateExcluder
    /// </summary>
    public unsafe BmSDK.Engine.RB_BodyInstance LegGrateExcluder
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RB_BodyInstance>(Ptr + 4368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4368); }
    }

    /// <summary>
    /// ObjectProperty: SpawnedProjectiles
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectile SpawnedProjectiles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectile>(Ptr + 4372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4372); }
    }

    /// <summary>
    /// FloatProperty: DryPct
    /// </summary>
    public unsafe float DryPct
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4396); }
    }

    /// <summary>
    /// NameProperty: DesiredPoseForReplication
    /// </summary>
    public unsafe BmSDK.FName DesiredPoseForReplication
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4400); }
    }

    /// <summary>
    /// StructProperty: AimDirectionForReplication
    /// </summary>
    public unsafe System.Numerics.Vector3 AimDirectionForReplication
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4408); }
    }

    /// <summary>
    /// IntProperty: PlayerIndex
    /// </summary>
    public unsafe int PlayerIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4420); }
    }

    /// <summary>
    /// StructProperty: FallingTarget
    /// </summary>
    public unsafe System.Numerics.Vector3 FallingTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4424); }
    }

    /// <summary>
    /// ObjectProperty: FallingTargetActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor FallingTargetActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 4436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4436); }
    }

    /// <summary>
    /// FloatProperty: BoostSpeed
    /// </summary>
    public unsafe float BoostSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4440); }
    }

    /// <summary>
    /// FloatProperty: BoostTime
    /// </summary>
    public unsafe float BoostTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4444); }
    }

    /// <summary>
    /// FloatProperty: DefaultBoostSpeed
    /// </summary>
    public unsafe float DefaultBoostSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4448); }
    }

    /// <summary>
    /// NameProperty: UpGadgets
    /// </summary>
    public unsafe BmSDK.FName UpGadgets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4452); }
    }

    /// <summary>
    /// NameProperty: DoubleUpGadgets
    /// </summary>
    public unsafe BmSDK.FName DoubleUpGadgets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4516); }
    }

    /// <summary>
    /// NameProperty: DownGadgets
    /// </summary>
    public unsafe BmSDK.FName DownGadgets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4580); }
    }

    /// <summary>
    /// StructProperty: ExtraCollision
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.FFakeWall ExtraCollision
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FFakeWall>(Ptr + 4620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4620); }
    }

    /// <summary>
    /// ComponentProperty: OverrideUnderColl
    /// </summary>
    public unsafe BmSDK.Engine.PrimitiveComponent OverrideUnderColl
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PrimitiveComponent>(Ptr + 4668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4668); }
    }

    /// <summary>
    /// ObjectProperty: OverheadRopeControlPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RRope2SimplePhysicsControlPoint OverheadRopeControlPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRope2SimplePhysicsControlPoint>(Ptr + 4672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4672); }
    }

    /// <summary>
    /// FloatProperty: OverheadRopeControlPointRopePosition
    /// </summary>
    public unsafe float OverheadRopeControlPointRopePosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4692); }
    }

    /// <summary>
    /// NameProperty: OverheadRopeControlPointSocketNames
    /// </summary>
    public unsafe BmSDK.FName OverheadRopeControlPointSocketNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4712); }
    }

    /// <summary>
    /// ObjectProperty: LastWirePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint_RopeBase LastWirePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint_RopeBase>(Ptr + 4752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4752); }
    }

    /// <summary>
    /// ObjectProperty: CurrentSpecialMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveInstance CurrentSpecialMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveInstance>(Ptr + 4756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4756); }
    }

    /// <summary>
    /// StructProperty: ClimbToCeilingClimbPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.FCeilingClimbPoint ClimbToCeilingClimbPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FCeilingClimbPoint>(Ptr + 4760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4760); }
    }

    /// <summary>
    /// StructProperty: ClimbToCatwalkClimbPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.FCeilingClimbPoint ClimbToCatwalkClimbPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FCeilingClimbPoint>(Ptr + 4872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4872); }
    }

    /// <summary>
    /// ObjectProperty: CurrentCeilingVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RCeilingClimbVolume CurrentCeilingVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCeilingClimbVolume>(Ptr + 4984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4984); }
    }

    /// <summary>
    /// ObjectProperty: GrateToCeiling
    /// </summary>
    public unsafe BmSDK.BmGame.RTunnelGrateBase GrateToCeiling
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTunnelGrateBase>(Ptr + 4988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4988); }
    }

    /// <summary>
    /// ObjectProperty: GrateFromCeiling
    /// </summary>
    public unsafe BmSDK.BmGame.RTunnelGrateBase GrateFromCeiling
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTunnelGrateBase>(Ptr + 4992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4992); }
    }

    /// <summary>
    /// ObjectProperty: ActiveGrate
    /// </summary>
    public unsafe BmSDK.BmGame.RTunnelGrateBase ActiveGrate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTunnelGrateBase>(Ptr + 4996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4996); }
    }

    /// <summary>
    /// ObjectProperty: GadgetList
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget GadgetList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget>(Ptr + 5000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5000); }
    }

    /// <summary>
    /// StructProperty: LastJumpVelocity
    /// </summary>
    public unsafe System.Numerics.Vector3 LastJumpVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 5128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5128); }
    }

    /// <summary>
    /// ObjectProperty: GlideKickOverridePS
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem GlideKickOverridePS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 5140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5140); }
    }

    /// <summary>
    /// ObjectProperty: SuperGlideAttackFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem SuperGlideAttackFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 5144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5144); }
    }

    /// <summary>
    /// ObjectProperty: SuperGlideAttackMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant SuperGlideAttackMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 5148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5148); }
    }

    /// <summary>
    /// ClassProperty: ForensicsType
    /// </summary>
    public unsafe BmSDK.Class ForensicsType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 5152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5152); }
    }

    /// <summary>
    /// ObjectProperty: TraversalMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController TraversalMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5156); }
    }

    /// <summary>
    /// ObjectProperty: StealthMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController StealthMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5160); }
    }

    /// <summary>
    /// ObjectProperty: RunTraversalMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController RunTraversalMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5164); }
    }

    /// <summary>
    /// ObjectProperty: StealthTraversalMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController StealthTraversalMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5168); }
    }

    /// <summary>
    /// ObjectProperty: WalkingMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController WalkingMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5172); }
    }

    /// <summary>
    /// ObjectProperty: FallingSpecialMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController FallingSpecialMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5176); }
    }

    /// <summary>
    /// ObjectProperty: FallingClimbSpecialMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController FallingClimbSpecialMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5180); }
    }

    /// <summary>
    /// ObjectProperty: CapeGlideSpecialMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController CapeGlideSpecialMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5184); }
    }

    /// <summary>
    /// ObjectProperty: HardCapeGlideSpecialMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController HardCapeGlideSpecialMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5188); }
    }

    /// <summary>
    /// ObjectProperty: ClimbFromLedgeMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController ClimbFromLedgeMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5192); }
    }

    /// <summary>
    /// ObjectProperty: ClimbFromDangleMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController ClimbFromDangleMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5196); }
    }

    /// <summary>
    /// ObjectProperty: ClimbFromLadderMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController ClimbFromLadderMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5200); }
    }

    /// <summary>
    /// ObjectProperty: LedgeMovesLeft
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController LedgeMovesLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5204); }
    }

    /// <summary>
    /// ObjectProperty: LedgeMovesRight
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController LedgeMovesRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5208); }
    }

    /// <summary>
    /// ObjectProperty: DangleMovesLeft
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController DangleMovesLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5212); }
    }

    /// <summary>
    /// ObjectProperty: DangleMovesRight
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController DangleMovesRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5216); }
    }

    /// <summary>
    /// ObjectProperty: JumpStraightOffRailingMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController JumpStraightOffRailingMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 5220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5220); }
    }

    /// <summary>
    /// IntProperty: ClimbIndex
    /// </summary>
    public unsafe int ClimbIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5224); }
    }

    /// <summary>
    /// ObjectProperty: CustomisableFallingGrabLedgeMove
    /// </summary>
    public unsafe BmSDK.BmGame.REnvironmentSpecialMoveWrapperFalling CustomisableFallingGrabLedgeMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REnvironmentSpecialMoveWrapperFalling>(Ptr + 5228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5228); }
    }

    /// <summary>
    /// ObjectProperty: HopOffRailangMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig HopOffRailangMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5232); }
    }

    /// <summary>
    /// ObjectProperty: HopOffRailangMoveToHang
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig HopOffRailangMoveToHang
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5236); }
    }

    /// <summary>
    /// ObjectProperty: HopOffRailangMoveToHang128
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig HopOffRailangMoveToHang128
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5240); }
    }

    /// <summary>
    /// ObjectProperty: HopOffRailangMoveToHang128Dangle
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig HopOffRailangMoveToHang128Dangle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5244); }
    }

    /// <summary>
    /// ObjectProperty: StepOffRailing128Move
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig StepOffRailing128Move
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5248); }
    }

    /// <summary>
    /// ObjectProperty: DropOffWireMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DropOffWireMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5252); }
    }

    /// <summary>
    /// ObjectProperty: GlideKickMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GlideKickMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5256); }
    }

    /// <summary>
    /// ObjectProperty: BoostGlideKickMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig BoostGlideKickMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5260); }
    }

    /// <summary>
    /// ObjectProperty: DiveOffBuildingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DiveOffBuildingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5264); }
    }

    /// <summary>
    /// ObjectProperty: GlideFromVantagePointMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GlideFromVantagePointMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5268); }
    }

    /// <summary>
    /// ObjectProperty: LastChanceJumpMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig LastChanceJumpMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5272); }
    }

    /// <summary>
    /// ObjectProperty: LowGlideKickMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig LowGlideKickMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5276); }
    }

    /// <summary>
    /// ObjectProperty: ExitCoverLeftMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ExitCoverLeftMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5280); }
    }

    /// <summary>
    /// ObjectProperty: ExitCoverRightMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ExitCoverRightMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5284); }
    }

    /// <summary>
    /// ObjectProperty: CapeGlideLandHardMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CapeGlideLandHardMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5288); }
    }

    /// <summary>
    /// ObjectProperty: CapeGlideLandSkidMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CapeGlideLandSkidMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5292); }
    }

    /// <summary>
    /// ObjectProperty: CapeGlideLandToRunMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CapeGlideLandToRunMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5296); }
    }

    /// <summary>
    /// ObjectProperty: FastGlideSkidLandMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig FastGlideSkidLandMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5300); }
    }

    /// <summary>
    /// ObjectProperty: BoostGlideLandMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig BoostGlideLandMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5304); }
    }

    /// <summary>
    /// ObjectProperty: BoostGlideLandHardMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig BoostGlideLandHardMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5308); }
    }

    /// <summary>
    /// ObjectProperty: ShockwaveUpgradeLandMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ShockwaveUpgradeLandMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5312); }
    }

    /// <summary>
    /// ObjectProperty: CapeGlideWallHitMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CapeGlideWallHitMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5316); }
    }

    /// <summary>
    /// ObjectProperty: CapeGlideWallHitHardMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CapeGlideWallHitHardMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5320); }
    }

    /// <summary>
    /// ObjectProperty: SlideMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig SlideMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5324); }
    }

    /// <summary>
    /// ObjectProperty: DiveOverRailingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DiveOverRailingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5328); }
    }

    /// <summary>
    /// ObjectProperty: DiveOverRailingToFallMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DiveOverRailingToFallMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5332); }
    }

    /// <summary>
    /// ObjectProperty: RailingToLedgeHangMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig RailingToLedgeHangMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5336); }
    }

    /// <summary>
    /// ObjectProperty: RailingToLEdgeHang128Move
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig RailingToLEdgeHang128Move
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5340); }
    }

    /// <summary>
    /// ObjectProperty: RunStepDown128Move
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig RunStepDown128Move
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5344); }
    }

    /// <summary>
    /// ObjectProperty: WalkStepDown128Move
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig WalkStepDown128Move
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5348); }
    }

    /// <summary>
    /// ObjectProperty: StealthStepDown128Move
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig StealthStepDown128Move
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5352); }
    }

    /// <summary>
    /// StructProperty: WireBouncer
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.FWireBounceUpdater WireBouncer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FWireBounceUpdater>(Ptr + 5356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5356); }
    }

    /// <summary>
    /// ComponentProperty: PlayerIconPSC
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent PlayerIconPSC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5424); }
    }

    /// <summary>
    /// ObjectProperty: SlideStopAudioEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent SlideStopAudioEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 5428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5428); }
    }

    /// <summary>
    /// StructProperty: CurrentCollisionSmoothingForce
    /// </summary>
    public unsafe System.Numerics.Vector3 CurrentCollisionSmoothingForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 5432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5432); }
    }

    /// <summary>
    /// StructProperty: DesiredCollisionSmoothingForce
    /// </summary>
    public unsafe System.Numerics.Vector3 DesiredCollisionSmoothingForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 5444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5444); }
    }

    /// <summary>
    /// FloatProperty: CollisionSmoothingStrength
    /// </summary>
    public unsafe float CollisionSmoothingStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5456); }
    }

    /// <summary>
    /// FloatProperty: CollisionSmoothingOffStrength
    /// </summary>
    public unsafe float CollisionSmoothingOffStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5460); }
    }

    /// <summary>
    /// FloatProperty: CurrentAvoidAnimStrength
    /// </summary>
    public unsafe float CurrentAvoidAnimStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5464); }
    }

    /// <summary>
    /// FloatProperty: MaxAvoidAnimSpeed
    /// </summary>
    public unsafe float MaxAvoidAnimSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5468); }
    }

    /// <summary>
    /// FloatProperty: AvoidAnimOnStrength
    /// </summary>
    public unsafe float AvoidAnimOnStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5472); }
    }

    /// <summary>
    /// FloatProperty: AvoidAnimOffStrength
    /// </summary>
    public unsafe float AvoidAnimOffStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5476); }
    }

    /// <summary>
    /// ObjectProperty: GlideBoostSoundEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent GlideBoostSoundEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 5480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5480); }
    }

    /// <summary>
    /// ObjectProperty: GlideBoostStopSoundEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent GlideBoostStopSoundEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 5484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5484); }
    }

    /// <summary>
    /// ObjectProperty: GlideBoostSoundParam
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName GlideBoostSoundParam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 5488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5488); }
    }

    /// <summary>
    /// ObjectProperty: CapeOpenSoundParam
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName CapeOpenSoundParam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 5492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5492); }
    }

    /// <summary>
    /// StructProperty: CriticalLandScreenShake
    /// </summary>
    public unsafe BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct CriticalLandScreenShake
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 5496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5496); }
    }

    /// <summary>
    /// IntProperty: QuickGadgets
    /// </summary>
    public unsafe int QuickGadgets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5640); }
    }

    /// <summary>
    /// FloatProperty: SpecialMoveLeftFootCycleStartTime
    /// </summary>
    public unsafe float SpecialMoveLeftFootCycleStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5660); }
    }

    /// <summary>
    /// FloatProperty: SpecialMoveRightPassingCycleStartTime
    /// </summary>
    public unsafe float SpecialMoveRightPassingCycleStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5664); }
    }

    /// <summary>
    /// FloatProperty: OverrideFallingGravity
    /// </summary>
    public unsafe float OverrideFallingGravity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5668); }
    }

    /// <summary>
    /// FloatProperty: MaxJumpStrengthToJumpLand
    /// </summary>
    public unsafe float MaxJumpStrengthToJumpLand
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5672); }
    }

    /// <summary>
    /// FloatProperty: GrappleForceFieldSize
    /// </summary>
    public unsafe float GrappleForceFieldSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5676); }
    }

    /// <summary>
    /// FloatProperty: GrappleForceFieldWidth
    /// </summary>
    public unsafe float GrappleForceFieldWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5680); }
    }

    /// <summary>
    /// FloatProperty: GrappleForceFieldStrength
    /// </summary>
    public unsafe float GrappleForceFieldStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5684); }
    }

    /// <summary>
    /// FloatProperty: GrappleForceFieldStrengthPower
    /// </summary>
    public unsafe float GrappleForceFieldStrengthPower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5688); }
    }

    /// <summary>
    /// FloatProperty: GrappleAnimForceFieldFactor
    /// </summary>
    public unsafe float GrappleAnimForceFieldFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5692); }
    }

    /// <summary>
    /// StructProperty: CantRunInDirection
    /// </summary>
    public unsafe System.Numerics.Vector3 CantRunInDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 5696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5696); }
    }

    /// <summary>
    /// StructProperty: QuickFireFailedTransitionId
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId QuickFireFailedTransitionId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 5708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5708); }
    }

    /// <summary>
    /// StructProperty: ShotOnVantageShaker
    /// </summary>
    public unsafe BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct ShotOnVantageShaker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 5712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5712); }
    }

    /// <summary>
    /// ObjectProperty: UnderWaterVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RWaterRescueVolumeBase UnderWaterVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWaterRescueVolumeBase>(Ptr + 5856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5856); }
    }

    /// <summary>
    /// StructProperty: UnderWaterVolumeLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 UnderWaterVolumeLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 5860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5860); }
    }

    /// <summary>
    /// ObjectProperty: UnderWaterEmitter
    /// </summary>
    public unsafe BmSDK.BmGame.REmitter UnderWaterEmitter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REmitter>(Ptr + 5872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5872); }
    }

    /// <summary>
    /// ObjectProperty: SlippedCorner
    /// </summary>
    public unsafe BmSDK.Engine.Actor SlippedCorner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 5876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5876); }
    }

    /// <summary>
    /// FloatProperty: JumpStrength
    /// </summary>
    public unsafe float JumpStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5880); }
    }

    /// <summary>
    /// FloatProperty: JumpFallOffRate
    /// </summary>
    public unsafe float JumpFallOffRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5884); }
    }

    /// <summary>
    /// FloatProperty: FallAnimRate
    /// </summary>
    public unsafe float FallAnimRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5888); }
    }

    /// <summary>
    /// FloatProperty: JumpAnimRate
    /// </summary>
    public unsafe float JumpAnimRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5892); }
    }

    /// <summary>
    /// ObjectProperty: FallSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FallSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 5896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5896); }
    }

    /// <summary>
    /// ObjectProperty: FallStopSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FallStopSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 5900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5900); }
    }

    /// <summary>
    /// ComponentProperty: HangFromVantageRope
    /// </summary>
    public unsafe BmSDK.BmGame.RSimpleRopeComponent HangFromVantageRope
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSimpleRopeComponent>(Ptr + 5904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5904); }
    }

    /// <summary>
    /// StructProperty: LastRootMotionVelocity
    /// </summary>
    public unsafe System.Numerics.Vector3 LastRootMotionVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 5908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5908); }
    }

    /// <summary>
    /// StructProperty: EnvironemntEdgeTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveTypesContainer EnvironemntEdgeTypes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveTypesContainer>(Ptr + 5920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5920); }
    }

    /// <summary>
    /// StructProperty: DamageProxyLastActivePos
    /// </summary>
    public unsafe System.Numerics.Vector3 DamageProxyLastActivePos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 5928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5928); }
    }

    /// <summary>
    /// StructProperty: InterrogWallSpaceCheckExtents
    /// </summary>
    public unsafe System.Numerics.Vector3 InterrogWallSpaceCheckExtents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 5940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5940); }
    }

    /// <summary>
    /// FloatProperty: InterrogWallSpaceCheckHeight
    /// </summary>
    public unsafe float InterrogWallSpaceCheckHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5952); }
    }
}
