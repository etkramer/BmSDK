#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ProcBuilding<br/>
/// (flags = 0)
/// </summary>
public partial class ProcBuilding : BmSDK.Engine.Volume, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ProcBuilding", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ProcBuilding() { }

    /// <summary>
    /// Constructs a new ProcBuilding
    /// </summary>
    public ProcBuilding(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ProcBuilding Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ProcBuilding(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ProcBuilding>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ProcBuilding>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ProcBuilding>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ProcBuilding>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ProcBuilding>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ProcBuilding>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ProcBuilding>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: Ruleset
    /// </summary>
    public unsafe BmSDK.Engine.ProcBuildingRuleset Ruleset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ProcBuildingRuleset>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// ObjectProperty: LowLODPersistentActor
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshActor LowLODPersistentActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshActor>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// ObjectProperty: CurrentSimpleMeshActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor CurrentSimpleMeshActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// ComponentProperty: CurrentSimpleMeshComp
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent CurrentSimpleMeshComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// ComponentProperty: SimpleMeshComp
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent SimpleMeshComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ArrayProperty: BuildingMeshCompInfos
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.ProcBuilding.FPBMeshCompInfo> BuildingMeshCompInfos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.ProcBuilding.FPBMeshCompInfo>>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// ArrayProperty: BuildingFracMeshCompInfos
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.ProcBuilding.FPBFracMeshCompInfo> BuildingFracMeshCompInfos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.ProcBuilding.FPBFracMeshCompInfo>>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// BoolProperty: bGenerateRoofMesh
    /// </summary>
    public unsafe bool bGenerateRoofMesh
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 812) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 812); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 812); }
    }

    /// <summary>
    /// BoolProperty: bGenerateFloorMesh
    /// </summary>
    public unsafe bool bGenerateFloorMesh
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 812) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 812); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 812); }
    }

    /// <summary>
    /// BoolProperty: bApplyRulesToRoof
    /// </summary>
    public unsafe bool bApplyRulesToRoof
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 812) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 812); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 812); }
    }

    /// <summary>
    /// BoolProperty: bApplyRulesToFloor
    /// </summary>
    public unsafe bool bApplyRulesToFloor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 812) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 812); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 812); }
    }

    /// <summary>
    /// BoolProperty: bSplitWallsAtRoofLevels
    /// </summary>
    public unsafe bool bSplitWallsAtRoofLevels
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 812) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 812); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 812); }
    }

    /// <summary>
    /// BoolProperty: bSplitWallsAtWallEdges
    /// </summary>
    public unsafe bool bSplitWallsAtWallEdges
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 812) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 812); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 812); }
    }

    /// <summary>
    /// BoolProperty: bQuickEdited
    /// </summary>
    public unsafe bool bQuickEdited
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 812) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 812); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 812); }
    }

    /// <summary>
    /// BoolProperty: bBuildingBrushCollision
    /// </summary>
    public unsafe bool bBuildingBrushCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 812) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 812); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 812); }
    }

    /// <summary>
    /// BoolProperty: bDebugDrawEdgeInfo
    /// </summary>
    public unsafe bool bDebugDrawEdgeInfo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 812) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 812); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 812); }
    }

    /// <summary>
    /// BoolProperty: bDebugDrawScopes
    /// </summary>
    public unsafe bool bDebugDrawScopes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 812) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 812); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 812); }
    }

    /// <summary>
    /// ArrayProperty: LODMeshComps
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.StaticMeshComponent> LODMeshComps
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.StaticMeshComponent>>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// ArrayProperty: LODMeshUVInfos
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.ProcBuilding.FPBFaceUVInfo> LODMeshUVInfos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.ProcBuilding.FPBFaceUVInfo>>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }

    /// <summary>
    /// ArrayProperty: TopLevelScopes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.ProcBuilding.FPBScope2D> TopLevelScopes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.ProcBuilding.FPBScope2D>>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// IntProperty: NumMeshedTopLevelScopes
    /// </summary>
    public unsafe int NumMeshedTopLevelScopes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }

    /// <summary>
    /// ArrayProperty: TopLevelScopeUVInfos
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.ProcBuilding.FPBFaceUVInfo> TopLevelScopeUVInfos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.ProcBuilding.FPBFaceUVInfo>>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// ArrayProperty: TopLevelScopeInfos
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.ProcBuilding.FPBScopeProcessInfo> TopLevelScopeInfos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.ProcBuilding.FPBScopeProcessInfo>>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// ArrayProperty: EdgeInfos
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.ProcBuilding.FPBEdgeInfo> EdgeInfos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.ProcBuilding.FPBEdgeInfo>>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// FloatProperty: MaxFacadeZ
    /// </summary>
    public unsafe float MaxFacadeZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// FloatProperty: MinFacadeZ
    /// </summary>
    public unsafe float MinFacadeZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }

    /// <summary>
    /// ArrayProperty: OverlappingBuildings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.ProcBuilding> OverlappingBuildings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.ProcBuilding>>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }

    /// <summary>
    /// FloatProperty: SimpleMeshMassiveLODDistance
    /// </summary>
    public unsafe float SimpleMeshMassiveLODDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// FloatProperty: RenderToTexturePullBackAmount
    /// </summary>
    public unsafe float RenderToTexturePullBackAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// IntProperty: RoofLightmapRes
    /// </summary>
    public unsafe int RoofLightmapRes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// IntProperty: NonRectWallLightmapRes
    /// </summary>
    public unsafe int NonRectWallLightmapRes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// FloatProperty: LODRenderToTextureScale
    /// </summary>
    public unsafe float LODRenderToTextureScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// NameProperty: ParamSwatchName
    /// </summary>
    public unsafe BmSDK.FName ParamSwatchName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// ArrayProperty: BuildingMaterialParams
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.ProcBuilding.FPBMaterialParam> BuildingMaterialParams
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.ProcBuilding.FPBMaterialParam>>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// ArrayProperty: BuildingMatParamMICs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant> BuildingMatParamMICs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant>>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// ArrayProperty: AttachedBuildings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.ProcBuilding> AttachedBuildings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.ProcBuilding>>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// IntProperty: BuildingInstanceVersion
    /// </summary>
    public unsafe int BuildingInstanceVersion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// Enum: EPBCornerType
    /// </summary>
    public enum EPBCornerType
    {
        EPBC_Default = 0,
        EPBC_Chamfer = 1,
        EPBC_Round = 2,
        EPBC_MAX = 3,
    }

    /// <summary>
    /// Struct: FPBEdgeInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FPBEdgeInfo
    {
        /// <summary>
        /// StructProperty: EdgeEnd
        /// </summary>
        public unsafe System.Numerics.Vector3 EdgeEnd
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: EdgeStart
        /// </summary>
        public unsafe System.Numerics.Vector3 EdgeStart
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: ScopeAIndex
        /// </summary>
        public unsafe int ScopeAIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ByteProperty: ScopeAEdge
        /// </summary>
        public unsafe BmSDK.Engine.ProcBuilding.EScopeEdge ScopeAEdge
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ProcBuilding.EScopeEdge>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// IntProperty: ScopeBIndex
        /// </summary>
        public unsafe int ScopeBIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// ByteProperty: ScopeBEdge
        /// </summary>
        public unsafe BmSDK.Engine.ProcBuilding.EScopeEdge ScopeBEdge
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ProcBuilding.EScopeEdge>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// FloatProperty: EdgeAngle
        /// </summary>
        public unsafe float EdgeAngle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }
    }

    /// <summary>
    /// Enum: EScopeEdge
    /// </summary>
    public enum EScopeEdge
    {
        EPSA_Top = 0,
        EPSA_Bottom = 1,
        EPSA_Left = 2,
        EPSA_Right = 3,
        EPSA_None = 4,
        EPSA_MAX = 5,
    }

    /// <summary>
    /// Struct: FPBFaceUVInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FPBFaceUVInfo
    {
        /// <summary>
        /// StructProperty: Offset
        /// </summary>
        public unsafe System.Numerics.Vector2 Offset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Size
        /// </summary>
        public unsafe System.Numerics.Vector2 Size
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FPBScopeProcessInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FPBScopeProcessInfo
    {
        /// <summary>
        /// ObjectProperty: OwningBuilding
        /// </summary>
        public unsafe BmSDK.Engine.ProcBuilding OwningBuilding
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ProcBuilding>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: Ruleset
        /// </summary>
        public unsafe BmSDK.Engine.ProcBuildingRuleset Ruleset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ProcBuildingRuleset>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// NameProperty: RulesetVariation
        /// </summary>
        public unsafe BmSDK.FName RulesetVariation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// BoolProperty: bGenerateLODPoly
        /// </summary>
        public unsafe bool bGenerateLODPoly
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 24); }; }
        }

        /// <summary>
        /// BoolProperty: bPartOfNonRect
        /// </summary>
        public unsafe bool bPartOfNonRect
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Struct: FPBScope2D
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FPBScope2D
    {
        /// <summary>
        /// StructProperty: ScopeFrame
        /// </summary>
        public unsafe BmSDK.GameObject.FMatrix ScopeFrame
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FMatrix>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: DimX
        /// </summary>
        public unsafe float DimX
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }

        /// <summary>
        /// FloatProperty: DimZ
        /// </summary>
        public unsafe float DimZ
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }
    }

}
