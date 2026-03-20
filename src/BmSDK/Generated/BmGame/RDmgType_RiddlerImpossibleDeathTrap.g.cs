#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_RiddlerImpossibleDeathTrap<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RDmgType_RiddlerImpossibleDeathTrap : BmSDK.BmGame.RDmgType_ElectricFloor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_RiddlerImpossibleDeathTrap", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_RiddlerImpossibleDeathTrap() { }

    /// <summary>
    /// Constructs a new RDmgType_RiddlerImpossibleDeathTrap
    /// </summary>
    public RDmgType_RiddlerImpossibleDeathTrap(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_RiddlerImpossibleDeathTrap Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_RiddlerImpossibleDeathTrap(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bAlwaysKO
    /// </summary>
    public unsafe bool bAlwaysKO
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 216) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 216); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 216); }
    }
}
