#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCombatMove_RobinThrow<br/>
/// (size = 1008)
/// (flags = 10485778)
/// </summary>
public partial class RCombatMove_RobinThrow : BmSDK.BmGame.RCombatMove_PlayerSpecial, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCombatMove_RobinThrow", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCombatMove_RobinThrow() { }

    /// <summary>
    /// Constructs a new RCombatMove_RobinThrow
    /// </summary>
    public RCombatMove_RobinThrow(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCombatMove_RobinThrow Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCombatMove_RobinThrow(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_RobinThrow>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_RobinThrow>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_RobinThrow>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_RobinThrow>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_RobinThrow>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_RobinThrow>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_RobinThrow>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: ExitMoveForPawn
    /// </summary>
    public unsafe void ExitMoveForPawn(BmSDK.BmGame.RPawnCombat PawnToExit)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCombatMove_RobinThrow.ExitMoveForPawn", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnToExit, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ExitMove
    /// </summary>
    public unsafe void ExitMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCombatMove_RobinThrow.ExitMove", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: MoveOverridenForPawn
    /// </summary>
    public unsafe void MoveOverridenForPawn(BmSDK.BmGame.RPawnCombat OverridenPawn, BmSDK.BmGame.RCombatMove NewMove)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCombatMove_RobinThrow.MoveOverridenForPawn", true);
        byte* paramsPtr = stackalloc byte[264];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverridenPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMove, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateControllerInput
    /// </summary>
    public unsafe void UpdateControllerInput()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCombatMove_RobinThrow.UpdateControllerInput", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetThrowInfo
    /// </summary>
    public unsafe bool SetThrowInfo()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCombatMove_RobinThrow.SetThrowInfo", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: FindThrowTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain FindThrowTarget(System.Numerics.Vector3 TestThrowDir, bool throwee)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCombatMove_RobinThrow.FindThrowTarget", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestThrowDir, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(throwee, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: GetScoreForThrowTarget
    /// </summary>
    public unsafe float GetScoreForThrowTarget(BmSDK.BmGame.RThrowTarget TestTarget, System.Numerics.Vector3 TestThrowDir)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCombatMove_RobinThrow.GetScoreForThrowTarget", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestTarget, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestThrowDir, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: GetScoreForPawn
    /// </summary>
    public unsafe float GetScoreForPawn(BmSDK.BmGame.RPawnVillain TestPawn, System.Numerics.Vector3 TestThrowDir, float MaxRange)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCombatMove_RobinThrow.GetScoreForPawn", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestThrowDir, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxRange, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: LockThrowDir
    /// </summary>
    public unsafe void LockThrowDir()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCombatMove_RobinThrow.LockThrowDir", true);
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanReceiveAttackFromPawn
    /// </summary>
    public unsafe bool CanReceiveAttackFromPawn(BmSDK.BmGame.RPawnCombat TestPawn, BmSDK.BmGame.RPawnCombat NewAttacker)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCombatMove_RobinThrow.CanReceiveAttackFromPawn", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAttacker, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: CanNewAttackBeStarted
    /// </summary>
    public unsafe bool CanNewAttackBeStarted()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCombatMove_RobinThrow.CanNewAttackBeStarted", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsValidTarget
    /// </summary>
    public unsafe bool IsValidTarget(BmSDK.BmGame.RPawnVillain Enemy)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCombatMove_RobinThrow.IsValidTarget", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Enemy, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: Initialise
    /// </summary>
    public unsafe void Initialise()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCombatMove_RobinThrow.Initialise", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// StructProperty: IntoTakedownAnimID
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId IntoTakedownAnimID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// StructProperty: ThrowAnimID
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId ThrowAnimID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// StructProperty: TargetAnimID
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId TargetAnimID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// FloatProperty: TargetDist
    /// </summary>
    public unsafe float TargetDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// StructProperty: ThrowDir
    /// </summary>
    public unsafe System.Numerics.Vector3 ThrowDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bNewAttackerAllowed
    /// </summary>
    public unsafe bool bNewAttackerAllowed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 960); }
    }

    /// <summary>
    /// BoolProperty: bCanUpdateThrowDir
    /// </summary>
    public unsafe bool bCanUpdateThrowDir
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 960); }
    }

    /// <summary>
    /// BoolProperty: bSetCapeState
    /// </summary>
    public unsafe bool bSetCapeState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 960); }
    }

    /// <summary>
    /// BoolProperty: bTargetGoneRagdoll
    /// </summary>
    public unsafe bool bTargetGoneRagdoll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 960); }
    }

    /// <summary>
    /// BoolProperty: bDirectThrow
    /// </summary>
    public unsafe bool bDirectThrow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 960); }
    }

    /// <summary>
    /// BoolProperty: bOldApplySoftPawnCollision
    /// </summary>
    public unsafe bool bOldApplySoftPawnCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 960); }
    }

    /// <summary>
    /// BoolProperty: bOldReceiveSoftPawnCollision
    /// </summary>
    public unsafe bool bOldReceiveSoftPawnCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 960); }
    }

    /// <summary>
    /// FloatProperty: BiggestControllerInput
    /// </summary>
    public unsafe float BiggestControllerInput
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// FloatProperty: CapeTimer
    /// </summary>
    public unsafe float CapeTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// FloatProperty: CheckRagdollTimer
    /// </summary>
    public unsafe float CheckRagdollTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// StructProperty: ThrowInfo
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayerCombat.FThrowInfo ThrowInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.FThrowInfo>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }
}
