#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: CameraAnimInst<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class CameraAnimInst : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.CameraAnimInst", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal CameraAnimInst() { }

    /// <summary>
    /// Constructs a new CameraAnimInst
    /// </summary>
    public CameraAnimInst(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, CameraAnimInst Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected CameraAnimInst(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: CamAnim
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CamAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ObjectProperty: InterpGroupInst
    /// </summary>
    public unsafe BmSDK.Engine.CameraAnimInst.LastPPSettings InterpGroupInst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CameraAnimInst.LastPPSettings>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ObjectProperty: MoveTrack
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MoveTrack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ObjectProperty: MoveInst
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MoveInst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ObjectProperty: SourceAnimNode
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SourceAnimNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// FloatProperty: CurTime
    /// </summary>
    public unsafe float CurTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// BoolProperty: bLooping
    /// </summary>
    public unsafe bool bLooping
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// BoolProperty: bFinished
    /// </summary>
    public unsafe bool bFinished
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// BoolProperty: bAutoReleaseWhenFinished
    /// </summary>
    public unsafe bool bAutoReleaseWhenFinished
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// BoolProperty: bBlendingIn
    /// </summary>
    public unsafe bool bBlendingIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// BoolProperty: bBlendingOut
    /// </summary>
    public unsafe bool bBlendingOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// FloatProperty: BlendInTime
    /// </summary>
    public unsafe float BlendInTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// FloatProperty: BlendOutTime
    /// </summary>
    public unsafe float BlendOutTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// FloatProperty: CurBlendInTime
    /// </summary>
    public unsafe float CurBlendInTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// FloatProperty: CurBlendOutTime
    /// </summary>
    public unsafe float CurBlendOutTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// FloatProperty: PlayRate
    /// </summary>
    public unsafe float PlayRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// FloatProperty: BasePlayScale
    /// </summary>
    public unsafe float BasePlayScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// FloatProperty: TransientScaleModifier
    /// </summary>
    public unsafe float TransientScaleModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// FloatProperty: CurrentBlendWeight
    /// </summary>
    public unsafe float CurrentBlendWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// FloatProperty: RemainingTime
    /// </summary>
    public unsafe float RemainingTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// ByteProperty: PlaySpace
    /// </summary>
    public unsafe byte PlaySpace
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// StructProperty: UserPlaySpaceMatrix
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT UserPlaySpaceMatrix
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// StructProperty: LastPPSettings
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LastPPSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// FloatProperty: LastPPSettingsAlpha
    /// </summary>
    public unsafe float LastPPSettingsAlpha
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// StructProperty: LastCameraLoc
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LastCameraLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }
}
