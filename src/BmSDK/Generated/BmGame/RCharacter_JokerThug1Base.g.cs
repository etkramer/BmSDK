#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RCharacter_JokerThug1Base<br/>
/// (size = 584)
/// (flags = 67108883)
/// </summary>
public partial class RCharacter_JokerThug1Base : BmSDK.BmGame.RCharacter_JokerThug, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCharacter_JokerThug1Base", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCharacter_JokerThug1Base() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCharacter_JokerThug1Base(nint ptr) : base(ptr) { }

}
