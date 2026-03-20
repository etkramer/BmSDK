#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSpecialMoveConfig_CwClawClimbEnd<br/>
/// (size = 552)
/// (flags = 4114)
/// </summary>
public partial class RSpecialMoveConfig_CwClawClimbEnd : BmSDK.BmGame.RSpecialMoveConfig_RelativeAnimMove, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSpecialMoveConfig_CwClawClimbEnd", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_CwClawClimbEnd() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_CwClawClimbEnd
    /// </summary>
    public RSpecialMoveConfig_CwClawClimbEnd(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_CwClawClimbEnd Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_CwClawClimbEnd(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: LandAnim
    /// </summary>
    public unsafe BmSDK.FName LandAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// NameProperty: LandRightAnim
    /// </summary>
    public unsafe BmSDK.FName LandRightAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// NameProperty: LandRightIdleAnim
    /// </summary>
    public unsafe BmSDK.FName LandRightIdleAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }

    /// <summary>
    /// NameProperty: WallIdleAnim
    /// </summary>
    public unsafe BmSDK.FName WallIdleAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// NameProperty: ClimbLedgeAnim
    /// </summary>
    public unsafe BmSDK.FName ClimbLedgeAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// NameProperty: ClimbRailingAnim
    /// </summary>
    public unsafe BmSDK.FName ClimbRailingAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// NameProperty: ClimbLedgeCameraState
    /// </summary>
    public unsafe BmSDK.FName ClimbLedgeCameraState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// NameProperty: ClimbRailingCameraState
    /// </summary>
    public unsafe BmSDK.FName ClimbRailingCameraState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// NameProperty: ClimbLedgeEndMovementStance
    /// </summary>
    public unsafe BmSDK.FName ClimbLedgeEndMovementStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// NameProperty: ClimbRailingEndMovementStance
    /// </summary>
    public unsafe BmSDK.FName ClimbRailingEndMovementStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// NameProperty: ClimbLedgeEndControllerState
    /// </summary>
    public unsafe BmSDK.FName ClimbLedgeEndControllerState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// NameProperty: ClimbRailingEndControllerState
    /// </summary>
    public unsafe BmSDK.FName ClimbRailingEndControllerState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }
}
