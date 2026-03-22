#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCharacter_Hobo_Gen1<br/>
/// (size = 584)
/// (flags = 18)
/// </summary>
public partial class RCharacter_Hobo_Gen1 : BmSDK.BmGame.RCharacter_JokerThug, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCharacter_Hobo_Gen1", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCharacter_Hobo_Gen1() { }

    /// <summary>
    /// Constructs a new RCharacter_Hobo_Gen1
    /// </summary>
    public RCharacter_Hobo_Gen1(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCharacter_Hobo_Gen1 Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCharacter_Hobo_Gen1(nint ptr) : base(ptr) { }

}
