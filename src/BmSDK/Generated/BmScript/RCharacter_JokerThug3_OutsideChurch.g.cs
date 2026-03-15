#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCharacter_JokerThug3_OutsideChurch<br/>
/// (size = 584)
/// (flags = 18)
/// </summary>
public partial class RCharacter_JokerThug3_OutsideChurch : BmSDK.BmScript.RCharacter_JokerThug2Fat, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCharacter_JokerThug3_OutsideChurch", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCharacter_JokerThug3_OutsideChurch() { }

    /// <summary>
    /// Constructs a new RCharacter_JokerThug3_OutsideChurch
    /// </summary>
    public RCharacter_JokerThug3_OutsideChurch(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCharacter_JokerThug3_OutsideChurch Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCharacter_JokerThug3_OutsideChurch(nint ptr) : base(ptr) { }

}
