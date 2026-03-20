#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: DOFEffect<br/>
/// (flags = 0)
/// </summary>
public partial class DOFEffect : BmSDK.Engine.PostProcessEffect, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.DOFEffect", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal DOFEffect() { }

    /// <summary>
    /// Constructs a new DOFEffect
    /// </summary>
    public DOFEffect(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, DOFEffect Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected DOFEffect(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: FocusDistance
    /// </summary>
    public unsafe float FocusDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// FloatProperty: ApertureStop
    /// </summary>
    public unsafe float ApertureStop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }
}
