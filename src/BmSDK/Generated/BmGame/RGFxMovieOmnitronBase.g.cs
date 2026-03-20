#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieOmnitronBase<br/>
/// (flags = 0)
/// </summary>
public partial class RGFxMovieOmnitronBase : BmSDK.BmGame.RGFxMovie, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieOmnitronBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieOmnitronBase() { }

    /// <summary>
    /// Constructs a new RGFxMovieOmnitronBase
    /// </summary>
    public RGFxMovieOmnitronBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieOmnitronBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieOmnitronBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: FlashRumbleValueLeft
    /// </summary>
    public unsafe float FlashRumbleValueLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// FloatProperty: FlashRumbleValueRight
    /// </summary>
    public unsafe float FlashRumbleValueRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: PasswordFound
    /// </summary>
    public unsafe bool PasswordFound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 704); }
    }

    /// <summary>
    /// BoolProperty: MinigameComplete
    /// </summary>
    public unsafe bool MinigameComplete
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 704); }
    }

    /// <summary>
    /// ObjectProperty: SpecialMoveVar
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMovieInstance_MinigameBase SpecialMoveVar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMovieInstance_MinigameBase>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// ObjectProperty: MovieInfoBrainHacking
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie MovieInfoBrainHacking
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }
}
