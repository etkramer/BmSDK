#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_PlayGfxMovie<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqAct_PlayGfxMovie : BmSDK.GFxUI.GFxAction_OpenMovie, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_PlayGfxMovie", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_PlayGfxMovie() { }

    /// <summary>
    /// Constructs a new RSeqAct_PlayGfxMovie
    /// </summary>
    public RSeqAct_PlayGfxMovie(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_PlayGfxMovie Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_PlayGfxMovie(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bPauseGame
    /// </summary>
    public unsafe bool bPauseGame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 424); }
    }

    /// <summary>
    /// ByteProperty: TimingMode
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxMoviePlayer.GFxTimingMode TimingMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxMoviePlayer.GFxTimingMode>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }
}
