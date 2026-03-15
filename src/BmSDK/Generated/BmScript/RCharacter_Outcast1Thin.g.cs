#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCharacter_Outcast1Thin<br/>
/// (size = 584)
/// (flags = 18)
/// </summary>
public partial class RCharacter_Outcast1Thin : BmSDK.BmScript.RCharacter_OutcastBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCharacter_Outcast1Thin", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCharacter_Outcast1Thin() { }

    /// <summary>
    /// Constructs a new RCharacter_Outcast1Thin
    /// </summary>
    public RCharacter_Outcast1Thin(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCharacter_Outcast1Thin Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCharacter_Outcast1Thin(nint ptr) : base(ptr) { }

}
