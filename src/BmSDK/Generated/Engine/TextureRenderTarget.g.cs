#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: TextureRenderTarget<br/>
/// (flags = 0)
/// </summary>
public partial class TextureRenderTarget : BmSDK.Engine.Texture, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.TextureRenderTarget", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal TextureRenderTarget() { }

    /// <summary>
    /// Constructs a new TextureRenderTarget
    /// </summary>
    public TextureRenderTarget(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, TextureRenderTarget Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected TextureRenderTarget(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bUpdateImmediate
    /// </summary>
    public unsafe bool bUpdateImmediate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 308) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 308); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 308); }
    }

    /// <summary>
    /// BoolProperty: bNeedsTwoCopies
    /// </summary>
    public unsafe bool bNeedsTwoCopies
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 308) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 308); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 308); }
    }

    /// <summary>
    /// BoolProperty: bRenderOnce
    /// </summary>
    public unsafe bool bRenderOnce
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 308) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 308); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 308); }
    }

    /// <summary>
    /// FloatProperty: TargetGamma
    /// </summary>
    public unsafe float TargetGamma
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }
}
