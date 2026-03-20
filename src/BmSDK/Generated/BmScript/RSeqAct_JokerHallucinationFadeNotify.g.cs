#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_JokerHallucinationFadeNotify<br/>
/// (size = 376)
/// (flags = 8210)
/// </summary>
public partial class RSeqAct_JokerHallucinationFadeNotify : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_JokerHallucinationFadeNotify", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_JokerHallucinationFadeNotify() { }

    /// <summary>
    /// Constructs a new RSeqAct_JokerHallucinationFadeNotify
    /// </summary>
    public RSeqAct_JokerHallucinationFadeNotify(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_JokerHallucinationFadeNotify Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_JokerHallucinationFadeNotify(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_JokerHallucinationFadeNotify.GetObjClassVersion", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: Activated
    /// </summary>
    public unsafe void Activated()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_JokerHallucinationFadeNotify.Activated", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ByteProperty: FadeType
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimNotify_JokerHallucination.EFadeType FadeType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimNotify_JokerHallucination.EFadeType>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ArrayProperty: Joker
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnJokerHallucination> Joker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnJokerHallucination>>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// BoolProperty: bDontDelete
    /// </summary>
    public unsafe bool bDontDelete
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 372) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 372); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 372); }
    }
}
