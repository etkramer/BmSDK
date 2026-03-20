#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_FireflyHud<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqAct_FireflyHud : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_FireflyHud", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_FireflyHud() { }

    /// <summary>
    /// Constructs a new RSeqAct_FireflyHud
    /// </summary>
    public RSeqAct_FireflyHud(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_FireflyHud Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_FireflyHud(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: TheMovieInstance
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie TheMovieInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ObjectProperty: RPC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController RPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// ObjectProperty: FireflyModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleFirefly FireflyModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleFirefly>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }
}
