#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCharacter_Ivy<br/>
/// (size = 408)
/// (flags = 18)
/// </summary>
public partial class RCharacter_Ivy : BmSDK.BmGame.RCharacter, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCharacter_Ivy", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCharacter_Ivy() { }

    /// <summary>
    /// Constructs a new RCharacter_Ivy
    /// </summary>
    public RCharacter_Ivy(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCharacter_Ivy Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCharacter_Ivy(nint ptr) : base(ptr) { }

}
