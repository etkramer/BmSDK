#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: GameStateObject<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class GameStateObject : BmSDK.Engine.GameplayEventsHandler, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.GameStateObject", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal GameStateObject() { }

    /// <summary>
    /// Constructs a new GameStateObject
    /// </summary>
    public GameStateObject(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GameStateObject Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GameStateObject(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: TeamStates
    /// </summary>
    public unsafe BmSDK.GameObject.FArray_Mirror TeamStates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FArray_Mirror>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// StructProperty: PlayerStates
    /// </summary>
    public unsafe BmSDK.GameObject.FArray_Mirror PlayerStates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FArray_Mirror>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ByteProperty: SessionType
    /// </summary>
    public unsafe BmSDK.Engine.GameStateObject.GameSessionType SessionType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameStateObject.GameSessionType>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// BoolProperty: bIsMatchStarted
    /// </summary>
    public unsafe bool bIsMatchStarted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bIsRoundStarted
    /// </summary>
    public unsafe bool bIsRoundStarted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// IntProperty: RoundNumber
    /// </summary>
    public unsafe int RoundNumber
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// IntProperty: MaxRoundNumber
    /// </summary>
    public unsafe int MaxRoundNumber
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// Struct: FTeamState
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FTeamState
    {
        /// <summary>
        /// IntProperty: TeamIndex
        /// </summary>
        public unsafe int TeamIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: PlayerIndices
        /// </summary>
        public unsafe BmSDK.TArray<int> PlayerIndices
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Enum: GameSessionType
    /// </summary>
    public enum GameSessionType
    {
        GT_SessionInvalid = 0,
        GT_SinglePlayer = 1,
        GT_Coop = 2,
        GT_Multiplayer = 3,
        GT_MAX = 4,
    }
}
