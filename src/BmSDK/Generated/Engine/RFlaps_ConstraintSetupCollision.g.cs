#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RFlaps_ConstraintSetupCollision<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RFlaps_ConstraintSetupCollision : BmSDK.Engine.RFlaps_ConstraintSetup, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RFlaps_ConstraintSetupCollision", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RFlaps_ConstraintSetupCollision() { }

    /// <summary>
    /// Constructs a new RFlaps_ConstraintSetupCollision
    /// </summary>
    public RFlaps_ConstraintSetupCollision(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RFlaps_ConstraintSetupCollision Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RFlaps_ConstraintSetupCollision(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: ConstrainedParticle
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ConstrainedParticle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// FloatProperty: Friction
    /// </summary>
    public unsafe float Friction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// FloatProperty: Restitution
    /// </summary>
    public unsafe float Restitution
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// NameProperty: BoneNames
    /// </summary>
    public unsafe BmSDK.FName BoneNames_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }
    /// <summary>
    /// NameProperty: BoneNames
    /// </summary>
    public unsafe BmSDK.FName BoneNames_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }
    /// <summary>
    /// NameProperty: BoneNames
    /// </summary>
    public unsafe BmSDK.FName BoneNames_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }
    /// <summary>
    /// NameProperty: BoneNames
    /// </summary>
    public unsafe BmSDK.FName BoneNames_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }
    /// <summary>
    /// NameProperty: BoneNames
    /// </summary>
    public unsafe BmSDK.FName BoneNames_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }
    /// <summary>
    /// NameProperty: BoneNames
    /// </summary>
    public unsafe BmSDK.FName BoneNames_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }
    /// <summary>
    /// NameProperty: BoneNames
    /// </summary>
    public unsafe BmSDK.FName BoneNames_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }
    /// <summary>
    /// NameProperty: BoneNames
    /// </summary>
    public unsafe BmSDK.FName BoneNames_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

}
