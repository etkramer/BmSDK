#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: NavMeshPath_EnforceTwoWayEdges<br/>
/// (flags = 0)
/// </summary>
public partial class NavMeshPath_EnforceTwoWayEdges : BmSDK.Engine.NavMeshPathConstraint, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.NavMeshPath_EnforceTwoWayEdges", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal NavMeshPath_EnforceTwoWayEdges() { }

    /// <summary>
    /// Constructs a new NavMeshPath_EnforceTwoWayEdges
    /// </summary>
    public NavMeshPath_EnforceTwoWayEdges(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, NavMeshPath_EnforceTwoWayEdges Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected NavMeshPath_EnforceTwoWayEdges(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: NextConstraint
    /// </summary>
    public unsafe BmSDK.Engine.NavMeshPathConstraint NextConstraint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.NavMeshPathConstraint>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// IntProperty: NumNodesProcessed
    /// </summary>
    public unsafe int NumNodesProcessed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// IntProperty: NumThrownOutNodes
    /// </summary>
    public unsafe int NumThrownOutNodes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// FloatProperty: AddedDirectCost
    /// </summary>
    public unsafe float AddedDirectCost
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// FloatProperty: AddedHeuristicCost
    /// </summary>
    public unsafe float AddedHeuristicCost
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }
}
