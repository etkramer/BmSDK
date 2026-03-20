#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: NavMeshGoalFilter_OutSideOfDotProductWedge<br/>
/// (size = 124)
/// (flags = 0)
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
    /// Function: OutsideOfDotProductWedge
    /// </summary>
    public unsafe static bool OutsideOfDotProductWedge(BmSDK.Engine.NavMeshGoal_GenericFilterContainer FilterContainer, System.Numerics.Vector3 InLocation, BmSDK.Rotator InRotation, float InEpsilon)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.NavMeshGoalFilter_OutSideOfDotProductWedge.OutsideOfDotProductWedge", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FilterContainer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InRotation, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InEpsilon, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 36);
    }

    /// <summary>
    /// StructProperty: Location
    /// </summary>
    public unsafe System.Numerics.Vector3 Location
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// StructProperty: Rotation
    /// </summary>
    public unsafe System.Numerics.Vector3 Rotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// FloatProperty: Epsilon
    /// </summary>
    public unsafe float Epsilon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }
}
