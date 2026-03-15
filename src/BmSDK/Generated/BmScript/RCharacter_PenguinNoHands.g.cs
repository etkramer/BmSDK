#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCharacter_PenguinNoHands<br/>
/// (size = 408)
/// (flags = 18)
/// </summary>
public partial class RCharacter_PenguinNoHands : BmSDK.BmGame.RCharacter, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCharacter_PenguinNoHands", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCharacter_PenguinNoHands() { }

    /// <summary>
    /// Constructs a new RCharacter_PenguinNoHands
    /// </summary>
    public RCharacter_PenguinNoHands(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCharacter_PenguinNoHands Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCharacter_PenguinNoHands(nint ptr) : base(ptr) { }

}
