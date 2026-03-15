#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RGFxMovieUI_RiddlerMapSelect<br/>
/// (size = 736)
/// (flags = 18)
/// </summary>
public partial class RGFxMovieUI_RiddlerMapSelect : BmSDK.BmGame.RGFxMovieUI_RiddlerMapSelectBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RGFxMovieUI_RiddlerMapSelect", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieUI_RiddlerMapSelect() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_RiddlerMapSelect
    /// </summary>
    public RGFxMovieUI_RiddlerMapSelect(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_RiddlerMapSelect Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_RiddlerMapSelect(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: BuildLoadList
    /// </summary>
    public unsafe bool BuildLoadList()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieUI_RiddlerMapSelect.BuildLoadList", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// ArrayProperty: BaseIconRef
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GFxUI.SwfMovie> BaseIconRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GFxUI.SwfMovie>>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }
}
