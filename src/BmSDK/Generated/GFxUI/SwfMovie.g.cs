#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.GFxUI;

/// <summary>
/// Class: SwfMovie<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class SwfMovie : BmSDK.GFxUI.GFxRawData, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "GFxUI.SwfMovie", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SwfMovie() { }

    /// <summary>
    /// Constructs a new SwfMovie
    /// </summary>
    public SwfMovie(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SwfMovie Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SwfMovie(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bUsesFontlib
    /// </summary>
    public unsafe bool bUsesFontlib
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 148); }
    }

    /// <summary>
    /// BoolProperty: bSetSRGBOnImportedTextures
    /// </summary>
    public unsafe bool bSetSRGBOnImportedTextures
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 148); }
    }

    /// <summary>
    /// BoolProperty: bPackTextures
    /// </summary>
    public unsafe bool bPackTextures
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 148); }
    }

    /// <summary>
    /// BoolProperty: bStoreDecompressedForFasterInit
    /// </summary>
    public unsafe bool bStoreDecompressedForFasterInit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 148); }
    }

    /// <summary>
    /// StrProperty: SourceFile
    /// </summary>
    public unsafe BmSDK.FString SourceFile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// IntProperty: PackTextureSize
    /// </summary>
    public unsafe int PackTextureSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// ByteProperty: PackedTextureResize
    /// </summary>
    public unsafe byte PackedTextureResize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// ByteProperty: TextureRescale
    /// </summary>
    public unsafe byte TextureRescale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 173); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 173); }
    }

    /// <summary>
    /// StrProperty: TextureFormat
    /// </summary>
    public unsafe BmSDK.FString TextureFormat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// StrProperty: SourceFileTimestamp
    /// </summary>
    public unsafe BmSDK.FString SourceFileTimestamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// IntProperty: RTTextures
    /// </summary>
    public unsafe int RTTextures
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// IntProperty: RTVideoTextures
    /// </summary>
    public unsafe int RTVideoTextures
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// StructProperty: ImportTimeStamp
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ImportTimeStamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }

    /// <summary>
    /// Enum: EPackedTextureResize
    /// </summary>
    public enum EPackedTextureResize
    {
        EPackedTextureResize_None = 0,
        EPackedTextureResize_Power2 = 1,
        EPackedTextureResize_Mult4 = 2,
        EPackedTextureResize_Mult128 = 3,
        EPackedTextureResize_MAX = 4,
    }

    /// <summary>
    /// Enum: FlashTextureRescale
    /// </summary>
    public enum FlashTextureRescale
    {
        FlashTextureScale_High = 0,
        FlashTextureScale_Low = 1,
        FlashTextureScale_NextLow = 2,
        FlashTextureScale_Mult4 = 3,
        FlashTextureScale_None = 4,
        FlashTextureScale_MAX = 5,
    }
}
