#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: NavMeshGoal_ClosestActorInList<br/>
/// (size = 0)
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
    /// ArrayProperty: GoalList
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT GoalList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// StructProperty: PolyToGoalActorMap
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PolyToGoalActorMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// StructProperty: CachedAnchorPoly
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CachedAnchorPoly
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }
}
