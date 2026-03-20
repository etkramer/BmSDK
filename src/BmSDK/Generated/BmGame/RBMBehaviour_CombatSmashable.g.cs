#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_CombatSmashable<br/>
/// (flags = 0)
/// </summary>
public partial class RBMBehaviour_CombatSmashable : BmSDK.BmGame.RBMBehaviour_CombatAI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_CombatSmashable", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_CombatSmashable() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_CombatSmashable
    /// </summary>
    public RBMBehaviour_CombatSmashable(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_CombatSmashable Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_CombatSmashable(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: DropBoxTimer
    /// </summary>
    public unsafe float DropBoxTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }
}
