#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: DrawTaperedCapsuleComponent<br/>
/// (flags = 0)
/// </summary>
public partial class DrawTaperedCapsuleComponent : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.DrawTaperedCapsuleComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal DrawTaperedCapsuleComponent() { }

    /// <summary>
    /// Constructs a new DrawTaperedCapsuleComponent
    /// </summary>
    public DrawTaperedCapsuleComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, DrawTaperedCapsuleComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected DrawTaperedCapsuleComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: CapsuleColor
    /// </summary>
    public unsafe BmSDK.GameObject.FColor CapsuleColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// ObjectProperty: CapsuleMaterial
    /// </summary>
    public unsafe BmSDK.Engine.Material CapsuleMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material>(Ptr + 544); }
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
    /// FloatProperty: CapsuleTopRadius
    /// </summary>
    public unsafe float CapsuleTopRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// BoolProperty: bDrawWireCapsule
    /// </summary>
    public unsafe bool bDrawWireCapsule
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 564) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 564); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 564); }
    }

    /// <summary>
    /// BoolProperty: bDrawLitCapsule
    /// </summary>
    public unsafe bool bDrawLitCapsule
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 564) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 564); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 564); }
    }

    /// <summary>
    /// BoolProperty: bDrawOnlyIfSelected
    /// </summary>
    public unsafe bool bDrawOnlyIfSelected
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 564) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 564); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 564); }
    }
}
