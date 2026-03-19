#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: NavMeshGoalFilter_NotNearOtherAI<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class NavMeshGoalFilter_NotNearOtherAI : BmSDK.Engine.NavMeshGoal_Filter, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.NavMeshGoalFilter_NotNearOtherAI", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal NavMeshGoalFilter_NotNearOtherAI() { }

    /// <summary>
    /// Constructs a new NavMeshGoalFilter_NotNearOtherAI
    /// </summary>
    public NavMeshGoalFilter_NotNearOtherAI(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, NavMeshGoalFilter_NotNearOtherAI Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected NavMeshGoalFilter_NotNearOtherAI(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: DistanceToCheck
    /// </summary>
    public unsafe float DistanceToCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }
}
