#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAEC_Casualty<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RAEC_Casualty : BmSDK.BmGame.RAEC_CasualtyBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAEC_Casualty", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAEC_Casualty() { }

    /// <summary>
    /// Constructs a new RAEC_Casualty
    /// </summary>
    public RAEC_Casualty(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAEC_Casualty Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAEC_Casualty(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Casualty>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Casualty>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Casualty>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Casualty>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Casualty>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Casualty>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Casualty>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: ChildGroupCheckCas
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ChildGroupCheckCas
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// ObjectProperty: ChildSoloCas
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ChildSoloCas
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// ObjectProperty: ChildPauseGroup
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ChildPauseGroup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }

    /// <summary>
    /// ObjectProperty: AAITAnnoyRunner
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AAITAnnoyRunner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// ObjectProperty: GlideKickOriginHidePoint
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GlideKickOriginHidePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// ObjectProperty: DropAttackOriginHidePoint
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DropAttackOriginHidePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// ObjectProperty: AssignedSentryGunPlacementPoint
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AssignedSentryGunPlacementPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }

    /// <summary>
    /// ObjectProperty: NervousSetPieceSpotter
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT NervousSetPieceSpotter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// IntProperty: NervousInvestigateCap
    /// </summary>
    public unsafe int NervousInvestigateCap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// BoolProperty: bDiscoveredByCheckin
    /// </summary>
    public unsafe bool bDiscoveredByCheckin
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 852); }
    }

    /// <summary>
    /// BoolProperty: bWaitingToPlayHeardTakedown
    /// </summary>
    public unsafe bool bWaitingToPlayHeardTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 852); }
    }

    /// <summary>
    /// BoolProperty: bPerimSetPieceStarted
    /// </summary>
    public unsafe bool bPerimSetPieceStarted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 852); }
    }

    /// <summary>
    /// BoolProperty: bNeedGlideKickResponse
    /// </summary>
    public unsafe bool bNeedGlideKickResponse
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 852); }
    }

    /// <summary>
    /// BoolProperty: bNeedDropAttackResponse
    /// </summary>
    public unsafe bool bNeedDropAttackResponse
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 852); }
    }

    /// <summary>
    /// BoolProperty: bDoneCheekyGargMine
    /// </summary>
    public unsafe bool bDoneCheekyGargMine
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 852); }
    }

    /// <summary>
    /// BoolProperty: bCasFaceDown
    /// </summary>
    public unsafe bool bCasFaceDown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 852); }
    }

    /// <summary>
    /// BoolProperty: bLeftOfCasBlocked
    /// </summary>
    public unsafe bool bLeftOfCasBlocked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 852); }
    }

    /// <summary>
    /// BoolProperty: bRightOfCasBlocked
    /// </summary>
    public unsafe bool bRightOfCasBlocked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 852); }
    }

    /// <summary>
    /// BoolProperty: thugOnCasLeft
    /// </summary>
    public unsafe bool thugOnCasLeft
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 852); }
    }

    /// <summary>
    /// BoolProperty: triggeredAAIAnnouncement
    /// </summary>
    public unsafe bool triggeredAAIAnnouncement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 852); }
    }

    /// <summary>
    /// BoolProperty: triggeredAAIResponse
    /// </summary>
    public unsafe bool triggeredAAIResponse
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 852); }
    }

    /// <summary>
    /// ArrayProperty: InvestigateNavReq
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>> InvestigateNavReq
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// IntProperty: NumAssigned
    /// </summary>
    public unsafe int NumAssigned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// FloatProperty: ReleaseTimer
    /// </summary>
    public unsafe float ReleaseTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// FloatProperty: PlayHeardTakedownSkipTimer
    /// </summary>
    public unsafe float PlayHeardTakedownSkipTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// StructProperty: takedownHidePointPos
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT takedownHidePointPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// StructProperty: crouchPosLeftOfCas
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT crouchPosLeftOfCas
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }

    /// <summary>
    /// StructProperty: crouchRotLeftOfCas
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT crouchRotLeftOfCas
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// StructProperty: crouchPosRightOfCas
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT crouchPosRightOfCas
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }

    /// <summary>
    /// StructProperty: crouchRotRightOfCas
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT crouchRotRightOfCas
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// FloatProperty: CAS_FAR_GESTURE_DIST
    /// </summary>
    public unsafe float CAS_FAR_GESTURE_DIST
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// StructProperty: cachedSpottedLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT cachedSpottedLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// IntProperty: casFoundCount
    /// </summary>
    public unsafe int casFoundCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// ByteProperty: NSPType
    /// </summary>
    public unsafe byte NSPType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }
}
