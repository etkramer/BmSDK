#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: NavMeshGoal_ClosestActorInList<br/>
/// (size = 208)
/// (flags = 0)
/// </summary>
public partial class NavMeshGoal_ClosestActorInList : BmSDK.Engine.NavMeshPathGoalEvaluator, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.NavMeshGoal_ClosestActorInList", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal NavMeshGoal_ClosestActorInList() { }

    /// <summary>
    /// Constructs a new NavMeshGoal_ClosestActorInList
    /// </summary>
    public NavMeshGoal_ClosestActorInList(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, NavMeshGoal_ClosestActorInList Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected NavMeshGoal_ClosestActorInList(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: RecycleInternal
    /// </summary>
    public unsafe void RecycleInternal()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.NavMeshGoal_ClosestActorInList.RecycleInternal", true);
        byte* paramsPtr = stackalloc byte[0];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: Recycle
    /// </summary>
    public unsafe void Recycle()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.NavMeshGoal_ClosestActorInList.Recycle", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClosestActorInList
    /// </summary>
    public unsafe static BmSDK.Engine.NavMeshGoal_ClosestActorInList ClosestActorInList(BmSDK.Engine.NavigationHandle NavHandle, out BmSDK.TArray<BmSDK.Engine.NavMeshPathGoalEvaluator.FBiasedGoalActor> InGoalList)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.NavMeshGoal_ClosestActorInList.ClosestActorInList", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NavHandle, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        InGoalList = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.NavMeshPathGoalEvaluator.FBiasedGoalActor>>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.NavMeshGoal_ClosestActorInList>(paramsPtr + 24);
    }

    /// <summary>
    /// ArrayProperty: GoalList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.NavMeshPathGoalEvaluator.FBiasedGoalActor> GoalList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.NavMeshPathGoalEvaluator.FBiasedGoalActor>>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// StructProperty: PolyToGoalActorMap
    /// </summary>
    public unsafe BmSDK.GameObject.FMultiMap_Mirror PolyToGoalActorMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FMultiMap_Mirror>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// StructProperty: CachedAnchorPoly
    /// </summary>
    public unsafe System.IntPtr CachedAnchorPoly
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }
}
