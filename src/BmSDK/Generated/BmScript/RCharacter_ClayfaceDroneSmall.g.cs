#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCharacter_ClayfaceDroneSmall<br/>
/// (size = 584)
/// (flags = 18)
/// </summary>
public partial class RCharacter_ClayfaceDroneSmall : BmSDK.BmGame.RCharacter_JokerThug, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCharacter_ClayfaceDroneSmall", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCharacter_ClayfaceDroneSmall() { }

    /// <summary>
    /// Constructs a new RCharacter_ClayfaceDroneSmall
    /// </summary>
    public RCharacter_ClayfaceDroneSmall(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCharacter_ClayfaceDroneSmall Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCharacter_ClayfaceDroneSmall(nint ptr) : base(ptr) { }

}
