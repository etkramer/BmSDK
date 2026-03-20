#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AnimNodeScalePlayRate<br/>
/// (size = 308)
/// (flags = 144703634)
/// </summary>
public partial class AnimNodeScalePlayRate : BmSDK.Engine.AnimNodeBlendBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AnimNodeScalePlayRate", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AnimNodeScalePlayRate() { }

    /// <summary>
    /// Constructs a new AnimNodeScalePlayRate
    /// </summary>
    public AnimNodeScalePlayRate(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AnimNodeScalePlayRate Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AnimNodeScalePlayRate(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: ScaleByValue
    /// </summary>
    public unsafe float ScaleByValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }
}
