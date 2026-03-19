#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SkelControlWheel<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class SkelControlWheel : BmSDK.Engine.SkelControlBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SkelControlWheel", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SkelControlWheel() { }

    /// <summary>
    /// Constructs a new SkelControlWheel
    /// </summary>
    public SkelControlWheel(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SkelControlWheel Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SkelControlWheel(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: WheelDisplacement
    /// </summary>
    public unsafe float WheelDisplacement
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// FloatProperty: WheelMaxRenderDisplacement
    /// </summary>
    public unsafe float WheelMaxRenderDisplacement
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// FloatProperty: WheelMinRenderDisplacement
    /// </summary>
    public unsafe float WheelMinRenderDisplacement
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// FloatProperty: WheelRoll
    /// </summary>
    public unsafe float WheelRoll
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// FloatProperty: WheelWobble
    /// </summary>
    public unsafe float WheelWobble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// ByteProperty: WheelRollAxis
    /// </summary>
    public unsafe byte WheelRollAxis
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// ByteProperty: WheelSteeringAxis
    /// </summary>
    public unsafe byte WheelSteeringAxis
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 269); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 269); }
    }

    /// <summary>
    /// FloatProperty: WheelSteering
    /// </summary>
    public unsafe float WheelSteering
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// BoolProperty: bInvertWheelRoll
    /// </summary>
    public unsafe bool bInvertWheelRoll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 276); }
    }

    /// <summary>
    /// BoolProperty: bInvertWheelSteering
    /// </summary>
    public unsafe bool bInvertWheelSteering
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 276); }
    }
}
