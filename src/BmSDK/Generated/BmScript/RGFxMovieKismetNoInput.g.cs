#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RGFxMovieKismetNoInput<br/>
/// (size = 696)
/// (flags = 22)
/// </summary>
public partial class RGFxMovieKismetNoInput : BmSDK.BmGame.RGFxMovieKismetBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RGFxMovieKismetNoInput", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieKismetNoInput() { }

    /// <summary>
    /// Constructs a new RGFxMovieKismetNoInput
    /// </summary>
    public RGFxMovieKismetNoInput(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieKismetNoInput Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieKismetNoInput(nint ptr) : base(ptr) { }

}
