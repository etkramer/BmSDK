#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveConfig_ActivePoseTransitionWithOffset<br/>
/// (size = 348)
/// (flags = 4114)
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
    /// Function: GetEndPositionAndYaw
    /// </summary>
    public unsafe override void GetEndPositionAndYaw(BmSDK.Engine.Pawn Player, BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator MoveLocation, out System.Numerics.Vector3 EndPosition, out int EndYaw)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSpecialMoveConfig_ActivePoseTransitionWithOffset.GetEndPositionAndYaw", true);
        byte* paramsPtr = stackalloc byte[132];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveLocation, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        EndPosition = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 116);
        EndYaw = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 128);
        return;
    }

    /// <summary>
    /// StructProperty: MoveOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 MoveOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }

    /// <summary>
    /// IntProperty: YawOffset
    /// </summary>
    public unsafe int YawOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 344); }
    }
}
