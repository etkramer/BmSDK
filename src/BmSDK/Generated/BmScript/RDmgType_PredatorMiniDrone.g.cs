#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RDmgType_PredatorMiniDrone<br/>
/// (size = 220)
/// (flags = 18)
/// </summary>
public partial class RDmgType_PredatorMiniDrone : BmSDK.BmGame.RDmgType_Electricity, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RDmgType_PredatorMiniDrone", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_PredatorMiniDrone() { }

    /// <summary>
    /// Constructs a new RDmgType_PredatorMiniDrone
    /// </summary>
    public RDmgType_PredatorMiniDrone(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_PredatorMiniDrone Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_PredatorMiniDrone(nint ptr) : base(ptr) { }

}
