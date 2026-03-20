#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RGFxMovieUI_PressStart<br/>
/// (flags = 0)
/// </summary>
public partial class RGFxMovieUI_PressStart : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RGFxMovieUI_PressStart", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieUI_PressStart() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_PressStart
    /// </summary>
    public RGFxMovieUI_PressStart(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_PressStart Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_PressStart(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: PopupType
    /// </summary>
    public unsafe BmSDK.BmScript.RGFxMovieUI_PressStart.PSPopTypes PopupType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RGFxMovieUI_PressStart.PSPopTypes>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// IntProperty: ActiveController
    /// </summary>
    public unsafe int ActiveController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// Enum: PSPopTypes
    /// </summary>
    public enum PSPopTypes
    {
        PSPopType_None = 0,
        PSPopType_Exit = 1,
        PSPopType_AccountPicker = 2,
        PSPopType_MAX = 3,
    }
}
