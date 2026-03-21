#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAnimNotify_Emote<br/>
/// (size = 69)
/// (flags = 134230162)
/// </summary>
public partial class RAnimNotify_Emote : BmSDK.BmGame.RAnimNotify_Script, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimNotify_Emote", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimNotify_Emote() { }

    /// <summary>
    /// Constructs a new RAnimNotify_Emote
    /// </summary>
    public RAnimNotify_Emote(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnimNotify_Emote Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimNotify_Emote(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: EmoteType
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimNotify_Emote.EEmoteType EmoteType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimNotify_Emote.EEmoteType>(Ptr + 68); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }
    }

    /// <summary>
    /// Enum: EEmoteType
    /// </summary>
    public enum EEmoteType
    {
        Emote_Dazed = 0,
        Emote_ExertLight = 1,
        Emote_ExertMed = 2,
        Emote_Fall = 3,
        Emote_HurtCollapse = 4,
        Emote_HurtLight = 5,
        Emote_HurtMed = 6,
        Emote_HurtStrong = 7,
        Emote_HurtPassout = 8,
        Emote_Kicked = 9,
        Emote_Punched = 10,
        Emote_Laugh = 11,
        Emote_Muffled = 12,
        Emote_RoarAngry = 13,
        Emote_RoarThrown = 14,
        Emote_StopMuffle = 15,
        Emote_StopAll = 16,
        Emote_MAX = 17,
    }
}
