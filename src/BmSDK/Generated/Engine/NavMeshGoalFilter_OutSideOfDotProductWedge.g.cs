#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: NavMeshGoalFilter_OutSideOfDotProductWedge<br/>
/// (size = 84)
/// (flags = 134217874)
/// </summary>
public partial class NavMeshGoalFilter_OutSideOfDotProductWedge : BmSDK.Engine.NavMeshGoal_Filter, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.NavMeshGoalFilter_OutSideOfDotProductWedge", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal NavMeshGoalFilter_OutSideOfDotProductWedge() { }

    /// <summary>
    /// Constructs a new NavMeshGoalFilter_OutSideOfDotProductWedge
    /// </summary>
    public NavMeshGoalFilter_OutSideOfDotProductWedge(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, NavMeshGoalFilter_OutSideOfDotProductWedge Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected NavMeshGoalFilter_OutSideOfDotProductWedge(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: Location
    /// </summary>
    public unsafe System.Numerics.Vector3 Location
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// StructProperty: Rotation
    /// </summary>
    public unsafe System.Numerics.Vector3 Rotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 68); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }
    }

    /// <summary>
    /// FloatProperty: Epsilon
    /// </summary>
    public unsafe float Epsilon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 80); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }
    }
}
