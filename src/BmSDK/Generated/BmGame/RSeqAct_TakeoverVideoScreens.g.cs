#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_TakeoverVideoScreens<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_TakeoverVideoScreens : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_TakeoverVideoScreens", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_TakeoverVideoScreens() { }

    /// <summary>
    /// Constructs a new RSeqAct_TakeoverVideoScreens
    /// </summary>
    public RSeqAct_TakeoverVideoScreens(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_TakeoverVideoScreens Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_TakeoverVideoScreens(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: takeoverTexture
    /// </summary>
    public unsafe BmSDK.Engine.TextureRenderTarget2D takeoverTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.TextureRenderTarget2D>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// ByteProperty: takeoverOriginator
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_TakeoverVideoScreens.eVideoTakeoverOriginator takeoverOriginator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_TakeoverVideoScreens.eVideoTakeoverOriginator>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// ByteProperty: TransitionType
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_TakeoverVideoScreens.eVideoTakoverTransitionType TransitionType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_TakeoverVideoScreens.eVideoTakoverTransitionType>(Ptr + 385); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 385); }
    }

    /// <summary>
    /// FloatProperty: TransitionDuration
    /// </summary>
    public unsafe float TransitionDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// FloatProperty: transitionProportion
    /// </summary>
    public unsafe float transitionProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// BoolProperty: bNeedsTransOut
    /// </summary>
    public unsafe bool bNeedsTransOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 396) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 396); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 396); }
    }
}
