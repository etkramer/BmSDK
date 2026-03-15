#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveConfig_HoldLedge<br/>
/// (size = 348)
/// (flags = 4114)
/// </summary>
public partial class RSpecialMoveConfig_HoldLedge : BmSDK.BmGame.RSpecialMoveConfig_ActivePoseTransition, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveConfig_HoldLedge", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_HoldLedge() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_HoldLedge
    /// </summary>
    public RSpecialMoveConfig_HoldLedge(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_HoldLedge Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_HoldLedge(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetEndPositionAndYaw
    /// </summary>
    public unsafe void GetEndPositionAndYaw(BmSDK.Engine.Pawn Player, BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator MoveLocation, out System.Numerics.Vector3 EndPosition, out int EndYaw)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSpecialMoveConfig_HoldLedge.GetEndPositionAndYaw", true);
        byte* paramsPtr = stackalloc byte[132];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveLocation, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        EndPosition = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 116);
        EndYaw = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 128);
        return;
    }

    /// <summary>
    /// BoolProperty: bUseNegativeNormal
    /// </summary>
    public unsafe bool bUseNegativeNormal
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 332) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 332); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 332); }
    }

    /// <summary>
    /// StructProperty: LedgeOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 LedgeOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }
}
