#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSpecialMoveConfig_CwClawClimbStart<br/>
/// (size = 536)
/// (flags = 4114)
/// </summary>
public partial class RSpecialMoveConfig_CwClawClimbStart : BmSDK.BmGame.RSpecialMoveConfig_RelativeAnimMove, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSpecialMoveConfig_CwClawClimbStart", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_CwClawClimbStart() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_CwClawClimbStart
    /// </summary>
    public RSpecialMoveConfig_CwClawClimbStart(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_CwClawClimbStart Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_CwClawClimbStart(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: StandToLaunchAnim
    /// </summary>
    public unsafe BmSDK.FName StandToLaunchAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// NameProperty: RunToLaunchAnim
    /// </summary>
    public unsafe BmSDK.FName RunToLaunchAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// NameProperty: StandToLaunchPounceAnim
    /// </summary>
    public unsafe BmSDK.FName StandToLaunchPounceAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }

    /// <summary>
    /// NameProperty: RunToLaunchPounceAnim
    /// </summary>
    public unsafe BmSDK.FName RunToLaunchPounceAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// NameProperty: LaunchAnim
    /// </summary>
    public unsafe BmSDK.FName LaunchAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// NameProperty: LaunchFromRunAnim
    /// </summary>
    public unsafe BmSDK.FName LaunchFromRunAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// NameProperty: LaunchRightAnim
    /// </summary>
    public unsafe BmSDK.FName LaunchRightAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// NameProperty: LaunchUpAnim
    /// </summary>
    public unsafe BmSDK.FName LaunchUpAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// NameProperty: LaunchUpRightAnim
    /// </summary>
    public unsafe BmSDK.FName LaunchUpRightAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// NameProperty: LaunchIdleAnim
    /// </summary>
    public unsafe BmSDK.FName LaunchIdleAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }
}
