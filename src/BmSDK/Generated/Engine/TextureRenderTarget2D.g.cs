#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: TextureRenderTarget2D<br/>
/// (flags = 0)
/// </summary>
public partial class TextureRenderTarget2D : BmSDK.Engine.TextureRenderTarget, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.TextureRenderTarget2D", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal TextureRenderTarget2D() { }

    /// <summary>
    /// Constructs a new TextureRenderTarget2D
    /// </summary>
    public TextureRenderTarget2D(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, TextureRenderTarget2D Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected TextureRenderTarget2D(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: Clear
    /// </summary>
    public unsafe void Clear()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.TextureRenderTarget2D.Clear", true);
        byte* paramsPtr = stackalloc byte[64];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: Create
    /// </summary>
    public unsafe static BmSDK.Engine.TextureRenderTarget2D Create(int InSizeX, int InSizeY, BmSDK.Engine.Texture.EPixelFormat InFormat = default, BmSDK.GameObject.FLinearColor InClearColor = default, bool bOnlyRenderOnce = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.TextureRenderTarget2D.Create", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSizeX, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSizeY, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InFormat, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InClearColor, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnlyRenderOnce, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.TextureRenderTarget2D>(paramsPtr + 32);
    }

    /// <summary>
    /// IntProperty: SizeX
    /// </summary>
    public unsafe int SizeX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// IntProperty: SizeY
    /// </summary>
    public unsafe int SizeY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }

    /// <summary>
    /// ByteProperty: Format
    /// </summary>
    public unsafe BmSDK.Engine.Texture.EPixelFormat Format
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture.EPixelFormat>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// ByteProperty: AddressX
    /// </summary>
    public unsafe BmSDK.Engine.Texture.TextureAddress AddressX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture.TextureAddress>(Ptr + 325); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 325); }
    }

    /// <summary>
    /// ByteProperty: AddressY
    /// </summary>
    public unsafe BmSDK.Engine.Texture.TextureAddress AddressY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture.TextureAddress>(Ptr + 326); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 326); }
    }

    /// <summary>
    /// StructProperty: ClearColor
    /// </summary>
    public unsafe BmSDK.GameObject.FLinearColor ClearColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FLinearColor>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }

    /// <summary>
    /// BoolProperty: bForceLinearGamma
    /// </summary>
    public unsafe bool bForceLinearGamma
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 344) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 344); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 344); }
    }
}
