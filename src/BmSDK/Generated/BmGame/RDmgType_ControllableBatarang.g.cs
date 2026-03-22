#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_ControllableBatarang<br/>
/// (size = 120)
/// (flags = 18)
/// </summary>
public partial class RDmgType_ControllableBatarang : BmSDK.BmGame.RDmgType_Batarang, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_ControllableBatarang", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_ControllableBatarang() { }

    /// <summary>
    /// Constructs a new RDmgType_ControllableBatarang
    /// </summary>
    public RDmgType_ControllableBatarang(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_ControllableBatarang Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_ControllableBatarang(nint ptr) : base(ptr) { }

}
