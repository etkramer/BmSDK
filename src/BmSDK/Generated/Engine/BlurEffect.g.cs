#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: BlurEffect<br/>
/// (size = 128)
/// (flags = 0)
/// </summary>
public partial class BlurEffect : BmSDK.Engine.PostProcessEffect, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.BlurEffect", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal BlurEffect() { }

    /// <summary>
    /// Constructs a new BlurEffect
    /// </summary>
    public BlurEffect(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, BlurEffect Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected BlurEffect(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: BlurKernelSize
    /// </summary>
    public unsafe int BlurKernelSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }
}
