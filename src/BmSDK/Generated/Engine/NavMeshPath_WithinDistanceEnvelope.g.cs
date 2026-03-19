#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: NavMeshPath_WithinDistanceEnvelope<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class NavMeshPath_WithinDistanceEnvelope : BmSDK.Engine.NavMeshPathConstraint, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.NavMeshPath_WithinDistanceEnvelope", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal NavMeshPath_WithinDistanceEnvelope() { }

    /// <summary>
    /// Constructs a new NavMeshPath_WithinDistanceEnvelope
    /// </summary>
    public NavMeshPath_WithinDistanceEnvelope(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, NavMeshPath_WithinDistanceEnvelope Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected NavMeshPath_WithinDistanceEnvelope(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: MaxDistance
    /// </summary>
    public unsafe float MaxDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// FloatProperty: MinDistance
    /// </summary>
    public unsafe float MinDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: bSoft
    /// </summary>
    public unsafe bool bSoft
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// BoolProperty: bOnlyThrowOutNodesThatLeaveEnvelope
    /// </summary>
    public unsafe bool bOnlyThrowOutNodesThatLeaveEnvelope
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// FloatProperty: SoftStartPenalty
    /// </summary>
    public unsafe float SoftStartPenalty
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// StructProperty: EnvelopeTestPoint
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT EnvelopeTestPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }
}
