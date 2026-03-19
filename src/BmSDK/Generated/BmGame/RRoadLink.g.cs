#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RRoadLink<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RRoadLink : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RRoadLink", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RRoadLink() { }

    /// <summary>
    /// Constructs a new RRoadLink
    /// </summary>
    public RRoadLink(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RRoadLink Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RRoadLink(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRoadLink>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRoadLink>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRoadLink>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRoadLink>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRoadLink>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRoadLink>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRoadLink>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: Points
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Points_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }
    /// <summary>
    /// ObjectProperty: Points
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Points_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// ObjectProperty: SpriteMain
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SpriteMain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// ObjectProperty: SpriteNotMain
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SpriteNotMain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// ObjectProperty: SpriteArmoured
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SpriteArmoured
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// ObjectProperty: RoadNetwork
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RoadNetwork
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// ComponentProperty: SpriteComp
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SpriteComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// StructProperty: Lanes
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Lanes_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }
    /// <summary>
    /// StructProperty: Lanes
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Lanes_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// StructProperty: AltLanes
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AltLanes_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }
    /// <summary>
    /// StructProperty: AltLanes
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AltLanes_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// FloatProperty: Camber
    /// </summary>
    public unsafe float Camber
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: LanesSeparatedByBarrier
    /// </summary>
    public unsafe bool LanesSeparatedByBarrier
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 904); }
    }

    /// <summary>
    /// BoolProperty: ObstaclesBetweenLanes
    /// </summary>
    public unsafe bool ObstaclesBetweenLanes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 904); }
    }

    /// <summary>
    /// BoolProperty: IsJump
    /// </summary>
    public unsafe bool IsJump
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 904); }
    }

    /// <summary>
    /// BoolProperty: IsMainRoad
    /// </summary>
    public unsafe bool IsMainRoad
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 904); }
    }

    /// <summary>
    /// BoolProperty: IsArmouredRoad
    /// </summary>
    public unsafe bool IsArmouredRoad
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 904); }
    }

    /// <summary>
    /// BoolProperty: IsDisabled
    /// </summary>
    public unsafe bool IsDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 904); }
    }

    /// <summary>
    /// BoolProperty: IsSharpTurn
    /// </summary>
    public unsafe bool IsSharpTurn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 904); }
    }

    /// <summary>
    /// BoolProperty: IsStairs
    /// </summary>
    public unsafe bool IsStairs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 904); }
    }

    /// <summary>
    /// BoolProperty: NoUturns
    /// </summary>
    public unsafe bool NoUturns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 904); }
    }

    /// <summary>
    /// BoolProperty: NoSkip
    /// </summary>
    public unsafe bool NoSkip
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 904); }
    }

    /// <summary>
    /// BoolProperty: CantCallBatmobile
    /// </summary>
    public unsafe bool CantCallBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 904); }
    }

    /// <summary>
    /// BoolProperty: CantSatNav
    /// </summary>
    public unsafe bool CantSatNav
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 904); }
    }

    /// <summary>
    /// BoolProperty: OnlySatNav
    /// </summary>
    public unsafe bool OnlySatNav
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 904); }
    }

    /// <summary>
    /// BoolProperty: IsUnderGround
    /// </summary>
    public unsafe bool IsUnderGround
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 904); }
    }

    /// <summary>
    /// BoolProperty: OnlyFriendly
    /// </summary>
    public unsafe bool OnlyFriendly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 904); }
    }

    /// <summary>
    /// BoolProperty: CantSpawn
    /// </summary>
    public unsafe bool CantSpawn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 904); }
    }

    /// <summary>
    /// BoolProperty: ThugsCannotFlee
    /// </summary>
    public unsafe bool ThugsCannotFlee
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 904); }
    }

    /// <summary>
    /// BoolProperty: UseAltLanes
    /// </summary>
    public unsafe bool UseAltLanes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 904); }
    }

    /// <summary>
    /// BoolProperty: NoZBiasOnFindNearestPoint
    /// </summary>
    public unsafe bool NoZBiasOnFindNearestPoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 904); }
    }

    /// <summary>
    /// BoolProperty: IsDoor
    /// </summary>
    public unsafe bool IsDoor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 904); }
    }

    /// <summary>
    /// BoolProperty: CantSpawnBatmobile
    /// </summary>
    public unsafe bool CantSpawnBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 904); }
    }

    /// <summary>
    /// BoolProperty: OnlyStreaming
    /// </summary>
    public unsafe bool OnlyStreaming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 904); }
    }

    /// <summary>
    /// NameProperty: StreetName
    /// </summary>
    public unsafe BmSDK.FName StreetName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// ByteProperty: SatNavInLane
    /// </summary>
    public unsafe byte SatNavInLane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// ArrayProperty: RoadNetworkLinkIndices
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>> RoadNetworkLinkIndices
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }

    /// <summary>
    /// Struct: FLane
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FLane
    {
        /// <summary>
        /// BoolProperty: Usable
        /// </summary>
        public unsafe bool Usable
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: SeaWall
        /// </summary>
        public unsafe bool SeaWall
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Start
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Start
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: End
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT End
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Struct: FLaneInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FLaneInfo
    {
        /// <summary>
        /// FloatProperty: InnerDistance
        /// </summary>
        public unsafe float InnerDistance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: LaneWidth
        /// </summary>
        public unsafe float LaneWidth
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: FootpathWidth
        /// </summary>
        public unsafe float FootpathWidth
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: MaxHeadroom
        /// </summary>
        public unsafe float MaxHeadroom
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: SeaWallWidth
        /// </summary>
        public unsafe float SeaWallWidth
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }
}
