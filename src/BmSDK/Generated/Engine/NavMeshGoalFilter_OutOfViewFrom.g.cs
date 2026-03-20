#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: NavMeshGoalFilter_OutOfViewFrom<br/>
/// (size = 116)
/// (flags = 0)
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
    /// Function: MustBeHiddenFromThisPoint
    /// </summary>
    public unsafe static bool MustBeHiddenFromThisPoint(BmSDK.Engine.NavMeshGoal_GenericFilterContainer FilterContainer, System.Numerics.Vector3 InOutOfViewLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.NavMeshGoalFilter_OutOfViewFrom.MustBeHiddenFromThisPoint", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FilterContainer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InOutOfViewLocation, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    /// <summary>
    /// StructProperty: GoalPoly
    /// </summary>
    public unsafe System.IntPtr GoalPoly
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// StructProperty: OutOfViewLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 OutOfViewLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }
}
