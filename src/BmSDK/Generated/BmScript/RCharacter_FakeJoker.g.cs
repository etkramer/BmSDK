#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCharacter_FakeJoker<br/>
/// (size = 420)
/// (flags = 18)
/// </summary>
public partial class RCharacter_FakeJoker : BmSDK.BmScript.RCharacter_Joker, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCharacter_FakeJoker", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCharacter_FakeJoker() { }

    /// <summary>
    /// Constructs a new RCharacter_FakeJoker
    /// </summary>
    public RCharacter_FakeJoker(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCharacter_FakeJoker Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCharacter_FakeJoker(nint ptr) : base(ptr) { }

}
