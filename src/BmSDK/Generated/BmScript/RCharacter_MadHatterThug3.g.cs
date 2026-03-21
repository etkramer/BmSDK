#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCharacter_MadHatterThug3<br/>
/// (size = 584)
/// (flags = 18)
/// </summary>
public partial class RCharacter_MadHatterThug3 : BmSDK.BmScript.RCharacter_JokerThug1, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCharacter_MadHatterThug3", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCharacter_MadHatterThug3() { }

    /// <summary>
    /// Constructs a new RCharacter_MadHatterThug3
    /// </summary>
    public RCharacter_MadHatterThug3(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCharacter_MadHatterThug3 Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCharacter_MadHatterThug3(nint ptr) : base(ptr) { }

}
