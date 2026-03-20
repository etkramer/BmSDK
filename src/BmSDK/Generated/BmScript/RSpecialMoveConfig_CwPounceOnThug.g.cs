#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSpecialMoveConfig_CwPounceOnThug<br/>
/// (size = 680)
/// (flags = 4114)
/// </summary>
public partial class RSpecialMoveConfig_CwPounceOnThug : BmSDK.BmGame.RSpecialMoveConfig_RelativeAnimMove, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSpecialMoveConfig_CwPounceOnThug", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_CwPounceOnThug() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_CwPounceOnThug
    /// </summary>
    public RSpecialMoveConfig_CwPounceOnThug(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_CwPounceOnThug Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_CwPounceOnThug(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: LaunchAnim
    /// </summary>
    public unsafe BmSDK.FName LaunchAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// NameProperty: MidAirAnim
    /// </summary>
    public unsafe BmSDK.FName MidAirAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// NameProperty: LandAnim
    /// </summary>
    public unsafe BmSDK.FName LandAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }

    /// <summary>
    /// NameProperty: LandForwardAnim
    /// </summary>
    public unsafe BmSDK.FName LandForwardAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// NameProperty: VictimLandAnim
    /// </summary>
    public unsafe BmSDK.FName VictimLandAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// NameProperty: VictimLandFrontAnim
    /// </summary>
    public unsafe BmSDK.FName VictimLandFrontAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// NameProperty: VictimLandBackAnim
    /// </summary>
    public unsafe BmSDK.FName VictimLandBackAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// ObjectProperty: VictimAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VictimAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// FloatProperty: SmashRadius
    /// </summary>
    public unsafe float SmashRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// StructProperty: SmashScreenShake
    /// </summary>
    public unsafe BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct SmashScreenShake
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 524); }
    }
}
