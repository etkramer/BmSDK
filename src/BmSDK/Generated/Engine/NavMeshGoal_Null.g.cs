#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: NavMeshGoal_Null<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class NavMeshGoal_Null : BmSDK.Engine.NavMeshPathGoalEvaluator, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.NavMeshGoal_Null", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal NavMeshGoal_Null() { }

    /// <summary>
    /// Constructs a new NavMeshGoal_Null
    /// </summary>
    public NavMeshGoal_Null(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, NavMeshGoal_Null Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected NavMeshGoal_Null(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bAlwaysSucceed
    /// </summary>
    public unsafe bool bAlwaysSucceed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// StructProperty: PartialGoal
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PartialGoal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }
}
