#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SeqAct_PlayCameraAnim<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class SeqAct_PlayCameraAnim : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SeqAct_PlayCameraAnim", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqAct_PlayCameraAnim() { }

    /// <summary>
    /// Constructs a new SeqAct_PlayCameraAnim
    /// </summary>
    public SeqAct_PlayCameraAnim(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqAct_PlayCameraAnim Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqAct_PlayCameraAnim(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: CameraAnim
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CameraAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ObjectProperty: UserDefinedSpaceActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT UserDefinedSpaceActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// BoolProperty: bLoop
    /// </summary>
    public unsafe bool bLoop
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 368); }
    }

    /// <summary>
    /// BoolProperty: bRandomStartTime
    /// </summary>
    public unsafe bool bRandomStartTime
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 368); }
    }

    /// <summary>
    /// FloatProperty: BlendInTime
    /// </summary>
    public unsafe float BlendInTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// FloatProperty: BlendOutTime
    /// </summary>
    public unsafe float BlendOutTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// FloatProperty: Rate
    /// </summary>
    public unsafe float Rate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// FloatProperty: IntensityScale
    /// </summary>
    public unsafe float IntensityScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// ByteProperty: PlaySpace
    /// </summary>
    public unsafe byte PlaySpace
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }
}
