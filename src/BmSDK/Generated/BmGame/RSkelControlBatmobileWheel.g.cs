#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSkelControlBatmobileWheel<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSkelControlBatmobileWheel : BmSDK.Engine.SkelControlWheel, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSkelControlBatmobileWheel", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSkelControlBatmobileWheel() { }

    /// <summary>
    /// Constructs a new RSkelControlBatmobileWheel
    /// </summary>
    public RSkelControlBatmobileWheel(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSkelControlBatmobileWheel Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSkelControlBatmobileWheel(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: SuspensionBone
    /// </summary>
    public unsafe BmSDK.FName SuspensionBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }

    /// <summary>
    /// NameProperty: DiskBrakeBone
    /// </summary>
    public unsafe BmSDK.FName DiskBrakeBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// NameProperty: WheelBone
    /// </summary>
    public unsafe BmSDK.FName WheelBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }

    /// <summary>
    /// NameProperty: CoolingDiskBone
    /// </summary>
    public unsafe BmSDK.FName CoolingDiskBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// StructProperty: SuspensionRotAxis
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SuspensionRotAxis
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }

    /// <summary>
    /// FloatProperty: WheelSteeringVisualLimitDeg
    /// </summary>
    public unsafe float WheelSteeringVisualLimitDeg
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// FloatProperty: CoolingDiskSpinSpeed
    /// </summary>
    public unsafe float CoolingDiskSpinSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }

    /// <summary>
    /// StructProperty: SquashAxis
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SquashAxis
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }

    /// <summary>
    /// FloatProperty: SquashMaxDist
    /// </summary>
    public unsafe float SquashMaxDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 344); }
    }

    /// <summary>
    /// IntProperty: SuspensionBoneIndex
    /// </summary>
    public unsafe int SuspensionBoneIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// IntProperty: DiskBrakeBoneIndex
    /// </summary>
    public unsafe int DiskBrakeBoneIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// IntProperty: WheelBoneIndex
    /// </summary>
    public unsafe int WheelBoneIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// IntProperty: CoolingDiskBoneIndex
    /// </summary>
    public unsafe int CoolingDiskBoneIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// FloatProperty: SuspensionStrutLength
    /// </summary>
    public unsafe float SuspensionStrutLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }

    /// <summary>
    /// FloatProperty: CoolingDiskCurRot
    /// </summary>
    public unsafe float CoolingDiskCurRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// FloatProperty: SquashDist
    /// </summary>
    public unsafe float SquashDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// FloatProperty: WantSquashDist
    /// </summary>
    public unsafe float WantSquashDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// FloatProperty: LastSpinVel
    /// </summary>
    public unsafe float LastSpinVel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }
}
