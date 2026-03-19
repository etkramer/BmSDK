#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveConfig_OmnitronPasswordCracking<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSpecialMoveConfig_OmnitronPasswordCracking : BmSDK.BmGame.RSpecialMoveConfig, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveConfig_OmnitronPasswordCracking", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_OmnitronPasswordCracking() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_OmnitronPasswordCracking
    /// </summary>
    public RSpecialMoveConfig_OmnitronPasswordCracking(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_OmnitronPasswordCracking Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_OmnitronPasswordCracking(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: ResonatorPose
    /// </summary>
    public unsafe BmSDK.FName ResonatorPose
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// NameProperty: EndPose
    /// </summary>
    public unsafe BmSDK.FName EndPose
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// NameProperty: CustomInAnim
    /// </summary>
    public unsafe BmSDK.FName CustomInAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// FloatProperty: CameraYawOffset
    /// </summary>
    public unsafe float CameraYawOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }

    /// <summary>
    /// FloatProperty: CameraPitchOffset
    /// </summary>
    public unsafe float CameraPitchOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// FloatProperty: MinOverlayTimer
    /// </summary>
    public unsafe float MinOverlayTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// FloatProperty: MaxOverlayTimer
    /// </summary>
    public unsafe float MaxOverlayTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }

    /// <summary>
    /// FloatProperty: MininumStartDistance
    /// </summary>
    public unsafe float MininumStartDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }

    /// <summary>
    /// FloatProperty: MaxThumbSpeed
    /// </summary>
    public unsafe float MaxThumbSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// FloatProperty: ThumbAccel
    /// </summary>
    public unsafe float ThumbAccel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// FloatProperty: ThumbDecel
    /// </summary>
    public unsafe float ThumbDecel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// BoolProperty: bAlignAnimWithLocator
    /// </summary>
    public unsafe bool bAlignAnimWithLocator
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 456) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 456); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 456); }
    }
}
