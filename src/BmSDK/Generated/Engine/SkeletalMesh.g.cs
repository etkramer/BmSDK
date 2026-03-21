#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SkeletalMesh<br/>
/// (size = 1048)
/// (flags = 402)
/// </summary>
public partial class SkeletalMesh : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SkeletalMesh", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SkeletalMesh() { }

    /// <summary>
    /// Constructs a new SkeletalMesh
    /// </summary>
    public SkeletalMesh(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SkeletalMesh Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SkeletalMesh(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SkeletalMesh>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SkeletalMesh>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SkeletalMesh>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SkeletalMesh>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SkeletalMesh>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SkeletalMesh>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SkeletalMesh>
        => ((GameObject)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Struct: FSoftBodySpecialBoneInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FSoftBodySpecialBoneInfo
    {
        /// <summary>
        /// NameProperty: BoneName
        /// </summary>
        public unsafe BmSDK.FName BoneName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: BoneType
        /// </summary>
        public unsafe BmSDK.Engine.SkeletalMesh.SoftBodyBoneType BoneType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh.SoftBodyBoneType>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ArrayProperty: AttachedVertexIndices
        /// </summary>
        public unsafe BmSDK.TArray<int> AttachedVertexIndices
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Enum: SoftBodyBoneType
    /// </summary>
    public enum SoftBodyBoneType
    {
        SOFTBODYBONE_Fixed = 0,
        SOFTBODYBONE_BreakableAttachment = 1,
        SOFTBODYBONE_TwoWayAttachment = 2,
        SOFTBODYBONE_MAX = 3,
    }

    /// <summary>
    /// Struct: FSoftBodyTetraLink
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FSoftBodyTetraLink
    {
        /// <summary>
        /// IntProperty: Index
        /// </summary>
        public unsafe int Index
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Bary
        /// </summary>
        public unsafe System.Numerics.Vector3 Bary
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FClothSpecialBoneInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FClothSpecialBoneInfo
    {
        /// <summary>
        /// NameProperty: BoneName
        /// </summary>
        public unsafe BmSDK.FName BoneName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: BoneType
        /// </summary>
        public unsafe BmSDK.Engine.SkeletalMesh.ClothBoneType BoneType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh.ClothBoneType>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ArrayProperty: AttachedVertexIndices
        /// </summary>
        public unsafe BmSDK.TArray<int> AttachedVertexIndices
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Enum: ClothBoneType
    /// </summary>
    public enum ClothBoneType
    {
        CLOTHBONE_Fixed = 0,
        CLOTHBONE_BreakableAttachment = 1,
        CLOTHBONE_TearLine = 2,
        CLOTHBONE_MAX = 3,
    }

    /// <summary>
    /// Struct: FSkeletalMeshLODInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public partial record struct FSkeletalMeshLODInfo
    {
        /// <summary>
        /// FloatProperty: DisplayFactor
        /// </summary>
        public unsafe float DisplayFactor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: LODHysteresis
        /// </summary>
        public unsafe float LODHysteresis
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ArrayProperty: LODMaterialMap
        /// </summary>
        public unsafe BmSDK.TArray<int> LODMaterialMap
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ArrayProperty: bEnableShadowCasting
        /// </summary>
        public unsafe BmSDK.TArray<bool> bEnableShadowCasting
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<bool>>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// ArrayProperty: TriangleSorting
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMesh.TriangleSortOption> TriangleSorting
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMesh.TriangleSortOption>>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// ArrayProperty: TriangleSortSettings
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMesh.FTriangleSortSettings> TriangleSortSettings
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMesh.FTriangleSortSettings>>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// StrProperty: SourceAuthor
        /// </summary>
        public unsafe BmSDK.FString SourceAuthor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// StrProperty: MaxFilePath
        /// </summary>
        public unsafe BmSDK.FString MaxFilePath
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }
    }

    /// <summary>
    /// Struct: FTriangleSortSettings
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FTriangleSortSettings
    {
        /// <summary>
        /// ByteProperty: TriangleSorting
        /// </summary>
        public unsafe BmSDK.Engine.SkeletalMesh.TriangleSortOption TriangleSorting
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh.TriangleSortOption>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: CustomLeftRightAxis
        /// </summary>
        public unsafe BmSDK.Engine.SkeletalMesh.TriangleSortAxis CustomLeftRightAxis
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh.TriangleSortAxis>(Ptr + 1); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1); }; }
        }

        /// <summary>
        /// NameProperty: CustomLeftRightBoneName
        /// </summary>
        public unsafe BmSDK.FName CustomLeftRightBoneName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Enum: TriangleSortAxis
    /// </summary>
    public enum TriangleSortAxis
    {
        TSA_X_Axis = 0,
        TSA_Y_Axis = 1,
        TSA_Z_Axis = 2,
        TSA_MAX = 3,
    }

    /// <summary>
    /// Enum: ClothMovementScaleGen
    /// </summary>
    public enum ClothMovementScaleGen
    {
        ECMDM_DistToFixedVert = 0,
        ECMDM_VertexBoneWeight = 1,
        ECMDM_Empty = 2,
        ECMDM_MAX = 3,
    }

    /// <summary>
    /// Enum: TriangleSortOption
    /// </summary>
    public enum TriangleSortOption
    {
        TRISORT_None = 0,
        TRISORT_CenterRadialDistance = 1,
        TRISORT_Random = 2,
        TRISORT_Tootle = 3,
        TRISORT_MergeContiguous = 4,
        TRISORT_Custom = 5,
        TRISORT_CustomLeftRight = 6,
        TRISORT_MAX = 7,
    }

    /// <summary>
    /// Enum: BoneBreakOption
    /// </summary>
    public enum BoneBreakOption
    {
        BONEBREAK_SoftPreferred = 0,
        BONEBREAK_AutoDetect = 1,
        BONEBREAK_RigidPreferred = 2,
        BONEBREAK_MAX = 3,
    }

    /// <summary>
    /// Struct: FBoneMirrorExport
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 17)]
    public partial record struct FBoneMirrorExport
    {
        /// <summary>
        /// NameProperty: BoneName
        /// </summary>
        public unsafe BmSDK.FName BoneName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// NameProperty: SourceBoneName
        /// </summary>
        public unsafe BmSDK.FName SourceBoneName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ByteProperty: BoneFlipAxis
        /// </summary>
        public unsafe BmSDK.GameObject.EAxis BoneFlipAxis
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.EAxis>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FBoneMirrorInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 5)]
    public partial record struct FBoneMirrorInfo
    {
        /// <summary>
        /// IntProperty: SourceIndex
        /// </summary>
        public unsafe int SourceIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: BoneFlipAxis
        /// </summary>
        public unsafe BmSDK.GameObject.EAxis BoneFlipAxis
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.EAxis>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FBoneBounds
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FBoneBounds
    {
        /// <summary>
        /// IntProperty: BoneIndex
        /// </summary>
        public unsafe int BoneIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Box
        /// </summary>
        public unsafe BmSDK.GameObject.FSimpleBox Box
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FSimpleBox>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// StructProperty: Bounds
    /// </summary>
    public unsafe BmSDK.GameObject.FBoxSphereBounds Bounds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FBoxSphereBounds>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// FloatProperty: ConservativeBounds
    /// </summary>
    public unsafe float ConservativeBounds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 72); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }
    }

    /// <summary>
    /// ArrayProperty: PerBoneBounds
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMesh.FBoneBounds> PerBoneBounds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMesh.FBoneBounds>>(Ptr + 76); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }
    }

    /// <summary>
    /// ArrayProperty: Materials
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInterface> Materials
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInterface>>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// ArrayProperty: ClothingAssets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.ApexClothingAsset> ClothingAssets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.ApexClothingAsset>>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ArrayProperty: ClothingTeleportRefBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> ClothingTeleportRefBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// StructProperty: Origin
    /// </summary>
    public unsafe System.Numerics.Vector3 Origin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// StructProperty: RotOrigin
    /// </summary>
    public unsafe BmSDK.Rotator RotOrigin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// ArrayProperty: RefSkeleton
    /// </summary>
    public unsafe BmSDK.TArray<int> RefSkeleton
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// IntProperty: SkeletalDepth
    /// </summary>
    public unsafe int SkeletalDepth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// MapProperty: NameIndexMap
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ NameIndexMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// StructProperty: LODModels
    /// </summary>
    public unsafe BmSDK.GameObject.FIndirectArray_Mirror LODModels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FIndirectArray_Mirror>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// ArrayProperty: RefBasesInvMatrix
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject.FBoneAtom> RefBasesInvMatrix
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject.FBoneAtom>>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// ArrayProperty: FaceFXBoneToRefBone
    /// </summary>
    public unsafe BmSDK.TArray<int> FaceFXBoneToRefBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// ArrayProperty: SkelMirrorTable
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMesh.FBoneMirrorInfo> SkelMirrorTable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMesh.FBoneMirrorInfo>>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// ByteProperty: SkelMirrorAxis
    /// </summary>
    public unsafe BmSDK.GameObject.EAxis SkelMirrorAxis
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.EAxis>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// ByteProperty: SkelMirrorFlipAxis
    /// </summary>
    public unsafe BmSDK.GameObject.EAxis SkelMirrorFlipAxis
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.EAxis>(Ptr + 273); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 273); }
    }

    /// <summary>
    /// ArrayProperty: Sockets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMeshSocket> Sockets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMeshSocket>>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// ArrayProperty: BoneBreakNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> BoneBreakNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// ArrayProperty: BoneBreakOptions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMesh.BoneBreakOption> BoneBreakOptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMesh.BoneBreakOption>>(Ptr + 300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }
    }

    /// <summary>
    /// ArrayProperty: LODInfo
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMesh.FSkeletalMeshLODInfo> LODInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMesh.FSkeletalMeshLODInfo>>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }

    /// <summary>
    /// ArrayProperty: PerPolyCollisionBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> PerPolyCollisionBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// ArrayProperty: AddToParentPerPolyCollisionBone
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> AddToParentPerPolyCollisionBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }

    /// <summary>
    /// ArrayProperty: PerPolyBoneKDOPs
    /// </summary>
    public unsafe BmSDK.TArray<int> PerPolyBoneKDOPs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bPerPolyUseSoftWeighting
    /// </summary>
    public unsafe bool bPerPolyUseSoftWeighting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 360); }
    }

    /// <summary>
    /// BoolProperty: bUseSimpleLineCollision
    /// </summary>
    public unsafe bool bUseSimpleLineCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 360); }
    }

    /// <summary>
    /// BoolProperty: bUseSimpleBoxCollision
    /// </summary>
    public unsafe bool bUseSimpleBoxCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 360); }
    }

    /// <summary>
    /// BoolProperty: bForceCPUSkinning
    /// </summary>
    public unsafe bool bForceCPUSkinning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 360); }
    }

    /// <summary>
    /// BoolProperty: bUseFullPrecisionUVs
    /// </summary>
    public unsafe bool bUseFullPrecisionUVs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 360); }
    }

    /// <summary>
    /// BoolProperty: bUsePackedPosition
    /// </summary>
    public unsafe bool bUsePackedPosition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 360); }
    }

    /// <summary>
    /// BoolProperty: ForceShadowVolumes
    /// </summary>
    public unsafe bool ForceShadowVolumes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 360); }
    }

    /// <summary>
    /// BoolProperty: EnablePerBoneBounds
    /// </summary>
    public unsafe bool EnablePerBoneBounds
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 360); }
    }

    /// <summary>
    /// BoolProperty: EnableFaceFX
    /// </summary>
    public unsafe bool EnableFaceFX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 360); }
    }

    /// <summary>
    /// BoolProperty: EnableFaceFXBoneScaling
    /// </summary>
    public unsafe bool EnableFaceFXBoneScaling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 360); }
    }

    /// <summary>
    /// BoolProperty: EnableTwistBoneFixers
    /// </summary>
    public unsafe bool EnableTwistBoneFixers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 360); }
    }

    /// <summary>
    /// BoolProperty: EnableClavicleFixer
    /// </summary>
    public unsafe bool EnableClavicleFixer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 360); }
    }

    /// <summary>
    /// BoolProperty: EnableStretches
    /// </summary>
    public unsafe bool EnableStretches
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 360); }
    }

    /// <summary>
    /// ObjectProperty: FaceFXAsset
    /// </summary>
    public unsafe BmSDK.Engine.FaceFXAsset FaceFXAsset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.FaceFXAsset>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }

    /// <summary>
    /// ObjectProperty: DrivenMaterialParameterConfig
    /// </summary>
    public unsafe BmSDK.Engine.RSkeletalMeshDrivenMaterialParameterConfig DrivenMaterialParameterConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RSkeletalMeshDrivenMaterialParameterConfig>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// ObjectProperty: PreviewBoundsPhysicsAsset
    /// </summary>
    public unsafe BmSDK.Engine.PhysicsAsset PreviewBoundsPhysicsAsset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PhysicsAsset>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// ByteProperty: PreviewBoundsType
    /// </summary>
    public unsafe BmSDK.Engine.RSkeletalMeshComponent_Export.ESkeletalMeshComponentBoundsType PreviewBoundsType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RSkeletalMeshComponent_Export.ESkeletalMeshComponentBoundsType>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// ArrayProperty: PreviewMorphSets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MorphTargetSet> PreviewMorphSets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MorphTargetSet>>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// IntProperty: LODBiasPC
    /// </summary>
    public unsafe int LODBiasPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// IntProperty: LODBiasPS3
    /// </summary>
    public unsafe int LODBiasPS3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// IntProperty: LODBiasXbox360
    /// </summary>
    public unsafe int LODBiasXbox360
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// IntProperty: MaxBonesPerBatch
    /// </summary>
    public unsafe int MaxBonesPerBatch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// NameProperty: CachedPathName
    /// </summary>
    public unsafe BmSDK.FName CachedPathName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// StrProperty: SourceFilePath
    /// </summary>
    public unsafe BmSDK.FString SourceFilePath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// StrProperty: SourceFileTimestamp
    /// </summary>
    public unsafe BmSDK.FString SourceFileTimestamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// ArrayProperty: ClothMesh
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> ClothMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }

    /// <summary>
    /// ArrayProperty: ClothMeshScale
    /// </summary>
    public unsafe BmSDK.TArray<float> ClothMeshScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// ArrayProperty: ClothToGraphicsVertMap
    /// </summary>
    public unsafe BmSDK.TArray<int> ClothToGraphicsVertMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// ArrayProperty: ClothMovementScale
    /// </summary>
    public unsafe BmSDK.TArray<float> ClothMovementScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 476); }
    }

    /// <summary>
    /// ByteProperty: ClothMovementScaleGenMode
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMesh.ClothMovementScaleGen ClothMovementScaleGenMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh.ClothMovementScaleGen>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// FloatProperty: ClothToAnimMeshMaxDist
    /// </summary>
    public unsafe float ClothToAnimMeshMaxDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }

    /// <summary>
    /// BoolProperty: bLimitClothToAnimMesh
    /// </summary>
    public unsafe bool bLimitClothToAnimMesh
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 496); }
    }

    /// <summary>
    /// ArrayProperty: ClothWeldingMap
    /// </summary>
    public unsafe BmSDK.TArray<int> ClothWeldingMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// IntProperty: ClothWeldingDomain
    /// </summary>
    public unsafe int ClothWeldingDomain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// ArrayProperty: ClothWeldedIndices
    /// </summary>
    public unsafe BmSDK.TArray<int> ClothWeldedIndices
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// BoolProperty: bForceNoWelding
    /// </summary>
    public unsafe bool bForceNoWelding
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 528); }
    }

    /// <summary>
    /// IntProperty: NumFreeClothVerts
    /// </summary>
    public unsafe int NumFreeClothVerts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// ArrayProperty: ClothIndexBuffer
    /// </summary>
    public unsafe BmSDK.TArray<int> ClothIndexBuffer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// ArrayProperty: ClothBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> ClothBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// IntProperty: ClothHierarchyLevels
    /// </summary>
    public unsafe int ClothHierarchyLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// BoolProperty: bEnableClothBendConstraints
    /// </summary>
    public unsafe bool bEnableClothBendConstraints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 564) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 564); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 564); }
    }

    /// <summary>
    /// BoolProperty: bEnableClothDamping
    /// </summary>
    public unsafe bool bEnableClothDamping
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 564) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 564); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 564); }
    }

    /// <summary>
    /// BoolProperty: bUseClothCOMDamping
    /// </summary>
    public unsafe bool bUseClothCOMDamping
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 564) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 564); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 564); }
    }

    /// <summary>
    /// FloatProperty: ClothStretchStiffness
    /// </summary>
    public unsafe float ClothStretchStiffness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// FloatProperty: ClothBendStiffness
    /// </summary>
    public unsafe float ClothBendStiffness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }

    /// <summary>
    /// FloatProperty: ClothDensity
    /// </summary>
    public unsafe float ClothDensity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// FloatProperty: ClothThickness
    /// </summary>
    public unsafe float ClothThickness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }

    /// <summary>
    /// FloatProperty: ClothDamping
    /// </summary>
    public unsafe float ClothDamping
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// IntProperty: ClothIterations
    /// </summary>
    public unsafe int ClothIterations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// IntProperty: ClothHierarchicalIterations
    /// </summary>
    public unsafe int ClothHierarchicalIterations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// FloatProperty: ClothFriction
    /// </summary>
    public unsafe float ClothFriction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// FloatProperty: ClothRelativeGridSpacing
    /// </summary>
    public unsafe float ClothRelativeGridSpacing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// FloatProperty: ClothPressure
    /// </summary>
    public unsafe float ClothPressure
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// FloatProperty: ClothCollisionResponseCoefficient
    /// </summary>
    public unsafe float ClothCollisionResponseCoefficient
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// FloatProperty: ClothAttachmentResponseCoefficient
    /// </summary>
    public unsafe float ClothAttachmentResponseCoefficient
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// FloatProperty: ClothAttachmentTearFactor
    /// </summary>
    public unsafe float ClothAttachmentTearFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// FloatProperty: ClothSleepLinearVelocity
    /// </summary>
    public unsafe float ClothSleepLinearVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// FloatProperty: HardStretchLimitFactor
    /// </summary>
    public unsafe float HardStretchLimitFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// BoolProperty: bHardStretchLimit
    /// </summary>
    public unsafe bool bHardStretchLimit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 628) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 628); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 628); }
    }

    /// <summary>
    /// BoolProperty: bEnableClothOrthoBendConstraints
    /// </summary>
    public unsafe bool bEnableClothOrthoBendConstraints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 628) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 628); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 628); }
    }

    /// <summary>
    /// BoolProperty: bEnableClothSelfCollision
    /// </summary>
    public unsafe bool bEnableClothSelfCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 628) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 628); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 628); }
    }

    /// <summary>
    /// BoolProperty: bEnableClothPressure
    /// </summary>
    public unsafe bool bEnableClothPressure
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 628) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 628); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 628); }
    }

    /// <summary>
    /// BoolProperty: bEnableClothTwoWayCollision
    /// </summary>
    public unsafe bool bEnableClothTwoWayCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 628) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 628); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 628); }
    }

    /// <summary>
    /// ArrayProperty: ClothSpecialBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMesh.FClothSpecialBoneInfo> ClothSpecialBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMesh.FClothSpecialBoneInfo>>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }

    /// <summary>
    /// BoolProperty: bEnableClothLineChecks
    /// </summary>
    public unsafe bool bEnableClothLineChecks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 644) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 644); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 644); }
    }

    /// <summary>
    /// BoolProperty: bClothMetal
    /// </summary>
    public unsafe bool bClothMetal
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 644) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 644); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 644); }
    }

    /// <summary>
    /// FloatProperty: ClothMetalImpulseThreshold
    /// </summary>
    public unsafe float ClothMetalImpulseThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// FloatProperty: ClothMetalPenetrationDepth
    /// </summary>
    public unsafe float ClothMetalPenetrationDepth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }

    /// <summary>
    /// FloatProperty: ClothMetalMaxDeformationDistance
    /// </summary>
    public unsafe float ClothMetalMaxDeformationDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// BoolProperty: bEnableClothTearing
    /// </summary>
    public unsafe bool bEnableClothTearing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 660) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 660); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 660); }
    }

    /// <summary>
    /// FloatProperty: ClothTearFactor
    /// </summary>
    public unsafe float ClothTearFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// IntProperty: ClothTearReserve
    /// </summary>
    public unsafe int ClothTearReserve
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bEnableValidBounds
    /// </summary>
    public unsafe bool bEnableValidBounds
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 672) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 672); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 672); }
    }

    /// <summary>
    /// StructProperty: ValidBoundsMin
    /// </summary>
    public unsafe System.Numerics.Vector3 ValidBoundsMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// StructProperty: ValidBoundsMax
    /// </summary>
    public unsafe System.Numerics.Vector3 ValidBoundsMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// StructProperty: ClothTornTriMap
    /// </summary>
    public unsafe BmSDK.GameObject.FMap_Mirror ClothTornTriMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FMap_Mirror>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// StrProperty: SourceAuthor
    /// </summary>
    public unsafe BmSDK.FString SourceAuthor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// StrProperty: MaxFilePath
    /// </summary>
    public unsafe BmSDK.FString MaxFilePath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ArrayProperty: SoftBodySurfaceToGraphicsVertMap
    /// </summary>
    public unsafe BmSDK.TArray<int> SoftBodySurfaceToGraphicsVertMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// ArrayProperty: SoftBodySurfaceIndices
    /// </summary>
    public unsafe BmSDK.TArray<int> SoftBodySurfaceIndices
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// ArrayProperty: SoftBodyTetraVertsUnscaled
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> SoftBodyTetraVertsUnscaled
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// ArrayProperty: SoftBodyTetraIndices
    /// </summary>
    public unsafe BmSDK.TArray<int> SoftBodyTetraIndices
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// ArrayProperty: SoftBodyTetraLinks
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMesh.FSoftBodyTetraLink> SoftBodyTetraLinks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMesh.FSoftBodyTetraLink>>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }

    /// <summary>
    /// ArrayProperty: CachedSoftBodyMeshes
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> CachedSoftBodyMeshes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// ArrayProperty: CachedSoftBodyMeshScales
    /// </summary>
    public unsafe BmSDK.TArray<float> CachedSoftBodyMeshScales
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// ArrayProperty: SoftBodyBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> SoftBodyBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// ArrayProperty: SoftBodySpecialBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMesh.FSoftBodySpecialBoneInfo> SoftBodySpecialBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMesh.FSoftBodySpecialBoneInfo>>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// FloatProperty: SoftBodyVolumeStiffness
    /// </summary>
    public unsafe float SoftBodyVolumeStiffness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// FloatProperty: SoftBodyStretchingStiffness
    /// </summary>
    public unsafe float SoftBodyStretchingStiffness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }

    /// <summary>
    /// FloatProperty: SoftBodyDensity
    /// </summary>
    public unsafe float SoftBodyDensity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// FloatProperty: SoftBodyParticleRadius
    /// </summary>
    public unsafe float SoftBodyParticleRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }

    /// <summary>
    /// FloatProperty: SoftBodyDamping
    /// </summary>
    public unsafe float SoftBodyDamping
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// IntProperty: SoftBodySolverIterations
    /// </summary>
    public unsafe int SoftBodySolverIterations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }

    /// <summary>
    /// FloatProperty: SoftBodyFriction
    /// </summary>
    public unsafe float SoftBodyFriction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// FloatProperty: SoftBodyRelativeGridSpacing
    /// </summary>
    public unsafe float SoftBodyRelativeGridSpacing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }

    /// <summary>
    /// FloatProperty: SoftBodySleepLinearVelocity
    /// </summary>
    public unsafe float SoftBodySleepLinearVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }

    /// <summary>
    /// BoolProperty: bEnableSoftBodySelfCollision
    /// </summary>
    public unsafe bool bEnableSoftBodySelfCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 928); }
    }

    /// <summary>
    /// FloatProperty: SoftBodyAttachmentResponse
    /// </summary>
    public unsafe float SoftBodyAttachmentResponse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// FloatProperty: SoftBodyCollisionResponse
    /// </summary>
    public unsafe float SoftBodyCollisionResponse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// FloatProperty: SoftBodyDetailLevel
    /// </summary>
    public unsafe float SoftBodyDetailLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// IntProperty: SoftBodySubdivisionLevel
    /// </summary>
    public unsafe int SoftBodySubdivisionLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// BoolProperty: bSoftBodyIsoSurface
    /// </summary>
    public unsafe bool bSoftBodyIsoSurface
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bEnableSoftBodyDamping
    /// </summary>
    public unsafe bool bEnableSoftBodyDamping
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: bUseSoftBodyCOMDamping
    /// </summary>
    public unsafe bool bUseSoftBodyCOMDamping
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }

    /// <summary>
    /// FloatProperty: SoftBodyAttachmentThreshold
    /// </summary>
    public unsafe float SoftBodyAttachmentThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// BoolProperty: bEnableSoftBodyTwoWayCollision
    /// </summary>
    public unsafe bool bEnableSoftBodyTwoWayCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 956) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 956); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 956); }
    }

    /// <summary>
    /// FloatProperty: SoftBodyAttachmentTearFactor
    /// </summary>
    public unsafe float SoftBodyAttachmentTearFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// BoolProperty: bEnableSoftBodyLineChecks
    /// </summary>
    public unsafe bool bEnableSoftBodyLineChecks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 964) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 964); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 964); }
    }

    /// <summary>
    /// BoolProperty: bHasVertexColors
    /// </summary>
    public unsafe bool bHasVertexColors
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 964) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 964); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 964); }
    }

    /// <summary>
    /// ArrayProperty: GraphicsIndexIsCloth
    /// </summary>
    public unsafe BmSDK.TArray<bool> GraphicsIndexIsCloth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<bool>>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// ArrayProperty: CachedStreamingTextureFactors
    /// </summary>
    public unsafe BmSDK.TArray<float> CachedStreamingTextureFactors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }

    /// <summary>
    /// FloatProperty: StreamingDistanceMultiplier
    /// </summary>
    public unsafe float StreamingDistanceMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// IntProperty: ReleaseResourcesFence
    /// </summary>
    public unsafe int ReleaseResourcesFence
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// StructProperty: SkelMeshRUID
    /// </summary>
    public unsafe ulong SkelMeshRUID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<ulong>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// ArrayProperty: Stretches
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RSkeletalMeshComponent_Export.FStretchDescription> Stretches
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RSkeletalMeshComponent_Export.FStretchDescription>>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// BoolProperty: bUseClothingAssetMaterial
    /// </summary>
    public unsafe bool bUseClothingAssetMaterial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1020) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1020); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1020); }
    }

    /// <summary>
    /// BoolProperty: bUseClothCollisionChannels
    /// </summary>
    public unsafe bool bUseClothCollisionChannels
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1020) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1020); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1020); }
    }

    /// <summary>
    /// ByteProperty: DesiredTessellationMode
    /// </summary>
    public unsafe BmSDK.Engine.EngineTypes.EMaterialTessellationMode DesiredTessellationMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.EngineTypes.EMaterialTessellationMode>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// BoolProperty: EnableWatertightNormalsOverride
    /// </summary>
    public unsafe bool EnableWatertightNormalsOverride
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1028); }
    }

    /// <summary>
    /// BoolProperty: EnableMeshDicingForTessellation
    /// </summary>
    public unsafe bool EnableMeshDicingForTessellation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1028); }
    }

    /// <summary>
    /// IntProperty: DicingTargetMapWidth
    /// </summary>
    public unsafe int DicingTargetMapWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// IntProperty: DicingTargetMapHeight
    /// </summary>
    public unsafe int DicingTargetMapHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// FloatProperty: DicingTexelsPerEdge
    /// </summary>
    public unsafe float DicingTexelsPerEdge
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// FloatProperty: DesiredTessellationDistance
    /// </summary>
    public unsafe float DesiredTessellationDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }
}
