#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieUI_ChallengeSymbolMini<br/>
/// (flags = 0)
/// </summary>
public partial class RGFxMovieUI_ChallengeSymbolMini : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieUI_ChallengeSymbolMini", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieUI_ChallengeSymbolMini() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_ChallengeSymbolMini
    /// </summary>
    public RGFxMovieUI_ChallengeSymbolMini(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_ChallengeSymbolMini Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_ChallengeSymbolMini(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: CMan
    /// </summary>
    public unsafe BmSDK.BmGame.RChallengeManager CMan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RChallengeManager>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// ObjectProperty: AssociatedActor
    /// </summary>
    public unsafe BmSDK.BmGame.RChallengeModeStartPointBase AssociatedActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RChallengeModeStartPointBase>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// ObjectProperty: LookAtActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor LookAtActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// IntProperty: ChallengeID
    /// </summary>
    public unsafe int ChallengeID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// BoolProperty: bVisible
    /// </summary>
    public unsafe bool bVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1100) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1100); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1100); }
    }

    /// <summary>
    /// BoolProperty: bNotSet
    /// </summary>
    public unsafe bool bNotSet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1100) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1100); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1100); }
    }

    /// <summary>
    /// IntProperty: CharacterId
    /// </summary>
    public unsafe int CharacterId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }
}
