#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: CoverLink<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class CoverLink : BmSDK.Engine.NavigationPoint, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.CoverLink", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal CoverLink() { }

    /// <summary>
    /// Constructs a new CoverLink
    /// </summary>
    public CoverLink(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, CoverLink Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected CoverLink(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<CoverLink>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<CoverLink>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<CoverLink>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<CoverLink>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<CoverLink>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<CoverLink>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<CoverLink>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// BoolProperty: GLOBAL_bUseSlotMarkers
    /// </summary>
    public unsafe bool GLOBAL_bUseSlotMarkers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bDisabled
    /// </summary>
    public unsafe bool bDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bClaimAllSlots
    /// </summary>
    public unsafe bool bClaimAllSlots
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bAutoSort
    /// </summary>
    public unsafe bool bAutoSort
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bAutoAdjust
    /// </summary>
    public unsafe bool bAutoAdjust
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bCircular
    /// </summary>
    public unsafe bool bCircular
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bLooped
    /// </summary>
    public unsafe bool bLooped
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bPlayerOnly
    /// </summary>
    public unsafe bool bPlayerOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bDynamicCover
    /// </summary>
    public unsafe bool bDynamicCover
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bFractureOnTouch
    /// </summary>
    public unsafe bool bFractureOnTouch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bDebug_FireLinks
    /// </summary>
    public unsafe bool bDebug_FireLinks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bDebug_ExposedLinks
    /// </summary>
    public unsafe bool bDebug_ExposedLinks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bDebug_CoverGen
    /// </summary>
    public unsafe bool bDebug_CoverGen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bDoAutoSlotDensityFixup
    /// </summary>
    public unsafe bool bDoAutoSlotDensityFixup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 944); }
    }

    /// <summary>
    /// FloatProperty: LeanTraceDist
    /// </summary>
    public unsafe float LeanTraceDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// ArrayProperty: Slots
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>>>>> Slots
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>>>>>>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// ArrayProperty: DynamicLinkInfos
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>>>> DynamicLinkInfos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>>>>>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// ArrayProperty: Claims
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>>> Claims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>>>>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// FloatProperty: InvalidateDistance
    /// </summary>
    public unsafe float InvalidateDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// FloatProperty: MaxFireLinkDist
    /// </summary>
    public unsafe float MaxFireLinkDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }

    /// <summary>
    /// StructProperty: CircularOrigin
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CircularOrigin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// FloatProperty: CircularRadius
    /// </summary>
    public unsafe float CircularRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// FloatProperty: AlignDist
    /// </summary>
    public unsafe float AlignDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// FloatProperty: AutoCoverSlotInterval
    /// </summary>
    public unsafe float AutoCoverSlotInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// FloatProperty: StandHeight
    /// </summary>
    public unsafe float StandHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// FloatProperty: MidHeight
    /// </summary>
    public unsafe float MidHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// StructProperty: StandingLeanOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT StandingLeanOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// StructProperty: CrouchLeanOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CrouchLeanOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }

    /// <summary>
    /// StructProperty: PopupOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PopupOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }

    /// <summary>
    /// FloatProperty: SlipDist
    /// </summary>
    public unsafe float SlipDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// FloatProperty: TurnDist
    /// </summary>
    public unsafe float TurnDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// FloatProperty: DangerScale
    /// </summary>
    public unsafe float DangerScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }

    /// <summary>
    /// ObjectProperty: NextCoverLink
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT NextCoverLink
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// ByteProperty: LocationDescription
    /// </summary>
    public unsafe byte LocationDescription
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }
}
