#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ScriptedTexture<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ScriptedTexture : BmSDK.Engine.TextureRenderTarget2D, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ScriptedTexture", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ScriptedTexture() { }

    /// <summary>
    /// Constructs a new ScriptedTexture
    /// </summary>
    public ScriptedTexture(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ScriptedTexture Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ScriptedTexture(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bNeedsUpdate
    /// </summary>
    public unsafe bool bNeedsUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bSkipNextClear
    /// </summary>
    public unsafe bool bSkipNextClear
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// DelegateProperty: __Render__Delegate
    /// </summary>
    public unsafe System.IntPtr __Render__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }
}
