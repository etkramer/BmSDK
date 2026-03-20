#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RProjectile_Grenade_Incendiary<br/>
/// (size = 7216)
/// (flags = 0)
/// </summary>
public partial class RProjectile_Grenade_Incendiary : BmSDK.BmScript.RProjectile_Grenade, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RProjectile_Grenade_Incendiary", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RProjectile_Grenade_Incendiary() { }

    /// <summary>
    /// Constructs a new RProjectile_Grenade_Incendiary
    /// </summary>
    public RProjectile_Grenade_Incendiary(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RProjectile_Grenade_Incendiary Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RProjectile_Grenade_Incendiary(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RProjectile_Grenade_Incendiary>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RProjectile_Grenade_Incendiary>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RProjectile_Grenade_Incendiary>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RProjectile_Grenade_Incendiary>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RProjectile_Grenade_Incendiary>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RProjectile_Grenade_Incendiary>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RProjectile_Grenade_Incendiary>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe void Destroyed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RProjectile_Grenade_Incendiary.Destroyed", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CheckLocationForCharge
    /// </summary>
    public unsafe bool CheckLocationForCharge(System.Numerics.Vector3 CheckLoc)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RProjectile_Grenade_Incendiary.CheckLocationForCharge", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckLoc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: DeployCharge_OpenSpace
    /// </summary>
    public unsafe BmSDK.BmScript.RIncendiaryGrenadeCharge DeployCharge_OpenSpace(System.Numerics.Vector3 prevLoc, System.Numerics.Vector3 currentLoc, int Depth, System.Numerics.Vector3 toNeighbourOffsets)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RProjectile_Grenade_Incendiary.DeployCharge_OpenSpace", true);
        byte* paramsPtr = stackalloc byte[144];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(prevLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(currentLoc, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Depth, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(toNeighbourOffsets, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RIncendiaryGrenadeCharge>(paramsPtr + 76);
    }

    /// <summary>
    /// Function: DeployCharge_Grate
    /// </summary>
    public unsafe BmSDK.BmScript.RIncendiaryGrenadeCharge DeployCharge_Grate(BmSDK.BmGame.RTunnelGrateBase currentGrate, int Depth)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RProjectile_Grenade_Incendiary.DeployCharge_Grate", true);
        byte* paramsPtr = stackalloc byte[172];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(currentGrate, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Depth, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RIncendiaryGrenadeCharge>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: SpawnCharges
    /// </summary>
    public unsafe void SpawnCharges()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RProjectile_Grenade_Incendiary.SpawnCharges", true);
        byte* paramsPtr = stackalloc byte[96];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddToList_OpenSpace
    /// </summary>
    public unsafe void AddToList_OpenSpace(System.Numerics.Vector3 prevLoc, System.Numerics.Vector3 currentLoc, int Depth, System.Numerics.Vector3 toNeighbourOffsets)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RProjectile_Grenade_Incendiary.AddToList_OpenSpace", true);
        byte* paramsPtr = stackalloc byte[172];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(prevLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(currentLoc, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Depth, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(toNeighbourOffsets, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddToList_Grate
    /// </summary>
    public unsafe void AddToList_Grate(BmSDK.BmGame.RTunnelGrateBase Grate, int Depth)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RProjectile_Grenade_Incendiary.AddToList_Grate", true);
        byte* paramsPtr = stackalloc byte[108];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Grate, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Depth, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetOffsetsFromNorthRot
    /// </summary>
    public unsafe void GetOffsetsFromNorthRot(BmSDK.Rotator NorthRot, out System.Numerics.Vector3 toNeighbourOffsets)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RProjectile_Grenade_Incendiary.GetOffsetsFromNorthRot", true);
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NorthRot, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        toNeighbourOffsets = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    /// <summary>
    /// Function: StopAudio
    /// </summary>
    public unsafe void StopAudio()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RProjectile_Grenade_Incendiary.StopAudio", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoBlast
    /// </summary>
    public unsafe void DoBlast()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RProjectile_Grenade_Incendiary.DoBlast", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe void PostBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RProjectile_Grenade_Incendiary.PostBeginPlay", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FchargeInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public partial record struct FchargeInfo
    {
        /// <summary>
        /// IntProperty: Depth
        /// </summary>
        public unsafe int Depth
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bValid
        /// </summary>
        public unsafe bool bValid
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// ObjectProperty: spawnedCharge
        /// </summary>
        public unsafe BmSDK.BmScript.RIncendiaryGrenadeCharge spawnedCharge
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RIncendiaryGrenadeCharge>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StructProperty: SpawnLoc
        /// </summary>
        public unsafe System.Numerics.Vector3 SpawnLoc
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ObjectProperty: Grate
        /// </summary>
        public unsafe BmSDK.BmGame.RTunnelGrateBase Grate
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTunnelGrateBase>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// StructProperty: prevLoc
        /// </summary>
        public unsafe System.Numerics.Vector3 prevLoc
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// StructProperty: toNeighbourOffsets
        /// </summary>
        public unsafe System.Numerics.Vector3 toNeighbourOffsets_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }
        /// <summary>
        /// StructProperty: toNeighbourOffsets
        /// </summary>
        public unsafe System.Numerics.Vector3 toNeighbourOffsets_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }
        /// <summary>
        /// StructProperty: toNeighbourOffsets
        /// </summary>
        public unsafe System.Numerics.Vector3 toNeighbourOffsets_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }
        /// <summary>
        /// StructProperty: toNeighbourOffsets
        /// </summary>
        public unsafe System.Numerics.Vector3 toNeighbourOffsets_3
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 84); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }; }
        }
    }

    /// <summary>
    /// IntProperty: Range
    /// </summary>
    public unsafe int Range
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// ArrayProperty: shortestDistToSpawnedCharges
    /// </summary>
    public unsafe BmSDK.TArray<int> shortestDistToSpawnedCharges
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// BoolProperty: bDrawDebug
    /// </summary>
    public unsafe bool bDrawDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1048) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1048); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1048); }
    }

    /// <summary>
    /// BoolProperty: bTriggeredExplodedCallback
    /// </summary>
    public unsafe bool bTriggeredExplodedCallback
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1048) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1048); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1048); }
    }

    /// <summary>
    /// ComponentProperty: SkelMeshComp
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent SkelMeshComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }

    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 1156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1156); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 1252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1252); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 1348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1348); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 1444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1444); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 1540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1540); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 1636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1636); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 1732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1732); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 1828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1828); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 1924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1924); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 2020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2020); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 2116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2116); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 2212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2212); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 2308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2308); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 2404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2404); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 2500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2500); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 2596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2596); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 2692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2692); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 2788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2788); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 2884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2884); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 2980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2980); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 3076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3076); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 3172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3172); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 3268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3268); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 3364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3364); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 3460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3460); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 3556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3556); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 3652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3652); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 3748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3748); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_29
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 3844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3844); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_30
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 3940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3940); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_31
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 4036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4036); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_32
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 4132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4132); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_33
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 4228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4228); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_34
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 4324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4324); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_35
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 4420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4420); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_36
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 4516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4516); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_37
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 4612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4612); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_38
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 4708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4708); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_39
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 4804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4804); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_40
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 4900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4900); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_41
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 4996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4996); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_42
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 5092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5092); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_43
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 5188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5188); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_44
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 5284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5284); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_45
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 5380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5380); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_46
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 5476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5476); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_47
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 5572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5572); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_48
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 5668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5668); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_49
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 5764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5764); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_50
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 5860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5860); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_51
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 5956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5956); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_52
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 6052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6052); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_53
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 6148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6148); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_54
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 6244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6244); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_55
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 6340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6340); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_56
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 6436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6436); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_57
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 6532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6532); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_58
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 6628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6628); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_59
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 6724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6724); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_60
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 6820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6820); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_61
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 6916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6916); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_62
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 7012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7012); }
    }
    /// <summary>
    /// StructProperty: chargeInfoList
    /// </summary>
    public unsafe BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo chargeInfoList_63
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RProjectile_Grenade_Incendiary.FchargeInfo>(Ptr + 7108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7108); }
    }

    /// <summary>
    /// IntProperty: numChargesSpawned
    /// </summary>
    public unsafe int numChargesSpawned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7204); }
    }

    /// <summary>
    /// IntProperty: numChargesInList
    /// </summary>
    public unsafe int numChargesInList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7208); }
    }

    /// <summary>
    /// IntProperty: currentDepth
    /// </summary>
    public unsafe int currentDepth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7212); }
    }
}
