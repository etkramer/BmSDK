#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SeqAct_CameraShake<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class SeqAct_CameraShake : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SeqAct_CameraShake", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqAct_CameraShake() { }

    /// <summary>
    /// Constructs a new SeqAct_CameraShake
    /// </summary>
    public SeqAct_CameraShake(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqAct_CameraShake Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqAct_CameraShake(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Shake
    /// </summary>
    public unsafe BmSDK.Engine.SequenceAction.Targets Shake
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SequenceAction.Targets>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ObjectProperty: LocationActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LocationActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// FloatProperty: ShakeScale
    /// </summary>
    public unsafe float ShakeScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// BoolProperty: bDoControllerVibration
    /// </summary>
    public unsafe bool bDoControllerVibration
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 372) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 372); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 372); }
    }

    /// <summary>
    /// BoolProperty: bRadialShake
    /// </summary>
    public unsafe bool bRadialShake
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 372) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 372); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 372); }
    }

    /// <summary>
    /// BoolProperty: bOrientTowardRadialEpicenter
    /// </summary>
    public unsafe bool bOrientTowardRadialEpicenter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 372) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 372); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 372); }
    }

    /// <summary>
    /// FloatProperty: RadialShake_InnerRadius
    /// </summary>
    public unsafe float RadialShake_InnerRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// FloatProperty: RadialShake_OuterRadius
    /// </summary>
    public unsafe float RadialShake_OuterRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// FloatProperty: RadialShake_Falloff
    /// </summary>
    public unsafe float RadialShake_Falloff
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
