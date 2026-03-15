#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCharacter_PenguinThug1_Head7_Thin<br/>
/// (size = 556)
/// (flags = 18)
/// </summary>
public partial class RCharacter_PenguinThug1_Head7_Thin : BmSDK.BmScript.RCharacter_PenguinThug, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCharacter_PenguinThug1_Head7_Thin", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCharacter_PenguinThug1_Head7_Thin() { }

    /// <summary>
    /// Constructs a new RCharacter_PenguinThug1_Head7_Thin
    /// </summary>
    public RCharacter_PenguinThug1_Head7_Thin(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCharacter_PenguinThug1_Head7_Thin Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCharacter_PenguinThug1_Head7_Thin(nint ptr) : base(ptr) { }

}
