#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCharacter_PenguinThug2_Head5_Thin<br/>
/// (size = 556)
/// (flags = 18)
/// </summary>
public partial class RCharacter_PenguinThug2_Head5_Thin : BmSDK.BmScript.RCharacter_PenguinThug, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCharacter_PenguinThug2_Head5_Thin", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCharacter_PenguinThug2_Head5_Thin() { }

    /// <summary>
    /// Constructs a new RCharacter_PenguinThug2_Head5_Thin
    /// </summary>
    public RCharacter_PenguinThug2_Head5_Thin(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCharacter_PenguinThug2_Head5_Thin Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCharacter_PenguinThug2_Head5_Thin(nint ptr) : base(ptr) { }

}
