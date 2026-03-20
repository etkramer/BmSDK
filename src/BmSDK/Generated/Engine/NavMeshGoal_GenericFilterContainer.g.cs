#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: NavMeshGoal_GenericFilterContainer<br/>
/// (flags = 0)
/// </summary>
public partial class NavMeshGoal_GenericFilterContainer : BmSDK.Engine.NavMeshPathGoalEvaluator, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.NavMeshGoal_GenericFilterContainer", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal NavMeshGoal_GenericFilterContainer() { }

    /// <summary>
    /// Constructs a new NavMeshGoal_GenericFilterContainer
    /// </summary>
    public NavMeshGoal_GenericFilterContainer(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, NavMeshGoal_GenericFilterContainer Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected NavMeshGoal_GenericFilterContainer(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: GoalFilters
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.NavMeshGoal_Filter> GoalFilters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.NavMeshGoal_Filter>>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// StructProperty: SuccessfulGoal
    /// </summary>
    public unsafe System.IntPtr SuccessfulGoal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// ObjectProperty: MyNavigationHandle
    /// </summary>
    public unsafe BmSDK.Engine.NavigationHandle MyNavigationHandle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.NavigationHandle>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// ArrayProperty: SeedLocations
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> SeedLocations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }
}
