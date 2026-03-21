#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCharacter_RasSpectral<br/>
/// (size = 492)
/// (flags = 18)
/// </summary>
public partial class RCharacter_RasSpectral : BmSDK.BmScript.RCharacter_Ras, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCharacter_RasSpectral", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCharacter_RasSpectral() { }

    /// <summary>
    /// Constructs a new RCharacter_RasSpectral
    /// </summary>
    public RCharacter_RasSpectral(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCharacter_RasSpectral Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCharacter_RasSpectral(nint ptr) : base(ptr) { }

}
