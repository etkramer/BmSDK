#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RStealthTakedownStage_ChainTakedown_FearFromAboveOnSpotEnd<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RStealthTakedownStage_ChainTakedown_FearFromAboveOnSpotEnd : BmSDK.BmScript.RStealthTakedownStage_ChainTakedown_FearFromAboveEnd, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RStealthTakedownStage_ChainTakedown_FearFromAboveOnSpotEnd", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RStealthTakedownStage_ChainTakedown_FearFromAboveOnSpotEnd() { }

    /// <summary>
    /// Constructs a new RStealthTakedownStage_ChainTakedown_FearFromAboveOnSpotEnd
    /// </summary>
    public RStealthTakedownStage_ChainTakedown_FearFromAboveOnSpotEnd(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RStealthTakedownStage_ChainTakedown_FearFromAboveOnSpotEnd Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RStealthTakedownStage_ChainTakedown_FearFromAboveOnSpotEnd(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_ChainTakedown_FearFromAboveOnSpotEnd>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_ChainTakedown_FearFromAboveOnSpotEnd>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_ChainTakedown_FearFromAboveOnSpotEnd>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_ChainTakedown_FearFromAboveOnSpotEnd>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_ChainTakedown_FearFromAboveOnSpotEnd>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_ChainTakedown_FearFromAboveOnSpotEnd>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_ChainTakedown_FearFromAboveOnSpotEnd>
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
