#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_DodgeFallingCasualty<br/>
/// (size = 432)
/// (flags = 8210)
/// </summary>
public partial class RBMBehaviour_DodgeFallingCasualty : BmSDK.BmGame.RBMBehaviour_Startle, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_DodgeFallingCasualty", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_DodgeFallingCasualty() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_DodgeFallingCasualty
    /// </summary>
    public RBMBehaviour_DodgeFallingCasualty(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_DodgeFallingCasualty Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_DodgeFallingCasualty(nint ptr) : base(ptr) { }

}
