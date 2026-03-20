#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: TextureCube<br/>
/// (flags = 0)
/// </summary>
public partial class TextureCube : BmSDK.Engine.Texture, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.TextureCube", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal TextureCube() { }

    /// <summary>
    /// Constructs a new TextureCube
    /// </summary>
    public TextureCube(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, TextureCube Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected TextureCube(nint ptr) : base(ptr) { }

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
    public unsafe BmSDK.Engine.Texture.EPixelFormat Format
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture.EPixelFormat>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// IntProperty: NumMips
    /// </summary>
    public unsafe int NumMips
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }

    /// <summary>
    /// BoolProperty: bIsCubemapValid
    /// </summary>
    public unsafe bool bIsCubemapValid
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 324); }
    }

    /// <summary>
    /// BoolProperty: ReflectionTexture
    /// </summary>
    public unsafe bool ReflectionTexture
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 324); }
    }

    /// <summary>
    /// BoolProperty: ReflectionEditorPreivewTexture
    /// </summary>
    public unsafe bool ReflectionEditorPreivewTexture
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 324); }
    }

    /// <summary>
    /// BoolProperty: bHasPendingRequestInFlight
    /// </summary>
    public unsafe bool bHasPendingRequestInFlight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 324); }
    }

    /// <summary>
    /// BoolProperty: bHasCancelationPending
    /// </summary>
    public unsafe bool bHasCancelationPending
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 324); }
    }

    /// <summary>
    /// ObjectProperty: FacePosX
    /// </summary>
    public unsafe BmSDK.Engine.Texture2D FacePosX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture2D>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }

    /// <summary>
    /// ObjectProperty: FaceNegX
    /// </summary>
    public unsafe BmSDK.Engine.Texture2D FaceNegX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture2D>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }

    /// <summary>
    /// ObjectProperty: FacePosY
    /// </summary>
    public unsafe BmSDK.Engine.Texture2D FacePosY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture2D>(Ptr + 344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 344); }
    }

    /// <summary>
    /// ObjectProperty: FaceNegY
    /// </summary>
    public unsafe BmSDK.Engine.Texture2D FaceNegY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture2D>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ObjectProperty: FacePosZ
    /// </summary>
    public unsafe BmSDK.Engine.Texture2D FacePosZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture2D>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// ObjectProperty: FaceNegZ
    /// </summary>
    public unsafe BmSDK.Engine.Texture2D FaceNegZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture2D>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// IntProperty: ReflectionIndex
    /// </summary>
    public unsafe int ReflectionIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// IntProperty: ReflectionMipOffset
    /// </summary>
    public unsafe int ReflectionMipOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }
}
