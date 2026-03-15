#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCharacter_Outcast4Fat<br/>
/// (size = 584)
/// (flags = 18)
/// </summary>
public partial class RCharacter_Outcast4Fat : BmSDK.BmScript.RCharacter_OutcastBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCharacter_Outcast4Fat", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCharacter_Outcast4Fat() { }

    /// <summary>
    /// Constructs a new RCharacter_Outcast4Fat
    /// </summary>
    public RCharacter_Outcast4Fat(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCharacter_Outcast4Fat Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCharacter_Outcast4Fat(nint ptr) : base(ptr) { }

}
