#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SkelControlSpline<br/>
/// (size = 268)
/// (flags = 142606482)
/// </summary>
public partial class SkelControlSpline : BmSDK.Engine.SkelControlBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SkelControlSpline", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SkelControlSpline() { }

    /// <summary>
    /// Constructs a new SkelControlSpline
    /// </summary>
    public SkelControlSpline(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SkelControlSpline Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SkelControlSpline(nint ptr) : base(ptr) { }

    /// <summary>
    /// Enum: ESplineControlRotMode
    /// </summary>
    public enum ESplineControlRotMode
    {
        SCR_NoChange = 0,
        SCR_AlongSpline = 1,
        SCR_Interpolate = 2,
        SCR_MAX = 3,
    }

    /// <summary>
    /// IntProperty: SplineLength
    /// </summary>
    public unsafe int SplineLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// ByteProperty: SplineBoneAxis
    /// </summary>
    public unsafe BmSDK.GameObject.EAxis SplineBoneAxis
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.EAxis>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// ByteProperty: BoneRotMode
    /// </summary>
    public unsafe BmSDK.Engine.SkelControlSpline.ESplineControlRotMode BoneRotMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkelControlSpline.ESplineControlRotMode>(Ptr + 253); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 253); }
    }

    /// <summary>
    /// BoolProperty: bInvertSplineBoneAxis
    /// </summary>
    public unsafe bool bInvertSplineBoneAxis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 256); }
    }

    /// <summary>
    /// FloatProperty: EndSplineTension
    /// </summary>
    public unsafe float EndSplineTension
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// FloatProperty: StartSplineTension
    /// </summary>
    public unsafe float StartSplineTension
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }
}
