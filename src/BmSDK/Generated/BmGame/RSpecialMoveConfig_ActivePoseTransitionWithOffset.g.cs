#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveConfig_ActivePoseTransitionWithOffset<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSpecialMoveConfig_ActivePoseTransitionWithOffset : BmSDK.BmGame.RSpecialMoveConfig_ActivePoseTransition, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveConfig_ActivePoseTransitionWithOffset", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_ActivePoseTransitionWithOffset() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_ActivePoseTransitionWithOffset
    /// </summary>
    public RSpecialMoveConfig_ActivePoseTransitionWithOffset(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_ActivePoseTransitionWithOffset Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_ActivePoseTransitionWithOffset(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: MoveOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 MoveOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 440); }
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
}
