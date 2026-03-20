#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_Explosive_HeavyObject<br/>
/// (size = 216)
/// (flags = 18)
/// </summary>
public partial class RDmgType_Explosive_HeavyObject : BmSDK.BmGame.RDmgType_Explosive, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_Explosive_HeavyObject", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_Explosive_HeavyObject() { }

    /// <summary>
    /// Constructs a new RDmgType_Explosive_HeavyObject
    /// </summary>
    public RDmgType_Explosive_HeavyObject(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_Explosive_HeavyObject Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_Explosive_HeavyObject(nint ptr) : base(ptr) { }

}
