#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ApexForceFieldGenericComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ApexForceFieldGenericComponent : BmSDK.Engine.ApexForceFieldComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ApexForceFieldGenericComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ApexForceFieldGenericComponent() { }

    /// <summary>
    /// Constructs a new ApexForceFieldGenericComponent
    /// </summary>
    public ApexForceFieldGenericComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ApexForceFieldGenericComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ApexForceFieldGenericComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: ForceStrength
    /// </summary>
    public unsafe float ForceStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// FloatProperty: ForceRadius
    /// </summary>
    public unsafe float ForceRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// FloatProperty: ForceHeight
    /// </summary>
    public unsafe float ForceHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// ByteProperty: Coordinates
    /// </summary>
    public unsafe byte Coordinates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// StructProperty: Constant
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Constant
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// StructProperty: PositionMultiplierX
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PositionMultiplierX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }

    /// <summary>
    /// StructProperty: PositionMultiplierY
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PositionMultiplierY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }

    /// <summary>
    /// StructProperty: PositionMultiplierZ
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PositionMultiplierZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// StructProperty: PositionTarget
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PositionTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// StructProperty: VelocityMultiplierX
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VelocityMultiplierX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }

    /// <summary>
    /// StructProperty: VelocityMultiplierY
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VelocityMultiplierY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// StructProperty: VelocityMultiplierZ
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VelocityMultiplierZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// StructProperty: VelocityTarget
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VelocityTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// StructProperty: Noise
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Noise
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// StructProperty: FalloffLinear
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FalloffLinear
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// StructProperty: FalloffQuadratic
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FalloffQuadratic
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// FloatProperty: TorusRadius
    /// </summary>
    public unsafe float TorusRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }
}
