#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: NavMeshGoalFilter_OutOfViewFrom<br/>
/// (size = 72)
/// (flags = 134217874)
/// </summary>
public partial class NavMeshGoalFilter_OutOfViewFrom : BmSDK.Engine.NavMeshGoal_Filter, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.NavMeshGoalFilter_OutOfViewFrom", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal NavMeshGoalFilter_OutOfViewFrom() { }

    /// <summary>
    /// Constructs a new NavMeshGoalFilter_OutOfViewFrom
    /// </summary>
    public NavMeshGoalFilter_OutOfViewFrom(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, NavMeshGoalFilter_OutOfViewFrom Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected NavMeshGoalFilter_OutOfViewFrom(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: GoalPoly
    /// </summary>
    public unsafe System.IntPtr GoalPoly
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// StructProperty: OutOfViewLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 OutOfViewLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }
}
