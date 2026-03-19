#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: TextureMovie<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class TextureMovie : BmSDK.Engine.Texture, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.TextureMovie", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal TextureMovie() { }

    /// <summary>
    /// Constructs a new TextureMovie
    /// </summary>
    public TextureMovie(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, TextureMovie Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected TextureMovie(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: SizeX
    /// </summary>
    public unsafe int SizeX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// IntProperty: SizeY
    /// </summary>
    public unsafe int SizeY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }

    /// <summary>
    /// ByteProperty: Format
    /// </summary>
    public unsafe byte Format
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// ByteProperty: AddressX
    /// </summary>
    public unsafe byte AddressX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 317); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 317); }
    }

    /// <summary>
    /// ByteProperty: AddressY
    /// </summary>
    public unsafe byte AddressY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 318); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 318); }
    }

    /// <summary>
    /// ByteProperty: MovieStreamSource
    /// </summary>
    public unsafe byte MovieStreamSource
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 319); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 319); }
    }

    /// <summary>
    /// ClassProperty: DecoderClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DecoderClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }

    /// <summary>
    /// ObjectProperty: Decoder
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Decoder
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }

    /// <summary>
    /// BoolProperty: Paused
    /// </summary>
    public unsafe bool Paused
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 336); }
    }

    /// <summary>
    /// BoolProperty: Stopped
    /// </summary>
    public unsafe bool Stopped
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 336); }
    }

    /// <summary>
    /// BoolProperty: Looping
    /// </summary>
    public unsafe bool Looping
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 336); }
    }

    /// <summary>
    /// BoolProperty: ResetOnLastFrame
    /// </summary>
    public unsafe bool ResetOnLastFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 336); }
    }

    /// <summary>
    /// BoolProperty: AutoPlay
    /// </summary>
    public unsafe bool AutoPlay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 336); }
    }

    /// <summary>
    /// StructProperty: Data
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Data
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }

    /// <summary>
    /// StructProperty: ReleaseCodecFence
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ReleaseCodecFence
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }
}
