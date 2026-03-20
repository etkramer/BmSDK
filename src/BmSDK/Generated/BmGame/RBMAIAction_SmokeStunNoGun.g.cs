#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMAIAction_SmokeStunNoGun<br/>
/// (flags = 0)
/// </summary>
public partial class RBMAIAction_SmokeStunNoGun : BmSDK.BmGame.RBMAIAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMAIAction_SmokeStunNoGun", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMAIAction_SmokeStunNoGun() { }

    /// <summary>
    /// Constructs a new RBMAIAction_SmokeStunNoGun
    /// </summary>
    public RBMAIAction_SmokeStunNoGun(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMAIAction_SmokeStunNoGun Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMAIAction_SmokeStunNoGun(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_SmokeStunNoGun>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_SmokeStunNoGun>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_SmokeStunNoGun>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_SmokeStunNoGun>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_SmokeStunNoGun>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_SmokeStunNoGun>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_SmokeStunNoGun>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: HostPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI HostPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ObjectProperty: AEC
    /// </summary>
    public unsafe BmSDK.BmGame.RAlertEventCoordinatorSolo AEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAlertEventCoordinatorSolo>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// ObjectProperty: OnGarg
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint_Mesh OnGarg
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint_Mesh>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// StrProperty: DisplayName
    /// </summary>
    public unsafe BmSDK.FString DisplayName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// BoolProperty: bActive
    /// </summary>
    public unsafe bool bActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 708) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 708); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 708); }
    }

    /// <summary>
    /// BoolProperty: bActionAimStateActive
    /// </summary>
    public unsafe bool bActionAimStateActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 708) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 708); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 708); }
    }

    /// <summary>
    /// BoolProperty: bInheritPreviousAimAt
    /// </summary>
    public unsafe bool bInheritPreviousAimAt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 708) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 708); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 708); }
    }

    /// <summary>
    /// BoolProperty: bCustomEyeLocation
    /// </summary>
    public unsafe bool bCustomEyeLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 708) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 708); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 708); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreCaltrops
    /// </summary>
    public unsafe bool bIgnoreCaltrops
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 708) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 708); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 708); }
    }

    /// <summary>
    /// BoolProperty: bInterpolateRandomAim
    /// </summary>
    public unsafe bool bInterpolateRandomAim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 708) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 708); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 708); }
    }

    /// <summary>
    /// BoolProperty: bUsesDroneRemote
    /// </summary>
    public unsafe bool bUsesDroneRemote
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 708) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 708); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 708); }
    }

    /// <summary>
    /// ByteProperty: ExitRequestLevel
    /// </summary>
    public unsafe BmSDK.BmGame.RBMAIAction.ActionExitLevel ExitRequestLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIAction.ActionExitLevel>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// ByteProperty: LatentExitLockLevel
    /// </summary>
    public unsafe BmSDK.BmGame.RBMAIAction.ActionExitLevel LatentExitLockLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIAction.ActionExitLevel>(Ptr + 713); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 713); }
    }

    /// <summary>
    /// ByteProperty: MoveSpeed
    /// </summary>
    public unsafe BmSDK.Engine.RAutomaticTransitions.EMovementSpeed MoveSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAutomaticTransitions.EMovementSpeed>(Ptr + 714); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 714); }
    }

    /// <summary>
    /// FloatProperty: NetworkPopDist
    /// </summary>
    public unsafe float NetworkPopDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// FloatProperty: NetworkBlendDist
    /// </summary>
    public unsafe float NetworkBlendDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// StrProperty: Id
    /// </summary>
    public unsafe BmSDK.FString Id
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// StructProperty: ActionAimStateLoc
    /// </summary>
    public unsafe System.Numerics.Vector3 ActionAimStateLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// NameProperty: ActionAimStateAimAtName
    /// </summary>
    public unsafe BmSDK.FName ActionAimStateAimAtName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// StructProperty: FacingState
    /// </summary>
    public unsafe BmSDK.BmGame.RBMAIAction.FActionFacingState FacingState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIAction.FActionFacingState>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// FloatProperty: SpeedScale
    /// </summary>
    public unsafe float SpeedScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }

    /// <summary>
    /// NameProperty: MoveStance
    /// </summary>
    public unsafe BmSDK.FName MoveStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// NameProperty: WeapStance
    /// </summary>
    public unsafe BmSDK.FName WeapStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// NameProperty: IdleStance
    /// </summary>
    public unsafe BmSDK.FName IdleStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// StructProperty: RandomAimAtPoint
    /// </summary>
    public unsafe System.Numerics.Vector3 RandomAimAtPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// NameProperty: RandomAimAtName
    /// </summary>
    public unsafe BmSDK.FName RandomAimAtName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// StructProperty: PrevRandomAimAtPoint
    /// </summary>
    public unsafe System.Numerics.Vector3 PrevRandomAimAtPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// StructProperty: RandomAimAtTargetPoint
    /// </summary>
    public unsafe System.Numerics.Vector3 RandomAimAtTargetPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// FloatProperty: LastRandomAimAtUpdateTime
    /// </summary>
    public unsafe float LastRandomAimAtUpdateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// FloatProperty: RandomAimUpdateWaitTime
    /// </summary>
    public unsafe float RandomAimUpdateWaitTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// FloatProperty: MinRandAimWaitTime
    /// </summary>
    public unsafe float MinRandAimWaitTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// FloatProperty: RandAimWaitRandomFactor
    /// </summary>
    public unsafe float RandAimWaitRandomFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }
}
