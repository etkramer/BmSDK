#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_WaitForCutscenesToFinish<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqAct_WaitForCutscenesToFinish : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_WaitForCutscenesToFinish", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_WaitForCutscenesToFinish() { }

    /// <summary>
    /// Constructs a new RSeqAct_WaitForCutscenesToFinish
    /// </summary>
    public RSeqAct_WaitForCutscenesToFinish(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_WaitForCutscenesToFinish Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_WaitForCutscenesToFinish(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: CurrController
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController CurrController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// FloatProperty: CurrentDelayTimer
    /// </summary>
    public unsafe float CurrentDelayTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// FloatProperty: DelayTimer
    /// </summary>
    public unsafe float DelayTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }
}
