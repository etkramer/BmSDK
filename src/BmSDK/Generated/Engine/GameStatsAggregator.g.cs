#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: GameStatsAggregator<br/>
/// (size = 708)
/// (flags = 0)
/// </summary>
public partial class GameStatsAggregator : BmSDK.Engine.GameplayEventsHandler, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.GameStatsAggregator", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal GameStatsAggregator() { }

    /// <summary>
    /// Constructs a new GameStatsAggregator
    /// </summary>
    public GameStatsAggregator(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GameStatsAggregator Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GameStatsAggregator(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetAggregateMappingIDs
    /// </summary>
    public unsafe bool GetAggregateMappingIDs(int EventID, out int AggregateID, out int TargetAggregateID)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameStatsAggregator.GetAggregateMappingIDs", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        AggregateID = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
        TargetAggregateID = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: Reset
    /// </summary>
    public unsafe void Reset()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameStatsAggregator.Reset", true);
        byte* paramsPtr = stackalloc byte[0];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: PostProcessStream
    /// </summary>
    public unsafe void PostProcessStream()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameStatsAggregator.PostProcessStream", true);
        byte* paramsPtr = stackalloc byte[0];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: PreProcessStream
    /// </summary>
    public unsafe void PreProcessStream()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameStatsAggregator.PreProcessStream", true);
        byte* paramsPtr = stackalloc byte[0];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Struct: FAggregateEventMapping
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FAggregateEventMapping
    {
        /// <summary>
        /// IntProperty: EventID
        /// </summary>
        public unsafe int EventID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: AggregateID
        /// </summary>
        public unsafe int AggregateID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: TargetAggregateID
        /// </summary>
        public unsafe int TargetAggregateID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FPlayerEvents
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 512)]
    public partial record struct FPlayerEvents
    {
        /// <summary>
        /// StructProperty: TotalEvents
        /// </summary>
        public unsafe BmSDK.Engine.GameStatsAggregator.FGameEvents TotalEvents
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameStatsAggregator.FGameEvents>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: WeaponEvents
        /// </summary>
        public unsafe BmSDK.Engine.GameStatsAggregator.FWeaponEvents WeaponEvents
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameStatsAggregator.FWeaponEvents>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }

        /// <summary>
        /// StructProperty: DamageAsPlayerEvents
        /// </summary>
        public unsafe BmSDK.Engine.GameStatsAggregator.FDamageEvents DamageAsPlayerEvents
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameStatsAggregator.FDamageEvents>(Ptr + 160); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }; }
        }

        /// <summary>
        /// StructProperty: DamageAsTargetEvents
        /// </summary>
        public unsafe BmSDK.Engine.GameStatsAggregator.FDamageEvents DamageAsTargetEvents
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameStatsAggregator.FDamageEvents>(Ptr + 248); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }; }
        }

        /// <summary>
        /// StructProperty: ProjectileEvents
        /// </summary>
        public unsafe BmSDK.Engine.GameStatsAggregator.FProjectileEvents ProjectileEvents
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameStatsAggregator.FProjectileEvents>(Ptr + 336); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }; }
        }

        /// <summary>
        /// StructProperty: PawnEvents
        /// </summary>
        public unsafe BmSDK.Engine.GameStatsAggregator.FPawnEvents PawnEvents
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameStatsAggregator.FPawnEvents>(Ptr + 424); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }; }
        }
    }

    /// <summary>
    /// Struct: FTeamEvents
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 512)]
    public partial record struct FTeamEvents
    {
        /// <summary>
        /// StructProperty: TotalEvents
        /// </summary>
        public unsafe BmSDK.Engine.GameStatsAggregator.FGameEvents TotalEvents
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameStatsAggregator.FGameEvents>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: WeaponEvents
        /// </summary>
        public unsafe BmSDK.Engine.GameStatsAggregator.FWeaponEvents WeaponEvents
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameStatsAggregator.FWeaponEvents>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }

        /// <summary>
        /// StructProperty: DamageAsPlayerEvents
        /// </summary>
        public unsafe BmSDK.Engine.GameStatsAggregator.FDamageEvents DamageAsPlayerEvents
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameStatsAggregator.FDamageEvents>(Ptr + 160); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }; }
        }

        /// <summary>
        /// StructProperty: DamageAsTargetEvents
        /// </summary>
        public unsafe BmSDK.Engine.GameStatsAggregator.FDamageEvents DamageAsTargetEvents
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameStatsAggregator.FDamageEvents>(Ptr + 248); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }; }
        }

        /// <summary>
        /// StructProperty: ProjectileEvents
        /// </summary>
        public unsafe BmSDK.Engine.GameStatsAggregator.FProjectileEvents ProjectileEvents
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameStatsAggregator.FProjectileEvents>(Ptr + 336); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }; }
        }

        /// <summary>
        /// StructProperty: PawnEvents
        /// </summary>
        public unsafe BmSDK.Engine.GameStatsAggregator.FPawnEvents PawnEvents
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameStatsAggregator.FPawnEvents>(Ptr + 424); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }; }
        }
    }

    /// <summary>
    /// Struct: FPawnEvents
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public partial record struct FPawnEvents
    {
    }

    /// <summary>
    /// Struct: FDamageEvents
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public partial record struct FDamageEvents
    {
    }

    /// <summary>
    /// Struct: FProjectileEvents
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public partial record struct FProjectileEvents
    {
    }

    /// <summary>
    /// Struct: FWeaponEvents
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public partial record struct FWeaponEvents
    {
    }

    /// <summary>
    /// Struct: FEventsBase
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public partial record struct FEventsBase
    {
        /// <summary>
        /// StructProperty: TotalEvents
        /// </summary>
        public unsafe BmSDK.Engine.GameStatsAggregator.FGameEvents TotalEvents
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameStatsAggregator.FGameEvents>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: EventsByClass
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.GameStatsAggregator.FGameEvents> EventsByClass
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.GameStatsAggregator.FGameEvents>>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }
    }

    /// <summary>
    /// Struct: FGameEvents
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial record struct FGameEvents
    {
        /// <summary>
        /// StructProperty: Events
        /// </summary>
        public unsafe BmSDK.GameObject.FMap_Mirror Events
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FMap_Mirror>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Struct: FGameEvent
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FGameEvent
    {
        /// <summary>
        /// ArrayProperty: EventCountByTimePeriod
        /// </summary>
        public unsafe BmSDK.TArray<float> EventCountByTimePeriod
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// ObjectProperty: GameState
    /// </summary>
    public unsafe BmSDK.Engine.GameStateObject GameState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameStateObject>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ArrayProperty: AggregatesList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.GameStatsAggregator.FAggregateEventMapping> AggregatesList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.GameStatsAggregator.FAggregateEventMapping>>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// StructProperty: AggregateEventsMapping
    /// </summary>
    public unsafe BmSDK.GameObject.FMap_Mirror AggregateEventsMapping
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FMap_Mirror>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ArrayProperty: AggregateEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.GameplayEvents.FGameplayEventMetaData> AggregateEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.GameplayEvents.FGameplayEventMetaData>>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// ArrayProperty: AggregatesFound
    /// </summary>
    public unsafe BmSDK.TArray<int> AggregatesFound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// StructProperty: AllGameEvents
    /// </summary>
    public unsafe BmSDK.Engine.GameStatsAggregator.FGameEvents AllGameEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameStatsAggregator.FGameEvents>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// ArrayProperty: AllTeamEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.GameStatsAggregator.FTeamEvents> AllTeamEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.GameStatsAggregator.FTeamEvents>>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// ArrayProperty: AllPlayerEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.GameStatsAggregator.FPlayerEvents> AllPlayerEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.GameStatsAggregator.FPlayerEvents>>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }

    /// <summary>
    /// StructProperty: AllWeaponEvents
    /// </summary>
    public unsafe BmSDK.Engine.GameStatsAggregator.FWeaponEvents AllWeaponEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameStatsAggregator.FWeaponEvents>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// StructProperty: AllProjectileEvents
    /// </summary>
    public unsafe BmSDK.Engine.GameStatsAggregator.FProjectileEvents AllProjectileEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameStatsAggregator.FProjectileEvents>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// StructProperty: AllPawnEvents
    /// </summary>
    public unsafe BmSDK.Engine.GameStatsAggregator.FPawnEvents AllPawnEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameStatsAggregator.FPawnEvents>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// StructProperty: AllDamageEvents
    /// </summary>
    public unsafe BmSDK.Engine.GameStatsAggregator.FDamageEvents AllDamageEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameStatsAggregator.FDamageEvents>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

}
