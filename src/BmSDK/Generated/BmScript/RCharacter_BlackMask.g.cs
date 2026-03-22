#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCharacter_BlackMask<br/>
/// (size = 408)
/// (flags = 18)
/// </summary>
public partial class RCharacter_BlackMask : BmSDK.BmGame.RCharacter, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCharacter_BlackMask", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCharacter_BlackMask() { }

    /// <summary>
    /// Constructs a new RCharacter_BlackMask
    /// </summary>
    public RCharacter_BlackMask(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCharacter_BlackMask Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCharacter_BlackMask(nint ptr) : base(ptr) { }

}
