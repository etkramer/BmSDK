#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAnimNotify_JokerHallucination<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RAnimNotify_JokerHallucination : BmSDK.Engine.AnimNotify, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimNotify_JokerHallucination", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimNotify_JokerHallucination() { }

    /// <summary>
    /// Constructs a new RAnimNotify_JokerHallucination
    /// </summary>
    public RAnimNotify_JokerHallucination(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnimNotify_JokerHallucination Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimNotify_JokerHallucination(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bNoDelete
    /// </summary>
    public unsafe bool bNoDelete
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 84); }
    }

    /// <summary>
    /// BoolProperty: bDisableTouchFade
    /// </summary>
    public unsafe bool bDisableTouchFade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 84); }
    }

    /// <summary>
    /// ByteProperty: FadeType
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimNotify_JokerHallucination.EFadeType FadeType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimNotify_JokerHallucination.EFadeType>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// Enum: EFadeType
    /// </summary>
    public enum EFadeType
    {
        FadeOutNow = 0,
        FadeOutWhenOffScreen = 1,
        FadeOutWhenOffScreenOrThisAnimOver = 2,
        FadeOutNowInstant = 3,
        FadeIn = 4,
        FadeInInstant = 5,
        FadeNone = 6,
        FadeInWhenOffScreen = 7,
        EFadeType_MAX = 8,
    }
}
