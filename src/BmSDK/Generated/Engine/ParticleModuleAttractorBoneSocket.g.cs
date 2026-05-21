#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleAttractorBoneSocket<br/>
/// (size = 364)
/// (flags = 142610578)
/// </summary>
public partial class ParticleModuleAttractorBoneSocket : BmSDK.Engine.ParticleModuleAttractorBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleAttractorBoneSocket", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as ParticleModuleAttractorBoneSocket.
    /// </summary>
    public static ParticleModuleAttractorBoneSocket DefaultObject => (ParticleModuleAttractorBoneSocket)StaticClass().DefaultObject;

    internal ParticleModuleAttractorBoneSocket() { }

    /// <summary>
    /// Constructs a new ParticleModuleAttractorBoneSocket
    /// </summary>
    public ParticleModuleAttractorBoneSocket(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleAttractorBoneSocket Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleAttractorBoneSocket(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ParticleModuleAttractorBoneSocket>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleModuleAttractorBoneSocket>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ParticleModuleAttractorBoneSocket>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleModuleAttractorBoneSocket>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleModuleAttractorBoneSocket>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleModuleAttractorBoneSocket>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ParticleModuleAttractorBoneSocket>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleModuleAttractorBoneSocket>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Enum: ELocationBoneSocketDestSelectionMethod
    /// </summary>
    public enum ELocationBoneSocketDestSelectionMethod : byte
    {
        BONESOCKETDESTSEL_Sequential = 0,
        BONESOCKETDESTSEL_Random = 1,
        BONESOCKETDESTSEL_RandomExhaustive = 2,
        BONESOCKETDESTSEL_BlendAll = 3,
        BONESOCKETDESTSEL_MAX = 4,
    }

    /// <summary>
    /// Struct: FAttractLocationBoneSocketInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FAttractLocationBoneSocketInfo
    {
        /// <summary>
        /// NameProperty: BoneSocketName
        /// </summary>
        public unsafe BmSDK.FName BoneSocketName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Offset
        /// </summary>
        public unsafe System.Numerics.Vector3 Offset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Enum: ELocationBoneSocketDestination
    /// </summary>
    public enum ELocationBoneSocketDestination : byte
    {
        BONESOCKETDEST_Bones = 0,
        BONESOCKETDEST_Sockets = 1,
        BONESOCKETDEST_MAX = 2,
    }

    /// <summary>
    /// ByteProperty: FalloffType
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleAttractorBoneSocket.EBoneSocketAttractorFalloffType FalloffType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleAttractorBoneSocket.EBoneSocketAttractorFalloffType>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// ByteProperty: DestinationType
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleAttractorBoneSocket.ELocationBoneSocketDestination DestinationType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleAttractorBoneSocket.ELocationBoneSocketDestination>(Ptr + 97); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 97); }
    }

    /// <summary>
    /// ByteProperty: SelectionMethod
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleAttractorBoneSocket.ELocationBoneSocketDestSelectionMethod SelectionMethod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleAttractorBoneSocket.ELocationBoneSocketDestSelectionMethod>(Ptr + 98); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 98); }
    }

    /// <summary>
    /// BoolProperty: bParticleLifeRelative
    /// </summary>
    public unsafe bool bParticleLifeRelative
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bAttractAlongLengthOfBone
    /// </summary>
    public unsafe bool bAttractAlongLengthOfBone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// StructProperty: FalloffExponent
    /// </summary>
    public unsafe ref BmSDK.DistributionFloat.FRawDistributionFloat FalloffExponent
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 104);

    /// <summary>
    /// StructProperty: Range
    /// </summary>
    public unsafe ref BmSDK.DistributionFloat.FRawDistributionFloat Range
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 140);

    /// <summary>
    /// StructProperty: Strength
    /// </summary>
    public unsafe ref BmSDK.DistributionFloat.FRawDistributionFloat Strength
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 176);

    /// <summary>
    /// StructProperty: CollisionRadius
    /// </summary>
    public unsafe ref BmSDK.DistributionFloat.FRawDistributionFloat CollisionRadius
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 212);

    /// <summary>
    /// StructProperty: DragCoefficient
    /// </summary>
    public unsafe ref BmSDK.DistributionFloat.FRawDistributionFloat DragCoefficient
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 248);

    /// <summary>
    /// StructProperty: DragRadius
    /// </summary>
    public unsafe ref BmSDK.DistributionFloat.FRawDistributionFloat DragRadius
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 284);

    /// <summary>
    /// StructProperty: UniversalOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 UniversalOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 320);

    /// <summary>
    /// ArrayProperty: SourceLocations
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.ParticleModuleAttractorBoneSocket.FAttractLocationBoneSocketInfo> SourceLocations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.ParticleModuleAttractorBoneSocket.FAttractLocationBoneSocketInfo>>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }

    /// <summary>
    /// NameProperty: SkelMeshActorParamName
    /// </summary>
    public unsafe BmSDK.FName SkelMeshActorParamName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// ObjectProperty: EditorSkelMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMesh EditorSkelMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// Enum: EBoneSocketAttractorFalloffType
    /// </summary>
    public enum EBoneSocketAttractorFalloffType : byte
    {
        BSFOFF_Constant = 0,
        BSFOFF_Linear = 1,
        BSFOFF_Exponent = 2,
        BSFOFF_MAX = 3,
    }
}
