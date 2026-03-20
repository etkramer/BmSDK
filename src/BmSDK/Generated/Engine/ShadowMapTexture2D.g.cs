#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ShadowMapTexture2D<br/>
/// (flags = 0)
/// </summary>
public partial class ShadowMapTexture2D : BmSDK.Engine.Texture2D, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ShadowMapTexture2D", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ShadowMapTexture2D() { }

    /// <summary>
    /// Constructs a new ShadowMapTexture2D
    /// </summary>
    public ShadowMapTexture2D(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ShadowMapTexture2D Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ShadowMapTexture2D(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: ShadowmapFlags
    /// </summary>
    public unsafe int ShadowmapFlags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }
}
