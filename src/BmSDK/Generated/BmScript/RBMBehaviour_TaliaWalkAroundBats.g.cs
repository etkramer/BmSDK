#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RBMBehaviour_TaliaWalkAroundBats<br/>
/// (size = 444)
/// (flags = 8210)
/// </summary>
public partial class RBMBehaviour_TaliaWalkAroundBats : BmSDK.BmScript.RBMBehaviour_HarleyWalkAroundBats, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RBMBehaviour_TaliaWalkAroundBats", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_TaliaWalkAroundBats() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_TaliaWalkAroundBats
    /// </summary>
    public RBMBehaviour_TaliaWalkAroundBats(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_TaliaWalkAroundBats Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_TaliaWalkAroundBats(nint ptr) : base(ptr) { }

}
