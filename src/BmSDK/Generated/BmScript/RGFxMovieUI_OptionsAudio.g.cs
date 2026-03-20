#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RGFxMovieUI_OptionsAudio<br/>
/// (flags = 0)
/// </summary>
public partial class RGFxMovieUI_OptionsAudio : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RGFxMovieUI_OptionsAudio", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieUI_OptionsAudio() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_OptionsAudio
    /// </summary>
    public RGFxMovieUI_OptionsAudio(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_OptionsAudio Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_OptionsAudio(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: FullyLocalisedDialogue
    /// </summary>
    public unsafe BmSDK.FString FullyLocalisedDialogue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// IntProperty: OldDynRange
    /// </summary>
    public unsafe int OldDynRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }
}
