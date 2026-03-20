#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RJobAssignment_TunnelGrenade<br/>
/// (size = 100)
/// (flags = 0)
/// </summary>
public partial class RJobAssignment_TunnelGrenade : BmSDK.BmGame.RJobAssignment, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RJobAssignment_TunnelGrenade", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RJobAssignment_TunnelGrenade() { }

    /// <summary>
    /// Constructs a new RJobAssignment_TunnelGrenade
    /// </summary>
    public RJobAssignment_TunnelGrenade(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RJobAssignment_TunnelGrenade Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RJobAssignment_TunnelGrenade(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: DoAssignment
    /// </summary>
    public unsafe void DoAssignment(BmSDK.BmGame.RBMRoomAIState RoomState, BmSDK.BmGame.RBMAIController ThugCon, BmSDK.GameObject AssignTarget)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RJobAssignment_TunnelGrenade.DoAssignment", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RoomState, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThugCon, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AssignTarget, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanBeAssigned
    /// </summary>
    public unsafe bool CanBeAssigned(BmSDK.BmGame.RBMRoomAIState RoomState, BmSDK.BmGame.RBMAIController ThugCon, BmSDK.GameObject AssignTarget)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RJobAssignment_TunnelGrenade.CanBeAssigned", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RoomState, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThugCon, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AssignTarget, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: IsAlreadyDoingJob
    /// </summary>
    public unsafe bool IsAlreadyDoingJob(BmSDK.BmGame.RBMAIController TestCon)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RJobAssignment_TunnelGrenade.IsAlreadyDoingJob", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestCon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: AddToDestList
    /// </summary>
    public unsafe void AddToDestList(BmSDK.BmGame.RBMRoomAIState RoomState, out BmSDK.TArray<BmSDK.BmGame.RAEC_LevelScripting.FSearchTarget> OutList)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RJobAssignment_TunnelGrenade.AddToDestList", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RoomState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutList = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAEC_LevelScripting.FSearchTarget>>(paramsPtr + 8);
        return;
    }
}
