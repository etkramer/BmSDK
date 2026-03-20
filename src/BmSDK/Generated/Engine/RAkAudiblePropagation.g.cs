#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RAkAudiblePropagation<br/>
/// (size = 133)
/// (flags = 134221970)
/// </summary>
public partial class RAkAudiblePropagation : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RAkAudiblePropagation", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAkAudiblePropagation() { }

    /// <summary>
    /// Constructs a new RAkAudiblePropagation
    /// </summary>
    public RAkAudiblePropagation(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAkAudiblePropagation Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAkAudiblePropagation(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: PropagationDesc
    /// </summary>
    public unsafe BmSDK.Engine.AkWwise.FAkPropagationDesc PropagationDesc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkWwise.FAkPropagationDesc>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// FloatProperty: UpdateTimeFast
    /// </summary>
    public unsafe float UpdateTimeFast
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// FloatProperty: UpdateTimeSlow
    /// </summary>
    public unsafe float UpdateTimeSlow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// FloatProperty: InterpolationTime
    /// </summary>
    public unsafe float InterpolationTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// ByteProperty: RaycastPriority
    /// </summary>
    public unsafe BmSDK.Engine.RAkAudiblePropagation.EAkPropagationRayPriority RaycastPriority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAkAudiblePropagation.EAkPropagationRayPriority>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// Enum: EAkPropagationRayPriority
    /// </summary>
    public enum EAkPropagationRayPriority
    {
        AK_PROP_RAY_PRIORITY_AUTO = 0,
        AK_PROP_RAY_PRIORITY_LOW = 1,
        AK_PROP_RAY_PRIORITY_NORMAL = 2,
        AK_PROP_RAY_PRIORITY_HIGH = 3,
        AK_PROP_RAY_PRIORITY_MAX = 4,
    }
}
