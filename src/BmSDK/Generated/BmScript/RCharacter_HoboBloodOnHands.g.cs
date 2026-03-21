#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCharacter_HoboBloodOnHands<br/>
/// (size = 584)
/// (flags = 18)
/// </summary>
public partial class RCharacter_HoboBloodOnHands : BmSDK.BmGame.RCharacter_JokerThug, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCharacter_HoboBloodOnHands", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCharacter_HoboBloodOnHands() { }

    /// <summary>
    /// Constructs a new RCharacter_HoboBloodOnHands
    /// </summary>
    public RCharacter_HoboBloodOnHands(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCharacter_HoboBloodOnHands Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCharacter_HoboBloodOnHands(nint ptr) : base(ptr) { }

}
