#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RB_RadialImpulseComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RB_RadialImpulseComponent : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RB_RadialImpulseComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RB_RadialImpulseComponent() { }

    /// <summary>
    /// Constructs a new RB_RadialImpulseComponent
    /// </summary>
    public RB_RadialImpulseComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RB_RadialImpulseComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RB_RadialImpulseComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: ImpulseFalloff
    /// </summary>
    public unsafe byte ImpulseFalloff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// FloatProperty: ImpulseStrength
    /// </summary>
    public unsafe float ImpulseStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// FloatProperty: ImpulseRadius
    /// </summary>
    public unsafe float ImpulseRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// BoolProperty: bVelChange
    /// </summary>
    public unsafe bool bVelChange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 552) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 552); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 552); }
    }

    /// <summary>
    /// BoolProperty: bUseSurfaceAreaApproximation
    /// </summary>
    public unsafe bool bUseSurfaceAreaApproximation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 552) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 552); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 552); }
    }

    /// <summary>
    /// BoolProperty: bCauseFracture
    /// </summary>
    public unsafe bool bCauseFracture
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 552) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 552); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 552); }
    }

    /// <summary>
    /// BoolProperty: bCauseApexFracture
    /// </summary>
    public unsafe bool bCauseApexFracture
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 552) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 552); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 552); }
    }

    /// <summary>
    /// BoolProperty: bFireThenDettachSelf
    /// </summary>
    public unsafe bool bFireThenDettachSelf
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 552) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 552); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 552); }
    }

    /// <summary>
    /// StructProperty: AffectedChannels
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AffectedChannels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// FloatProperty: DamageAmount
    /// </summary>
    public unsafe float DamageAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// ClassProperty: DestructiblesDamageType
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DestructiblesDamageType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// ComponentProperty: PreviewSphere
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PreviewSphere
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }
}
