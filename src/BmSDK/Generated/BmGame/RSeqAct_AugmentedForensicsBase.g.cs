#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_AugmentedForensicsBase<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqAct_AugmentedForensicsBase : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_AugmentedForensicsBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_AugmentedForensicsBase() { }

    /// <summary>
    /// Constructs a new RSeqAct_AugmentedForensicsBase
    /// </summary>
    public RSeqAct_AugmentedForensicsBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_AugmentedForensicsBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_AugmentedForensicsBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: LinkedMatinee
    /// </summary>
    public unsafe BmSDK.Engine.SeqAct_Interp LinkedMatinee
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SeqAct_Interp>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// FloatProperty: DirectorTrackStart
    /// </summary>
    public unsafe float DirectorTrackStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// FloatProperty: DirectorTrackRange
    /// </summary>
    public unsafe float DirectorTrackRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// IntProperty: AlternateDirectorTrackForPlayback
    /// </summary>
    public unsafe int AlternateDirectorTrackForPlayback
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// IntProperty: AlternateSlomoTrackForPlayback
    /// </summary>
    public unsafe int AlternateSlomoTrackForPlayback
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// BoolProperty: bIsAutoPlay
    /// </summary>
    public unsafe bool bIsAutoPlay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 400) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 400); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 400); }
    }

    /// <summary>
    /// BoolProperty: TimelineVisible
    /// </summary>
    public unsafe bool TimelineVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 400) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 400); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 400); }
    }

    /// <summary>
    /// BoolProperty: TellPlayerToScrub
    /// </summary>
    public unsafe bool TellPlayerToScrub
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 400) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 400); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 400); }
    }

    /// <summary>
    /// FloatProperty: TruncatedInterpLength
    /// </summary>
    public unsafe float TruncatedInterpLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }
}
