#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: NavMeshGoal_PolyEncompassesAI<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class NavMeshGoal_PolyEncompassesAI : BmSDK.Engine.NavMeshPathGoalEvaluator, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.NavMeshGoal_PolyEncompassesAI", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal NavMeshGoal_PolyEncompassesAI() { }

    /// <summary>
    /// Constructs a new NavMeshGoal_PolyEncompassesAI
    /// </summary>
    public NavMeshGoal_PolyEncompassesAI(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, NavMeshGoal_PolyEncompassesAI Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected NavMeshGoal_PolyEncompassesAI(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: OverrideExtentToCheck
    /// </summary>
    public unsafe System.Numerics.Vector3 OverrideExtentToCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }
}
