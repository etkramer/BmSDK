#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieUI_PauseOptionsAudio<br/>
/// (flags = 0)
/// </summary>
public partial class RGFxMovieUI_PauseOptionsAudio : BmSDK.BmGame.RGFxMovieUI_PauseBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieUI_PauseOptionsAudio", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieUI_PauseOptionsAudio() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_PauseOptionsAudio
    /// </summary>
    public RGFxMovieUI_PauseOptionsAudio(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_PauseOptionsAudio Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_PauseOptionsAudio(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: OldDynRange
    /// </summary>
    public unsafe int OldDynRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1612); }
    }
}
