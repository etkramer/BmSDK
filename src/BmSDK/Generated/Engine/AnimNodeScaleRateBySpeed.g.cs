#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AnimNodeScaleRateBySpeed<br/>
/// (size = 312)
/// (flags = 144703634)
/// </summary>
public partial class AnimNodeScaleRateBySpeed : BmSDK.Engine.AnimNodeScalePlayRate, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AnimNodeScaleRateBySpeed", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AnimNodeScaleRateBySpeed() { }

    /// <summary>
    /// Constructs a new AnimNodeScaleRateBySpeed
    /// </summary>
    public AnimNodeScaleRateBySpeed(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AnimNodeScaleRateBySpeed Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AnimNodeScaleRateBySpeed(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: BaseSpeed
    /// </summary>
    public unsafe float BaseSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }
}
