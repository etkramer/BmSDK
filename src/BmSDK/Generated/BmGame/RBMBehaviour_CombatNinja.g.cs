#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_CombatNinja<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMBehaviour_CombatNinja : BmSDK.BmGame.RBMBehaviour_CombatAI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_CombatNinja", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_CombatNinja() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_CombatNinja
    /// </summary>
    public RBMBehaviour_CombatNinja(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_CombatNinja Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_CombatNinja(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bDestroyNextTick
    /// </summary>
    public unsafe bool bDestroyNextTick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1020) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1020); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1020); }
    }

    /// <summary>
    /// BoolProperty: bBeenInActiveCombat
    /// </summary>
    public unsafe bool bBeenInActiveCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1020) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1020); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1020); }
    }

    /// <summary>
    /// FloatProperty: TimeUntilNextCombatRoll
    /// </summary>
    public unsafe float TimeUntilNextCombatRoll
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }
}
