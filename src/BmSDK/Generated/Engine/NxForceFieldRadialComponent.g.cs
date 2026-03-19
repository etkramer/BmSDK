#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: NxForceFieldRadialComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class NxForceFieldRadialComponent : BmSDK.Engine.NxForceFieldComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.NxForceFieldRadialComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal NxForceFieldRadialComponent() { }

    /// <summary>
    /// Constructs a new NxForceFieldRadialComponent
    /// </summary>
    public NxForceFieldRadialComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, NxForceFieldRadialComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected NxForceFieldRadialComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: ForceStrength
    /// </summary>
    public unsafe float ForceStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 660); }
    }

    /// <summary>
    /// FloatProperty: ForceRadius
    /// </summary>
    public unsafe float ForceRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// FloatProperty: SelfRotationStrength
    /// </summary>
    public unsafe float SelfRotationStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ByteProperty: ForceFalloff
    /// </summary>
    public unsafe byte ForceFalloff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// StructProperty: Kernel
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Kernel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }
}
