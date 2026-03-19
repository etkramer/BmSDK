#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SeqAct_PlaySound<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class SeqAct_PlaySound : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SeqAct_PlaySound", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqAct_PlaySound() { }

    /// <summary>
    /// Constructs a new SeqAct_PlaySound
    /// </summary>
    public SeqAct_PlaySound(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqAct_PlaySound Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqAct_PlaySound(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: PlaySound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlaySound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// FloatProperty: ExtraDelay
    /// </summary>
    public unsafe float ExtraDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// BoolProperty: bDelayReached
    /// </summary>
    public unsafe bool bDelayReached
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 388); }
    }

    /// <summary>
    /// BoolProperty: bSuppressSubtitles
    /// </summary>
    public unsafe bool bSuppressSubtitles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 388); }
    }

    /// <summary>
    /// BoolProperty: bStopped
    /// </summary>
    public unsafe bool bStopped
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 388); }
    }

    /// <summary>
    /// FloatProperty: SoundDuration
    /// </summary>
    public unsafe float SoundDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// FloatProperty: FadeInTime
    /// </summary>
    public unsafe float FadeInTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// FloatProperty: FadeOutTime
    /// </summary>
    public unsafe float FadeOutTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// FloatProperty: VolumeMultiplier
    /// </summary>
    public unsafe float VolumeMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// FloatProperty: PitchMultiplier
    /// </summary>
    public unsafe float PitchMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// FloatProperty: BeforeEndTime
    /// </summary>
    public unsafe float BeforeEndTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }
}
