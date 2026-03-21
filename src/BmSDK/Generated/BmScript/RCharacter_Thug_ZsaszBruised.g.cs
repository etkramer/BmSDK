#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCharacter_Thug_ZsaszBruised<br/>
/// (size = 584)
/// (flags = 18)
/// </summary>
public partial class RCharacter_Thug_ZsaszBruised : BmSDK.BmScript.RCharacter_Thug_Zsasz, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCharacter_Thug_ZsaszBruised", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCharacter_Thug_ZsaszBruised() { }

    /// <summary>
    /// Constructs a new RCharacter_Thug_ZsaszBruised
    /// </summary>
    public RCharacter_Thug_ZsaszBruised(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCharacter_Thug_ZsaszBruised Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCharacter_Thug_ZsaszBruised(nint ptr) : base(ptr) { }

}
