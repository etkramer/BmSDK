#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_CombatHeavyObject<br/>
/// (flags = 0)
/// </summary>
public partial class RBMBehaviour_CombatHeavyObject : BmSDK.BmGame.RBMBehaviour_CombatAI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_CombatHeavyObject", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_CombatHeavyObject() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_CombatHeavyObject
    /// </summary>
    public RBMBehaviour_CombatHeavyObject(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_CombatHeavyObject Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_CombatHeavyObject(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: DropBoxTimer
    /// </summary>
    public unsafe float DropBoxTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }
}
