#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCharacter_Outcast3Fat<br/>
/// (size = 584)
/// (flags = 18)
/// </summary>
public partial class RCharacter_Outcast3Fat : BmSDK.BmScript.RCharacter_OutcastBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCharacter_Outcast3Fat", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCharacter_Outcast3Fat() { }

    /// <summary>
    /// Constructs a new RCharacter_Outcast3Fat
    /// </summary>
    public RCharacter_Outcast3Fat(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCharacter_Outcast3Fat Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCharacter_Outcast3Fat(nint ptr) : base(ptr) { }

}
