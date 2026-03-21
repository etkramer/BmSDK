#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// ABSTRACT Class: RCharacter_VenomHenchman<br/>
/// (size = 408)
/// (flags = 19)
/// </summary>
public partial class RCharacter_VenomHenchman : BmSDK.BmScript.RCharacter_Venom, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCharacter_VenomHenchman", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCharacter_VenomHenchman() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCharacter_VenomHenchman(nint ptr) : base(ptr) { }

}
