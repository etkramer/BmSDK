#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAnimNotify_PickupProp<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RAnimNotify_PickupProp : BmSDK.Engine.AnimNotify, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimNotify_PickupProp", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimNotify_PickupProp() { }

    /// <summary>
    /// Constructs a new RAnimNotify_PickupProp
    /// </summary>
    public RAnimNotify_PickupProp(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnimNotify_PickupProp Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimNotify_PickupProp(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: PickupType
    /// </summary>
    public unsafe byte PickupType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ObjectProperty: CustomMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CustomMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// ObjectProperty: CustomPhysics
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CustomPhysics
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// ObjectProperty: CustomMeshStatic
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CustomMeshStatic
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// ObjectProperty: AnimSet
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: bLeftHand
    /// </summary>
    public unsafe bool bLeftHand
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: bOverrideExisting
    /// </summary>
    public unsafe bool bOverrideExisting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: bDrawInFrontOfPostProcessWhenInXrayMode
    /// </summary>
    public unsafe bool bDrawInFrontOfPostProcessWhenInXrayMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: bDrawInForegroundAndInFrontOfPostProcessWhenInXrayMode
    /// </summary>
    public unsafe bool bDrawInForegroundAndInFrontOfPostProcessWhenInXrayMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: bDrawInFrontOfPostProcessWhenInThermalMode
    /// </summary>
    public unsafe bool bDrawInFrontOfPostProcessWhenInThermalMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: bDrawInForegroundAndInFrontOfPostProcessWhenInThermalMode
    /// </summary>
    public unsafe bool bDrawInForegroundAndInFrontOfPostProcessWhenInThermalMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: bPlayAnim
    /// </summary>
    public unsafe bool bPlayAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// ArrayProperty: XrayMats
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT XrayMats
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// NameProperty: AnimationName
    /// </summary>
    public unsafe BmSDK.FName AnimationName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// StructProperty: AdvancedDropSettings
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AdvancedDropSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// Enum: RiotPickupType
    /// </summary>
    public enum RiotPickupType
    {
        RPT_Custom = 0,
        RPT_Pipe = 1,
        RPT_Stone = 2,
        RPT_Brick = 3,
        RPT_Spraycan = 4,
        RPT_Molotov = 5,
        RPT_Drop = 6,
        RPT_Delete = 7,
        RPT_Flare = 8,
        RPT_MAX = 9,
    }
}
