#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAttackPointSearch<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RAttackPointSearch : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAttackPointSearch", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAttackPointSearch() { }

    /// <summary>
    /// Constructs a new RAttackPointSearch
    /// </summary>
    public RAttackPointSearch(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAttackPointSearch Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAttackPointSearch(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: TargetLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT TargetLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// FloatProperty: AttackRadius
    /// </summary>
    public unsafe float AttackRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// ArrayProperty: AttackPointList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>> AttackPointList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ArrayProperty: PossibleAttackPoints
    /// </summary>
    public unsafe BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT> PossibleAttackPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// IntProperty: AttackPointCheckID
    /// </summary>
    public unsafe int AttackPointCheckID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ObjectProperty: NavigationManager
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT NavigationManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// ObjectProperty: PlayerPawn
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// NameProperty: ClaimName
    /// </summary>
    public unsafe BmSDK.FName ClaimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// ByteProperty: CurrState
    /// </summary>
    public unsafe byte CurrState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// ByteProperty: StanceToCheck
    /// </summary>
    public unsafe byte StanceToCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 161); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 161); }
    }

    /// <summary>
    /// ArrayProperty: PylonList
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT PylonList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// IntProperty: VisCheckIndex
    /// </summary>
    public unsafe int VisCheckIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// FloatProperty: SubDivideSizeTarget
    /// </summary>
    public unsafe float SubDivideSizeTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }

    /// <summary>
    /// BoolProperty: bAutoAdjustToFloor
    /// </summary>
    public unsafe bool bAutoAdjustToFloor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 188) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 188); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 188); }
    }

    /// <summary>
    /// BoolProperty: bAdjustHeightForHumanTargetSize
    /// </summary>
    public unsafe bool bAdjustHeightForHumanTargetSize
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 188) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 188); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 188); }
    }

    /// <summary>
    /// FloatProperty: SearchStartTime
    /// </summary>
    public unsafe float SearchStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// Struct: FAttackPoint
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FAttackPoint
    {
        /// <summary>
        /// BoolProperty: bCanSeeStandingTarget
        /// </summary>
        public unsafe bool bCanSeeStandingTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bCanSeeCrouchingTarget
        /// </summary>
        public unsafe bool bCanSeeCrouchingTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Location
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Location
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }
}
