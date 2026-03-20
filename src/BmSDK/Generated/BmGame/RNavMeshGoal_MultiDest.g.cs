#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RNavMeshGoal_MultiDest<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RNavMeshGoal_MultiDest : BmSDK.Engine.NavMeshPathGoalEvaluator, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RNavMeshGoal_MultiDest", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RNavMeshGoal_MultiDest() { }

    /// <summary>
    /// Constructs a new RNavMeshGoal_MultiDest
    /// </summary>
    public RNavMeshGoal_MultiDest(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RNavMeshGoal_MultiDest Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RNavMeshGoal_MultiDest(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: GoalPolyList
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> GoalPolyList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// ObjectProperty: GoalData
    /// </summary>
    public unsafe BmSDK.BmGame.RMultiDestGoalData GoalData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMultiDestGoalData>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }
}
