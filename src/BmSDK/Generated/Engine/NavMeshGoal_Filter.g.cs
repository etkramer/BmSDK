#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: NavMeshGoal_Filter<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class NavMeshGoal_Filter : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.NavMeshGoal_Filter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal NavMeshGoal_Filter() { }

    /// <summary>
    /// Constructs a new NavMeshGoal_Filter
    /// </summary>
    public NavMeshGoal_Filter(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, NavMeshGoal_Filter Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected NavMeshGoal_Filter(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bShowDebug
    /// </summary>
    public unsafe bool bShowDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 84); }
    }

    /// <summary>
    /// IntProperty: NumNodesThrownOut
    /// </summary>
    public unsafe int NumNodesThrownOut
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// IntProperty: NumNodesProcessed
    /// </summary>
    public unsafe int NumNodesProcessed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }
}
