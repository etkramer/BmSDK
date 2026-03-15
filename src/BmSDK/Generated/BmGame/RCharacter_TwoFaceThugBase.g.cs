#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RCharacter_TwoFaceThugBase<br/>
/// (size = 584)
/// (flags = 19)
/// </summary>
public partial class RCharacter_TwoFaceThugBase : BmSDK.BmGame.RCharacter_JokerThug, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCharacter_TwoFaceThugBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCharacter_TwoFaceThugBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCharacter_TwoFaceThugBase(nint ptr) : base(ptr) { }

}
