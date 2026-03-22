#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCharacter_GuardBM2_Tiger3_Glasses<br/>
/// (size = 428)
/// (flags = 18)
/// </summary>
public partial class RCharacter_GuardBM2_Tiger3_Glasses : BmSDK.BmScript.RCharacter_GuardBM2_Tiger3, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCharacter_GuardBM2_Tiger3_Glasses", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCharacter_GuardBM2_Tiger3_Glasses() { }

    /// <summary>
    /// Constructs a new RCharacter_GuardBM2_Tiger3_Glasses
    /// </summary>
    public RCharacter_GuardBM2_Tiger3_Glasses(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCharacter_GuardBM2_Tiger3_Glasses Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCharacter_GuardBM2_Tiger3_Glasses(nint ptr) : base(ptr) { }

}
