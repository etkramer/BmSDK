#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCharacter_Outcast3Thin<br/>
/// (size = 584)
/// (flags = 18)
/// </summary>
public partial class RCharacter_Outcast3Thin : BmSDK.BmScript.RCharacter_OutcastBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCharacter_Outcast3Thin", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCharacter_Outcast3Thin() { }

    /// <summary>
    /// Constructs a new RCharacter_Outcast3Thin
    /// </summary>
    public RCharacter_Outcast3Thin(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCharacter_Outcast3Thin Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCharacter_Outcast3Thin(nint ptr) : base(ptr) { }

}
