#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RRobinBatClaw<br/>
/// (size = 2452)
/// (flags = 10485810)
/// </summary>
public partial class RRobinBatClaw : BmSDK.BmGame.RHarpoonGun, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RRobinBatClaw", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RRobinBatClaw() { }

    /// <summary>
    /// Constructs a new RRobinBatClaw
    /// </summary>
    public RRobinBatClaw(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RRobinBatClaw Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RRobinBatClaw(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRobinBatClaw>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRobinBatClaw>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRobinBatClaw>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRobinBatClaw>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRobinBatClaw>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRobinBatClaw>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRobinBatClaw>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: CalculateEquipBoneName
    /// </summary>
    public unsafe void CalculateEquipBoneName(out BmSDK.FName OutEquipBoneName, out BmSDK.FName OutEquipBoneName2, out BmSDK.Rotator OutRelativeRotation, BmSDK.FName CustomBone = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RRobinBatClaw.CalculateEquipBoneName", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomBone, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutEquipBoneName = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
        OutEquipBoneName2 = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 8);
        OutRelativeRotation = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 16);
        return;
    }

    /// <summary>
    /// Function: ProjectileCam
    /// </summary>
    public unsafe void ProjectileCam()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RRobinBatClaw.ProjectileCam", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartPullMove
    /// </summary>
    public unsafe void StartPullMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RRobinBatClaw.StartPullMove", true);
        byte* paramsPtr = stackalloc byte[160];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CheckAutoTarget
    /// </summary>
    public unsafe bool CheckAutoTarget(BmSDK.Engine.Actor Target, out System.Numerics.Vector3 TargetPosition, out float OverridePriority, out float OverrideMaxRange, out byte DoLOSCheck)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RRobinBatClaw.CheckAutoTarget", true);
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        TargetPosition = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 8);
        OverridePriority = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 20);
        OverrideMaxRange = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 24);
        DoLOSCheck = BmSDK.Framework.MarshalUtil.ToManaged<byte>(paramsPtr + 28);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 32);
    }

    /// <summary>
    /// Function: UpdateHarpoonTarget
    /// </summary>
    public unsafe bool UpdateHarpoonTarget(bool bInFlight = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RRobinBatClaw.UpdateHarpoonTarget", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInFlight, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: UpdateTarget
    /// </summary>
    public unsafe void UpdateTarget()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RRobinBatClaw.UpdateTarget", true);
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FinalBlowCam
    /// </summary>
    public unsafe void FinalBlowCam()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RRobinBatClaw.FinalBlowCam", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoFireMove
    /// </summary>
    public unsafe void DoFireMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RRobinBatClaw.DoFireMove", true);
        byte* paramsPtr = stackalloc byte[144];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetPrimedPose
    /// </summary>
    public unsafe BmSDK.FName GetPrimedPose(out BmSDK.BmGame.RInventoryGadget.PlayerWantsToCrouch StanceIsCrouched, out BmSDK.BmGame.RAnimUtil.EMirrorChoice MirroredNess, bool InSoftCover, BmSDK.BmGame.RInventoryGadget.CoverCornerType CornerType, out BmSDK.FName OutCapeState, out BmSDK.FName OutCapeTransitionState)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RRobinBatClaw.GetPrimedPose", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSoftCover, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CornerType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        StanceIsCrouched = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.PlayerWantsToCrouch>(paramsPtr + 0);
        MirroredNess = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil.EMirrorChoice>(paramsPtr + 1);
        OutCapeState = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 12);
        OutCapeTransitionState = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 28);
    }

    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe void PostBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RRobinBatClaw.PostBeginPlay", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetImpactAudioEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent GetImpactAudioEvent(BmSDK.Engine.AkWwise.EAkWorldMaterial Mat)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RRobinBatClaw.GetImpactAudioEvent", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mat, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(paramsPtr + 4);
    }

    /// <summary>
    /// ObjectProperty: HarpoonFireMissMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig HarpoonFireMissMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2404); }
    }

    /// <summary>
    /// ObjectProperty: VantageFireMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig VantageFireMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2412); }
    }

    /// <summary>
    /// ObjectProperty: VantageFailMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig VantageFailMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2420); }
    }

    /// <summary>
    /// ObjectProperty: RailingFireMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig RailingFireMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2428); }
    }

    /// <summary>
    /// ObjectProperty: RailingFailMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig RailingFailMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2436); }
    }

    /// <summary>
    /// ByteProperty: ZipKickThrowType
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.BatarangThrowType ZipKickThrowType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.BatarangThrowType>(Ptr + 2444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2444); }
    }

    /// <summary>
    /// IntProperty: DamageGiven
    /// </summary>
    public unsafe int DamageGiven
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2448); }
    }
}
