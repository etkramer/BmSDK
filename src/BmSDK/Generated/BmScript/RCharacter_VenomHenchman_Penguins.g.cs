#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCharacter_VenomHenchman_Penguins<br/>
/// (size = 408)
/// (flags = 18)
/// </summary>
public partial class RCharacter_VenomHenchman_Penguins : BmSDK.BmScript.RCharacter_VenomHenchman, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCharacter_VenomHenchman_Penguins", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCharacter_VenomHenchman_Penguins() { }

    /// <summary>
    /// Constructs a new RCharacter_VenomHenchman_Penguins
    /// </summary>
    public RCharacter_VenomHenchman_Penguins(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCharacter_VenomHenchman_Penguins Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCharacter_VenomHenchman_Penguins(nint ptr) : base(ptr) { }

}
