#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieUI_PauseOptionsPlayer<br/>
/// (flags = 0)
/// </summary>
public partial class RGFxMovieUI_PauseOptionsPlayer : BmSDK.BmGame.RGFxMovieUI_PauseBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieUI_PauseOptionsPlayer", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieUI_PauseOptionsPlayer() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_PauseOptionsPlayer
    /// </summary>
    public RGFxMovieUI_PauseOptionsPlayer(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_PauseOptionsPlayer Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_PauseOptionsPlayer(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: WorldPPSettings
    /// </summary>
    public unsafe BmSDK.Engine.PostProcessVolume.FPostProcessSettings WorldPPSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PostProcessVolume.FPostProcessSettings>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// ArrayProperty: PauseScreens
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGFxMovieUI_PauseBase.FScreenDef> PauseScreens
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGFxMovieUI_PauseBase.FScreenDef>>(Ptr + 1596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1596); }
    }
}
