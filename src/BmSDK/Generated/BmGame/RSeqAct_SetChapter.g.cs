#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_SetChapter<br/>
/// (size = 212)
/// (flags = 134226066)
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

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSeqAct_SetChapter>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_SetChapter>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSeqAct_SetChapter>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_SetChapter>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_SetChapter>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSeqAct_SetChapter>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_SetChapter>
        => ((GameObject)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ByteProperty: SideStory
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_SetChapter.ESideStory SideStory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_SetChapter.ESideStory>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// ByteProperty: SubChapter
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_SetChapter.ESubChapter SubChapter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_SetChapter.ESubChapter>(Ptr + 205); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 205); }
    }

    /// <summary>
    /// IntProperty: Chapter
    /// </summary>
    public unsafe int Chapter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
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

    /// <summary>
    /// Enum: ESideStory
    /// </summary>
    public enum ESideStory
    {
        ESideStory_None = 0,
        ESideStory_Azrael = 1,
        ESideStory_Bane = 2,
        ESideStory_C = 3,
        ESideStory_DeadShot = 4,
        ESideStory_E = 5,
        ESideStory_F = 6,
        ESideStory_G = 7,
        ESideStory_Hush = 8,
        ESideStory_I = 9,
        ESideStory_AutoJez = 10,
        ESideStory_K = 11,
        ESideStory_L = 12,
        ESideStory_MadHatter = 13,
        ESideStory_Nora = 14,
        ESideStory_O = 15,
        ESideStory_Paths = 16,
        ESideStory_Q = 17,
        ESideStory_Races = 18,
        ESideStory_S = 19,
        ESideStory_ThugBullies = 20,
        ESideStory_U = 21,
        ESideStory_V = 22,
        ESideStory_W = 23,
        ESideStory_X = 24,
        ESideStory_Y = 25,
        ESideStory_Zsasz = 26,
        ESideStory_MAX = 27,
    }
}
