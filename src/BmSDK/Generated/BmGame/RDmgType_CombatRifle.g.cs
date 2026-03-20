#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_CombatRifle<br/>
/// (flags = 0)
/// </summary>
public partial class RDmgType_CombatRifle : BmSDK.BmGame.RDmgType_Rifle, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_CombatRifle", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_CombatRifle() { }

    /// <summary>
    /// Constructs a new RDmgType_CombatRifle
    /// </summary>
    public RDmgType_CombatRifle(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_CombatRifle Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_CombatRifle(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: StaggerBatmanRange
    /// </summary>
    public unsafe float StaggerBatmanRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }
}
