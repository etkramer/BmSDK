#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: Texture2D<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class Texture2D : BmSDK.Engine.Texture, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.Texture2D", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal Texture2D() { }

    /// <summary>
    /// Constructs a new Texture2D
    /// </summary>
    public Texture2D(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, Texture2D Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected Texture2D(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: Mips
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Mips
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// IntProperty: SizeX
    /// </summary>
    public unsafe int SizeX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// IntProperty: SizeY
    /// </summary>
    public unsafe int SizeY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }

    /// <summary>
    /// IntProperty: OriginalSizeX
    /// </summary>
    public unsafe int OriginalSizeX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }

    /// <summary>
    /// IntProperty: OriginalSizeY
    /// </summary>
    public unsafe int OriginalSizeY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }

    /// <summary>
    /// IntProperty: AutoLODSizeX
    /// </summary>
    public unsafe int AutoLODSizeX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }

    /// <summary>
    /// IntProperty: AutoLODSizeY
    /// </summary>
    public unsafe int AutoLODSizeY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 344); }
    }

    /// <summary>
    /// ByteProperty: Format
    /// </summary>
    public unsafe byte Format
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// ByteProperty: AddressX
    /// </summary>
    public unsafe byte AddressX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 349); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 349); }
    }

    /// <summary>
    /// ByteProperty: AddressY
    /// </summary>
    public unsafe byte AddressY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 350); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 350); }
    }

    /// <summary>
    /// BoolProperty: XboxForcePWLCorrection
    /// </summary>
    public unsafe bool XboxForcePWLCorrection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: UseCustomDxtWeights
    /// </summary>
    public unsafe bool UseCustomDxtWeights
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bIsStreamable
    /// </summary>
    public unsafe bool bIsStreamable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bHasCancelationPending
    /// </summary>
    public unsafe bool bHasCancelationPending
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bHasBeenLoadedFromPersistentArchive
    /// </summary>
    public unsafe bool bHasBeenLoadedFromPersistentArchive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bForceMiplevelsToBeResident
    /// </summary>
    public unsafe bool bForceMiplevelsToBeResident
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bGlobalForceMipLevelsToBeResident
    /// </summary>
    public unsafe bool bGlobalForceMipLevelsToBeResident
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: PrestreamMipLevelsFullMips
    /// </summary>
    public unsafe bool PrestreamMipLevelsFullMips
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: PrestreamMipLevelsHighPriority
    /// </summary>
    public unsafe bool PrestreamMipLevelsHighPriority
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: PrestreamGentleLastRenderTimeHint
    /// </summary>
    public unsafe bool PrestreamGentleLastRenderTimeHint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bIsCompositingSource
    /// </summary>
    public unsafe bool bIsCompositingSource
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bHasBeenPaintedInEditor
    /// </summary>
    public unsafe bool bHasBeenPaintedInEditor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bHeightmapTexture
    /// </summary>
    public unsafe bool bHeightmapTexture
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: IsALightingGel
    /// </summary>
    public unsafe bool IsALightingGel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// StructProperty: CustomDxtWeights
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CustomDxtWeights
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// FloatProperty: PrestreamMipLevelsTimestamp
    /// </summary>
    public unsafe float PrestreamMipLevelsTimestamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// IntProperty: GelIndex
    /// </summary>
    public unsafe int GelIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// IntProperty: GelMipOffset
    /// </summary>
    public unsafe int GelMipOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// NameProperty: TextureFileCacheName
    /// </summary>
    public unsafe BmSDK.FName TextureFileCacheName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// StructProperty: TextureFileCacheGuid
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT TextureFileCacheGuid
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// IntProperty: RequestedMips
    /// </summary>
    public unsafe int RequestedMips
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// IntProperty: ResidentMips
    /// </summary>
    public unsafe int ResidentMips
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// IntProperty: MipsToRemoveOnCompress
    /// </summary>
    public unsafe int MipsToRemoveOnCompress
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// StructProperty: PendingMipChangeRequestStatus
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PendingMipChangeRequestStatus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }

    /// <summary>
    /// ArrayProperty: SystemMemoryData
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> SystemMemoryData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }

    /// <summary>
    /// StructProperty: StreamableTexturesLink
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT StreamableTexturesLink
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }

    /// <summary>
    /// IntProperty: StreamingIndex
    /// </summary>
    public unsafe int StreamingIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// IntProperty: MipTailBaseIdx
    /// </summary>
    public unsafe int MipTailBaseIdx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }

    /// <summary>
    /// StructProperty: ResourceMem
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ResourceMem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }

    /// <summary>
    /// IntProperty: FirstResourceMemMip
    /// </summary>
    public unsafe int FirstResourceMemMip
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// FloatProperty: Timer
    /// </summary>
    public unsafe float Timer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// StructProperty: CompressSourceArtTask
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CompressSourceArtTask
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// Struct: FTexture2DMipMap
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FTexture2DMipMap
    {
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Data
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: Size
        /// </summary>
        public unsafe int Size
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }
    }
}
