#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCharacter_MultiStageMilitia<br/>
/// (flags = 0)
/// </summary>
public partial class RCharacter_MultiStageMilitia : BmSDK.BmScript.RCharacter_MultiStage, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCharacter_MultiStageMilitia", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCharacter_MultiStageMilitia() { }

    /// <summary>
    /// Constructs a new RCharacter_MultiStageMilitia
    /// </summary>
    public RCharacter_MultiStageMilitia(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCharacter_MultiStageMilitia Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCharacter_MultiStageMilitia(nint ptr) : base(ptr) { }

}
