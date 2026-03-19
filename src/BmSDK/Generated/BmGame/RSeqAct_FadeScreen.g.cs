#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_FadeScreen<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_FadeScreen : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_FadeScreen", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_FadeScreen() { }

    /// <summary>
    /// Constructs a new RSeqAct_FadeScreen
    /// </summary>
    public RSeqAct_FadeScreen(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_FadeScreen Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_FadeScreen(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: FadeInTime
    /// </summary>
    public unsafe float FadeInTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// FloatProperty: FadeOutTime
    /// </summary>
    public unsafe float FadeOutTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// BoolProperty: bSeqActive
    /// </summary>
    public unsafe bool bSeqActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 384) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 384); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 384); }
    }

    /// <summary>
    /// BoolProperty: bFadesAudio
    /// </summary>
    public unsafe bool bFadesAudio
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 384) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 384); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 384); }
    }

    /// <summary>
    /// BoolProperty: bFadeIn
    /// </summary>
    public unsafe bool bFadeIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 384) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 384); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 384); }
    }

    /// <summary>
    /// BoolProperty: IncludeInMovieCaptures
    /// </summary>
    public unsafe bool IncludeInMovieCaptures
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 384) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 384); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 384); }
    }

    /// <summary>
    /// FloatProperty: FadeR
    /// </summary>
    public unsafe float FadeR
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// FloatProperty: FadeG
    /// </summary>
    public unsafe float FadeG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// FloatProperty: FadeB
    /// </summary>
    public unsafe float FadeB
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }
}
