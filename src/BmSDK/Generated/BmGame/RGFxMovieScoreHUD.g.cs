#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieScoreHUD<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RGFxMovieScoreHUD : BmSDK.BmGame.RGFxMovie, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieScoreHUD", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieScoreHUD() { }

    /// <summary>
    /// Constructs a new RGFxMovieScoreHUD
    /// </summary>
    public RGFxMovieScoreHUD(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieScoreHUD Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieScoreHUD(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: TotalScore
    /// </summary>
    public unsafe int TotalScore
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// FloatProperty: PredatorTime
    /// </summary>
    public unsafe float PredatorTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bNoPause
    /// </summary>
    public unsafe bool bNoPause
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 704); }
    }

    /// <summary>
    /// BoolProperty: bUseHeadToHeadScores
    /// </summary>
    public unsafe bool bUseHeadToHeadScores
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 704); }
    }
}
