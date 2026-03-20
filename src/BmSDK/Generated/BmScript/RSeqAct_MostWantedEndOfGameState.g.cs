#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_MostWantedEndOfGameState<br/>
/// (size = 376)
/// (flags = 8210)
/// </summary>
public partial class RSeqAct_MostWantedEndOfGameState : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_MostWantedEndOfGameState", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_MostWantedEndOfGameState() { }

    /// <summary>
    /// Constructs a new RSeqAct_MostWantedEndOfGameState
    /// </summary>
    public RSeqAct_MostWantedEndOfGameState(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_MostWantedEndOfGameState Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_MostWantedEndOfGameState(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_MostWantedEndOfGameState.GetObjClassVersion", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: Activated
    /// </summary>
    public unsafe override void Activated()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_MostWantedEndOfGameState.Activated", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
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
    /// ObjectProperty: RPC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController RPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ObjectProperty: FlagMan
    /// </summary>
    public unsafe BmSDK.BmGame.RFlagManager FlagMan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RFlagManager>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// ByteProperty: SideStory
    /// </summary>
    public unsafe BmSDK.Engine.Actor.ESideStory SideStory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor.ESideStory>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// ByteProperty: SubChapter
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_MostWantedEndOfGameState.ESubChapter SubChapter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_MostWantedEndOfGameState.ESubChapter>(Ptr + 369); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 369); }
    }

    /// <summary>
    /// IntProperty: Chapter
    /// </summary>
    public unsafe int Chapter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }
}
