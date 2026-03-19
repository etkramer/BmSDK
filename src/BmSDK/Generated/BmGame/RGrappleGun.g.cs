#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGrappleGun<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RGrappleGun : BmSDK.BmGame.RInventoryGadget, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGrappleGun", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGrappleGun() { }

    /// <summary>
    /// Constructs a new RGrappleGun
    /// </summary>
    public RGrappleGun(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGrappleGun Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGrappleGun(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGrappleGun>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGrappleGun>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGrappleGun>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGrappleGun>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGrappleGun>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGrappleGun>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGrappleGun>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// FloatProperty: MaxGrappleHeight
    /// </summary>
    public unsafe float MaxGrappleHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2068); }
    }

    /// <summary>
    /// FloatProperty: MinGrappleHeight
    /// </summary>
    public unsafe float MinGrappleHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2072); }
    }

    /// <summary>
    /// FloatProperty: MaxGrappleHorizontalDistance
    /// </summary>
    public unsafe float MaxGrappleHorizontalDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2076); }
    }

    /// <summary>
    /// FloatProperty: MaxGrappleAngle
    /// </summary>
    public unsafe float MaxGrappleAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2080); }
    }

    /// <summary>
    /// FloatProperty: MaxHorizontalDistanceForAimedGrapple
    /// </summary>
    public unsafe float MaxHorizontalDistanceForAimedGrapple
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2084); }
    }

    /// <summary>
    /// FloatProperty: MaxAimedGrappleAngle
    /// </summary>
    public unsafe float MaxAimedGrappleAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2088); }
    }

    /// <summary>
    /// FloatProperty: RunGrappleAngle
    /// </summary>
    public unsafe float RunGrappleAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2092); }
    }

    /// <summary>
    /// FloatProperty: WallStickGrappleAngle
    /// </summary>
    public unsafe float WallStickGrappleAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2096); }
    }

    /// <summary>
    /// FloatProperty: EscapeGrappleAngle
    /// </summary>
    public unsafe float EscapeGrappleAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2100); }
    }

    /// <summary>
    /// ObjectProperty: GrappleFireMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GrappleFireMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2104); }
    }

    /// <summary>
    /// ObjectProperty: GrappleFireGlideMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GrappleFireGlideMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2112); }
    }

    /// <summary>
    /// ObjectProperty: GrappleFireRunningMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GrappleFireRunningMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2120); }
    }

    /// <summary>
    /// ObjectProperty: GrappleFireFallingMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GrappleFireFallingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2128); }
    }

    /// <summary>
    /// ObjectProperty: FailedGrappleFireMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FailedGrappleFireMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2136); }
    }

    /// <summary>
    /// ObjectProperty: VantagePointGrappleMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VantagePointGrappleMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2144); }
    }

    /// <summary>
    /// ObjectProperty: RailingFireGrappleMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RailingFireGrappleMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2152); }
    }

    /// <summary>
    /// ObjectProperty: ShimmyFireGrappleMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ShimmyFireGrappleMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2160); }
    }

    /// <summary>
    /// ObjectProperty: ChainFireGrappleMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ChainFireGrappleMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2168); }
    }

    /// <summary>
    /// ObjectProperty: ChainFireBeamGrappleMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ChainFireBeamGrappleMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2176); }
    }

    /// <summary>
    /// ObjectProperty: GrappleFireWithBackFlipMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GrappleFireWithBackFlipMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2184); }
    }

    /// <summary>
    /// ObjectProperty: GrappleFireTakedownEscape
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GrappleFireTakedownEscape
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2192); }
    }

    /// <summary>
    /// ObjectProperty: GrappleEndDangleMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GrappleEndDangleMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2200); }
    }

    /// <summary>
    /// ObjectProperty: GrappleEndShimmyMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GrappleEndShimmyMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2208); }
    }

    /// <summary>
    /// ObjectProperty: CustomGrappleEndDangleMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CustomGrappleEndDangleMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2216); }
    }

    /// <summary>
    /// ObjectProperty: GrappleEndClimbFlat
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GrappleEndClimbFlat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2224); }
    }

    /// <summary>
    /// ObjectProperty: GrappleEndClimbRailing
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GrappleEndClimbRailing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2232); }
    }

    /// <summary>
    /// ObjectProperty: GrappleEndClimbOverWall
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GrappleEndClimbOverWall
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2240); }
    }

    /// <summary>
    /// ObjectProperty: GrappleEndRunFlat
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GrappleEndRunFlat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2248); }
    }

    /// <summary>
    /// ObjectProperty: GrappleEndRunFlatNoRoll
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GrappleEndRunFlatNoRoll
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2256); }
    }

    /// <summary>
    /// ObjectProperty: GrappleEndRunRailing
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GrappleEndRunRailing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2264); }
    }

    /// <summary>
    /// ObjectProperty: GrappleEndRunOverWall
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GrappleEndRunOverWall
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2272); }
    }

    /// <summary>
    /// ObjectProperty: GrappleEndFly
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GrappleEndFly
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2280); }
    }

    /// <summary>
    /// ObjectProperty: GrappleEndFlyRail
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GrappleEndFlyRail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2288); }
    }

    /// <summary>
    /// ObjectProperty: GrappleBoostToDive
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GrappleBoostToDive
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2296); }
    }

    /// <summary>
    /// ObjectProperty: GrappleEndFly180
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GrappleEndFly180
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2304); }
    }

    /// <summary>
    /// ObjectProperty: GrappleEndOnRailing
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GrappleEndOnRailing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2312); }
    }

    /// <summary>
    /// ObjectProperty: SwingToShimmyMoves
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SwingToShimmyMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2320); }
    }

    /// <summary>
    /// ObjectProperty: SwingToStandMoves
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SwingToStandMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2328); }
    }

    /// <summary>
    /// ObjectProperty: DiveSwingMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DiveSwingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2336); }
    }

    /// <summary>
    /// ObjectProperty: GrappleFromChuteMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GrappleFromChuteMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2344); }
    }

    /// <summary>
    /// ObjectProperty: Projectile
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Projectile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2352); }
    }

    /// <summary>
    /// ObjectProperty: LastHighlightedChute
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LastHighlightedChute
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2360); }
    }

    /// <summary>
    /// ObjectProperty: CurrentHidePoint
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CurrentHidePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2368); }
    }

    /// <summary>
    /// ObjectProperty: ActiveHidePoint
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ActiveHidePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2376); }
    }

    /// <summary>
    /// ObjectProperty: QueuedHidePoint
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT QueuedHidePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2384); }
    }

    /// <summary>
    /// ObjectProperty: GrappleBoostSoundParam
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GrappleBoostSoundParam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2392); }
    }

    /// <summary>
    /// ObjectProperty: SucceedBoostSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SucceedBoostSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2400); }
    }

    /// <summary>
    /// ObjectProperty: FailedBoostSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FailedBoostSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2408); }
    }

    /// <summary>
    /// ObjectProperty: ImpactSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ImpactSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2416); }
    }

    /// <summary>
    /// ObjectProperty: FireGrappleSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FireGrappleSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2424); }
    }

    /// <summary>
    /// ObjectProperty: GrappleLoopSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GrappleLoopSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2432); }
    }

    /// <summary>
    /// ObjectProperty: PassiveImpactSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PassiveImpactSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2440); }
    }

    /// <summary>
    /// ObjectProperty: PassiveFireGrappleSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PassiveFireGrappleSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2448); }
    }

    /// <summary>
    /// ObjectProperty: PassiveGrappleLoopSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PassiveGrappleLoopSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2456); }
    }

    /// <summary>
    /// ObjectProperty: PC
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2464); }
    }

    /// <summary>
    /// ObjectProperty: LastHidePoint
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LastHidePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2472); }
    }

    /// <summary>
    /// ObjectProperty: LastSwingPoint
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LastSwingPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2480); }
    }

    /// <summary>
    /// ObjectProperty: CurrentDelayedChuteTarget
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CurrentDelayedChuteTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2488); }
    }

    /// <summary>
    /// ObjectProperty: UseSpecialOctTree
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT UseSpecialOctTree
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2496); }
    }

    /// <summary>
    /// ObjectProperty: WaterRescueGrappleMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WaterRescueGrappleMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2504); }
    }

    /// <summary>
    /// ClassProperty: GrappleProjectileClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GrappleProjectileClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2512); }
    }

    /// <summary>
    /// ComponentProperty: GrappleRope
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GrappleRope
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2520); }
    }

    /// <summary>
    /// FloatProperty: IconSize
    /// </summary>
    public unsafe float IconSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2528); }
    }

    /// <summary>
    /// IntProperty: MinGrapplePitch
    /// </summary>
    public unsafe int MinGrapplePitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2532); }
    }

    /// <summary>
    /// IntProperty: MinEdgeSwingPitch
    /// </summary>
    public unsafe int MinEdgeSwingPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2536); }
    }

    /// <summary>
    /// IntProperty: MinVantagePitch
    /// </summary>
    public unsafe int MinVantagePitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2540); }
    }

    /// <summary>
    /// FloatProperty: VantagePointGrappleAngle
    /// </summary>
    public unsafe float VantagePointGrappleAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2544); }
    }

    /// <summary>
    /// FloatProperty: ChutePointGrappleAngle
    /// </summary>
    public unsafe float ChutePointGrappleAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2548); }
    }

    /// <summary>
    /// FloatProperty: ChutePointGrappleAngleWeight
    /// </summary>
    public unsafe float ChutePointGrappleAngleWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2552); }
    }

    /// <summary>
    /// FloatProperty: MaxOWSwingRange
    /// </summary>
    public unsafe float MaxOWSwingRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2556); }
    }

    /// <summary>
    /// FloatProperty: DummyPropertyToReplaceMinGrappleBoostRange
    /// </summary>
    public unsafe float DummyPropertyToReplaceMinGrappleBoostRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2560); }
    }

    /// <summary>
    /// NameProperty: CustomHangCamera
    /// </summary>
    public unsafe BmSDK.FName CustomHangCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2564); }
    }

    /// <summary>
    /// BoolProperty: bCantShimmyOnNextHang
    /// </summary>
    public unsafe bool bCantShimmyOnNextHang
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bCantAutoPopUpOnNextHang
    /// </summary>
    public unsafe bool bCantAutoPopUpOnNextHang
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: CurrentSwingGrapple
    /// </summary>
    public unsafe bool CurrentSwingGrapple
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bFadingOutChuteHighlight
    /// </summary>
    public unsafe bool bFadingOutChuteHighlight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bTargettingCeiling
    /// </summary>
    public unsafe bool bTargettingCeiling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: ActiveSwingGrapple
    /// </summary>
    public unsafe bool ActiveSwingGrapple
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: QueuedSwingGrapple
    /// </summary>
    public unsafe bool QueuedSwingGrapple
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bGrappleQueued
    /// </summary>
    public unsafe bool bGrappleQueued
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bActive
    /// </summary>
    public unsafe bool bActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bPreFire
    /// </summary>
    public unsafe bool bPreFire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bShowingGrappleIcon
    /// </summary>
    public unsafe bool bShowingGrappleIcon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bGrapplingFromChute
    /// </summary>
    public unsafe bool bGrapplingFromChute
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bRenderGrappleDebug
    /// </summary>
    public unsafe bool bRenderGrappleDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bUseReverseCameraForSwinging
    /// </summary>
    public unsafe bool bUseReverseCameraForSwinging
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bDoingGrappleSpaceTest
    /// </summary>
    public unsafe bool bDoingGrappleSpaceTest
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bVantagePointCheckFrame
    /// </summary>
    public unsafe bool bVantagePointCheckFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bRunGrapple
    /// </summary>
    public unsafe bool bRunGrapple
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bEdgeSwingGrapple
    /// </summary>
    public unsafe bool bEdgeSwingGrapple
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bCanSwingToPoints
    /// </summary>
    public unsafe bool bCanSwingToPoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bGrappleSelectionDebug
    /// </summary>
    public unsafe bool bGrappleSelectionDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bAllowAimingWhenFalling
    /// </summary>
    public unsafe bool bAllowAimingWhenFalling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bCatwomanGrappleGun
    /// </summary>
    public unsafe bool bCatwomanGrappleGun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bUnusableGrappleTarget
    /// </summary>
    public unsafe bool bUnusableGrappleTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bDoingGlideStick
    /// </summary>
    public unsafe bool bDoingGlideStick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bHarleyGrappleGun
    /// </summary>
    public unsafe bool bHarleyGrappleGun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bUseGrappleOctree
    /// </summary>
    public unsafe bool bUseGrappleOctree
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: LastSwingGrapple
    /// </summary>
    public unsafe bool LastSwingGrapple
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bDebugTreatAsOverworld
    /// </summary>
    public unsafe bool bDebugTreatAsOverworld
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bOverrideGrappleRendering
    /// </summary>
    public unsafe bool bOverrideGrappleRendering
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bWallStick
    /// </summary>
    public unsafe bool bWallStick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bDebugGrappleChecks
    /// </summary>
    public unsafe bool bDebugGrappleChecks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: bDebugCeilingClimbPoints
    /// </summary>
    public unsafe bool bDebugCeilingClimbPoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2572); }
    }

    /// <summary>
    /// BoolProperty: StateOverridesTick
    /// </summary>
    public unsafe bool StateOverridesTick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2576) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2576); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2576); }
    }

    /// <summary>
    /// BoolProperty: bGrappleGunDisabled
    /// </summary>
    public unsafe bool bGrappleGunDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2576) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2576); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2576); }
    }

    /// <summary>
    /// BoolProperty: bForcedGrapple
    /// </summary>
    public unsafe bool bForcedGrapple
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2576) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2576); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2576); }
    }

    /// <summary>
    /// BoolProperty: bGrapplingToWindow
    /// </summary>
    public unsafe bool bGrapplingToWindow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2576) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2576); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2576); }
    }

    /// <summary>
    /// BoolProperty: bCheckFearGas
    /// </summary>
    public unsafe bool bCheckFearGas
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2576) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2576); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2576); }
    }

    /// <summary>
    /// FloatProperty: LookFarwardFallingTime
    /// </summary>
    public unsafe float LookFarwardFallingTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2580); }
    }

    /// <summary>
    /// FloatProperty: MaxHorizontalRange
    /// </summary>
    public unsafe float MaxHorizontalRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2584); }
    }

    /// <summary>
    /// StructProperty: CurrentTarget
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CurrentTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2588); }
    }

    /// <summary>
    /// FloatProperty: CurrentTargetRadius
    /// </summary>
    public unsafe float CurrentTargetRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2600); }
    }

    /// <summary>
    /// StructProperty: GrapplePoint
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GrapplePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2604); }
    }

    /// <summary>
    /// StructProperty: CeilingTarget
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CeilingTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2612); }
    }

    /// <summary>
    /// StructProperty: ActiveGrappleTarget
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ActiveGrappleTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2624); }
    }

    /// <summary>
    /// StructProperty: ActiveOutwardNormal
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ActiveOutwardNormal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2636); }
    }

    /// <summary>
    /// StructProperty: ActiveGrapplePoint
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ActiveGrapplePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2648); }
    }

    /// <summary>
    /// StructProperty: QueuedGrappleTarget
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT QueuedGrappleTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2728); }
    }

    /// <summary>
    /// StructProperty: QueuedOutwardNormal
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT QueuedOutwardNormal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2740); }
    }

    /// <summary>
    /// StructProperty: QueuedGrapplePoint
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT QueuedGrapplePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2752); }
    }

    /// <summary>
    /// StructProperty: CurrentTarget2
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CurrentTarget2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2832); }
    }

    /// <summary>
    /// StructProperty: GrapplePoint2
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GrapplePoint2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2844); }
    }

    /// <summary>
    /// StructProperty: HideLinkSwingTarget
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT HideLinkSwingTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2924); }
    }

    /// <summary>
    /// FloatProperty: GrappleLength
    /// </summary>
    public unsafe float GrappleLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2936); }
    }

    /// <summary>
    /// IntProperty: RopeInitTimer
    /// </summary>
    public unsafe int RopeInitTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2940); }
    }

    /// <summary>
    /// FloatProperty: VantagePointSwingRate
    /// </summary>
    public unsafe float VantagePointSwingRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2944); }
    }

    /// <summary>
    /// FloatProperty: StandingSwingRate
    /// </summary>
    public unsafe float StandingSwingRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2948); }
    }

    /// <summary>
    /// ArrayProperty: GrappleTrailBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RGrappleGun.EscapeHidePoints>>> GrappleTrailBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RGrappleGun.EscapeHidePoints>>>>(Ptr + 2952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2952); }
    }

    /// <summary>
    /// ArrayProperty: GrappleTrailMirrorBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RGrappleGun.EscapeHidePoints>> GrappleTrailMirrorBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RGrappleGun.EscapeHidePoints>>>(Ptr + 2968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2968); }
    }

    /// <summary>
    /// ArrayProperty: GrappleTrail
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGrappleGun.EscapeHidePoints> GrappleTrail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGrappleGun.EscapeHidePoints>>(Ptr + 2984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2984); }
    }

    /// <summary>
    /// FloatProperty: DisplayFailedGrappleTime
    /// </summary>
    public unsafe float DisplayFailedGrappleTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3000); }
    }

    /// <summary>
    /// FloatProperty: OriginalGrappleLength
    /// </summary>
    public unsafe float OriginalGrappleLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3004); }
    }

    /// <summary>
    /// FloatProperty: VantagePointBias
    /// </summary>
    public unsafe float VantagePointBias
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3008); }
    }

    /// <summary>
    /// NameProperty: PreGrappleDestState
    /// </summary>
    public unsafe BmSDK.FName PreGrappleDestState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 3012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3012); }
    }

    /// <summary>
    /// FloatProperty: GrappleAccelTime
    /// </summary>
    public unsafe float GrappleAccelTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3020); }
    }

    /// <summary>
    /// IntProperty: FlyingGrapplePitch
    /// </summary>
    public unsafe int FlyingGrapplePitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3024); }
    }

    /// <summary>
    /// StructProperty: AimedHidePoints
    /// </summary>
    public unsafe BmSDK.BmGame.RGrappleGun.EscapeHidePoints AimedHidePoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrappleGun.EscapeHidePoints>(Ptr + 3028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3028); }
    }

    /// <summary>
    /// StructProperty: EscapeHidePoints
    /// </summary>
    public unsafe BmSDK.BmGame.RGrappleGun.CheckedGrapplePoints EscapeHidePoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrappleGun.CheckedGrapplePoints>(Ptr + 3048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3048); }
    }

    /// <summary>
    /// IntProperty: CurrentGrapplePointToCheck
    /// </summary>
    public unsafe int CurrentGrapplePointToCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3068); }
    }

    /// <summary>
    /// IntProperty: NumValidGrapplePoints
    /// </summary>
    public unsafe int NumValidGrapplePoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3072); }
    }

    /// <summary>
    /// FloatProperty: HidePointDistWeight
    /// </summary>
    public unsafe float HidePointDistWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3076); }
    }

    /// <summary>
    /// FloatProperty: HidePointAngleWeight
    /// </summary>
    public unsafe float HidePointAngleWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3080); }
    }

    /// <summary>
    /// FloatProperty: HidePointAnglePower
    /// </summary>
    public unsafe float HidePointAnglePower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3084); }
    }

    /// <summary>
    /// FloatProperty: AngleToNormalWeight
    /// </summary>
    public unsafe float AngleToNormalWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3088); }
    }

    /// <summary>
    /// FloatProperty: RunningHidePointDistWeight
    /// </summary>
    public unsafe float RunningHidePointDistWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3092); }
    }

    /// <summary>
    /// FloatProperty: RunningHidePointAngleWeight
    /// </summary>
    public unsafe float RunningHidePointAngleWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3096); }
    }

    /// <summary>
    /// FloatProperty: RunningHidePointAnglePower
    /// </summary>
    public unsafe float RunningHidePointAnglePower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3100); }
    }

    /// <summary>
    /// FloatProperty: RunningAngleToNormalWeight
    /// </summary>
    public unsafe float RunningAngleToNormalWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3104); }
    }

    /// <summary>
    /// FloatProperty: RunningStickyWeight
    /// </summary>
    public unsafe float RunningStickyWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3108); }
    }

    /// <summary>
    /// FloatProperty: EdgeSwingDistWeight
    /// </summary>
    public unsafe float EdgeSwingDistWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3112); }
    }

    /// <summary>
    /// FloatProperty: EdgeSwingAngleWeight
    /// </summary>
    public unsafe float EdgeSwingAngleWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3116); }
    }

    /// <summary>
    /// FloatProperty: EdgeSwingAnglePower
    /// </summary>
    public unsafe float EdgeSwingAnglePower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3120); }
    }

    /// <summary>
    /// FloatProperty: EdgeSwingAngleToNormalWeight
    /// </summary>
    public unsafe float EdgeSwingAngleToNormalWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3124); }
    }

    /// <summary>
    /// FloatProperty: ChuteAngleWeight
    /// </summary>
    public unsafe float ChuteAngleWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3128); }
    }

    /// <summary>
    /// FloatProperty: ChuteAnglePower
    /// </summary>
    public unsafe float ChuteAnglePower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3132); }
    }

    /// <summary>
    /// FloatProperty: ChuteDistWeight
    /// </summary>
    public unsafe float ChuteDistWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3136); }
    }

    /// <summary>
    /// FloatProperty: RunningGrappleAngleTan
    /// </summary>
    public unsafe float RunningGrappleAngleTan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3140); }
    }

    /// <summary>
    /// FloatProperty: OffScreenLRIconBias
    /// </summary>
    public unsafe float OffScreenLRIconBias
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3144); }
    }

    /// <summary>
    /// StructProperty: OffScreenArrowRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT OffScreenArrowRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3148); }
    }

    /// <summary>
    /// ByteProperty: GrapplePlayerId
    /// </summary>
    public unsafe byte GrapplePlayerId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 3160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3160); }
    }

    /// <summary>
    /// ByteProperty: LocalPlayerId
    /// </summary>
    public unsafe byte LocalPlayerId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 3161); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3161); }
    }

    /// <summary>
    /// StructProperty: DebugDrawColor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DebugDrawColor_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3164); }
    }
    /// <summary>
    /// StructProperty: DebugDrawColor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DebugDrawColor_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3168); }
    }
    /// <summary>
    /// StructProperty: DebugDrawColor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DebugDrawColor_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3172); }
    }
    /// <summary>
    /// StructProperty: DebugDrawColor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DebugDrawColor_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3176); }
    }
    /// <summary>
    /// StructProperty: DebugDrawColor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DebugDrawColor_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3180); }
    }
    /// <summary>
    /// StructProperty: DebugDrawColor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DebugDrawColor_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3184); }
    }
    /// <summary>
    /// StructProperty: DebugDrawColor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DebugDrawColor_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3188); }
    }
    /// <summary>
    /// StructProperty: DebugDrawColor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DebugDrawColor_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3192); }
    }
    /// <summary>
    /// StructProperty: DebugDrawColor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DebugDrawColor_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3196); }
    }
    /// <summary>
    /// StructProperty: DebugDrawColor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DebugDrawColor_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3200); }
    }
    /// <summary>
    /// StructProperty: DebugDrawColor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DebugDrawColor_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3204); }
    }
    /// <summary>
    /// StructProperty: DebugDrawColor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DebugDrawColor_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3208); }
    }
    /// <summary>
    /// StructProperty: DebugDrawColor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DebugDrawColor_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3212); }
    }

    /// <summary>
    /// StructProperty: DesiredGrappleIconPos
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DesiredGrappleIconPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3216); }
    }

    /// <summary>
    /// StructProperty: GrappleIconOriginalPos
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GrappleIconOriginalPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3228); }
    }

    /// <summary>
    /// FloatProperty: GrappleIconTravelTime
    /// </summary>
    public unsafe float GrappleIconTravelTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3240); }
    }

    /// <summary>
    /// FloatProperty: OldGrapplePointTime
    /// </summary>
    public unsafe float OldGrapplePointTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3244); }
    }

    /// <summary>
    /// FloatProperty: GrappleLagTime
    /// </summary>
    public unsafe float GrappleLagTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3248); }
    }

    /// <summary>
    /// FloatProperty: AerialGrappleRange
    /// </summary>
    public unsafe float AerialGrappleRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3252); }
    }

    /// <summary>
    /// FloatProperty: NoAerialGrappelIfWillHitTime
    /// </summary>
    public unsafe float NoAerialGrappelIfWillHitTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3256); }
    }

    /// <summary>
    /// StructProperty: GrappleWayPoints
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GrappleWayPoints_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3260); }
    }
    /// <summary>
    /// StructProperty: GrappleWayPoints
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GrappleWayPoints_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3272); }
    }
    /// <summary>
    /// StructProperty: GrappleWayPoints
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GrappleWayPoints_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3284); }
    }
    /// <summary>
    /// StructProperty: GrappleWayPoints
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GrappleWayPoints_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3296); }
    }
    /// <summary>
    /// StructProperty: GrappleWayPoints
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GrappleWayPoints_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3308); }
    }
    /// <summary>
    /// StructProperty: GrappleWayPoints
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GrappleWayPoints_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3320); }
    }
    /// <summary>
    /// StructProperty: GrappleWayPoints
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GrappleWayPoints_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3332); }
    }
    /// <summary>
    /// StructProperty: GrappleWayPoints
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GrappleWayPoints_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3344); }
    }

    /// <summary>
    /// StructProperty: GrappleSafePoint
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GrappleSafePoint_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3356); }
    }
    /// <summary>
    /// StructProperty: GrappleSafePoint
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GrappleSafePoint_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3368); }
    }
    /// <summary>
    /// StructProperty: GrappleSafePoint
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GrappleSafePoint_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3380); }
    }
    /// <summary>
    /// StructProperty: GrappleSafePoint
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GrappleSafePoint_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3392); }
    }
    /// <summary>
    /// StructProperty: GrappleSafePoint
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GrappleSafePoint_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3404); }
    }
    /// <summary>
    /// StructProperty: GrappleSafePoint
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GrappleSafePoint_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3416); }
    }
    /// <summary>
    /// StructProperty: GrappleSafePoint
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GrappleSafePoint_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3428); }
    }
    /// <summary>
    /// StructProperty: GrappleSafePoint
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GrappleSafePoint_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3440); }
    }

    /// <summary>
    /// FloatProperty: GrappleWayPointDistances
    /// </summary>
    public unsafe float GrappleWayPointDistances_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3452); }
    }
    /// <summary>
    /// FloatProperty: GrappleWayPointDistances
    /// </summary>
    public unsafe float GrappleWayPointDistances_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3456); }
    }
    /// <summary>
    /// FloatProperty: GrappleWayPointDistances
    /// </summary>
    public unsafe float GrappleWayPointDistances_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3460); }
    }
    /// <summary>
    /// FloatProperty: GrappleWayPointDistances
    /// </summary>
    public unsafe float GrappleWayPointDistances_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3464); }
    }
    /// <summary>
    /// FloatProperty: GrappleWayPointDistances
    /// </summary>
    public unsafe float GrappleWayPointDistances_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3468); }
    }
    /// <summary>
    /// FloatProperty: GrappleWayPointDistances
    /// </summary>
    public unsafe float GrappleWayPointDistances_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3472); }
    }
    /// <summary>
    /// FloatProperty: GrappleWayPointDistances
    /// </summary>
    public unsafe float GrappleWayPointDistances_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3476); }
    }
    /// <summary>
    /// FloatProperty: GrappleWayPointDistances
    /// </summary>
    public unsafe float GrappleWayPointDistances_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3480); }
    }

    /// <summary>
    /// IntProperty: CurrentGrappleWayPoint
    /// </summary>
    public unsafe int CurrentGrappleWayPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3484); }
    }

    /// <summary>
    /// StructProperty: LastClearGrapplePos
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LastClearGrapplePos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3488); }
    }

    /// <summary>
    /// StructProperty: GrappleWaypointFallBack
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GrappleWaypointFallBack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3500); }
    }

    /// <summary>
    /// IntProperty: NumGrapplePointsToCheckPerFrame
    /// </summary>
    public unsafe int NumGrapplePointsToCheckPerFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3512); }
    }

    /// <summary>
    /// StructProperty: LastGrapplePoint
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LastGrapplePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3516); }
    }

    /// <summary>
    /// StructProperty: LastGrapplePointTarget
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LastGrapplePointTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3524); }
    }

    /// <summary>
    /// FloatProperty: LastGrapplePointTime
    /// </summary>
    public unsafe float LastGrapplePointTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3536); }
    }

    /// <summary>
    /// FloatProperty: GrapplePointThinkingTime
    /// </summary>
    public unsafe float GrapplePointThinkingTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3540); }
    }

    /// <summary>
    /// FloatProperty: MaxGrappleBoostExtraHeight
    /// </summary>
    public unsafe float MaxGrappleBoostExtraHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3544); }
    }

    /// <summary>
    /// FloatProperty: MaxGrappleBoostExtraSpeed
    /// </summary>
    public unsafe float MaxGrappleBoostExtraSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3548); }
    }

    /// <summary>
    /// FloatProperty: GrappleBoostHeightFactor
    /// </summary>
    public unsafe float GrappleBoostHeightFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3552); }
    }

    /// <summary>
    /// FloatProperty: MaxGrappleBoostExtraHeightMk3
    /// </summary>
    public unsafe float MaxGrappleBoostExtraHeightMk3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3556); }
    }

    /// <summary>
    /// FloatProperty: MaxGrappleBoostExtraSpeedMk3
    /// </summary>
    public unsafe float MaxGrappleBoostExtraSpeedMk3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3560); }
    }

    /// <summary>
    /// FloatProperty: GrappleBoostHeightFactorMk3
    /// </summary>
    public unsafe float GrappleBoostHeightFactorMk3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3564); }
    }

    /// <summary>
    /// FloatProperty: MaxGrappleBoostExtraHeightMk4
    /// </summary>
    public unsafe float MaxGrappleBoostExtraHeightMk4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3568); }
    }

    /// <summary>
    /// FloatProperty: MaxGrappleBoostExtraSpeedMk4
    /// </summary>
    public unsafe float MaxGrappleBoostExtraSpeedMk4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3572); }
    }

    /// <summary>
    /// FloatProperty: GrappleBoostHeightFactorMk4
    /// </summary>
    public unsafe float GrappleBoostHeightFactorMk4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3576); }
    }

    /// <summary>
    /// IntProperty: GrappleBoostLvl
    /// </summary>
    public unsafe int GrappleBoostLvl
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3580); }
    }

    /// <summary>
    /// FloatProperty: ChainGrappleRange
    /// </summary>
    public unsafe float ChainGrappleRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3584); }
    }

    /// <summary>
    /// ArrayProperty: CheckedGrapplePoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> CheckedGrapplePoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 3588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3588); }
    }

    /// <summary>
    /// StructProperty: CurrentOutwardNormal
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CurrentOutwardNormal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3604); }
    }

    /// <summary>
    /// FloatProperty: GlideStickForwardTilt
    /// </summary>
    public unsafe float GlideStickForwardTilt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3616); }
    }

    /// <summary>
    /// FloatProperty: GlideStickCheckLocationShift
    /// </summary>
    public unsafe float GlideStickCheckLocationShift
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3620); }
    }

    /// <summary>
    /// IntProperty: GrappleFilter
    /// </summary>
    public unsafe int GrappleFilter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3624); }
    }

    /// <summary>
    /// IntProperty: HidePointFilter
    /// </summary>
    public unsafe int HidePointFilter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3628); }
    }

    /// <summary>
    /// StructProperty: PlayerPositionCheckOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PlayerPositionCheckOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3632); }
    }

    /// <summary>
    /// FloatProperty: fDelayedChuteTargetButtonHoldTime
    /// </summary>
    public unsafe float fDelayedChuteTargetButtonHoldTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3644); }
    }

    /// <summary>
    /// FloatProperty: GrappleStiffness
    /// </summary>
    public unsafe float GrappleStiffness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3648); }
    }

    /// <summary>
    /// ArrayProperty: GrappleDodgeAnims
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> GrappleDodgeAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 3652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3652); }
    }
}
