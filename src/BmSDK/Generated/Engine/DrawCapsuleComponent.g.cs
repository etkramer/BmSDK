#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: DrawCapsuleComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class DrawCapsuleComponent : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.DrawCapsuleComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal DrawCapsuleComponent() { }

    /// <summary>
    /// Constructs a new DrawCapsuleComponent
    /// </summary>
    public DrawCapsuleComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, DrawCapsuleComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected DrawCapsuleComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: CapsuleColor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CapsuleColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// ObjectProperty: CapsuleMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CapsuleMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// FloatProperty: CapsuleHeight
    /// </summary>
    public unsafe float CapsuleHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// FloatProperty: CapsuleRadius
    /// </summary>
    public unsafe float CapsuleRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// BoolProperty: bDrawWireCapsule
    /// </summary>
    public unsafe bool bDrawWireCapsule
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 560) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 560); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 560); }
    }

    /// <summary>
    /// BoolProperty: bDrawLitCapsule
    /// </summary>
    public unsafe bool bDrawLitCapsule
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 560) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 560); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 560); }
    }

    /// <summary>
    /// BoolProperty: bDrawOnlyIfSelected
    /// </summary>
    public unsafe bool bDrawOnlyIfSelected
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 560) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 560); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 560); }
    }
}
