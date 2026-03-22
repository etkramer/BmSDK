#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: NxForceFieldRadialComponent<br/>
/// (size = 508)
/// (flags = 2292199570)
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
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// FloatProperty: ForceRadius
    /// </summary>
    public unsafe float ForceRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }

    /// <summary>
    /// FloatProperty: SelfRotationStrength
    /// </summary>
    public unsafe float SelfRotationStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// ByteProperty: ForceFalloff
    /// </summary>
    public unsafe BmSDK.Engine.PrimitiveComponent.ERadialImpulseFalloff ForceFalloff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PrimitiveComponent.ERadialImpulseFalloff>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// StructProperty: Kernel
    /// </summary>
    public unsafe System.IntPtr Kernel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }
}
