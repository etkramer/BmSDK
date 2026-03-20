#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AnimNodeAdditiveBlending<br/>
/// (flags = 0)
/// </summary>
public partial class AnimNodeAdditiveBlending : BmSDK.Engine.AnimNodeBlend, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AnimNodeAdditiveBlending", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AnimNodeAdditiveBlending() { }

    /// <summary>
    /// Constructs a new AnimNodeAdditiveBlending
    /// </summary>
    public AnimNodeAdditiveBlending(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AnimNodeAdditiveBlending Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AnimNodeAdditiveBlending(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bPassThroughWhenNotRendered
    /// </summary>
    public unsafe bool bPassThroughWhenNotRendered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 320); }
    }
}
