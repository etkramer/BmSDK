#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCharacter_PDLC_HarleyThug_Thin<br/>
/// (size = 432)
/// (flags = 18)
/// </summary>
public partial class RCharacter_PDLC_HarleyThug_Thin : BmSDK.BmGame.RCharacter_PDLC_HarleyThugBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCharacter_PDLC_HarleyThug_Thin", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCharacter_PDLC_HarleyThug_Thin() { }

    /// <summary>
    /// Constructs a new RCharacter_PDLC_HarleyThug_Thin
    /// </summary>
    public RCharacter_PDLC_HarleyThug_Thin(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCharacter_PDLC_HarleyThug_Thin Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCharacter_PDLC_HarleyThug_Thin(nint ptr) : base(ptr) { }

}
