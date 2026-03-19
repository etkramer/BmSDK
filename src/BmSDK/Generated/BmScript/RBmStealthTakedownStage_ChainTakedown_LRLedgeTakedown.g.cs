#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RBmStealthTakedownStage_ChainTakedown_LRLedgeTakedown<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBmStealthTakedownStage_ChainTakedown_LRLedgeTakedown : BmSDK.BmScript.RBmStealthTakedownStage_ChainTakedown_LRRailingTakedown, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RBmStealthTakedownStage_ChainTakedown_LRLedgeTakedown", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBmStealthTakedownStage_ChainTakedown_LRLedgeTakedown() { }

    /// <summary>
    /// Constructs a new RBmStealthTakedownStage_ChainTakedown_LRLedgeTakedown
    /// </summary>
    public RBmStealthTakedownStage_ChainTakedown_LRLedgeTakedown(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBmStealthTakedownStage_ChainTakedown_LRLedgeTakedown Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBmStealthTakedownStage_ChainTakedown_LRLedgeTakedown(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBmStealthTakedownStage_ChainTakedown_LRLedgeTakedown>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBmStealthTakedownStage_ChainTakedown_LRLedgeTakedown>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBmStealthTakedownStage_ChainTakedown_LRLedgeTakedown>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBmStealthTakedownStage_ChainTakedown_LRLedgeTakedown>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBmStealthTakedownStage_ChainTakedown_LRLedgeTakedown>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBmStealthTakedownStage_ChainTakedown_LRLedgeTakedown>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBmStealthTakedownStage_ChainTakedown_LRLedgeTakedown>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// FloatProperty: fSlowdownAmountToSelectNextVictim
    /// </summary>
    public unsafe float fSlowdownAmountToSelectNextVictim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1664); }
    }

    /// <summary>
    /// FloatProperty: fRealTimeWaitForSlowdownToEnd
    /// </summary>
    public unsafe float fRealTimeWaitForSlowdownToEnd
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1668); }
    }

    /// <summary>
    /// BoolProperty: SpottedByAnotherThug
    /// </summary>
    public unsafe bool SpottedByAnotherThug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1672) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1672); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1672); }
    }

    /// <summary>
    /// BoolProperty: bTriggeredSloMo
    /// </summary>
    public unsafe bool bTriggeredSloMo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1672) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1672); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1672); }
    }

    /// <summary>
    /// BoolProperty: bLinearDampingOnRagdollDisabled
    /// </summary>
    public unsafe bool bLinearDampingOnRagdollDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1672) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1672); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1672); }
    }

    /// <summary>
    /// BoolProperty: bDoingLastHitSlomo
    /// </summary>
    public unsafe bool bDoingLastHitSlomo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1672) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1672); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1672); }
    }

    /// <summary>
    /// BoolProperty: bCheckForNextFearTakedownTargetAtStart
    /// </summary>
    public unsafe bool bCheckForNextFearTakedownTargetAtStart
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1672) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1672); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1672); }
    }

    /// <summary>
    /// BoolProperty: bNextChainFearTakedownTargetExistedAtStart
    /// </summary>
    public unsafe bool bNextChainFearTakedownTargetExistedAtStart
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1672) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1672); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1672); }
    }

    /// <summary>
    /// BoolProperty: bCountThisMoveTowardsFearTakedownCount
    /// </summary>
    public unsafe bool bCountThisMoveTowardsFearTakedownCount
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1672) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1672); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1672); }
    }

    /// <summary>
    /// ObjectProperty: CachedTunnelGrate
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CachedTunnelGrate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1676); }
    }

    /// <summary>
    /// IntProperty: iScreenShakeId
    /// </summary>
    public unsafe int iScreenShakeId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1684); }
    }

    /// <summary>
    /// StructProperty: FinalHitCameraShake
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FinalHitCameraShake
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1688); }
    }
}
