#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: NavMeshGoalFilter_MinPathDistance<br/>
/// (flags = 0)
/// </summary>
public partial class NavMeshGoalFilter_MinPathDistance : BmSDK.Engine.NavMeshGoal_Filter, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.NavMeshGoalFilter_MinPathDistance", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal NavMeshGoalFilter_MinPathDistance() { }

    /// <summary>
    /// Constructs a new NavMeshGoalFilter_MinPathDistance
    /// </summary>
    public NavMeshGoalFilter_MinPathDistance(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, NavMeshGoalFilter_MinPathDistance Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected NavMeshGoalFilter_MinPathDistance(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: MinDistancePathShouldBe
    /// </summary>
    public unsafe int MinDistancePathShouldBe
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }
}
