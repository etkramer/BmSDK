#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RVehicleScenario<br/>
/// (flags = 0)
/// </summary>
public partial class RVehicleScenario : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RVehicleScenario", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RVehicleScenario() { }

    /// <summary>
    /// Constructs a new RVehicleScenario
    /// </summary>
    public RVehicleScenario(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RVehicleScenario Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicleScenario(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetNearestAvailableSpawnPoint
    /// </summary>
    public unsafe bool GetNearestAvailableSpawnPoint(out System.Numerics.Vector3 SpawnLoc, out BmSDK.Rotator SpawnRot, out float RoadWidth, System.Numerics.Vector3 TestLoc, System.Numerics.Vector3 CameraLoc, System.Numerics.Vector3 playerLoc, float MinDistanceFromPlayerLoc, out BmSDK.TArray<System.Numerics.Vector3> AvoidLoc, float MinDistanceFromAvoidLoc, bool ObeyExclusionZones, BmSDK.BmGame.RGameInfo.EDistrict SpawnInDistrict = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleScenario.GetNearestAvailableSpawnPoint", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestLoc, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraLoc, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(playerLoc, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinDistanceFromPlayerLoc, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinDistanceFromAvoidLoc, paramsPtr + 84);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObeyExclusionZones, paramsPtr + 88);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnInDistrict, paramsPtr + 92);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        SpawnLoc = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        SpawnRot = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 12);
        RoadWidth = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 24);
        AvoidLoc = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(paramsPtr + 68);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 96);
    }

    /// <summary>
    /// Function: DestroyVehicles
    /// </summary>
    public unsafe static bool DestroyVehicles(out BmSDK.TArray<BmSDK.BmGame.RVehicleNPC> VehiclesIn, System.Numerics.Vector3 CameraLoc, float MinDistanceFromCameraLoc, float MinTimeHidden)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleScenario.DestroyVehicles", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraLoc, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinDistanceFromCameraLoc, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinTimeHidden, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        VehiclesIn = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleNPC>>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 36);
    }

    /// <summary>
    /// Function: SpawnScenarioVehicle
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleNPC SpawnScenarioVehicle(System.Numerics.Vector3 SpawnLoc, BmSDK.Rotator SpawnRot, float RoadWidth, BmSDK.TArray<BmSDK.Engine.Volume> BehaviourVolumes, BmSDK.BmGame.RPatrolPoint PatrolRoute, bool ObeyExclusionZones, int Index, BmSDK.TArray<BmSDK.BmGame.RVehicleNPC> SpawnedVehicles)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleScenario.SpawnScenarioVehicle", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnRot, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RoadWidth, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BehaviourVolumes, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PatrolRoute, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObeyExclusionZones, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnedVehicles, paramsPtr + 60);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPC>(paramsPtr + 76);
    }

    /// <summary>
    /// Function: SpawnInstanceEx
    /// </summary>
    public unsafe bool SpawnInstanceEx(System.Numerics.Vector3 SpawnLoc, BmSDK.Rotator SpawnRot, System.Numerics.Vector3 CameraLoc, System.Numerics.Vector3 playerLoc, float MinDistanceFromPlayerLoc, out BmSDK.TArray<System.Numerics.Vector3> AvoidLoc, float MinDistanceFromAvoidLoc, out BmSDK.TArray<BmSDK.BmGame.RVehicleNPC> VehiclesOut, out BmSDK.TArray<BmSDK.Engine.Volume> BehaviourVolumes, BmSDK.BmGame.RPatrolPoint PatrolRoute, bool bForceSpawnLocation, bool ObeyExclusionZones, BmSDK.BmGame.RGameInfo.EDistrict SpawnInDistrict = default, BmSDK.BmGame.RVehicleNPC.EVehicleSpawnType SpawnType = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleScenario.SpawnInstanceEx", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnRot, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraLoc, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(playerLoc, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinDistanceFromPlayerLoc, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinDistanceFromAvoidLoc, paramsPtr + 68);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PatrolRoute, paramsPtr + 104);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceSpawnLocation, paramsPtr + 112);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObeyExclusionZones, paramsPtr + 116);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnInDistrict, paramsPtr + 120);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnType, paramsPtr + 121);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        AvoidLoc = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(paramsPtr + 52);
        VehiclesOut = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleNPC>>(paramsPtr + 72);
        BehaviourVolumes = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Volume>>(paramsPtr + 88);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 124);
    }

    /// <summary>
    /// Function: SpawnInstance
    /// </summary>
    public unsafe bool SpawnInstance(System.Numerics.Vector3 SpawnLoc, BmSDK.Rotator SpawnRot, System.Numerics.Vector3 CameraLoc, System.Numerics.Vector3 playerLoc, float MinDistanceFromPlayerLoc, out BmSDK.TArray<BmSDK.BmGame.RVehicleNPC> VehiclesOut, bool bForceSpawnLocation = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RVehicleScenario.SpawnInstance", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnRot, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraLoc, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(playerLoc, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinDistanceFromPlayerLoc, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceSpawnLocation, paramsPtr + 68);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        VehiclesOut = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleNPC>>(paramsPtr + 52);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 72);
    }

    /// <summary>
    /// ByteProperty: ScenarioIsPlaceholderFor
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleScenario.VehicleScenarioPlaceholderType ScenarioIsPlaceholderFor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleScenario.VehicleScenarioPlaceholderType>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ArrayProperty: Vehicles
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicleScenario.FScenarioVehicleDesc> Vehicles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleScenario.FScenarioVehicleDesc>>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// BoolProperty: bMilitaryScenario
    /// </summary>
    public unsafe bool bMilitaryScenario
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// Enum: VehicleScenarioPlaceholderType
    /// </summary>
    public enum VehicleScenarioPlaceholderType
    {
        ScenarioPlacheolder_None = 0,
        ScenarioPlacheolder_Formation = 1,
        ScenarioPlacheolder_HeavyDrone = 2,
        ScenarioPlacheolder_MAX = 3,
    }

    /// <summary>
    /// Struct: FScenarioVehicleDesc
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FScenarioVehicleDesc
    {
        /// <summary>
        /// ObjectProperty: VehicleArchetype
        /// </summary>
        public unsafe BmSDK.BmGame.RVehicleNPC VehicleArchetype
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPC>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: VehicleArchetypeRandom
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicleNPC> VehicleArchetypeRandom
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleNPC>>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ObjectProperty: VehicleBehaviour
        /// </summary>
        public unsafe BmSDK.BmGame.RVehicleBehaviour VehicleBehaviour
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBehaviour>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ObjectProperty: OverrideGuardBehaviour
        /// </summary>
        public unsafe BmSDK.BmGame.RVehicleBehaviour OverrideGuardBehaviour
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBehaviour>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// ObjectProperty: OverrideCombatBehaviour
        /// </summary>
        public unsafe BmSDK.BmGame.RVehicleBehaviour OverrideCombatBehaviour
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBehaviour>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// IntProperty: TargetVehicle
        /// </summary>
        public unsafe int TargetVehicle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// FloatProperty: TargetDistance
        /// </summary>
        public unsafe float TargetDistance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// FloatProperty: TargetOffset
        /// </summary>
        public unsafe float TargetOffset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// ArrayProperty: Passengers
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicleScenario.FScenarioPassengerDesc> Passengers
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleScenario.FScenarioPassengerDesc>>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// BoolProperty: IsPartyCar
        /// </summary>
        public unsafe bool IsPartyCar
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }; }
        }

        /// <summary>
        /// FloatProperty: MassScale
        /// </summary>
        public unsafe float MassScale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }

        /// <summary>
        /// BoolProperty: ReturnToPatrolWhenPlayerLost
        /// </summary>
        public unsafe bool ReturnToPatrolWhenPlayerLost
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 84); }; }
        }

        /// <summary>
        /// BoolProperty: DontShowOnRadar
        /// </summary>
        public unsafe bool DontShowOnRadar
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 84); }; }
        }
    }

    /// <summary>
    /// Struct: FScenarioPassengerDesc
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FScenarioPassengerDesc
    {
        /// <summary>
        /// IntProperty: SeatIndex
        /// </summary>
        public unsafe int SeatIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: Passenger
        /// </summary>
        public unsafe BmSDK.BmGame.RBmPawnSpawner Passenger
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBmPawnSpawner>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: ChanceOfNotBeingSpawned
        /// </summary>
        public unsafe int ChanceOfNotBeingSpawned
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ByteProperty: IdleAnimType
        /// </summary>
        public unsafe BmSDK.BmGame.RVehicleNPC.VehiclePassengerIdleType IdleAnimType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPC.VehiclePassengerIdleType>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StructProperty: IdleAnimCustom
        /// </summary>
        public unsafe BmSDK.BmGame.RVehicleNPC.FVehiclePassengerIdleInfo IdleAnimCustom
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPC.FVehiclePassengerIdleInfo>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }
}
