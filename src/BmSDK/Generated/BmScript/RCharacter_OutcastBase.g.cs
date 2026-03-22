#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCharacter_OutcastBase<br/>
/// (size = 584)
/// (flags = 18)
/// </summary>
public partial class RCharacter_OutcastBase : BmSDK.BmGame.RCharacter_JokerThug, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCharacter_OutcastBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCharacter_OutcastBase() { }

    /// <summary>
    /// Constructs a new RCharacter_OutcastBase
    /// </summary>
    public RCharacter_OutcastBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCharacter_OutcastBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCharacter_OutcastBase(nint ptr) : base(ptr) { }

}
