#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveConfig_AlignedPoseTransition<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSpecialMoveConfig_AlignedPoseTransition : BmSDK.BmGame.RSpecialMoveConfig_PoseTransition, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveConfig_AlignedPoseTransition", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_AlignedPoseTransition() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_AlignedPoseTransition
    /// </summary>
    public RSpecialMoveConfig_AlignedPoseTransition(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_AlignedPoseTransition Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_AlignedPoseTransition(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: Offset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Offset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }

    /// <summary>
    /// IntProperty: YawOffset
    /// </summary>
    public unsafe int YawOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// FloatProperty: CameraLagTime
    /// </summary>
    public unsafe float CameraLagTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }
}
