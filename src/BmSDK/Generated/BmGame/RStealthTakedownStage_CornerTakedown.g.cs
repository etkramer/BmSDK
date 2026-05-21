#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RStealthTakedownStage_CornerTakedown<br/>
/// (size = 1760)
/// (flags = 10485778)
/// </summary>
public partial class RStealthTakedownStage_CornerTakedown : BmSDK.BmGame.RStealthTakedownStageQuickBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RStealthTakedownStage_CornerTakedown", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RStealthTakedownStage_CornerTakedown.
    /// </summary>
    public static RStealthTakedownStage_CornerTakedown DefaultObject => (RStealthTakedownStage_CornerTakedown)StaticClass().DefaultObject;

    internal RStealthTakedownStage_CornerTakedown() { }

    /// <summary>
    /// Constructs a new RStealthTakedownStage_CornerTakedown
    /// </summary>
    public RStealthTakedownStage_CornerTakedown(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RStealthTakedownStage_CornerTakedown(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_CornerTakedown>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_CornerTakedown>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_CornerTakedown>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_CornerTakedown>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_CornerTakedown>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_CornerTakedown>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_CornerTakedown>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_CornerTakedown>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: GotoStageEx
    /// </summary>
    public unsafe override void GotoStageEx(BmSDK.BmGame.RGameInfo.EStealthTakeDownStages NextStageClass, bool bClientRequest = default, BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator EscapeLoc = default, bool bEscapeTakedown = default, bool bNextStageIsFearTakedown = default, bool bNextStageIsKnockoutSmash = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RStealthTakedownStage_CornerTakedown.GotoStageEx", true);
        byte* paramsPtr = stackalloc byte[156];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextStageClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bClientRequest, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EscapeLoc, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEscapeTakedown, paramsPtr + 140);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNextStageIsFearTakedown, paramsPtr + 144);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNextStageIsKnockoutSmash, paramsPtr + 148);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UnEquipBatclawForTakedown
    /// </summary>
    public unsafe virtual void UnEquipBatclawForTakedown()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RStealthTakedownStage_CornerTakedown.UnEquipBatclawForTakedown", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: EquipBatclawForTakedown
    /// </summary>
    public unsafe virtual void EquipBatclawForTakedown()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RStealthTakedownStage_CornerTakedown.EquipBatclawForTakedown", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ReleaseClaws
    /// </summary>
    public unsafe virtual void ReleaseClaws()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RStealthTakedownStage_CornerTakedown.ReleaseClaws", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AttachBatclaw
    /// </summary>
    public unsafe virtual void AttachBatclaw()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RStealthTakedownStage_CornerTakedown.AttachBatclaw", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FindRopeAttachPoints
    /// </summary>
    public unsafe virtual void FindRopeAttachPoints()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RStealthTakedownStage_CornerTakedown.FindRopeAttachPoints", true);
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetFinishState
    /// </summary>
    public unsafe override BmSDK.FName GetFinishState()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RStealthTakedownStage_CornerTakedown.GetFinishState", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetPoseFinalMirrored
    /// </summary>
    public unsafe override bool GetPoseFinalMirrored()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RStealthTakedownStage_CornerTakedown.GetPoseFinalMirrored", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetStageAnim
    /// </summary>
    public unsafe override int GetStageAnim()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RStealthTakedownStage_CornerTakedown.GetStageAnim", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetReferencePosition
    /// </summary>
    public unsafe override void GetReferencePosition(out System.Numerics.Vector3 ReferencePosition, out BmSDK.Rotator ReferenceRotation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RStealthTakedownStage_CornerTakedown.GetReferencePosition", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ReferencePosition = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        ReferenceRotation = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 12);
        return;
    }

    /// <summary>
    /// Function: Begin
    /// </summary>
    public unsafe override void Begin()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RStealthTakedownStage_CornerTakedown.Begin", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// BoolProperty: RopesReleased
    /// </summary>
    public unsafe bool RopesReleased
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1700) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1700); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1700); }
    }

    /// <summary>
    /// BoolProperty: AttachRope
    /// </summary>
    public unsafe bool AttachRope
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1700) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1700); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1700); }
    }

    /// <summary>
    /// ComponentProperty: MyRope
    /// </summary>
    public unsafe BmSDK.BmGame.RSimpleRopeComponent MyRope
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSimpleRopeComponent>(Ptr + 1704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1704); }
    }

    /// <summary>
    /// StructProperty: RopeAttachPoint
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RopeAttachPoint
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1712);

    /// <summary>
    /// StructProperty: RopeRenderAttachPoint
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RopeRenderAttachPoint
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1724);

    /// <summary>
    /// StructProperty: RopeRenderStartOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RopeRenderStartOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1736);

    /// <summary>
    /// StructProperty: RopePhysStartOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RopePhysStartOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1748);
}
