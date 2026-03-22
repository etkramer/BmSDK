#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCharacter_Cop2<br/>
/// (size = 472)
/// (flags = 18)
/// </summary>
public partial class RCharacter_Cop2 : BmSDK.BmScript.RCharacter_Cop, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCharacter_Cop2", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCharacter_Cop2() { }

    /// <summary>
    /// Constructs a new RCharacter_Cop2
    /// </summary>
    public RCharacter_Cop2(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCharacter_Cop2 Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCharacter_Cop2(nint ptr) : base(ptr) { }

}
