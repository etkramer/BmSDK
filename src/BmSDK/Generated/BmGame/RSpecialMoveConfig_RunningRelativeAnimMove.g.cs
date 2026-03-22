#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveConfig_RunningRelativeAnimMove<br/>
/// (size = 372)
/// (flags = 4114)
/// </summary>
public partial class RSpecialMoveConfig_RunningRelativeAnimMove : BmSDK.BmGame.RSpecialMoveConfig_RelativeAnimMove, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveConfig_RunningRelativeAnimMove", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_RunningRelativeAnimMove() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_RunningRelativeAnimMove
    /// </summary>
    public RSpecialMoveConfig_RunningRelativeAnimMove(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_RunningRelativeAnimMove Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_RunningRelativeAnimMove(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: AnimationLaunchFoot
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig_RunningRelativeAnimMove.RelativeAnimLaunchFoot AnimationLaunchFoot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig_RunningRelativeAnimMove.RelativeAnimLaunchFoot>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// FloatProperty: AnimDistScale
    /// </summary>
    public unsafe float AnimDistScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// FloatProperty: FootFastFwdThreshold
    /// </summary>
    public unsafe float FootFastFwdThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// FloatProperty: FootFastFwdScale
    /// </summary>
    public unsafe float FootFastFwdScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreFootPlacement
    /// </summary>
    public unsafe bool bIgnoreFootPlacement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 364) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 364); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 364); }
    }

    /// <summary>
    /// BoolProperty: bUse3dPosForPickingAnim
    /// </summary>
    public unsafe bool bUse3dPosForPickingAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 364) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 364); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 364); }
    }

    /// <summary>
    /// ObjectProperty: CapeGlideOverrideMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CapeGlideOverrideMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// Enum: RelativeAnimLaunchFoot
    /// </summary>
    public enum RelativeAnimLaunchFoot
    {
        RALF_LeftFoot = 0,
        RALF_RightFoot = 1,
        RALF_LeftPassing = 2,
        RALF_RightPassing = 3,
        RALF_MAX = 4,
    }
}
