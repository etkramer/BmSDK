#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCharacter_PenguinThug2_Head5<br/>
/// (size = 556)
/// (flags = 18)
/// </summary>
public partial class RCharacter_PenguinThug2_Head5 : BmSDK.BmScript.RCharacter_PenguinThug, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCharacter_PenguinThug2_Head5", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCharacter_PenguinThug2_Head5() { }

    /// <summary>
    /// Constructs a new RCharacter_PenguinThug2_Head5
    /// </summary>
    public RCharacter_PenguinThug2_Head5(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCharacter_PenguinThug2_Head5 Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCharacter_PenguinThug2_Head5(nint ptr) : base(ptr) { }

}
