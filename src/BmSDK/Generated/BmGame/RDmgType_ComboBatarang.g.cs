#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_ComboBatarang<br/>
/// (size = 120)
/// (flags = 18)
/// </summary>
public partial class RDmgType_ComboBatarang : BmSDK.BmGame.RDmgType_Batarang, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_ComboBatarang", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_ComboBatarang() { }

    /// <summary>
    /// Constructs a new RDmgType_ComboBatarang
    /// </summary>
    public RDmgType_ComboBatarang(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_ComboBatarang Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_ComboBatarang(nint ptr) : base(ptr) { }

}
