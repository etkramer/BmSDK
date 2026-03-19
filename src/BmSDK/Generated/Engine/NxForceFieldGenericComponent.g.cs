#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: NxForceFieldGenericComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class NxForceFieldGenericComponent : BmSDK.Engine.NxForceFieldComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.NxForceFieldGenericComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal NxForceFieldGenericComponent() { }

    /// <summary>
    /// Constructs a new NxForceFieldGenericComponent
    /// </summary>
    public NxForceFieldGenericComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, NxForceFieldGenericComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected NxForceFieldGenericComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: RoughExtentX
    /// </summary>
    public unsafe float RoughExtentX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 660); }
    }

    /// <summary>
    /// FloatProperty: RoughExtentY
    /// </summary>
    public unsafe float RoughExtentY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// FloatProperty: RoughExtentZ
    /// </summary>
    public unsafe float RoughExtentZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ByteProperty: Coordinates
    /// </summary>
    public unsafe byte Coordinates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// StructProperty: Constant
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Constant
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// StructProperty: PositionMultiplierX
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PositionMultiplierX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// StructProperty: PositionMultiplierY
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PositionMultiplierY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// StructProperty: PositionMultiplierZ
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PositionMultiplierZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// StructProperty: PositionTarget
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PositionTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// StructProperty: VelocityMultiplierX
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VelocityMultiplierX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// StructProperty: VelocityMultiplierY
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VelocityMultiplierY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// StructProperty: VelocityMultiplierZ
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VelocityMultiplierZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// StructProperty: VelocityTarget
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VelocityTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// StructProperty: Noise
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Noise
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// StructProperty: FalloffLinear
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FalloffLinear
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// StructProperty: FalloffQuadratic
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FalloffQuadratic
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// FloatProperty: TorusRadius
    /// </summary>
    public unsafe float TorusRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// StructProperty: Kernel
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Kernel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }
}
