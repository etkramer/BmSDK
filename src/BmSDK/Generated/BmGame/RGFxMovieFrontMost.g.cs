#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieFrontMost<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RGFxMovieFrontMost : BmSDK.BmGame.RGFxMovie, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieFrontMost", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieFrontMost() { }

    /// <summary>
    /// Constructs a new RGFxMovieFrontMost
    /// </summary>
    public RGFxMovieFrontMost(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieFrontMost Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieFrontMost(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: FadeNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> FadeNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// ArrayProperty: CurrentPrompts
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> CurrentPrompts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// ObjectProperty: OnFadedMovieToCallback
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT OnFadedMovieToCallback
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// ByteProperty: JustifyLast
    /// </summary>
    public unsafe byte JustifyLast
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// StrProperty: SubtitlesLast
    /// </summary>
    public unsafe BmSDK.FString SubtitlesLast
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// BoolProperty: bSaveIconActive
    /// </summary>
    public unsafe bool bSaveIconActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 756) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 756); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 756); }
    }

    /// <summary>
    /// BoolProperty: bFadeInProgress
    /// </summary>
    public unsafe bool bFadeInProgress
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 756) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 756); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 756); }
    }

    /// <summary>
    /// FloatProperty: FADE_OUT_TIME
    /// </summary>
    public unsafe float FADE_OUT_TIME
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// FloatProperty: FADE_IN_TIME
    /// </summary>
    public unsafe float FADE_IN_TIME
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// StrProperty: VRamBarPath
    /// </summary>
    public unsafe BmSDK.FString VRamBarPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// FloatProperty: TotalAvailableVRam
    /// </summary>
    public unsafe float TotalAvailableVRam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// Enum: AnimatedFadeType
    /// </summary>
    public enum AnimatedFadeType
    {
        AF_Fade_Bats = 0,
        AF_Fade_Riddler = 1,
        AF_Fade_MAX = 2,
    }
}
