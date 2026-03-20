#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RObjectPool<br/>
/// (flags = 0)
/// </summary>
public partial class RObjectPool : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RObjectPool", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RObjectPool() { }

    /// <summary>
    /// Constructs a new RObjectPool
    /// </summary>
    public RObjectPool(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RObjectPool Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RObjectPool(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetMaxDamageInstances
    /// </summary>
    public unsafe int GetMaxDamageInstances()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.RObjectPool.GetMaxDamageInstances", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetDamageInstanceIndex
    /// </summary>
    public unsafe int GetDamageInstanceIndex(BmSDK.Engine.Actor ImpactActor, System.Numerics.Vector3 ImpactLocation, float Radius)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.RObjectPool.GetDamageInstanceIndex", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ImpactActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ImpactLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Radius, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: Initialise
    /// </summary>
    public unsafe void Initialise(BmSDK.Engine.GameReplicationInfo Game)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.RObjectPool.Initialise", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Game, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CreateDecal
    /// </summary>
    public unsafe BmSDK.Engine.RockDecalComponent CreateDecal()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.RObjectPool.CreateDecal", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: AddDecal
    /// </summary>
    public unsafe BmSDK.Engine.RockDecalComponent AddDecal(BmSDK.Engine.MaterialInterface DecalMaterial, System.Numerics.Vector3 DecalLocation, System.Numerics.Vector3 DecalNormal, float DecalRoll, float DecalWidth, float DecalHeight, BmSDK.Engine.Actor HitActor, BmSDK.Engine.PrimitiveComponent HitComponent, BmSDK.FName HitBone = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.RObjectPool.AddDecal", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DecalMaterial, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DecalLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DecalNormal, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DecalRoll, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DecalWidth, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DecalHeight, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitActor, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitComponent, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitBone, paramsPtr + 60);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(paramsPtr + 68);
    }

    /// <summary>
    /// Function: GetSpawnedDecalDepth
    /// </summary>
    public unsafe float GetSpawnedDecalDepth()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.RObjectPool.GetSpawnedDecalDepth", true);
        byte* paramsPtr = stackalloc byte[64];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetUnscaledDecalMatrix
    /// </summary>
    public unsafe BmSDK.GameObject.FMatrix GetUnscaledDecalMatrix(System.Numerics.Vector3 Location, BmSDK.Rotator Rotation, float Roll)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.RObjectPool.GetUnscaledDecalMatrix", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Location, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rotation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Roll, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FMatrix>(paramsPtr + 32);
    }

    /// <summary>
    /// Function: GetDecalMatrix
    /// </summary>
    public unsafe BmSDK.GameObject.FMatrix GetDecalMatrix(System.Numerics.Vector3 Location, BmSDK.Rotator Rotation, float Roll, float Width, float Height, float Depth)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.RObjectPool.GetDecalMatrix", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Location, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rotation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Roll, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Width, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Height, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Depth, paramsPtr + 36);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FMatrix>(paramsPtr + 48);
    }

    /// <summary>
    /// Function: GetDecalClipValuesFromScale
    /// </summary>
    public unsafe System.Numerics.Vector3 GetDecalClipValuesFromScale(float Width, float Height, float Depth)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.RObjectPool.GetDecalClipValuesFromScale", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Width, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Height, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Depth, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: GetFreeDecal
    /// </summary>
    public unsafe BmSDK.Engine.RockDecalComponent GetFreeDecal()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.RObjectPool.GetFreeDecal", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: EnlargeNearbyDecal
    /// </summary>
    public unsafe BmSDK.Engine.RockDecalComponent EnlargeNearbyDecal(BmSDK.Engine.MaterialInterface DecalMaterial, System.Numerics.Vector3 DecalLocation, float DecalWidth, float DecalHeight, BmSDK.Engine.Actor HitActor)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.RObjectPool.EnlargeNearbyDecal", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DecalMaterial, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DecalLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DecalWidth, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DecalHeight, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitActor, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(paramsPtr + 36);
    }

    /// <summary>
    /// Function: SpawnEmitterOnSocket
    /// </summary>
    public unsafe BmSDK.Engine.Emitter SpawnEmitterOnSocket(BmSDK.Engine.ParticleSystem Tamplate, BmSDK.Engine.SkeletalMeshComponent Skeleton, BmSDK.FName SocketName, bool bAttachToMesh = default, float DrawScale = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.RObjectPool.SpawnEmitterOnSocket", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Tamplate, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Skeleton, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SocketName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAttachToMesh, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DrawScale, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Emitter>(paramsPtr + 32);
    }

    /// <summary>
    /// Function: SpawnEmitterOnMesh
    /// </summary>
    public unsafe BmSDK.Engine.Emitter SpawnEmitterOnMesh(BmSDK.Engine.ParticleSystem Template, System.Numerics.Vector3 SpawnLocation, BmSDK.Rotator SpawnRotation, BmSDK.Engine.SkeletalMeshComponent Skeleton = default, BmSDK.FName Bone = default, bool HardAttach = default, float DrawScale = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.RObjectPool.SpawnEmitterOnMesh", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Template, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnRotation, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Skeleton, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Bone, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HardAttach, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DrawScale, paramsPtr + 52);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Emitter>(paramsPtr + 56);
    }

    /// <summary>
    /// Function: SpawnEmitterOnPawn
    /// </summary>
    public unsafe BmSDK.Engine.Emitter SpawnEmitterOnPawn(BmSDK.Engine.ParticleSystem Template, System.Numerics.Vector3 SpawnLocation, BmSDK.Rotator SpawnRotation, BmSDK.Engine.Pawn P = default, BmSDK.FName Bone = default, bool HardAttach = default, float DrawScale = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.RObjectPool.SpawnEmitterOnPawn", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Template, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnRotation, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Bone, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HardAttach, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DrawScale, paramsPtr + 52);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Emitter>(paramsPtr + 56);
    }

    /// <summary>
    /// Function: SpawnEmitter
    /// </summary>
    public unsafe BmSDK.Engine.Emitter SpawnEmitter(BmSDK.Engine.ParticleSystem Template, System.Numerics.Vector3 SpawnLocation, BmSDK.Rotator SpawnRotation, int TranslucencySortPriority = default, float DrawScale = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.RObjectPool.SpawnEmitter", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Template, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnRotation, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TranslucencySortPriority, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DrawScale, paramsPtr + 36);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Emitter>(paramsPtr + 40);
    }

    /// <summary>
    /// Function: StopEmittersWithTemplate
    /// </summary>
    public unsafe void StopEmittersWithTemplate(BmSDK.Engine.ParticleSystem Template)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.RObjectPool.StopEmittersWithTemplate", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Template, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FRAdvancedDamageInstance
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FRAdvancedDamageInstance
    {
        /// <summary>
        /// FloatProperty: CurrentHealth
        /// </summary>
        public unsafe float CurrentHealth
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: CurrentDestructionStage
        /// </summary>
        public unsafe int CurrentDestructionStage
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ComponentProperty: OngoingEffect
        /// </summary>
        public unsafe BmSDK.Engine.ParticleSystemComponent OngoingEffect
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ComponentProperty: OngoingDecal
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent OngoingDecal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ObjectProperty: ImpactActor
        /// </summary>
        public unsafe BmSDK.Engine.Actor ImpactActor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// StructProperty: ImpactLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 ImpactLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }
    }

    /// <summary>
    /// Struct: FRDecalPool
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FRDecalPool
    {
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_3
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_4
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_5
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_6
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_7
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_8
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_9
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_10
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_11
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 88); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_12
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 96); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_13
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 104); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_14
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 112); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_15
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 120); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_16
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 128); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_17
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 136); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_18
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 144); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_19
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 152); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_20
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 160); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_21
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 168); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_22
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 176); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_23
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 184); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_24
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 192); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_25
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 200); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_26
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 208); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_27
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 216); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_28
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 224); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_29
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 232); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_30
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 240); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_31
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 248); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_32
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 256); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_33
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 264); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_34
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 272); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_35
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 280); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_36
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 288); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_37
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 296); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_38
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 304); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_39
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 312); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_40
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 320); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_41
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 328); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_42
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 336); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_43
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 344); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 344); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_44
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 352); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_45
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 360); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_46
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 368); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_47
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 376); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_48
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 384); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_49
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 392); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_50
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 400); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_51
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 408); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_52
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 416); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_53
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 424); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_54
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 432); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_55
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 440); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_56
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 448); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_57
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 456); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_58
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 464); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_59
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 472); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_60
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 480); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_61
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 488); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_62
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 496); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_63
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 504); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_64
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 512); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_65
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 520); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_66
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 528); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_67
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 536); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_68
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 544); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_69
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 552); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_70
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 560); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_71
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 568); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_72
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 576); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_73
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 584); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_74
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 592); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_75
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 600); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_76
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 608); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_77
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 616); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_78
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 624); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_79
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 632); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_80
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 640); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_81
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 648); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_82
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 656); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_83
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 664); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_84
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 672); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_85
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 680); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_86
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 688); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_87
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 696); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_88
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 704); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_89
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 712); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_90
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 720); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_91
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 728); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_92
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 736); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_93
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 744); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_94
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 752); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_95
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 760); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_96
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 768); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_97
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 776); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_98
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 784); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_99
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 792); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_100
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 800); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_101
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 808); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_102
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 816); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_103
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 824); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_104
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 832); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_105
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 840); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_106
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 848); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_107
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 856); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_108
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 864); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_109
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 872); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_110
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 880); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_111
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 888); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_112
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 896); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_113
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 904); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_114
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 912); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_115
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 920); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_116
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 928); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_117
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 936); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_118
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 944); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_119
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 952); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_120
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 960); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_121
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 968); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_122
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 976); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_123
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 984); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_124
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 992); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_125
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1000); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_126
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1008); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_127
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1016); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_128
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1024); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_129
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1032); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_130
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1040); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_131
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1048); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_132
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1056); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_133
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1064); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_134
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1072); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_135
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1080); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_136
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1088); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_137
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1096); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_138
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1104); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_139
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1112); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_140
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1120); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_141
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1128); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_142
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1136); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_143
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1144); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_144
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1152); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_145
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1160); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_146
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1168); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_147
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1176); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_148
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1184); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_149
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1192); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_150
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1200); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1200); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_151
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1208); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1208); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_152
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1216); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1216); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_153
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1224); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1224); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_154
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1232); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1232); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_155
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1240); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_156
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1248); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_157
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1256); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_158
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1264); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1264); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_159
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1272); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1272); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_160
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1280); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1280); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_161
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1288); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1288); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_162
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1296); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1296); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_163
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1304); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1304); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_164
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1312); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1312); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_165
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1320); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1320); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_166
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1328); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1328); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_167
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1336); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1336); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_168
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1344); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1344); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_169
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1352); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1352); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_170
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1360); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1360); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_171
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1368); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1368); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_172
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1376); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1376); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_173
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1384); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1384); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_174
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1392); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1392); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_175
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1400); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1400); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_176
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1408); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1408); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_177
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1416); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1416); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_178
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1424); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1424); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_179
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1432); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1432); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_180
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1440); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1440); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_181
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1448); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1448); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_182
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1456); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1456); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_183
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1464); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1464); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_184
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1472); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1472); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_185
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1480); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1480); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_186
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1488); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1488); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_187
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1496); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1496); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_188
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1504); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1504); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_189
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1512); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1512); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_190
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1520); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1520); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_191
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1528); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1528); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_192
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1536); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1536); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_193
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1544); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1544); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_194
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1552); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1552); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_195
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1560); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1560); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_196
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1568); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1568); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_197
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1576); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1576); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_198
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1584); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1584); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_199
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1592); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1592); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_200
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1600); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1600); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_201
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1608); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1608); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_202
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1616); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1616); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_203
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1624); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1624); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_204
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1632); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1632); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_205
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1640); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1640); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_206
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1648); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1648); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_207
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1656); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1656); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_208
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1664); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1664); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_209
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1672); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1672); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_210
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1680); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1680); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_211
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1688); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1688); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_212
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1696); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1696); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_213
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1704); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1704); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_214
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1712); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1712); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_215
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1720); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1720); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_216
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1728); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1728); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_217
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1736); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1736); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_218
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1744); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1744); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_219
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1752); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1752); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_220
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1760); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1760); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_221
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1768); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1768); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_222
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1776); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1776); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_223
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1784); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1784); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_224
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1792); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1792); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_225
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1800); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1800); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_226
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1808); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1808); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_227
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1816); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1816); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_228
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1824); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1824); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_229
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1832); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1832); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_230
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1840); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1840); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_231
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1848); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1848); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_232
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1856); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1856); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_233
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1864); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1864); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_234
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1872); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1872); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_235
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1880); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1880); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_236
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1888); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1888); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_237
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1896); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1896); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_238
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1904); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1904); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_239
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1912); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1912); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_240
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1920); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1920); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_241
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1928); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1928); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_242
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1936); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1936); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_243
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1944); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1944); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_244
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1952); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1952); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_245
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1960); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1960); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_246
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1968); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1968); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_247
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1976); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1976); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_248
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1984); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1984); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_249
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 1992); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1992); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_250
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2000); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2000); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_251
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2008); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2008); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_252
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2016); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2016); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_253
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2024); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2024); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_254
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2032); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2032); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_255
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2040); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2040); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_256
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2048); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2048); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_257
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2056); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2056); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_258
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2064); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2064); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_259
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2072); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2072); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_260
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2080); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2080); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_261
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2088); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2088); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_262
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2096); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2096); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_263
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2104); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2104); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_264
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2112); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2112); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_265
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2120); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2120); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_266
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2128); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2128); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_267
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2136); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2136); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_268
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2144); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2144); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_269
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2152); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2152); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_270
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2160); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2160); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_271
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2168); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2168); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_272
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2176); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2176); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_273
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2184); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2184); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_274
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2192); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2192); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_275
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2200); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2200); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_276
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2208); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2208); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_277
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2216); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2216); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_278
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2224); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2224); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_279
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2232); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2232); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_280
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2240); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2240); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_281
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2248); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2248); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_282
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2256); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2256); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_283
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2264); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2264); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_284
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2272); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2272); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_285
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2280); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2280); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_286
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2288); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2288); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_287
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2296); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2296); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_288
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2304); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2304); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_289
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2312); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2312); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_290
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2320); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2320); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_291
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2328); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2328); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_292
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2336); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2336); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_293
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2344); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2344); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_294
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2352); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2352); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_295
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2360); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2360); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_296
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2368); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2368); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_297
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2376); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2376); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_298
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2384); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2384); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_299
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2392); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2392); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_300
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2400); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2400); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_301
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2408); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2408); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_302
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2416); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2416); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_303
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2424); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2424); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_304
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2432); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2432); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_305
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2440); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2440); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_306
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2448); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2448); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_307
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2456); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2456); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_308
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2464); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2464); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_309
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2472); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2472); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_310
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2480); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2480); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_311
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2488); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2488); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_312
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2496); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2496); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_313
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2504); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2504); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_314
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2512); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2512); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_315
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2520); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2520); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_316
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2528); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2528); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_317
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2536); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2536); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_318
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2544); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2544); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_319
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2552); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2552); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_320
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2560); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2560); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_321
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2568); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2568); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_322
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2576); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2576); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_323
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2584); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2584); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_324
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2592); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2592); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_325
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2600); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2600); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_326
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2608); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2608); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_327
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2616); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2616); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_328
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2624); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2624); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_329
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2632); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2632); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_330
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2640); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2640); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_331
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2648); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2648); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_332
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2656); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2656); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_333
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2664); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2664); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_334
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2672); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2672); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_335
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2680); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2680); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_336
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2688); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2688); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_337
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2696); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2696); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_338
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2704); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2704); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_339
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2712); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2712); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_340
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2720); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2720); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_341
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2728); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2728); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_342
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2736); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2736); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_343
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2744); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2744); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_344
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2752); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2752); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_345
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2760); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2760); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_346
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2768); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2768); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_347
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2776); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2776); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_348
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2784); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2784); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_349
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2792); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2792); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_350
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2800); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2800); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_351
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2808); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2808); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_352
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2816); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2816); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_353
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2824); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2824); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_354
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2832); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2832); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_355
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2840); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2840); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_356
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2848); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2848); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_357
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2856); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2856); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_358
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2864); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2864); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_359
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2872); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2872); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_360
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2880); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2880); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_361
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2888); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2888); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_362
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2896); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2896); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_363
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2904); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2904); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_364
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2912); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2912); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_365
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2920); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2920); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_366
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2928); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2928); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_367
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2936); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2936); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_368
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2944); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2944); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_369
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2952); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2952); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_370
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2960); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2960); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_371
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2968); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2968); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_372
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2976); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2976); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_373
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2984); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2984); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_374
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 2992); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2992); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_375
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3000); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3000); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_376
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3008); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3008); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_377
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3016); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3016); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_378
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3024); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3024); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_379
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3032); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3032); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_380
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3040); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3040); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_381
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3048); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3048); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_382
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3056); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3056); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_383
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3064); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3064); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_384
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3072); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3072); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_385
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3080); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3080); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_386
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3088); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3088); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_387
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3096); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3096); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_388
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3104); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3104); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_389
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3112); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3112); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_390
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3120); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3120); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_391
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3128); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3128); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_392
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3136); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3136); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_393
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3144); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3144); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_394
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3152); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3152); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_395
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3160); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3160); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_396
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3168); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3168); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_397
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3176); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3176); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_398
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3184); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3184); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_399
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3192); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3192); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_400
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3200); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3200); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_401
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3208); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3208); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_402
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3216); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3216); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_403
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3224); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3224); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_404
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3232); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3232); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_405
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3240); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3240); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_406
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3248); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3248); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_407
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3256); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3256); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_408
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3264); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3264); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_409
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3272); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3272); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_410
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3280); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3280); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_411
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3288); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3288); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_412
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3296); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3296); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_413
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3304); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3304); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_414
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3312); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3312); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_415
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3320); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3320); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_416
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3328); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3328); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_417
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3336); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3336); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_418
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3344); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3344); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_419
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3352); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3352); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_420
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3360); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3360); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_421
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3368); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3368); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_422
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3376); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3376); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_423
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3384); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3384); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_424
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3392); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3392); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_425
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3400); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3400); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_426
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3408); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3408); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_427
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3416); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3416); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_428
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3424); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3424); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_429
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3432); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3432); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_430
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3440); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3440); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_431
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3448); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3448); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_432
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3456); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3456); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_433
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3464); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3464); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_434
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3472); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3472); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_435
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3480); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3480); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_436
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3488); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3488); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_437
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3496); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3496); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_438
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3504); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3504); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_439
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3512); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3512); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_440
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3520); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3520); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_441
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3528); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3528); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_442
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3536); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3536); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_443
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3544); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3544); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_444
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3552); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3552); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_445
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3560); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3560); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_446
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3568); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3568); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_447
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3576); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3576); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_448
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3584); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3584); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_449
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3592); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3592); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_450
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3600); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3600); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_451
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3608); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3608); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_452
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3616); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3616); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_453
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3624); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3624); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_454
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3632); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3632); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_455
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3640); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3640); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_456
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3648); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3648); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_457
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3656); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3656); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_458
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3664); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3664); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_459
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3672); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3672); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_460
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3680); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3680); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_461
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3688); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3688); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_462
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3696); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3696); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_463
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3704); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3704); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_464
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3712); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3712); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_465
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3720); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3720); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_466
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3728); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3728); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_467
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3736); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3736); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_468
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3744); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3744); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_469
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3752); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3752); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_470
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3760); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3760); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_471
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3768); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3768); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_472
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3776); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3776); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_473
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3784); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3784); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_474
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3792); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3792); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_475
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3800); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3800); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_476
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3808); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3808); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_477
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3816); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3816); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_478
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3824); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3824); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_479
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3832); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3832); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_480
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3840); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3840); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_481
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3848); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3848); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_482
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3856); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3856); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_483
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3864); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3864); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_484
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3872); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3872); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_485
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3880); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3880); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_486
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3888); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3888); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_487
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3896); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3896); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_488
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3904); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3904); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_489
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3912); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3912); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_490
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3920); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3920); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_491
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3928); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3928); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_492
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3936); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3936); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_493
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3944); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3944); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_494
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3952); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3952); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_495
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3960); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3960); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_496
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3968); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3968); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_497
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3976); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3976); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_498
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3984); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3984); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_499
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 3992); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3992); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_500
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 4000); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4000); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_501
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 4008); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4008); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_502
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 4016); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4016); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_503
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 4024); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4024); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_504
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 4032); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4032); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_505
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 4040); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4040); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_506
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 4048); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4048); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_507
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 4056); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4056); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_508
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 4064); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4064); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_509
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 4072); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4072); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_510
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 4080); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4080); }; }
        }
        /// <summary>
        /// ComponentProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.RockDecalComponent Pool_511
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockDecalComponent>(Ptr + 4088); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4088); }; }
        }

        /// <summary>
        /// IntProperty: Index
        /// </summary>
        public unsafe int Index
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4096); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4096); }; }
        }
    }

    /// <summary>
    /// StructProperty: Emitters
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FREmitterPool Emitters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FREmitterPool>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// StructProperty: Decals
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRDecalPool Decals
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRDecalPool>(Ptr + 2488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2488); }
    }

    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 6588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6588); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 6632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6632); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 6676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6676); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 6720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6720); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 6764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6764); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 6808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6808); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 6852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6852); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 6896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6896); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 6940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6940); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 6984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6984); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7028); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7072); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7116); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7160); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7204); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7248); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7292); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7336); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7380); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7424); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7468); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7512); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7556); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7600); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7644); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7688); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7732); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7776); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7820); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_29
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7864); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_30
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7908); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_31
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7952); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_32
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7996); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_33
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 8040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8040); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_34
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 8084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8084); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_35
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 8128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8128); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_36
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 8172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8172); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_37
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 8216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8216); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_38
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 8260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8260); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_39
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 8304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8304); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_40
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 8348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8348); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_41
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 8392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8392); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_42
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 8436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8436); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_43
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 8480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8480); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_44
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 8524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8524); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_45
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 8568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8568); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_46
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 8612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8612); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_47
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 8656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8656); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_48
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 8700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8700); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_49
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 8744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8744); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_50
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 8788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8788); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_51
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 8832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8832); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_52
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 8876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8876); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_53
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 8920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8920); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_54
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 8964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8964); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_55
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 9008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9008); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_56
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 9052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9052); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_57
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 9096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9096); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_58
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 9140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9140); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_59
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 9184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9184); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_60
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 9228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9228); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_61
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 9272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9272); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_62
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 9316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9316); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_63
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 9360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9360); }
    }

    /// <summary>
    /// IntProperty: DamageInstancesIndex
    /// </summary>
    public unsafe int DamageInstancesIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 9404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9404); }
    }

    /// <summary>
    /// Struct: FREmitterPool
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FREmitterPool
    {
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_3
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_4
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_5
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_6
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_7
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_8
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_9
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_10
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_11
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 88); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_12
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 96); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_13
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 104); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_14
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 112); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_15
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 120); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_16
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 128); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_17
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 136); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_18
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 144); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_19
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 152); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_20
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 160); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_21
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 168); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_22
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 176); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_23
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 184); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_24
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 192); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_25
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 200); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_26
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 208); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_27
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 216); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_28
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 224); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_29
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 232); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_30
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 240); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_31
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 248); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_32
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 256); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_33
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 264); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_34
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 272); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_35
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 280); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_36
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 288); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_37
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 296); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_38
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 304); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_39
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 312); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_40
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 320); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_41
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 328); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_42
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 336); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_43
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 344); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 344); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_44
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 352); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_45
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 360); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_46
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 368); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_47
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 376); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_48
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 384); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_49
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 392); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_50
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 400); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_51
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 408); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_52
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 416); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_53
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 424); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_54
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 432); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_55
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 440); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_56
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 448); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_57
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 456); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_58
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 464); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_59
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 472); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_60
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 480); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_61
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 488); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_62
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 496); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_63
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 504); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_64
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 512); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_65
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 520); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_66
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 528); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_67
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 536); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_68
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 544); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_69
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 552); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_70
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 560); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_71
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 568); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_72
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 576); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_73
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 584); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_74
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 592); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_75
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 600); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_76
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 608); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_77
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 616); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_78
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 624); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_79
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 632); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_80
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 640); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_81
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 648); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_82
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 656); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_83
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 664); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_84
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 672); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_85
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 680); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_86
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 688); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_87
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 696); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_88
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 704); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_89
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 712); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_90
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 720); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_91
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 728); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_92
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 736); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_93
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 744); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_94
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 752); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_95
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 760); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_96
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 768); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_97
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 776); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_98
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 784); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_99
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 792); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_100
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 800); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_101
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 808); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_102
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 816); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_103
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 824); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_104
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 832); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_105
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 840); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_106
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 848); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_107
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 856); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_108
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 864); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_109
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 872); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_110
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 880); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_111
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 888); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_112
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 896); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_113
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 904); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_114
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 912); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_115
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 920); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_116
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 928); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_117
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 936); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_118
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 944); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_119
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 952); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_120
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 960); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_121
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 968); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_122
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 976); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_123
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 984); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_124
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 992); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_125
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1000); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_126
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1008); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_127
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1016); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_128
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1024); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_129
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1032); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_130
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1040); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_131
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1048); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_132
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1056); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_133
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1064); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_134
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1072); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_135
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1080); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_136
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1088); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_137
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1096); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_138
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1104); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_139
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1112); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_140
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1120); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_141
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1128); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_142
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1136); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_143
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1144); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_144
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1152); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_145
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1160); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_146
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1168); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_147
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1176); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_148
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1184); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_149
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1192); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }; }
        }

        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1200); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1200); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1208); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1208); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1216); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1216); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_3
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1224); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1224); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_4
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1232); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1232); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_5
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1240); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_6
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1248); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_7
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1256); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_8
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1264); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1264); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_9
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1272); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1272); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_10
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1280); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1280); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_11
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1288); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1288); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_12
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1296); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1296); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_13
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1304); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1304); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_14
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1312); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1312); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_15
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1320); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1320); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_16
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1328); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1328); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_17
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1336); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1336); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_18
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1344); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1344); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_19
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1352); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1352); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_20
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1360); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1360); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_21
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1368); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1368); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_22
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1376); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1376); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_23
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1384); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1384); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_24
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1392); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1392); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_25
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1400); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1400); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_26
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1408); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1408); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_27
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1416); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1416); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_28
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1424); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1424); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_29
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1432); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1432); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_30
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1440); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1440); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_31
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1448); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1448); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_32
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1456); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1456); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_33
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1464); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1464); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_34
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1472); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1472); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_35
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1480); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1480); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_36
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1488); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1488); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_37
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1496); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1496); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_38
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1504); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1504); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_39
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1512); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1512); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_40
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1520); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1520); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_41
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1528); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1528); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_42
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1536); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1536); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_43
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1544); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1544); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_44
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1552); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1552); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_45
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1560); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1560); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_46
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1568); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1568); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_47
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1576); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1576); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_48
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1584); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1584); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_49
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1592); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1592); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_50
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1600); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1600); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_51
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1608); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1608); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_52
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1616); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1616); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_53
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1624); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1624); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_54
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1632); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1632); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_55
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1640); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1640); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_56
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1648); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1648); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_57
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1656); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1656); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_58
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1664); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1664); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_59
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1672); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1672); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_60
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1680); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1680); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_61
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1688); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1688); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_62
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1696); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1696); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_63
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1704); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1704); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_64
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1712); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1712); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_65
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1720); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1720); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_66
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1728); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1728); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_67
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1736); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1736); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_68
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1744); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1744); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_69
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1752); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1752); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_70
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1760); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1760); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_71
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1768); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1768); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_72
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1776); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1776); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_73
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1784); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1784); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_74
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1792); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1792); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_75
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1800); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1800); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_76
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1808); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1808); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_77
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1816); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1816); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_78
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1824); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1824); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_79
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1832); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1832); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_80
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1840); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1840); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_81
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1848); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1848); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_82
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1856); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1856); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_83
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1864); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1864); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_84
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1872); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1872); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_85
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1880); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1880); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_86
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1888); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1888); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_87
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1896); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1896); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_88
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1904); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1904); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_89
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1912); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1912); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_90
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1920); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1920); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_91
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1928); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1928); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_92
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1936); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1936); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_93
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1944); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1944); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_94
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1952); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1952); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_95
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1960); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1960); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_96
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1968); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1968); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_97
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1976); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1976); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_98
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1984); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1984); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_99
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1992); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1992); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_100
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2000); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2000); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_101
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2008); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2008); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_102
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2016); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2016); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_103
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2024); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2024); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_104
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2032); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2032); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_105
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2040); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2040); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_106
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2048); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2048); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_107
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2056); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2056); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_108
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2064); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2064); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_109
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2072); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2072); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_110
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2080); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2080); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_111
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2088); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2088); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_112
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2096); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2096); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_113
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2104); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2104); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_114
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2112); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2112); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_115
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2120); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2120); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_116
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2128); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2128); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_117
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2136); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2136); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_118
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2144); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2144); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_119
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2152); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2152); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_120
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2160); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2160); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_121
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2168); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2168); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_122
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2176); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2176); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_123
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2184); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2184); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_124
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2192); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2192); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_125
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2200); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2200); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_126
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2208); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2208); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_127
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2216); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2216); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_128
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2224); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2224); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_129
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2232); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2232); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_130
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2240); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2240); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_131
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2248); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2248); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_132
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2256); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2256); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_133
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2264); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2264); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_134
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2272); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2272); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_135
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2280); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2280); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_136
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2288); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2288); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_137
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2296); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2296); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_138
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2304); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2304); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_139
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2312); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2312); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_140
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2320); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2320); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_141
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2328); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2328); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_142
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2336); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2336); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_143
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2344); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2344); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_144
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2352); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2352); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_145
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2360); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2360); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_146
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2368); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2368); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_147
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2376); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2376); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_148
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2384); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2384); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_149
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2392); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2392); }; }
        }

        /// <summary>
        /// IntProperty: Index
        /// </summary>
        public unsafe int Index
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2400); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2400); }; }
        }
    }

}
