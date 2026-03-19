#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieUI_PauseOptionsExtras<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RGFxMovieUI_PauseOptionsExtras : BmSDK.BmGame.RGFxMovieUI_PauseBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieUI_PauseOptionsExtras", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieUI_PauseOptionsExtras() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_PauseOptionsExtras
    /// </summary>
    public RGFxMovieUI_PauseOptionsExtras(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_PauseOptionsExtras Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_PauseOptionsExtras(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: WorldPPSettings
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieUI_PauseBase.PauseScreens WorldPPSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieUI_PauseBase.PauseScreens>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// ArrayProperty: PauseScreens
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> PauseScreens
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1596); }
    }
}
