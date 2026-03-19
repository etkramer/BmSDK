#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: NavMeshGoal_At<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class NavMeshGoal_At : BmSDK.Engine.NavMeshPathGoalEvaluator, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.NavMeshGoal_At", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal NavMeshGoal_At() { }

    /// <summary>
    /// Constructs a new NavMeshGoal_At
    /// </summary>
    public NavMeshGoal_At(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, NavMeshGoal_At Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected NavMeshGoal_At(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: Goal
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Goal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// FloatProperty: GoalDist
    /// </summary>
    public unsafe float GoalDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// BoolProperty: bKeepPartial
    /// </summary>
    public unsafe bool bKeepPartial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// BoolProperty: bWeightPartialByDist
    /// </summary>
    public unsafe bool bWeightPartialByDist
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// BoolProperty: bGoalInSamePolyAsAnchor
    /// </summary>
    public unsafe bool bGoalInSamePolyAsAnchor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// FloatProperty: PartialDistSq
    /// </summary>
    public unsafe float PartialDistSq
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// StructProperty: GoalPoly
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GoalPoly
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// StructProperty: PartialGoal
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PartialGoal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }
}
