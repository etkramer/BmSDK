#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_FloorTakedownBatarang<br/>
/// (size = 216)
/// (flags = 0)
/// </summary>
public partial class RDmgType_FloorTakedownBatarang : BmSDK.BmGame.RDmgType_Batarang, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_FloorTakedownBatarang", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_FloorTakedownBatarang() { }

    /// <summary>
    /// Constructs a new RDmgType_FloorTakedownBatarang
    /// </summary>
    public RDmgType_FloorTakedownBatarang(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_FloorTakedownBatarang Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_FloorTakedownBatarang(nint ptr) : base(ptr) { }

}
