#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxGameViewportClient<br/>
/// (flags = 0)
/// </summary>
public partial class RGFxGameViewportClient : BmSDK.Engine.GameViewportClient, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxGameViewportClient", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxGameViewportClient() { }

    /// <summary>
    /// Constructs a new RGFxGameViewportClient
    /// </summary>
    public RGFxGameViewportClient(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxGameViewportClient Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxGameViewportClient(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bShowCalibrationImage
    /// </summary>
    public unsafe bool bShowCalibrationImage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 460) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 460); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 460); }
    }

    /// <summary>
    /// BoolProperty: bShowSessionDebug
    /// </summary>
    public unsafe bool bShowSessionDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 460) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 460); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 460); }
    }

    /// <summary>
    /// ArrayProperty: ErrorPopup
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGFxMoviePopupRequester> ErrorPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGFxMoviePopupRequester>>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// FloatProperty: SubtitleYLast
    /// </summary>
    public unsafe float SubtitleYLast
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }
}
