#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCharacter_JokerThug1Thin_Mask<br/>
/// (size = 584)
/// (flags = 18)
/// </summary>
public partial class RCharacter_JokerThug1Thin_Mask : BmSDK.BmScript.RCharacter_JokerThug1Thin, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCharacter_JokerThug1Thin_Mask", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCharacter_JokerThug1Thin_Mask() { }

    /// <summary>
    /// Constructs a new RCharacter_JokerThug1Thin_Mask
    /// </summary>
    public RCharacter_JokerThug1Thin_Mask(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCharacter_JokerThug1Thin_Mask Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCharacter_JokerThug1Thin_Mask(nint ptr) : base(ptr) { }

}
