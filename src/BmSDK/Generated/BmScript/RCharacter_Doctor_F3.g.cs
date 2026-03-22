#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCharacter_Doctor_F3<br/>
/// (size = 408)
/// (flags = 18)
/// </summary>
public partial class RCharacter_Doctor_F3 : BmSDK.BmGame.RCharacter, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCharacter_Doctor_F3", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCharacter_Doctor_F3() { }

    /// <summary>
    /// Constructs a new RCharacter_Doctor_F3
    /// </summary>
    public RCharacter_Doctor_F3(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCharacter_Doctor_F3 Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCharacter_Doctor_F3(nint ptr) : base(ptr) { }

}
