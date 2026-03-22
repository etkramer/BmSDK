#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCharacter_MadHatter_Code<br/>
/// (size = 408)
/// (flags = 67108882)
/// </summary>
public partial class RCharacter_MadHatter_Code : BmSDK.BmScript.RCharacter_MadHatter, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCharacter_MadHatter_Code", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCharacter_MadHatter_Code() { }

    /// <summary>
    /// Constructs a new RCharacter_MadHatter_Code
    /// </summary>
    public RCharacter_MadHatter_Code(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCharacter_MadHatter_Code Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCharacter_MadHatter_Code(nint ptr) : base(ptr) { }

}
