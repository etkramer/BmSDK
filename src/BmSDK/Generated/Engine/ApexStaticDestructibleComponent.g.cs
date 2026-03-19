#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ApexStaticDestructibleComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ApexStaticDestructibleComponent : BmSDK.Engine.ApexStaticComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ApexStaticDestructibleComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ApexStaticDestructibleComponent() { }

    /// <summary>
    /// Constructs a new ApexStaticDestructibleComponent
    /// </summary>
    public ApexStaticDestructibleComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ApexStaticDestructibleComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ApexStaticDestructibleComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: SleepEnergyThreshold
    /// </summary>
    public unsafe float SleepEnergyThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// FloatProperty: SleepDamping
    /// </summary>
    public unsafe float SleepDamping
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// StructProperty: ApexDestructibleActor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ApexDestructibleActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// StructProperty: ApexDestructiblePreview
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ApexDestructiblePreview
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// BoolProperty: bIsThumbnailComponent
    /// </summary>
    public unsafe bool bIsThumbnailComponent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 692); }
    }

    /// <summary>
    /// BoolProperty: bInitRBPhysCompleted
    /// </summary>
    public unsafe bool bInitRBPhysCompleted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 692); }
    }

    /// <summary>
    /// BoolProperty: bForceUpdateTransform
    /// </summary>
    public unsafe bool bForceUpdateTransform
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 692); }
    }

    /// <summary>
    /// StructProperty: OwnerDrawScale
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT OwnerDrawScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }
}
