#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCharacter_OutcastTwoFace2<br/>
/// (size = 584)
/// (flags = 18)
/// </summary>
public partial class RCharacter_OutcastTwoFace2 : BmSDK.BmGame.RCharacter_TwoFaceThugBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCharacter_OutcastTwoFace2", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCharacter_OutcastTwoFace2() { }

    /// <summary>
    /// Constructs a new RCharacter_OutcastTwoFace2
    /// </summary>
    public RCharacter_OutcastTwoFace2(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCharacter_OutcastTwoFace2 Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCharacter_OutcastTwoFace2(nint ptr) : base(ptr) { }

}
