#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_SetChapter<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_SetChapter : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_SetChapter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_SetChapter() { }

    /// <summary>
    /// Constructs a new RSeqAct_SetChapter
    /// </summary>
    public RSeqAct_SetChapter(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_SetChapter Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_SetChapter(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: SideStory
    /// </summary>
    public unsafe byte SideStory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ByteProperty: SubChapter
    /// </summary>
    public unsafe byte SubChapter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 353); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 353); }
    }

    /// <summary>
    /// IntProperty: Chapter
    /// </summary>
    public unsafe int Chapter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// Enum: ESubChapter
    /// </summary>
    public enum ESubChapter
    {
        ESubChapter_None = 0,
        ESubChapter_a = 1,
        ESubChapter_b = 2,
        ESubChapter_c = 3,
        ESubChapter_d = 4,
        ESubChapter_e = 5,
        ESubChapter_f = 6,
        ESubChapter_g = 7,
        ESubChapter_h = 8,
        ESubChapter_i = 9,
        ESubChapter_j = 10,
        ESubChapter_k = 11,
        ESubChapter_l = 12,
        ESubChapter_m = 13,
        ESubChapter_n = 14,
        ESubChapter_o = 15,
        ESubChapter_p = 16,
        ESubChapter_q = 17,
        ESubChapter_r = 18,
        ESubChapter_s = 19,
        ESubChapter_t = 20,
        ESubChapter_u = 21,
        ESubChapter_v = 22,
        ESubChapter_w = 23,
        ESubChapter_x = 24,
        ESubChapter_y = 25,
        ESubChapter_z = 26,
        ESubChapter_MAX = 27,
    }
}
