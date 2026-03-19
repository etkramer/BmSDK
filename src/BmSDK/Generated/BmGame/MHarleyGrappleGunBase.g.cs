#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MHarleyGrappleGunBase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MHarleyGrappleGunBase : BmSDK.BmGame.RGrappleGun, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MHarleyGrappleGunBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MHarleyGrappleGunBase() { }

    /// <summary>
    /// Constructs a new MHarleyGrappleGunBase
    /// </summary>
    public MHarleyGrappleGunBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MHarleyGrappleGunBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MHarleyGrappleGunBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MHarleyGrappleGunBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MHarleyGrappleGunBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MHarleyGrappleGunBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MHarleyGrappleGunBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MHarleyGrappleGunBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MHarleyGrappleGunBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MHarleyGrappleGunBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: PounceToLedgeMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PounceToLedgeMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3668); }
    }

    /// <summary>
    /// ObjectProperty: JumpPounceToLedgeMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT JumpPounceToLedgeMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3676); }
    }

    /// <summary>
    /// FloatProperty: PounceCheckOut
    /// </summary>
    public unsafe float PounceCheckOut
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3684); }
    }

    /// <summary>
    /// StructProperty: PounceCheckExtent
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PounceCheckExtent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3688); }
    }

    /// <summary>
    /// FloatProperty: PounceCheckMaxDeltaZ
    /// </summary>
    public unsafe float PounceCheckMaxDeltaZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3700); }
    }

    /// <summary>
    /// FloatProperty: PounceUpFromFloorMinDistance
    /// </summary>
    public unsafe float PounceUpFromFloorMinDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3704); }
    }

    /// <summary>
    /// FloatProperty: PounceUpFromFloorMaxDistance
    /// </summary>
    public unsafe float PounceUpFromFloorMaxDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3708); }
    }

    /// <summary>
    /// FloatProperty: PounceUpFromLedgeMinDistance
    /// </summary>
    public unsafe float PounceUpFromLedgeMinDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3712); }
    }

    /// <summary>
    /// FloatProperty: PounceUpFromLedgeMaxDistance
    /// </summary>
    public unsafe float PounceUpFromLedgeMaxDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3716); }
    }

    /// <summary>
    /// FloatProperty: PounceDownMinDistance
    /// </summary>
    public unsafe float PounceDownMinDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3720); }
    }

    /// <summary>
    /// FloatProperty: PounceDownMaxDistance
    /// </summary>
    public unsafe float PounceDownMaxDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3724); }
    }

    /// <summary>
    /// FloatProperty: PounceFlatMinDistance
    /// </summary>
    public unsafe float PounceFlatMinDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3728); }
    }

    /// <summary>
    /// FloatProperty: PounceFlatMaxDistance
    /// </summary>
    public unsafe float PounceFlatMaxDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3732); }
    }

    /// <summary>
    /// FloatProperty: PounceFlatMaxShortJumpDistance
    /// </summary>
    public unsafe float PounceFlatMaxShortJumpDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3736); }
    }

    /// <summary>
    /// FloatProperty: PounceFlatMaxMidJumpDistance
    /// </summary>
    public unsafe float PounceFlatMaxMidJumpDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3740); }
    }

    /// <summary>
    /// FloatProperty: PounceUpVerticalDistanceMin
    /// </summary>
    public unsafe float PounceUpVerticalDistanceMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3744); }
    }

    /// <summary>
    /// FloatProperty: PounceDownVerticalDistanceMin
    /// </summary>
    public unsafe float PounceDownVerticalDistanceMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3748); }
    }

    /// <summary>
    /// FloatProperty: CartWheelShortFreeSpaceNeeded
    /// </summary>
    public unsafe float CartWheelShortFreeSpaceNeeded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3752); }
    }

    /// <summary>
    /// FloatProperty: CartWheelLongFreeSpaceNeeded
    /// </summary>
    public unsafe float CartWheelLongFreeSpaceNeeded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3756); }
    }

    /// <summary>
    /// FloatProperty: MinDistanceFromWallToJump
    /// </summary>
    public unsafe float MinDistanceFromWallToJump
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3760); }
    }

    /// <summary>
    /// FloatProperty: MaxHorizontalJumpDistance
    /// </summary>
    public unsafe float MaxHorizontalJumpDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3764); }
    }

    /// <summary>
    /// FloatProperty: MaxHorizontalCartWheelShortDistance
    /// </summary>
    public unsafe float MaxHorizontalCartWheelShortDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3768); }
    }

    /// <summary>
    /// FloatProperty: OffsetCorrectionForHighRailing
    /// </summary>
    public unsafe float OffsetCorrectionForHighRailing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3772); }
    }

    /// <summary>
    /// BoolProperty: bPounceCheckDebug
    /// </summary>
    public unsafe bool bPounceCheckDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3776) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3776); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3776); }
    }

    /// <summary>
    /// BoolProperty: bPounceLOSDebug
    /// </summary>
    public unsafe bool bPounceLOSDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3776) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3776); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3776); }
    }

    /// <summary>
    /// BoolProperty: bCanQueueGrapple
    /// </summary>
    public unsafe bool bCanQueueGrapple
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3776) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3776); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3776); }
    }

    /// <summary>
    /// StructProperty: RailingGoingToPoint
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RailingGoingToPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3780); }
    }

    /// <summary>
    /// StructProperty: RailingGoingToNormal
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RailingGoingToNormal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3792); }
    }
}
