#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCharacter_MadHatter_BrokenHat<br/>
/// (size = 408)
/// (flags = 18)
/// </summary>
public partial class RCharacter_MadHatter_BrokenHat : BmSDK.BmScript.RCharacter_MadHatter, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCharacter_MadHatter_BrokenHat", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCharacter_MadHatter_BrokenHat() { }

    /// <summary>
    /// Constructs a new RCharacter_MadHatter_BrokenHat
    /// </summary>
    public RCharacter_MadHatter_BrokenHat(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCharacter_MadHatter_BrokenHat Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCharacter_MadHatter_BrokenHat(nint ptr) : base(ptr) { }

}
